using UnityEngine;

public class ImmuneScript : MonoBehaviour
{
    public GameObject txtobj;
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
        if (Other.tag == "immune")
        {
            Other.transform.GetComponent<humanScript>().Spawn();
        }
    }
    void Awake()
    {
        txtobj = GameObject.Find("immune Count");
        txtobj.GetComponent<ImmuneCountScript>().Immune++;
        txtobj.GetComponent<ImmuneCountScript>().ChangeText();
    }
}
