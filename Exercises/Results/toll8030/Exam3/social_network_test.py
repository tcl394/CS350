#social_network_test

from social_network import new_person, get_friends, add_friend, del_friend, get_topics, add_topic, del_topic, system_export, system_import

#PERSON
def test_new_person():
    new_person("toll8030")
    new_person("meme1234")
    new_person("boom0001")
    return

#FRIEND
def test_new_friend():
    friendID1 = "meme1234"
    add_friend("toll8030", friendID1)
    friendID2 = "boom0001"
    add_friend("toll8030", friendID2)
    return
def test_friends_list():
    get_friends("toll8030")
    return
def test_remove_friend():
    del_friend("toll8030", "meme1234")
    return

#POST
def test_new_topic():
    topic1 = "hello"    
    add_topic("toll8030", "meme1234", topic1)
    topic2 = "I am typing"
    add_topic("toll8030", "boom0001", topic2)
    return
def test_topics_list():
    get_topics("toll8030")
    return
def test_remove_topic():
    del_topic("toll8030", "meme1234","hello")
    return

#SYSTEM
def test_export():
    system_export()
    return

def test_import():
    system_import()
    return

#RUN TEST
if __name__ == '__main__' :

    test_new_person()
    test_new_friend()
    print()
    test_friends_list()
    print()
    test_remove_friend()
    print()
    test_new_topic()
    print()
    test_topics_list()
    print()
    test_remove_topic()
    print()
    test_export()
    print()
    test_import()
