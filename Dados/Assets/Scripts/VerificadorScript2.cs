using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificadorScript2 : MonoBehaviour {
    public string resultado = "Sin dato";
    public static Vector3 velocidadDado;

    // Use this for initialization
    void Start()
    {
        velocidadDado = DadoScript2.velocidadDado;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        velocidadDado = DadoScript2.velocidadDado;
    }

    void OnTriggerEnter(Collider objeto)
    {
        if (objeto.tag == "dado2")
        {
            resultado = 7 - int.Parse(objeto.name) +"";
            
        }
    }
}
