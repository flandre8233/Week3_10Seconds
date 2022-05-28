using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeeper : SingletonMonoBehavior<PlayerKeeper>
{

    public List<GameObject> Players = new List<GameObject>();

    public void AddPlayer(KeyCode keyCode)
    {
        Players.Add(PlayerSpawner.instance.SpawnPlayerRandomly(keyCode));
    }

    public void RemovePlayer(KeyCode keyCode)
    {
        GameObject Player = FindPlayerObject(keyCode);
        Players.Remove(Player);
        Player.AddComponent<PlayerDead>();
    }

    GameObject FindPlayerObject(KeyCode KeyCode)
    {
        foreach (var item in Players)
        {
            if (item.GetComponent<Player>().KeyCode == KeyCode)
            {
                return item;
            }
        }
        return null;
    }


    public void SetAllAttack()
    {
        foreach (var item in Players)
        {
            item.AddComponent<PlayerAttack>();
        }
    }

    public void SetWinner(KeyCode Winner)
    {
        foreach (var item in Players)
        {
            if (item.GetComponent<Player>().KeyCode == Winner)
            {
                item.AddComponent<PlayerWin>();
                if (item.GetComponent<PlayerAttack>())
                {
                    Destroy(item.GetComponent<PlayerAttack>());
                }
            }
        }


    }
    public void SetLoser(KeyCode Winner)
    {
        foreach (var item in Players)
        {
            if (item.GetComponent<Player>().KeyCode != Winner)
            {
                item.AddComponent<PlayerDead>();
                if (item.GetComponent<PlayerAttack>())
                {
                    Destroy(item.GetComponent<PlayerAttack>());
                }
            }
        }
    }

}


