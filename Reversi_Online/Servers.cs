using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Reversi_Online
{
    static class Servers
    {
        private static DataServerDialog dataServerDialog;

        static Servers()
        {
            dataServerDialog = new DataServerDialog();
        }

        public static void ConnectAll()
        {
            dataServerDialog.Connect();
        }
        public static void DisconnectAll()
        {
            dataServerDialog.Close();
        }

        public static DataServerDialog DataServer => dataServerDialog;
    }
}
