using UnityEngine;
using System.Collections;

public class ScriptMenu : MonoBehaviour {

    public GameObject painel;
    public string Cena_game;
    public string menuPrincipal;

    void Start()
    {

    }

    public void retornar()
    {
        Time.timeScale = 1f;
        painel.SetActive(false);
    }

    public void recomeçar()
    {
        Application.LoadLevel(Cena_game);
        Time.timeScale = 1f;
    }
    public void menu()
    {
        Application.LoadLevel(menuPrincipal);
        Time.timeScale = 1f;
    }
}
