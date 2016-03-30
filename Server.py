#region ----------   IMPORTS   -----------------------------
import threading
import socket
from socket import *
import select
import thread
import re
import PIL
import PIL.Image
import PIL.ImageFont
import PIL.ImageOps
import PIL.ImageDraw
import os
import sqlite3 as lite
import sys
import os .path
import time
import struct
#endregion

BUFF = 1024
HOST = '0.0.0.0'# must be input parameter @TODO
PORT = 1237 # must be input parameter @TODO
SessionList=[]

server_socket=socket()

class Communication:

    def response(self, key):
        return 'Server response: ' + key

    def Thread_Handler(self, clientsock, addr):
        while 1:
            data = clientsock.recv(BUFF)
            #if not data: break
            print repr(addr) + ' recv:' + repr(data)
            clientsock.send(self.response(data))
            print repr(addr) + ' sent:' + repr(self.response(data))
            if "close" == data.rstrip(): break # type 'close' on client console to close connection from the server side
            if "register"==data.rstrip():
                r=Register()
                username=r.Register(clientsock)
                print username
                while username==False:
                    clientsock.send(self.response("username not good please try again"))
                    username = clientsock.recv(BUFF)
                """info = clientsock.Recv(BUFF)
                info = info.split("#")
                state = info[0]
                print state
                username=r.Register(clientsock)

                username = info[1]
                password = info[2]

                uname_exists = DBManager().UnameExists(username)[0]

                if not uname_exists:
                    DBManager().AddInfo(username, password)
                    message = "Signed up"
                    self.Send(Communication.response(message))
                else:
                    message = "username exists"
                    self.Send(message)#name not good please try again"))
                    #username = clientsock.recv(BUFF)"""
                print "opening a new folder with username"
                r.openfolder(username)
                clientsock.send(self.response("a folder with your name opend in server"))
            elif "login"==data.rstrip():
                l=Login()
                username = clientsock.recv(BUFF)
                clientsock.send(self.response("username recived"))
                password = clientsock.recv(BUFF)
                answer=l.Login(username,password)
                if answer:
                    clientsock.send("login good")
                    print "client signd in"
                else:
                    clientsock.send("login not good")
                    print "client not signd in"
            elif "uploadfiles"==data.rstrip():
                print '1'
                u=FilesManager()
                clientsock.send(self.response("uploadfiles"))
                print '2'
                username=clientsock.recv(1024)
                clientsock.send("got username")
                u.recvanduploadfile(clientsock,username)
                """filename = clientsock.recv(BUFF)
                print '3'
                print usernamefilename
                a=usernamefilename.split('#')
                print '5'
                print a
                username=a[0]
                filename=a[1]
                ans=u.uploadfile(username,filename)
                if ans=='ok':
                    clientsock.send("file uploaded")
                print '6'"""
            elif "deletfile"==data.rstrip():
                clientsock.send(self.response("deletefile"))
                usernamefilename=clientsock.recv(BUFF)
                print usernamefilename
                a=usernamefilename.split('#')
                user=a[0]
                name=a[1]
                u.deletefile(user,name)






        clientsock.close()
        print addr, "- closed connection" #log on console

    def listener(self):
        """ADDR = (HOST, PORT)
        serversock = socket(AF_INET, SOCK_STREAM)
        serversock.setsockopt(SOL_SOCKET, SO_REUSEADDR, 1)
        serversock.bind(ADDR)
        serversock.listen(5)
        while 1:
            print 'waiting for connection... listening on port', PORT
            clientsock, addr = serversock.accept()
            print '1'
            print '...connected from:', addr
            thread.start_new_thread(Communication().Thread_Handler, (clientsock, addr))
            #port2=a.find()
            #print port2
            #SessionManager().addnewsession(a,con)
            #SessionManager().printlist()
"""
        print __name__

        print '1'
        ADDR = (HOST, PORT)
        serversock = socket(AF_INET, SOCK_STREAM)
        serversock.setsockopt(SOL_SOCKET, SO_REUSEADDR, 1)
        serversock.bind(ADDR)
        serversock.listen(5)
        while 1:
            print 'waiting for connection... listening on port', PORT
            clientsock, addr = serversock.accept()
            print '...connected from:', addr
            thread.start_new_thread(Communication().Thread_Handler, (clientsock, addr))
            #port2=a.find()
            #print port2
            #SessionManager().addnewsession(a,con)
            #SessionManager().printlist()


    def recvbuff(self):
        t=None
    def Sendbuff(self):
        return 0
    def CloseServer(self):
        server_socket.close()



