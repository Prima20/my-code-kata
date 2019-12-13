using System;

class MainClass {

  public static string FirstReverse(string str) {
    
    string res = "";
    // code goes here  
    for(int i=str.Length-1; i>=0; i--){
      res += str[i];
    }
    return res;

  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(FirstReverse(Console.ReadLine()));
  } 

}