using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPPickup : MonoBehaviour
{
    public int HpValue = 5;

    public void OnTriggerEnter(Collider other)
    {
        // Debug.Log function below was a trouble shooting attempt idea from tutor to help me fix what wasn't working with health trigger pickup. Was successful.  
        Debug.Log("I love anime");
        if (other.tag == "Player")
        {
            IInventoryHP inventory = other.GetComponent<IInventoryHP>();

            if (inventory != null)
            {
                inventory.HpValue = inventory.HpValue + HpValue;
                print("Player inventory has " + inventory.HpValue + "HP in it.");
                gameObject.SetActive(false);
            }
        }
    }
}
