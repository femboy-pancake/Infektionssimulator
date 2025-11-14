using UnityEngine;
using TMPro;

public class infectedcouintScript : MonoBehaviour
{
    public TMP_Text scoreText;

    public int infected = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.GetComponent<TMP_Text>().text = " infected: " + infected.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChangeText()
    {
        this.GetComponent<TMP_Text>().text = " infected: " + infected.ToString();
    }
        


    
}
