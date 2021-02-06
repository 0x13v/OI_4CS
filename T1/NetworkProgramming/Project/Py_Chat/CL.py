# import socket
from socket import *
# form socket import socket, bind, listen, recv, send 

HOST = '' #localhost / 192.168.1.1
# LAN - 192.168.1.1
PORT = 8001
s = socket(AF_INET, SOCK_STREAM)# 98% of all socket programming will use AF_INET and SOCK_STREAM
s.bind((HOST, PORT)) 
s.listen(1) # how many connections it can receive at one time 
conn, addr = s.accept() # accept the connection
print 'Connected by', addr # print the address of the person connected
i = True
while i is True:
    data = conn.recv(1024) #recives datae (1024 bytes) using conn and store into data
    print "Received ", repr(data) # print data; Data is the message the users types
    reply = raw_input("Reply: ")
    conn.sendall(reply) 
    
conn.close()