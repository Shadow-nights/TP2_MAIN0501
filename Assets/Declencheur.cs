using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Declencheur : MonoBehaviour{
    public int nbCaisse =0;    
        
    // Start is called before the first frame update
    void Start(){

    }
    void OnTriggerEnter(Collider other){
        nbCaisse++;
        Debug.Log("Il y'a "+nbCaisse+" objets dans la zone");
    }
    void OnTriggerExit(Collider other){
        nbCaisse--;
        Debug.Log("Il y'a "+nbCaisse+" objets dans la zone");
    }
    // Update is called once per frame
    void Update(){

    }
}

