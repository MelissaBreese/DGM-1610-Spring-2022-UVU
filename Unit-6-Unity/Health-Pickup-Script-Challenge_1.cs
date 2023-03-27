using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public int hpValue = 1;
   
    public void OnTriggerEnter(Collider other)
    {
        // Debug.Log function below was a trouble shooting attempt idea from tutor to help me fix what wasn't working with health trigger pickup. Was successful.  
        Debug.Log("I love anime");
        if(other.tag == "Player")
        {
            IInventory inventory = other.GetComponent<IInventory>();

            if(inventory != null)
            {
                inventory.Health = inventory.Health + hpValue;
                print("Player inventory has " + inventory.Health + "HP in it.");
                gameObject.SetActive(false);
            }
        }
    }
}
