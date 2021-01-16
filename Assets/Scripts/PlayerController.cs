using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    private int health;
    public int maxhealth = 5;

    void Start() { 
        this.health = this.maxhealth;
    }

    // Setters
    public void Damage(){
        if (this.health > 1) this.health -= 1; // Player can't die.
    }

    public void Heal(){
        if (this.health < maxhealth) this.health += 1;
    }

    //  Getters
    public int getHealth(){
        return this.health;
    }
}
