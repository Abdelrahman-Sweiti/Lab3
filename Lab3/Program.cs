namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Challenge1();
            Challenge2();
            Challenge3();
            Challenge4();
            Challenge5();
            Challenge6();
            Challenge7();
            Challenge8();
            Challenge9();
        }
        static void Challenge1()
        {
            Console.WriteLine("Challenge 1");
            Console.WriteLine("Please enter 3 numbers:");
            string input = Console.ReadLine();
            decimal product = MultiplyNumbers(input);
            Console.WriteLine($"The product of these 3 numbers is: {product}");
        }

        static decimal MultiplyNumbers(string input)
        {
            string[] numbers = input.Split(' ');

            decimal product = 1;

            for (int i = 0; i < 3 && i < numbers.Length; i++)
            {
                if (decimal.TryParse(numbers[i], out decimal number))
                {
                    product *= number;
                }
                else
                {
                    product *= 1;
                }
            }

            return product;
        }

        static void Challenge2()
        {
            Console.WriteLine("Challenge 2");
            Console.WriteLine("Please enter a number between 2-10:");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int count) && count >= 2 && count <= 10)
            {
                double average = FindAverage(count);
                Console.WriteLine($"The average of these {count} numbers is: {average}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 2-10.");
            }
        }

        static double FindAverage(int count)
        {
            double sum = 0;
            for (int i = 1; i <= count; i++)
            {
                Console.Write($"{i} of {count} - Enter a number: ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out double number) && number >= 0)
                {
                    sum += number;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a non-negative number.");
                    i--;
                }
            }
            return sum / count;
        }

        static void Challenge3()
        {
            Console.WriteLine("Challenge 3");
            Console.WriteLine();
            PrintPattern();
        }

        static void PrintPattern()
        {
            int size = 5;

            for (int i = -size + 1; i < size; i++)
            {
                for (int j = -size + 1; j < size; j++)
                {
                    if (Math.Abs(i) + Math.Abs(j) < size)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Challenge4()
        {
            Console.WriteLine("Challenge 4");
            int[] numbers = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };
            int mostFrequentNumber = FindMostFrequentNumber(numbers);
            Console.WriteLine($"The number that appears the most times is: {mostFrequentNumber}");
        }

        static int FindMostFrequentNumber(int[] numbers)
        {
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            foreach (int number in numbers)
            {
                if (frequencyMap.ContainsKey(number))
                {
                    frequencyMap[number]++;
                }
                else
                {
                    frequencyMap[number] = 1;
                }
            }

            int mostFrequentNumber = numbers[0];
            int maxFrequency = 1;

            foreach (var kvp in frequencyMap)
            {
                if (kvp.Value > maxFrequency)
                {
                    maxFrequency = kvp.Value;
                    mostFrequentNumber = kvp.Key;
                }
            }

            return mostFrequentNumber;
        }

        static void Challenge5()
        {
            Console.WriteLine("Challenge 5");
            int[] numbers = { 5, 25, 99, 123, 78, 96, 555, 108, 4 };
            int maxNumber = FindMaximumNumber(numbers);
            Console.WriteLine($"The maximum number in the array is: {maxNumber}");
        }

        static int FindMaximumNumber(int[] numbers)
        {
            int maxNumber = numbers[0];

            foreach (int number in numbers)
            {
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            return maxNumber;
        }

        static void Challenge6()
        {
            Console.WriteLine("Challenge 6");
            Console.WriteLine("Please enter a word:");
            string word = Console.ReadLine();
            SaveWordToFile(word);
        }

        static void SaveWordToFile(string word)
        {
            using (StreamWriter writer = new StreamWriter("words.txt", true))
            {
                writer.WriteLine(word);
            }
        }

        static void Challenge7()
        {
            Console.WriteLine("Challenge 7");
            Console.WriteLine("Contents of words.txt:");
            ReadFileContents();
        }

        static void ReadFileContents()
        {
            using (StreamReader reader = new StreamReader("words.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        static void Challenge8()
        {
            Console.WriteLine("Challenge 8");
            Console.WriteLine("Removing a word from words.txt...");
            RemoveWordFromFile("example");
        }

        static void RemoveWordFromFile(string wordToRemove)
        {
            string tempFile = Path.GetTempFileName();

            using (StreamReader reader = new StreamReader("words.txt"))
            using (StreamWriter writer = new StreamWriter(tempFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line != wordToRemove)
                    {
                        writer.WriteLine(line);
                    }
                }
            }

            File.Delete("words.txt");
            File.Move(tempFile, "words.txt");
        }

        static void Challenge9()
        {
            Console.WriteLine("Challenge 9");
            Console.WriteLine("Please enter a sentence:");
            string sentence = Console.ReadLine();
            string[] wordArray = GetWordCharacterCounts(sentence);
            Console.WriteLine("Word and Character Counts:");
            foreach (string wordCount in wordArray)
            {
                Console.WriteLine(wordCount);
            }
        }

        static string[] GetWordCharacterCounts(string sentence)
        {
            string[] words = sentence.Split(' ');

            string[] wordArray = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                int characterCount = word.Length;
                wordArray[i] = $"{word}: {characterCount}";
            }

            return wordArray;
        }

    }
}