using System;
using System.Collections.Generic;

namespace Reversi_Online
{
    class LadenEventArgs : EventArgs
    {
        public Dictionary<string, object> PayloadData = new Dictionary<string, object>();
        public bool ContainsPayload => this.PayloadData.Count > 0;
    }
    delegate void LadenEventHandler(object sender, LadenEventArgs e);
}
