using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject Asteroids;
    public float spawnTime = 0.25f;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        
        InvokeRepeating("addAsteroid", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void addAsteroid()
    {
        var x1 = transform.position.x - rend.bounds.size.x/2;
        var x2 = transform.position.x + rend.bounds.size.x / 2;

        var spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);

        Instantiate(Asteroids, spawnPoint, Quaternion.identity);
    }
}
