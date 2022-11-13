package ru.WebServer;

import java.io.IOException;
import java.net.ServerSocket;

public class WebServer {

    public static void main(String[] args){
        try(ServerSocket serverSocket = new ServerSocket(8088)) {
            System.out.println("Your are on server!");
            serverSocket.accept();
        } catch (IOException e) {
            e.printStackTrace();
        }

    }
}
