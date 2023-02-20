using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz20._02._2023
{
    internal class Program {
        static void Main(string[] args) {
            CreditCard ev = new CreditCard();
            ev.evnt += new MyDelegate(ev.PlusMoney);
            ev.evnt += new MyDelegate(ev.MinusMoney);
            ev.evnt += new MyDelegate(ev.StartCredit);
            ev.evnt += new MyDelegate(ev.MoneyGoal);
            ev.evnt += new MyDelegate(ev.ChangePin);
        }
    }
}
