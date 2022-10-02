//Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

int GetNumber(string message)
 {
    int result = 0;
    bool correctInput = false;
    while(!correctInput)
        {         
            Console.WriteLine(message);         
            correctInput = int.TryParse(Console.ReadLine(), 
            out result); 

            if(result < 1)             
                correctInput = false;  

            if(!correctInput)             
                Console.WriteLine("Вы ввели некорректное число");          
                Console.WriteLine();     
        }      
        return result; 
 }      

//Console.WriteLine("Введите первое число:"); 
//int numA = int.Parse(Console.ReadLine() ?? "");
int numA = GetNumber("Введите первое число:");
 
//Console.WriteLine("Введите второе число:");
//int numB = int.Parse(Console.ReadLine()??"");
int numB = GetNumber("Введите второе число:");

double result = Math.Pow(numA, numB);

Console.WriteLine($"Число {numA} возведенное в степень {numB} равно: {result}");

 