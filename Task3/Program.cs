// Напишите программу, которая спрашивает у пользователя кол-во элементов и спршивает сами элементы. 
//После записи элементов в массив, необходимо его вывести на экран.
//8
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]    
// так и не понял как сделать что бы пользователь писал элименты
Console.Clear();
    Console.Write("Введите любое число (A): ");
            int enterNumber = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[enterNumber];

            for (int i = 0; i < enterNumber; i++)
            {
                array[i] = new Random().Next(enterNumber+1);
                Console.Write(array[i] + "; ");
            }
            Console.WriteLine();
       
       