import Client
print "welcone new client to dan's cloud"
print "you can use our of cloud saving and sharing from everywhere"

a=Client.Communication().connect()
true=True
while true:
    b=raw_input("enter: ")
    if b=="disconnect":
        x=Client.Communication().disconnect()
        if x=='n':
            Client.Presentation().showfiles()
        elif x=='y':
            true=False


