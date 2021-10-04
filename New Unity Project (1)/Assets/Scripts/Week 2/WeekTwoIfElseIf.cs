using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekTwoIfElseIf : MonoBehaviour
{
    public string myName = "Connor";//a refernece to the users name
    public string myCarColour = "Black";//a reference to the users car colour
    public bool likesCoffee = false;//does the user like coffee
    public int myAge = 20;// a reference to the users age
    // Start is called before the first frame update
    void Start()
    {
        //checks to see if the users likes coffee is false
        if(likesCoffee == false)
        {
            Debug.Log("Does Not Like Coffee");
        }
        //checks to see if my age is is greater than 5, otherwise it is not
        if(myAge > 5)
        {
            Debug.Log("my age is greater than 5");
        }
        else
        {
            Debug.Log("My age is less than 5");
        }
        //checks to see if my age is greater than 20, else it checks to see if it is less than 17
        if(myAge > 20)
        {
            Debug.Log("age is greater than 20");
        }
        else if(myAge < 17)
        {
            Debug.Log("my age is less than 17");
        }
        //if my car colour is white
        //else if it checks to see if it is yellow
        //otherwise checks to see if its purple
        if(myCarColour == "Black")
        {
            Debug.Log("car is black");
        }
        else if(myCarColour == "Yellow")
        {
            Debug.Log("My Car is Yellow");
                if(likesCoffee == true)
            {
                Debug.Log("Does like Coffee");
            }
        }
        else
        {
            if(myCarColour == "purple")
            {
                Debug.Log("Car colour is purple");
            }
            else
            {
                Debug.Log("Car is some other colour");
            }
            Debug.Log("Car is some other colour");
        }
    }

}
