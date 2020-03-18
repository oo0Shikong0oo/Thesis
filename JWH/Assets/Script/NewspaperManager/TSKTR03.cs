using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TSKTR03 : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.Log("taskTransmitterOn_003");
        string texttosend = gameObject.GetComponentInChildren<TextMeshProUGUI>().text;
        NewsMNG02.newspaper.addHeadline(texttosend);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
