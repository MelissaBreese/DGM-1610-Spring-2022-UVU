using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoxChangeColor : MonoBehaviour
{
    public Material newcolor;
    public MeshRenderer colorRenderer;
    // Start is called before the first frame update
    public void Start()
    {
        colorRenderer = GetComponent<MeshRenderer>();
    }   
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
            colorRenderer.material = newcolor;
    }
}
