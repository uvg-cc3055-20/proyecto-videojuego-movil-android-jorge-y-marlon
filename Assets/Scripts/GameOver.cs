using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour {
    public static GameOver instance;
    public GameObject gameOverPanel;
    private void Start()
    {
        instance = this;
    }

    public void CharacterSelect()
    {
        SceneManager.LoadScene("CharacterSelect");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
