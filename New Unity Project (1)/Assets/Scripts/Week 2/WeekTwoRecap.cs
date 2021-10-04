using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekTwoRecap : MonoBehaviour
{
    #region My Awesome Variables
    public int myInt; //An example of an Int
    /// <summary>
    /// The Users name as a string
    /// </summary>
    private string myName;
    public float myHeight = 2.0f; //This is an example of a float
    /*
     * A string to hold the users last name
     */
    private string myLastName = "Galy";
    public bool myBool = false;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        //This is an example of a temporary variable, it only exists within these parenthesis
        string myFavouriteGame = myName + "Fave Game Is" + "Deathloop";
        //These are examples of Debug.Log and debug log error, the log error will pause the editor if it is enabled in console
        Debug.Log("This is logging out: " + myName + " " + myLastName);
        Debug.LogError("Hey there's error here");
        Debug.Log(myFavouriteGame);
        /*
         * This is an example of random.range it returns a number between 0 - 19, if it is an int we are returning.
         * If it is a float, it is inclusive, meaning that the float will return a number between 0.0f and 10.0f/
         */
        myInt = Random.Range(0, 20);
        myHeight = Random.Range(0f, 10f);

    }

}
