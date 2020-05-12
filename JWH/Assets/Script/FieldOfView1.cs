using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FieldOfView1 : MonoBehaviour
{
    public float viewRadius;
    public float viewAngle;

    public Vector3 DirFromAngle(float angleInDegrees, bool v)
    {
        return new Vector3(Mathf.Sin(angleInDegrees * Mathf.Deg2Rad), 0, Mathf.Cos(angleInDegrees * Mathf.Deg2Rad));
    }
}
