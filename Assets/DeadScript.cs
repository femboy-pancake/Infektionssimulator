using System.Security.Cryptography;
using UnityEngine;

public class DeadScript : MonoBehaviour
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


    void Awake()
    {
        txtobj = GameObject.Find("immune Count");
        txtobj.GetComponent<ImmuneCountScript>().Immune++;
        txtobj.GetComponent<ImmuneCountScript>().ChangeText();
    }
}
