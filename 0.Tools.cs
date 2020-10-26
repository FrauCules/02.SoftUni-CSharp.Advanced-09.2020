using System;
using System.Linq;

namespace Tools
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[][] jagged = new int[5][];
        }
    }
}

/* WHILE
   while ((command = Console.ReadLine()) != "end")
   {

   }
*/
/* SWITCH
    switch (num)
    {
        case 0:
            break;
        case "a":
            break;
        default:
            break;
    }
*/
/* STACK
        Stack<int> stack = new Stack<int>();
        stack.Push(value); // добавяне на елемент най-отгоре
        stack.Pop();       // взимане на най-горния елемент с премахване от стека
        stack.Peek();      // взимане на най-горния елемент без да бъде премахнат от стека 
        
        Stack<int> myStackMaterials = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
*/
/*  QUEUE
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(value);  // добавяне на елемент на края на опашката
        queue.Dequeue();       // взимане на първия елемент и премахване от опашката
        queue.Peek();          // взимане на първия елемент без да се премахва от опашката

        Queue<int> myQueueMagicLevel = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
*/
/*  MATRIX
-- INT matrix
        int[] list = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string[] line = Console.ReadLine().Split();
        int nRow = int.Parse(line[0]);
        int nCol = int.Parse(line[1]);
        int[,] matrix = new int[nRow, nCol];
        ReadMatrix(matrix);

            int[,] matrix =
                    {  { 5, 2, 3, 1 },
                    { 1, 9, 2, 4 },
                    { 9, 8, 6, 11 }  };



FILL Method int
        private static void ReadMatrix(int[,] matrix)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            matrix[row, col] = currentRow[col];
                        }
                    }
                }

PRINT Method int
        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

     Печата елементите един под друг
            foreach (int element in matrix)
            {
                Console.WriteLine(element);
            }

-- STRING matrix
        string[, ] martix = new string[row,col]

FILL Method
        ReadMatrix(matrix);
        private static void ReadMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] currentRow = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }

PRINT Method   
        PrintMatrix(matrix);
        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine(matrix[row, matrix.GetLength(1) - 1]);
            }
        }

-- CHAR Martix
FILL Method
        char[, ] matrix = new char[row,col];
        ReadMatrix(matrix);
        private static void ReadMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                 matrix[row, col] = currentRow[col];
                }
            }
        }

PRINT Method
        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                   Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }

!!!!!!!!!   Позиции в матрица:
 public class Position
        {
            public Position(int row, int col)
            {
                Col = col;
                Row = row;
            }

            public int Row { get; set; }

            public int Col { get; set; }

            public bool IsSafe(int rowCount, int colCount) // оставаме ли в матрицата? ДА - true / НЕ - false
            {
                if (Row < 0 || Col < 0)
                {
                    return false;
                }
                if (Row >= rowCount || Col >= colCount)
                {
                    return false;
                }

                return true;
            }

            public void CheckOtherSideMovement(int rowCount, int colCount) // ако сме излезли извън матрицата, влизаме от другата страна
            {
                if (Row < 0)
                {
                    Row = rowCount - 1;
                }
                if (Col < 0)
                {
                    Col = colCount - 1;
                }
                if (Row >= rowCount)
                {
                    Row = 0;
                }
                if (Col >= colCount)
                {
                    Col = 0;
                }
            }

            public static Position GetDirection(string command) // определяне на посоката на движение
            {
                int row = 0;
                int col = 0;
                if (command == "left")
                {
                    col = -1;
                }
                if (command == "right")
                {
                    col = 1;
                }
                if (command == "up")
                {
                    row = -1;
                }
                if (command == "down")
                {
                    row = 1;
                }

                return new Position(row, col);
            }

!!!!!!! Четене на матрица, принтиране на матрица, намиране позиция в матрица
        static Position GetPlayerPosition(char[,] matrix) // намиране позицията на играча
        {
            Position position = null;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'f')
                    {
                        position = new Position(row, col);
                    }
                }
            }

            return position;
        }

        private static void ReadMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string line = Console.ReadLine();
                for (int col = 0; col < line.Length; col++)
                {
                    matrix[row, col] = line[col];
                }
            }
        }   // четем матрицата от конзолата

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }   // разпечатваме матрицата
*/
/* JUGGED ARRAY - Назъбени матрици----------------------------------------
FILL Jagged Arrays 
        int[][] jagged = new int[5][];  // инициилизира броя на редовете, колоните са динамични и не знаеш колко ще са

FILL --------------------------------
        ReadJagged(jagged);
        private static void ReadJagged(int[][] jagged)
        {
            for (int row = 0; row < jagged.Length; row++)
            {
                string[] inputNumbers = Console.ReadLine().Split(' '); // четеш данните от съответния ред
                jagged[row] = new int[inputNumbers.Length];            // инициализираш поредната колона с дължината на прочетените елементи

                for (int col = 0; col < jagged[row].Length; col++)     // въртиш даокато из„ерпиш броя на елементите от съответния ред
                {
                    jagged[row][col] = int.Parse(inputNumbers[col]);
                }
            }
        }

PRINT Jagged Arrays -------------------------------------------
        PringJagged(jagged);   
        private static void PringJagged(int[][] jagged)
        {
            for (int row = 0; row < jagged.Length; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write("{0} ", jagged[row][col]);
                }
                Console.WriteLine();
            }
        }

    --Foreach loop ---------------
        foreach (int[] row in jagged)
        {
            Console.WriteLine(string.Join(" ",row));
        }
*/
/* Dictionary -------------------------------------
 * using System.Collections.Generic;
 * using System.Linq;

    * Dictionary<string, Dictionary<string, double>>
            Dictionary<string, Dictionary<string, double>> list = new Dictionary<string, Dictionary<string, double>>();
            var input = "";

            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] data = input.Split(", ");
                string name = data[0];
                string product = data[1];
                double price = double.Parse(data[2]);

                if (!list.ContainsKey(name))
                {
                    list[name] = new Dictionary<string, double>();
                }

                if (!list[name].ContainsKey(product))
                {
                    list[name][product] = price;
                }
            }

            foreach (var item in list.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value))
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var items in item.Value)
                {
                    Console.WriteLine($"Product: {items.Key}, Price: {items.Value}");
                }
            }
Вход:
lidl, juice, 2.30
fantastico, apple, 1.20
kaufland, banana, 1.10
fantastico, grape, 2.20
Revision

Изход:
fantastico->
Product: apple, Price: 1.2
Product: grape, Price: 2.2
kaufland->
Product: banana, Price: 1.1
lidl->
Product: juice, Price: 2.3


    * Dictionary<string, Dictionary<string, List<string>>> 
            Dictionary<string, Dictionary<string, List<string>>> list = new Dictionary<string, Dictionary<string, List<string>>>();
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                string[] data = Console.ReadLine().Split(" ");
                string continents = data[0];
                string contries = data[1];
                string cities = data[2];

                if (!list.ContainsKey(continents))
                {
                    list[continents] = new Dictionary<string, List<string>>();
                }

                if (!list[continents].ContainsKey(contries))
                {
                    
                    list[continents][contries] =new List<string>();
                }
                list[continents][contries].Add(cities);
            }

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key}М:");
                foreach (var items in item.Value)
                {
                    var towns = items.Key.ToList();
                    Console.WriteLine($"  {items.Key} -> {string.Join(", ", items.Value)}");

                }
            }
Вход:
9
Europe Bulgaria Sofia
Asia China Beijing
Asia Japan Tokyo
Europe Poland Warsaw
Europe Germany Berlin
Europe Poland Poznan
Europe Bulgaria Plovdiv
Africa Nigeria Abuja
Asia China Shanghai

Изход:
Europe:
  Bulgaria -> Sofia, Plovdiv
  Poland -> Warsaw, Poznan
  Germany -> Berlin
Asia:
  China -> Beijing, Shanghai
  Japan -> Tokyo
Africa:
  Nigeria -> Abuja

*/
/* Sets and Dictionaries Advanced 
 * 
            int n=int.Parse(Console.ReadLine());
            HashSet<string> name = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                name.Add(Console.ReadLine());
            }

            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
Вход:
8
Ivan
Pesho
Ivan
Stamat
Pesho
Alice
Peter
Pesho

Изход:
Ivan
Pesho
Stamat
Alice
Peter

 */
/* Steream, Files and Directories
 * using System.IO;
 * 
 * string fileName = "C:\\Temp\\work\\test.txt";
 * string theSamefileName = @"C:\Temp\work\test.txt";
 * 
 * StreamReader reader = new StreamReader("test.txt", Encoding.GetEncoding("Windows-1251"));  // Отваряне на файл със задаване на кодиране
 * StreamReader reader = new StreamReader("test.txt",Encoding.GetEncoding("UTF-8"));
 * 
 * using StreamReader reader = new StreamReader("../../../text.txt");
 * 
    - Using(...)--- Чете от файл и записва в друг файл всеки четен ред
            var reader = new StreamReader("../../../Input.txt");
            using (reader)
            {
                int count = 0;
                string line = reader.ReadLine();

                using (var writer = new StreamWriter("../../../output.txt", true)) // true - като Append - добавя във файла
                {
                    while (line != null)
                    {
                        if(count%2 == 1)
                        {
                            writer.WriteLine(line);
                        }
                        count++;
                        line = reader.ReadLine();
                    }
                }
            }

     using (StreamReader stream = new StreamReader("../../../text.txt"))
            {
                while ((input = stream.ReadLine()) != null)
                {
                    string[] separators = { " ", "-", ",", "." };
                    wordsInput = input.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < wordsInput.Length; i++)
                    {
                        
                        if (words.ContainsKey(wordsInput[i]))
                        {
                            words[wordsInput[i]]++;
                        }
                    }
                }
            }

    StreamReader reader = new StreamReader("../../../text.txt");
        Console.WriteLine(reader.ReadToEnd());
        reader.Close();

    using (StreamWriter writer = new StreamWriter("../../../text.txt"))
            {
                writer.WriteLine("Hello");
            }

    using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    string line;
                    int count = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (count % 2 == 0)
                        {
                            Regex regex = new Regex("[-.,!?]");
                            line = regex.Replace(line, "@");
                            var array = line.Split().ToArray().Reverse();
                            writer.WriteLine(string.Join(" ", array));
                        }
                        count++;
                    }
                }
            }

   - Динамично наименоване на файлове - в случая в цикъл:
    using (var pieceStream = new FileStream($"../../../Part-{i+1}.txt", FileMode.Create)){....}

   - Прихващане на грешки
        class HandlingExceptions
        {
          static void Main()
          {
                string fileName = @"somedir\somefile.txt";
                try
                {
                      StreamReader reader = new StreamReader(fileName);
                      Console.WriteLine("File {0} successfully opened.", fileName);
                      Console.WriteLine("File contents:");
                      using (reader)
                      {
                            Console.WriteLine(reader.ReadToEnd());
                      }
                }

                catch (FileNotFoundException) // несъществуващ файл
                {
                      Console.Error.WriteLine("Can not find file {0}.", fileName);
                }

                catch (DirectoryNotFoundException) // несъществуваща директория
                {
                      Console.Error.WriteLine("Invalid directory in the file path.");
                }

                catch (IOException) // вх-изх.грешка
                {
                      Console.Error.WriteLine("Can not open the file {0}", fileName);
                }
          }
    }

   - Byte As Text - Encoding.UTF8
        using System.Text;
        namespace _97._ByteAsString
        {
            class Program
            {
                static void Main(string[] args)
                {
                    string text = "Tova e text. Това  е текст.";
                    using(FileStream stream = new FileStream("../../../output.txt", FileMode.Create))
                    {
                        byte[] byteText = Encoding.UTF8.GetBytes(text);
                        stream.Write(byteText, 0, byteText.Length);
                    }
                }
            }
        }

namespace _05._Directory_Traversal
{
    5.	Directory Traversal
            Write a program that traverses a given directory for all files with the given extension. 
            Search through the first level of the directory only and write information about each found file in report.txt. 
            The files should be grouped by their extension. Extensions should be ordered by the count of their files descending, 
            then by name alphabetically. Files under an extension should be ordered by their size. report.txt should be saved on the Desktop. 
            Ensure the desktop path is always valid, regardless of the user.
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> fileInfo = new Dictionary<string, Dictionary<string, double>>();

            DirectoryInfo dirInfo = new DirectoryInfo("C:/Users/Мария/source/repos/Streams, Files and Directories - EX/05. Directory Traversal/obj/Debug/netcoreapp3.1");
            FileInfo[] files = dirInfo.GetFiles();

            foreach (var item in files)
            {
                if (!fileInfo.ContainsKey(item.Extension))
                {
                    fileInfo[item.Extension] = new Dictionary<string, double>();
                }
                fileInfo[item.Extension].Add(item.Name, item.Length/1024.00);
            }

            using (StreamWriter writer = new StreamWriter(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/DirectoryTraversal.txt"))
            {
                foreach (var item in fileInfo.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    writer.WriteLine(item.Key);
                    foreach (var items in item.Value.OrderByDescending(x => x.Value))
                    {
                        writer.WriteLine($"--{items.Key} - {items.Value:f3} kb");
                    }
                }
            }
        }
    }
}

namespace _06._Zip_and_Extract
{
    6.	Zip and Extract
            Write a program that creates a zip file in a given directory and extracts it in another one. 
            Use the copyMe.png file from your resources and zip it in a directory of your choice. 
            Extract the zip file in another directory, again, by your choice.
            Hint - use the ZipFile class 
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"C:/Users/Мария/source/repos/Digit_to_Text_DE", @"C:/Users/Мария/source/repos/myZipFile.zip");
            Directory.CreateDirectory(@"C:/Users/Мария/source/repos/NewFolder");
            ZipFile.ExtractToDirectory(@"C:/Users/Мария/source/repos/myZipFile.zip", @"C:/Users/Мария/source/repos/NewFolder");
        }
    }
}

*/
/* FUNCTIONAL PROGRAMMING
     1. Write a program that reads a line of text from the console. Print all the words that start with an uppercase letter in the same order you've received them in the text.
           string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(s => s[0] == s.ToUpper()[0]).ToArray();
           Console.WriteLine(string.Join("\n", words));

     2. Write a program that reads one line of integers separated by ", ". Then prints the even numbers of that sequence sorted in increasing order.
           int[] numbers = Console.ReadLine()
                .Split(", ")
                .Select((number) =>
                {
                    return int.Parse(number);
                })
                .Where(n => n % 2 == 0)
                .OrderBy((int x) =>
                {
                    return x;
                })
                .ToArray();
          Console.WriteLine(string.Join(", ", numbers));

        3. Write a program that reads one line of double prices separated by ", ". Print the prices with added VAT for all of them. 
           Format them to 2 signs after the decimal point. The order of the prices must be the same.
           VAT is equal to 20% of the price.
                decimal[] numbers = Console.ReadLine().Split(", ").Select(decimal.Parse).Select(x => x * 1.2m).ToArray();
                foreach (var item in numbers)
                {
                    Console.WriteLine($"{item:f2}");
                }

        4.  Write a program that traverses a collection of names and returns the first name, 
            whose sum of characters is equal to or larger than a given number N, which will be given on the first line. 
            Use a function that accepts another function as one of its parameters. 
            Start off by building a regular function to hold the basic logic of the program. 
            Something along the lines of Func<string, int, bool>. 
            Afterwards create your main function which should accept the first function as one of its parameters. 

            int num = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Func<string, int> getAsciiSum = p =>
            {
                int sum = 0;
                for (int i = 0; i < p.Length; i++)
                {
                    sum += p[i];
                };
                return sum;
            };
            Func<List<string>, int, Func<string, int>, string> nameResult = (names, num, getAsciiSum) => names.FirstOrDefault(p => getAsciiSum(p) >=num);
            Console.WriteLine(nameResult(names, num, getAsciiSum));

            Input:
            800
            Qvor Qnaki Petromir Sadam
            Output:
            Petromir

      5.1. Write a custom comparator that sorts all even numbers before all the odd ones in ascending order. 
           Pass it to Array.Sort() function and print the result. Use functions
                int[] nums = Console.ReadLine().ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                Array.Sort(nums, (x, y) =>
                {
                    int sorter = 0;
                    if (x % 2 ==0 && y % 2 != 0) // ако първото число е четно, а второто нечетно - остват си така
                    {
                        sorter = -1;
                    }
                    else if (x % 2 != 0 && y % 2 == 0) // ако първото число е нечетно, а второто четно - ще се разменят
                    {
                        sorter = 1;
                    }
                    else // ако и двете числа са четни или нечетни - ги подрежда по големина
                    {
                        //sorter = x - y;             // Вариант на сравнение 1
                        sorter = x.CompareTo(y);    // Вариант на сравнение 2
                    }

                    return sorter;
                });
                Console.WriteLine(string.Join(" ",nums));

      5.2. По-краткия запис на горнито решение с террнарен оператор:
                int[] nums = Console.ReadLine().ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                Array.Sort(nums, (x, y) =>
                    (x % 2 == 0 && y % 2 != 0) ? -1 :       // ако първото число е четно, а второто нечетно - остват си така
                    (x % 2 != 0 && y % 2 == 0) ? 1 :        // ако първото число е нечетно, а второто четно - ще се разменят
                    x.CompareTo(y));                        // ако и двете са четни или нечетни ги подрежда по големина
                Console.WriteLine(string.Join(" ", nums));

      6. Write a program that receives an integer N on first line. On the next N lines, read pairs of "[name], [age]". Then read three lines with:
            •	Condition - "younger" or "older"
            •	Age - Integer
            •	Format - "name", "age" or "name age"
            Depending on the condition, print the correct pairs in the correct format. 
Input 1:
5
Lucas, 20
Tomas, 18
Mia, 29
Noah, 31
Simo, 16
older
20
name age	
Output 1:
Lucas - 20
Mia - 29
Noah - 31		

Input 2:
5
Lucas, 20
Tomas, 18
Mia, 29
Noah, 31
Simo, 16
younger
20
name	
Output 2:
Tomas
Simo	

Input 3:
5
Lucas, 20
Tomas, 18
Mia, 29
Noah, 31
Simo, 16
younger
50
age	
Output 3:
20
18
29
31
16

using System;
namespace _05._Filter_By_Age
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(", ");
                people[i] = new Person() { Name = input[0], Age = int.Parse(input[1]) };
            }

            string condition = Console.ReadLine();
            int ageToFilter = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            Func<Person, bool> conditionDelegate = GetCondition(condition, ageToFilter);
            Action<Person> printerDelegate = GetPrinter(format);

            foreach (var item in people)
            {
                if (conditionDelegate(item))
                {
                    printerDelegate(item);
                }
            }
        }

        static Action<Person> GetPrinter(string format)
        {
            switch (format)
            {
                case "name":
                    return p => { Console.WriteLine($"{p.Name}"); };
                case "age":
                    return p => { Console.WriteLine($"{p.Age}"); };
                case "name age":
                    return p => { Console.WriteLine($"{p.Name} - {p.Age}"); };
                default:
                    return null;
            }
        }

        static Func<Person,bool> GetCondition(string condition, int age)
        {
            switch(condition)
            {
                case "younger": return p => p.Age <age;
                case "older": return p => p.Age >= age;
                default:
                    return null;
            }
        }
    }
}
    */
