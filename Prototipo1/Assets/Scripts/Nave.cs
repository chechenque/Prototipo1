using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Clase que modela una nave (jugador principal)
/// En nuestro Juego
/// </summary>
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

    public bool LOG = false;

    private void Start(){
        if(LOG) Debug.Log("El script inicio");
        audioS = this.GetComponent<AudioSource>();
        combo = 0;
        puntuacion = 0;
        salud = 100;
    }

    private void Update() {
        vm = Input.GetAxis("Vertical");
        hm = Input.GetAxis("Horizontal");
        this.transform.Translate(hm * Time.deltaTime * speed, 0, 0);
        ++puntuacion;
        if (LOG) Debug.Log("Combo : " + combo + "\nPuntuacion : " + puntuacion);
    }

    private void OnCollisionEnter(Collision collision) {
        if (LOG) Debug.Log("TAG NAVE: " +collision.gameObject.tag);

        switch (collision.gameObject.tag) {
            case "zombie":
                AtropellaZombie();
                break;
            case "obstaculo":
                DetectaObstaculo(collision);
                break;
            case "powerup":
                DetectaPowerUp(collision);
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

    /// <summary>
    /// Metodo que detecta un obstaculo
    /// reduce el combo a 0
    /// baja salud de acuerdo al obstaculo
    /// </summary>
    /// <param name="collision">El obstaculo con el que hace colision</param>
    private void DetectaObstaculo(Collision collision) {
        
    }

    /// <summary>
    /// Metodo que detecta un powerUp
    /// La lista de PowerUps es:
    /// Inmoratlidad: No recibes daños por cierto tiempo o numero de obstaculos
    /// Multiplicador de puntos: Aumenta la manera en la que se obtienen los puntos
    /// Boost de Puntos: Da un paquede de puntos de Golpe
    /// Reduccion de Velocidad: Reduce la velocidad del camino
    /// Boost de zombies: Generacion intensa de Zoombies, salen mas zombies de lo normal
    /// </summary>
    /// <param name="collision">El PowerUp con el que hace colision</param>
    private void DetectaPowerUp(Collision collision) {

    }
}
