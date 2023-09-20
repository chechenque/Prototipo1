using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour{
    public float speed, rotationSpeed;
    private float vm;
    private float hm;
    public AudioClip audio;
    public AudioSource audioS;

    public int kill;
    public int puntuacion;
    public int salud;
    public int combo;

    private void Start(){
        Debug.Log("El script inicio");
        audioS = this.GetComponent<AudioSource>();
        combo = 0;
    }

    private void Update() {
        vm = Input.GetAxis("Vertical");
        hm = Input.GetAxis("Horizontal");
        this.transform.Translate(hm * Time.deltaTime * speed, 0, 0);
    }

    private void OnCollisionEnter(Collision collision) {
        Debug.Log("TAG NAVE: " +collision.gameObject.tag);

        switch (collision.gameObject.tag) {
            case "zombie":
                AtropellaZombie();
                break;
            case "obstaculo":
                DetectaObstaculo();
                break;
        }
    }

    /// <summary>
    /// Metodo que aumenta el valor del como
    /// La puntuacion
    /// Y las Kills del jugador
    /// </summary>
    private void AtropellaZombie() {
        kill++;
        combo++;
        puntuacion += 10 * combo;
    }

    private void DetectaObstaculo() {

    }
}
