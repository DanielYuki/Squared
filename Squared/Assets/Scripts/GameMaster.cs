using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour{

    private static GameMaster instance;
    public Vector2 lastCheckPoint;
    public bool dashUnlockTriggered;

    void Awake() {
        if (instance == null){
            instance = this;
            DontDestroyOnLoad(this);
        }else{
            Destroy(gameObject);
        }
    }
}
