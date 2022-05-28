using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Win", 0);
        Destroy(this, 3);
    }

    void Win()
    {
        GetComponent<PlayerAnimation>().ToHappy();
    }
}
