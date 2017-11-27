#social_network

#PERSON
def new_person(userID):
    with open(userID+'_friends.txt', 'w+') as f:
        f.write(userID+' FRIENDS\n')
    with open(userID+'_topics.txt', 'w+') as f:
        f.write(userID+' TOPICS\n')
    with open('users.txt', 'a+') as f:
        f.write(userID+'\n')
    return

#FRIEND
def get_friends(userID):
    with open(userID+'_friends.txt', 'r') as f:
        print('----------')
        for line in f:
            print(line)
        print('----------')
    return

def add_friend(userID, friendID):
    with open(userID+'_friends.txt', 'a') as f:
        f.write(friendID+'\n')
        print(friendID+" added")
    return

def del_friend(userID, friendID):
    with open(userID+'_friends.txt', 'r') as f:
        lines = f.readlines()
    with open(userID+'_friends.txt', 'w') as f:
        for line in lines:
            if line != friendID+'\n':
                f.write(line)
    print(friendID+' removed')
    return

#POST
def get_topics(userID):
    with open(userID+'_topics.txt', 'r') as f:
        print('----------')
        for line in f:
            print(line)
        print('----------')
    return

def add_topic(userID, friendID, topic):
    with open(userID+'_topics.txt', 'a') as f:
        f.write(friendID+'- '+topic+'\n')
    print('New Topic from ' +friendID+'- '+topic)
    return

def del_topic(userID, friendID, topic):
    with open(userID+'_topics.txt', 'r') as f:
        lines = f.readlines()
    with open(userID+'_topics.txt', 'w') as f:
        for line in lines:
            if line != friendID+'- '+topic+'\n':
                f.write(line)
    print('Topic removed')
    return


#SYSTEM
def system_export():
    with open('users.txt', 'r') as f:
        users = f.readlines()
    for user in users:
        user = user[:-1]
        with open(user+'_friends.txt', 'r') as f:
            lines = f.readlines()
        with open('system_export.txt', 'a+') as f:
            f.write(user+'_ _\n')
            for line in lines:
                    f.write(line)
                    f.write('\n')
        with open(user+'_topics.txt', 'r') as f:
            lines = f.readlines()
        with open('system_export.txt', 'a+') as f:
            for line in lines:
                    f.write(line)
    print('System export file created')
    return

def system_import():
    with open('system_export.txt', 'r') as f:
        lines = f.readlines()
    for line in lines:   
        if line[-4:] == '_ _\n':
            userID = line[:-4]
            with open(userID+'_friends.txt', 'w+') as f:
                i=1
                while line != userID+' TOPICS':
                    line = lines[lines.index(line)+i]
                    f.write(lines[lines.index(line)+i])
                    i=i+1
            with open(userID+'_topics.txt', 'w+') as f:
                f.write(userID+' TOPICS\n')


        

    print('System imported files')
    return


