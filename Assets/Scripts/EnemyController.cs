using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private PlayerController player;
    private bool isCollided = false; //Fix double collider event bug

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(!isCollided){
            this.isCollided = true;
            this.player.Damage();
            Destroy(gameObject);
        }

    }

}
