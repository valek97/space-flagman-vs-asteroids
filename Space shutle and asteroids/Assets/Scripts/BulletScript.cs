using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 1;
    private Rigidbody2D bullet;
    // Start is called before the first frame update
    void Start()
    {
        bullet = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        bullet.velocity = new Vector2(0, 5f * speed);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
