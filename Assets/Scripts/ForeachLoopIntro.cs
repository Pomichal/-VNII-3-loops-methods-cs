using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoopIntro : MonoBehaviour
{

    public string subject;

    // we can add values to the list inline
    public List<string> words = new List<string>{"great", "awesome", "nice", "perfect"};

    // Start is called before the first frame update
    void Start()
    {
        foreach(string word in words)
        {
            print(word);
        }
    }
}
