using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TaskTransmitter : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.Log("taskTransmitterOn");
        string texttosend = gameObject.GetComponentInChildren<TextMeshProUGUI>().text;
        NewspaperManager.newspaper.addHeadline(texttosend);
    }
}
