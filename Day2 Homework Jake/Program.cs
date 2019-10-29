using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Day2_Homework_Jake;

namespace Day2HomeworkJake
{
    class Program
    {
        static void Main(string[] args)
        {
            Coach therapy = new Coach();
            Coach tobiamus = new Coach();
            Player josh = new Player();
            Player tom = new Player();
            Player jake = new Player();
            Player joe = new Player();
            Player ben = new Player();

            MethodExample methodExample = new MethodExample();
            string myString = methodExample.ReverseString("Reverse me");
            Console.WriteLine(myString);
        }
        
       
        class FreeAgents : Player
        {
            private int previousEarnings;
            public void SetPreviousEarnings(int earings)
            {
                if (earings < 0)
                {
                    earings = 0;
                }
                else
                {
                    previousEarnings = earings;
                }
            }
            public int GetPreviousEarnings()
            {
                return previousEarnings;
            }
            public FreeAgents()
            {
                Console.WriteLine("I'm a free agent");
            }

        }

        class Squad : Player
        {
            private int wins;
            public void SetWins(int squadWins)
            {
                if (squadWins < 0)
                {
                    squadWins = 0;
                }
                else
                {
                    wins = squadWins;
                }
            }
            public int GetWins()
            {
                return wins;
            }

            private string player1;
            public void SetPlayer1(string player1Info)
            {
                for (int i = 0; i < player1Info.Length; i++)
                {
                    if (Char.IsUpper(player1Info[i]))
                    {
                        Char.ToLower(player1Info[i]);
                    }
                }
                Char.ToUpper(player1Info[0]);
            }
            public string GetPlayer1()
            {
                return player1;
            }

            private string player2;
            public void SetPlayer2(string player2Info)
            {
                for (int i = 0; i < player2Info.Length; i++)
                {
                    if (Char.IsUpper(player2Info[i]))
                    {
                        Char.ToLower(player2Info[i]);
                    }
                }
                Char.ToUpper(player2Info[0]);
            }
            public string GetPlayer2()
            {
                return player2;
            }

            private string player3;
            public void SetPlayer3(string player3Info)
            {
                for (int i = 0; i < player3Info.Length; i++)
                {
                    if (Char.IsUpper(player3Info[i]))
                    {
                        Char.ToLower(player3Info[i]);
                    }
                }
                Char.ToUpper(player3Info[0]);
            }
            public string GetPlayer3()
            {
                return player3;
            }

            private string player4;
            public void SetPlayer4(string player4Info)
            {
                for (int i = 0; i < player4Info.Length; i++)
                {
                    if (Char.IsUpper(player4Info[i]))
                    {
                        Char.ToLower(player4Info[i]);
                    }
                }
                Char.ToUpper(player4Info[0]);
            }
            public string GetPlayer4()
            {
                return player4;
            }

            private string player5;
            public void SetPlayer5(string player5Info)
            {
                for (int i = 0; i < player5Info.Length; i++)
                {
                    if (Char.IsUpper(player5Info[i]))
                    {
                        Char.ToLower(player5Info[i]);
                    }
                }
                Char.ToUpper(player5Info[0]);
            }
            public string GetPlayer5()
            {
                return player5;
            }
        }
    }
    class MethodExample
    {
        //every method has an access specifier, return type
        //it also has a name and arguments if needed and finally a body
        public string ReverseString(string str)
        {
            return "String has been reversed" + str;
        }
    }

}
