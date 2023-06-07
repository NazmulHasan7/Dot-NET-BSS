using System;

namespace CSharpBasics.Excercises
{
    public class StringExcercises
    {
        public static void Excercise01()
        {
            Console.Write("Enter a few numbers separted by a hypen: ");
            var input = Console.ReadLine();
            
            if (String.IsNullOrEmpty(input))
                return;
            
            var numbers = input.Split('-');
            var isConsecutiveInc = false;
            var isConsecutiveDec = false;
            int currentNumber, nextNumber;
            var incNature = false;
            for(var i=0; i<numbers.Length-1; i++)
            {
                currentNumber = Convert.ToInt32(numbers[i]);
                nextNumber = Convert.ToInt32(numbers[i + 1]);
                isConsecutiveInc = (currentNumber+1 == nextNumber) ? true : false;
                if (i == 0 && isConsecutiveInc)
                    incNature = true;
                if(!incNature)
                    isConsecutiveDec = (currentNumber-1 == nextNumber) ? true : false;

                if (!isConsecutiveInc && !isConsecutiveDec)
                {
                    Console.WriteLine("Not Consecutive");
                    return;
                }
            }
            Console.WriteLine("Consecutive");
            return;
        }
        public static void Excercise02()
        {
            Console.Write("Enter a few numbers separted by a hypen: ");
            var input = Console.ReadLine();
            if(String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            var numbers = input.Split('-');
            var copiedNumbers = new List<string>();
            for(var i=0; i<numbers.Length; i++)
            {
                if (copiedNumbers.Contains(numbers[i]))
                {
                    Console.WriteLine("Contains duplicate");
                    break;
                }
                copiedNumbers.Add(numbers[i]);
            }
        }
        public static void Excercise03()
        {
            Console.WriteLine("Enter Time i.e 12.30: ");
            var input = Console.ReadLine();
            if(String.IsNullOrWhiteSpace (input))
            {
                Console.WriteLine("Invalid Input");
                return;
            }
            var times = input.Split(':');
            try
            {
                var hours = Convert.ToInt32(times[0]);
                var minutes = Convert.ToInt32(times[1]);
                if((hours >= 0 && hours <= 23) && (minutes >= 0 && minutes <=59))
                {
                    Console.WriteLine("Ok");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid Time");
                    return;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
            }
        }
        public static void Excercise04()
        {
            Console.Write("Enter words: ");
            var input = Console.ReadLine().ToLower();
            if(String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }
            var PascalCase = "";
            var words = input.Split(' ');
            foreach(var word in words)
            {
                PascalCase += char.ToUpper(word[0]) + word.Substring(1);
            }
            Console.WriteLine(PascalCase);
        }
        public static void Excercise05()
        {
            Console.Write("Enter a word: ");
            var input = Console.ReadLine();
            input = input.ToLower();
            int vowelCount = 0;
            var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            foreach(var character in input)
            {
                if (vowels.Contains(character))
                {
                    vowelCount++;
                }      
            }
            Console.WriteLine("Total vowels: " +vowelCount);
        }
    }
}
