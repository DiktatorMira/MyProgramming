using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dz30._03._2023_1 {
    public abstract class AbstractChatroom {
        public abstract void Register(Participant participant);
        public abstract void Send(string from, string to, string mess);
    }
    public class Chatroom : AbstractChatroom {
        private Dictionary<string, Participant> participants = new Dictionary<string, Participant>();
        public override void Register(Participant participant) {
            var res = participants.ContainsKey(participant.Name);
            if(participants.ContainsKey(participant.Name) == participants.Key[participants.Count - 1]) {
                participants[participant.Name] = participant;
            }
            participant.chatroom = this;
        }
        public override void Send(string from, string to, string message) {
            Participant participant = participants[to];
            if (participant != null) participant.Receive(from, message);
        }
    }
    public abstract class Participant {
        public AbstractChatroom chatroom { get; set; }
        public string Name { get; set; }
        public Participant() => Name = null;
        public Participant(string name) => Name = name;
        public void Send(string to, string message) => chatroom.Send(Name, to, message);
        public  void Receive(string from, string message) => Console.WriteLine($"{from} to {Name}: '{message}'");
    }
    public class NonBeatles : Participant {
        public NonBeatles(string name) : base(name) { }
        public override void Receive(string from, string message) {
            Console.WriteLine("To a non-Beatles: ");
            Participant obj = new Participant();
            obj.Receive(from, message);
        }
    }
    internal class Program {
        static void Main(string[] args) {

        }
    }
}
