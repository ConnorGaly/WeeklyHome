using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTutorial : MonoBehaviour
{
    public string myName = "Connor"; //a string to hold my name
    public int myAge = 20; //an int to hold my age
    public bool myFirstBool = false; //a bool to hold my bool
    public int myAgeInMonths = 0; //an int to hold my age in months

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log logs out a string message that we can put inside of it
        //We can add multiple strings to add variables together to make one big string
        //Debugging is super useful for when we want to break down out code and check for bugs and where they are occuring.
        Debug.Log(myName);
        Debug.Log(myAge);
        Debug.Log(myFirstBool);
        Debug.Log(myAgeInMonths);
        Debug.Log(myName + " is this many years old: " + myAge);

        myAgeInMonths = myAge * 12;
        //This is an example of adding multiple strings and variables together to make a string to log out.
        Debug.Log("My age in months: " + myAgeInMonths);


        //this will pause the editor, allowing us to checkchecks during run time
        Debug.Break();

        //Logs out an error message, if the console has paused on an error, the inspector will pause
        Debug.LogError("There has been an Error :0");
        //Logs out a warning, will not pause the inspector, just shows a warning message
        Debug.LogWarning("This is just a warning");
    }

    // Update is called once per frame
    void Update()
    {
        myAgeInMonths = 23;
        //This log will be called every frame, and is an example of how to check variables later on in our code.
        Debug.Log("age in months is now: " + myAgeInMonths);
    }
}
