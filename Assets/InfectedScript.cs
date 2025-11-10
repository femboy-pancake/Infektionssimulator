using Unity.VisualScripting;
using UnityEngine;

public class InfectedScript : MonoBehaviour
{
    public Vector3 targetPos;
    public float speed = 5f;
    private Transform target;
    public GameObject human;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    
    
    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.tag == "human")
        {


            Other.transform.GetComponent<human>().TakeDamage();

            Debug.Log("Hit: " + Other);

            Destroy(Other.gameObject);
            Other.transform.position, Other.transform.rotation);
            Other.IsDestroyed(gameObject);

            Instantiate(infected, this.transform.position, this.transform.rotation);
        }
    }
}
