using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListsAndArrays : MonoBehaviour
{
    //The basic anatomy is;
    //access tyoe
    //Data type followed by [] to say its an array
    //then variable name
    public int[] myFirstIntArray;//an array to hold out ints, an array is a collection of items
    //the basic anatomy of a list is:
    //access type
    //List<DataType>
    //variable name
    //then we have to intiialise it with an empty list using the new keyword to get a new instance for our list class
    public List<int> myFirstIntList = new List<int>();//a list to hold a collection of items

    // Start is called before the first frame update
    void Start()
    {
        //this is examples of accessing an element of an array
        //arrays and lists always start at element 0
        //The easiest way to remember which element to access is, what ever position you want, minus 1, i e, i want position 4, so i need element 3
        Debug.Log("The first number in my array is: " + myFirstIntArray[0]);
        Debug.Log("The first number in my array is: " + myFirstIntArray[1]);
        Debug.Log("The first number in my array is: " + myFirstIntArray[2]);

        //an example of adding an element to an array
        myFirstIntArray = new int[] { 5,4,2,7 };
        //an example of removing an element from an array
        myFirstIntArray = new int[] { 5, 2, 7 };
        //an example of getting the length of the array or how many items are in there
        Debug.Log(myFirstIntArray.Length);

        //example of accessing in a list, same behavioiur as an array
        Debug.Log(" The first number in my list is: " + myFirstIntList[0]);
        Debug.Log(" The first number in my list is: " + myFirstIntList[1]);
        Debug.Log(" The first number in my list is: " + myFirstIntList[2]);

        //an example of adding an element to a list
        myFirstIntList.Add(9);
        //an example of removing an element from a list
        myFirstIntList.Remove(5);
        //an example of using remove at, so removes the item from the element that i define i.e. element 2, or in this the case the last element of my list
        //list.count returns how long my list is, the -1 allows me to take into account that arrays and lists start at position 0
        myFirstIntList.RemoveAt(myFirstIntList.Count - 1);

        //this is an example of accessing a random element from an array or list
        //the key here is Random.Range for ints is exclusive, menaning that what ever number is the max will be minus 1
        //this is excellent for us, as arrays/lists start at position 0, so an array or list of 9 long, has 8 elements
        //so if we did a random range between 0 and 9 we can only get a number between 0 and 8.

        Debug.Log("Accessing a Random Element from my list " + myFirstIntList[Random.Range(0, myFirstIntList.Count)]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
