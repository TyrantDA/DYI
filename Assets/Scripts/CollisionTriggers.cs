using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class CollisionTriggers : MonoBehaviour
{

    // public TrackedStates state;

    

    public GameObject hammer;
    public GameObject Generator;
    public GameObject light;
    public GameObject Wheel;
    public GameObject WheelSpawn;
    public GameObject Spark;
    public GameObject Car;

    public AudioSource pickupSound;
    public AudioSource doorOpen;
    public AudioSource electric;

    public HealthDamage Health;
    public Inventory Invent; 

    private Vector3 pos = new Vector3(-16.817f, 0.361f, 19.763f);

    // Start is called before the first frame update
    void Start()
    {
       
    }


   public bool IsCarFix()
    {
        if(Invent.StateCheck(TrackedStates.WheelOn) && Invent.StateCheck(TrackedStates.SparkOn))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hammer"))
        {
            Invent.UpdateInventory(TrackedStates.HasHammer, true);
            Destroy(hammer);
            pickupSound.Play();
        }

        if (collision.gameObject.CompareTag("Wheel"))
        {
            Invent.UpdateInventory(TrackedStates.HasWheel, true);
            Destroy(Wheel);
            pickupSound.Play();
        }

        if (collision.gameObject.CompareTag("SparkPlug"))
        {
            Invent.UpdateInventory(TrackedStates.HasSpark, true);
            Destroy(Spark);
            pickupSound.Play();
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Generator"))
        {
            if (Invent.StateCheck(TrackedStates.HasHammer))
            {
                Debug.Log("Lights");
                light.GetComponent<Light>().enabled = true;
                Invent.UpdateInventory(TrackedStates.HasHammer, false);
                Invent.UpdateInventory(TrackedStates.GeneratorActivated, true);
                doorOpen.Play();

            }
        }

        if (collision.gameObject.CompareTag("Car"))
        {
            if (Invent.StateCheck(TrackedStates.HasWheel))
            {
                Debug.Log("wheel");
                Invent.UpdateInventory(TrackedStates.HasWheel, false);
                Invent.UpdateInventory(TrackedStates.WheelOn, true);
                GameObject child = Instantiate(WheelSpawn, pos, Quaternion.Euler(new Vector3(90f,0f,0f)));
                child.transform.parent = Car.transform;
            }

            if(Invent.StateCheck(TrackedStates.HasSpark))
            {
                Invent.UpdateInventory(TrackedStates.HasSpark, false);
                Invent.UpdateInventory(TrackedStates.SparkOn, true);
            }
        }
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("Water"))
        {
            if (Invent.StateCheck(TrackedStates.GeneratorActivated))
            {
                Health.WaterDamage();
                electric.Play();
            }
            else
            {
                electric.Stop();
            }
        }
    }
}
