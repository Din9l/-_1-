// Лаба 3 02.10.

// using System;


// определить Макс длину подпоследовательности из одинаковых элементов
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


// минимальную длину подпоследовательности из четных

// class exercise_2{
//   static void Main(){
//     int n = Convert.ToInt32(Console.ReadLine()), one = Convert.ToInt32(Console.ReadLine()), cnt=1, max_cnt=0, min_cnt=int.MaxValue, k=0;

//     for (int i=0; i<n-1; i++){
//       int two = Convert.ToInt32(Console.ReadLine());

//       if ((one%2==0)&(two%2==0)){
//         cnt++;
//         one = two; max_cnt=cnt;k=0;}

// 	else if ((one%2!=0)&(two%2==0)&(i==n-2)){min_cnt=1;k=1;}

//       else {if (max_cnt<min_cnt){min_cnt=max_cnt;};
// 	  cnt = 1;
//       one = two;
// 	  k=1;}}


// 	if (k==0){Console.WriteLine($"Итоговая длина: {max_cnt}");}

//     else {Console.WriteLine($"Итоговая длина: {min_cnt}");}
//   }
// }


// максимальную сумму подпоследовательности из четных элементов
// class exercise_3{
// static void Main(){
// 	int n = Convert.ToInt32(Console.ReadLine()), one = Convert.ToInt32(Console.ReadLine()), cnt=1, max_sum=int.MinValue, sum=0;
// 	for (int i=0; i<n-1; i++){
// 		int two = Convert.ToInt32(Console.ReadLine());

// 		if (one<0 & two<0 &(Math.Abs(one)%2==0)&(Math.Abs(two)%2==0)){

// 		cnt++;
// 		if (sum==0){sum = one+two;}
// 		else {sum = sum + two;}
// 		one = two;
// 		max_sum=0;
// 		if (sum<max_sum){max_sum=sum;}
// 		}

// 		else if ((one<0 || two<0)&(Math.Abs(one)%2==0)&(Math.Abs(two)%2==0)){

// 		cnt++;
// 		if (cnt==2){sum = one+two;}
// 		else {sum = sum + two;}
// 		one = two;
// 		if (sum>=max_sum){max_sum=sum;}
// 		if (max_sum==0 & sum<=0){max_sum=sum;}
// 		}


// 		else if ((one%2==0)&(two%2==0)){
// 		cnt++;
// 		if (sum==0){sum = one+two;}
// 		else {sum = sum + two;}
// 		one = two;
// 		if (sum>max_sum){max_sum=sum;}
// 		if (max_sum==0 & sum<0){max_sum=sum;}}


// 		else {cnt = 1;
// 		one = two;
// 		sum = 0;}

// 		}
// 	Console.WriteLine($"Максимальная сумма: {max_sum}");
// 	}}