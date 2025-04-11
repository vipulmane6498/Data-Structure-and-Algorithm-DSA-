//Left Most repeating character 

//abccb = here b repeated 1st so return its 1st b's index

using System;

class LeftMostRepeatingChar{
    
    public static void Main(String[] args){
        string s="abbcc";
    
    int result = Final(s);
    System.Console.WriteLine("Index of the Left most repeating character is: "+result);
    }
 
    static int Final(string s){
        for(int i=0; i<s.Length; i++){
            //below i+1 => its always start loop after the index of i so it will not start loop from starting index 
            for( int j=i+1; j<s.Length; j++){
                if(s[i]==s[j]){
                  //  b == b return its index
                    return i;
                }
            }
        }
        return -1;
    }
    
    
}

/*
Index of the Left most repeating character is: 1
*/