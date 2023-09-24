using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MueveTrack : MonoBehaviour{
    public float speed;
    public int count;

    private void Start() {
        Debug.Log("MUEVE TRACK INICIO");
        count = 0;
    }

    private void Update() {
        this.transform.Translate(Time.deltaTime * 0.1f * speed, 0, 0);
        ++count;
        /*if(count == 1000) {
            count = 0;
            Funcion();
        }*/
    }

    /// <summary>
    /// Metodo que aumenta la velocidad dada la funcion presentada aqui
    /// </summary>
    private void Funcion() {
        speed += 2 * speed;
    }
}
