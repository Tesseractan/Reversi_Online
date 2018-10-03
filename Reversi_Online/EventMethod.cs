using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Dynamic;

namespace Reversi_Online
{
    class EventMethod<T>
    {
        private T obj;
        private string eventName;
        private Delegate method;
        
        public EventMethod(T obj, string eventName, Delegate method)
        {
            this.obj = obj;
            this.eventName = eventName;
            this.method = method;
        }
        public void Apply()
        {
            Type type = this.obj.GetType();
            EventInfo eventInfo = type.GetEvent(this.eventName);
            eventInfo.AddEventHandler(this.obj, this.method);
        }
        public void Apply(int times)
        {
            Type type = this.obj.GetType();
            EventInfo eventInfo = type.GetEvent(this.eventName);
            this.Apply();
            ParameterInfo[] parameters = this.method.Method.GetParameters();
            int count = 0;
            void function(params object[] args)
            {
                if (count++ < times)
                {
                    this.method.DynamicInvoke(args);
                }
                else eventInfo.RemoveEventHandler(this.obj, (Action<object[]>)function);
            }
            eventInfo.AddEventHandler(this.obj, (Action<object[]>)function);
        }
        public void Fire()
        {
            Type type = this.obj.GetType();
            EventInfo eventInfo = type.GetEvent(this.eventName);
            eventInfo.RemoveEventHandler(this.obj, this.method);
        }
        public T Object
        {
            get => this.obj;
            set { this.obj = value; }
        }
        public string EventName
        {
            get => this.eventName;
            set { this.eventName = value; }
        }
        public Delegate Method
        {
            get => this.method;
            set { this.method = value; }
        }
    }
}
