using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
    public TMP_Text tmp;

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
        tmp.text = salud.ToString();
    }

    private void Update() {
        vm = Input.GetAxis("Vertical");
        hm = Input.GetAxis("Horizontal");
        this.transform.Translate(hm * Time.deltaTime * speed, 0, 0);
        ++puntuacion;
        if (LOG) LogCompleto();
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
        if (LOG) Debug.Log("Obstaculo detectado");
        int c = Random.Range(1, 25);
        if(salud - c < 0) {
            salud = 0;
            tmp.text = salud.ToString();
            DestruyeCoche();
        } else {
            salud -= c;
            tmp.text = salud.ToString();
        }

        if (LOG) Debug.Log("Vida perdida: " + c);
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
        switch (Random.Range(0, 3)) {
            case 0:
                BoostPuntos();
                break;
            case 1:
                RegeneraVida();
                break;
            case 2:
                AumentaCombo();
                break;
        }
    }

    /// <summary>
    /// Metodo que genera un boostDePuntos
    /// El rango va desde 0 puntos hasta 10k
    /// </summary>
    private void BoostPuntos() {
        int c = Random.Range(0, 10000);
        if (LOG) Debug.Log("Puntos obtenido: " + c);
        this.puntuacion += c;
    }

    /// <summary>
    /// MEtodo que regenera vida del persona
    /// el Maximo es 100.
    /// Si supera el maximo se asigna 100
    /// </summary>
    private void RegeneraVida() {
        int c = Random.Range(0, 100);
        if (LOG) Debug.Log("Vida regenerada: " + c);
        if (c + salud > 100) {
            salud = 100;
        } else {
            salud += c;
        }
        tmp.text = salud.ToString();
    }

    /// <summary>
    /// Metodo que aumenta el combo que llevamos
    /// </summary>
    private void AumentaCombo() {
        int c = Random.Range(0, 25);
        if (LOG) Debug.Log("Combo aumentado: " + c);
        this.combo += c;
    }

    /// <summary>
    /// Metodo que nos muestra los logs completos de nuestro Scrip
    /// </summary>
    private void LogCompleto() {
        Debug.Log("Kills : " + kill + "\nSalud : " + salud);
        Debug.Log("Combo : " + combo + "\nPuntuacion : " + puntuacion);      
    }

    private void DestruyeCoche() {
        this.gameObject.SetActive(false);
    }
}