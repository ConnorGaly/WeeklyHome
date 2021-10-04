using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekTwoIfElseStatements : MonoBehaviour
{
    public string myName = "Connor"; // a string to hold a reference too users name
    public string myCarColour = "Black"; //holds a reference to users car colour
    public bool likesCoffee = true; //holds a reference to if the user likes coffee
    public int myAge = 20; //holds the users age

    // Start is called before the first frame update
    void Start()
    {
        //checks to see if their name is Connor
        //otherwise they are not Connor
        if(myName == "Connor")
        {
            Debug.Log("You are Connor");
        }
        else
        {
            Debug.Log("You are not Connor");
        }

        //Checks to see if their age is less than 20 and greater than 5
        //otherwise their age does not fall between these.
        if(myAge < 20 && myAge > 5)
        {

        }
        else
        {
            Debug.Log("your age does not fall between 20 and 5");
        }
        //checks to see if their age is greater than 5.
        if(myAge > 5)
        {
            Debug.Log("age is greater than 5");
        }
        //checks to see if their age is less than 20
        if(myAge <20)
        {
            Debug.Log("Age is less than 20");
        }
        //an example of a nested If, Else, If statements
        //If my name is not Connor, or my car colour is Black
        //
        if (myName != "Connor" || myCarColour == "Black") ;
        {
            //do this
            Debug.Log("Not Connor or car colour is black");
            // if the user likes coffee, than log that out.
            if(likesCoffee == false)
            {
                Debug.Log("Does not Like Coffee");
            }
            else
            {
                //Otherwise log out they dont like coffee
                Debug.Log("does like coffee");
                //then check their age to see if they are older than 20
                //otherwise they must be younger
                if(myAge > 20)
                {
                    Debug.Log("Your older than Connor :0");
                }
                else
                {
                    Debug.Log("Your younger than Connor");
                }
            }
        }
    }
}
