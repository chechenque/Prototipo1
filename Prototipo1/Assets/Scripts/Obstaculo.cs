using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour{
    public bool LOG = false;
    public int speed;
    public AudioClip[] audios = new AudioClip[3];
    public AudioSource audioS;
    int c;

    private void Start() {
        if (LOG) Debug.Log("Obstaculo Start");
    }

    private void Update() {
        this.transform.Translate(0, 0, 1 * Time.deltaTime * speed);
    }

    private void OnCollisionEnter(Collision collision) {
        if (LOG) Debug.Log("TAG CollisionEnter: " + collision.gameObject.tag);
        if (collision.gameObject.tag == "nave") {
            c = Random.Range(0, 3);
            audioS.PlayOneShot(audios[c]);
        }
    }

    

}