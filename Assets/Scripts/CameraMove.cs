using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject player;
    private Vector3 cameraPos;
    private Vector3 playerPos;

    [SerializeField] private float changePositionZ;
    [SerializeField] private float changePositionX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraPos = transform.position;
        playerPos = player.transform.position;

        float distanceX = 0;
        float distanceZ = 0;

   
            distanceX = cameraPos.x - playerPos.x;
            distanceZ = cameraPos.z - playerPos.z;
        

        if(distanceX > changePositionX)
        {
            transform.position = new Vector3(playerPos.x, transform.position.y, playerPos.z);
        }
        else if(distanceX < -changePositionX)
        {
            transform.position = new Vector3(playerPos.x, transform.position.y, playerPos.z);
        }


        if (distanceZ > changePositionZ)
        {
            transform.position = new Vector3(playerPos.x, transform.position.y, playerPos.z);
        }
        else if (distanceZ < -changePositionZ)
        {
            transform.position = new Vector3(playerPos.x, transform.position.y, playerPos.z);
        }
    }
}
