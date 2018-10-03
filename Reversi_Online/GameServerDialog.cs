using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Reversi_Online
{
    class GameServerDialog : ServerDialog
    {
        private static readonly IPEndPoint endPoint = new IPEndPoint(new IPAddress(new byte[4] { 192, 168, 1, 12 }), 2019);

        public GameServerDialog() : base(endPoint)
        {
            
        }
    }
}
