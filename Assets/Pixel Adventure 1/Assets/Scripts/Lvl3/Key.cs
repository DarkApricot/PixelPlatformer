using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private PlayerInteractions pi;
    [SerializeField] private Transform player;
    private float offsetKey;
    [SerializeField] private float offsetLeft;
    [SerializeField] private float offsetRight;
    [SerializeField] private float offsetHeight;

    void Start()
    {
        pi = FindObjectOfType<PlayerInteractions>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            offsetKey = offsetRight;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            offsetKey = offsetLeft;
        }

        if (pi.grabKey == true)
        {
            transform.position = new Vector3(player.position.x + offsetKey, player.position.y + offsetHeight, player.position.z);
        }

        if (pi.doorOpen == true)
        {
            Destroy(gameObject);
        }
    }
}
