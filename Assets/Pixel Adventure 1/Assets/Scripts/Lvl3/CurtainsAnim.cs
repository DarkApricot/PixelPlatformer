using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurtainsAnim : MonoBehaviour
{
    private Animator animate;
    private PlayerInteractions pi;
    void Start()
    {
        animate = GetComponent<Animator>();
        pi = FindObjectOfType<PlayerInteractions>();
    }

    void Update()
    {
        if (pi.stairsAnim == true)
        {
            animate.SetTrigger("openCurtains");
        }

    }
}
