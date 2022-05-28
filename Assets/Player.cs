using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public KeyCode KeyCode;
    [SerializeField] GameObject ModelObject;

    private void Start()
    {
        ModelObject.transform.localScale = new Vector3(Random.Range(0, 100) <= 50 ? 1 : -1, 1, 1);
    }
}
