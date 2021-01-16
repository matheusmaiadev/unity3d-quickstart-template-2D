using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    private int health = 5;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }

    // Setters
    public void Damage(){
        if (this.health > 0) this.health -= 1;
    }

    public void Heal(){
        if (this.health < 3) this.health += 1;
    }

    //  Getters
    public int getHealth(){
        return this.health;
    }
}
