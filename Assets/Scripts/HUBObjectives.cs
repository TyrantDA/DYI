using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUBObjectives : MonoBehaviour
{
    public Inventory invent;
    public Text text;
    private string Generator, Car;
    // Start is called before the first frame update
    void Start()
    {
        Generator = " ";
        Car = " ";
    }

    // Update is called once per frame
    void Update()
    {
        if(!invent.StateCheck(TrackedStates.GeneratorActivated))
        {
            Generator = "Fix Generator \n";
        }
        else
        {
            Generator = " ";
        }

        if(!invent.StateCheck(TrackedStates.SparkOn) || !invent.StateCheck(TrackedStates.WheelOn))
        {
            Car = "Fix Car \n";
        }
        else
        {
            Car = " ";
        }

        text.text = "Objectives : \n" + Generator + Car;
    }
}
