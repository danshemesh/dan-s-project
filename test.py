import os
import Wi
import  sys
from subprocess import PIPE, Popen
process = Popen([r"C:\Users\dan\Desktop\ConsoleApplication2\ConsoleApplication2\bin\Debug\ConsoleApplication2.exe"], stdin=PIPE, stdout=PIPE, stderr=PIPE)
print os.getpid()
print process.stdout.read()