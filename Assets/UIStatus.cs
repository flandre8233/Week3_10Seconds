using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIStatus : SingletonMonoBehavior<UIStatus>
{
    [SerializeField] GameObject Ready;
    [SerializeField] GameObject Game;
    [SerializeField] GameObject Result;
    public void ToReadyStatus()
    {
        OffAllObject();
        Ready.SetActive(true);
    }
    public void ToGameStatus()
    {
        OffAllObject();
        Game.SetActive(true);
    }
    public void ToResultStatus()
    {
        OffAllObject();
        Result.SetActive(true);
    }

    void OffAllObject()
    {
        Ready.SetActive(false);
        Game.SetActive(false);
        Result.SetActive(false);
    }
}
