using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadlockWheel4 : MonoBehaviour
{
    private Animator animate;



    void Start()
    {
        animate = GetComponent<Animator>();
    }
    private void OnMouseDown()
    {
        animate.SetInteger("number4", animate.GetInteger("number4") + 1);


    }
    void Update()
    {
        if (animate.GetInteger("number4") == 10)
        {
            animate.SetInteger("number4", animate.GetInteger("number4") - 10);
        }
    }
}