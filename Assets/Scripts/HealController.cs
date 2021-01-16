using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealController : MonoBehaviour
{
    private PlayerController player;
    private bool isCollided = false; //Fix double collider event bug

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(!isCollided){
            this.isCollided = true;
            this.player.Heal();
            Destroy(gameObject);
        }
    }
}
