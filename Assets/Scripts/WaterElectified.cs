using UnityEngine;

public class WaterElectified : MonoBehaviour
{
    public GameObject electrified;

    public GameObject triggers;
    private bool on;
    private bool hasSpawned;

    // Start is called before the first frame update
    void Start()
    {
        on = false;
        hasSpawned = false;
    }

    // Update is called once per frame
    void Update()
    {
        on = triggers.GetComponent<CollisionTriggers>().Invent.StateCheck(TrackedStates.GeneratorActivated);
       


        if(on && !hasSpawned)
        {
            Debug.Log(transform.position.x + " : " + transform.position.y + " : " + transform.position.z);

            Vector3 hold = new Vector3(transform.position.x - 0.826f, 0.558f, transform.position.z + 0.334f);
            Instantiate(electrified, hold, transform.rotation);

            hold = new Vector3(transform.position.x - 0.196f, 0.558f, transform.position.z + 0.009f);
            Instantiate(electrified, hold, transform.rotation);

            hold = new Vector3(transform.position.x + 0.464f, 0.558f, transform.position.z + 0.334f);
            Instantiate(electrified, hold, transform.rotation);
            hasSpawned = true;
        }
    }
}