class SessionManager:
    open_client_sockets={}
    def addnewsession(self,addr,con):    #adds a session to open_client_socket(list)

        SessionManager.open_client_sockets[addr]=con
        print
    def disconnect(self,addr):

        SessionManager.open_client_sockets[addr]=-1
        #SessionManager.open_client_sockets.pop(session,SessionManager.open_client_sockets[session])
    def upload(self,filename,content):
        f = open(filename ,content)
        while True:
            data=Communication.recvbuff()

    def printlist(self):
        for session in SessionManager.open_client_sockets:
            print session
            print SessionManager.open_client_sockets[session]

class FilesManager:
    def uploadfile(self,username,name):
        print '7'
        pathtosave = r"C:\\Users\\dan\\Desktop\\usersofcloud\\"+username+'\\myfiles'
        print '8'
        filename = os.path.join(pathtosave,name)
        filename=open(filename,'w')
        print '9'
        return 'ok'
    def recvanduploadfile(self,clientsock,username):
        pathtosave = r"C:\\Users\\dan\\Desktop\\usersofcloud\\"+username+'\\myfiles'
        data = clientsock.recv(1024)
        filename,length = data.split("@",1)
        clientsock.send("ack")
        length=int(length)
        fulldata= clientsock.recv(length)
        filename=os.path.basename(filename)

        with open(os.path.join(pathtosave,filename), "wb") as f:
            f.write(fulldata)

    def deletefile(self,username,name):
        pathtodel = r"C:\\Users\\dan\\Desktop\\usersofcloud\\"+username+'\\myfiles\\'
        #filename = 'forcing{0}damping{1}omega{2}set2.png'.format(forcing, damping, omega)
        filename = os.path.join(pathtodel,name)
        os.remove(filename)

class ConvertFiles:
    def txtconvert(self):
        t=None
    def imageconvert(self,path):
        PIXEL_ON = 0  # PIL color to use for "on"
        PIXEL_OFF = 255  # PIL color to use for "off"


        def main():
            image = text_image(path)
            image.show()
            image.save(path)


        def text_image(text_path, font_path=None):
            """Convert text file to a grayscale image with black characters on a white background.
            arguments:
            text_path - the content of this file will be converted to an image
            font_path - path to a font file (for example impact.ttf)
            """
            grayscale = 'L'
            # parse the file into lines
            with open(text_path) as text_file:  # can throw FileNotFoundError
                lines = tuple(l.rstrip() for l in text_file.readlines())

            # choose a font (you can see more detail in my library on github)
            large_font = 20  # get better resolution with larger size
            font_path = font_path or 'cour.ttf'  # Courier New. works in windows. linux may need more explicit path
            try:
                font = PIL.ImageFont.truetype(font_path, size=large_font)
            except IOError:
                font = PIL.ImageFont.load_default()
                print('Could not use chosen font. Using default.')

            # make the background image based on the combination of font and lines
            pt2px = lambda pt: int(round(pt * 96.0 / 72))  # convert points to pixels
            max_width_line = max(lines, key=lambda s: font.getsize(s)[0])
            # max height is adjusted down because it's too large visually for spacing
            test_string = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ'
            max_height = pt2px(font.getsize(test_string)[1])
            max_width = pt2px(font.getsize(max_width_line)[0])
            height = max_height * len(lines)  # perfect or a little oversized
            width = int(round(max_width + 40))  # a little oversized
            image = PIL.Image.new(grayscale, (width, height), color=PIXEL_OFF)
            draw = PIL.ImageDraw.Draw(image)

            # draw each line of text
            vertical_position = 5
            horizontal_position = 5
            line_spacing = int(round(max_height * 0.8))  # reduced spacing seems better
            for line in lines:
                draw.text((horizontal_position, vertical_position),line, fill=PIXEL_ON, font=font)
                vertical_position += line_spacing
            # crop the text
            c_box = PIL.ImageOps.invert(image).getbbox()
            image = image.crop(c_box)
            return image
        if __name__ == '__main__':
            main()



class Login:
    def Login(self,username,password):
        if DBManager().isloginexsits(username,password):
            return True
        else:
            return False
