using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions_2 : MonoBehaviour
{
    int myInt = 5;



    void Start()
    {
        myInt = MultiplyByThree(myInt);
        Debug.Log(myInt);
    }

    int MultiplyByThree(int number)
    {
        int result;
        result = number * 3;
        return result;
    }
}
