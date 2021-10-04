using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekTwoIfStatements : MonoBehaviour
{
    public string myName = "Connor"; //variable to hold my name
    public bool likesCoffee = false; //Does the user like coffee
    public int myFavouriteNumber = 76; //the users favourite number
    public float myFavouriteFloat = 5.5f; //the users favourite float

    // Start is called before the first frame update
    void Start()
    {
        //if anatomy of an if statement is:
        //if
        //a condition i.e. (value inside of likesCoffee is equal to true)
        //then do what is inside of the curly braes
        if(likesCoffee == false) ;
        {
            Debug.Log("Connor Does Not Like Coffee");
        }

        //an example of a false statement being true
        if (likesCoffee == true) ;
        {
            Debug.Log("Connor Likes Coffee");
        }
        //an example of a false statement being true
        if(myName == "Asriel")
        {
            Debug.Log("Your Name is Asriel");
        }
        //an example of a string condition being trye
        if (myName != "Asriel")
        {
            Debug.Log("Your Name is Connor");
            likesCoffee = false;
        }
        //an example of an int equalling exactly 7 being true
        if(myFavouriteNumber == 76)
        {
            Debug.Log("Is Exactly 76");
        }
        //an example of a number being less than or equal to 74
        if(myFavouriteNumber <= 74)
        {
            Debug.Log("Your Number is less than 74");
        }
        //an example of a float being greater than 74
        if(myFavouriteNumber > 74)
        {
            Debug.Log("Your number is greater than 74");
        }

        //Examples of multiple conditions
        if(myName == "Connor" && likesCoffee == true)
        {
            Debug.Log("Connor hates Coffee");
        }
        //an example of an && (and) cindition where if both conditions are true
        //then execute the code
        if(myName != "Connor" && likesCoffee == true)
        {
            Debug.Log("you are not Connor and you like Coffee");
        }
        //an example of || (or) condition where if one of the conditions are true
        //then the code is executed
        if(myFavouriteNumber < 4 || myFavouriteNumber > 6)
        {
            Debug.Log("my favourite number is less than 4 or my favourite number is greater than 6");
        }
        //an example of nesting multiple if statements with multple functions
        if(likesCoffee == false)
        {
            if(myName == "Connor")
            {
                Debug.Log("Connor hates coffee");
            }
            if(myName != "Connor")
            {
                Debug.Log("Not Connor");
                if(myFavouriteNumber >4 && myFavouriteNumber < 7)
                {
                    Debug.Log("and my favourite number is:" + myFavouriteNumber);
                }
            }
        }
    }

}
