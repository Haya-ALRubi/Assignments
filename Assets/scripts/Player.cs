using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
   public string playerName;
   public int health;
   public static int playerCount = 0;
   public void InitializePlayer(string name, int intialHealth)
   {
    playerName = name;
    health = intialHealth;
    playerCount ++;
   }
   public void Heal(int amount)
   {
    health += amount;
    Debug.Log(playerName+":Health= "+health);
   }
   public void Heal(bool fullRestore)
   {
    if(fullRestore){
        health = 100;
        
    }
   }
   public static void ShowPlayerCount()
   {
    Debug.Log("Number of players: "+playerCount);
   }
}
