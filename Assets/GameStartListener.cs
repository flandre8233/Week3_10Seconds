using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartListener : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && PlayerRegistrar.instance.GetRegisteredKeyCode().Length >= 2 )
        {
            OnInput();
        }
    }

    void OnInput()
    {
        Ready.instance.OnGameStartEntry();
        Destroy(gameObject);
    }
}
