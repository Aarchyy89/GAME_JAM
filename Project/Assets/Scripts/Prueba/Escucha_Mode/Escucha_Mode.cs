using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldofView : MonoBehaviour
{
    public float view_Radius;
    [Range(0, 360)]
    public float view_angle;

    public Vector3 DirFromAngle(float angle, bool angleIsGlobal)    
    {
        if(!angleIsGlobal)
        {
            angle += transform.eulerAngles.y;
        }
        return new Vector3(Mathf.Sin(angle * Mathf.Deg2Rad), 0, Mathf.Cos(angle * Mathf.Deg2Rad));
    }


}
