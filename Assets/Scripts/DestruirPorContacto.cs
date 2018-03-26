using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirPorContacto : MonoBehaviour {

    public GameObject expocion, expocionJugador;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("AreaLimite")) return;

        Instantiate(expocion, transform.position, transform.rotation);
        if (other.CompareTag("Player")) {
            Instantiate(expocionJugador, other.transform.position, other.transform.rotation);
        }
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
