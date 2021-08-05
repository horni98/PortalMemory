using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaveMovement : MonoBehaviour
{
    public float lavaSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, lavaSpeed);



    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            lavaSpeed = 1f;

        }

    }

}