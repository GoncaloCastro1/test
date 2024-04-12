using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float velocidade = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {

            rb.velocity = new Vector2(-velocidade, rb.velocity.y);

        }
        else if (Input.GetKey(KeyCode.D))
        {

            rb.velocity = new Vector2(velocidade, rb.velocity.y);
        } 
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, velocidade);
        }
    }
}

