using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameStatus : SingletonMonoBehavior<InGameStatus>
{
    [SerializeField] GameObject Ready;
    [SerializeField] GameObject Game;
    [SerializeField] GameObject Result;
    public void ToReadyStatus()
    {
        OffAllObject();
        Ready.SetActive(true);
        UIStatus.instance.ToReadyStatus();
    }
    public void ToGameStatus()
    {
        OffAllObject();
        Game.SetActive(true);
        UIStatus.instance.ToGameStatus();
    }
    public void ToResultStatus()
    {
        OffAllObject();
        Result.SetActive(true);
        UIStatus.instance.ToResultStatus();
    }

    void OffAllObject()
    {
        Ready.SetActive(false);
        Game.SetActive(false);
        Result.SetActive(false);
    }

    private void Start()
    {
        ToReadyStatus();
    }
}
