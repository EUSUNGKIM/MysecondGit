using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGitignore
{
    internal class Program
    {
        struct Player
        {
            public string name;
            public int level;
        }
        struct Monster
        {
            public string name;
            public int level;
        }
        static void Main(string[] args)
        {

            Player player = new Player()
            {  name = "용사", level = 1 };
            Monster monster = new Monster() 
            {  name = "슬라임", level = 4 };
            Monster monster = new Monster() 
            {  name = "슬라임", level = 4 };
        }
    }
}
