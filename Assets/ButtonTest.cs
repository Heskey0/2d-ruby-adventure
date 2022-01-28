using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class ButtonTest : MonoBehaviour
{

    void Start()
    {
        Button btn = GameObject.Find("Button").GetComponent<Button>();
        btn.onClick.AddListener(()=>Debug.Log("aa"));
    }

    void Update()
    {
        
    }
}
