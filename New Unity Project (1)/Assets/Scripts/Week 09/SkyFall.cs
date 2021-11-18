using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SkyFall : MonoBehaviour
{
    public UnityEvent dealDamageEvent = new UnityEvent();//creat my event

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.transform.name); //accessing the name of the transform
        
        collision.transform.position = collision.transform.position + new Vector3(0, 10, 0);
       if(dealDamageEvent != null)//checks to see if theres at least 1 function
        {
            dealDamageEvent.Invoke();//Call my event and loop  through the lists of functions
        }
       //dealDamageEvent?.Invoke(); this does the exact same as above
    }
}
