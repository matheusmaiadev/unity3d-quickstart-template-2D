using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private PlayerController player;
    private bool isCollided = false; //Fix double collider event bug

      public float tempoIP;
  private Renderer mainRenderer;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        mainRenderer =  GameObject.Find("DamageScreen").GetComponent<SpriteRenderer>();

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(!isCollided){
            StartCoroutine(PiscarDano());
            this.isCollided = true;
            this.player.Damage();
        }

    }

    IEnumerator PiscarDano()
    {
        for (int i = 0; i < 4; i++)
        {
            mainRenderer.enabled = true;
            yield return new WaitForSeconds(0.2f);
            mainRenderer.enabled = false;
            yield return new WaitForSeconds(0.2f);
        }

        Destroy(gameObject);

        mainRenderer.enabled = false;
    }

}
