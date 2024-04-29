using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dusme : MonoBehaviour
{
    [SerializeField] float BeklemeSuresi=5f;
    MeshRenderer renderer;
    Rigidbody rigidbody;


    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;        
    }

    void Update()
    {
        if(Time.time > BeklemeSuresi)
        {
            rigidbody.useGravity = true;
            renderer.enabled = true;
        }
        
    }
}
