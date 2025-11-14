using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
public class InfectedScript : MonoBehaviour
{
    public Vector3 targetPos;
    public float speed = 5f;
    private Transform target;
    public GameObject human;
    private GameObject infected;
    int diceRoll;
    public GameObject immune;
    public GameObject dead;
    public GameObject txtobj;

    // Start is called once before the first execution of Update after the MonoBehaviour is created


    void Start()
    {
        StartCoroutine(Change());
    }

    // Update is called once per frame
    void Update()
    {

    }



    IEnumerator Change()

    {
        yield return new WaitForSeconds(5);

        diceRoll = Random.Range(0, 100);
        if (diceRoll <= 50 && gameObject.tag == "infected")
        {
            Instantiate(human, this.transform.position, this.transform.rotation);
            GetComponent<humanScript>().enabled = false;
            Destroy(gameObject);
        }

        else if (diceRoll <= 79 && gameObject.tag == "infected")
        {
            Instantiate(immune, this.transform.position, this.transform.rotation);
            GetComponent<ImmuneScript>().enabled = false;
            Destroy(gameObject);


        }

        else if (diceRoll >= 80 && gameObject.tag == "infected")
        {
            Instantiate(dead, this.transform.position, this.transform.rotation);
            GetComponent<DeadScript>().enabled = false;
            Destroy(gameObject);


        }


    }
     




    private void OnTriggerEnter2D(Collider2D Other)
    {


        if (Other.tag == "human")
        {


            Other.transform.GetComponent<humanScript>().Spawn();

            Debug.Log("Hit: " + Other);


        }



    }

    private void Awake()
    {
        txtobj = GameObject.Find("Infected Count");
        txtobj.GetComponent<infectedcouintScript>().infected++;
        txtobj.GetComponent<infectedcouintScript>().ChangeText();
    }

}
