using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjetos : MonoBehaviour{
    public GameObject[] spawns = new GameObject[7];
    public GameObject[] cars = new GameObject[4];
    public GameObject[] powerUp = new GameObject[1];
    public GameObject[] obstaculos = new GameObject[3];

    int c;

    private void Start() {
        for(int i = 0; i < 3; ++i) {
            c = Random.Range(0, 4);
            Instantiate(cars[c], spawns[i].transform.position, spawns[i].transform.rotation);
        }

        for(int i = 3; i < 6; ++i) {
            c = Random.Range(0, 3);
            Instantiate(obstaculos[c], spawns[i%3].transform.position, spawns[i%3].transform.rotation);
        }

        c = Random.Range(0, 1);
        Instantiate(powerUp[c], spawns[6].transform.position, spawns[6].transform.rotation);
    }
}
