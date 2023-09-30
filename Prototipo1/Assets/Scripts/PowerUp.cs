using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour{
    public bool LOG = false;
    public int speed;
    public AudioClip audio;
    public AudioSource audioS;

    private void Start() {
        if (LOG) Debug.Log("PowerUp Start");
        audioS = this.GetComponent<AudioSource>();
    }

    private void Update() {
        this.transform.Translate(0, 0, 1 * Time.deltaTime * speed);
    }

    private void OnCollisionEnter(Collision collision) {
        if (LOG) Debug.Log("TAG CollisionEnter: " + collision.gameObject.tag);
        if (collision.gameObject.tag == "nave") {
            audioS.PlayOneShot(audio);
            Destroy(this.gameObject,6f);
        }
    }

}
