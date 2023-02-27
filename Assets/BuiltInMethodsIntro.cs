using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuiltInMethodsIntro : MonoBehaviour
{


    void Awake()
    {
        print("Awake");
    }

    // Start is called before the first frame update
    void Start()
    {
        print("Start");

    }

    // Update is called once per frame
    void Update()
    {
        print("Update, delta time: " + Time.deltaTime);
    }

    void FixedUpdate()
    {
        print("Fixed update, fixed delta time: " + Time.fixedDeltaTime);
    }
}
