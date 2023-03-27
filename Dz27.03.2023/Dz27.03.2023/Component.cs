using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz27._03._2023 { 
    public abstract class Component {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }
        public int Protect { get; set; }
    }
    public class Human : Component {
        Human() {
            Name = "Человек";
            Damage = 20;
            Speed = 20;
            Health = 150;
            Protect = 0;
        }
        public override string ToString() {
            return $"Название персонажа: {Name}\nУрон: {Damage}\nСкорость: {Speed}\n Кол-во здоровья: {Health}\n Защита: {Protect}";
        }
    }
    public class Elf : Component {
        Elf() {
            Name = "Эльф";
            Damage = 15;
            Speed = 30;
            Health = 100;
            Protect = 0;
        }
        public override string ToString() {
            return $"Название персонажа: {Name}\nУрон: {Damage}\nСкорость: {Speed}\n Кол-во здоровья: {Health}\n Защита: {Protect}";
        }
    }
    public abstract class Decorator : Component {
        protected Component component { get; set; }
        public Decorator(Component component) => this.component = component;
        public abstract void Change();
    }
    public class HumanWarrior : Decorator {
        public HumanWarrior(Human comp) : base(comp) { }
        public override void Change() {
            component.Name = "Человек-воин";
            component.Damage += 20;
            component.Speed += 10;
            component.Health += 50;
            component.Protect += 20;
        }
    }
    public class Swordsman : Decorator{
        public Swordsman(HumanWarrior comp) : base(comp) { }
        public override void Change() {
            component.Name = "Меченосец";
            component.Damage += 40;
            component.Speed -= 10;
            component.Health += 50;
            component.Protect += 40;
        }
    }
    public class Archer : Decorator {
        public Archer(HumanWarrior comp) : base(comp) { }
        public override void Change() {
            component.Name = "Лучник";
            component.Damage += 20;
            component.Speed += 20;
            component.Health += 50;
            component.Protect += 10;
        }
    }
    public class Rider : Decorator {
        public Rider(Swordsman comp) : base(comp) { }
        public override void Change() {
            component.Name = "Всандик";
            component.Damage -= 10;
            component.Speed += 40;
            component.Health += 200;
            component.Protect += 100;
        }
    }
    public class ElfWarrior : Decorator {
        public ElfWarrior(Elf comp) : base(comp) { }
        public override void Change() {
            component.Name = "Эльф-воин";
            component.Damage += 20;
            component.Speed -= 10;
            component.Health += 100;
            component.Protect += 20;
        }
    }
    public class ElfWizard : Decorator {
        public ElfWizard(Elf comp) : base(comp) { }
        public override void Change() {
            component.Name = "Эльф-маг";
            component.Damage += 10;
            component.Speed += 10;
            component.Health -= 50;
            component.Protect += 10;
        }
    }
    public class Crossbowman : Decorator {
        public Crossbowman(ElfWarrior comp) : base(comp) { }
        public override void Change()  {
            component.Name = "Арбалетчик";
            component.Damage += 20;
            component.Speed += 10;
            component.Health += 50;
            component.Protect -= 10;
        }
    }
    public class EvilWizard : Decorator {
        public EvilWizard(ElfWizard comp) : base(comp) { }
        public override void Change() {
            component.Name = "Злой маг";
            component.Damage += 70;
            component.Speed += 20;
            component.Health += 0;
            component.Protect +=0;
        }
    }
    public class KindWizard : Decorator {
        public KindWizard(ElfWizard comp) : base(comp) { }
        public override void Change() {
            component.Name = "Добрый маг";
            component.Damage += 50;
            component.Speed += 30;
            component.Health += 100;
            component.Protect += 30;
        }
    }
}
