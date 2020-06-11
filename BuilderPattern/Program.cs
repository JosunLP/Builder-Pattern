using BuilderPattern.builder;
using BuilderPattern.director;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuDirector director = new MenuDirector();

            MenuBuilder builder1 = new BurgerMenuBuilder();
            director.Construct(builder1);
            Menu menu1 = builder1.GetResult();
            Console.WriteLine("Burger menu: {0}", menu1);

            MenuBuilder builder2 = new KidsMenuBuilder();
            director.Construct(builder2);
            Menu menu2 = builder2.GetResult();
            Console.WriteLine("Burger menu: {0}", menu2);
        }
    }
}
