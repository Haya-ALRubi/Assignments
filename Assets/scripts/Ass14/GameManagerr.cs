using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Playerr player = new Playerr();
        Enemy enemy = new Enemy();
        Debug.Log(player.Health);
        Debug.Log(player.Health);
        Debug.Log(enemy.Health);
        Debug.Log(enemy.Health);
        player.Heal();
        enemy.Attack(player, 10);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
