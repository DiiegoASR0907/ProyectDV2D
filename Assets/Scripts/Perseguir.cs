using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perseguir : MonoBehaviour {
    // darle un radio de vision al enemigo y velocidad a objeto
    public float visionRadius;
    public float speed;
    // asignar variable al tag jugador
    GameObject player;
    // almaceno posicion inicial
    Vector3 initialPosition;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        //actualizar posicion del transform a medida que encuentre tag player
        initialPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        // el objeto siempre se movera a la posicion inical de player 
        Vector3 target = initialPosition;
        // la variable distancia me determina el valor de distancia entre player y enemigo
        float dist = Vector3.Distance(player.transform.position, transform.position);
        //si el player ingresa en el radio del enemigo me transforme la posicion del enemigo
        if (dist < visionRadius) target = player.transform.position;
        // darle movimiento al enemigo al punto inicial del player
        float fixedSpeed = speed*Time.deltaTime;
        // mover del transform position hasta posicion del player mientras este dentro del target
        transform.position = Vector3.MoveTowards(transform.position, target, fixedSpeed);
        // dibuja linea de separación entre enemigo y player, si posicion incial esta mas cerca me la marca aya
        Debug.DrawLine(transform.position, target, Color.green);
	}
    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, visionRadius);
    }
}
