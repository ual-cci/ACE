
using System;
using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;
using UnityEngine.Events;

public class Delegate_example : MonoBehaviour
{
    
    //defining Delegates 
    //public delegate void OnButtonClickDelegate(); 
    //public static OnButtonClickDelegate buttonClickDelegate;
    
    //another way to do it is use an event, which is a bit safer in Unity
     public delegate void OnButtonClickDelegate();
     public static event OnButtonClickDelegate buttonClickDelegate;
    
    private Renderer colorChanger; 
    // Start is called before the first frame update
    void Start()
    
    {    
         buttonClickDelegate += myCustomMethod; 
         buttonClickDelegate += anotherMethod;
         colorChanger = gameObject.GetComponent<Renderer>(); 
  
        
    }

    public void myCustomMethod()
    {
        colorChanger.material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f)); 
    }

    public void anotherMethod()
    {
        transform.Translate(Vector3.down);
        return;
    }

    public void OnMouseUp()
    {
        buttonClickDelegate();
        return;
    }

    public void OnDisable()
    {
        buttonClickDelegate -= myCustomMethod; 
        buttonClickDelegate -= anotherMethod;
    }
}
