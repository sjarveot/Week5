﻿using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt kasutajatunnust ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!"
            //muul konsoolis kuvatakse "Vale kasutaja tunnus või salasõna, proovi uuesti".



            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna");
            string userPassword = Console.ReadLine();



            if(userName == "admin" && userPassword == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");

            }
            else 
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti.");
            }
           
        }



        
    }
}
