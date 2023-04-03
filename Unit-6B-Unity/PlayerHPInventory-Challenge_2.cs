using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour, IInventory
{
    public int Health { get => health; set => health = value; }

    public int health = 0;
    public int HpHealthValue { get => hpHealthValue; set => hpHealthValue = value; }

    public int hpHealthValue = 0;
}