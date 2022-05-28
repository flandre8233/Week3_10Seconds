using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class WinnerControll : SingletonMonoBehavior<WinnerControll>
{
    public KeyCode FindWhoWin()
    {
        return HoldListControll.instance.GetAllListener().OrderByDescending(x => x.GetTotalHoldTime()).Select(x => x.GetKeyCode()).FirstOrDefault();
    }


}
