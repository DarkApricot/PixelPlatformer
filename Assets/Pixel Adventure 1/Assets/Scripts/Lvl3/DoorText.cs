using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorText : MonoBehaviour
{
    private PlayerInteractions pi;
    void Start()
    {
        pi = FindObjectOfType<PlayerInteractions>();
    }

    void Update()
    {
        if (pi.doorPopup == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -0.8f);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -80);
        }
    }
}
