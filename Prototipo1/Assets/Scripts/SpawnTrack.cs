using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrack : MonoBehaviour{
    public GameObject track;
    public Transform spawn;

    private void OnTriggerEnter(Collider other) {
        Debug.Log("TAG SPAWN: " + other.gameObject.tag);

        if(other.gameObject.tag == "nave") {
            Instantiate(track, spawn.position, spawn.rotation);
        }
    }
}
