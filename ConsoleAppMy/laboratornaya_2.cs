// лаба 2 26.09.
// 1 задание
// Дана последовательность из n  элементов для не меньше 3. Определить количество локальных минимумов


// using System;
// class exercise_1{
//   static void Main() {
//     int cnt=0;
//     Console.WriteLine("Ведите количество элементов:");
//     int n=Convert.ToInt32(Console.ReadLine());
//     int a=Convert.ToInt32(Console.ReadLine()),b=Convert.ToInt32(Console.ReadLine()),c=Convert.ToInt32(Console.ReadLine());
//     if (n==3)
//     {
//       if ((a>b) & (c>b))
//       {
//       Console.WriteLine("1");
//       }
//       else {Console.WriteLine("0");}
//     }
    
//     else {
//       if ((a>b)&(c>b))
//       {
//         cnt ++;
//       }
//       for (int i=0; i<n-3; i++){
//       int x = Convert.ToInt32(Console.ReadLine());
//       a=b;
//       b=c;
//       c=x;
//       if ((a>b)&(c>b))
//       {
//         cnt ++;
//       }
//       }
//     }
//     Console.WriteLine(cnt);
//   }
// }


// Задание 2
// Дана последовательность из n  элементов для не меньше 3. Определить все ли элементы последовательности чётные
// class exercise_2{
//   static void Main() {
//     Console.WriteLine("Ведите количество элементов:");
//     int n=Convert.ToInt32(Console.ReadLine()), a=Convert.ToInt32(Console.ReadLine()), cnt=0;
//     if (a%2==0){cnt++;}
//       for (int i=0; i<n-1; i++){
//       a = Convert.ToInt32(Console.ReadLine());
//       if (a%2==0){cnt ++;}
//       }
//       if (cnt==n){Console.WriteLine("Все числа чётные!");}
//       else {Console.WriteLine("Какое-то число нечётное!");}
//     } }


// Задание 3
// Дана последовательность из n  элементов для не меньше 3. Необходимо определить два максимума
// class exercise_3{
//   static void Main() {
//     Console.WriteLine("Ведите количество элементов:");
//     int n=Convert.ToInt32(Console.ReadLine()), max_max=Convert.ToInt32(Console.ReadLine()), max_min=Convert.ToInt32(Console.ReadLine());

//       if (max_min>max_max){
//         max_max = max_min - max_max;
//         max_min = max_min - max_max;
//         max_max = max_max + max_min;
//       }

//       for (int i=0; i<n-2;i++){
//         int chif = Convert.ToInt32(Console.ReadLine());
//         if (chif>=max_min){max_min=chif;}
//         if (max_min>=max_max) 
//         {
//         max_max = max_min - max_max;
//         max_min = max_min - max_max;
//         max_max = max_max + max_min;
//         } } 

//       Console.WriteLine($"Первый максимум: {max_max}");
//       Console.WriteLine($"Второй максимум: {max_min}");
//         } }

