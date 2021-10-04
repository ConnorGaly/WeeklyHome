using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionBasics : MonoBehaviour
{
    public string myFirstName = "Connor"; // A string to hold the users first name
    public string myLastName = "Galy"; //  a string to hold the users last name
    public int myAgeInYears = 20; // the users age in years
    public int myAgeInMonths = 0; // the users age in months
    public int myAgeInWeek = 0; // the users age in weeks

    //this function is called before start
    private void Awake()
    {
        PrintMyAge();
    }

    // Start is called before the first frame update
    void Start()
    {
        //an example of how to call a function
        PrintFullName();
    }

    // Update is called once per frame
    void Update()
    {
        //this will be called every frame
        PrintMyClassTime();
    }

    public void PrintFullName()
    {
        //the anatomy of a function is as follows
        //access type : public or private
        // the return type: Void = return nothing, just do instructions
        //then the function name, same naming scheme as a class. all capitals for first letter and every word.
        //finally our parantheses and curly braces with instructions inside(){}

        Debug.Log("My Name is: " + myFirstName + " " + myLastName);
        //functions can be called inside other functions
        PrintMyAge();
    }

    public void PrintMyAge()
    {
        //temportary variables in use
        Debug.Log(" Calls Print My Age");
        int monthsInAYear = 12;
        int weeksInAMonth = 4;
        int daysInAWeek = 7;
        int myAgeInDays = 0;
        //calculates the users age in years, months and weeks
        myAgeInMonths = myAgeInYears * monthsInAYear;
        myAgeInWeek = myAgeInMonths * weeksInAMonth;
        myAgeInDays = myAgeInWeek * daysInAWeek;
        //an example on how to use debugging effectively in a function
            Debug.Log("myAgeInWeek age in daysInAWeek is: " + myAgeInDays);
        //prints out the users age in years, months and days, weeks
        Debug.Log("My Age is: " + myAgeInYears + " years old, which is " + myAgeInMonths + " In Months. Which is " + myAgeInWeek + " in weeks, which is in: " + myAgeInDays);
        Debug.Log("Print my age is complete");
    }

    public void PrintMyClassTime()
    {
        Debug.Log("myAgeInWeek Class Time is on Fridays 9am.");
    }
}
