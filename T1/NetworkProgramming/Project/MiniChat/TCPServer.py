#!/usr/bin/python3
import socket

server_soc = socket.socket(socket.AF_INET,socket.SOCK_STREAM) #create socket
Host = '192.168.1.11' #Host IP in Network
Port = 5001 #connect Port

server_soc.bind((Host,Port))
server_soc.listen(3)#Start TCP Listener

print("Host: "+str(Host))
print("Port: "+str(Port))
while(True):
    Client_soc,address = server_soc.accept()
    print(str(address)+" Connected ")
    msg= "Hello world !"+"\r\n"
    Client_soc.send(msg.encode('ascii'))
    MSG=Client_soc.recv(1024)
    print("MSG: " + MSG.decode('ascii'))
    Client_soc.close()
