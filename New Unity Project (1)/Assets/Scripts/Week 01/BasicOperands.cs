using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicOperands : MonoBehaviour
{
    public string myName = "Connor";
    public int myAgeInYears = 20;
    public int myAgeInMonths = 0;
    public int myAgeInWeeks = 0;
    public int myAgeInDays = 0;
    public int myBirthdayDay = 9;
    public int myBirthdayMonth = 8;
    public int myBirthdayYear = 2001;

    // Start is called before the first frame update
    void Start()
    {

        string myDebugMessage = "My name is: " + myName + "my birthday is:" + myBirthdayDay + "/" + myBirthdayMonth + "/" + myBirthdayYear;
        myDebugMessage = myDebugMessage + " my age in years is: " + myAgeInYears;

        myAgeInMonths = myAgeInYears * 12;
        Debug.Log("My age in months is: " + myAgeInMonths);
        myAgeInWeeks = myAgeInMonths * 4;
        myAgeInDays = myAgeInWeeks * 7;

        myDebugMessage += " My age in months: " + myAgeInMonths;
        myDebugMessage += " My age in Weeks is: " + myAgeInWeeks;
        myDebugMessage += " My age in days is: " + myAgeInDays;

        Debug.Log(myDebugMessage);

        Debug.Log("this is an example of Modulous, it divides a number evenly and returns the remainder" + myAgeInDays % 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
