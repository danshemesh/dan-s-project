#region ----------   IMPORTS   -----------------------------
import socket
#endregion

Port=1237
client_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
client_socket.connect(('127.0.0.1', Port))
class Communication:
    def connect(self):
        client_socket.send(raw_input("enter: "))
        response=client_socket.recv(1024)
        print response
    def disconnect(self):
        print "are you sure you want to disconnect? y/n"
        a = raw_input("enter your answer: ")
        if a == 'n':
            client_socket.send("disconnect")
            return 'n'
        elif a == 'y':
            client_socket.close()
            return 'y'

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



