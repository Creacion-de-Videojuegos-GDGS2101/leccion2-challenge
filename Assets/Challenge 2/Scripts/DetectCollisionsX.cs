//MATERIA: Creación de videojuegos
//GRUPO: GDGS2101
//ALUMNO: José Guillermo Balderas Zamora
// FECHA: 30/09/2022


// Importaciones
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* Clase DetectCollisionsX
*
*author: José Guillermo Balderas Zamora
*
* Clase DetectCollisionsX da soporte a detectar las colisiones, cuando una pelota toque un perro sera destruido
**/
public class DetectCollisionsX : MonoBehaviour
{
    // Funcion que ayuda a destruir los objetos tanto perro como pelota
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
