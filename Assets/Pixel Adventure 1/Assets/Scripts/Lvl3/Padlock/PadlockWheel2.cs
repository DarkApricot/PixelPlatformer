using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadlockWheel2 : MonoBehaviour
{
    private Animator animate;

    void Start()
    {
        animate = GetComponent<Animator>();
    }
    private void OnMouseDown()
    {
        animate.SetInteger("number2", animate.GetInteger("number2") + 1);
    }
    void Update()
    {
        if (animate.GetInteger("number2") == 10)
        {
            animate.SetInteger("number2", animate.GetInteger("number2") - 10);
        }
    }
}