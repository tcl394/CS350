#include <stdio.h>
#include <string>
#include <vector>
#include <queue>
#include <fstream>  
#include <iostream>  
#include <sstream>
#include <iterator>
#include <algorithm>
#include <set>

class BkTree {
    public:
        BkTree();
        ~BkTree();
        void insert(std::string m_item);
        void get_friends(std::string center, std::deque<std::string>& friends);
    private:
        size_t EditDistance( const std::string &s, const std::string &t );
        struct Node {
            std::string m_item;
            size_t m_distToParent;
            Node *m_firstChild;
            Node *m_nextSibling;
            Node(std::string x, size_t dist);        
            bool visited;
            ~Node();
        };
        Node *m_root;
        int   m_size;
    protected:
};

BkTree::BkTree() {
    m_root = NULL; 
    m_size = 0;
}

BkTree::~BkTree() { 
    if( m_root ) 
        delete m_root; 
}

BkTree::Node::Node(std::string x, size_t dist) {
    m_item         = x;
    m_distToParent = dist;
    m_firstChild   = m_nextSibling = NULL;
    visited        = false;
}

BkTree::Node::~Node() {
    if( m_firstChild ) 
        delete m_firstChild;
    if( m_nextSibling ) 
        delete m_nextSibling;
}

void BkTree::insert(std::string m_item) {
    if( !m_root ){
        m_size = 1;
        m_root = new Node(m_item, -1);
        return;
    }
    Node *t = m_root;
    while( true ) {
        size_t d = EditDistance( t->m_item, m_item );
        if( !d ) 
            return;
        Node *ch = t->m_firstChild;
        while( ch ) {
            if( ch->m_distToParent == d ) { 
                t = ch; 
                break; 
            }
            ch = ch->m_nextSibling;
        }
        if( !ch ) {
            Node *newChild = new Node(m_item, d);
            newChild->m_nextSibling = t->m_firstChild;
            t->m_firstChild = newChild;
            m_size++;
            break;
        }
    }
}

size_t BkTree::EditDistance( const std::string &left, const std::string &right ) {
    size_t asize = left.size();
    size_t bsize = right.size();
    std::vector<size_t> prevrow(bsize+1);
    std::vector<size_t> thisrow(bsize+1);

    for(size_t i = 0; i <= bsize; i++)
        prevrow[i] = i;

    for(size_t i = 1; i <= asize; i ++) {
        thisrow[0] = i;
        for(size_t j = 1; j <= bsize; j++) {
            thisrow[j] = std::min(prevrow[j-1] + size_t(left[i-1] != right[j-1]), 
                    1 + std::min(prevrow[j],thisrow[j-1]) );
        }
        std::swap(thisrow,prevrow);
    }
    return prevrow[bsize];
}

void BkTree::get_friends(std::string center, std::deque<std::string>& flv) {
    if( !m_root ) return ;
    std::queue< Node* > q;
    q.push( m_root );

    while( !q.empty() ) {
        Node *t = q.front(); 
        q.pop();
        if ( !t ) continue;
        size_t d = EditDistance( t->m_item, center );
        if( d == 1 ) { 
            if ( t->visited == false ) {
                flv.push_back(t->m_item);
                t->visited = true;
            }
        }
        Node *ch = t->m_firstChild;
        q.push(ch);
        while( ch ) {
            if( ch->m_distToParent >=  1 )
                q.push(ch);
            ch = ch->m_nextSibling;
        }
    }
    return;
}

int main( int argc, char **argv ) {
    BkTree *pDictionary = new BkTree();

    std::ifstream dictFile("word.list");
    std::string line; 
    if (dictFile.is_open()) {
        while (! dictFile.eof() ) {               
            std::getline (dictFile,line);
            if ( line.size()) {
                pDictionary->insert(line);
            }
        }
        dictFile.close();
    }
    std::deque<std::string>  flq;
    pDictionary->get_friends("aa", flq);
    int counter = 0;
    while ( !flq.empty()) {
        counter++;
        std::string nf = flq.front();
        flq.pop_front();
        pDictionary->get_friends(nf, flq);
    } 
    std::cout << counter << std::endl;
    return 0;
}
