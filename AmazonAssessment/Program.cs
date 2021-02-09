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