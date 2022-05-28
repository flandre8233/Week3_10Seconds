using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : SingletonMonoBehavior<PlayerSpawner>
{
    [SerializeField]
    GameObject SpawnPrefab;

    private void Start()
    {

    }

    public GameObject SpawnPlayerRandomly(KeyCode keyCode)
    {
        Vector3 RandnomSpawnPoint = Random.insideUnitCircle.normalized * 10;
        GameObject SpawnedObject = Instantiate(SpawnPrefab, RandnomSpawnPoint, Quaternion.identity);
        SpawnedObject.GetComponent<Player>().KeyCode = keyCode;
        return SpawnedObject;
    }
}
