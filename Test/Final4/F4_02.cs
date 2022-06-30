﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Final4
{
    class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }


        public void TakeBus() 
        {
            t1.Take(name);
        }

        public void TakeSubway()
        {
            t2.Take(name);
        }
    }

    class Bus
    {
        private string number;
        private int fee;

        public Bus(string number, int fee)
        {
            this.number = number;
            this.fee = fee;
        }


        public void Take(string name) 
        {
            Console.WriteLine("{0}은 {1}버스를 탑니다.", name, number);
            Console.WriteLine("버스 요금은 {0:C}입니다.", fee);
        }
    }

    class Subway
    {
        private string line;
        private int fee;

        public Subway(string line, int fee)
        {
            this.line = line;
            this.fee = fee;
        }


        public void Take(string name)
        {
            Console.WriteLine("{0}은 {1}호선 지하철을 탑니다.", name, line);
            Console.WriteLine("버스 요금은 {0:C}입니다.", fee);
        }
    }


    internal class F4_02
    {
        static void Main1(string[] args)
        {

            Person kim = new Person("김유신", 24);
            Person lee = new Person("이순신", 34);

            Bus t1 = new Bus("64", 1500);
            Subway t2 = new Subway("1", 1600);

            kim.TakeBus(t1);
            lee.TakeSubway(t2);


        }
    }
}
