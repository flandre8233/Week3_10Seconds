using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerTextUI : MonoBehaviour
{
    Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Game.instance.GameEndTimer)
        {
            text.text = Game.instance.GameEndTimer.GetCurrentTime().ToString ("#.##");
            text.color = Color.Lerp(Color.black, Color.red, Game.instance.GameEndTimer.GetProgress());
        }
        else
        {
            text.text = "Game Set!";
            text.color = Color.red;
        }
    }
}
