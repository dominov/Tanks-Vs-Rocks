using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverDisparo : MonoBehaviour {
    private Rigidbody rig;
    public float velocidad;
    // Use this for initialization

    void Awake()
    {
        rig = GetComponent<Rigidbody>();
    }
    void Start () {
        rig.velocity = transform.forward * velocidad;
    }
	
	
}
