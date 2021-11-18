using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   private void OnTriggerEnter(Collider other)
    {
       // GameObject.transform.position(1, 1, 1)
        Debug.Log(other.name);//Calls the name of the object once collided with
        other.transform.position = new Vector3(0, 10, 0);//teleports the sphere once collided
        other.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0); //makes the speed not levels of flash
    }
}
