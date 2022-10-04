using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Task3
{
    internal class ListOfHero<T> where T : Hero
    {
        public void InDegub(T hero)
        {
            Debug.WriteLine($"Your hero is : {hero} and his price : {hero.Price} and id is : {hero.Id} ");
            Console.WriteLine($"Your hero is : {hero} and his price : {hero.Price} and id is : {hero.Id} ");
        }
    }
}