/* FUNK - получава до 16 стойности, връща стойност
   using System.Linq;

        1)  Func<string, int> myIntParse = s => int.Parse(s);
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(myIntParse).ToArray()

        2)  Write a program that executes some mathematical operations on a given collection. On the first line you are given a list of numbers. On the next lines you are passed different commands that you need to apply to all the numbers in the list:
            •	"add" -> add 1 to each number
            •	"multiply" -> multiply each number by 2
            •	"subtract" -> subtract 1 from each number
            •	"print" -> print the collection
            •	"end" -> ends the input

            Func<int, int> addNum = p => p + 1;
            Func<int, int> multiplyNum = p => p * 2;
            Func<int, int> subtractNum = p => p - 1;

            List<int> nums = Console.ReadLine().ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "add":
                        nums = nums.Select(x => addNum(x)).ToList();
                        break;
                    case "multiply":
                        nums = nums.Select(multiplyNum).ToList();
                        break;
                    case "subtract":
                        nums = nums.Select(subtractNum).ToList();
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", nums)); ;
                        break;
                    default:
                        break;
                }
            }

        3)
namespace _02._Sum_Numbers___Func // Разновидности на синтаксиса на Func
{
    class Program
    {
        Write a program that reads a line of integers separated by ", ". Print on two lines the count of numbers and their sum.
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(", ").Select(ParseNumber).ToArray();

            PrintResults(array, GetCount, Sum);                      // Вариант 1     
            PrintResults(array, GetCount, x => { return x.Sum(); }); // Вариант 2
            PrintResults(array, GetCount, x =>                       // Вариант 3 
            {
                int sum = 0;
                for (int i = 0; i < x.Length; i++)
                {
                    sum = +x[i];
                }
                return sum;
            });
        }

        static void PrintResults(int[] array, Func<int[], int> count, Func<int[], int> sum)
        {
            Console.WriteLine(count(array));
            Console.WriteLine(sum(array));
        }

        static int GetCount(int[] array)
        {
            return array.Length;
        }

        static int Sum(int[] array)
        {
            return array.Sum();
        }

        static int ParseNumber(string number)
        {
            return int.Parse(number);
        }
    }
}
 * 
 */
/* ACTION - получава до 16 стойности, не връща стойност
  1. Write a program that reads a collection of strings from the console and then prints them onto the console. 
     Each name should be printed on a new line.
     1)  string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
           foreach (var item in words)
           {
               Action<string> printWord = i => Console.WriteLine(item);
               printWord(item);
           }

     2)    string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
           Action<string> printWord = a => Console.WriteLine(String.Join(Enviroment.NewLine, a));
           printWord(words);

   2. Write a program that reads a collection of names as strings from the console, appends "Sir" in front of every name and prints it back on the console.
       1)  string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
           foreach (var item in words)
           {
               Action<string> printWord = i => Console.WriteLine($"Sir {item}");
               printWord(item);
           }

       2)  List<string> names = Console.ReadLine().Split().ToList();
           names = names.Select(n => $"Sir {n}").ToList();
           Action<string[]> printNames = a => 
               Console.WriteLine(string.Join(Enviroment.NewLine, a));
           printNames(names.ToArray());
*/
/* PREDICATE - получава стойности, връща bool
        1) You are given a lower and an upper bound for a range of integer numbers. 
           Then a command specifies if you need to list all even or odd numbers in the given range.
           input 1:
            20 30
            odd
           output 1:
            21 23 25 27 29

           input 2:
            10 30
            even
           output 2:
            10 12 14 16 18 20 22 24 26 28 30

            int[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int start = data[0];
            int end = data[1];
            string criteria = Console.ReadLine();

            Func<int, int, List<int>> listResult = (start, end) =>
             {
                 List<int> nums = new List<int>();

                 for (int i = start; i <= end; i++)
                 {
                     nums.Add(i);
                 }

                 return nums;
             };
            List<int> numbers = listResult(start, end);
            Predicate<int> criteriaPredicate = n => true;

            if (criteria == "odd")
            {
                criteriaPredicate = n => n % 2 != 0;
            }
            else
            {
                criteriaPredicate = n => n % 2 == 0;
            }
            
            numbers = MyWhere(numbers, criteriaPredicate);
            Console.WriteLine(string.Join(" ", numbers));
        }

        static List<int> MyWhere(List<int> items, Predicate<int> predicate)
        {
            List<int> result = new List<int>();
            foreach (var item in items)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        2) Write a program that reverses a collection and removes elements that are divisible by a given integer n. Use predicates/functions
            List<int> nums = Console.ReadLine().ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            nums.Reverse();
            Func<int, bool> predicate = x => x % n != 0;
            nums = nums.Where(predicate).ToList();
            Console.WriteLine(string.Join(" ",nums));
*/
/* CLASS
     Access Modifiers /променливи за контрол на достъпа/:
        public - всеки, който има достъп до този клас може да го види
        private - може да се ползва само в този клас
        internal - може да се ползва само в този проект
        protected - може да се вижда само в класове, които наследяват текущия
        променливите/полетата по Default - private
        класа по Default - internal

        ако искаме нещо да е публично - правим го на пропърти - имат {get; set;} - името е с гл.буква
        яко искаме да е частно - правим го на поле - името е с малка буква 

            namespace CarManufacturer
            {
                public class StartUp
                {
                    static void Main(string[] args)
                    {
                        string make = Console.ReadLine();
                        string model = Console.ReadLine();
                        int year = int.Parse(Console.ReadLine());
                        double fuelQuantity = double.Parse(Console.ReadLine());
                        double fuelConsumption = double.Parse(Console.ReadLine());

                        Engine engine = new Engine(650, 1000);
                        Tire[] tires = new Tire[]
                        {
                            new Tire(2008, 1200),
                            new Tire(2007, 1250),
                            new Tire(2009, 1300),
                            new Tire(2008, 1400),
                        };
                        Car firstCat = new Car();
                        Car secondCat = new Car(make, model, year);
                        Car thirdCat = new Car(make, model, year, fuelQuantity, fuelConsumption, engine,tires);
                    }
                }

                public class Car
                {
                    public Car()
                    {
                        Make = "VW";
                        Model = "Golf";
                        Year = 2025;
                        FuelQuantity = 200;
                        FuelConsumption = 10;
                    }
                    public Car(string make, string model, int year) : this()
                    {
                        Make = make;
                        Model = model;
                        Year = year;
                    }

                    public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
                    {
                        FuelQuantity = fuelQuantity;
                        FuelConsumption = fuelConsumption;
                    }

                    public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumption)
                    {
                        Engine = engine;
                        Tires = tires;
                    }
                    public string Make { get; set; }
                    public string Model { get; set; }
                    public int Year { get; set; }
                    public double FuelQuantity { get; set; }
                    public double FuelConsumption { get; set; }
                    public Engine Engine { get; set; }
                    public Tire[] Tires { get; set; }
                }

                public class Engine
                {
                    public Engine(int horsePower, double cubicCapacity)
                    {
                        HorsePower = horsePower;
                        CubicCapacity = cubicCapacity;
                    }

                    public int HorsePower { get; set; }
                    public double CubicCapacity { get; set; }
                }

                public class Tire
                {
                    public Tire(int year, double pressure)
                    {
                        Year = year;
                        Pressure = pressure;
                    }
                    public int Year { get; set; }
                    public double Pressure { get; set; }
                }
            }

*/
/* ENUMERATOR
        class Program
        {
            static void Main(string[] args)
            {
                Payment payment = Payment.Bank;
                Console.WriteLine(payment);
                DoPayment(Payment.Terminal);

                Console.WriteLine($"Cash: {(int)Payment.Cash}");
                Console.WriteLine($"GoToCanada: {(int)Payment.GoToCanada}");
                Console.WriteLine($"4: {(Payment)4}");

                for (int i = 51; i < 51+15; i++)
                {
                    Console.WriteLine($"{i}: {(Payment)i}");
                }
            }

            static void DoPayment(Payment type)
            {
                if(type == Payment.Cash)
                {
                    Console.WriteLine("Take all the money");
                }

                else if (type == Payment.GoToCanada)
                {
                    Console.WriteLine("Forget the money");
                }
                else
                {
                    Console.WriteLine(type);
                }
            }
        }

        enum Payment
        {
            Bank = 51,
            Cash,
            ShootAndRun = 60,
            GoToCanada,
            Terminal = 75
        }
 */
/* StaticClasses
    class Program
        {
            static void Main(string[] args)
            {
                BankHelpers.Name = "Pesho Bank";
                BankHelpers.CalculateDebt(55);

                Math.Max(6, 9); // класа Math е статичен и се вика без инстанция
            
                Hello1(); // когато Методът Hello1 е статичен - можем да го викаме без инстанция

                Program program = new Program(); // когато Методът Hello2 не е статичен - първо му правим инстанция, после го викаме
                program.Hello2();

             }

            static void Hello1() {Console.WriteLine("Hello 1");}

            void Hello2() {Console.WriteLine("Hello 2");}
        }
    }

    static class BankHelpers
    {
        public static string Name { get; set; }

        public static void CalculateDebt(double income)
        {
            Console.WriteLine("Mnogo");
        }
    }
*/
/* Class Example from Lab - 5.Special Cars
    namespace CarManufacturer
    {
        using System;
        using System.Collections.Generic;
        using System.Linq;

        public class StartUp
        {
            static void Main(string[] args)
            {
                string input = null;
                var cars = new List<Car>();
                var tires = new List<Tire[]>();
                var engines = new List<Engine>();

                while ((input = Console.ReadLine()) != "No more tires")
                {
                    var split = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var tire = new List<Tire>();

                    for (int i = 0; i < split.Length; i += 2)
                    {
                        var year = int.Parse(split[i]);
                        var pressure = double.Parse(split[i + 1]);
                        var newTire = new Tire(year, pressure);
                        tire.Add(newTire);
                    }

                    tires.Add(tire.ToArray());
                }

                while ((input = Console.ReadLine()) != "Engines done")
                {
                    var split = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                    for (int i = 0; i < split.Length; i += 2)
                    {
                        var horsePower = int.Parse(split[i]);
                        var cubicCapacity = double.Parse(split[i + 1]);
                        var engine = new Engine(horsePower, cubicCapacity);
                        engines.Add(engine);
                    }
                }

                while ((input = Console.ReadLine()) != "Show special")
                {
                    var split = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var make = split[0];
                    var model = split[1];
                    var year = int.Parse(split[2]);
                    var fuelQuantity = double.Parse(split[3]);
                    var fuelConsumption = double.Parse(split[4]);
                    var engine = engines[int.Parse(split[5])];
                    var tire = tires[int.Parse(split[5])];
                    var car = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tire);
                    cars.Add(car);
                }

                cars = cars
                    .Where(x => x.Year >= 2017 && x.Engine.HorsePower > 330 && x.Tires.Sum(y => y.Pressure) >= 9 && x.Tires.Sum(y => y.Pressure) <= 10)
                    .ToList();
                foreach (var car in cars)
                {
                    car.Drive(20);
                    Console.WriteLine(car.WhoAmI());
                }
            }
        }
    }

    public class Car
    {
        private Tire[] tires;

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public Engine Engine { get; set; }

        public Tire[] Tires
        {
            get => tires;
            set
            {
                if (value.Length >= 0 && value.Length <= 4)
                    tires = value;
            }
        }

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(string make, string model, int year)
            : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        public void Drive(double distance)
        {
            double distanceConsumption = distance * (this.FuelConsumption / 100);
            bool canContinue = this.FuelQuantity - distanceConsumption >= 0;

            if (canContinue)
                this.FuelQuantity -= distanceConsumption;
            else
                throw new Exception("Not enough fuel to perform this trip!");
        }

        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {this.Make}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Year: {this.Year}");
            sb.AppendLine($"HorsePowers: {this.Engine.HorsePower}");
            sb.Append($"FuelQuantity: {this.FuelQuantity}");
            return sb.ToString();
        }
    }

    public class Engine
    {
        public int HorsePower { get; set; }
        public double CubicCapacity { get; set; }
        public Engine(int horsrPower, double cubicCapacity)
        {
            this.HorsePower = horsrPower;
            this.CubicCapacity = cubicCapacity;
        }
    }

    public class Tire
    {
        public int Year { get; set; }
        public double Pressure { get; set; }
        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }
    }
*/
/* Class Example fron EX - 03. Oldest Family Member
        Use your Person class from the previous tasks. Create a class Family. 
        The class should have a list of people, a method for adding members - void AddMember(Person member) 
        and a method returning the oldest family member – Person GetOldestMember(). 
        Write a program that reads the names and ages of N people and adds them to the family. 
        Then print the name and age of the oldest member. 
Input 1:
3
Pesho 3
Gosho 4
Annie 5
Output 1:
Annie 5

Input 2:
5
Steve 10
Christopher 15
Annie 4
Ivan 35
Maria 34
Outpit 2:
Ivan 35
------------- CODE:
using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
           
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = line[0];
                int age = int.Parse(line[1]);

                Person person = new Person(age, name);

                family.AddMember(person);
            }

            Person oldestPerson = family.GetOldestMember();

            Console.WriteLine(oldestPerson.Name+" "+oldestPerson.Age);
        }
    }
}

public class Person
    {
        public Person()
        {
            Name = "No name";
            Age = 1;
        }
        public Person(int age):this()
        {
            Age = age;
        }
        public Person(int age, string name):this(age)
        {
            Name =name;
        }
        public int Age { get; set; }
        public string Name { get; set; }
    }

public class Family
    {
        public Family()
        {
            People = new List<Person>(); 
        }
        public List<Person> People { get; set; }
        public void AddMember(Person member)
        {
            People.Add(member);
        }

        public Person GetOldestMember()
        {
            //// Вариант 1
            int maxAge = int.MinValue;
            Person oldestMember = null;
            foreach (var item in People)
            {
                var currentAge = item.Age;
                if (currentAge > maxAge)
                {
                    maxAge = currentAge;
                    oldestMember = item;
                }
            }
            return oldestMember;

            //Вариант 2
            //Person oldestMember = People.OrderByDescending(x => x.Age).ToArray().First(); // 2.1

            //Person oldestMember = People.OrderByDescending(x => x.Age).ToArray()[0];      // 2.2
            //return oldestMember;

            //return People.OrderByDescending(x => x.Age).ToArray()[0];


            // Вариант 3 
            //public Person GetOldestMember()
                => return People.OrderByDescending(x => x.Age).ToArray()[0];
        }
    }
 */
/* Class Example forn EX - 04.Defining Classes-Opinion Poll
        Using the Person class, write a program that reads from the console N lines of personal information and then prints all people, 
        whose age is more than 30 years, sorted in alphabetical order.
Input 1:
3
Pesho 12
Stamat 31
Ivan 48
Output 1:
Ivan - 48
Stamat - 31

Input 2:
5
Nikolai 33
Yordan 88
Tosho 22
Lyubo 44
Stanislav 11
Output 2:
Lyubo - 44
Nikolai - 33
Yordan - 88
 
------- CODE:
using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = line[0];
                int age = int.Parse(line[1]);

                Person person = new Person(age, name);

                family.AddMember(person);
            }

            Person[] resultArray = family.GetPeople();

            foreach (var item in resultArray)
            {
                Console.WriteLine(item.Name + " - " + item.Age);
            }
        }
    }
}

    public class Person
    {
        public Person()
        {
            Name = "No name";
            Age = 1;
        }
        public Person(int age):this()
        {
            Age = age;
        }
        public Person(int age, string name):this(age)
        {
            Name =name;
        }
        public int Age { get; set; }
        public string Name { get; set; }
    }
    
    public class Family
    {
        public Family()
        {
            People = new List<Person>(); 
        }
        public List<Person> People { get; set; }
        public void AddMember(Person member)
        {
           People.Add(member);
        }

        public Person[] GetPeople()
        {
            var people = People.Where(x=> x.Age>30).OrderBy(x => x.Name).ToArray();
            return people;
        }
    }
 */
/* Class Example from EX - 05.Date Modifier
        Create a class DateModifier, which stores the difference of the days between two dates. 
        It should have a method which takes two string parameters representing a date as strings and calculates the difference in the days between them. 
Input 1:
1992 05 31
2016 06 17
Outut 1:
8783

Input 2:
2016 05 31
2016 04 19
Output 2:
42
--------- CODE:
using System;

namespace DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();
            DateModifier dateModifier = new DateModifier();
            Console.WriteLine(dateModifier.GetDaysDifference(start, end));
        }
    }
}

    public class DateModifier
    {
        public int GetDaysDifference(string startDateString, string endDateString)
        {
            //1992 05 31 - year montht day
            //2016 06 17
            DateTime startDate = DateTime.Parse(startDateString);
            DateTime endtDate = DateTime.Parse(endDateString);

            var totalDays = Math.Abs((int)(endtDate- startDate).TotalDays);

            return totalDays;
        }
    }
 */
/* Class Example from EX - 06. Speed Racing
        Write a program that keeps track of cars and their fuel and supports methods for moving the cars. Define a class Car. Each Car has the following properties:
        •	string Model
        •	double FuelAmount
        •	double FuelConsumptionPerKilometer
        •	double Travelled distance
        A car’s model is unique - there will never be 2 cars with the same model. On the first line of the input, you will receive a number N – the number of cars you need to track. On each of the next N lines, you will receive information about a car in the following format: 
        "{model} {fuelAmount} {fuelConsumptionFor1km}"
        All cars start at 0 kilometers traveled. After the N lines, until the command "End" is received, you will receive commands in the following format: 
        "Drive {carModel} {amountOfKm}"
        Implement a method in the Car class to calculate whether or not a car can move that distance. If it can, the car’s fuel amount should be reduced by the amount of used fuel and its traveled distance should be increased by the number of the traveled kilometers. Otherwise, the car should not move (its fuel amount and the traveled distance should stay the same) and you should print on the console:
        "Insufficient fuel for the drive"
        After the "End" command is received, print each car and its current fuel amount and the traveled distance in the format:
         "{model} {fuelAmount} {distanceTraveled}"
        Print the fuel amount formatted two digits after the decimal separator
Input 1:
2
AudiA4 23 0.3
BMW-M2 45 0.42
Drive BMW-M2 56
Drive AudiA4 5
Drive AudiA4 13
End
Output 1:
AudiA4 17.60 18
BMW-M2 21.48 56

Input 2:
3
AudiA4 18 0.34
BMW-M2 33 0.41
Ferrari-488Spider 50 0.47
Drive Ferrari-488Spider 97
Drive Ferrari-488Spider 35
Drive AudiA4 85
Drive AudiA4 50
End
Output 2:
Insufficient fuel for the drive
Insufficient fuel for the drive
AudiA4 1.00 50
BMW-M2 33.00 0
Ferrari-488Spider 4.41 97

------- CODE:
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            string line;

            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine();
                string[] input = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumption = double.Parse(input[2]);
                
                Car car = new Car(model, fuelAmount, fuelConsumption);
                cars.Add(car);
            }

            while((line = Console.ReadLine()) != "End")
            {
                string[] input = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[1];
                int amount = int.Parse(input[2]);

                //Car[] car = cars.Where(x => x.Model == model).ToArray(); // когато търсим колекция от инстанции по условие
                Car car = cars.FirstOrDefault(x => x.Model == model); 

                car.Drive(amount);
            }
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:F2} {item.TravelledDistance}");
            }
        }
    }
}

    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = 0;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }
        public void Drive(int amountOfKm)
        {
            double neededLiters = FuelConsumptionPerKilometer * amountOfKm;
            bool canMove = FuelAmount - neededLiters >= 0;

            if (canMove)
            {
                FuelAmount -= neededLiters;
                TravelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
 */
