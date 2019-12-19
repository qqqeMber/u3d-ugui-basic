using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hellounity3d : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnGUI()
    {
        GUI.skin.label.fontSize = 50;
        GUI.Label(new Rect(10, 10, Screen.width, Screen.height), "hello unity3d");

    }
}
