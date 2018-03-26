using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandonRotate : MonoBehaviour {

    private Rigidbody rig;
    public float rotacion;
    // Use this for initialization
    void Awake()
    {
        rig = GetComponent<Rigidbody>();
    }

    void Start(){

        rig.angularVelocity = Random.insideUnitSphere* rotacion;
    }

    
}