/* Class Example form EX - 07.Raw Data
        Write a program that tracks cars and their cargo. Define a class Car that holds an information about model, engine, cargo and a collection of exactly 4 tires. The engine, cargo and tire should be separate classes. Create a constructor that receives all of the information about the Car and creates and initializes its inner components (engine, cargo and tires).
        On the first line of input, you will receive a number N - the number of cars you have. On each of the next N lines, you will receive an information about each car in the format:
        "{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType} {tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"
        The speed, power, weight and tire age are integers and tire pressure is a double. 
        After the N lines, you will receive a single line with one of the following commands: 
        •	"fragile" - print all cars whose cargo is "fragile" with a tire, whose pressure is  < 1
        •	"flamable" - print all of the cars, whose cargo is "flamable" and have engine power > 250
        The cars should be printed in order of appearing in the input.
Input 1:
2
ChevroletAstro 200 180 1000 fragile 1.3 1 1.5 2 1.4 2 1.7 4
Citroen2CV 190 165 1200 fragile 0.9 3 0.85 2 0.95 2 1.1 1
fragile
Output 1:
Citroen2CV

Input2:
4
ChevroletExpress 215 255 1200 flamable 2.5 1 2.4 2 2.7 1 2.8 1
ChevroletAstro 210 230 1000 flamable 2 1 1.9 2 1.7 3 2.1 1
DaciaDokker 230 275 1400 flamable 2.2 1 2.3 1 2.4 1 2 1
Citroen2CV 190 165 1200 fragile 0.8 3 0.85 2 0.7 5 0.95 2
flamable
Output 2:
ChevroletExpress
DaciaDokker

------------ Code:
using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];

                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);

                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                
                Tire[] tires = new Tire [4];
                int num = 0;
                for (int j = 5; j < input.Length; j+=2)
                {
                    double tirePressure = double.Parse(input[j]);
                    int tireAge = int.Parse(input[j+1]);

                    Tire tire = new Tire(tirePressure, tireAge);
                    tires[num++] = tire;
                }

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            string command = Console.ReadLine();  
            
            if(command == "fragile") // "fragile" - print all cars whose cargo is "fragile" with a tire, whose pressure is  < 1
            {
                var fragileCars = cars.Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(p => p.Pressure < 1)).ToList();
                foreach (var item in fragileCars)
                {
                    Console.WriteLine(item.Model);
                }
            }

            if (command == "flamable") // "flamable" - print all of the cars, whose cargo is "flamable" and have engine power > 250
            {
                var flamableCar = cars.Where(x => x.Cargo.Type == "flamable" && x.Engine.Power>250).ToList();
                foreach (var item in flamableCar)
                {
                    Console.WriteLine(item.Model);
                }
            }
        }
    }
}

    public class Car
        {
        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tires = tires;
        }
        
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tires { get; set; }
    }

    public class Cargo
    {
        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }

        public int Weight { get; set; }
        public string Type { get; set; }
    }

    public class Engine
    {
        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }

        public int Speed { get; set; }
        public int Power { get; set; }
    }
 */
/* Class Example from EX - 08.Car Salesman
        Define two classes Car and Engine. 
        Car has the following properties:
        •	Model
        •	Engine
        •	Weight 
        •	Color
        Engine has the following properties:
        •	Model
        •	Power
        •	Displacement
        •	Efficiency
        A Car’s weight and color and its Engine’s displacement and efficiency are optional. 
        On the first line, you will read a number N, which will specify how many lines of engines you will receive. On each of the next N lines, you will receive information about an Engine in the following format: 
        "{model} {power} {displacement} {efficiency}"
        After the lines with engines, you will receive a number M. On each of the next M lines, an information about a Car will follow in the format:
         "{model} {engine} {weight} {color}" 
        The engine will be the model of an existing Engine. When creating the object for a Car, you should keep a reference to the real engine in it, instead of just the engine’s model. Note that the optional properties might be missing from the formats.
        Your task is to print all the cars in the order they were received and their information in the format defined bellow. If any of the optional fields is missing, print "n/a" in its place:
 
        {CarModel}:
          {EngineModel}:
            Power: {EnginePower}
            Displacement: {EngineDisplacement}
            Efficiency: {EngineEfficiency}
          Weight: {CarWeight}
          Color: {CarColor}
        Bonus*
        Override the classes’ ToString() methods to have a reusable way of displaying the objects.
Input 1:
2
V8-101 220 50
V4-33 140 28 B
3
FordFocus V4-33 1300 Silver
FordMustang V8-101
VolkswagenGolf V4-33 Orange 
Output 1:
FordFocus:
  V4-33:
    Power: 140
    Displacement: 28
    Efficiency: B
  Weight: 1300
  Color: Silver
FordMustang:
  V8-101:
    Power: 220
    Displacement: 50
    Efficiency: n/a
  Weight: n/a
  Color: n/a
VolkswagenGolf:
  V4-33:
    Power: 140
    Displacement: 28
    Efficiency: B
  Weight: n/a
  Color: Orange

Input 2:
4
DSL-10 280 B
V7-55 200 35
DSL-13 305 55 A+
V7-54 190 30 D
4
FordMondeo DSL-13 Purple
VolkswagenPolo V7-54 1200 Yellow
VolkswagenPassat DSL-10 1375 Blue
FordFusion DSL-13
Output 2:
FordMondeo:
  DSL-13:
    Power: 305
    Displacement: 55
    Efficiency: A+
  Weight: n/a
  Color: Purple
VolkswagenPolo:
  V7-54:
    Power: 190
    Displacement: 30
    Efficiency: D
  Weight: 1200
  Color: Yellow
VolkswagenPassat:
  DSL-10:
    Power: 280
    Displacement: n/a
    Efficiency: B
  Weight: 1375
  Color: Blue
FordFusion:
  DSL-13:
    Power: 305
    Displacement: 55
    Efficiency: A+
  Weight: n/a
  Color: n/a

----------------- Code:
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string engineModel = input[0];
                int power = int.Parse(input[1]);
                string displacement = "n/a";
                string efficiency = "n/a";

                if (input.Length == 3)
                {
                    if (Char.IsDigit(input[2][0]))
                    {
                        displacement = input[2];
                    }
                    else
                    {
                        efficiency = input[2];
                    }
                }

                if (input.Length == 4)
                {
                    displacement = input[2];
                    efficiency = input[3];
                }
                Engine engine = new Engine(engineModel, power, displacement, efficiency);
                engines.Add(engine);
            }

            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                
            string model = input[0];
            string engine = input[1];
            string weight = "n/a";
            string color = "n/a";

            if (input.Length == 3)
            {
                if (Char.IsDigit(input[2][0]))
                {
                    weight = input[2];
                }
                else
                {
                    color = input[2];
                }
            }

            if (input.Length == 4)
            {
                weight = input[2];
                color = input[3];
            }
            Car car = new Car(model, engine, weight, color);
            cars.Add(car);
        }


            foreach (var item in cars)
            {
                item.ToString();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.EngineModel}:");
                Engine engine = engines.FirstOrDefault(x => x.Model == car.EngineModel);
                Console.WriteLine($"    Power: {engine.Power}");
                Console.WriteLine($"    Displacement: {engine.Displacement}");
                Console.WriteLine($"    Efficiency: {engine.Efficiency}");
                Console.WriteLine($"  Weight: {car.Weight}");
                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}

    public class Car
    {
        
        public Car(string model, string engineModel, string weight, string color)
        {
            Model = model;
            EngineModel = engineModel;
            Weight = weight;
            Color = color;
        }

        public string Model { get; set; }
        public string EngineModel { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }
    }

    public class Engine
    {
        public Engine(string engineModel, int power, string displacement, string efficiency)
        {
            Model = engineModel;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public string Model { get; set; }
        public int Power { get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }
    }
 */
/* Class Example from EX - 09.Pokemon Trainer
        Define a class Trainer and a class Pokemon. 
        Trainers have:
        •	Name
        •	Number of badges
        •	A collection of pokemon
        Pokemon have:
        •	Name
        •	Element
        •	Health
        All values are mandatory. Every Trainer starts with 0 badges.
        You will be receiving lines until you receive the command "Tournament". Each line will carry information about a pokemon and the trainer who caught it in the format:
        "{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"
        TrainerName is the name of the Trainer who caught the pokemon. Trainers’ names are unique.
        After receiving the command "Tournament", you will start receiving commands until the "End" command is received. They can contain one of the following:
        •	"Fire"
        •	"Water"
        •	"Electricity"
        For every command you must check if a trainer has at least 1 pokemon with the given element. If he does, he receives 1 badge. Otherwise, all of his pokemon lose 10 health. If a pokemon falls to 0 or less health, he dies and must be deleted from the trainer’s collection. In the end, you should print all of the trainers, sorted by the amount of badges they have in descending order (if two trainers have the same amount of badges, they should be sorted by order of appearance in the input) in the format: 
        "{trainerName} {badges} {numberOfPokemon}"
input 1:
Pesho Charizard Fire 100
Gosho Squirtle Water 38
Pesho Pikachu Electricity 10
Tournament
Fire
Electricity
End
Output 1:
Pesho 2 2
Gosho 0 1
 
Input2:
Output
Pesho 2 2
Gosho 0 1
Output2:
Nasko 1 1
Stamat 0 0
Jicata 0 1
------------------------------- CODE:
using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer // 100%
{
    public class Program
    {
        static List<Trainer> trainers;

        static void Main(string[] args)
        {
            int count = 0;
            int pokemonsCount = 0;
            string line;

            trainers = new List<Trainer>();
            while ((line = Console.ReadLine().Trim()) != "Tournament")
            {
                string[] input = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                // string name, string PokemonName, string PokemonElement, int PokemonHealth
                string name = input[0];
                string PokemonName = input[1];
                string PokemonElement = input[2];
                int PokemonHealth = int.Parse(input[3]);
                Trainer trainer;
                if ((trainer = GetTrainer(name)) == null)
                {
                    trainer = new Trainer(name, PokemonName, PokemonElement, PokemonHealth);
                    trainers.Add(trainer);
                }
                else
                    trainer.AddPokemon(PokemonName, PokemonElement, PokemonHealth);
            }
            
            while ((line = Console.ReadLine().Trim()) != "End")
            {
                foreach (var currentTrainer in trainers)
                {
                    foreach (var pokemon in currentTrainer.PokemonList)
                    {
                        if (pokemon.Element == line && pokemon.Health > 0)
                        {
                            count++;
                        }
                    }
                    if (count > 0)
                        currentTrainer.Badges++;
                    else
                    {
                        foreach (var pokemon in currentTrainer.PokemonList)
                        {
                            pokemon.Health -= 10;
                        }
                    }
                    count = 0;
                }
            }

            foreach (var currentTrainer in trainers.OrderByDescending(x => x.Badges))
            {
                foreach (var pokemon in currentTrainer.PokemonList)
                {
                    if (pokemon.Health > 0)
                    {
                        pokemonsCount++;
                    }
                }
                Console.WriteLine($"{currentTrainer.name} {currentTrainer.Badges} {pokemonsCount}");
                pokemonsCount = 0;
            }
        }

        static Trainer GetTrainer(string name)
            => trainers.FirstOrDefault(x => x.name == name);
    }
}

    public class Pokemon
    {
        public Pokemon(string name, string element, int health)
        {
            Name = name;
            Element = element;
            Health = health;
        }

        public string Name { get; set; }
        public string Element { get; set; }
        public int Health { get; set; }
    }

    public class Trainer
    {
        public string name;
        
        public Trainer(string name, string PokemonName, string PokemonElement, int PokemonHealth)
        {
            this.name = name; // трябва да е с this.name (this.Name - дава грешка)
            Badges = 0;
            PokemonList = new List<Pokemon>();
            AddPokemon(PokemonName, PokemonElement, PokemonHealth);
        }
        
        public int Badges { get; set; }
        public List<Pokemon> PokemonList { get; set; }

        public void AddPokemon(string name, string element, int health)
        {
            Pokemon pokemon = new Pokemon(name, element, health);
            PokemonList.Add(pokemon);
        }
    }
 */
/* Class Example from EX - 10.SoftInoParking 
        Your task is to create a repository, which stores cars by creating the classes described below.
        First, write a C# class Car with the following properties:
        •	Make: string
        •	Model: string
        •	HorsePower: int
        •	RegistrationNumber: string
        public class Car 
        {	
            // TODO: implement this class
        }
        The class' constructor should receive make, model, horsePower and registrationNumber and override the ToString() method in the following format:
        "Make: {make}"
        "Model: {model}"
        "HorsePower: {horse power}"
        "RegistrationNumber: {registration number}"
        Write a C# class Parking that has Cars (a collection which stores the entity Car). All entities inside the class have the same properties.
        public class Parking 
        {
            // TODO: implement this class
        }
        The class' constructor should initialize the Cars with a new instance of the collection and accept capacity as a parameter. 
        Implement the following fields:
        •	Field cars –  a collection that holds added cars.
        •	Field capacity – accessed only by the base class (responsible for the parking capacity).
        Implement the following methods:
        AddCar(Car Car)
        The method first checks if there is already a car with the provided car registration number and if there is, the method returns the following message:
        "Car with that registration number, already exists!"
        Next checks if the count of the cars in the parking is more than the capacity and if it is returns the following message:
        "Parking is full!"
        Finally if nothing from the previous conditions is true it just adds the current car to the cars in the parking and returns the message:
        "Successfully added new car {Make} {RegistrationNumber}"
        RemoveCar(string RegistrationNumber)
        Removes a car with the given registration number. If the provided registration number does not exist returns the message: 
        "Car with that registration number, doesn't exist!"
        Otherwise, removes the car and returns the message:
        "Successfully removed {registrationNumber}"
        GetCar(string RegistrationNumber)
        Returns the Car with the provided registration number.
        RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        A void method, which removes all cars that have the provided registration numbers. Each car is removed only if the registration number exists.
        And the following property:
        •	Count - Returns the number of stored cars.
        Examples
        This is an example how the Parking class is intended to be used. 


using System;

namespace SoftUniParking
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var car = new Car("Skoda", "Fabia", 65, "CC1856BG");
            var car2 = new Car("Audi", "A3", 110, "EB8787MN");

            Console.WriteLine(car.ToString());
            //Make: Skoda
            //Model: Fabia
            //HorsePower: 65
            //RegistrationNumber: CC1856BG

            var parking = new Parking(5);
            Console.WriteLine(parking.AddCar(car));
            //Successfully added new car Skoda CC1856BG

            Console.WriteLine(parking.AddCar(car));
            //Car with that registration number, already exists!

            Console.WriteLine(parking.AddCar(car2));
            //Successfully added new car Audi EB8787MN

            Console.WriteLine(parking.GetCar("EB8787MN").ToString());
            //Make: Audi
            //Model: A3
            //HorsePower: 110
            //RegistrationNumber: EB8787MN

            Console.WriteLine(parking.RemoveCar("EB8787MN"));
            //Successfullyremoved EB8787MN

            Console.WriteLine(parking.Count); //1

        }
    }
}

    public class Car
    {
        public Car(string make, string model, int horsePower, string registrationNumber)
        {
            Make = make;
            Model = model;
            HorsePower = horsePower;
            RegistrationNumber = registrationNumber;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }
        public override string ToString() // заменяме оригиналния ToString() с наш
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Make: {Make}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"HorsePower: {HorsePower}");
            sb.AppendLine($"RegistrationNumber: {RegistrationNumber}");

            return sb.ToString().TrimEnd();
        }
    }

    public class Parking
    {
        private List<Car> cars;
        private int capacity;
        public Parking(int capacity)
        {
            this.capacity=capacity;
            this.cars = new List<Car>();
        }
        public int Count
            => this.cars.Count; // връща броя на колите
        public string AddCar(Car car)
        {
            bool exists = cars.Any(x => x.RegistrationNumber == car.RegistrationNumber);

            if (exists)
            {
                 return "Car with that registration number, already exists!";
            }

            if(capacity== cars.Count)
            {
                return "Parking is full!";
            }

            cars.Add(car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public string RemoveCar(string registrationNumber)
        {
            Car car = cars.FirstOrDefault(x => x.RegistrationNumber == registrationNumber);
            if (car==null)
            {
                return "Car with that registration number, doesn't exist!";
            }
            else
            {
                cars.Remove(car);
                return $"Successfully removed {registrationNumber}";
            }
        }
        public Car GetCar(string registrationNumber)
            => cars.FirstOrDefault(x => x.RegistrationNumber == registrationNumber);

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var item in registrationNumbers)
            {
                Car car = cars.FirstOrDefault(x => x.RegistrationNumber == item);
                cars.Remove(car); // ако колата не съществува, ако подадем NULL - ще върне False - не е нужна проверка
            }
        }
    }
 */
/* Custom LINKED LIST
        In this workshop, we are going to create another custom data structure, which has similar functionalities as the C# doubly linked list. Just like the structures from the previous workshop, our custom doubly linked list will work only with integers. It will have the following functionalities: 
        •	void AddFirst(int element) – adds an element at the beginning of the collection
        •	void AddLast(int element) – adds an element at the end of the collection
        •	int RemoveFirst() – removes the element at the beginning of the collection
        •	int RemoveLast() – removes the element at the end of the collection
        •	void ForEach() – goes through the collection and executes a given action
        •	int[] ToArray() – returns the collection as an array
        Feel free to implement your own functionality or to write the methods by yourself. 
        NOTE: You need a StartUp class with the namespace CustomDoublyLinkedList.
--------- CODE
using System;

namespace CustomDoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            for (int i = 0; i < 5; i++)
            {
                list.AddFirst(new Node(i));
            }

            for (int i = 15; i < 20; i++)
            {
                list.AddLast(new Node(i));
            }

            list.PrintList();
            list.RemoveFirst();
            list.RemoveLast();
            Console.WriteLine();

            list.Remove(2); // изтрива елемент със стойност 2
            list.PrintList();
            list.PrintList();

            Console.WriteLine(list.ToArray().Length);

            //Console.WriteLine(list.Pop().Value);

            //list.PrintList();
            //list.ReversePrintList();

            //Node currentHead = list.Head;
            //Console.WriteLine("CurrentHead "+currentHead.Value);
            //Console.WriteLine("Next "+currentHead.Next.Value);
            //Console.WriteLine("Next "+currentHead.Next.Next.Value);
            //Console.WriteLine("Next "+currentHead.Next.Next.Next.Value);

            //while(currentHead != null)
            //{
            //    Console.WriteLine(currentHead.Value);
            //    currentHead = currentHead.Next;
            //}
        }
    }
}

    public class Node
    {
        public Node(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }
    }

    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public void AddFirst(Node nodeNewHead)
        {
            if (Head == null)
            {
                Head = nodeNewHead;
                Tail = nodeNewHead;
            }
            else
            {
                nodeNewHead.Next = Head;
                Head.Previous = nodeNewHead;
                Head = nodeNewHead;
            }
        }

        public void AddLast(Node nodeNewTail)
        {
            if(Tail== null)
            {
                Tail = nodeNewTail;
                Head = nodeNewTail;
            }
            else
            {
                nodeNewTail.Previous = Tail;
                Tail.Next = nodeNewTail;
                Tail = nodeNewTail;
            }

        }

        public Node RemoveFirst()
        {
            var oldHead = this.Head;
            this.Head = this.Head.Next;
            this.Head.Previous = null;
            return oldHead;
        }

        public Node RemoveLast()
        {
            var oldTail = this.Tail;
            Tail = this.Tail.Previous;
            Tail.Next = null;
            return oldTail;
        }

        public void ForEach(Action<Node> action)
        {
            Node currentNode = Head;
            while(currentNode != null)
            {
                action(currentNode);
                currentNode = currentNode.Next;
            }
        }

        public void PrintList()
        {
            this.ForEach(node => Console.WriteLine(node.Value));
        }

        public Node[] ToArray()
        {
            List<Node> list = new List<Node>();
            this.ForEach(node => list.Add(node));
            return list.ToArray();
        }

        public void ReverseForEach(Action<Node> action)
        {
            Node currentNode = Tail;
            while (currentNode != null)
            {
                action(currentNode);
                currentNode = currentNode.Previous;
            }
        }

        public void ReversePrintList()
        {
            this.ReverseForEach(node => Console.WriteLine(node.Value));
        }

        public void ReversePrintList_1()
        {
            Node currentNode = Tail;
            while(currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Previous;
            }
        }

        public void PrintList_1()
        {
            Node currentNode = Head;
            while(currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }

        public Node Pop()
        {
            var oldHead = this.Head;
            this.Head = this.Head.Next;
            return oldHead;
        }

        public bool Contains(int value)
        {
            bool isFaund =false;
            ForEach(node =>
            {
                if (node.Value == value) isFaund = true;
            });

            return isFaund;
        }

        public bool Remove( int value) // // Изтрива елемента със стойност value
        {
            Node currentNode = Head;
            while(currentNode != null)
            {
                if(currentNode.Value == value)
                {
                    currentNode.Previous.Next = currentNode.Next;       // прехвърля връзките в двете посоки
                    currentNode.Next.Previous = currentNode.Previous;
                    return true;
                }
                currentNode = currentNode.Next;
            }

            return false;
        }
    }
 */
