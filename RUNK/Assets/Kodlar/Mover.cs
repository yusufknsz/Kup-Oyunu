using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour

{
    [SerializeField]float moveSpeed =12f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        
        
    }
    void PrintInstruction()
    {
        Debug.Log("Hoşgelgidiniz");
        Debug.Log("Karakterimizi W,A,S,D veya <-,->,^ Tuşlarıyla kontrol edebilirsiniz");
        Debug.Log("Duvarlara çarpma!!!");



    }
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime*moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime*moveSpeed;
        transform.Translate(xValue,0,zValue);


    }

}
