using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekThreeChallenges : MonoBehaviour
{
    public string firstName = "Connor"; //variable of users first name
    public string lastName = "Galy";//variable of users last name

    // Start is called before the first frame update
    void Start()
    {
        FullName(firstName, lastName);
    }
    private void FullName(string FirstName, string LastName)
    {
        Debug.Log(FirstName + " " + LastName);

        PrintMyAge(20)

        Debug.Log(ReturnAreaOfTriangle(5, 4) + "m2");
    }

    private void PrintMyAge(int years)
    {
        int months = ReturnSumOf(years, 12);
        int weeks = ReturnSumOf(months, 4);
        int days = ReturnSumOf(weeks, 7);
        int hours = ReturnSumOf(days, 24);
        int mins = ReturnSumOf(hours, 60);
        int secs = ReturnSumOf(mins, 60);

        Debug.Log("My Age Conversion is: " + months + "m " + weeks + "w " + days + "d " + hours + "h " + mins + "m " + secs + " s");
    }

    private int ReturnSumOf(int a, int b)
    {
        return a * b;
    }


    private float ReturnAreaOfTriangle(float Base, float Height)
    {
        return (Base * 0.5f) * Height;
    }
}
