using System;

class MainClass {

  public static int SimpleAdding(int num) {

    // code goes here
    if(num > 1){
          return num + SimpleAdding(num-1);
    }else{
      return 1;
    }


  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(SimpleAdding(Console.ReadLine()));
  } 

}