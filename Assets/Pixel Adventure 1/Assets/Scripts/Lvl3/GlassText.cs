using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassText : MonoBehaviour
{
    private PlayerInteractions pi;
    private Transform pos;
    private ConnectingPadlock padlock;

    void Start()
    {
        pi = FindObjectOfType<PlayerInteractions>();
        pos = GetComponent<Transform>();
        padlock = FindObjectOfType<ConnectingPadlock>();
    }

    void Update()
    {
        if (pi.glass == true && padlock.deleteGlass == false)
        {
            pos.position = new Vector3(pos.position.x, pos.position.y, 30);
        }
        else
        {
            pos.position = new Vector3(pos.position.x, pos.position.y, -50);
        }
    }
}
