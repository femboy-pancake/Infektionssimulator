using TMPro;
using UnityEngine;

public class HumanCouintScript : MonoBehaviour
{

    public TMP_Text scoreText;

    public int humancount = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.GetComponent<TMP_Text>().text = " human: " + humancount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void ChangeText()
    {
        this.GetComponent<TMP_Text>().text = " human: " + humancount.ToString();

    }
}
