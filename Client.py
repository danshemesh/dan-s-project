#region ----------   IMPORTS   -----------------------------
import socket
import  os
#endregion

Port=1237

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


class UserForm:
    def requestnewuser(self):
        t=None
    def login(self):
        t=None
class Presentation:
    def recieveutemstoshow(self):
        t=None
    def showfiles(self):
        t=None
class ClientFilesManager:
    def syncfile(self):
        t=None
    def editfile(self):
        t=None
    def deletefile(self):
        t=None
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



