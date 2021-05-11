
using UnityEngine;
using System.Collections; 


public class Delegate_example : MonoBehaviour
{
    
    //defining Delegates 
    public delegate void OnButtonClickDelegate();
    public static OnButtonClickDelegate buttonClickDelegate;
    
    //another way to do it is use an event, which is a bit safer in Unity
    // public delegate Event OnButtonClickDelegate();
    // public static event OnButtonClickDelegate buttonClickDelegate;
    //
    private Renderer colorChanger; 
    // Start is called before the first frame update
    void Start()
    
    {    buttonClickDelegate += myCustomMethod; 
         buttonClickDelegate += anotherMethod;
         colorChanger = gameObject.GetComponent<Renderer>(); 
         
         //second way
         //Delegatehandler.buttonClickDelegate += myCustomMethod; 
         //Delegatehandler.buttonClickDelegate += anotherMethod;
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp()
    {
        buttonClickDelegate();
    }

    public void myCustomMethod()
    {
        Debug.Log("I ran!");
        transform.Translate(Vector3.up);
    }
    

    public void anotherMethod()
    {
        colorChanger.material.color =
            new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }
}
