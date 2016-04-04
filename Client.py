#region ----------   IMPORTS   -----------------------------
import socket
import  os
#endregion
host='0.0.0.0'
Port=1237
port2=1238

"""class ServerComGUI:
    def listener(self):
        ADDR = (host, port2)
        serversock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        serversock.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
        serversock.bind(ADDR)
        serversock.listen(1)
        clientsock, addr = serversock.accept()
        print 'waiting for connection... listening on port', port2
        print '...connected from:', addr
        a=Communication()
        msg=clientsock.recv(1024)
        print msg
        a.registeru()
        a.registerpass()"""


class Communication():
    def __init__(self):
        self.client_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        self.client_socket.connect(('127.0.0.1', Port))
        """    def connect(self):#1
        t=None"""

    def sendmsg(self):
        msg=raw_input("enter: ")
        self.client_socket.send(msg)
    def recvmsg(self):
        response=self.client_socket.recv(1024)
        return response
    def registeru(self,clientsock):
        msg=clientsock.recv(1024)
        print msg
        self.client_socket.send(msg)
    def registerpass(self,clientsock):
        msg=clientsock.recv(1024)
        print msg
        self.client_socket.send(msg)
    def disconnect(self):
        #print "are you sure you want to disconnect? y/n"
        #a = raw_input("enter your answer: ")
        #if a == 'n':
        #    self.client_socket.send("disconnect")
        #    return 'n'
        #elif a == 'y':
        print "you are now disconnecting from the system"
        print "thank you for using dan's cloud"
        self.client_socket.close()
        #    return 'y'
    def loginu(self,clientsock):
        msg=clientsock.recv(1024)
        self.client_socket.send(msg)
    def loginpass(self,clientsock):
        msg=clientsock.recv(1024)
        self.client_socket.send(msg)




class UserForm:
    def requestnewuser(self):
        t=None


class Presentation:
    def recieveutemstoshow(self):
        t=None
    def recvndupload(self,name,path,c):
        c.client_socket.send(name)
        data = c.client_socket.recv(1024)
        filename,length = data.split("@",1)
        c.client_socket.send("ack")
        length=int(length)
        fulldata= c.client_socket.recv(length)
        filename=os.path.basename(filename)

        with open(os.path.join(path,filename), "wb") as f:
            f.write(fulldata)

    def showfiles(self):
        t=None
class ClientFilesManager:
    def uploadfile(self,username,filename,c):

        c.client_socket.send(username)
        #print ms
        #msg3=msg+'#'+msg2
        #print msg3
        a=c.client_socket.recv(1024)
        f=open(filename,'rb')
        size=os.path.getsize(filename)
        content=f.read(size)
        c.client_socket.send(filename + "@"+str(size))
        c.client_socket.recv(1024)
        c.client_socket.send(content)
    def syncfile(self):
        t=None
    def editfile(self):
        t=None
    def deletefile(self,username,name,c):
        print '2'
        msg3=username+"@"+name

        print '3'
        print msg3
        c.client_socket.send(msg3)
        print '4'
    def copyfile(self):
        t=None
class ConfigurationMamanager:
    def cipher(self):
        t=None
    def hashtype(self):
        t=None
    def keylength(self):
        t=None
class TokenManager:
    t=None

