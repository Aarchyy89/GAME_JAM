using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] SpawnLocations;
    public GameObject door;

    public static Spawner instance;
    public Vector3 respawnLocation;

    private void Awake()
    {
        instance = this;
        SpawnLocations = GameObject.FindGameObjectsWithTag("SpawnPoint");
    }

    private void Start()
    {
        door = (GameObject)Resources.Load("salida", typeof(GameObject));

        respawnLocation = door.transform.position;

        SpawnDoor();
    }

    private void SpawnDoor()
    {
        int spawn = Random.Range(0, SpawnLocations.Length);
        GameObject.Instantiate(door, SpawnLocations[spawn].transform.position, Quaternion.identity);
    }
}
