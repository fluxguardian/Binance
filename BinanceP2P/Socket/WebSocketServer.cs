using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace BinanceP2P.Socket
{
    public class WebSocketServer
    {
        public readonly List<WebSocketSession> Clients = new List<WebSocketSession>();

        public event EventHandler<WebSocketSession> ClientConnected;
        public event EventHandler<WebSocketSession> ClientDisconnected;

        private bool _listening;

        public void Close() => _listening = false;

        public void Listen(int port)
        {
            if (_listening) throw new Exception("Already listening!");
            _listening = true;

            var server = new TcpListener(IPAddress.Any, port);
            server.Start();

            Console.WriteLine("WS Server - UP");

            ThreadPool.QueueUserWorkItem(_ =>
            {
                while (_listening)
                {
                    var session = new WebSocketSession(server.AcceptTcpClient());
                    session.HandshakeCompleted += (__, ___) =>
                    {
                        Console.WriteLine($"{session.Id}| Handshake Valid.");
                        Clients.Add(session);
                    };

                    session.Disconnected += (__, ___) =>
                    {
                        Console.WriteLine($"{session.Id}| Disconnected.");
                        Clients.Remove(session);

                        ClientDisconnected?.Invoke(this, session);
                        session.Dispose();
                    };

                    Console.WriteLine($"{session.Id}| Connected.");
                    ClientConnected?.Invoke(this, session);
                    session.Start();
                }

                server.Stop();
            });
        }
    }
}
