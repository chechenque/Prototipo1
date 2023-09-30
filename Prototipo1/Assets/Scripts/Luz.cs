using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luz : MonoBehaviour{
    public float speed;

    // Start is called before the first frame update
    void Start() {
        transform.Rotate(50f, 0, 0);
    }

    // Update is called once per frame
    void Update() {
        if (this.transform.rotation.eulerAngles.x > 60) {
            transform.Rotate(-6f, 0, 0);
        } else {
            transform.Rotate(speed * Time.deltaTime, 0, 0);
        }
    }
}
