using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A script that demonstrates the correct set up and usage of variables inside of unity
/// </summary>
public class VariableEt : MonoBehaviour
{ 
    //the access type, the data type, variableName, default value i want to assign.
    public int myFirstInt = 1; //an int stores whole numbers
    private int m_mySecondInt = 4;
    public float myFirstFloat = 3.455f; //a float stores decimal numbers, and requires the f symbol to denote its a float when setting.
    public double myFirstDouble = 0.11f; //Essentially a float, but can go to 16 rather than 8 decimal places
    public bool myFirstBool = false; //a bool is used to store true or false
    public string myFirstString = "Connor is an idiot"; //A string holds words,uses the "" to denote these words are a string
    public char myFirstChar = 'C'; //A char holds a single character, nothing else, uses the '' to denote that it is a char

    // Start is called before the first frame update
    void Start()
    {
        myFirstString = "Connor is not an idiot"; // sets my first string to Nathan is not awesome 
        myFirstInt = 5; //sets my first in to 5

        //doing something else
    }
}
