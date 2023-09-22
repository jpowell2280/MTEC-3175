using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Clickscript : MonoBehaviour
{
    public TextMeshProUGUI clickText;
    private int clickCount = 0; //Start click value at 0.

    public Image clickImage; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        clickText.text = "Clicks: " + clickCount; //Updates the click text to show the current count. 
        
    }

    public void Click(bool status)
    {
        if (status)
        {
            clickCount++; //Increments click by 1 every time the code is ran.
            clickImage.color = Color.red; //Changes image color to red when clicked.
        }
        else
        {
            Reset();
            clickImage.color = Color.white; //Changes image color to green.
        }
    }

    public void Reset()
    {
        clickImage.color = Color.white; //Reverts color back to white.
    }
}
