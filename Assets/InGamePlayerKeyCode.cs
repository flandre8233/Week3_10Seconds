using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGamePlayerKeyCode : SingletonMonoBehavior<InGamePlayerKeyCode>
{
    public KeyCode[] RegisteredKeyCode;

    public void UpdatePlayerKeyCode()
    {
        RegisteredKeyCode = PlayerRegistrar.instance.GetRegisteredKeyCode();
    }

    public KeyCode[] Get()
    {
        return RegisteredKeyCode;
    }
}
