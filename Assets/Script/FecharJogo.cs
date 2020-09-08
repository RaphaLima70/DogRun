using UnityEngine;
using System.Collections;

public class MenuPrincipal : MonoBehaviour {

    public string cenaGame;

    void Start()
    {

    }


    public void começar()
    {
        Application.LoadLevel(cenaGame);
        Time.timeScale = 1f;
    }
    public void Exit()
    {
        Application.Quit();
    }
}
