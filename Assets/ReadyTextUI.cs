using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ReadyTextUI : SingletonMonoBehavior<ReadyTextUI>
{
    Text text;
    private void Start()
    {
        text = GetComponent<Text>();
        OnGameStartEntry();
    }

     void OnGameStartEntry()
    {
        Invoke("OnOne", 0);
        Invoke("OnTwo", 2);
        Invoke("OnThree", 4);
    }

    void OnOne()
    {
        text.text = "Are You Ready?";
    }
    void OnTwo()
    {
        text.text = "Set!";
    }
    void OnThree()
    {
        text.text = "Hold & Block!!";
    }
}
