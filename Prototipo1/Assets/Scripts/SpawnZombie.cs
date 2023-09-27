using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombie : MonoBehaviour{
    public GameObject[] spawns = new GameObject[5];
    public GameObject[] zombies = new GameObject[1];

    private void Start() {
        Debug.Log("SPAWN ZOMBIES");
        for(int i = 0; i < 5; ++i) {
            Instantiate(zombies[0], spawns[i].transform.position, spawns[i].transform.rotation);
        }
    }
}
