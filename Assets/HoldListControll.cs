using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class HoldListControll : SingletonMonoBehavior<HoldListControll>
{
    GamePlayerInputHoldListener[] Listeners;

    // Start is called before the first frame update
    void Start()
    {
        InitPlayers();
    }

    void InitPlayers()
    {
        KeyCode[] PlayerArray = InGamePlayerKeyCode.instance.Get();
        Listeners = new GamePlayerInputHoldListener[PlayerArray.Length];
        for (int i = 0; i < PlayerArray.Length; i++)
        {
            KeyCode Item = PlayerArray[i];
            Listeners[i] = GamePlayerInputHoldListener.Create(Item);
        }
    }

    public GamePlayerInputHoldListener[] GetAllListener()
    {
        return Listeners;
    }


}
