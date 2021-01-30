using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    public float speed = -1;
    public GameObject Score;
    private Rigidbody2D asteroids;
    // Start is called before the first frame update
    void Start()
    {
        Score = GameObject.Find("Main Camera");
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
            //Дописать передачу счета
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Score.GetComponent<Score>().score += 5;
            // Score.GetComponent<Score>().ScorePoints(15);
            // Score.GetComponent<Score>().score += 15;
        }
        if (name == "spaceship")
        {
            //Score.GetComponent<Score>().score += 10;
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }

}
