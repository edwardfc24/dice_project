using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour
{
    static Rigidbody rigidBody;
    public static Vector3 velocity;
    public static string diceNumber;

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
            rigidBody.AddForce(transform.up * 800f);
            // transform.position = new Vector3(0f, 2f, 0f);
            transform.rotation = Quaternion.identity;
            rigidBody.AddTorque(xVelocity, yVelocity, zVelocity);
        }
    }
}
