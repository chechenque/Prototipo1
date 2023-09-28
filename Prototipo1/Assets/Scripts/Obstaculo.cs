using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour{
    public bool LOG = false;

    private void Start() {
        if (LOG) Debug.Log("Obstaculo Start");
    }
}
