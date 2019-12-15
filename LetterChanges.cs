using System;

class MainClass {

  public static string LetterChanges(string str) {
    
    string word = "";
    for(int i=0; i<str.Length; i++){
      if(IsEnglishLetter(str[i])){
          Char c = (Char)(Convert.ToUInt16(str[i]) + 1);
          bool isVowel = "aeiou".IndexOf(c.ToString(), StringComparison.InvariantCultureIgnoreCase) >= 0;
          if(isVowel){
             word += Char.ToUpper(c);
          }else{
              word += Char.ToLower(c);
          }
          
      }else{
        word += str[i];
      }

    }
    // code goes here  
    return word;

  }
  
  public static bool IsEnglishLetter(char c)
  {
    return (c>='A' && c<='Z') || (c>='a' && c<='z');
  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(LetterChanges(Console.ReadLine()));
  } 

}