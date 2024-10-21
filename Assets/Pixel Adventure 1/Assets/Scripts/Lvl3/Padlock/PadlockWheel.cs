using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadlockWheel : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnMouseDown()
    {
        anim.SetInteger("number", anim.GetInteger("number") + 1);

    }
    void Update()
    {
        if (anim.GetInteger("number") == 10)
        {
            anim.SetInteger("number", anim.GetInteger("number") - 10);
        }
    }
}