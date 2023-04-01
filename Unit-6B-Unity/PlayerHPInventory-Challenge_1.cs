using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHPInventory : MonoBehaviour, IInventoryHP
{
    public int HpValue { get => HpValue; set => HpValue = value; }

    public int health = 0;
}