/* Custom LIST and STACK
        In this workshop we will create our own custom data structures – a custom list and a custom stack. The custom list will have similar functionality to C# lists that you've used before. Our custom list will work only with integers for now, but this will be fixed later in the course. It will have the following functionality: 
        •	void Add(int element) - Adds the given element to the end of the list
        •	int RemoveAt(int index) - Removes the element at the given index
        •	bool Contains(int element) - Checks if the list contains the given element returns (True or False)
        •	void Swap(int firstIndex, int secondIndex) - Swaps the elements at the given indexes
        Feel free to implement your own functionality or to write the methods by yourself. 
        The custom stack will also have similar functionality to the C# stack and again, we will make it work only with integers. Later on, we will learn how to implement it in a way that will allow us to work with any types. It will have the following functionality:
        •	void Push(int element) – Adds the given element to the stack
        •	int Pop() – Removes the last added element
        •	int Peek() – Returns the last element in the stack without removing it
        •	void ForEach(Action<int> action) – Goes through each of the elements in the stack
        Feel free to implement your own functionality or to write the methods by yourself.
----- CODE ------
using _2.CustomListClass;
using System;

namespace CustomListClass
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            CustomList myCustomList = new CustomList();

            for (int i = 0; i < 5; i++)
            {
                myCustomList.Add(i);
            }

            myCustomList.Insert(1, 6);

            myCustomList.RemoveAt(1);

            Console.WriteLine(myCustomList.Contains(3));
            myCustomList.Swap(1,3);
            Console.WriteLine(myCustomList); // CW работи с обекти и сам вика ToString();


            Console.WriteLine("---- Stack ----");
            CustomStack myCustomStack = new CustomStack();
            for (int i = 0; i < 5; i++)
            {
                myCustomStack.Push(i);
                //Console.WriteLine(myCustomStack.Peek());
            }

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(myCustomStack.Peek());
            //    Console.WriteLine(myCustomStack.Pop());
            //}

            myCustomStack.ForEach(x => // вариант за печат 1
            {
                Console.WriteLine(x);
            });

            myCustomStack.ForEach(Console.WriteLine); // вариант за печат 2, защото самия Console.WriteLine e Action
        }
    }
}
 
public class CustomList
    {
        private const int INITIAL_CAPACITY = 2;
        //private readonly int[] items;
        private  int[] items;

        public CustomList() // // конструктора задава първоначалния капацитет на 2
        {
            this.items = new int[INITIAL_CAPACITY];
        }
        public int Count { get; private set; } //  съдържа боя на значещите елементи

        public void Add(int item)       // добавя елемент в масива
        {
            if(this.Count == this.items.Length)
            {
                this.Resize();
            }
            this.items[this.Count] = item;
            this.Count++;
        }

        public int RemoveAt(int index)  // изтрива елемент на дадена позиция и връща стойността на изтрития елемент 
        {
            if (!this.IsValidIndex(index)) // валидация на индекса
            {
                throw new ArgumentOutOfRangeException();
            }

            int removedItem = this.items[index]; // елемента, който ще изтриваме
            this.items[index] = default(int);   // нулира стойността на елемента
            this.ShiftToLeft(index);                  // праща за изтриване и преместване на сл.елементи

            this.items[Count-1] = default;
            this.Count--;                       // намалява стойността на значещите елементи с 1

            if(this.Count <= this.items.Length/4)
            {
                this.Shrink();  // свива капацитета на масива
            }

            return removedItem;
        }

        public void Insert(int index, int element) // вмъква елемент на определена позиция
        {
            if (!IsValidIndex(index))
            {
                throw new ArgumentOutOfRangeException();
            }

            if(this.Count== this.items.Length)
            {
                this.Resize();
            }

            this.ShiftToRight(index);
            this.items[index] = element;
            this.Count++;
        }

        public bool Contains(int item) // връща true ако има този елемент, ако не - връща false
        {
            for (int i = 0; i < this.Count; i++)
            {
                int currentElement = this.items[i];

                if (currentElement == item)
                {
                    return true;
                }
            }

            return false;
        }

        public void Swap(int firstIndex, int secondIndex)   // местата на два елемента по техн.индекси
        {
            if(!IsValidIndex(firstIndex) || !IsValidIndex(secondIndex))
            {
                throw new ArgumentOutOfRangeException();
            }

            // Aditional Variable - бавен и лесен метод
            //int currentItem = this.items[firstIndex];
            //this.items[firstIndex] = this.items[secondIndex];
            //this.items[secondIndex] = currentItem;

            // Bitwise - много бърз, пести памет
            // x = x ^ y;
            // y = x ^ y;
            // x = x ^ y;
            this.items[firstIndex] = this.items[firstIndex] ^ this.items[secondIndex];
            this.items[secondIndex] = this.items[firstIndex] ^ this.items[secondIndex];
            this.items[firstIndex] = this.items[firstIndex] ^ this.items[secondIndex];
        }

        public int this[int index] // Индексатор/4
        { 
            get 
            {
                if (!this.IsValidIndex(index))
                {
                    throw new ArgumentOutOfRangeException();
                }
                return this.items[index];
            }
            set 
            {
                if (!this.IsValidIndex(index))
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.items[index] = value; // записва стойността след = (value)
            }

        }

        private void Resize()   // удвоява капацитета на масива
        {
            int[] copy = new int[this.items.Length*2];
            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }
            items = copy;
        } 

        private void Shrink()  // свива капацитета на масива
        {
            int[] copy = new int[this.items.Length / 2];

            for (int i = 0; i < this.Count; i++)
            {
                this.items[i] = copy[i];
            }

            this.items = copy;

        } 

        private void ShiftToLeft(int index) // изтрива определена позиция и премества следващите елементи с една позиция назад/наляво
        {
            for (int i = index; i < this.Count-1; i++)
            {
                this.items[i] = this.items[i + 1];
            }
        } 

        private void ShiftToRight(int index)   // от определена позиция премества следващите елементи с една позиция надясно
        {
            for (int i = Count; i > index; i--)
            {
                this.items[i] = this.items[i-1];
            }
        }

        private bool IsValidIndex(int index) // проверява дали индекса е валиден
        => index < this.Count;

        public override string ToString() // наш ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.Count; i++)
            {
                if(i == this.Count - 1)
                {
                    // Final iteration
                    sb.Append($"{this.items[i]}");
                }
                else
                {
                    sb.Append($"{this.items[i]}, ");
                }
            }
            
            return sb.ToString().TrimEnd(); // ползвай TrimEnd() за да не остават празни редове
        }
    }

class CustomStack
    {
        private const int INITIAL_CAPACITY = 4;
        private const string EMPTY_STACK_EXC_MSG = "Stack is empty"; // правя къстъм съобщение, което викам при грешка

        private int[] items;

        public CustomStack() // конструктора задава първоначалния капацитет на 4
        {
            this.items = new int[INITIAL_CAPACITY];
        }

        public int Count { get; private set; } //  съдържа боя на значещите елементи

        public void Push(int item)  // добавя елемент в масива
        {
            if (this.Count == this.items.Length)
            {
                this.Resize();
            }
            this.items[this.Count] = item;
            this.Count++;
        }

        public int Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException(EMPTY_STACK_EXC_MSG);
            }

            int poppedIten =this.items[this.Count - 1];
            this.items[this.Count-1] = default;
            this.Count--;

            return poppedIten;
        }

        public int Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException(EMPTY_STACK_EXC_MSG);
            }

            int poppedIten = this.items[this.Count - 1];
           
            return poppedIten;
        }

        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < this.Count; i++)
            {
                // action(this.items[i]); // от първия към посления
                action(this.items[this.Count -i -1]); // от последния към първия
            }
        }

        private void Resize()    // удвоява капацитета на масива
        {
            int[] copy = new int[this.items.Length * 2];
            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }
            items = copy;
        }
    }
 
 */
/* Iterators - 20 Lectures-EX 1.ListIterator 
        Create a generic class ListyIterator. The collection, which it will iterate through, should be received in the constructor. You should store the elements in a List. The class should have three main functions:
        •	Move - should move an internal index position to the next index in the list. The method should return true, if it had successfully moved the index and false if there is no next index.
        •	HasNext - should return true, if there is a next index and false, if the index is already at the last element of the list.
        •	Print - should print the element at the current internal index. Calling Print on a collection without elements should throw an appropriate exception with the message "Invalid Operation!". 
        By default, the internal index should be pointing to the 0th index of the List. Your program should support the following commands:
        
        Your program should catch any exceptions thrown because of the described validations - calling Print on an empty collection - and print their messages instead.
        Input
        •	Input will come from the console as lines of commands. 
        •	The first line will always be the Create command in the input. 
        •	The last command received will always be the END command.
        Output
        •	For every command from the input (with the exception of the END and Create commands), print the result of that command on the console, each on a new line. 
        •	In case of Move or HasNext commands, print the return value of the methods.
        •	In case of a Print command you don’t have to do anything additional as the method itself should already print on the console.
        Constraints
        •	There will always be only one Create command and it will always be the first command passed.
        •	The number of commands received will be between [1…100].
        •	The last command will always be the only END command.
Input 1:
Create
Print
END
Output 1:
Invalid Operation!

Input 2:
Create Stefcho Goshky
HasNext
Print
Move
Print
END
Output 2:
True
Stefcho
True
Goshky

Input 3:
Create 1 2 3
HasNext
Move
HasNext
HasNext
Move
HasNext
END

Output 3:
True
True
True
True
True
False

-------------- CODE ------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;

namespace ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create { e1 e2 …}  - void    -   Creates a ListyIterator from the specified collection.
            //                                    In case of a Create command without any elements, you should create a ListyIterator with an empty collection.
            //  Move                  boolean     This command should move the internal index to the next index.
            //  Print                 void        This command should print the element at the current internal index.
            //  HasNext               boolean     Returns whether the collection has a next element.
            //  END                   void        Stops the input.
            //Your program should catch any exceptions thrown because of the described validations - calling Print on an empty collection - and print their messages instead.

            ListyIterator<string> iterator = null;
            string line;

            while ((line = Console.ReadLine()) != "END")
            {
                try          // опитай да изпълниш този код
                {
                    string[] input = line.Split();
                    string command = input[0];

                    switch (command)
                    {
                        case "Create":
                            List<string> elements = input.Skip(1).ToList();
                            iterator = new ListyIterator<string>(elements);
                            break;
                        case "Move":
                            Console.WriteLine(iterator.Move());
                            break;
                        case "Print":
                            iterator.Print();
                            break;
                        case "HasNext":
                            Console.WriteLine(iterator.HasNext());
                            break;
                    }
                }
                catch (InvalidOperationException e)     // catch (Exception e) - ще прихваща и отпечатва всички грешка
                                                        // catch (InvalidOperationException e) - можем да конкретизираме типа на грешката, който да прихваща
                {
                    Console.WriteLine(e.Message); // отпечатва съобщението на грешката
                }      
            }
        }
    }
}

    public class ListyIterator<T>
    {
        private List<T> list;
        private int index;

        public ListyIterator(List<T> listInitial)   // listInotial -ще ни бъде първоначалната колекция със съответните стойности /може да бъде и празна/
        {
            this.list = listInitial;
            this.index = 0;
        }

        public int Count
            => this.list.Count;
        public bool Move()
        {
            //should move an internal index position to the next index in the list. 
            //The method should return true, if it had successfully moved the index and false if there is no next index
            if (this.HasNext())
            {
                index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            // should return true, if there is a next index and false, if the index is already at the last element of the list.
            if (index < list.Count - 1) // има следващ елемент
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            // should print the element at the current internal index. 
            //Calling Print on a collection without elements should throw an appropriate exception 
            //with the message "Invalid Operation!".

            if (list.Count == 0) // ако лист е празен - печатаме грешка
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(list[index]); // ако в листа има елементи - печатаме настоящиа индекс
            }
        }
    }
 */
/* Iterators - 20 Lectures-EX 2.Collection
    Using the ListyIterator from the last problem, extend it by implementing the IEnumerable<T> interface, implement all methods desired by the interface manually. Use yield return for the GetEnumerator() method. Add a new command PrintAll that should foreach the collection and print all of the elements on a single line separated by a space. Your program should catch any exceptions thrown because of validations and print their messages instead.
    Input
    •	Input will come from the console as lines of commands. 
    •	The first line will always be the Create command in the input. 
    •	The last command received will always be the END command.
    Output
    •	For every command from the input (with the exception of the END and Create commands), print the result of that command on the console, each on a new line. 
    •	In case of Move or HasNext commands print the return value of the method
    •	In case of a Print command you don’t have to do anything additional as the method itself should already print on the console.
    •	In case of a PrintAll command you should print all of the elements on a single line separated by spaces. 
    Constraints
    •	Do NOT use the GetEnumerator() method from the base class. Use your own implementation using "yield return".
    •	There will always be only one Create command and it will always be the first command passed.
    •	The number of commands received will be between [1…100].
    •	The last command will always be the only END command.
Input 1:
Create 1 2 3 4 5
Move
PrintAll
END
Output 1:
True
1 2 3 4 5

Input 2:
Create Stefcho Goshky Peshu
PrintAll
Move
Move
Print
HasNext
END

Output 2:
Stefcho Goshky Peshu
True
True
Peshu
False

------------- CODE --------------- 
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> iterator = null;
            string line;

            while ((line = Console.ReadLine()) != "END")
            {
                try          // опитай да изпълниш този код
                {
                    string[] input = line.Split();
                    string command = input[0];

                    switch (command)
                    {
                        case "Create":
                            List<string> elements = input.Skip(1).ToList();
                            iterator = new ListyIterator<string>(elements);
                            break;
                        case "Move":
                            Console.WriteLine(iterator.Move());
                            break;
                        case "Print":
                            iterator.Print();
                            break;
                        case "HasNext":
                            Console.WriteLine(iterator.HasNext());
                            break;
                        case "PrintAll":
                            foreach (var item in iterator)
                            {
                                Console.Write(item + " ");
                            }
                            Console.WriteLine();
                            break;
                    }
                }
                catch (InvalidOperationException e)     // catch (Exception e) - ще прихваща и отпечатва всички грешка
                                                        // catch (InvalidOperationException e) - можем да конкретизираме типа на грешката, който да прихваща
                {
                    Console.WriteLine(e.Message); // отпечатва съобщението на грешката
                }      
            }
        }
    }
}

public class ListyIterator<T> :IEnumerable<T>
    {
        private List<T> list;
        private int index;

        public ListyIterator(List<T> listInitial)   // listInotial -ще ни бъде първоначалната колекция със съответните стойности /може да бъде и празна/
        {
            this.list = listInitial;
            this.index = 0;
        }

        public int Count
            => this.list.Count;

        public void Reset()
            => index = 0;

        public bool Move()
        {
            //should move an internal index position to the next index in the list. 
            //The method should return true, if it had successfully moved the index and false if there is no next index
            if (this.HasNext())
            {
                index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            // should return true, if there is a next index and false, if the index is already at the last element of the list.
            if (index < list.Count - 1) // има следващ елемент
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            // should print the element at the current internal index. 
            //Calling Print on a collection without elements should throw an appropriate exception 
            //with the message "Invalid Operation!".

            if (list.Count == 0) // ако лист е празен - печатаме грешка
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(list[index]); // ако в листа има елементи - печатаме настоящиа индекс
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            //while (index < Count)     // Вариант 1
            //{
            //    yield return list[index];

            //    if (!Move())
            //    {
            //        yield break; 
            //    }

            //}

            foreach (T item in list)        // Вариант 2 - по-краткия
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

 */
/* Iterators - 20 Lectures-EX 3.Stack
        Create your custom stack. You are aware of the Stack's structure. There is a collection to store the elements and two functions (not from the functional programming) - to push an element and to pop it. Keep in mind that the first element, which is popped is the last in the collection. The Push method adds an element at the top of the collection and the Pop method returns the top element and removes it. Push and Pop will be the only commands and they will come in the following format:
        "Push {element1}, {element2}, … {elementN}
         Pop
        … "
        Write your custom implementation of Stack<T> and implement IEnumerable<T> interface. Your implementation of the GetEnumerator() method should follow the rules of the Abstract Data Type – Stack (return the elements in reverse order of adding them to the stack).
        Input
        •	The input will come from the console as lines of commands. 
        •	Push and pop will be the only possible commands, followed by integers for the push command and no another input for the pop command. 
        Output
        •	When you receive END, the input is over. Foreach the stack twice and print all elements each on new line.
        Constraints
        •	The elements in the push command will be valid integers between [2-31…231-1].
        •	The commands will always be valid (always be either Push, Pop or END).
        •	If Pop command could not be executed as expected (e.g. no elements in the stack), print on the console: "No elements".
Input 1:
Push 1, 2, 3, 4
Pop
Pop
END
Output 1:
2
1
2
1

Input 2:
Push 1, 2, 3, 4 
Pop
Push 1
END

Output 2:
1
3
2
1
1
3
2
1

Input 3:
Push 1, 2, 3, 4 
Pop
Pop
Pop
Pop
Pop
END

Output 3:
No elements
----------- CODE ------------ 
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>();

            string line;

            while ((line = Console.ReadLine()) != "END")
            {
                try          // опитай да изпълниш този код
                {
                    string[] input = line.Split(new string[] { ", ", " " }, StringSplitOptions.RemoveEmptyEntries);
                    string command = input[0];

                    switch (command)
                    {
                        case "Push":
                            List<int> elements = input.Skip(1).Select(int.Parse).ToList();
                            foreach (var item in elements)
                            {
                                myStack.Push(item);
                            }
                            break;
                        case "Pop":             // вместо Try-Catch може да сложим проверка преди да изпълним Pop()
                            myStack.Pop();
                            break;
                    }

                }
                catch (InvalidOperationException e)     // catch (Exception e) - ще прихваща и отпечатва всички грешка
                                                        // catch (InvalidOperationException e) - можем да конкретизираме типа на грешката, който да прихваща
                {
                    Console.WriteLine(e.Message); // отпечатва съобщението на грешката
                }

            }
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}

    public class MyStack<T> : IEnumerable<T>
    {
        private List<T> stack;

        public MyStack()
        {
            this.stack = new List<T>();
        }

        public int Count
            => this.stack.Count;

        public void Push(T item)
        {
            this.stack.Add(item);
        }

        public T Pop()
        {
            try
            {
                //T lastItems = this.stack[Count - 1];   // Вар.1
                //T lastItem = stack.Last();             // Вар.2
                
                T lastItems = this.stack[^1];            // Вар.3  [^1] връща последния елемент, [^2] връща предпоследния елемент и т.н. !!!!!!!
                stack.RemoveAt(stack.Count - 1);    // така маха последния елемент
                
                return lastItems;

            }
            catch (Exception)
            {

                throw new InvalidOperationException("No elements");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = stack.Count-1; i >= 0; i--)
            {
                yield return stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    } 
 */
/* Iterators - 20 Lectures-EX 4.Froggy 
        Let's play a game. You have a tiny little Frog, and a Lake that has a path of stones in it. 
        Every stone has a number. Our frog must cross the lake along that path and then return. 
        But there are some rules. First, the frog must jump on all the stones, which are in even positions 
        in ascending order and then on all the odd ones, but in reversed order. The order of the stones and 
        their numbers will be given on the first line of input. Then you must print the order of stones in which our frog jumped from one to another.
        Try to achieve this functionality by creating a class Lake (it will hold all stone numbers in order) that 
        implements the IEnumerable<int> interface and overrides its GetEnumerator() methods.
Input 1:
1, 2, 3, 4, 5, 6, 7, 8
Output 1:
1, 3, 5, 7, 8, 6, 4, 2

Input 2:
1, 2, 3, 4, 5
Output 2:
1, 3, 5, 4, 2

Input 3:
13, 23, 1, -8, 4, 9
Output 3:
13, 1, 4, 9, -8, 23
--------------------- CODE -----------------
using System;
using System.Linq;

namespace Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stones = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            
            Lake lake = new Lake(stones); // или директно можем да подадем параметрите: Lake lake = new Lake(1,2,3,4)

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}

    class Lake: IEnumerable<int>
    {
        private List<int> stones;

        public Lake(params int[] stones) // за упражняване на params
        {
            this.stones = stones.ToList(); // на List присвояваме масив с ToList()
        }

        public IEnumerator<int> GetEnumerator()
        {
            int last = stones.Count-1;

            for (int i = 0; i < stones.Count; i+=2)
            {
                yield return stones[i];
            }

            if (last % 2 == 0)      // ако посл.индекс е четно -> намаляме с 1
            {
                last--;
            }

            for (int i = last; i > 0; i-=2)
            {
                yield return stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
 */
