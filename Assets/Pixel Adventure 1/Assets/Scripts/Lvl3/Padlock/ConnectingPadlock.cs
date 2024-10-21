using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectingPadlock : MonoBehaviour
{
    [SerializeField] private Animator[] wheelAnimators;
    public bool deleteGlass;

    void Start()
    {
        deleteGlass = false;
    }

    void Update()
    {
        if (wheelAnimators[0].GetInteger("number") == 6 && wheelAnimators[1].GetInteger("number2") == 4 && wheelAnimators[2].GetInteger("number3") == 1 && wheelAnimators[3].GetInteger("number4") == 3)
        {
            Debug.Log("unlocked");
            deleteGlass = true;
        }

        if (Input.GetKey(KeyCode.B))
        {
            deleteGlass = true;
        }
    }
}
