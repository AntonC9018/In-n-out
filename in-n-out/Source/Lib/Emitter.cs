using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innout.Source.Lib
{
    public abstract class HandlerParams
    {
    }

    public delegate void HandlerFunction(HandlerParams handlerParams);

    class Handler
    {
        public HandlerFunction func;

        public Handler(HandlerFunction f)
        {
            func = f;
        }
    }

    class Event
    {
        List<Handler> toRemove;
        List<Handler> toAdd;
        List<Handler> handlers;

        public Event()
        {
            toRemove = new List<Handler>();
            toAdd = new List<Handler>();
            handlers = new List<Handler>();
        }

        public void AddHandler(Handler h)
        {
            toAdd.Add(h);
        }

        public void RemoveHandler(Handler h)
        {
            toAdd.Remove(h);
        }

        public void Notify(HandlerParams hp)
        {
            foreach (var h in toAdd)
            {
                handlers.Remove(h);
            }
            foreach (var h in toRemove)
            {
                handlers.Remove(h);
            }            
            foreach (var h in handlers)
            {
                h.func(hp);
            }
        }
    }

    class Emitter
    {
        IDictionary<string, Event> events;
        public Emitter()
        {
            events = new Dictionary<string, Event>();
        }

        public void RegisterEvent(string Name)
        {
            var ev = new Event();
            events.Add(Name, ev);
        }

        public void Subscribe(string Name, Handler handler)
        {
            if (!events.ContainsKey(Name))
            {
                Console.WriteLine("No " + Name + " event found registered");
                return;
            }
            events[Name].AddHandler(handler);
        }

        public void Unsubscribe(string Name, Handler handler)
        {
            if (!events.ContainsKey(Name))
            {
                Console.WriteLine("No " + Name + " event found registered");
                return;
            }
            events[Name].RemoveHandler(handler);
        }

        public void Notify(string Name, HandlerParams hp)
        {
            if (!events.ContainsKey(Name))
            {
                Console.WriteLine("No " + Name + " event found registered");
                return;
            }
            events[Name].Notify(hp);
        }

        //public void SubscribeOnce(string)
    }
}
