using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    [SerializeField] private GameObject canvas1;
    [SerializeField] private GameObject canvas2;
    public bool endScreen;

    private lvl5Button button;
    public void OnClickYes1()
    {
        canvas2.SetActive(true);
        button = FindObjectOfType<lvl5Button>();
    }
    private void Start()
    {
        canvas1.SetActive(false);
        canvas2.SetActive(false);
    }
    private void Update()
    {
        if (button.openMenu == true)
        {
            canvas1.SetActive(true);
        }

    }

    public void OnClickYes2()
    {
        endScreen = true;
    }

    public void OnClickNo1()
    {
        canvas1.SetActive(false);
    }

    public void OnClickNo2()
    {
        canvas2.SetActive(false);
        canvas1.SetActive(true);
    }
}

