using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180126_Practica02
{
    class Program
    {
        static void Main(string[] args)
        {
            King king = new King("King Arthur");
            king.Weapon.UseWeapon();
            king.Fight();
            Queen quenn = new Queen("Queen Elizabeth");
            quenn.Weapon.UseWeapon();
            quenn.Fight();
            Knight knight= new Knight("Sir Alex Ferguson");
            knight.Weapon.UseWeapon();
            knight.Fight();
            Troll troll = new Troll("Uruk Khai");
            troll.Weapon.UseWeapon();
            troll.Fight();
            Console.ReadLine();
        }
    }

    public class Character
    {
        Random random = new Random();
        public string Name { get; set; }

        public WeaponBehavior Weapon { get; set; }

        public void SetWeapon(WeaponBehavior weapon)
        {
            Console.WriteLine();
        }
        public void Fight()
        {
            Console.WriteLine("You attacked!");
        }

    }

    public class King : Character
    {
        public King(string Name)
        {
            this.Name = Name;
            Weapon = new AxeBehavior();
        }
    }

    public class Queen : Character
    {
        public Queen(string Name)
        {
            this.Name = Name;
            Weapon = new CrossbowBehavior();
        }
    }

    public class Knight : Character
    {
        public Knight(string Name)
        {
            this.Name = Name;
            Weapon = new SwordBehavior();
        }
    }

    public class Troll : Character
    {
        public Troll(string Name)
        {
            this.Name = Name;
            Weapon = new KnifeBehavior();
        }
    }

    public class SwordBehavior : WeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Attacking with a sword");
        }
    }

    public class AxeBehavior : WeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Attacking with an axe");
        }
    }

    public class KnifeBehavior : WeaponBehavior
    {

        public void UseWeapon()
        {
            Console.WriteLine("Attacking with a knife");
        }
    }

    public class CrossbowBehavior : WeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Attacking with a gay xbow");
        }
    }

    public interface WeaponBehavior
    {
        void UseWeapon();
    }
}
