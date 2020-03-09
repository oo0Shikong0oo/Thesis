using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint_001 : MonoBehaviour
{
    public GameObject uiObject;
    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider player)
    {
        
       if (player.gameObject.tag == "Player")
        {   Debug.Log("colliding");
            uiObject.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(10);
        uiObject.SetActive(false);
        //Destroy(uiObject);
        //Destroy(gameObject);
    }
}
