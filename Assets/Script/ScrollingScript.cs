using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
public class ScrollingScript : MonoBehaviour
{

    public Vector2 speed = new Vector2(5, 5);
    public Vector2 direcao = new Vector2(-1, 0);
    public float velocidade = 1;
    private bool isLooping = true;
    private List<Transform> backgroundPart;
    public int caseSwitch = 1;



    public void nivel()
    {
        switch (caseSwitch)
        {
            case 1:
                speed = new Vector2 (5,5);
                break;
            case 2:
                speed = new Vector2(6, 6);
                break;
            case 3:
                speed = new Vector2(7, 7);
                break;
            case 4:
                speed = new Vector2(8, 8);
                break;
            case 5:
                speed = new Vector2(9, 9);
                break;
            default:
                speed = new Vector2(9, 9);
                break;
        }
    }

    // Use this for initialization
    void Start()
    {

        if (isLooping)
        {
            backgroundPart = new List<Transform>();
            for (int i = 0; i < transform.childCount; i++)
            {
                Transform child = transform.GetChild(i);
                if (child.GetComponent<Renderer>() != null)
                {
                    backgroundPart.Add(child);
                }
            }

            backgroundPart = backgroundPart
                .OrderBy(t => t.position.x).ToList();

        }

    }

    // Update is called once per frame
    void Update()
    {
        nivel();
        Vector2 movimento = new Vector2(
            speed.x * direcao.x * velocidade,
            speed.y * direcao.y);

        movimento *= Time.deltaTime;

        transform.Translate(movimento);

        if (isLooping)
        {
            Transform firstChild = backgroundPart.FirstOrDefault();
            if (firstChild != null)
            {
                if (firstChild.position.x < Camera.main.transform.position.x)
                {
                    if (!firstChild.GetComponent<Renderer>().isVisibleFrom(Camera.main))
                    {
                        Transform lastChild = backgroundPart.LastOrDefault();
                        Vector3 lastPosition = lastChild.position;
                        Vector3 lastSize = (lastChild.GetComponent<Renderer>().bounds.max -
                                            lastChild.GetComponent<Renderer>().bounds.min);

                        firstChild.position = new Vector3(
                            lastPosition.x + lastSize.x,
                            firstChild.position.y,
                            firstChild.position.z);
                        backgroundPart.Remove(firstChild);
                        backgroundPart.Add(firstChild);
                    }
                }
            }
        }

    }
}
