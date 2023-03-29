using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz29._03._2023_1{
    public interface IHandler {
        IHandler SetNext(IHandler handler);
        object Handle(object request);
    }
    public class Receiver : IHandler {
        private IHandler NextHandler { get; set; }
        public bool BankTransfer { get; set; }
        public bool MoneyTransfer { get; set; }
        public bool PayPalTransfer { get; set; }
        public Receiver(bool bt, bool mt, bool ppt) {
            BankTransfer = bt;
            MoneyTransfer = mt;
            PayPalTransfer = ppt;
        }
        public IHandler SetNext(IHandler handler) => NextHandler = handler;
        public virtual object Handle(object request) {
            if (this.NextHandler != null) return NextHandler.Handle(request);
            else return null;
        }
    }
    public abstract class PaymentHandler {
        protected PaymentHandler Successor { get; set; }
        public abstract void Handle(Receiver receiver);
    }
    public class BankPaymentHandler : PaymentHandler {
        public override void Handle(Receiver receiver) {
            if (receiver.BankTransfer) Console.WriteLine("Банковский перевод.");
            else if(Successor != null) Successor.Handle(receiver);
        }
    }
    public class MoneyPaymentHandler : PaymentHandler {
        public override void Handle(Receiver receiver)  {
            if (receiver.MoneyTransfer) Console.WriteLine("Перевод через системы денежных переводов.");
            else if (Successor != null) Successor.Handle(receiver);
        }
    }
    public class PayPalPaymentHandler : PaymentHandler {
        public override void Handle(Receiver receiver) {
            if (receiver.PayPalTransfer) Console.WriteLine("Перевод через пейпал.");
            else if (Successor != null) Successor.Handle(receiver);
        }
    }
    internal class Program {
        public static void Request(PaymentHandler handler, Receiver receiver) => handler.Handle(receiver);
        static void Main(string[] args) {
            PaymentHandler bankPaymentHandler = new BankPaymentHandler();
            PaymentHandler moneyPaymentHandler = new MoneyPaymentHandler();
            PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();
            bankPaymentHandler.Succesor = paypalPaymentHandler;
        }
    }
}
