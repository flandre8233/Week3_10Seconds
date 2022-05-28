using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
    }

    void Attack()
    {
        GetComponent<PlayerAnimation>().ToAttack();
    }

    private void Update()
    {
        if (Input.GetKeyDown(player.KeyCode))
        {
            Attack();
        }
        if (Input.GetKeyUp(player.KeyCode))
        {
        GetComponent<PlayerAnimation>().ToIdle();
        }
    }
}
