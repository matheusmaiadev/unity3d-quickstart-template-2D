using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneController : MonoBehaviour
{

    public void Play(){
        this.Phase(1);
    }

    
    public void Phase(int phaseNumber){
        if(phaseNumber == -1) Lose();
        else if(phaseNumber == -2) Win();
        else if(phaseNumber == -3) Menu();
        else SceneManager.LoadScene("Phase-" + phaseNumber);

    }

    public void Lose(){
        SceneManager.LoadScene("DefeatScene"); 

    }

    public void Win(){
        SceneManager.LoadScene("VictoryScene");

    }

    public void Menu(){
        SceneManager.LoadScene("MainMenuScene");

    }
    
    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    
}
