using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoopIntro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        while(i < 10)
        {
            print(i);
            i++;
        }
    }
}
