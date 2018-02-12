using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {
    public static PauseMenu instance;
    public  bool GameState = false;
    public GameObject pauseMenuUI;
    public GameObject button;
    void Start()
    {
        instance = this;
    }
    // Update is called once per frame
    /*void Update () {
        if (GameState)
        {
            Resume();
        }
        else
        {
            Pause();
        }
	}*/
    public void Pause (){

        pauseMenuUI.SetActive(true);
        GameState = true;
        button.SetActive(false);
    }
}
