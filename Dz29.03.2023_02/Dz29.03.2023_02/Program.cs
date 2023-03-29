using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dz29._03._2023_02 {
    public class TV {
        public void On() => Console.WriteLine("Телевизор включился.");
        public void Off() => Console.WriteLine("Телевизор выключился.");
    }
    public class Microwave {
        public void Start(int time) {
            Console.WriteLine("Подогрев еды начат.");
            Thread.Sleep(time);
        }
        public void Stop() => Console.WriteLine("Ваша еда готова!");
    }
    public class Computer {
        public void On() => Console.WriteLine("Компьютер включился.");
        public void Off() => Console.WriteLine("Компьютер выключился.");
    }
    public interface ICommand {
        void Execute();
        void Undo();
    }
    public class TVOnCommand : ICommand {
        private TV tv { get; set; }
        public TVOnCommand(TV objset) => tv = objset;
        public void Execute() => tv.On();
        public void Undo() => tv.Off();
    }
    public class MicrowaveOnCommand : ICommand {
        private Microwave microwave { get; set; }
        private int Time { get; set; }
        public MicrowaveOnCommand(Microwave objset, int time) {
            microwave = objset;
            Time = time;
        }
        public void Execute() {
            microwave.Start(Time);
            microwave.Stop();
        }
        public void Undo() => microwave.Stop();
    }
    public class ComputerOnCommand : ICommand {
        private Computer computer { get; set; }
        public ComputerOnCommand(Computer computer) => this.computer = computer;
        public void Execute() => computer.On();
        public void Undo() => computer.Off();
    }
    public class Controller {
        private ICommand command { get; set; }
        public Controller() => command = null;
        public void SetCommand(ICommand obj) => command = obj;
        public void PressButton() { if (command != null) command.Execute(); }
        public void PressUndoButton() { if (command != null) command.Undo(); }
    }
    internal class Program {
        public static void Invoker(ICommand command, bool undo) {
            Controller controller = new Controller();
            controller.SetCommand(command);
            controller.PressButton();
            if(undo) controller.PressUndoButton();
        }
        static void Main(string[] args) {
            TV tv = new TV();
            ICommand command = new TVOnCommand(tv);
            Invoker(command, true);
            Microwave microwave = new Microwave();
            command = new MicrowaveOnCommand(microwave, 5000);
            Invoker(command, false);
        }
    }
}
