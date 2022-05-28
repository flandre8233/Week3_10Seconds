using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ready : SingletonMonoBehavior<Ready>
{
    [SerializeField]
    GameObject Game;

    public void OnGameStartEntry()
    {
        PlayerRegistrar.instance.enabled = false;
        InGamePlayerKeyCode.instance.UpdatePlayerKeyCode();
        ReadyUI.instance.ToTimerCanvas();
        Invoke("OnGameStart", 6);
    }
    public void OnGameStart()
    {
        InGameStatus.instance.ToGameStatus();
    }

}