/* Comparators - 20 Lectures-EX 5.Comparing Objects
        Create a class Person. Each person should have a name, an age and a town. You should implement the interface – IComparable<T> and implement the CompareTo method. When you compare two people, first you should compare their names, after that – their age and finally – their towns. You will be receiving input with information about the people, until you receive the "END" command in the following format:
        "{name} {age} {town}"
        After that, you will receive n – the n'th person from your collection, starting from 1. You should bring statistics, how many people are equal to him, how many people are not equal to him and the total people in your collection in the following format:
        "{count of matches} {number of not equal people} {total number of people}"
        If there are no equal people print: "No matches".
        Input
        •	You will be receiving lines in the format described above, until the "END" command.
        •	After the "END" command, you will receive the position of the person you should compare the others to. 
        Note: Start counting the people in your collection from 1.
        Output
        •	Print a single line of output in the format described above.
        Constraints
        •	Input names, ages and addresses will be valid. 
        •	Input number will always be а valid integer in range [2…100]
Input 1:
Pesho 22 Vraca
Gogo 14 Sofeto
END
2
Output 1:
No matches

Input 2:
Pesho 22 Vraca
Gogo 22 Vraca
Gogo 22 Vraca
END
2
Output 2:
Pesho 22 Vraca
Gogo 22 Vraca
Gogo 22 Vraca
END
2
------------- CODE ----------
using System;
using System.Collections.Generic;

namespace _05._Comparing_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();

            string line;

            while ((line = Console.ReadLine()) != "END")
            {
                string[] input = line.Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                string town = input[2];

                list.Add(new Person(name, age, town));
            }

            int index = int.Parse(Console.ReadLine());

            Person person = list[index - 1];

            int sum = 0;
            foreach (var item in list)
            {
                if (person.CompareTo(item) == 0)
                {
                    sum++;
                }
            }

            if (sum > 1)
            {
                Console.WriteLine($"{sum} {list.Count-sum} {list.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}

    class Person : IComparable<Person>
    {
        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public int CompareTo(Person other) // връща число: -1 - първото е <; 0-равни са; 1- второто е по-голямо
        {
            if (Name.CompareTo(other.Name)!=0)
            {
                return Name.CompareTo(other.Name);
            }
            
            if(Age.CompareTo(other.Age) != 0)
            {
                return Age.CompareTo(other.Age);
            }

            if (Town.CompareTo(other.Town) != 0)
            {
                return Town.CompareTo(other.Town);
            }
            return 0;
        }
    } 
 */
/* HashSet / SortedSet / GetHashCode()- 20 Lectures-EX 6.  Equality Logic 
        Create a class Person holding a name and an age. A person with the same name and age should be considered the same. Override any methods needed to enforce this logic. Your class should work with both standard and hashed collections. Create a SortedSet and a HashSet of type Person. You will receive n – the number of input lines. On each of them, you will receive info about the people in the following format:
        "<name> <age>"
        You should add the people to both the sets. In the end, you should print the size of the sorted set and then the size of the hashset.
        Input
        •	On the first line of input you will receive a number n. 
        •	On each of the next n lines you will receive information about people in the described format. 
        Output
        •	The output should consist of exactly two lines. 
        •	On the first one, you should print the size of the sorted set
        •	On the second - the size of the hashset.
        Constraints
        •	A person’s name will be a string that contains only alphanumerical characters with a length between [1…50] symbols.
        •	A person’s age will be a positive integer between [1…100].
        •	The number of people N will be a positive integer between [0…100].
    Hint:
        You should override both the Equals and GetHashCode methods. You can check online for an implementation of GetHashCode
        – it doesn’t have to be perfect, but it should be good enough to produce the same hash code for objects with the same name and age, 
        and different enough hash codes for objects with different name and/or age.

Input 1:
4
Pesho 20
Peshp 20
Joro 15
Pesho 21
Output 1:
4
4
 
Input 2:
7
Ivan 17
ivan 17
Stoqn 25
Ivan 18
Ivan 17
Stopn 25
Stoqn 25
Output 2:
7
Ivan 17
ivan 17
Stoqn 25
Ivan 18
Ivan 17
Stopn 25
Stoqn 25
-------------- CODE ------------
using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //List<Person> list = new List<Person>();
            SortedSet<Person> sort = new SortedSet<Person>(); // подредени уникални елементи, използвайки ЗАДЪЛЖИТЕЛНО IComparable
            HashSet<Person> hash = new HashSet<Person>();
            string line;

            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine();
                string[] input = line.Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                
                sort.Add(new Person(name, age));
                hash.Add(new Person(name, age));
            }

            Console.WriteLine(sort.Count);
            Console.WriteLine(hash.Count);
        }
    }
}

    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        
        public int CompareTo(Person other) // връща число: -1 - първото е <; 0-равни са; 1- второто е по-голямо
                                           // Този метод се ползва от SortedSet, за да изкл.повтарящи се записи 
        {
            if (Name.CompareTo(other.Name) != 0)
            {
                return Name.CompareTo(other.Name);
            }

            if (Age.CompareTo(other.Age) != 0)
            {
                return Age.CompareTo(other.Age);
            }

            return 0;
        }

        public override int GetHashCode() // връща GetHashCode на всяка отделна инстанция
        {
            return Name.GetHashCode() + Age.GetHashCode();
        }

        public override bool Equals(object? obj) // предефитиране как да сравнява по GetHashCode
        {
            if (GetHashCode() == obj.GetHashCode())
            {
                return true;
            }
            else
            {
                return false;
            }
        }    
    }
 */

/* EXAM 2019.02.24 - 1. Club_Party
        // n – an integer specifying the halls' maximum capacity
        // Then you will be given input line which will contain English alphabet letters and numbers, separated by a single space
        // The input for the line should be read from the last inserted to the first one.
        // he letters represent the halls and the numbers – the people in a single reservation.
        // Companies of people should go in the halls. 
        // The first entered hall is the first which people are entering. 
        // Every reservation takes specific capacity, equal to its number.
        // Input:
        //  60
        // 1 20 b 20 20 a
        // Output
        // a-> 20, 20, 20
------------- CODE --------------
using System;
using System.Collections.Generic;

namespace _01._Club_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            
            Stack<string> stack = new Stack<string>();    // пази входа отзад напред
            Queue<string> halls = new Queue<string>();    // пази реда и дали има отворена зала
            List<int> reservations = new List<int>();
            int count = 0;                                // колко човека има в текущата зала  

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }

            while (stack.Count > 0) // 50    - 15 a 40 30 20 c 15 10 b

            {
                string currentInput = stack.Peek();
                if (char.IsDigit(currentInput[0])) // резервация ли е
                {
                    int reservation = int.Parse(currentInput);
                    if (halls.Count > 0)            // има ли отворена зала
                    {
                        if(count + reservation <= capacity) // отворената зала побира ли текущата резервация
                        {
                            reservations.Add(reservation); // ако ДА - добавяме я в списъка с влезлите резервации
                            count += reservation;
                        }
                        else   // ако залата прелива - разпечатваме текущата залата и влезлите разервации
                        {
                            Console.WriteLine($"{halls.Dequeue()} -> {string.Join(", ",reservations)}");
                            reservations.Clear();
                            count = 0;

                            if (halls.Count > 0)
                            {
                                reservations.Add(reservation); // ако ДА - добавяме я в списъка с влезлите резервации
                                count += reservation;
                            }
                        }
                    }  // ако няма отворена зала, пропускаме резервацията
                }
                else
                {
                    halls.Enqueue(currentInput);
                }
                stack.Pop();
            }
        }
    }
}
 

 */
/* EXAM 2019.02.24 - 2. Tron_Racers    
        The new TRON tournament has started and you have to keep track of the players on the field.
        You will be given an integer n for the size of the matrix. On the next n lines, you will receive the rows of the matrix. The game starts with two players (first player is marked with "f" and the second player is marked with "s") in random positions and all of the empty slots will be filled with "*". 
        Each turn you will be given commands respectively for each player’s movement. The first command is for the first player and the second is for the second player. After a player moves, he leaves a trail on the field. The symbol that marks the trail is the same as the player's symbol. If a player goes out of the matrix, he comes in from the other side. For example, if the player is on 0, 0 and the next command is left, he goes to the last spot in the first row.
        If a player steps on the other player's trail, he dies. When a player dies in the field, you should write "x" in the position where he died. 
        When only one of the players is left alive on the field the game ends.
        Input
        •	On the first line, you are given the integer N – the size of the square matrix.
        •	The next N lines holds the values for every row.
        •	On each of the next lines you will get two commands separated by space	.
        Output
        •	In the end print the matrix.
        Constraints
        •	The size of the matrix will be between [2…20].
        •	There will always be exactly two players.
        •	The players will always be indicated with "f" for the first one and "s" for the second one.
        •	There will always be enough commands to finish the game with one player alive. 
        •	There will not be commands where a player goes back and steps on his trail from the previous turn.
        •	Commands will be in the format up, down, left or right.

------------- CODE -------------
using System;
using System.ComponentModel.Design;

namespace _02._Tron_Racers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            ReadMatrix(matrix);
            int posFrow = PositionX(matrix, 'f');
            int posFcol = PositionY(matrix, 'f');
            int posSrow = PositionX(matrix, 's');
            int posScol = PositionY(matrix, 's');

            bool gameOver = false;
            while (!gameOver)
            {
                string[] command = Console.ReadLine().Split();
                string directionF = command[0];
                string directionS = command[1];

                switch (directionF)
                {
                    case "down":
                        if (posFrow + 1 < n)
                        {
                            posFrow++;
                        }
                        else
                        {
                            posFrow=0;
                        }
                        break;
                    case "up":
                        if (posFrow - 1 < 0)
                        {
                            posFrow = n-1;
                        }
                        else
                        {
                            posFrow--;
                        }
                        break;
                    case "left":
                        if (posFcol - 1 < 0)
                        {
                            posFcol = n - 1;
                        }
                        else
                        {
                            posFcol--;
                        }
                        break;
                    case "right":
                        if (posFcol + 1 < n)
                        {
                            posFcol++;
                        }
                        else
                        {
                            posFcol = 0;
                        }
                        break;
                }

                if(matrix[posFrow, posFcol] == 's')
                {
                    matrix[posFrow, posFcol] = 'x';
                    break;
                }
                else
                {
                    matrix[posFrow, posFcol] = 'f';
                }

                switch (directionS)
                {
                    case "down":
                        if (posSrow + 1 < n)
                        {
                            posSrow++;
                        }
                        else
                        {
                            posSrow = 0;
                        }
                        break;
                    case "up":
                        if (posSrow - 1 < 0)
                        {
                            posSrow = n - 1;
                        }
                        else
                        {
                            posSrow--;
                        }
                        break;
                    case "left":
                        if (posScol - 1 < 0)
                        {
                            posScol = n - 1;
                        }
                        else
                        {
                            posScol--;
                        }
                        break;
                    case "right":
                        if (posScol + 1 < n)
                        {
                            posScol++;
                        }
                        else
                        {
                            posScol = 0;
                        }
                        break;
                }

                if (matrix[posSrow, posScol] == 'f')
                {
                    matrix[posSrow, posScol] = 'x';
                    break;
                }
                else
                {
                    matrix[posSrow, posScol] = 's';
                }

            }

            PrintMatrix(matrix); ;
        }

        private static int PositionX(char[,] matrix, char player)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == player)
                    {
                        return row;
                    }
                }
            }

            return -1;
        }

        private static int PositionY(char[,] matrix, char player)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == player)
                    {
                        return col;
                    } 
                }
            }

            return -1;
        }
        private static void ReadMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}

 */
/* EXAM 2019.02.24 - 3. Heroes
            Your task is to create a repository which stores hero by creating the classes described below.
            First, write a C# class Item with the following properties:
            •	Strength: int
            •	Ability: int
            •	Intelligence: int
            The class constructor should receive strength, ability and intelligence and override the ToString() method in the following format:
            "Item:"
            "  * Strength: {Strength Value}"
            "  * Ability: {Ability Value}"
            "  * Intelligence: {Intelligence Value}"
            Next, write a C# class Hero with the following properties:
            •	Name: string
            •	Level: int
            •	Item: Item
            The class constructor should receive name, level and item and override the ToString() method in the following format:
            "Hero: {Name} – {Level}lvl"
            "Item:"
            "  * Strength: {Strength Value}"
            "  * Ability: {Ability Value}"
            "  * Intelligence: {Intelligence Value}"
            Write a C# class HeroRepository that has data (a collection which stores the entity Hero). All entities inside the repository have the same properties.
            public class HeroRepository 
            {
                // TODO: implement this class
            }
            The class constructor should initialize the data with a new instance of the collection. Implement the following features:
            •	Field data – collection that holds added heroes
            •	Method Add(Hero hero) – adds an entity to the data.
            •	Method Remove(string name) – removes an entity by given hero name.
            •	Method GetHeroWithHighestStrength() – returns the Hero which poses the item with the highest stength.
            •	Method GetHeroWithHighestAbility() – returns the Hero which poses the item with the highest ability.
            •	Method GetHeroWithHighestIntelligence() – returns the Hero which poses the item with the highest intellgence.
            •	Getter Count – returns the number of stored heroes.
            •	Оverride ToString() – Print all the heroes.
            Constraints
            •	The names of the heroes will be always unique.
            •	The items of the heroes will always be with positive values.
            •	The items of the heroes will always be different.
            •	You will always have an item with the highest strength, ability and intelligence.

----- CODE ----- 
using System;

namespace Heroes
{
    public class StartUp
    {
        public static void Main()
        {
            //Initialize the repository
            HeroRepository repository = new HeroRepository();
            
            //Initialize entity
            Item item = new Item(23, 35, 48);
            
            //Print Item
            Console.WriteLine(item);

            //Initialize entity
            Hero hero = new Hero("Hero Name", 24, item);
            
            //Print Hero
            Console.WriteLine(hero);

            //Hero: Hero Name - 24lvl
            //Item:
            //    * Strength: 23
            //    * Ability: 35
            //    * Intelligence: 48

            //Add Hero
            repository.Add(hero);
            //Remove Hero
            repository.Remove("Hero Name");

            Item secondItem = new Item(100, 20, 13);
            Hero secondHero = new Hero("Second Hero Name", 125, secondItem);

            //Add Heroes
            repository.Add(hero);
            repository.Add(secondHero);

            Hero heroStrength = repository.GetHeroWithHighestStrength(); // Hero with name Second Hero
            Hero heroAbility = repository.GetHeroWithHighestAbility(); // Hero with name Hero Name
            Hero heroIntelligence = repository.GetHeroWithHighestIntelligence(); // Hero with name Hero
            Console.WriteLine(repository.Count); //2

            Console.WriteLine("List Heroes");
            Console.WriteLine(repository);
            Console.WriteLine();

            Console.WriteLine("heroStrength " + heroStrength);
            Console.WriteLine("heroAbility " + heroAbility);
            Console.WriteLine("heroIntelligence "+ heroIntelligence);

        }
    }
}

    public class Item
    {
        public Item(int strength, int ability, int intelligence)
        {
            Strength = strength;
            Ability = ability;
            Intelligence = intelligence;
        }

        public int Strength { get; set; }
        public int Ability { get; set; }
        public int Intelligence { get; set; }

        public override string ToString()
        {
            StringBuilder sbItem = new StringBuilder();

            sbItem.AppendLine("Item:");
            sbItem.AppendLine($"  * Strength: {Strength}");
            sbItem.AppendLine($"  * Ability {Ability}");
            sbItem.Append($"  * Intelligence {Intelligence}");

            return sbItem.ToString();
        }
    }

    public Hero(string name, int level, Item item)
        {
            Name = name;
            Level = level;
            Item = item;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public Item  Item { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Hero: {Name} - {Level} lvl");
            sb.Append($"{Item}");

            return sb.ToString();
        }
    }
 
    public class HeroRepository
    {
        private List<Hero> heroList;

        public HeroRepository()
        {
            this.heroList = new List<Hero>();
        }

        public int Count => this.heroList.Count;

        public void Add(Hero hero)
        {
            heroList.Add(hero);
        }

        public void Remove(string name)
        {
            heroList = heroList.Where(x => x.Name != name).Select(y => y).ToList();
        }

        public Hero GetHeroWithHighestStrength()
        {
            var highestStrength =
                this.heroList
                    .OrderByDescending(x => x.Item.Strength)
                    .First();

            return highestStrength;
        }

        public Hero GetHeroWithHighestAbility()
        {
            var highestAbility =
                this.heroList
                    .OrderByDescending(x => x.Item.Ability)
                    .First();

            return highestAbility;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            var highestIntelligence =
                this.heroList
                    .OrderByDescending(x => x.Item.Intelligence)
                    .First();

            return highestIntelligence;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (this.heroList.Count >= 0)
            {
                foreach (var hero in this.heroList)
                {
                    sb.AppendLine($"{hero}");
                }
            }

            return sb.ToString();
        }
    }
 */
/* EXAM 2019.10.26 - 1. Dating_App
        First you will be given a sequence of integers representing males. Afterwards you will be given another sequence of integers representing females.
        You have to start from the first female and try to match it with the last male.
        •	If their values are equal, you have to match them and remove both of them. Otherwise you should remove only the female and decrease the value of the male by 2.
        •	If someone’s value is equal to or below 0, you should remove him/her from the records before trying to match him/her with anybody.
        •	Special case - if someone’s value divisible by 25 without remainder, you should remove him/her and the next person of the same gender. 
        You need to stop matching people when you have no more females or males.
        Input
        •	On the first line of input you will receive the integers, representing the males, separated by a single space. 
        •	On the second line of input you will receive the integers, representing the females, separated by a single space.
        Output
        •	On the first line of output - print the number of successful matches:
        o	"Matches: {matchesCount}"
        •	On the second line - print all males left:
        o	If there are no males: "Males left: none"
        o	If there are males: "Males left: {male1}, {male2}, {male3}, (…)"
        •	On the third line - print all females left:
        o	If there are no females: "Females left: none"
        o	If there are females: "Females left: {female1}, {female2}, {female3}, (…)"
        Constraints
        •	All of the given numbers will be valid integers in the range [-100, 100].
Input 1:
3 6 9 12
12 9 6 1 25 25
Output 2:
Matches: 3
Males left: 1
Females left: none
3 0 3 6 9 0 12
12 9 6 1 2 3 15 13 4
Input 2:
Matches: 4
Males left: none
Females left: 15, 13, 4

------------- CODE ------------
using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Dating_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> male = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                male.Push(input[i]);
            }

            Queue<int> female = new Queue<int>();
            input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                female.Enqueue(input[i]);
            }

            int matchesCount = 0;
            while (male.Count>0 && female.Count > 0)
            {
                if(male.Peek()<= 0)
                {
                    male.Pop();
                    continue;
                }
                if (female.Peek() <= 0)
                {
                    female.Dequeue();
                    continue;
                }

                if (male.Peek() % 25 == 0)
                {
                    male.Pop();
                    if (male.Count > 0)
                    {
                        male.Pop();
                    }
                    continue;
                }

                if (female.Peek() % 25 == 0)
                {
                    female.Dequeue();
                    if (female.Count > 0)
                    {
                        female.Dequeue();
                    }
                    continue;
                }

                if(male.Peek()== female.Peek())
                {
                    male.Pop();
                    female.Dequeue();
                    matchesCount++;
                    continue;
                }
                else
                {
                    female.Dequeue();
                    int num =male.Pop();
                    male.Push(num - 2);
                }

            }

            Console.WriteLine($"Matches: {matchesCount}");
            if (male.Count > 0)
            {
                Console.WriteLine($"Males left: {string.Join(", ", male)}");
            }
            else
            {
                Console.WriteLine("Males left: none");
            }

            if (female.Count > 0)
            {
                Console.WriteLine($"Females left: {string.Join(", ", female)}");
            }
            else
            {
                Console.WriteLine("Females left: none");
            }
        }
    }
}
  
 */
