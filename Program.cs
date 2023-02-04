using System;

namespace String04._02._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            
            string arr = "I a e y ";

            ////
            Console.WriteLine(arr);
            arr = arr.Remove(2,4);
            Console.WriteLine(arr);

            /////
            Console.WriteLine("Введите символ котрый хочете вставить ");
            string m = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите позицию куда вы хотите вставить символ ");
            int A = Convert.ToInt32(Console.ReadLine());
            arr = arr.Insert(A, m);
            Console.WriteLine(arr);

            /////
             int Count = 0;
            for (int i = 0; i<arr.Length; i++)
            {
                Count++;
            }
            Console.Write("Кол-во символов = "+Count);

            ////
            for (int i = arr.Length-1; i>=0; i--)
            {
                Console.Write(arr[i]);
            
            }

            Console.WriteLine("Введите русский текст");
            string text = Convert.ToString(Console.ReadLine());
            int Count = 0;
            for(int i =0 ;i<text.Length; i++)
            {
                if(text[i]=='A'||text[i]=='a')
                {
                    Count++;

                }
                if(text[i]=='E'||text[i]=='e')
                {
                    Count++;

                }
                if(text[i]=='Э'||text[i]=='э')
                {
                    Count++;

                }
                if(text[i]=='Ё'||text[i]=='ё')
                {
                    Count++;

                }
                if(text[i]=='И'||text[i]=='и')
                {
                   Count++;
                }
                if(text[i]=='О'||text[i]=='о')
                {
                    Count++;

                }

                if(text[i]=='Ы'||text[i]=='ы')
                {
                    Count++;

                }
                if(text[i]=='Ю'||text[i]=='ю')
                {
                    Count++;

                }
                if(text[i]=='Я'||text[i]=='я')
                {
                    Count++;

                }
                Console.Write("Кол-во глассных букв = "+Count);

            }

        }
    }
}
