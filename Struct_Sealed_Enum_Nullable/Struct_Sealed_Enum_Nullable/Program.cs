using Struct_Sealed_Enum_Nullable.Helpers;
using Struct_Sealed_Enum_Nullable.Services;

//string email = "fatima@gmail.com";
//if (email.CheckStr('@'))
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}

//string pass = "Agsgyasa56";
//Console.WriteLine(pass.CheckPasswordLength());
//Console.WriteLine(pass.CheckTextWithRegex(@"\d"));
//Console.WriteLine(pass.CheckTextWithRegex(@"[A-Za-z]"));
//int[] nums = { 1, 3, 5, 6 };
//Console.WriteLine(nums.MultiplearrayItems());

Console.WriteLine("Add number 1");
string num1 = Console.ReadLine();

Console.WriteLine("Add operation: +,-,*,/");
string operation = Console.ReadLine();

Console.WriteLine("Add number 2");
string num2 = Console.ReadLine();

CalculatorService calculatorService = new();

string response = calculatorService.Calculation(Convert.ToDouble(num1), operation, Convert.ToDouble(num2 ));
Console.WriteLine(response);