
//MATERIA: Creación de videojuegos
//GRUPO: GDGS2101
//ALUMNO: José Guillermo Balderas Zamora
// FECHA: 30/09/2022

// Importaciones
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* Clase PlayerControllerX
*
*author: José Guillermo Balderas Zamora
*
* Clase PlayerControllerX da soporte  al player a crear varios objetos tipo perro.
**/
public class PlayerControllerX : MonoBehaviour
{
    // variable GameObject
    public GameObject dogPrefab;

    // Update is called once per frame
    void Update()
    {

        // Al presionar la tecla espacio en el teclado  creara un objeto de tipo perro
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
        
    }
}
