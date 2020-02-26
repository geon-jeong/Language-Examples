from socket import *
import threading
import time

def func_send_data(_socket):
    while True:
        sdata = input('>')
        _socket.send(sdata.encode('utf-8'))

def func_recv_data(_socket):
    while True:
        rdata = _socket.recv(4096)
        print('receive :', rdata.decode('utf-8'))

#
# Examples Socket
#
if __name__ == '__main__':    
    port = 8082
    server_ip = '127.0.0.1'

    cl_socket = socket(AF_INET, SOCK_STREAM)
    cl_socket.connect((server_ip, port))

    print('Connected with server ip:', server_ip)

    send_to_client = threading.Thread(target=func_send_data, args=(cl_socket,))
    recv_from_client = threading.Thread(target=func_recv_data, args=(cl_socket,))
    send_to_client.start()
    recv_from_client.start()

    while True:
        time.sleep(0.5)
        pass


