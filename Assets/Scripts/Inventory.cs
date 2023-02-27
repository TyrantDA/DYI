using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum TrackedStates
{
    HasHammer,
    GeneratorActivated,
    HasWheel,
    WheelOn,
    HasSpark,
    SparkOn
}

public class Inventory : MonoBehaviour
{
    private List<bool> currentStates = new List<bool>();
    // Start is called before the first frame update
    void Start()
    {
        int count = Enum.GetValues(typeof(TrackedStates)).Length;

        for (int i = 0; i < count; i++)
        {
            currentStates.Add(false);
        }
    }

    public void UpdateInventory(TrackedStates state, bool newValue)
    {
        currentStates[(int)state] = newValue;
    }

    public bool StateCheck(TrackedStates state)
    {
        return currentStates[(int)state];
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
