using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenStuck : MonoBehaviour
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
        if (pi.whenStuck == true)
        {
            pos.localPosition = new Vector3(pos.localPosition.x, pos.localPosition.y, 0);
        }
        else
        {
            pos.localPosition = new Vector3(pos.localPosition.x, pos.localPosition.y, -20);

        }
    }
}