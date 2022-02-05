using UnityEngine;

public class Target : MonoBehaviour
{
    public int valueToAdd = 1;

    public GameObject explosionParticle;

    private float minSpeed = 12f;
    private float maxSpeed = 16f;
    private float maxTorque = 10f;
    private float xRange = 4f;
    private float ySpawnPos = -2f;

    private Rigidbody rb;
    private GameManager gameManager;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void Start()
    {
        rb.AddForce(RandomForce(), ForceMode.Impulse);
        rb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPos();
    }   
    private Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }
    private Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }
    private float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }
    private void OnMouseDown()
    {
        if (!GameManager.GameOver)
        {
            gameManager.UpdateScoreValue(valueToAdd);

            GameObject effect = (GameObject)Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);

            Destroy(effect, 2f);
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!gameObject.CompareTag("Bad"))
        {
            GameManager.GameOver = true;
        }

        Destroy(gameObject);
    }
}
