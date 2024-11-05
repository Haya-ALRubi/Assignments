using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player playerOne = new Player();
        Player playerTwo = new Player();
        playerOne.InitializePlayer("Haya",80);
        playerTwo.InitializePlayer("Ahmed",50);
        playerOne.Heal(20);
        playerTwo.Heal(30);
        playerOne.Heal(true);
        playerTwo.Heal(false);
        Player.ShowPlayerCount();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
