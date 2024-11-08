using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerr : Character
{

    public void Heal()
    {
        Health =+ 5;
        if (Health > 100)
        {
            Health = 100;
        }
        Debug.Log(CharacterName);
        Debug.Log(Health);
    }
}