/* EXAM 2019.10.26 - 2. Book_Worm 
        You will be given a string. Then, you will be given an integer N for the size of the field with square shape. On the next N lines, you will receive the rows of the field. The player will be placed on a random position, marked with "P". On random positions there will be letters. All of the empty positions will be marked with "-".
        Each turn you will be given commands for the player’s movement. If he moves to a letter, he consumes it, concatеnates it to the initial string and the letter disappears from the field. If he tries to move outside of the field, he is punished - he loses the last letter in the string, if there are any, and the player’s position is not changed.
        When the command "end" is received, stop the program, print all letters and the field.
        Input
        •	On the first line, you are given the initial string
        •	On the second line, you are given the integer N - the size of the square matrix
        •	The next N lines holds the values for every row
        •	On each of the next lines you will get a move command
        Output
        •	On the first line the final state of the string
        •	In the end print the matrix
        Constraints
        •	The size of the square matrix will be between [2…10]
        •	The player position will be marked with "P"
        •	The letters on the field will be any letter except for "P"
        •	Move commands will be: "up", "down", "left", "right"
        •	Stop command will be "end"
Input 1
Hello
4
P---
Mark
-l-y
--e-
down
right
right
right
end
Output 1:
HelloMark
----
---P
-l-y
--e-

Input 2:
Initial
5
-----
t-r--
--Pa-
--S--
z--t-
up
left
left
left
end
Output 2:
Initialr
-----
P----
---a-
--S--
z--t-
-------------- CODE -----------
using System;
using System.Collections.Generic;

namespace _2._Book_Worm
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Stack<char> letters = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                letters.Push(input[i]);
            }

            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            ReadMatrix(matrix);
            int posRow = PositionX(matrix);
            int posCol = PositionY(matrix);

            string direction;
            while ((direction=Console.ReadLine())!="end")
            {
                switch (direction)
                {
                    case "down":
                        matrix[posRow, posCol] = '-';
                        if (posRow + 1 < n)
                        {
                            posRow++;
                        }
                        else
                        {
                            letters.Pop();
                        }
                        break;
                    case "up":
                        matrix[posRow, posCol] = '-';
                        if (posRow - 1 < 0)
                        {
                            letters.Pop();
                        }
                        else
                        {
                            posRow--;
                        }
                        break;
                    case "left":
                        matrix[posRow, posCol] = '-';
                        if (posCol - 1 < 0)
                        {
                            letters.Pop();
                        }
                        else
                        {
                            posCol--;
                        }
                        break;
                    case "right":
                        matrix[posRow, posCol] = '-';
                        if (posCol + 1 < n)
                        {
                            posCol++;
                        }
                        else
                        {
                            letters.Pop();
                        }
                        break;
                }

                if (matrix[posRow, posCol] != '-')
                {
                    letters.Push(matrix[posRow, posCol]);
                    matrix[posRow, posCol] = 'P';
                }
                else
                {
                    matrix[posRow, posCol] = 'P';
                }
            }

            Stack<char> result = new Stack<char>();
            while(letters.Count>0)
            {
                result.Push(letters.Pop());
            }

            Console.WriteLine(string.Join("",result));
            PrintMatrix(matrix);
        }

        private static int PositionX(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] =='P')
                    {
                        return row;
                    }
                }
            }

            return -1;
        }

        private static int PositionY(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'P')
                    {
                        return col;
                    }
                }
            }

            return -1;
        }
        private static void ReadMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}

 */
/* EXAM 2019.10.26 - 3. Rabbits
        Your task is to create a repository which stores rabbit cages by creating the classes described below.
        First, write a C# class Rabbit with the following properties:
        •	Name: string
        •	Species: string
        •	Available: bool - true by default
        The class constructor should receive name and species. Override the ToString() method in the following format:
        "Rabbit ({species}): {name}"
        Next, write a C# class Cage that has data (a collection which stores the entity Rabbit). All entities inside the repository have the same properties. Also, the Cage class should have those properties:
        •	Name: string
        •	Capacity: int
        The class constructor should receive name and capacity, also it should initialize the data with a new instance of the collection. Implement the following features:
        •	Field data - collection that holds added rabbits
        •	Method Add(Rabbit rabbit) - adds an entity to the data if there is room for it
        •	Method RemoveRabbit(string name) - removes a rabbit by given name, if such exists, and returns bool
        •	Method RemoveSpecies(string species) - removes all rabbits by given species
        •	Method SellRabbit(string name) - sell (set its Available property to false without removing it from the collection) the first rabbit with the given name, also return the rabbit
        •	Method SellRabbitsBySpecies(string species) - sells (set their Available property to false without removing them from the collection) and returns all rabbits from that species as an array
        •	Getter Count - returns the number of rabbits
        •	Report() - returns a string in the following format, including only not sold rabbits:	
        o	"Rabbits available at {cageName}:
        {Rabbit1}
        {Rabbit2}
        (…)"
        Constraints
        •	The names of the rabbits will be always unique.
        •	You will always have a rabbit added before receiving methods manipulating the Cage’s rabbits.
        Examples
        This is an example how the Cage class is intended to be used. 

------------------CODE -------------------
namespace Rabbits
{
    using System;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            //Initialize the repository (Cage)
            Cage cage = new Cage("Wildness", 20);
            //Initialize entity
            Rabbit rabbit = new Rabbit("Fluffy", "Blanc de Hotot");
            //Print Rabbit
            Console.WriteLine(rabbit); //Rabbit (Blanc de Hotot): Fluffy

            //Add Rabbit
            cage.Add(rabbit);
            Console.WriteLine(cage.Count); //1
                                           //Remove Rabbit
            cage.RemoveRabbit("Rabbit Name"); //false

            Rabbit secondRabbit = new Rabbit("Bunny", "Brazilian");
            Rabbit thirdRabbit = new Rabbit("Jumpy", "Cashmere Lop");
            Rabbit fourthRabbit = new Rabbit("Puffy", "Cashmere Lop");
            Rabbit fifthRabbit = new Rabbit("Marlin", "Brazilian");

            //Add Rabbits
            cage.Add(secondRabbit);
            cage.Add(thirdRabbit);
            cage.Add(fourthRabbit);
            cage.Add(fifthRabbit);

            //Sell Rabbit by name
            Console.WriteLine(cage.SellRabbit("Bunny")); //Rabbit (Brazilian): Bunny
                                                         //Sell Rabbit by species
            Rabbit[] soldSpecies = cage.SellRabbitsBySpecies("Cashmere Lop");
            Console.WriteLine(string.Join(", ", soldSpecies.Select(f => f.Name))); //Jumpy, Puffy

            Console.WriteLine(cage.Report());
            //Rabbits available at Wildness:
            //Rabbit (Blanc de Hotot): Fluffy
            //Rabbit (Brazilian): Marlin
        }
    }
}

    public class Cage
    {
        private List<Rabbit> rabbits;
        public Cage(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            this.rabbits = new List<Rabbit>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        
        public int Count => this.rabbits.Count;

        public void Add(Rabbit rabbit)
        {
            if (rabbits.Count < this.Capacity)
            {
                rabbits.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            rabbits = rabbits.Where(x => x.Name != name).Select(y => y).ToList();
            if(rabbits== null)
            {
                return false;
            }

            return true;
        }

        public void RemoveSpecies(string species)
        {
            rabbits = rabbits.Where(x => x.Species != species).ToList();
        }

        // SellRabbit
        public Rabbit SellRabbit(string name)
        {
            var sellRabit =
                this.rabbits
                    .Where(x => x.Name == name)
                    .First();
            if(sellRabit!= null)
            {
                sellRabit.Available = false;
                return sellRabit;
            }
            return null;
        }

        // SellRabbitsBySpecies
        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            var soldRabbits = rabbits.Where(x => x.Species == species).ToArray();
            foreach (var item in soldRabbits)
            {
                item.Available = false;
            }

            return soldRabbits;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rabbits available at {Name}:");
            if (this.rabbits.Count >= 0)
            {
                foreach (var item in this.rabbits.Where(x=>x.Available==true))
                {
                    sb.AppendLine($"{item}");
                }
            }

            return sb.ToString().Trim();
        }
    }

    public class Rabbit
    {
        
        bool available = true;
        
        public Rabbit(string name, string species)
        {
            Name = name;
            Species = species;
            Available = available;
        }

        public string Name { get; set; }
        public string Species { get; set; }
        public bool Available { get; set; }

        public override string ToString()
        {
            return $"Rabbit ({Species}): {Name}";
        }
    }
 */
/* RetakeEXAM 2019.12.17 - 1. Santa's Present Factory
        Christmas is just around the corner and this year Santa has decided to share his secret with you. Get ready to learn how his dwarfs craft all the presents. 
        First you will receive a sequence of integers, representing the number of materials for crafting toys in one box. After that you will be given another sequence of integers – their magic level.
        Your task is to mix materials with magic so you can craft presents, listed in the table below with the exact magic level. 
        Present	Magic needed
        Doll	150
        Wooden train	250
        Teddy bear	300
        Bicycle 	400
        In order to craft a toy, you have to take the last box with materials and the first magic level value. The total magic level is calculated by their multiplication. If the result equals one of the levels described in the table above, you craft the present and remove both materials and magic value. Otherwise:
        •	If the product of the operation is a negative number, then you have to sum the values together, remove them both from their positions and the result should be added to the materials.
        •	If the product doesn’t equal one of the magic levels in the table and is a positive number, remove only the magic value and increase the material value with 15.
        •	If the magic or material (or both) equals 0, remove it (or both) and continue crafting the presents.
        Stop crafting presents when you run out of boxes of materials or magic level values.
        Your task is considered done if you manage to craft either one of the pairs - a doll and a train or a teddy bear and a bicycle.
        Input
        •	The first line of input will represent the values of boxes with materials - integers, separated by single space
        •	On the second line you will be given the magic values - integers again, separated by single space
        Output
        •	On the first line - print whether you've succeeded in crafting the presents
        o	"The presents are crafted! Merry Christmas!"
        o	"No presents this Christmas!"
        •	On the next two lines print the materials and magic that are left, if there are any, otherwise skip the line
        o	"Materials left: {material1}, {material2}, …"
        o	"Magic left: {magicValue1}, {magicValue2}, …
        •	On the next lines print the presents you have crafted at least once, ordered alphabetically in the format:
        "{toy name}: {amount}"
        …
        Constraints
        •	All of the materials' values will be integers in range [1, 100]
        •	Magic level values will be integers in range [-10, 100]
        •	In all cases at least one present will be crafted
Input 1:
10 -5 20 15 -30 10
40 60 10 4 10 0
Output 1:
The presents are crafted! Merry Christmas!
Materials left: 20, -5, 10
Bicycle: 1
Teddy bear: 2

Input 1:
30 5 15 60 0 30
-15 10 5 -15 25
Output 2:
No presents this Christmas!
Materials left: 20, 30
Doll: 1
Teddy bear: 1
-------------- CODE ------------
using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Santa_s_Present_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] present = new string[] {"Doll","Wooden train","Teddy bear","Bicycle"};
            List<int> magicNeede = new List<int> { 150, 250, 300, 400 };
            Dictionary<string, int> readyPresents = new Dictionary<string,int>();

            Stack<int> materials = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList());

            Queue<int> magicLevel = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList());
            
            while(materials.Count>0 && magicLevel.Count > 0)
            {
                // ако поредното число е 0 го премахваме
                if (materials.Peek() == 0 || magicLevel.Peek() == 0)
                {
                    if (materials.Peek() == 0)
                    {
                        materials.Pop();

                    }

                    if (magicLevel.Peek() == 0)
                    {
                        magicLevel.Dequeue();

                    }
                    continue;
                }

                // предните материал и маг.ниво са равни

                int multiplication = materials.Peek() * magicLevel.Peek();
                if (multiplication > 0)
                {
                    if (magicNeede.Contains(multiplication)) // има играчка с тази стойност
                    {
                        int index = magicNeede.IndexOf(multiplication);
                        if (readyPresents.ContainsKey(present[index]))
                        {
                            readyPresents[present[index]]++;
                        }
                        else
                        {
                            readyPresents.Add(present[index], 1);
                        }
                        materials.Pop();
                        magicLevel.Dequeue();
                        continue;
                    }
                    else
                    {
                        magicLevel.Dequeue();
                        int material = materials.Pop()+15;
                        materials.Push(material);
                        continue;
                    }
                }
                else
                {
                    int sum = materials.Pop() + magicLevel.Dequeue();
                    materials.Push(sum);
                }
            }

            if (readyPresents.ContainsKey("Doll") && readyPresents.ContainsKey("Wooden train") || readyPresents.ContainsKey("Teddy bear") && readyPresents.ContainsKey("Bicycle"))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }
            

            if (materials.Count > 0)
            {
                Console.WriteLine($"Materials left: {string.Join(", ", materials)}");
            }

            if (magicLevel.Count > 0)
            {
                Console.WriteLine($"Magic left: {string.Join(", ", magicLevel)}");
            }

            foreach (var item in readyPresents.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
*/
/* RetakeExam 2019.12.17 - 2. Present Delivery
        Now that the presents are ready, Santa has to deliver them to the kids. 
        You will receive an integer m for the count of presents Santa has and an integer n for the size of the neighborhood with a square shape. On the next lines you will receive the matrix, which represents the neighborhood. 
        Santa will be in a random cell, marked with the letter 'S'. Each cell stands for a house where children may live. If the cell has 'X' on it, that means there lives a naughty kid. Otherwise, if a nice kid lives there, the cell is marked by 'V'. There can aslo be cells marked with 'C' for cookies. All of the empty positions will be marked with '-'.
        Santa can move "up", "down", "left", "right". These will be the commands that you receive. If he moves to a house with a nice kid, the kid receives a present, but if Santa reaches a house with a naughty kid, he doesn’t drop a present. If the command sends Santa to a cell marked with 'C', Santa eats cookies and becomes happy and extra generous so all the kids around him* receive presents (doesn’t matter if naughty or nice). If Santa has been to a house and the kid there has received a present, the cell becomes '-'.
        Note: *around him means on his left, right, upwards and downwards by one cell. In this case Santa doesn't move to these cells or if he does, he returns to the cell where the cookie was.
        If Santa runs out of presents or you receive the command "Christmas morning", then you have to end the program. 
        Keep in mind that you have to check whether all of the nice kids received presents.
        Input
        •	On the first line, you are given the integer m – the count of presents
        •	On the second – integer n – size of the neighbourhood
        •	The next n lines hold the values for every row
        •	On each of the next lines you will get a command
        Output
        •	On the first line:
        o	If Santa goes out of presents, print: "Santa ran out of presents!"
        •	Next print the matrix.
        •	In the end print one of these messages:
        o	If he manages to give all the nice kids presents, print:
        "Good job, Santa! {count nice kids} happy nice kid/s."
        o	Otherwise print: 
        "No presents for {count nice kids} nice kid/s."
        Constraints
        •	The size of the square matrix will be between [2…10].
        •	Santa’s position will be marked with 'S'.
        •	There will always be at least 1 nice kid.
        •	There won't be a case where the cookie is on the border of the matrix.
Input 1:
5
4
- X V -
- S - V
- - - -
X - - -
up
right
down
right
Christmas morning
Output 1:
- - - - 
- - - S 
- - - - 
X - - - 
Good job, Santa! 2 happy nice kid/s.

Input 2:
3
4
- - - -
V - X -
- V C V
- - - S
left
up
Output 2:
Santa ran out of presents!
- - - - 
V - - - 
- - S - 
- - - - 
No presents for 1 nice kid/s.

-------------- CODE -------------
using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Present_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int presents = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            ReadMatrix(matrix);
            int posRow = PositionX(matrix);
            int posCol = PositionY(matrix);
            int niseKids = 0;

            string direction;
            while ((direction = Console.ReadLine()) != "Christmas morning")
            {
                switch (direction)
                {
                    case "down":
                        matrix[posRow, posCol] = '-';
                        if (posRow + 1 < n)
                        {
                            posRow++;
                        }
                        else
                        {
                            // 
                        }
                        break;
                    case "up":
                        matrix[posRow, posCol] = '-';
                        if (posRow - 1 < 0)
                        {
                            //
                        }
                        else
                        {
                            posRow--;
                        }
                        break;
                    case "left":
                        matrix[posRow, posCol] = '-';
                        if (posCol - 1 < 0)
                        {
                            //
                        }
                        else
                        {
                            posCol--;
                        }
                        break;
                    case "right":
                        matrix[posRow, posCol] = '-';
                        if (posCol + 1 < n)
                        {
                            posCol++;
                        }
                        else
                        {
                            //
                        }
                        break;
                }

                if (matrix[posRow, posCol] == '-'|| matrix[posRow, posCol] == 'X')
                {
                    matrix[posRow, posCol] = 'S';
                }
                else if(matrix[posRow, posCol] == 'V')
                {
                    matrix[posRow, posCol] = 'S';
                    presents--;
                    niseKids++;
                    if (presents == 0)
                        break;
                }
                else if(matrix[posRow, posCol] == 'C')
                {
                    matrix[posRow, posCol] = 'S';
                    if (posRow + 1 < n && (matrix[posRow + 1, posCol]=='V'|| matrix[posRow + 1, posCol] == 'X'))
                    {
                        if (matrix[posRow + 1, posCol] == 'V')
                            niseKids++;
                        presents--;
                        if (presents == 0)
                        matrix[posRow+1, posCol] = '-';
                            break;
                    }
                    if (posRow - 1 >= 0 && (matrix[posRow - 1, posCol] == 'V' || matrix[posRow - 1, posCol] == 'X'))
                    {
                        if (matrix[posRow - 1, posCol] == 'V')
                            niseKids++;
                        matrix[posRow - 1, posCol] = '-';
                        presents--;
                        if (presents == 0)
                            break;
                    }
                    if (posCol + 1 < n && (matrix[posRow, posCol+1] == 'V' || matrix[posRow, posCol+1] == 'X'))
                    {
                        if (matrix[posRow, posCol+1] == 'V')
                            niseKids++;
                        matrix[posRow, posCol+1] = '-';
                        presents--;
                        if (presents == 0)
                            break;
                    }
                    if (posCol - 1 >= 0 && (matrix[posRow, posCol-1] == 'V' || matrix[posRow, posCol-1] == 'X'))
                    {
                        if (matrix[posRow, posCol-1] == 'V')
                            niseKids++;
                        matrix[posRow, posCol-1] = '-';
                        presents--;
                        if (presents == 0)
                            break;
                    }
                }
            }

            if (presents == 0)
            {
                Console.WriteLine("Santa ran out of presents!");
            }
            PrintMatrix(matrix);

            int countNiceKids = CountNiceKids(matrix);

            if(countNiceKids==0)
            {
                Console.WriteLine($"Good job, Santa! {niseKids} happy nice kid/s.");
            }
            else
            {
                Console.WriteLine($"No presents for {countNiceKids} nice kid/s.");
            }
            
        }

        private static int CountNiceKids(char[,] matrix)
        {
            int result = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'V')
                    {
                        result++;
                    }
                }
            }

            return result;
        }

        private static int PositionX(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'S')
                    {
                        return row;
                    }
                }
            }

            return -1;
        }

        private static int PositionY(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'S')
                    {
                        return col;
                    }
                }
            }

            return -1;
        }
        private static void ReadMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] currentRow = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}

 */
