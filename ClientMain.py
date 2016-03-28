import Client
import time
print "welcone new client to dan's cloud"
print "you can use our of cloud saving and sharing from everywhere"
a=Client.Communication()
a.sendmsg()
u=Client.ClientFilesManager()

msg=a.recvmsg()
#time.sleep(1)
while msg != "Server response: close":
    print msg
    if msg == "Server response: register":
        a.registeru()
        a.registerpass()
    elif msg == "password is good":
        a.client_socket.send("ack")
    elif msg == "password is not good please try again":
        a.registerpass()
    elif msg == "Server response: username not good please try again":
        a.registeru()
        a.registerpass()
    elif msg == "Server response: login":
        a.loginu()
        msg=a.client_socket.recv(1024)
        print msg
        a.loginpass()
        print "after pass"
        msg=a.client_socket.recv(1024)
        print "recieved after pass"
        print msg
        if msg == "Server response: login username not good please try again":
            a.loginu()
        elif msg == "Server response: login password not good please try again":
            a.loginpass()

    elif msg == "Server response: uploadfiles":
        print '1'
        u.uploadfile()
        print '2'
    elif msg == "Server response: deletefile":
        u.deletefile()
    else:
        print "unknown msg"


    msg = a.recvmsg()



a.disconnect()

"""true=True
while true:
    b=raw_input("enter: ")
    if b=="disconnect":
        x=Client.Communication().disconnect()
        if x=='n':
            Client.Presentation().showfiles()
        elif x=='y':
            true=False"""