class Register:
    def Register(self,clientsock):
        #clientsock.send("please enter a username: ")
        username=clientsock.recv(1024)
        """if DBManager().isexists(username)==False:
            return False"""
        """if username in database already the server will ask the client to enter a new username(will be added when therews a database)"""
        #ans=DBManager().IsExists(username)
        #while ans==True:
            #username=clientsock.recv(1024)
        #clientsock.send("please enter a password: ")
        x=False
        while x==False:
            password=clientsock.recv(1024)
            print PasswordPolicy().passlength(password)
            print PasswordPolicy().iscomplicated(password)
            if (PasswordPolicy().passlength(password) and PasswordPolicy().iscomplicated(password)):
                clientsock.send("password is good")
                x=True
                answer=DBManager().Connect(username,password)
                if answer==True:
                    return username
                else:
                    return False
            else:
                clientsock.send("password is not good please try again")

    def openfolder(self,username):
        newpath = r"C:\\Users\\dan\\Desktop\\usersofcloud\\"+username
        if not os.path.exists(newpath):
            os.makedirs(newpath)
            secondpath=r"C:\\Users\\dan\\Desktop\\usersofcloud\\"+username+'\\myfiles'
            thirdpath=r"C:\\Users\\dan\\Desktop\\usersofcloud\\"+username+'\\sharedfiles'
            os.makedirs(secondpath)
            os.makedirs(thirdpath)

class PasswordPolicy:
    def passlength(self,password):    #checks if the password is in the length given in configuration manager
        length=len(password)
        if length>=ConfigurationManager.passwordlength:
            return True
        else:
            return  False
    def iscomplicated(self,password):    #checks if the password needs to be complicated(according to configuration manager) if so checks numbers letters and big letters
        #if ConfigurationManager.passwordcomplicated==True:
        answer = re.match(r'^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$', password)
        if answer is not None:
            return  True
        else:
            return False





class Authentication:
    def IsValidUser(self):
        t=None
    def IsValidPass(self,password):
        t=None
    def IsValidPassOfNewUser(self,password): #for new sighnd user checks if password True in all criteria in configuration manager
        answer=PasswordPolicy.passlength(password)
        if ConfigurationManager.passwordcomplicated==True:
            answer2= PasswordPolicy.iscomplicated(password)
        if answer==True and answer2==True:
            return True


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
    passwordcomplicated=True
    passwordlength=8
    def GetMaxconnection(self):
        return ConfigurationManager.__ConfigurationManager.maxcount
    class __ConfigurationManager:
        maxcount=6
        def __init__(self, arg):
            self.val = arg
        def __str__(self):
            return repr(self) + self.val
        def iscomplicated(self):
            return ConfigurationManager.passwordcomplicated
        def passwordlength(self):
            return  ConfigurationManager.passwordlength
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
    #con = lite.connect('usersandpass.db')
    #cur = con.cursor()
    def isexists(self,username):
        con = lite.connect('usersandpass.db')
        cur = con.cursor()

        cur.execute("SELECT username FROM users WHERE username = ?", (username,))
        data = cur.fetcone()
        if data!=None:
            return True
        else:
            return False
    def isloginexsits(self , username,password):
        con = lite.connect('usersandpass.db')
        cur = con.cursor()

        cur.execute("SELECT username FROM users WHERE username = ? and password =?", (username,password))
        data = cur.fetchone()
        if data==None:
            return False
        else:
            return True
    def ReadAllRows(self):
        conn = lite.connect('usersandpass.db')
        c = conn.cursor()
        c.execute("SELECT * FROM UserInfo")
        rows = c.fetchall()
        temp = rows
        rows = []
        for row in temp:
            data_string = str(row[0]) + "@" + row[1][1:-1] + "@" + row[2][1:-1] + \
                "@" + row[3][1:-1] + "@" + row[4][1:-1]
            ##uid@fname@lname@uname#.....
            rows.append(data_string)

        conn.commit()
        conn.close()
        return rows

    def UnameExists(username):
        rows = DBManager().ReadAllRows()
        for row in rows:
            if username in row:
                return (True, row)
        return (False, )


    def Connect(self,username,password):#enters a new user to databse1(of users and passwords
        con = lite.connect('usersandpass.db')
        cur = con.cursor()

        cur.execute("CREATE TABLE if not exists users(username TEXT, password TEXT)")
        #if DBManager().isexists(username):
        with con:
            cur.execute("INSERT INTO users VALUES (?, ?);", (username, password))
            #return True
        #else:
        return  True


    def Save(self):
        t=None
    def Delete(self):
        t=None
    def Update(self):
        t=None
    def Disconnect(self):
        t=None


"""class Pipes:
    f = open(r'\\.\pipe\connect', 'r+b', 0)
    i = 1

    while True:
        s = 'Message[{0}]'.format(i)
        i += 1

        f.write(struct.pack('I', len(s)) + s)   # Write str length and str
        f.seek(0)                               # EDIT: This is also necessary
        print 'Wrote:', s

        n = struct.unpack('I', f.read(4))[0]    # Read str length
        s = f.read(n)                           # Read str
        f.seek(0)                               # Important!!!
        print 'Read:', s

        time.sleep(2)
"""
class LogManager:
    def WriteAction(self):
        t=None

class Presention:
    def InitFileToPresent(self):
        t=None