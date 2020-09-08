using UnityEngine;
using System.Collections;

public class DogMovement : MonoBehaviour
{
    public GameObject popUp;
    Vector3 velocity = Vector3.zero;
    public Vector3 gravity;
    public Vector3 flapVelocity;
    public float maxSpeed = 5f;
    public bool pular = false;

    bool didFlap = false;

    // Use this for initialization
    void Start()
    {

    }
    //Do graphic & input updates here
    void Update()
    {
        if (pular)
        {
            didFlap = true;
            pular = false;
        }
        if (maxSpeed > 5)
        {
            maxSpeed = 5;
        }
    }


    // Do physics engine updates here
    void FixedUpdate()
    {
        velocity += gravity * Time.deltaTime;

        if (didFlap == true)
        {
            didFlap = false;
            velocity += flapVelocity;
        }


        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);

        transform.position += velocity * Time.deltaTime;


    }

    void OnCollisionEnter2D(Collision2D colisor)
    {
        {
            if (colisor.gameObject.tag == "Inimigo")
            {
                popUp.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }
}
