//Задача 29: Напишите программу, которая задаёт массив 
//           из 8 элементов и выводит их на экран.

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

int num = GetNumber("Введите восмизначное число:");

if (num < 10000000)
{
Console.WriteLine("Вы ввели некорректное число!");
}
else
{
    string str = num.ToString();
    for (int i=0; i<str.Length; i++) 
    {      
        Console.Write(str[i]+" ");
    }
}
Console.WriteLine();