import Client
import socket
import time
print "welcone new client to dan's cloud"
print "you can use our of cloud saving and sharing from everywhere"
a=Client.Communication()
port2=1238
host='0.0.0.0'
#listen=Client.ServerComGUI().listener()
ADDR = (host, port2)
serversock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
serversock.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
serversock.bind(ADDR)
serversock.listen(1)
clientsock, addr = serversock.accept()
print 'waiting for connection... listening on port', port2
print '...connected from:', addr
#a=Communication()
msg=clientsock.recv(1024)
print msg
a.client_socket.send(msg)
msg=a.recvmsg()
#a.registeru()
#a.registerpass()
#a.sendmsg()
u=Client.ClientFilesManager()

#msg=a.recvmsg()
print msg
#time.sleep(1)
while msg != "Server response: close":
    print msg
    if msg == "Server response: register":
        print 1
        a.registeru(clientsock)
        print 2

        a.registerpass(clientsock)
        print 3
    elif msg == "password is good":
        a.client_socket.send("ack")
    elif msg == "password is not good please try again":
        a.registerpass()
    elif msg == "Server response: username not good please try again":
        a.registeru(clientsock)
        a.registerpass(clientsock)
    elif msg == "Server response: login":
        a.loginu(clientsock)
        msg=a.client_socket.recv(1024)
        print msg
        a.loginpass(clientsock)
        print "after pass"
        msg=a.client_socket.recv(1024)
        print "recieved after pass"
        print msg
        if msg=="login not good":
            clientsock.send("login not good")
        elif msg=="login good":
            clientsock.send("login good")
            username=clientsock.recv(1024)
            a.client_socket.send(username)
            listoffiles=a.client_socket.recv(1024)
            clientsock.send(listoffiles)
            """a.sendmsg()"""
        """if msg == "Server response: login username not good please try again":
            a.loginu()
        elif msg == "Server response: login password not good please try again":
            a.loginpass()"""

    elif msg == "Server response: uploadfiles":
        print '1'
        clientsock.send("ack")
        username=clientsock.recv(1024)
        clientsock.send("ack")
        filename=clientsock.recv(1024)
        u.uploadfile(username,filename,a)
        print '2'
        msg=a.client_socket.recv(1024)
    elif msg == "Server response: deletefile":
        clientsock.send("ack")
        username=clientsock.recv(1024)
        clientsock.send("ack")
        name=clientsock.recv(1024)
        u.deletefile(username,name,a)
    else:
        print "unknown msg"
        #a.sendmsg()
    clientsock.send("ack")
    msg=clientsock.recv(1024)
    print msg
    a.client_socket.send(msg)
    msg=a.recvmsg()
    #msg = a.recvmsg()



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