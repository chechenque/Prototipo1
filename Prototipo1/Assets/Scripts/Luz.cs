using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luz : MonoBehaviour{
    public float velocidad;



    private void Start() {
        transform.Rotate(70, 0, 0);
    }

    private void FixedUpdate() {
        if(transform.localEulerAngles.x > 80) {
            transform.localEulerAngles.
        }
    }
}
