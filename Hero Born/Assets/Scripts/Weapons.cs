using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]

public struct Weapon
{
    // 7th edition book doesn't create Weapon script earlier in the book
}

public class WeaponShop
{
    public List<Weapon> inventory;
}