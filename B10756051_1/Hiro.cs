using System;
using System.Collections.Generic;
using System.Text;

namespace B10756051_1
{
    class Hiro
    {
        string hiroName = "cty";
        int hiroHP = 500;
        int hiroMP = 200;
        int maxHiroHP = 500;
        int maxHiroMP = 200;
        int hiroATK = 150;
        
        public void Showhiroinfo()
        {
            Console.WriteLine("\n名稱:" + hiroName);
            Console.WriteLine("生命值:" + hiroHP);
            Console.WriteLine("魔力值:" + hiroMP);
            Console.WriteLine("攻擊力:" + hiroATK);
        }

        public void Usehiroskill_01()
        {

            if (hiroHP == maxHiroHP)
            {
                Console.WriteLine("生命值已經是滿的了!");
            }
            else if(hiroHP < maxHiroHP)
            {
                hiroMP -= 10;
                Console.WriteLine("\n使用技能[恢復] Lv.1");
                Console.WriteLine("魔力值減少10");
                Console.WriteLine("血量恢復了100點!");
                hiroHP += 100;
            }
            Showhiroinfo();
        }
        public void Usehiroskill_02()
        {
            hiroATK += 100;
            hiroMP -= 20;
            Console.WriteLine("\n使用技能[強化] Lv.1");
            Console.WriteLine("魔力值減少20");
            Console.WriteLine("攻擊力增加了100點!");
            Showhiroinfo();
        }
    }
}
