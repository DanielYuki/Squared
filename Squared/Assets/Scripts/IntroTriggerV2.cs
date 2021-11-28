using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroTriggerV2 : MonoBehaviour
{
    public HingeJoint2D plankJoint;
    public Animator anim;

    private void Awake() {
        plankJoint = GameObject.FindGameObjectWithTag("Plank").GetComponent<HingeJoint2D>();
     
    }

    private void OnTriggerEnter2D(Collider2D other) {
        // if (this.gameObject.CompareTag("Room01")){
        //     Debug.Log("assa");
            
        //     StartCoroutine("BridgeTrigger");
        // }
        if (other.CompareTag("Player") && !other.isTrigger){
            Debug.Log("kol");
            StartCoroutine("BridgeTrigger");
        }
    }

    IEnumerator BridgeTrigger(){
        anim.SetTrigger("PlayIntro");

        yield return new WaitForSeconds(3.5f);

        plankJoint.enabled = false;
        Debug.Log("bbbbb");
    }
}
