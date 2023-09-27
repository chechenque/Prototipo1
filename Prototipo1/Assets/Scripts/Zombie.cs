using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour{
    public bool LOG = false;
    public int speed;
    public AudioClip[] audios = new AudioClip[6];
    public AudioSource audioS;
    int c;

    private void Start() {
        Debug.Log("ZOMBIE START");
    }

    private void Update() {
        this.transform.Translate(0, 0, 1 * Time.deltaTime * speed);
    }

    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "nave") {
            c = Random.Range(0, 4);
            audioS.PlayOneShot(audios[c]);
            Destroy(this.gameObject, 3);
        }
    }
}
