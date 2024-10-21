using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eye : MonoBehaviour
{
    public bool startLVL5;

    private Animator animate;
    private PlayerMovement player;

    private float posXeye;
    private float posYeye;

    [SerializeField] private float width;
    [SerializeField] private float height;

    void Start()
    {
        animate = GetComponent<Animator>();
        player = FindObjectOfType<PlayerMovement>();

        posXeye = transform.position.x;
        posYeye = transform.position.y;

        width = transform.lossyScale.x;
        height = transform.lossyScale.y;
        startLVL5 = true;
    }

    void Update()
    {
         if (player.playerPosY - height > posYeye && player.playerPosX + width < posXeye)    //looks up left
        {
            animate.SetInteger("EyePos", 9);
        }
        else if (player.playerPosY + height < posYeye && player.playerPosX + width < posXeye)       //looks down left
        {
            animate.SetInteger("EyePos", 3);
        }
        else if (player.playerPosY - height > posYeye && player.playerPosX - width > posXeye)    //looks up right
        {
            animate.SetInteger("EyePos", 7);
        }
        else if (player.playerPosY + height < posYeye && player.playerPosX - width > posXeye)       //looks down right
        {
            animate.SetInteger("EyePos", 1);
        }
        else if (player.playerPosX + width < posXeye)    //looks left
        {
            animate.SetInteger("EyePos", 6);
        }
        else if (player.playerPosX - width > posXeye)       //looks right
        {
            animate.SetInteger("EyePos", 4);
        }
        else if (player.playerPosY + height < posYeye)    //looks up
        {
            animate.SetInteger("EyePos", 8);
        }
        else if (player.playerPosY - height > posYeye)       //looks down
        {
            animate.SetInteger("EyePos", 2);
        }
        else            //looks middle
        {
            animate.SetInteger("EyePos", 5);
        }

    }
}
