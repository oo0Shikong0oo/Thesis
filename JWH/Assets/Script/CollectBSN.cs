using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBSN : MonoBehaviour
{
    void OnMouseDown()
    {
        BasinScore.scoreValue += 1;
       Destroy(gameObject);
    }
}
