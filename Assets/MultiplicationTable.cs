using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MultiplicationTable : MonoBehaviour
{
    
    void Start()
    {
        for(int i = 1 ; i <= 10 ; i++){
            int multi = Multiply(i , 5);
            Debug.Log("5 x " + i + " = " + multi) ;
        }
        
    }
    int Multiply(int number1, int number2){
        int output = number1 * number2;
        return output; 
    }

    
}
