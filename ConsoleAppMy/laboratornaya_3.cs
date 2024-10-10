// Лаба 3 

// using System;

// class exercise_1{
//   static void Main(){
//     int n = Convert.ToInt32(Console.ReadLine()), one = Convert.ToInt32(Console.ReadLine()), cnt=1, max_cnt=1;
//     for (int i=0; i<n-1; i++){
//       int two = Convert.ToInt32(Console.ReadLine());
//       if (one==two){
//         cnt++;
//         one = two;
//         if (cnt>max_cnt){max_cnt=cnt;}}
//       else {cnt = 1;
//       one = two;}
    
//     }
//     Console.WriteLine($"Итоговая длина: {max_cnt}");

//   }
// }


// class exercise_2{
//   static void Main(){
//     int n = Convert.ToInt32(Console.ReadLine()), one = Convert.ToInt32(Console.ReadLine()), cnt=1, max_cnt=0;
//     for (int i=0; i<n-1; i++){
//       int two = Convert.ToInt32(Console.ReadLine());
//       if ((one%2==0)&(two%2==0)){
//         cnt++;
//         one = two;
//         if (cnt>max_cnt){max_cnt=cnt;}}
//       else {cnt = 1;
//       one = two;}
    
//     }
//     Console.WriteLine($"Итоговая длина: {max_cnt}");

//   }
// }

// class exercise_3{
//   static void Main(){
//     int n = Convert.ToInt32(Console.ReadLine()), one = Convert.ToInt32(Console.ReadLine()), cnt=1, max_cnt=0, max_sum=0, sum=0;
//     for (int i=0; i<n-1; i++){
//       int two = Convert.ToInt32(Console.ReadLine());
//       if ((one%2==0)&(two%2==0)){
//         cnt++;
//         if (sum==0){sum = one+two;}
//         else {sum = sum + two;}
//         one = two;
//         Console.WriteLine(sum);
//         if (cnt>max_cnt){max_cnt=cnt;}
//         if (sum>max_sum){max_sum=sum;}}
//       else {cnt = 1;
//       one = two;
//       sum = 0;}
    
//     }
//     Console.WriteLine($"Итоговая длина: {max_cnt}, максимальная сумма: {max_sum}");

//   }
// }