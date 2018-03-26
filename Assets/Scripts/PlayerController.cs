using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary {
    public float xMin;
    public float xMax;
    public float zMin;
    public float zMax;
}

public class PlayerController : MonoBehaviour {
    private Rigidbody rig;
    [Header("Movimiento")]
    public float velocidad;
    public float rotacion;
    public Boundary boundary;

    [Header("Disparo")]
    public GameObject shot;
    public Transform puntoDisparo;
    public float fireRate;
    private float nextFire;



    // Use this for initialization
    void Awake () {
        rig = GetComponent<Rigidbody>();
	}

    // Update is called once per frame

    void Update() {
        if (Input.GetButton("Fire1") && Time.time > nextFire){
            nextFire = Time.time + fireRate;
            Instantiate(shot, puntoDisparo.position, Quaternion.identity);

        }

    }
    void FixedUpdate () {
        float moverHorizontal = Input.GetAxis("Horizontal");
        float moverVertical = Input.GetAxis("Vertical");

                    Vector3 movimiento = new Vector3(moverHorizontal, 0, moverVertical);
            rig.velocity = movimiento * velocidad;
        
        rig.position = new Vector3(Mathf.Clamp(rig.position.x, boundary.xMin, boundary.xMax), 0, Mathf.Clamp(rig.position.z, boundary.zMin, boundary.zMax));

        rig.rotation = Quaternion.Euler(-rig.velocity.z , 0,-rig.velocity.x * rotacion);
        

    }
}
