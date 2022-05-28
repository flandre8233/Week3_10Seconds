using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ReadyUI : SingletonMonoBehavior<ReadyUI>
{
    [SerializeField] GameObject TitleCanvasObject;
    [SerializeField] GameObject TimerCanvasObject;
    private void Start()
    {
        ToTitleCanvas();
    }

    public void ToTitleCanvas()
    {
        TitleCanvasObject.SetActive(true);
        TimerCanvasObject.SetActive(false);

    }
    public void ToTimerCanvas()
    {
        TitleCanvasObject.SetActive(false);
        TimerCanvasObject.SetActive(true);
    }
}
