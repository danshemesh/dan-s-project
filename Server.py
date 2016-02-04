import threading
import socket
import select

server_socket=socket.socket()
class Communication:
    SessionList=[]
    def Thread_Handler(self, con, addr):
        print addr

    def listener(self):
        Port=1234
        count=0
        server_socket.bind(('0.0.0.0',Port))
        server_socket.listen(5)
        """while count<ConfigurationManager.GetMaxconnection():
        rlist, wlist, xlist=select.select([server_socket]+SessionManager.open_client_sockets, SessionManager.open_client_sockets,[])
        for csocket in rlist:
            if csocket is server_socket:
                (new_socket, address)=server_socket.accept()
                SessionManager.open_client_sockets.append(new_socket)
                print "connection made"""""
        while 1:
            con, addr =server_socket.accept()

            th = threading.Thread(target=Communication.Thread_Handler,args=(con, addr,))
            x=con.recv(1024)
            print x
            SessionManager().addnewsession(addr)
            SessionManager().printlist()

    def recvbuff(self):
        t=None
    def Sendbuff(self):
        return 0
    def CloseServer(self):
        server_socket.close()



class SessionManager:
    open_client_sockets=[]
    def addnewsession(self,addr):
        SessionManager.open_client_sockets.append(addr)
    def disconnect(self,addr):
        for session in SessionManager.open_client_sockets:
            if session==addr:
                SessionManager.open_client_sockets.remove(session)
    def upload(self,filename,content):
        f = open(filename ,content)
        while True:
            data=Communication.recvbuff()
    def printlist(self):
        for session in SessionManager.open_client_sockets:
            print session




class Login:
    def Login(self):
        t=None
class Register:
    def Register(self):
        t=None
class PasswordPolicy:
    def IsStrongPass(self):
        t=None
class Authentication:
    def IsValidUser(self):
        t=None
    def IsValidPass(self):
        t=None
class TokenManager:
    Listofactivetokens=[]
    def GenarateRandId(self):
        t=None
class Encryption:
    def Encrypt(self):
        t=None
    def Decrypt(self):
        t=None
    def Sign(self):
        t=None
    def Verify(self):
        t=None

class KeyManager:
    def GenerateKey(self):
        t=None
    def RecvKey(self):
        t=None
    def StoreKey(self):
        t=None
    def Exchange(self):
        t=None

class ConfigurationManager:
    def GetMaxconnection(self):
        return ConfigurationManager.__ConfigurationManager.maxcount
    class __ConfigurationManager:
        maxcount=6
        def __init__(self, arg):
            self.val = arg
        def __str__(self):
            return repr(self) + self.val
    instance = None
    def __init__(self, arg):
        if not ConfigurationManager.instance:
            ConfigurationManager.instance = ConfigurationManager.__ConfigurationManager(arg)
        else:
            ConfigurationManager.instance.val = arg
    def __getattr__(self, name):
        return getattr(self.instance, name)

    def IsSsl(self):
        t=None
    def IsEncData(self):
        t=None

class AuthorizationManager:
    def IsOwner(self):
        t=None
    def IsShared(self):
        t=None
    def OperationStatus(self):
        t=None

class ProfileManager:
    username=''
    id=''


class DBManager:
    def Connect(self):
        t=None
    def Save(self):
        t=None
    def Delete(self):
        t=None
    def Update(self):
        t=None
    def Disconnect(self):
        t=None

class LogManager:
    def WriteAction(self):
        t=None

class Presention:
    def InitFileToPresent(self):
        t=None


