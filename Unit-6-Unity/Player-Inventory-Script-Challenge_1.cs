using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour, IInventory
{
    public int Health { get => health; set => health = value; }

    public int health = 0; 
}