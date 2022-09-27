////// Strings   ///////

// string s1="   hello world   ";
// Console.WriteLine($"{s1}");
// Console.WriteLine($"{s1} has {s1.Length} characters");

// string s2=s1.TrimStart();
// Console.WriteLine(s2);

// string s3="****hello world****";
// char[] charsToTrim = { '*' };
// Console.WriteLine(s3.Trim(charsToTrim));
// Console.WriteLine(s1.Contains("hello"));
// Console.WriteLine(s1.StartsWith("hy"));



////////  Conditional  ////////

// Console.WriteLine("Enter the year");
// int Y=Convert.ToInt32(Console.ReadLine());
// if(Y%4==0){
//     Console.WriteLine("Leap Year");
// }
// else{
//     Console.WriteLine("Not a leap year");
// }


// Console.WriteLine("Enter The 1st Number");
// int a=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter The 2nd Number");
// int b=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter The 3rd Number");
// int c=Convert.ToInt32(Console.ReadLine());

// if(a>c){
//     if(a>b){
//         Console.WriteLine($"{a} is the largest number");
//     }
//     else{
//         Console.WriteLine($"{b} is the largest number");
//     }
// }
//     else if(c>b){
//         Console.WriteLine($"{c} is the largest number");
//     }
//     else{
//         Console.WriteLine($"{b} is largest number");
//     }




// ///////   LOOPS //////
// Console.WriteLine("Enter 1st number");
// int n1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter 2nd number");
// int n2=Convert.ToInt32(Console.ReadLine());

// int j,hcf=1;
// if(n1>n2){
//     j=n2;
// }
// else{
//     j=n1;
// }
// for(int i=1;i<=j;i++){
//     if(n1%i==0 && n2%i==0){
//         hcf=i;
//     }
// }
// Console.WriteLine($"Hcf is {hcf}");



//////   Lists   ////
// var l1=new List<int> {};
// l1.Add(5);
// l1.Add(83);
// l1.Add(12);
// Console.WriteLine(l1.IndexOf(83));
// l1.Sort();
// foreach(int i in l1){
//     Console.WriteLine(i);
// }


////  classes and objects   //////
// class Car 
// {
//       public string color;
//       public string model;
//       public int year;
//       public Car(string color,string model,int year){
//         this.color=color;
//         this.model=model;
//         this.year=year;
//       }
// }
// class Program
// {
//   static void Main(string[] args)
//   {
//     Car myObj = new Car("Red","Swift",2012);
//     Console.WriteLine(myObj.color);
//   }
// }


////////   LINQS   /////
var a1=new List<int>{1,3,8,2,6,33,53,21};
var nums=from i in a1 where i%3==0 select i;
Console.WriteLine("Numbers divisible by 3");
foreach(var j in nums){
Console.WriteLine(j);
}

var nums1=a1.TakeWhile(n=>n<6);
foreach(var j in nums1){
    Console.WriteLine(j);
}