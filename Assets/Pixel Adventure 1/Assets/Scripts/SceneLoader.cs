using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private PlayerInteractions player;
    private bool onlyOnce;
    private ConnectingPadlock padlock;
    private menu menu;
    void Start()
    {
        player = FindObjectOfType<PlayerInteractions>();
        padlock = FindObjectOfType<ConnectingPadlock>();
        menu = FindObjectOfType<menu>();
    }

    void Update()
    {
        if (player.level1To2 == true)
        {
            onlyOnce = true;
            if (onlyOnce == true)
            {
                onlyOnce = false;
                NewLevel();
                Invoke("Lvl2", 2f);
            }
        }

        if (player.level2To3 == true)
        {
            onlyOnce = true;
            if (onlyOnce == true)
            {
                onlyOnce = false;
                NewLevel();
                Invoke("Lvl3", 2f);
            }
        }

        if (player.level3To4 == true)
        {
            onlyOnce = true;
            if (onlyOnce == true)
            {
                onlyOnce = false;
                NewLevel();
                Invoke("Lvl4", 2f);
            }
        }

        if (player.level4To5 == true)
        {
            onlyOnce = true;
            if (onlyOnce == true)
            {
                onlyOnce = false;
                NewLevel();
                Invoke("Lvl5", 2f);
            }
        }

        //if (menu.endScreen == true)
        //{
        //    NewLevel();
        //    Invoke("Titlescreen", 2f);

        //}
    }

    private void NewLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
