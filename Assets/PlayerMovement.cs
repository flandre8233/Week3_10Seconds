using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    PlayerAnimation PAnimation;
    // Start is called before the first frame update
    void Start()
    {
        PAnimation = GetComponent<PlayerAnimation>();
        PAnimation.ToRun();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(), Time.deltaTime * Random.Range(0.61f, 1.01f));

        if (Vector3.Distance(transform.position, new Vector3()) <= 1.2f)
        {
            PAnimation.ToIdle();
            Destroy(this);
        }

    }
}
