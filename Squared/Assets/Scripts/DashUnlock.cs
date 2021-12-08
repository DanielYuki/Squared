using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashUnlock : MonoBehaviour{

    private GameMaster gm;
    public PlayerMovement mov;
    public Animator anim, animB;

    void Start(){
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();
        
        if (gm.dashUnlockTriggered){
            this.gameObject.SetActive(false);
            mov.canDash = true;
            
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")){
            anim.SetTrigger("DashUnlocked");
            animB.SetTrigger("DashUnlockedB");
            this.gameObject.SetActive(false);
            mov.canDash = true;
            gm.dashUnlockTriggered = true;
        }
    }
}
