using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Loot
{
    public string Name;
    public int rarity;

    public Loot(string name, int rarity)
    {
        this.Name = name;
        this.rarity = rarity;
    }
}
