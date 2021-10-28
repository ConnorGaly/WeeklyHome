using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactManager : MonoBehaviour
{
    public Contact contactOne; //a reference to my contact 1
    public Contact contactTwo;
    public Contact contactThree;
    // Start is called before the first frame update
    void Start()
    {
    
        contactOne.Setup();
        contactTwo.Setup();
        contactThree.Setup();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