/* RetakeExam 2019.12.17 - 3.Christmas
        Can you imagine Santa without his special bag that carries presents for so many children? Neither can we. So let's have a quick sneak peek inside it and help  Santa rearrange it.
        Preparation
        Download the skeleton provided in Judge. Do not change the StartUp class or its namespace.
        Problem description
        Your task is to create a repository which stores presents by creating the classes described below.
        First, write a C# class Present with the following properties:
        •	Name: string
        •	Weight: double
        •	Gender: string
        The class constructor should receive name, weight and gender. Override the ToString() method in the following format:
        "Present {name} ({weight}) for a {gender}"
        Next, write a C# class Bag that has data (a collection which stores the entity Present). All entities inside the repository have the same properties. Also, the Bag class should have those properties:
        •	Color: string
        •	Capacity: int
        The class constructor should receive color and capacity, also it should initialize the data with a new instance of the collection. Implement the following features:
        •	Field data - collection that holds added presents
        •	Method Add(Present present) - adds an entity to the data if there is room for it
        •	Method Remove(string name) - removes a present by given name, if such exists, and returns bool
        •	Method GetHeaviestPresent() - returns the heaviest present
        •	Method GetPresent(string name) - returns the present with the given name
        •	Getter Count - returns the number of presents
        •	Report() - returns a string in the following format (print the presents in order of appearance):	
        o	"{color of Bag} bag contains:
        {Present1}
        {Present2}
        (…)"
        Constraints
        •	The names of the presents will be always unique.
•	You will always have a present added before receiving methods manipulating the Bag’s presents.

--------- CODE ------
namespace Christmas
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            //Initialize the repository (Bag)
            Bag bag = new Bag("Blue", 20);
            //Initialize entity
            Present present = new Present("Train", 0.4, "Boy");
            //Print Present
            Console.WriteLine(present); // Present Train for a Boy

            //Add Present
            bag.Add(present);
            Console.WriteLine(bag.Count); //1
                                          //Remove Present
            bag.Remove("Doll"); //false

            Present secondPresent = new Present("Doll", 0.7, "Girl");

            //Add Present
            bag.Add(secondPresent);

            //Get heaviest present
            Present heaviestPresent = bag.GetHeaviestPresent(); // Present Doll for a Girl
                                                                //Get present
            Present searchedPresent = bag.GetPresent("Train"); // Present Train for a Boy

            Console.WriteLine(bag.Report());
            // Blue bag contains:
            // Present Train for a Boy
            // Present Doll for a Girl

        }
    }
}

    class Bag
    {
        private List<Present> presents;
        public Bag(string color, int capacity)
        {
            Color = color;
            Capacity = capacity;
            this.presents = new List<Present>();
        }

        public string Color { get; set; }
        public int Capacity { get; set; }

        public int Count => this.presents.Count;

        public void Add(Present present)
        {
            if (presents.Count < this.Capacity)
            {
                presents.Add(present);
            }
        }

        public bool Remove(string name)
        {
            presents = presents.Where(x => x.Name != name).Select(y => y).ToList();
            if (presents == null)
            {
                return false;
            }

            return true;
        }

        public Present GetHeaviestPresent()
        {
            var heaviestPresent =
                this.presents
                    .OrderByDescending(x => x.Weight)
                    .First();

            return heaviestPresent;
        }

        public Present GetPresent(string name)
        {
            var namePresent =
                this.presents
                    .Where(x => x.Name == name)
                    .First();

            return namePresent;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Color} bag contains:");
            if (this.presents.Count >= 0)
            {
                foreach (var item in this.presents)
                {
                    sb.AppendLine($"{item}");
                }
            }

            return sb.ToString().Trim();
        }
    }

    class Present
    {
        public Present(string name, double weight, string gender)
        {
            Name = name;
            Weight = weight;
            Gender = gender;
        }

        public string Name { get; set; }
        public double Weight { get; set; }
        public string Gender { get; set; }

        public override string ToString()
        {
            return $"Present {Name} ({Weight}) for a {Gender}";
        }
    }
 */
/* EXAM 2020.02.22 - 1. Lootbox
        You are tired of being the only one on your team without cool items, so you decided buy some loot boxes which have a chance to drop some cool items.
        Every purchase gives you two loot boxes and they are represented as a sequence of integers. First, you will be given a sequence of integers, representing the first loot box. Afterwards, you will be given another sequence of integers representing the second loot box. 
        You need to start from the first item in the first box and sum it with the last item in the second box. If the sum of their values is an even number, add the summed item to your collection of claimed items and remove them both from the boxes. Otherwise, move the last item from the second box and add it at the last position in the first box. You need to stop summing items when one of the boxes becomes empty.
        If the first loot box becomes empty print:
	        "First lootbox is empty"
        If the second loot box becomes empty print:
	        "Second lootbox is empty"
        In the end you need to determine the quality of your claimed items. If the sum of the claimed items equal to or greater than 100, print:
	        "Your loot was epic! Value: {sum of claimed items}"
        Else print:
	        "Your loot was poor... Value: {sum of claimed items}"
        Input
        •	On the first line, you will receive the integers representing the first loot box, separated by a single space. 
        •	On the second line, you will receive the integers representing the second loot box, separated by a single space.
        Output
        •	On the first line of output – print which box got empty in the format described above.
        •	On the second line – the quality of your loot in the format described above.
        Constraints
        •	All of the given numbers will be valid integers in the range [0, 100].
        •	There won’t be a case where both loot boxes become empty at the same time.
Input 1:
10 11 8 13 5 6
0 4 7 3 6 23 3
Output 1:
Second lootbox is empty
Your loot was poor... Value: 42

Input 2:
20 40 60 80 100
10 20 30 40 50 60
Output 2:
First lootbox is empty
Your loot was epic! Value: 500
------------------------ CODE ------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _01._Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> lotBox1 = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> lotBox2 = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int sum = 0;

            while(lotBox1.Count>0 && lotBox2.Count > 0)
            {
                if(lotBox1.Peek()==0 && lotBox2.Peek() == 0)
                {
                    if(lotBox1.Peek() == 0)
                    {
                        lotBox1.Dequeue();
                    }

                    if (lotBox2.Peek() == 0)
                    {
                        lotBox2.Pop();
                    }

                    continue;
                }

                if((lotBox1.Peek() + lotBox2.Peek()) % 2 != 0)
                {
                    lotBox1.Enqueue(lotBox2.Pop());
                }
                else
                {
                    sum += lotBox1.Peek() + lotBox2.Peek();
                    lotBox1.Dequeue();
                    lotBox2.Pop();
                }
            }

            if (lotBox1.Count <= 0)
            {
                Console.WriteLine("First lootbox is empty");
            }

            if (lotBox2.Count <= 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (sum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {sum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {sum}");
            }
        }
    }
}
 */
/* EXAM 2020.02.22 - 2. Re-Volt
        You will be given an integer n for the size of the square matrix and an integer for the count of commands. On the next n lines, you will receive the rows of the matrix. The player starts at a random position (the player is marked with "f") and all of the empty slots will be filled with "-" (dash). The goal is to reach the finish mark which will be marked with "F". On the field there can also be bonuses and traps. Bonuses are marked with "B" and traps are marked with "T".
        Each turn you will be given commands for the player’s movement. If the player goes out of the matrix, he comes in from the other side. For example, if the player is on 0, 0 and the next command is left, he goes to the last spot on the first row.
        If the player steps on a bonus, he should move another step forward in the direction he is going. If the player steps on a trap, he should move a step backwards.
        When the player reaches the finish mark or the count of commands is reached the game ends.
        Input
        •	On the first line, you are given the integer N – the size of the square matrix.
        •	On the second you are given the count of commands.
        •	The next N lines holds the values for every row.
        •	On each of the next lines you will get commands for movement directions.
        Output
        •	If the player reaches the finish mark, print: 
        o	"Player won!"
        •	If the player reaches the commands count and hasn’t reached the finish mark print:
        o	"Player lost!"
        •	In the end print the matrix.
        Constraints
        •	The size of the matrix will be between [2…20].
        •	The players will always be indicated with "f".
        •	If the player steps on the finish mark at the same time as his last command, he wins the game.
        •	Commands will be in the format up, down, left or right.
        •	There won't be a case where you bypass the finish while you are on a trap or a bonus.
        •	A trap will never place you into a bonus or another trap and a bonus will never place you into a trap or another bonus.
Input 1:
5
5
-----
-f---
-B---
--T--
-F---
down
right
down
Output 2:
Player won!
-----
-----
-B---
--T--
-f---

Input 2:
4
3
----
-f-B
--T-
---F
up
up
left
Output 2:
Player lost!
----
---B
--T-
f--F
----------- CODE ----------
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace _02._Re_Volt
{
    class Program
    {
        public class Position
        {
            public Position(int row, int col)
            {
                Col = col;
                Row = row;
            }

            public int Row { get; set; }

            public int Col { get; set; }

            public bool IsSafe(int rowCount, int colCount) // оставаме ли в матрицата? ДА - true / НЕ - false
            {
                if (Row < 0 || Col < 0)
                {
                    return false;
                }
                if (Row >= rowCount || Col >= colCount)
                {
                    return false;
                }

                return true;
            }

            public void CheckOtherSideMovement(int rowCount, int colCount) // ако сме излезли извън матрицата, влизаме от другата страна
            {
                if (Row < 0)
                {
                    Row = rowCount - 1;
                }
                if (Col < 0)
                {
                    Col = colCount - 1;
                }
                if (Row >= rowCount)
                {
                    Row = 0;
                }
                if (Col >= colCount)
                {
                    Col = 0;
                }
            }

            public static Position GetDirection(string command)
            {
                int row = 0;
                int col = 0;
                if (command == "left")
                {
                    col = -1;
                }
                if (command == "right")
                {
                    col = 1;
                }
                if (command == "up")
                {
                    row = -1;
                }
                if (command == "down")
                {
                    row = 1;
                }

                return new Position(row, col);
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //размера на матрицата
            char[,] matrix = new char[n, n];
            int commands = int.Parse(Console.ReadLine()); // колко команди ще бъдат подадени
            
            ReadMatrix(matrix);
            var player = GetPlayerPosition(matrix);
            if (commands > 0)
            {
                matrix[player.Row, player.Col] = '-';
            }
            for (int i = 0; i < commands; i++)
            {
                string command = Console.ReadLine();

                MovePlayer(player, command, n);
                while (matrix[player.Row, player.Col] == 'B')
                {
                    MovePlayer(player, command, n);
                }

                while (matrix[player.Row, player.Col] == 'T')
                {
                    Position direction = Position.GetDirection(command); 
                    player.Row += direction.Row * -1; // връща ред назад
                    player.Col += direction.Col * -1; // връща колона назад
                }

                if (matrix[player.Row, player.Col] == 'F')
                {
                    Console.WriteLine($"Player won!");
                    matrix[player.Row, player.Col] = 'f';
                    PrintMatrix(matrix);
                    return;
                }
            }
            Console.WriteLine($"Player lost!");
            matrix[player.Row, player.Col] = 'f';
            PrintMatrix(matrix);
        }

        static Position MovePlayer(Position player, string command, int n) // 
        {
            Position movement = Position.GetDirection(command); // в каква посока се движим
            player.Row += movement.Row; // изчислява новата позиция на реда
            player.Col += movement.Col; // изчислява новата позиция на колоната
            player.CheckOtherSideMovement(n, n);    // ако сме излезли изнън матрицата, влизаме от другата страна

            return player;  // връща новата позиция
        }
        static Position GetPlayerPosition(char[,] matrix) // намиране позицията на играча
        {
            Position position = null;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'f')
                    {
                        position = new Position(row, col);
                    }
                }
            }

            return position;
        }

        private static void ReadMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string line = Console.ReadLine();
                for (int col = 0; col < line.Length; col++)
                {
                    matrix[row, col] = line[col];
                }
            }
        }   // четем матрицата от конзолата

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }   // разпечатваме матрицата
    }
}

*/
/* EXAM 2020.02.22 - 3. Guild
        Your task is to create a repository which stores players by creating the classes described below.
        First, write a C# class Player with the following properties:
        •	Name: string
        •	Class: string
        •	Rank: string – "Trial" by default
        •	Description: string – "n/a" by default
        The class constructor should receive name and class. Override the ToString() method in the following format:
        "Player {Name}: {Class}
        Rank: {Rank}
        Description: {Description}"
        Next, write a C# class Guild that has a roster (a collection which stores the entity Player). All entities inside the repository have the same properties. Also, the Guild class should have those properties:
        •	Name: string
        •	Capacity: int
        The class constructor should receive name and capacity, also it should initialize the roster with a new instance of the collection. Implement the following features:
        •	Field roster - collection that holds added players
        •	Method AddPlayer(Player player) - adds an entity to the roster if there is room for it
        •	Method RemovePlayer(string name) - removes a player by given name, if such exists, and returns bool
        •	Method PromotePlayer(string name) - promote (set his rank to "Member") the first player with the given name. If the player is already a "Member", do nothing.
        •	Method DemotePlayer(string name)- demote (set his rank to "Trial") the first player with the given name. If the player is already a "Trial",  do nothing.
        •	Method KickPlayersByClass(string class) - removes all the players by the given class and returns all players from that class as an array
        •	Getter Count - returns the number of players
        •	Report() - returns a string in the following format:	
        o	"Players in the guild: {guildName}
        {Player1}
        {Player2}
        (…)"
        Constraints
        •	The names of the players will be always unique.
        •	You will always have a player added before receiving methods manipulating the Guild's players.
 
--------------- CODE ----------
using System;
using System.Linq;

namespace Guild
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Initialize the repository (guild)
            Guild guild = new Guild("Weekend Raiders", 20);
            //Initialize entity
            Player player = new Player("Mark", "Rogue");
            //Print player
            Console.WriteLine(player); //Player Mark: Rogue
                                       //Rank: Trial
                                       //Description: n/a

            //Add player
            guild.AddPlayer(player);
            Console.WriteLine(guild.Count); //1
            Console.WriteLine(guild.RemovePlayer("Gosho")); //False

            Player firstPlayer = new Player("Pep", "Warrior");
            Player secondPlayer = new Player("Lizzy", "Priest");
            Player thirdPlayer = new Player("Mike", "Rogue");
            Player fourthPlayer = new Player("Marlin", "Mage");

            //Add description to player
            secondPlayer.Description = "Best healer EU";

            //Add players
            guild.AddPlayer(firstPlayer);
            guild.AddPlayer(secondPlayer);
            guild.AddPlayer(thirdPlayer);
            guild.AddPlayer(fourthPlayer);

            //Promote player
            guild.PromotePlayer("Lizzy");

            //RemovePlayer
            Console.WriteLine(guild.RemovePlayer("Pep")); //True

            Player[] kickedPlayers = guild.KickPlayersByClass("Rogue");
            Console.WriteLine(string.Join(", ", kickedPlayers.Select(p => p.Name))); //Mark, Mike

            Console.WriteLine(guild.Report());
            //Players in the guild: Weekend Raiders
            //Player Lizzy: Priest
            //Rank: Member
            //Description: Best healer EU
            //Player Marlin: Mage
            //Rank: Trial
            //Description: n/a

        }
    }
}

    public class Guild
    {
        private List<Player> roster;

        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            this.roster = new List<Player>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count => this.roster.Count;

        public void AddPlayer(Player player)
        {
            if (roster.Count < this.Capacity)
            {
                roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            int count = 0;
            foreach (var item in roster)
            {
                if(item.Name== name)
                {
                    count++;
                }
            }
            if(count==0)
            {
                return false;
            }
            
            roster = roster.Where(x => x.Name != name).ToList();
            return true;
        }

        public void PromotePlayer(string name)
        {
            var nameMember =
                this.roster
                    .Where(x => x.Name == name)
                    .First();
            if (nameMember.Rank != "Member")
            {
                nameMember.Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            var nameMember =
                this.roster
                    .Where(x => x.Name == name)
                    .First();
            if (nameMember.Rank != "Trial")
            {
                nameMember.Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string species)
        {
            var kik = roster.Where(x => x.Class == species).ToArray();
            foreach (var item in kik)
            {
                roster.Remove(item);
            }

            return kik;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Players in the guild: {Name}");
            foreach (var item in roster)
            {
                sb.AppendLine(item.ToString());
            }
            
            return sb.ToString().Trim();
        }
    }
 
    public class Player
    {
        string rank = "Trial";
        string description = "n/a";

        public Player(string name, string @class)
        {
            Name = name;
            Class = @class;
            Rank = rank;
            Description = description;
        }

        public string Name { get; set; }
        public string Class { get; set; }
        public string Rank { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Player {Name}: {Class}");
            sb.AppendLine($"Rank: { Rank}");
            sb.AppendLine($"Description: { Description}");
            
            return sb.ToString().Trim();
        }
    }
 */
/* RetakeExam 2020.08.19 - 1. Flower Wreaths
        You want to go on a flowers wreath competition but to participate you have to make at least 5 flower wreaths.

        You will be given two sequences of integers, representing roses and lilies. You need to start making wreaths knowing that one wreath needs 15 flowers. Your goal is to make at least 5 flower wreaths.
        You will start crafting from the last lilies and the first roses. If the sum of their values is equal to 15 – create one wreath and remove them. If the sum is bigger than 15, just decrease the value of the lilies by 2. If the sum is less than 15 you have to store them for later and remove them. You need to stop combining when you have no more roses or lilies. In the end, if you have any stored flowers you should make as many wreaths as you can with them. 
        Input
        •	On the first line, you will receive the integers representing the lilies, separated by ", ".
        •	On the second line, you will receive the integers representing the roses, separated by ", ".
        Output
        •	Print whether you have succeeded making at least 5 wreaths:
        o	"You made it, you are going to the competition with {count of wreaths} wreaths!" 
        o	"You didn't make it, you need {wreaths needed} wreaths more!"

        Constraints
        •	All of the given numbers will be valid integers in the range [0, 120].
        •	Don't have situation with negative number.
Input 1:
10, 15, 2, 7, 9, 13
2, 10, 8, 12, 0, 5
Output 1:
You made it, you are going to the competition with 5 wreaths!

Input 2:
10, 5, 3, 7, 8
5, 10, 8, 7, 6
Outpt 2:
Output
You didn't make, you need 1 wreaths more!
-------------------- CODE ------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace _01._Flower_Wreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Queue<int> roses = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            int wreath = 0;
            int flawerLeft = 0;

            while(lilies.Count>0 && roses.Count > 0)
            {
                int sum = lilies.Peek()+roses.Peek();
                while (sum > 15)
                {
                    sum -= 2;
                }
                if (sum == 15)
                {
                    wreath++;
                    lilies.Pop();
                    roses.Dequeue();
                }
                else
                {
                    flawerLeft += sum;
                    lilies.Pop();
                    roses.Dequeue();
                }
            }

            int wreathAditional = flawerLeft / 15;
            wreath += wreathAditional;

            if (wreath >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreath} wreaths!");
            }
            else 
            {
                Console.WriteLine($"You didn't make it, you need {5-wreath} wreaths more!");
            }
        }
    }
}

 */
