using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour {

    public void PlayCuphead()
    {
        SceneManager.LoadScene("CupheadGame");
    }
    public void PlayAngel()
    {
        SceneManager.LoadScene("AngelGame");
    }
}
