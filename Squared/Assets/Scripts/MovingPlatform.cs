using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour{

    public float speed;
    public int startPoint;
    public Transform[] points;

    private int i;

    void Start(){
        transform.position = points[startPoint].position;
    }


    void Update(){
        if (Vector2.Distance(transform.position, points[i].position) < 0.02f){
            i++;
            if (i == points.Length){
                i = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed* Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other){
        //if(other.transform.position.y > transform.position.y){
            other.transform.SetParent(transform);
        //}
    }

    private void OnCollisionExit2D(Collision2D other) {
        other.transform.SetParent(null);
    }
}
