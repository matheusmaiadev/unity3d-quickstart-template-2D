using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class HudController : MonoBehaviour
{
    private PlayerController playerController;
    private Text healthCount;
    private int health;
    private Canvas menuCanvas;

    // Start is called before the first frame update
    void Start()
    {
        this.playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        this.healthCount =  GameObject.Find("valueHealth").GetComponent<Text>();
        this.menuCanvas =  GameObject.Find("MenuCanvas").GetComponent<Canvas>();

    }

    void Update()
    {
       if (Input.GetKeyDown("escape")) this.menuCanvas.enabled = !this.menuCanvas.enabled;
    }

    // OnGUI is called for rendering and handling GUI events.
    void OnGUI()
    {
        this.health = playerController.getHealth();
        this.healthCount.text = string.Concat(Enumerable.Repeat("♥", this.health));
    }
}
