using Unity.VisualScripting;
using UnityEngine;

public class InfectedScript : MonoBehaviour
{
    public Vector3 targetPos;
    public float speed = 5f;
    private Transform target;
    public GameObject human;
    private GameObject infected;
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


            Other.transform.GetComponent<humanScript>().SpawnInfected();

            Debug.Log("Hit: " + Other);

            
        }



        else if (Other.tag == "immune")


        {
            Other.transform.GetComponent<ImmuneScript>().SpawnInfected();

        }
    }
    

}
