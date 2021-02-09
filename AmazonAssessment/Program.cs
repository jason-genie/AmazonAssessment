using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text;
using System;

namespace AmazonAssessment
{
	class Result
    {
        /*
   * Complete the 'doesCircleExist' function below.
   *
   * The function is expected to return a STRING_ARRAY.
   * The function accepts STRING_ARRAY commands as parameter.
   */

        public static List<string> doesCircleExist(List<string> commands)
        {
            int commandcount = commands.Count();
            List<string> results = new List<string>();
            for (int i = 0; i < commandcount; i++)
            {
                int x = 0, y = 0;
                int dir = 0; // 0:North 1:East 2:South 3:West
                int k = 0;
                // Repeat the commands 4 times
                while (k < 4)
                {
                    for (int j = 0; j < commands[i].Length; j++)
                    {
                        // Process commands
                        switch (commands[i][j])
                        {
                            case 'G':
                                switch (dir)
                                {
                                    case 0:
                                        y++;
                                        break;
                                    case 1:
                                        x++;
                                        break;
                                    case 2:
                                        y--;
                                        break;
                                    case 3:
                                        x--;
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            // Change the forward direction
                            case 'L':
                                dir = (dir == 0) ? 3 : (dir - 1);
                                break;
                            case 'R':
                                dir = (dir == 3) ? 0 : (dir + 1);
                                break;
                            default:
                                break;
                        }
                    }
                    k ++;
                }

                if (x == 0 && y == 0)
                    results.Add("YES");
                else
                results.Add("NO");
            }
            return results;
        }

    }
	
    class Program
    {
        public static void Main(string[] args)
        {

            int commandsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> commands = new List<string>();

            for (int i = 0; i < commandsCount; i++)
            {
                string commandsItem = Console.ReadLine();
                commands.Add(commandsItem);
            }

            List<string> result = Result.doesCircleExist(commands);

            Console.WriteLine(String.Join("\n", result));

        }
    }
}