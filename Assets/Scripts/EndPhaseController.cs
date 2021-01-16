using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPhaseController : MonoBehaviour
{
    private SceneController sceneController;
    private bool isCollided = false; //Fix double collider event bug
    public int numberPhase = 1;
    public static int totalPhase = 3;

    // Start is called before the first frame update
    void Start()
    {
        this.sceneController = GameObject.Find("SceneController").GetComponent<SceneController>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(!isCollided){
            this.isCollided = true;

            if(numberPhase <= totalPhase) {
                this.sceneController.Phase(numberPhase);
            } else {
                this.sceneController.Win();
            }
            
            Destroy(sceneController);
        }
    }
}
