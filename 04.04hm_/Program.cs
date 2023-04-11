using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._04hm_
{
    interface Element
    {
        void Accept(Client visitor);
    }

    class House_element : Element
    {
        public string MethodHouse()
        {
            return "House";
        }
        public void Accept(Client visitor)
        {
            visitor.VisitHouse(this);
        }
    }
    class Zavod_element : Element
    {
        public string MethodFabrik()
        {
            return "Zavod";
        }
        public void Accept(Client visitor)
        {
            visitor.VisitFabrik(this);
        }
    }
    class Cafe_element : Element
    {
        public string MethodBank()
        {
            return "Cafe";
        }

        public void Accept(Client visitor)
        {
            visitor.VisitBank(this);
        }
    }


    interface Client
    {
        void VisitHouse(House_element element);
        void VisitFabrik(Zavod_element element);
        void VisitBank(Cafe_element element);
    }

    class Client_place : Client
    {
        public void VisitHouse(House_element element)
        {
            Console.WriteLine(element.MethodHouse() + " + Client_place");
        }
        public void VisitFabrik(Zavod_element element)
        {
            Console.WriteLine(element.MethodFabrik() + " + Client_place");
        }
        public void VisitBank(Cafe_element element)
        {
            Console.WriteLine(element.MethodBank() + " + Client_place");
        }
    }
    class Client_Fabrik : Client
    {
        public void VisitHouse(House_element element)
        {
            Console.WriteLine(element.MethodHouse() + " + Client_place");
        }
        public void VisitFabrik(Zavod_element element)
        {
            Console.WriteLine(element.MethodFabrik() + " + Client_place");
        }
        public void VisitBank(Cafe_element element)
        {
            Console.WriteLine(element.MethodBank() + " + Client_place");
        }
    }
    class Client_Zavod : Client
    {
        public void VisitHouse(House_element element)
        {
            Console.WriteLine(element.MethodHouse() + " + Client_place");
        }
        public void VisitFabrik(Zavod_element element)
        {
            Console.WriteLine(element.MethodFabrik() + " + Client_place");
        }
        public void VisitBank(Cafe_element element)
        {
            Console.WriteLine(element.MethodBank() + " + Client_place");
        }
    }
    class Potrebitel
    {
        public static void ClientCode(List<Element> components, Client visitor)
        {
            foreach (var component in components)
            {
                component.Accept(visitor);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}