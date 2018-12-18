﻿using System;
using ClientTester.Commands;
using UnityEngine;

namespace ClientTester
{
    class Program
    {
        private const string DEFAULT_IP_ADDRESS = "127.0.0.1";
        private const int DEFAULT_SERVER_PORT = 11000;
        private static Vector3 clientPos = new Vector3(-50f, -2f, -38f);

        [STAThread]
        static void Main(string[] args)
        {
            ushort playerId1 = 1;

            // give main server a second to start up...
            System.Threading.Thread.Sleep(1000);

            MultiplayerClient mplayer1 = new MultiplayerClient(playerId1);
            mplayer1.Start(DEFAULT_IP_ADDRESS,DEFAULT_SERVER_PORT);

            CommandManager manager = new CommandManager(mplayer1);
            while (true)
            {
                manager.TakeCommand(Console.ReadLine());
            }
        }
    }
}
