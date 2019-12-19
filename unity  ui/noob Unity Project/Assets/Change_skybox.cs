using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Change_skybox : MonoBehaviour
{

    public Material[] skybox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClick()
    {
        this.GetComponent<Skybox>().material = skybox[Random.Range(0, 5)];
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
