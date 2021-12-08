using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour{

    public SpriteRenderer sr;

    void Start(){
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")){
            StartCoroutine(ActivateTrap());
        }
    }

    IEnumerator ActivateTrap(){
        sr.color = Color.white;

        yield return new WaitForSeconds(0.75f);
        sr.color = Color.red;
        this.tag = "Death" ;
    }

}
