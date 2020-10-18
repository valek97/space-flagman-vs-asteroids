using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipScript : MonoBehaviour
{
    private Rigidbody2D spaceShip;
    public float speed;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        spaceShip = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        spaceShip.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, Input.GetAxisRaw("Vertical") * speed);
        if (Input.GetKeyDown("space"))
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }
}
