using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickActive : MonoBehaviour
{
    public Rigidbody rb;
     void OnMouseDown()
    {
        rb.useGravity = true;

    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
