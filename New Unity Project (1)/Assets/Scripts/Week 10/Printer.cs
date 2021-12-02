using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Printer : MonoBehaviour
{
    public delegate void StringDelegate(string message);

    public static StringDelegate printEvent;

    private void OnEnable()
    {
        printEvent += PrintMessage;
    }

    private void OnDisable()
    {
        printEvent -= PrintMessage;
    }

    private void PrintMessage(string someMessage)
    {
        Debug.Log(someMessage);
    }
}
