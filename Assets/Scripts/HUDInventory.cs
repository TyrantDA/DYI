using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDInventory : MonoBehaviour
{
    public Inventory invent;
    public Text text;
    private string hammer, wheel, spark;

    // Start is called before the first frame update
    void Start()
    {
        hammer = " ";
        wheel = " ";
        spark = " ";
    }

    // Update is called once per frame
    void Update()
    {
        if(invent.StateCheck(TrackedStates.HasHammer))
        {
            hammer = "hammer \n";
        }
        else
        {
            hammer = " ";
        }

        if(invent.StateCheck(TrackedStates.HasWheel))
        {
            wheel = "wheel \n";
        }
        else
        {
            wheel = " ";
        }
        
        if(invent.StateCheck(TrackedStates.HasSpark))
        {
            spark = "Spark Plug \n";
        }
        else
        {
            spark = " ";
        }

        text.text = "Inventory : \n" + hammer + wheel  + spark;
        
    }
}
