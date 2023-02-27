using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListsIntro : MonoBehaviour
{

    public List<int> myList;

    // Start is called before the first frame update
    void Start()
    {
        myList = new List<int>();  // create an empty List of integers, overrides the list created in the editor

        myList.Add(4);
        myList.Add(7);

        myList.Insert(1, 14); // insert item 14 at the index 1 (second place)

        print("Item at index 1: " + myList[1]);


        myList.Remove(4); // removes the first occurence of item 4
        myList.RemoveAt(0); // removes the element at index 0 (the first item)


        print("Length of the list: " + myList.Count);


    }

}
