using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class MovimientoSimple : MonoAdvance
{
    public  float velocidad = 5.0f;
    public float tiempo = 1f;

 
    

    void Update()
    {
        // Obtener la entrada del teclado
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Calcular el vector de movimiento
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, movimientoVertical);
        

        // Mover el objeto en la direcci�n calculada
        transform.Translate (movimiento* velocidad *Time.deltaTime, Space.World);
    }
}

