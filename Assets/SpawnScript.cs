using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject prefab;
    void Start()
    {
        for (var i = 0; i < 50; i++)
        {
            Instantiate(prefab, new Vector3(i * 2.0f, 0, 0), Quaternion.identity);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.tag == "infected")
        {


            //Other.transform.GetComponent<playerScript>().GiveShield();

            Debug.Log("Hit: " + Other);

            {
                float x = Random.Range(-11f, 11f);
                float y = Random.Range(4.5f, -4.5f);
            }


        }
    }
}
