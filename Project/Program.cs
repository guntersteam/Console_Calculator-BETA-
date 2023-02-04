namespace Project
{
    public class Program
    {
        static void Main()
        {
            string output, answer;
            Int64 num_1 = 0, num_2 = 0;
            bool again = false;
            do
            {
                Console.WriteLine("Hello and welcome to my first poop program :) can you please write a first number");
                num_1 = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("And second :)");
                num_2 = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Write an operation between numbers For example: -, +, *, /, ^,fib1");
                output = Console.ReadLine().ToLower();
                
            
            switch(output){
                case "+":
                Console.WriteLine($"The sum of {num_1} and {num_2} = {num_1 + num_2}");
                break;
                case "-":
                Console.WriteLine($"The difference of {num_1} and {num_2} = {num_1 - num_2}");
                break;
                case "*":
                Console.WriteLine ($"The multiplication of {num_1} and {num_2} = {num_1 * num_2}");
                break;
                case "/":
                Console.WriteLine($"The division of {num_1} and {num_2} = {(double) num_1 / num_2}");
                break;
                case "^":
                Console.WriteLine($"Number {num_1} in degree {num_2} = {Math.Pow(num_1, num_2)}");
                break;
                default:
                Console.WriteLine("wrong operation");
                break;
            }
                bool AA = true;
            do{
                Console.WriteLine("If you want to use this application type \"Y\" into console, otherwise type \"N\" ");
                answer = Console.ReadLine();
                if (answer == "Y")
                {
                    again = true;
                    AA = false;
                    Console.Clear();
                }
                else if (answer == "N")
                {
                    again = false;
                    AA = false;
                }
                else{
                    Console.WriteLine("wrong operation try again");
                    AA = true;
                    
                }
            }while(AA);
            } while (again);
            Console.WriteLine("Thats all");
            Console.WriteLine("If you practice more, you'll be the best");
            Console.ReadKey();

        }
    }
}
