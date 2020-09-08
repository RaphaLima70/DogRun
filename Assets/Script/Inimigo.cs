using UnityEngine;
using System.Collections;

public class Inimigo : MonoBehaviour {

    public float velocidade = 5;
    public int caseSwitch = 1;

	// Use this for initialization
	void Start () {

        Destroy(gameObject, 7f);

	}
	
	// Update is called once per frame
	void Update () {

        nivel();
        transform.Translate(Vector2.left * velocidade * Time.deltaTime);

    }

    public void nivel()
    {
        switch (caseSwitch)
        {
            case 1:
                velocidade = 6;
                break;
            case 2:
                velocidade = 7;
                break;
            case 3:
                velocidade = 8f;
                break;
            case 4:
                velocidade = 8f;
                break;
            case 5:
                velocidade = 9f;
                break;
            default:
                velocidade = 9f;
                break;
        }
    }
}
