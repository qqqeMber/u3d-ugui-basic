using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Toscene : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
    }

    public void OnClick()
    {
        SceneManager.LoadScene(0);//level1为我们要切换到的场景
    }

    // Update is called once per frame
    void Update()
    {

    }
}