using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RegisteredPlayerTextUI : SingletonMonoBehavior<RegisteredPlayerTextUI>
{
    [SerializeField] Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    public void UpdateRegisteredPlayerView()
    {
        KeyCode[] RegisteredKeyCode = PlayerRegistrar.instance.GetRegisteredKeyCode();
        string RegisteredResult = "";
        if (RegisteredKeyCode.Length > 0)
        {
            RegisteredResult = "Current Player：";
            for (int i = 0; i < RegisteredKeyCode.Length; i++)
            {
                RegisteredResult += RegisteredKeyCode[i];
                if (i < RegisteredKeyCode.Length - 1)
                {
                    RegisteredResult += ", ";
                }
            }
        }
        text.text = RegisteredResult;
    }

}
