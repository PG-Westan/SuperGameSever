using System;
using SuperSocket.SocketBase;

namespace SuperGameSever
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input any key start sever");
            Console.ReadKey();
            Console.WriteLine("sever start...");

            var appSever = new AppServer();
            if (!appSever.Setup(7566))   //set up with listening port
            {
                Console.WriteLine("Failed to setup!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("The server started successfully");

            appSever.NewSessionConnected += AppServer_NewSessionConnected;
        }

        private static void AppServer_NewSessionConnected(AppSession session)
        {
            session.Send("Welcome to SuperSocket Telnet Server");
        }
    }
}
