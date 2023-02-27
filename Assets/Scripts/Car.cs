using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    //[SerializeField] private float speed;
    //[SerializeField] private float force;
    private Vector3 movement;
    private Rigidbody rb;
    private bool col;

    public GameObject[] BreakableWalls;
    private Animator anim;

    public AudioSource carEngine;
    public AudioSource crash;

    public CollisionTriggers ColTr;
    // Start is called before the first frame update
    void Start()
    {
        //movement = new Vector3(force, 0f, 0f);
        //rb = GetComponent<Rigidbody>();
        //col = false;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (ColTr.IsCarFix() && !col)
        //{
        //    Debug.Log("go");
        //    rb.AddForce(movement * speed);
        //}
    }

    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.CompareTag("Wall"))
        //{
        //    col = true;
        //}
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("BreakableWall"))
        {
            Debug.Log("collide");
            Destroy(BreakableWalls[0]);
            Destroy(BreakableWalls[1]);
            Destroy(BreakableWalls[2]);
            crash.Play();
        }
        if(collision.CompareTag("Wall"))
        {
            carEngine.Stop();
        }
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (ColTr.IsCarFix() && !col)
            {
                anim.SetTrigger("MoveTrigger");
                carEngine.Play();
            }
        }
    }
}
