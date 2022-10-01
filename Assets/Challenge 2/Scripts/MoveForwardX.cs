//MATERIA: Creación de videojuegos
//GRUPO: GDGS2101
//ALUMNO: José Guillermo Balderas Zamora
// FECHA: 30/09/2022


// Importaciones
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
* Clase MoveForwardX
*
*author: José Guillermo Balderas Zamora
*
* Clase MoveForwardX da soporte al movimiento que tiene el perro para que se desplace en linea recta, ademas el jugador podra crea un nuevo
* objeto de tipo perro.
**/
public class MoveForwardX : MonoBehaviour
{

    // Variable tipo float que guarda la velovidad
    public float speed;



    // Update is called once per frame
    void Update()
    {
        // Ayuda a mover en linea recta al objeto de tipo perro.
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
