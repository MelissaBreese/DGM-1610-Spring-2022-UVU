using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPPickup : MonoBehaviour
{
    public int HpHealth = 5;

    public void OnTriggerEnter(Collider other)
    {
        // Debug.Log function below was a trouble shooting attempt idea from tutor to help me fix what wasn't working with health trigger pickup. Was successful.  
       
        if (other.CompareTag("Player"))
        {
            Debug.Log("I love anime");
            IInventory Inventory = other.GetComponent<IInventory>();

            if (Inventory != null)
            {
                Inventory.HpHealthValue = Inventory.HpHealthValue + HpHealth;
                print("Player inventory has " + Inventory.HpHealthValue + "HP in it.");
                gameObject.SetActive(false);
            }
        }
    }
}