// See https://aka.ms/new-console-template for more information
CalculatorApp();


void CalculatorApp()
{
    try
    {
        //prompt the user to enter the first number
        Console.WriteLine("Please enter your first number");
        int firstNumber = int.Parse(Console.ReadLine());

        //pronmt the user to evter the second number
        Console.WriteLine("Please enter yiur second number");
        int secondNumber = int.Parse(Console.ReadLine());

        //promt the user to enter the operation 
        Console.WriteLine("Enter the operation (+, -, /, *)");
        char Opperation = Convert.ToChar(Console.ReadLine());
        int result = 0;

        //preform the opperation
        switch(Opperation){

            case '*':
                result = firstNumber * secondNumber; 
                break;
            case '/':
                result = firstNumber / secondNumber;
                break;
            case '+':
                result = firstNumber + secondNumber;
                break;
            case '-':
                result = firstNumber - secondNumber;
                break;
            default:
                Console.WriteLine("Invalid opperation");
                CalculatorApp();
                return;
        }
        Console.WriteLine($"Result: {result}");
    }
    catch (FormatException ex){
        //handle a imput exeption
        Console.WriteLine("Please enter a valid number.");
        CalculatorApp();

    }
    catch (DivideByZeroException ex)
    {
        //error so the user knows they cand divid by zero
        Console.WriteLine($"Error:{ex.Message}.You cannot divide by zero.");
        CalculatorApp();

    }
    finally {
        //this happens nomatter what
        Console.WriteLine("Opperation compleate");
    }
}
