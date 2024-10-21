using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaddersLvl1 : MonoBehaviour
{
    private PlayerInteractions button;
    private Transform pos;

    private void Start()
    {
        button = FindObjectOfType<PlayerInteractions>();
        pos = GetComponent<Transform>();
    }

    private void Update()
    {
        if (button.summonStairs == true)
        {
            gameObject.layer = 6;
            pos.position = new Vector3(pos.position.x, pos.position.y, 5);
        }
        else
        {
            pos.position = new Vector3(pos.position.x, pos.position.y, -40);
        }
    }
}
