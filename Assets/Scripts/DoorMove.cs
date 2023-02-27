using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMove : MonoBehaviour
{
    [SerializeField] private CollisionTriggers player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.Invent.StateCheck(TrackedStates.GeneratorActivated) && transform.position.y > -2)
        {
            transform.position -= new Vector3(0f, 0.003f, 0f);
        }
    }
}
