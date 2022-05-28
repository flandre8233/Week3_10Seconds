using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRegistrar : SingletonMonoBehavior<PlayerRegistrar>
{
    public int[] values;
    public bool[] keys;

    [SerializeField] List<KeyCode> INCode = new List<KeyCode>();

    // Start is called before the first frame update
    void Start()
    {
        values = (int[])System.Enum.GetValues(typeof(KeyCode));
        keys = new bool[values.Length];
        INCode = new List<KeyCode>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateKeys();
    }

    void OnKeyIN(KeyCode _KeyCode)
    {
        INCode.Add(_KeyCode);
        PlayerKeeper.instance.AddPlayer(_KeyCode);
        RegisteredPlayerTextUI.instance.UpdateRegisteredPlayerView();

    }
    void OnKeyOut(KeyCode _KeyCode)
    {
        INCode.Remove(_KeyCode);
        PlayerKeeper.instance.RemovePlayer(_KeyCode);
        RegisteredPlayerTextUI.instance.UpdateRegisteredPlayerView();
    }

    void UpdateKeys()
    {
        for (int i = 0; i < values.Length; i++)
        {
            if (!IsThisCodeAllow((KeyCode)values[i]))
            {
                continue;
            }
            bool IsKeyDown = Input.GetKey((KeyCode)values[i]);
            if (!keys[i] && IsKeyDown)
            {
                OnKeyIN((KeyCode)values[i]);
            }
            if (keys[i] && !IsKeyDown)
            {
                OnKeyOut((KeyCode)values[i]);
            }
            keys[i] = Input.GetKey((KeyCode)values[i]);
        }
    }

    public KeyCode[] GetRegisteredKeyCode()
    {
        return INCode.ToArray();
    }

    public bool IsThisCodeAllow(KeyCode Code)
    {
        return !((Code == KeyCode.Space) || (Code == KeyCode.Mouse0) || (Code == KeyCode.Mouse1));
    }

}
