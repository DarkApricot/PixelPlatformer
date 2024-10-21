using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurtainsText : MonoBehaviour
{
    private PlayerInteractions pi;
    private Transform pos;

    void Start()
    {
        pi = FindObjectOfType<PlayerInteractions>();   
        pos = GetComponent<Transform>();
    }

    void Update()
    {
        if (pi.curtainsPopup == true)
        {
            pos.position = new Vector3(pos.position.x, pos.position.y, 30);
        }
        else
        {
            pos.position = new Vector3(pos.position.x, pos.position.y, -50);

        }

    }
}
