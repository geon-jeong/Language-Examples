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
# Examples Server
#
if __name__ == '__main__':
    port = 8082

    sv_socket = socket(AF_INET, SOCK_STREAM)
    sv_socket.setsockopt(SOL_SOCKET, SO_REUSEADDR, 1)
    sv_socket.bind(('', port))
    sv_socket.listen(1)
    print('Server is Ready')

    connected_socket, connected_ip = sv_socket.accept()
    print('Connected IP: ' + str(connected_ip))

    send_to_client = threading.Thread(target=func_send_data, args=(connected_socket,))
    recv_from_client = threading.Thread(target=func_recv_data, args=(connected_socket,))
    send_to_client.start()
    recv_from_client.start()

    while True:
        time.sleep(0.5)
        pass


