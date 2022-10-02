//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

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

//Console.WriteLine();
//int num = int.Parse(Console.ReadLine()?? "");
int num = GetNumber("Введите положительное число:");

   string str = num.ToString();
   int[] arr = new int[str.Length];
   int sum = 0;

   for (int i=0; i < str.Length; i++)
    {
      arr[i] = int.Parse(str[i].ToString());
      sum = sum + arr[i];
    }
 
 Console.WriteLine(sum);

    
