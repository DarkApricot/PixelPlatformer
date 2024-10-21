using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float timeRemaining = 4;

    [SerializeField] private Transform player;
    private Transform pos;
    [SerializeField] private PlayerInteractions pi;
    private ConnectingPadlock padlock;
    [SerializeField] private Eye eye;

    private float lvl5timer;
    private float camSize;
    void Start()
    {
        pos = GetComponent<Transform>();
        pi = FindObjectOfType<PlayerInteractions>();
        padlock = FindObjectOfType<ConnectingPadlock>();
        eye = FindObjectOfType<Eye>();
    }
    void Update()
    {
        if (pi.floor == 0)
        {
            if (pi.wallTouched == false)
            {
                transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
            }
            else
            {
                transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
            }

        }
        else if (pi.floor == 1)
        {
            transform.position = new Vector3(5.36f, player.position.y, transform.position.z);
        }
        else if (pi.floor == 2)
        {
            transform.position = new Vector3(-1.57f, player.position.y, transform.position.z);
        }

        if (pi.stairsAnim == true)
        {
            timeRemaining -= Time.deltaTime;
            if (timeRemaining >= 0)
            {
                transform.position = new Vector3(-16.9f, 20.7f, -9);
            }
            else if (timeRemaining <= 0)
            {
                transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
                pi.floor = 2;
            }
        }

        if (pi.openGlass == true)
        {
                transform.position = new Vector3(32.58f, 17.5f, -9);
        }
        if (padlock.deleteGlass == true)
        {
            transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
        }

        //if (pi.level4To5 || eye.startLVL5 == true)
        //{
        //    lvl5timer += Time.deltaTime;
        //    if (lvl5timer == 2 && camSize < 6)
        //    {
        //        camSize += Time.deltaTime;
        //    }
        //    Camera.main.orthographicSize = camSize;
        //}
    }

}
