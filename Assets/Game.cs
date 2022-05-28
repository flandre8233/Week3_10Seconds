using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : SingletonMonoBehavior<Game>
{
    public Timer GameEndTimer;
    // Start is called before the first frame update
    void Start()
    {
        GameEndTimer = Timer.Create(10, OnTimeEnd);
        PlayerKeeper.instance.SetAllAttack();
    }

    public void OnTimeEnd()
    {
        InGameStatus.instance.ToResultStatus();

        KeyCode Winner = WinnerControll.instance.FindWhoWin();
        print("Winner is " + Winner.ToString());
        PlayerKeeper.instance.SetWinner(Winner);
        PlayerKeeper.instance.SetLoser(Winner);
    }



}
