using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenuOptions : MonoBehaviour {
    public void Resume()
    {
        PauseMenu.instance.GameState = false;
        PauseMenu.instance.pauseMenuUI.SetActive(false);
        PauseMenu.instance.button.SetActive(true);

    }
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void CharacterSelect()
    {
        SceneManager.LoadScene("CharacterSelect");
    }
}
