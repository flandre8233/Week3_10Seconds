using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDead : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GetComponent<PlayerMovement>())
        {
            Destroy(GetComponent<PlayerMovement>());
        }
        GetComponent<PlayerAnimation>().ToDead();
        Destroy(gameObject, 1.25f);
    }

}
