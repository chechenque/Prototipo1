using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjetos : MonoBehaviour{
    public GameObject[] spawns = new GameObject[7];
    public GameObject[] cars = new GameObject[3];
    public GameObject[] powerUp = new GameObject[1];
    public GameObject[] obstaculos = new GameObject[2];

    int s, c;

    private void Start() {
        for(int i = 0; i < cars.Length; ++i) {
            s = Random.Range(0, 4);
            c = Random.Range(0, 4);
        }
    }
}
