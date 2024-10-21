using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl5Button : MonoBehaviour
{
    private Animator animate;
    private PlayerInteractions button;
    public bool openMenu;

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
            openMenu = true;
        }

    }
}
