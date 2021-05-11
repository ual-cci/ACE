using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehaviors : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Delegate_example.buttonClickDelegate += potato; 
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void potato()
    {
        Debug.Log("potato");
        transform.Translate(Vector3.down);
    }

    public void OnDisable()
    {
        Delegate_example.buttonClickDelegate -= potato; 
       
    }
}
