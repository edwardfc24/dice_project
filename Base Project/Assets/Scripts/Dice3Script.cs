using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice3Script : MonoBehaviour
{
   
    
    static Rigidbody rigidBody;
    public static Vector3 velocity3;
    public static string diceNumber3;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xVelocity = Random.Range(0f, 400f);
        float yVelocity = Random.Range(0f, 400f);
        float zVelocity = Random.Range(0f, 400f);

        if(Input.GetKeyDown(KeyCode.Space)){
            diceNumber3 = "0";
            rigidBody.AddForce(transform.up * 800f);
            // transform.position = new Vector3(0f, 2f, 0f);
            transform.rotation = Quaternion.identity;
            rigidBody.AddTorque(xVelocity, yVelocity, zVelocity);
        }
    }
}
