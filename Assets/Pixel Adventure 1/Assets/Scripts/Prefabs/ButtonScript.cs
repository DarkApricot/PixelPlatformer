using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    private Animator animate;
    private PlayerInteractions button;

    void Start()
    {
        animate = GetComponent<Animator>();
        button = FindObjectOfType<PlayerInteractions>();

    }

    void Update()
    {
        if (button.isTouched == true)
        {
            animate.SetTrigger("isPressed");
        }

    }
}
