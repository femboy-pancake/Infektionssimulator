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
        txtobj = GameObject.Find("Dead Count");
        txtobj.GetComponent<DeadCouintScript>().Deadcount++;
        txtobj.GetComponent<DeadCouintScript>().ChangeText();
    }
}
