using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Escucha_Mode))]
public class FieldOfView_Editor : Editor
{
    private void OnSceneGUI()
    {
        Escucha_Mode FOW = (Escucha_Mode)target;
        Handles.color = Color.white;
        Handles.DrawWireArc(FOW.transform.position, Vector3.up, Vector3.forward, 360, FOW.view_Radius);
        
    }
}
