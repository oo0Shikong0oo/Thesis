using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NewsMNG02 : MonoBehaviour
{
    public Button[] taskButtons;
    public static NewsMNG02 newspaper;
    int numberActivated = 0;
    // Start is called before the first frame update
    void Start()
    {
        newspaper = this;
    }

    public void addHeadline(string HeadlineText)
    {
        if (numberActivated < taskButtons.Length)
        {
            taskButtons[numberActivated].GetComponentInChildren<Text>().text = HeadlineText;
            numberActivated++;
        }



    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
