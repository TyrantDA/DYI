using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimDemo : MonoBehaviour
{
    public Animator anim;

public void OnPressButton()
    {
        anim.SetTrigger("MoveTrigger");
    }


}
