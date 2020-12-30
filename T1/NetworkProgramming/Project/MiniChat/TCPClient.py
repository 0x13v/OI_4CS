#!/usr/bin/python3
import socket

Client_soc = socket.socket(socket.AF_INET,socket.SOCK_STREAM) #create socket
Host = socket.gethostbyname() #Host IP in Network
Port = 5001 #connect Port
server_IP = ''

Client_soc.connect((server_IP,Port))
Msg = Client_soc.recv(1024)
Client_soc.close()
print(Msg.decode('ascii'))