using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyText : MonoBehaviour
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
        if (pi.keyPopup == true && padlock.deleteGlass == true && pi.grabKey == false)
        {
            pos.position = new Vector3(pos.position.x, pos.position.y, -0.8f);
        }
        else
        {
            pos.position = new Vector3(pos.position.x, pos.position.y, -80);
        }
    }
}
