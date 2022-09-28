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


////  classes and objects   //////\
class Vehical {
     public string color="";
      public string model="";
      public int year;
}
class Car : Vehical 
{
     
      public Car(string color,string model,int year){
        this.color=color;
        this.model=model;
        this.year=year;
      }
}
class Program
{
  static void Main(string[] args)
  {
    Car myObj = new Car("Red","Swift",2012);
    Console.WriteLine(myObj.color);
  }
}


////////   LINQS   /////
// var a1=new List<int>{1,3,8,2,6,33,53,21};
// var a2=new List<int>{2,5,7,4,9,12};
// var nums=from i in a1 where i%3==0 where i<=21 orderby i select i;
// Console.WriteLine("Numbers divisible by 3");
// foreach(var j in nums){
// Console.WriteLine(j);
// }
// Console.WriteLine("First numbers less than 6");
// var nums1=a1.TakeWhile(n=>n<6);
// foreach(var j in nums1){
//     Console.WriteLine(j);
// }
// Console.WriteLine("Paires where a1 has lesss value then a2");
// var p=from n1 in a1
//       from n2 in a2
//       where n1<n2
//       select(n1,n2);
// foreach(var p1 in p){
//     Console.WriteLine($"{p1.n1},{p1.n2}");
// }