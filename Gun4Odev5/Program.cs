using System;
using System.Collections.Generic;

namespace Gun4Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            Console.WriteLine("--------------MyDictionary-------------");
            myDictionary.Add(1,"Engin Demiroğ");
            myDictionary.Add(2, "Dilara Bedir");
            myDictionary.Add(3,"Yazılımcı Geliştirme Kampı");
            myDictionary.ToList();
        }
    }
}
