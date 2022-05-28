using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayerInputHoldListener : MonoBehaviour
{
    [SerializeField] KeyCode InputKeyCode;

    public float HoldTotalTime;

    public static GamePlayerInputHoldListener Create(KeyCode _KeyCode)
    {
        GameObject NewObject = new GameObject();
        GamePlayerInputHoldListener TargetComponent = NewObject.AddComponent<GamePlayerInputHoldListener>();
        TargetComponent.InputKeyCode = _KeyCode;
        return TargetComponent;
    }

    private void Update()
    {

        if (Input.GetKey(InputKeyCode))
        {
            HoldTotalTime += Time.deltaTime;
            name = InputKeyCode.ToString() + " Listener : " + HoldTotalTime;
        }
    }

    public float GetTotalHoldTime()
    {
        return HoldTotalTime;
    }

public KeyCode GetKeyCode(){
    return InputKeyCode;
}
}
