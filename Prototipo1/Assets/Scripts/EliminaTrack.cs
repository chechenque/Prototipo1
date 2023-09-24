using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminaTrack : MonoBehaviour {
    public GameObject track;

    private void OnTriggerEnter(Collider other) {
        Debug.Log("ON TRIGGER TRACK " + other.gameObject.tag);
        if(other.gameObject.tag == "nave") {
            Debug.Log("SE DESTRUIRA EL TRACK");
            Destroy(track, 1.0f);
        }
    }
}
