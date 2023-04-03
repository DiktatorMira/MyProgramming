using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1 {
    public class Account {
        public State state { get; set; }
        public string Owner { get; set; }
        public Account(string owner) => Owner = owner;
        public State GetState() { return state; }
        public void SetState(State state) => this.state = state;
        public void Deposit(double amount) {
            state.Deposit(amount);
            Console.WriteLine($"Депонированно: {amount}");
            Console.WriteLine($"Баланс:{state.Balance}");
            Console.WriteLine($"Статус карты: {state.Status}");
        }
        public void Withdraw(double amount) {
            if (state.Withdraw(amount)) {
                Console.WriteLine($"Снято денег: {amount}");
                Console.WriteLine($"Баланс:{state.Balance}");
                Console.WriteLine($"Статус карты: {state.Status}");
            }
        }
        public void PayInterest() {
            if (state.PayInterest()) {
                Console.WriteLine("Процентов выплачены");
                Console.WriteLine($"Баланс:{state.Balance}");
                Console.WriteLine($"Статус карты: {state.Status}");
            }
        }
    }
    public abstract class State {
        public Account acc { get; set; }
        public double Balance { get; set; }
        public double Interest { get; set; }
        public double LowLim { get; set; }
        public double HighLim { get; set; }
        public string Status { get; set; }
        public Account GetAccount() { return acc; }
        public abstract void Deposit(double amount);
        public abstract bool Withdraw(double amount);
        public abstract bool PayInterest();
    }
    public class RedState : State {
        private void Initialize() {
            Interest = 0.0;
            LowLim = -10000000.0;
            HighLim = 0.0;
        }
        private void StateChangeCheck() {
            if (Balance >= LowLim) acc.SetState(new SilverState(this));
        }
        public RedState(State state) {
            Balance = state.Balance;
            Status = "Красная";
            Initialize();
        }
        public override void Deposit(double amount) {
            Balance += amount;
            StateChangeCheck();
        }
        public override bool Withdraw(double amount) {
            Console.WriteLine("Нет средств для снятия!");
            StateChangeCheck();
            return true;
        }
        public override bool PayInterest() {
            Console.WriteLine("Нет средств для процентов!");
            StateChangeCheck();
            return true;
        }
    }
    public class SilverState : State {
        private void Initialize() {
            Interest = 0.01;
            LowLim = 0.0;
            HighLim = 1000.0;
        }
        private void StateChangeCheck() {
            if (Balance <= LowLim) acc.SetState(new RedState(this));
            else if (Balance >= HighLim) acc.SetState(new GoldState(this));
        }
	    public SilverState(double balance, Account account) {
            Balance = balance;
            acc = account;
            Status = "Серебряная";
            Initialize();
        }
        public SilverState(State state) : this(state.Balance, state.acc) { }
        public override void Deposit(double amount) {
            Balance += amount;
            StateChangeCheck();
        }
	    public override bool Withdraw(double amount) {
            Balance -= amount;
            StateChangeCheck();
            return true;
        }
        public override bool PayInterest() {
            Balance += Interest * Balance;
            StateChangeCheck();
            return true;
        }
    }
    public class GoldState : State {
        private void Initialize() {
            Interest = 0.07;
            LowLim = 1000.0;
            HighLim = 1000000.0;
        }
        private void StateChangeCheck() {
            if (Balance <= LowLim) acc.SetState(new RedState(this));
            else if (Balance >= HighLim) acc.SetState(new SilverState(this));
        }
        public GoldState(double balance, Account account) {
            Balance = balance;
            acc = account;
            Status = "Серебряная";
            Initialize();
        }
        public GoldState(State state) : this(state.Balance, state.acc) { }
        public override void Deposit(double amount) {
            Balance += amount;
            StateChangeCheck();
        }
        public override bool Withdraw(double amount) {
            Balance -= amount;
            StateChangeCheck();
            return true;
        }
        public override bool PayInterest() {
            Balance += Interest * Balance;
            StateChangeCheck();
            return true;
        }
    }
}
