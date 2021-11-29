using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoints : MonoBehaviour{

    private GameMaster gm;

    void Start(){
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();
    }


    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")){
            gm.lastCheckPoint = transform.position;
        }
    }
}
