using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjetos : MonoBehaviour{
    public GameObject[] spawns = new GameObject[7];
    public GameObject[] cars = new GameObject[4];
    public GameObject[] powerUp = new GameObject[1];
    public GameObject[] obstaculos = new GameObject[3];

    int s, c;

    private void Start() {
        for(int i = 0; i < 3; ++i) {
            s = Random.Range(0, 7);
            c = Random.Range(0, 4);
            Instantiate(cars[c], spawns[s].transform.position, spawns[s].transform.rotation);
        }

        for(int i = 0; i < 3; ++i) {
            s = Random.Range(0, 7);
            c = Random.Range(0, 3);
            Instantiate(obstaculos[c], spawns[s].transform.position, spawns[s].transform.rotation);
        }

        s = Random.Range(0, 7);
        c = Random.Range(0, 1);
        Instantiate(powerUp[c], spawns[s].transform.position, spawns[s].transform.rotation);
    }
}
