using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FixAss14
{
    public class GameManagerr : MonoBehaviour
    {
        void Start()
        {
            Playerr player = new Playerr("Sonic");
            Enemy enemy = new Enemy("BossEnemy");
            Debug.Log(player.CharacterName + " " + "has" + " " + player.Health + " " + "health.");
            Debug.Log(enemy.CharacterName + " " + "has" + " " + enemy.Health + " " + "health.");
            player.Heal();
            enemy.Attack(player, 10);

        }


    }
}