using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line : MonoBehaviour
{
    // Start is called before the first frame update
    LineRenderer line_render;
    void Start()
    {
        line_render = GetComponent<LineRenderer>();
    }
    void Update()
    {
        
    }
    //private void OnGUI()
    //{
    //    if (GUILayout.Button("SetPoint0"))
    //    {
    //        line_render.SetPosition(0, new Vector3(0, 1, 0));
    //    }
    //    if (GUILayout.Button("SetPoint1"))
    //    {
    //        line_render.SetPosition(1, new Vector3(0, 0, 0));
    //    }
    //}




}
