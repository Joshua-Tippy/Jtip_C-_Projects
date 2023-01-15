//written by Joshua Tippy 10/04/2022
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSoccerPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            //new object uses Auto Implemented properties in SoccerPlayer.cs
            SoccerPlayer one = new SoccerPlayer();
            one.Name = "John Doe";
            one.Jersey = 42;
            one.Goals = 11;
            one.Assists = 5;

            Display(one);
        }

        //method displays all properties of object
        static void Display(SoccerPlayer player)
        {
            WriteLine("{0}" +
                "\nJersey: {1}" +
                "\nGoals: {2}" +
                "\nAssists: {3}",
                player.Name.ToString(), player.Jersey, player.Goals, player.Assists);
        }
    }
}
