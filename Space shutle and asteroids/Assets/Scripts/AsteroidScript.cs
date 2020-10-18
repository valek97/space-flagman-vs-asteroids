using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    public float speed = -2;
    private Rigidbody2D asteroids;
    // Start is called before the first frame update
    void Start()
    {
        asteroids = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        asteroids.velocity = new Vector2(0, 5f * speed);
        asteroids.angularVelocity = Random.Range(-200, 200);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject,3);
    }

    private void OnTriggerEnter2D( Collider2D collision)
    {
        var name = collision.name;
        if(name == "bullet(Clone)")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        if (name == "spaceship")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }

}
