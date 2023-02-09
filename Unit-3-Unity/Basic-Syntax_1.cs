using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSyntax_1 : MonoBehaviour
{
    void Start()
    {
        // learning more about commenting

        /*HELLO testing 123
         *this is line 2
         *line 3
         ***/
        Debug.Log(transform.position.x);

        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }
    
}
