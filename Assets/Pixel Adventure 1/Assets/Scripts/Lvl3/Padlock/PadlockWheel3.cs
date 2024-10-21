using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadlockWheel3 : MonoBehaviour
{
    private Animator animate;

    void Start()
    {
        animate = GetComponent<Animator>();
    }
    private void OnMouseDown()
    {
        animate.SetInteger("number3", animate.GetInteger("number3") + 1);
    }
    void Update()
    {
        if (animate.GetInteger("number3") == 10)
        {
            animate.SetInteger("number3", animate.GetInteger("number3") - 10);
        }
    }
}