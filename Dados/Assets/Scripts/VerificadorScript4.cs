using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificadorScript4 : MonoBehaviour
{
      
   public string resultado = "Sin dato";
    static Vector3 velocidadDado;

    // Use this for initialization
    void Start()
    {
        velocidadDado = DadoScript4.velocidadDado;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        velocidadDado = DadoScript4.velocidadDado;
    }
    
    void OnTriggerEnter(Collider objeto)
    {
        if (objeto.tag == "dado4")
        {
            resultado = 7 - int.Parse(objeto.name) +"";

        }
    }
}
