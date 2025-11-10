using UnityEngine;

public class humanScript : MonoBehaviour
{
    public Vector3 targetPos;
    public float speed = 5f;
    private Transform target;
    public GameObject infected;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        transform.position = new Vector3(-15, 3, 0);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (transform.position == targetPos)
        {
            float x = Random.Range(-11f, 11f);
            float y = Random.Range(4.5f, -4.5f);
            targetPos = new Vector3(x, y, 0);
        }
    }
    public void SpawnInfected()
    {
        Instantiate(infected, this.transform.position, this.transform.rotation);
        Destroy(gameObject);
    }
}