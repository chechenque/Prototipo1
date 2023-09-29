using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemueveObjeto : MonoBehaviour{
    public bool LOG = false;


    private void OnTriggerEnter(Collider other) {
        if (LOG) Debug.Log("TAG Limite: " + other.gameObject.tag);
        if (other.gameObject.tag != "Untagged") {
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision) {
        if (LOG) Debug.Log("TAG Limite: " + collision.gameObject.tag);
        if (collision.gameObject.tag != "Untagged") {
            Destroy(collision.gameObject);
        }
    }
}
