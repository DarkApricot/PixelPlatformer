using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private PlayerInteractions pi;
    void Start()
    {
        pi = FindObjectOfType<PlayerInteractions>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pi.doorOpen == true)
        {
            Destroy(gameObject);
        }
    }
}
