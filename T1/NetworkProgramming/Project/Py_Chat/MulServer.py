from socket import *
from threading import Thread

def clientHandler():
    conn, addr = s.accept()
    print addr, "is Connected"
    while 1:
        data = conn.recv(1024)
        if not data:
            break
        print "Received Message", repr(data)


HOST = '' #localhost
PORT = 8000

s = socket(AF_INET, SOCK_STREAM)
s.bind((HOST, PORT))
s.listen(5)

print "Server is running......"

#Thread(target=clientHandler).start()
#Thread(target=clientHandler).start()
#Thread(target=clientHandler).start()

for i in range(5):
    Thread(target=clientHandler).start()

s.close()