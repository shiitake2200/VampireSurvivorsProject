using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExp : MonoBehaviour
{
    public int Exp = 0;

    public void ExpUp(int amount)
    {
        Exp += amount;
    }
}
