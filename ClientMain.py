import Client
import time
print "welcone new client to dan's cloud"
print "you can use our of cloud saving and sharing from everywhere"
a=Client.Communication()
a.sendmsg()

msg=a.recvmsg()
#time.sleep(1)
while msg!="Server response: close":
    print msg
    if msg!="Server response: register":
        if msg=="password is good":
            a.client_socket.send("ack")
        elif msg=="password is not good please try again":
            a.registerpass()
        elif msg=="Server response: username not good please try again":
            a.registeru()
            a.registerpass()
    if msg=="Server response: login":
        a.loginu()
        a.loginpass()
        if msg=="Server response: login username not good please try again":
            a.loginu()
        elif msg=="Server response: login password not good please try again":
            a.loginpass()
        else:
            a.sendmsg()
    else:

        a.registeru()
        a.registerpass()


    msg=a.recvmsg()



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

