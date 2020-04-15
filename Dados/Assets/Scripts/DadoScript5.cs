using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DadoScript5 : MonoBehaviour
{
    public static Rigidbody rigidBody;
    public static Vector3 velocidadDado;
    public float posicion_y = 5.055f;
    public static string diceNumber;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
        SimulacionLanzamiento();
	}
	
	// Update is called once per frame
	void Update () {
       
            SimulacionLanzamiento();
            posicion_y = velocidadDado.y;
       
        
	}

    void SimulacionLanzamiento()
    {
        
        float xVelocity = Random.Range(0f, 500f);
        float yVelocity = Random.Range(0f, 500f);
        float zVelocity = Random.Range(0f, 500f);

        if(Input.GetKeyDown(KeyCode.Space)){
            diceNumber = "0";
            rigidBody.AddForce(transform.up * 700f);
            // transform.position = new Vector3(0f, 2f, 0f);
            transform.rotation = Quaternion.identity;
            rigidBody.AddTorque(xVelocity, yVelocity, zVelocity);
        }
    }
}