/* RetakeExam 2020.08.19 - 2. Bee
        You will be given an integer n for the size of the bee territory with square shape. On the next n lines, you will receive the rows of the territory. The bee will be placed on a random position, marked with the letter 'B'. On random positions there will be flowers, marked with 'f'. There may also be а bonus on the territory. There will always be only one bonus. It will be marked with the letter - 'O'. All of the empty positions will be marked with '.'.
        Each turn, you will be given a command for the bee’s movement.
        The commands will be: "up", "down", "left", "right", "End".
        If the bee moves to a flower, it pollinates the flower and increases the pollinated flowers with one.
        If it goes to a bonus, the bee gets a bonus one move forward and then the bonus disappears. If the bee goes out she can't return back and the program ends. If the bee receives the "End" command the program ends. The bee needs at least 5 pollinated flowers.
        Input
        •	On the first line, you are given the integer n – the size of the square matrix.
        •	The next n lines hold the values for every row.
        •	On each of the next lines, until you receive "End" command,  you will receive a move command.
        Output
        •	On the first line:
        o	If the bee goes out of its territory print: "The bee got lost!"
        •	On the second line:
        o	 If the bee couldn’t pollinate enough flowers, print: "The bee couldn't pollinate the flowers, she needed {needed} flowers more"
        o	If the bee successfully pollinated enough flowers, print: "Great job, the bee managed to pollinate {polinationed flowers} flowers!"
        •	In the end print the matrix.
        Constraints
        •	The size of the square matrix will be between [2…10].
        •	There will always be 0 or 1 bonus, marked with - 'O'.
        •	The bee position will be marked with 'B'.
        •	There won't be a case where a bonus moves the bee out of its territory.
Input 1:
5
Bff..
..O..
f.f.f
.....
fffff
right
right
down
left
left
down
down
right
down
Output 1:
The bee got lost!
Great job, the bee managed to pollinate 6 flowers!
.....
.....
....f
.....
..fff

Input 2:
4
....
.O..
ff..
f.B.
left
left
up
right
up
End
Output 2:
The bee couldn't pollinate the flowers, she needed 2 flowers more
.B..
....
....
....
---------------- CODE ----------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace _02._BEE
{
    public class Program
    {
        public class Position
        {
            public Position(int row, int col)
            {
                Col = col;
                Row = row;
            }

            public int Row { get; set; }

            public int Col { get; set; }

            public bool IsSafe(int rowCount, int colCount) // оставаме ли в матрицата? ДА - true / НЕ - false
            {
                if (Row < 0 || Col < 0)
                {
                    return false;
                }
                if (Row >= rowCount || Col >= colCount)
                {
                    return false;
                }

                return true;
            }

            public bool CheckOtherSideMovement(int rowCount, int colCount) // ако сме излезли извън матрицата, приключваме
            {
                if (Row < 0 || Col < 0|| Row >= rowCount|| Col >= colCount)
                {
                    return false;
                }

                return true;
            }

            public static Position GetDirection(string command) // определя посоката със стъпка 1
            {
                int row = 0;
                int col = 0;
                if (command == "left")
                {
                    col = -1;
                }
                if (command == "right")
                {
                    col = 1;
                }
                if (command == "up")
                {
                    row = -1;
                }
                if (command == "down")
                {
                    row = 1;
                }

                return new Position(row, col);
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //размера на матрицата
            char[,] matrix = new char[n, n];
            string command;
            bool gameOver = false;

            ReadMatrix(matrix);
            var player = GetPlayerPosition(matrix);
            int pollinate = 0;

            while ((command = Console.ReadLine()) != "End")
            {
                var oldPosition = player;
                matrix[oldPosition.Row, oldPosition.Col] = '.';

                if (!MovePlayer(player, command, n))
                {
                    gameOver = true;
                    break;
                }
                while (matrix[player.Row, player.Col] == 'O')
                {
                    matrix[player.Row, player.Col] = 'B';
                    oldPosition = player;
                    matrix[oldPosition.Row, oldPosition.Col] = '.';
                    if (!MovePlayer(player, command, n))
                    {
                        gameOver = true;
                        break;
                    }
                    if (matrix[player.Row, player.Col] == 'f')
                    {
                        pollinate++;
                    }
                    
                    matrix[player.Row, player.Col] = 'B';
                }

                if (matrix[player.Row, player.Col] == 'f')
                {
                    pollinate++;
                }
                
                matrix[player.Row, player.Col] = 'B';
            }

            if (gameOver)
            {
                Console.WriteLine("The bee got lost!");
            }

            if (pollinate >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {pollinate} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5-pollinate} flowers more");
            }
            
            PrintMatrix(matrix);

        }

        static bool MovePlayer(Position player, string command, int n) // 
        {
            Position movement = Position.GetDirection(command); // в каква посока се движим
            player.Row += movement.Row; // изчислява новата позиция на реда
            player.Col += movement.Col; // изчислява новата позиция на колоната
            if(player.Row >= 0 && player.Row < n && player.Col >= 0 && player.Col < n)
            {
                return true;  // връща новата позиция
            }
            return false;
        }
        static Position GetPlayerPosition(char[,] matrix) // намиране позицията на играча
        {
            Position position = null;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        position = new Position(row, col);
                    }
                }
            }

            return position;
        }

        private static void ReadMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string line = Console.ReadLine();
                for (int col = 0; col < line.Length; col++)
                {
                    matrix[row, col] = line[col];
                }
            }
        }   // четем матрицата от конзолата

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }   // разпечатваме матрицата
    }
}

 */
/* RetakeExam 2020.08.19 - 3. VetClinic
        Your task is to create a repository, which stores items by creating the classes described below.
        First, write a C# class Pet with the following properties:
        •	Name: string
        •	Age: int
        •	Owner: string
        The class constructor should receive name, age and owner. The class should override the ToString() method in the following format:
        "Name: {Name} Age: {Age} Owner: {Owner}"
        Next, write a C# class Clinic that has data (a collection, which stores the Pets). All entities inside the repository have the same properties. Also, the Clinic class should have those properties:
        •	Capacity: int
        The class constructor should receive capacity, also it should initialize the data with a new instance of the collection. Implement the following features:
        •	Field data – collection that holds added pets
        •	Method Add(Pet pet) – adds an entity to the data if there is an empty cell for the pet.
        •	Method Remove(string name) – removes the pet by given name, if such exists, and returns bool.
        •	Method GetPet(string name, string owner) – returns the pet with the given name and owner or null if no such pet exists.
        •	Method GetOldestPet() – returns the oldest Pet.
        •	Getter Count – returns the number of pets.
        •	GetStatistics() – returns a string in the following format:
        o	"The clinic has the following patients:
        Pet {Name} with owner: {Owner}
        Pet {Name} with owner: {Owner}
           (…)"
        Constraints
        •	The combinations of names and owners will always be unique.
        •	The age of the pets will always be positive.
--------- CODE ------------
using System;

namespace VetClinic
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // Initialize the repository
            Clinic clinic = new Clinic(20);

            // Initialize entity
            Pet dog = new Pet("Ellias", 5, "Tim");

            // Print Pet
            Console.WriteLine(dog); // Ellias 5 (Tim)

            // Add Pet
            clinic.Add(dog);

            // Remove Pet
            Console.WriteLine(clinic.Remove("Ellias")); // True
            Console.WriteLine(clinic.Remove("Pufa")); // False

            Pet cat = new Pet("Bella", 2, "Mia");
            Pet bunny = new Pet("Zak", 4, "Jon");

            clinic.Add(cat);
            clinic.Add(bunny);

            // Get Oldest Pet
            Pet oldestPet = clinic.GetOldestPet();
            Console.WriteLine(oldestPet); // Zak 4 (Jon)

            // Get Pet
            Pet pet = clinic.GetPet("Bella", "Mia");
            Console.WriteLine(pet); // Bella 2 (Mia)

            // Count
            Console.WriteLine(clinic.Count); // 2

            // Get Statistics
            Console.WriteLine(clinic.GetStatistics());
            //The clinic has the following patients:
            //Bella Mia
            //Zak Jon
        }
    }
}

    class Clinic
    {
        private List<Pet> pets;

        public Clinic(int capacity)
        {
            Capacity = capacity;
            this.pets = new List<Pet>();
        }

        public int Capacity { get; set; }

        public int Count
            => this.pets.Count; // връща броя на клетките

        public void Add(Pet pet)
        {
            if (Count < Capacity)
            {
                pets.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            bool exists = pets.Any(x => x.Name == name);
            if (exists)
            {
                pets = pets.Where(x => x.Name != name).ToList();
                return true;
            }    
            return false;
        }

        public Pet GetPet(string name, string owner)
        {
            bool exists = pets.Any(x => x.Name == name && x.Owner == owner);
            if (exists)
            {
                var getPet = pets.Where(x => x.Name == name && x.Owner == owner).First();
                return getPet;
            }
            else
            {
                return null; 
            }
        }

        public Pet GetOldestPet()
        {
            var oldestPet = pets.OrderByDescending(x => x.Age).First();
            return oldestPet;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("The clinic has the following patients:");
            foreach (var item in pets)
            {
                sb.AppendLine($"Pet {item.Name} with owner: {item.Owner}");
            }

            return sb.ToString().Trim();
        }
    } 

    class Pet
    {
        public Pet(string name, int age, string owner)
        {
            Name = name;
            Age = age;
            Owner = owner;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Owner { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} Age: {Age} Owner: {Owner}".ToString();
        }
    }

 */
/* Exam 2020.10.25 - 1. Scheduling
         * You are hired to create a program that schedules the work of a CPU and avoids tasks that could harm it.
        On the first line you will be given some tasks as integer values, separated by comma and space ", ". On the second line you will be given some threads as integer values, separated by a single space. On the third line, you will receive the integer value of a task that you need to kill. Your job is to stop the work of the CPU as soon as you get to this task, otherwise your CPU will crash. The thread that gets first to this task, kills it.
        The CPU works in the following way:
        •	It takes the first given thread value and the last given task value.
        •	If the thread value is greater than or equal to the task value, the task and thread get removed.
        •	If the thread value is less than the task value, the thread gets removed, but the task remains.
        After you finish the needed task, print on a single line:
        "Thread with value {thread} killed task {taskToBeKilled}"
        Then print the remaining threads (including the one that killed the task) starting from the first on a single line, separated by a single space.
        Input
        •	On the first line you will receive the tasks, separated by ", ".
        •	On the second line you will the threads, separated by a single space.
        •	On the third line, you will receive a single integer – value of the task to be killed.
        Output
        •	Print the thread that killed the task and task itself in the format given above.
        •	Print the remaining threads starting from the first on a single line, separated by a single space.
        Constraints
        •	The needed task will always be with a unique value
        •	You will always have enough threads to get to the needed task
Input 1:
20, 23, 54, 34, 90
150 64 20 34
54
Output 2:
Thread with value 20 killed task 54
20 34
Comment 1:
First, thread with value 150 is taken and the task with value 90. The thread has bigger value, so both thread and task get remove. Next, the thread 64 finishes task 34 and both get removed. Then thread 20 gets to task 54 and kills it.

Input 2:
33, 12, 15, 40, 45, 60
30 20 53 67 84 90
40
Output 2:
Thread with value 90 killed task 40
90
Comment 2:
Thread 30 takes task 60, but it the task has greater value, so the thread gets removed. Then thread 20 takes task 60 and the same happens – thread get removed. Then the same happens with thread 53. After that, thread 67 takes task 60 and finishes it. Then thread 84 finishes task 45.Finally, thread 90 gets to task 40, which should be killed and the program stops.
---------------- CODE --------------------
using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> tasks = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Queue<int> threads = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int taskToKill = int.Parse(Console.ReadLine());

            while (true)
            {
                if (tasks.Peek() == taskToKill)
                {
                    break;
                }
                if (threads.Peek() >= tasks.Peek())
                {
                    threads.Dequeue();
                    tasks.Pop();
                }
                else
                {
                    threads.Dequeue();
                }
            }

            Console.WriteLine($"Thread with value {threads.Peek()} killed task {taskToKill}");
            Console.WriteLine(String.Join(" ",threads));
        }
    }
}
 */
/* Exam 2020.10.25 - 2. Garden
Furion loves nature and that is why he has a beautiful square garden. He wants to plant it with magical flowers, so it can be even more beautiful. No one knows why, but he actually needs a software program to do that, that is why you'll write one for him.
You will be given N and M – integers, indicating the dimensions of the square garden. The garden is empty at the beginning – it has no flowers. Furion wants every place for a flower to be presented with a zero (0) when it is empty. After you finish creating the garden, you will start receiving two integers – Row and Column, separated by a single space – which represent the position at which Furion currently plants a flower. If you receive a position, which is outside of the garden, you should print "Invalid coordinates." and move on with the next position. This happens until you receive the command "Bloom Bloom Plow”. When you receive that input, all planted flowers should bloom.
The flowers are magical. When a flower blooms it instantly blooms flowers to all places to its left, right, up, and down, increasing their value with 1. Flowers can bloom multiple times, and each time the flower blooms – it becomes more and more beautiful, which means its value increases by 1. 
Input
•	On the first line of input you will receive two integers, separated by a single space – indicating the dimensions of the garden.
•	On the next several lines you will be receiving two integers separated by a single space – indicating the position at which Furion currently plants a flower.
•	When you receive the input line "Bloom Bloom Plow” the input sequence should end.
Output
•	Print "Invalid coordinates." each time you receive positions outside the garden.
•	The output is simple. Print the whole garden – each row of it on a new line, and each column – separated by a single space.
Constraints
•	The dimensions of the matrix (N and M) will contains be integers in the range [3, 500].
•	The amount of input commands will be in the range [0, N * M].
•	Flowers will always be planted on empty places.
Input 1:
5 5
1 1
3 3
Bloom Bloom Plow
Output 1:
0 1 0 1 0
1 1 1 2 1
0 1 0 1 0
1 2 1 1 1
0 1 0 1 0

Input 2:
4 4
0 0
3 3
1 1
2 2
Bloom Bloom Plow
Output 2:
1 2 2 2
2 1 2 2
2 2 1 2
2 2 2 1

------------------ CODE ---------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _2.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimention = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[,] matrix = new int[dimention[0], dimention[1]];
            FillMatrix(matrix);
            Queue<int> flowers = new Queue<int>();
            int rowF = 0;
            int colF = 0;

            string line;
            while((line= Console.ReadLine())!= "Bloom Bloom Plow")
            {
                int[] newPpositionF = line.Split().Select(int.Parse).ToArray();
                int newRow = newPpositionF[0];
                int newCol = newPpositionF[1];
                if(newRow<0 || newRow>=dimention[0] || newCol<0 || newCol >= dimention[1])
                {
                    Console.WriteLine("Invalid coordinates.");
                    continue;
                }
                rowF = newRow;
                colF = newCol;
                matrix[rowF, colF] = 1;
                flowers.Enqueue(rowF);
                flowers.Enqueue(colF);
            }

            BloomBloomPlow(matrix, flowers);

            PrintMatrix(matrix);
        }

        private static void BloomBloomPlow(int[,] matrix, Queue<int> flowers)
        {
            while (flowers.Count > 0)
            {
                int row = flowers.Dequeue();
                int col = flowers.Dequeue();

                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    if(col!=i)
                        matrix[row, i]++;
                }

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if(row !=i)
                    matrix[i,col]++;
                }
            }
        }

        private static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = 0;
                }
            }
        } 

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }   
    }
}

*/
/* Exam 2020.10.25 - 3. Classroom
        Your task is to create a repository, which stores items by creating the classes described below.
        First, write a C# class Student with the following properties:
        •	FirstName: string
        •	LastName: string
        •	Subject: string
        The class constructor should receive firstName, lastName and subject.  You need to create the appropriate getters and setters. The class should override the ToString() method in the following format:
        "Student: First Name = {firstName}, Last Name = {lastName}, Subject = {subject}"
        Next, write a C# class Classroom that has students (a collection, which stores the students) and a certain capacity. All entities inside the repository have the same fields. Also, the Classroom class should have the following properties:
        •	Capacity: int
        •	Count: int – returns the number of students in the classroom
        The class constructor should receive capacity, also it should initialize the students with a new instance of the collection. Implement the following features:
        •	Field students – collection that holds added students
        •	Method RegisterStudent(Student student) – adds an entity to the students if there is an empty seat for the student.
        o	Returns "Added student {firstName} {lastName}" if the student is successfully added
        o	Returns "No seats in the classroom" – if there are no more seats in the classroom

        •	Method DismissStudent(string firstName, string lastName) – removes the student by the given names
        o	Returns "Dismissed student {firstName} {lastName}" if the student is successfully dismissed
        o	Returns "Student not found" if the student is not in the classroom

        •	Method GetSubjectInfo(string subject) – returns all the students with the given subject in the following format:
        "Subject: {subjectName}
        Students:
        {firstName} {lastName}
        {firstName} {lastName}
        …"
        o	Returns "No students enrolled for the subject" if the student is not in the classroom

        •	Method GetStudentsCount() – returns the count of the students in the classroom.
        •	Method GetStudent(string firstName, string lastName) – returns the student with the given names. 
         Constraints
        •	The combinations of names will always be unique.
        •	The capacity will always be a positive number.
----------- CODE -----------
namespace ClassroomProject
{
    using System;
    public class StartUp
    {
        static void Main(string[] args)
        {
            // Initialize the repository
            Classroom classroom = new Classroom(10);
            // Initialize entities
            Student student = new Student("Peter", "Parker", "Geometry");
            Student studentTwo = new Student("Sarah", "Smith", "Algebra");
            Student studentThree = new Student("Sam", "Winchester", "Algebra");
            Student studentFour = new Student("Dean", "Winchester", "Music");
            // Print Student
            Console.WriteLine(student); // Student: First Name = Peter, Last Name = Parker, Subject = Geometry
            // Register Student
            string register = classroom.RegisterStudent(student);
            Console.WriteLine(register); // Added student Peter Parker
            string registerTwo = classroom.RegisterStudent(studentTwo);
            string registerThree = classroom.RegisterStudent(studentThree);
            string registerFour = classroom.RegisterStudent(studentFour);
            // Dismiss Student
            string dismissed = classroom.DismissStudent("Peter", "Parker");
            Console.WriteLine(dismissed); // Dismissed student Peter Parker
            string dismissedTwo = classroom.DismissStudent("Ellie", "Goulding");
            Console.WriteLine(dismissedTwo); // Student not found
            // Subject info
            string subjectInfo = classroom.GetSubjectInfo("Algebra");
            Console.WriteLine(subjectInfo);
            // Subject: Algebra
            // Students:
            // Sarah Smith
            // Sam Winchester
            string anotherInfo = classroom.GetSubjectInfo("Art");
            Console.WriteLine(anotherInfo); // No students enrolled for the subject
                                            // Get Student
            Console.WriteLine(classroom.GetStudent("Dean", "Winchester"));
            //Console.WriteLine(classroom.GetStudent("Dan", "Winchester"));
            // Student: First Name = Dean, Last Name = Winchester, Subject = Music
            //Console.WriteLine(classroom.Count);
        }
    }
}

    class Classroom
    {

        private List<Student> students;

        public Classroom(int capacity)
        {
            Capacity = capacity;
            this.students = new List<Student>();
        }
        public int Capacity { get; set; }

        public int Count =>
            this.students.Count;

        public string RegisterStudent(Student student)
        {
            if(students.Count< this.Capacity)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return $"No seats in the classroom";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {
            bool  exist = students.Any(x => x.FirstName == firstName && x.LastName == lastName);
            if (exist)
            {
                students = students.Where(x => x.FirstName != firstName && x.LastName != lastName).ToList();
                return $"Dismissed student {firstName} {lastName}";
            }
            else
            {
                return "Student not found";
            }
        }

        public string GetSubjectInfo(string subject)
        {
            bool exist = students.Any(x => x.Subject== subject);
            if (exist)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine("Students:");
                foreach (var item in students.Where(x => x.Subject == subject))
                {
                    sb.AppendLine($"{item.FirstName} {item.LastName}");
                }

                return sb.ToString().Trim();
            }
            else
            {
                return "No students enrolled for the subject";
            }
        }

        public int GetStudentsCount()
        {
            return students.Count;
        }

        public Student GetStudent(string firstName, string lastName)
        {
            bool exist = students.Any(x => x.FirstName == firstName && x.LastName == lastName);
            if (exist)
            {
                var getStudent = students.Where(x => x.FirstName == firstName && x.LastName == lastName).First();

                return getStudent;
            }
            else
            {
                return null;
            }
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, string subject)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }

        public override string ToString()
        {
            return $"Student: First Name = {FirstName}, Last Name = {LastName}, Subject = {Subject}".ToString();
        }
    }
 */