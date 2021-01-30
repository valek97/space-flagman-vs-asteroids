using UnityEngine;

public class SpaceshipScript : MonoBehaviour
{
    private Rigidbody2D spaceShip;
    public float speed;
    public GameObject bullet;
    public float fireRate = 0.1f;
    public float nextFire = 0;
    // Start is called before the first frame update
    void Start()
    {
        spaceShip = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        spaceShip.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, Input.GetAxisRaw("Vertical") * speed);
        if (( Time.time> nextFire) && Input.GetButton ("Fire1"))
        {
            nextFire = Time.time + fireRate;
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }
}
