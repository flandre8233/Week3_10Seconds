using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField]
    GameObject Idle;
    [SerializeField]
    GameObject Run;
    [SerializeField]
    GameObject[] Attack;
    [SerializeField]
    GameObject Happy;
    [SerializeField]
    GameObject Dead;

    void ResetAll()
    {
        Idle.SetActive(false);
        Run.SetActive(false);
        foreach (var item in Attack)
        {
            item.SetActive(false);
        }
        Happy.SetActive(false);
        Dead.SetActive(false);
    }

    public void ToIdle()
    {
        ResetAll();
        Idle.SetActive(true);
    }

    public void ToRun()
    {
        ResetAll();
        Run.SetActive(true);
    }

    public void ToAttack()
    {
        ResetAll();
        Attack[Random.Range(0, Attack.Length)].SetActive(true);
    }

    public void ToHappy()
    {
        ResetAll();
        Happy.SetActive(true);
    }

    public void ToDead()
    {
        ResetAll();
        Dead.SetActive(true);
    }

}
