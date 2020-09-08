using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{

    public int pontos = 0;
    public TextMesh Pontuacao;
    public TextMesh PontuacaoMax;
    public SpawnInimigos spawnLink1;
    public Inimigo spawnLink2;
    public Inimigo spawnLink2b;
    public Inimigo spawnLink2c;
    public ScrollingScript spawnLink3;
    public ScrollingScript spawnLink3b;

    void nivel()
    {
        if (pontos >= 0 && pontos < 3)
        {
            spawnLink1.caseSwitch = 1;
            spawnLink2.caseSwitch = 1;
            spawnLink2b.caseSwitch = 1;
            spawnLink2c.caseSwitch = 1;
            spawnLink3.caseSwitch = 1;
            spawnLink3b.caseSwitch = 1;
        }
        if (pontos >= 4 && pontos < 10)
        {
            spawnLink1.caseSwitch = 2;
            spawnLink2.caseSwitch = 2;
            spawnLink2b.caseSwitch = 2;
            spawnLink2c.caseSwitch = 2;
            spawnLink3.caseSwitch = 2;
            spawnLink3b.caseSwitch = 2;
        }
        if (pontos >= 11 && pontos < 25)
        {
            spawnLink1.caseSwitch = 3;
            spawnLink2.caseSwitch = 3;
            spawnLink2b.caseSwitch = 3;
            spawnLink2c.caseSwitch = 3;
            spawnLink3.caseSwitch = 3;
            spawnLink3b.caseSwitch = 3;
        }
        if (pontos >= 26 && pontos < 55)
        {
            spawnLink1.caseSwitch = 4;
            spawnLink2.caseSwitch = 4;
            spawnLink2b.caseSwitch = 4;
            spawnLink2c.caseSwitch = 4;
            spawnLink3.caseSwitch = 4;
            spawnLink3b.caseSwitch = 4;
        }
        if (pontos >= 56 && pontos < 120)
        {
            spawnLink1.caseSwitch = 5;
            spawnLink2.caseSwitch = 5;
            spawnLink2b.caseSwitch = 5;
            spawnLink2c.caseSwitch = 5;
            spawnLink3.caseSwitch = 5;
            spawnLink3b.caseSwitch = 5;
        }
        if (pontos >= 121 && pontos < 500)
        {
            spawnLink1.caseSwitch = 6;
            spawnLink2.caseSwitch = 6;
            spawnLink2b.caseSwitch = 6;
            spawnLink2c.caseSwitch = 6;
            spawnLink3.caseSwitch = 6;
            spawnLink3b.caseSwitch = 6;
        }
    }

    void Start()
    {

        PontuacaoMax.text = "Pontuação Max: " + PlayerPrefs.GetInt("HighScore");

    }

    void Update()
    {
        if (pontos > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", pontos);
        }
        PontuacaoMax.text = "HighScore: " + PlayerPrefs.GetInt("HighScore");
        if (Input.GetKeyDown(KeyCode.Home))
        {
            PlayerPrefs.SetInt("HighScore", 0);
        }
        Pontuacao.text = ("Score: " + pontos).ToString();

        nivel();

    }
   
}