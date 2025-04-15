using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colonia : MonoBehaviour
{
    // variables
    public int cantidadInfantes;
    public int cantidadJuveniles;
    int profesoresINecesito;
    int profesoresJNecesito;
    int profesoresTotal;
    int cordinadoresNecesito;
    int listaEspera;

    // Start is called before the first frame update
    void Start()
    {
        // chequear variable

        if (cantidadInfantes < 0 || cantidadJuveniles < 0 || cantidadInfantes > 100 || cantidadJuveniles > 100)
        {
            Debug.Log("La cantidad no puede ser negativa o no puede ser mayor a 100");
            return;
        }


        // operación
        profesoresINecesito = cantidadInfantes / 10;
        profesoresJNecesito = cantidadJuveniles / 20;
        profesoresTotal = profesoresINecesito + profesoresJNecesito;
        cordinadoresNecesito = profesoresTotal / 5;

        if ((profesoresTotal % 5) != 0)
        {
            cordinadoresNecesito ++;
        }

        listaEspera = (cantidadInfantes % 10) + (cantidadJuveniles % 20);

        // mensaje
        Debug.Log("Se necesitan " + profesoresJNecesito + " profesores para los inscriptos juveniles");
        Debug.Log("Se necesitan " + profesoresINecesito + " profesores para los inscriptos infantes");
        Debug.Log("Se necesitan " + cordinadoresNecesito + " coordinadores para los inscriptos");

        if (listaEspera > 0)
        {
            Debug.Log("Hay " + listaEspera + " cant de inscriptos en la lista de espera");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
