﻿using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_09.domain.service._667
{
    class boy667
    {
        public string name;
        public int age;
        public int final_MIN_AGE = 0;
        public int final_MAX_AGE = 100;
        private static string Default_name = "一本松　匠";
        private static int Default_age = 10;

        public boy667() : this(Default_name, Default_age)
        {
        }
        public boy667(string name) : this(name, Default_age)
        {
        }
        public boy667(int age) : this(Default_name, age)
        {
        }
        public boy667(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string getName()
        {
            return this.name;
        }
        public string SetName(string name)
        {
            if (name == "")
            {
                Console.WriteLine("引数エラーです");
                this.name = name;
            }
            else
            {
                this.name = name;
            }
            return this.name;
        }
        public int GetAge()
        {
            return this.age;
        }
        public int SetAge(int age)
        {
            if (age < final_MIN_AGE || age > final_MAX_AGE)
            {
                Console.WriteLine("引数エラーです");
                this.age = age;
            }
            else
            {
                this.age = age;
            }
            return this.age;
        }
        public void prologue()
        {
            Console.WriteLine("僕の名前は" + this.name);
            Console.WriteLine("夢は大リーグで活躍できる野球選手になることだ！");
            Console.WriteLine("まだ"+this.age+"歳だけど、僕は将来を考えてるんだ！");
            Console.WriteLine("凄い選手目指して頑張るぞ！ ");
            Console.WriteLine("みんなは帰ってしまったけど、今日も残って特訓だ！");
        }
        public void specialTraining(int battingbnt)
        {
            int course;
            int hitcnt = 0;
            int strikhit = 0;
            for (int i = 0; i<battingbnt; i++)
            {
                System.Random r = new System.Random();
                int courseRand = r.Next(1, 3);
                Console.WriteLine("ビュッ！");
                Console.WriteLine("1:内角、2:外角、3:ド真ん中");
                course = int.Parse(Console.ReadLine());
                if(course == courseRand)
                {
                    Console.WriteLine("HIT！");
                    hitcnt = hitcnt+1;
                }
                else
                {
                    Console.WriteLine("ストライク！");
                    strikhit = strikhit + 1;
                }
                Console.WriteLine("ループを強制的に抜けるにはqを入力してください");
                string loopbreak;
                loopbreak = Console.ReadLine();
                if(loopbreak == "q")
                {
                    break;
                }
            }
            Console.WriteLine("HIT数"+ hitcnt);
            Console.WriteLine("ストライク数" + strikhit);
        }
    }
}
