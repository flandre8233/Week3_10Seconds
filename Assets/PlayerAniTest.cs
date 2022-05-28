using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAniTest : MonoBehaviour
{
    [SerializeField] GameObject Idle;
    [SerializeField] GameObject Another;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            Idle.SetActive(true);
            Another.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            Idle.SetActive(false);
            Another.SetActive(true);
        }
    }
}
