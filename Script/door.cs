using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour {

    public GameObject Door;
    public bool doorIsOpening;

    void Update () {
        if (doorIsOpening == true) {
            Door.transform.Translate(Vector3.up * Time.deltaTime * 800);
            
        }
        if (Door.transform.position.y > 30f) {
            doorIsOpening = false;
        }
    }
    void OnMouseDown(){

        doorIsOpening = true;
    }

}