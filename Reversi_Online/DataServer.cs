using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using ReversiSerializableTypes;
using ReversiSerializableTypes.UserData;


namespace Reversi_Online
{
    class DataServerDialog : ServerDialog
    {
        private bool isAuthenticated;
        private static readonly IPEndPoint endPoint = new IPEndPoint(new IPAddress(new byte[4] { 192, 168, 1, 12 }), 2018);

        public event LadenEventHandler Authenticated;
        public DataServerDialog() : base(endPoint) {
            this.Disconnected += (s, e) =>
            {
                this.isAuthenticated = false;
            };
        }
        public void SignUp(EditableUserData data, Reactions reactions=null)
        {
            Thread signing = new Thread(() =>
            {
                if (!this.SendMessage("SIGNUP", ("EditableData", data))) goto disconnection;

                reactions?.RequestSentCallback?.Invoke();
                Message message = this.ReceiveMessage();
                if (message == null) goto disconnection;
                reactions?.MessageReceivedCallback?.Invoke(message);
                if (message.Title == "SUCCESS")
                {
                    this.isAuthenticated = true;
                    LadenEventArgs eventArgs = new LadenEventArgs();
                    eventArgs.PayloadData["message"] = message;

                    this.Authenticated(this, eventArgs);
                }
                return;
                disconnection: reactions?.DisconnectionErrorCallback?.Invoke();

            });
            signing.Start();
        }
        public void LogIn(LoginUserData data, Reactions reactions=null)
        {
            Thread logging = new Thread(() =>
            {
                if (!this.SendMessage("LOGIN", ("LoginData", data))) goto disconnection;
                
                reactions?.RequestSentCallback?.Invoke();
                Message message = this.ReceiveMessage();
                if (message == null) goto disconnection;
                reactions?.MessageReceivedCallback?.Invoke(message);
                if (message.Title == "SUCCESS")
                {
                    this.isAuthenticated = true;
                    LadenEventArgs eventArgs = new LadenEventArgs();
                    eventArgs.PayloadData["message"] = message;

                    this.Authenticated(this, eventArgs); //Thread.Sleep(10000);
                }
                return;
                disconnection: reactions?.DisconnectionErrorCallback?.Invoke();

            });
            logging.Start();

        }

        public bool IsAuthenticated => this.isAuthenticated;
    }
}
