using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorScript : MonoBehaviour
{
    private static int dice1Position = 0;
    private static int dice2Position = 1;
    private static int dice3Position = 2;
    private static int dice4Position = 3;
    private static int dice5Position = 4;
    private Vector3[] velocities;
    private int[] dicesNumber;
    // Start is called before the first frame update
    void Start()
    {
        velocities = new Vector3[5];
        dicesNumber = new int[5];
    }

    // Update is called once per frame
    void Update()
    {
        velocities[dice1Position] = DiceScript.velocity;
        velocities[dice2Position] = Dice2Script.velocity;
        velocities[dice3Position] = Dice3Script.velocity;
        velocities[dice4Position] = Dice4Script.velocity;
        velocities[dice5Position] = Dice5Script.velocity;
        getMove();
    }

    void OnTriggerStay(Collider collider) {
        if (collider.gameObject.GetComponentInParent(typeof(MonoBehaviour)).name == "dice"){
            if (velocities[dice1Position].x == 0f && velocities[dice1Position].y == 0 && velocities[dice1Position].z == 0)
            {
                //Debug.Log(collider.gameObject.name);
                //Debug.Log(collider.gameObject);
                int value = getNumber(collider);
                if (value > 0) {
                    dicesNumber[dice1Position] = value;
                }
                //Debug.Log("DADO 1: " + dicesNumber[dice1Position]);
            }
        } else if (collider.gameObject.GetComponentInParent(typeof(MonoBehaviour)).name == "dice2"){
            if (velocities[dice2Position].x == 0f && velocities[dice2Position].y == 0 && velocities[dice2Position].z == 0)
            {
                int value = getNumber(collider);
                if (value > 0)
                {
                    dicesNumber[dice2Position] = value;
                }
                //Debug.Log("DADO 2: " + dicesNumber[dice2Position]);
            }
        } else if (collider.gameObject.GetComponentInParent(typeof(MonoBehaviour)).name == "dice3"){
            if (velocities[dice3Position].x == 0f && velocities[dice3Position].y == 0 && velocities[dice3Position].z == 0)
            {
                int value = getNumber(collider);
                if (value > 0)
                {
                    dicesNumber[dice3Position] = value;
                }
            }
        } else if (collider.gameObject.GetComponentInParent(typeof(MonoBehaviour)).name == "dice4"){
            if (velocities[dice4Position].x == 0f && velocities[dice4Position].y == 0 && velocities[dice4Position].z == 0)
            {
                int value = getNumber(collider);
                if (value > 0)
                {
                    dicesNumber[dice4Position] = value;
                }
            }
        }
        else if (collider.gameObject.GetComponentInParent(typeof(MonoBehaviour)).name == "dice5"){
            if (velocities[dice5Position].x == 0f && velocities[dice5Position].y == 0 && velocities[dice5Position].z == 0)
            {
                int value = getNumber(collider);
                if (value > 0)
                {
                    dicesNumber[dice5Position] = value;
                }
            }
        }
    }

    int getNumber(Collider collider)
    {
        if (collider.gameObject.name == "Side1")
        {
            return 6;
        }
        else if (collider.gameObject.name == "Side2")
        {
            return 5;
        }
        else if (collider.gameObject.name == "Side3")
        {
            return 4;
        }
        else if (collider.gameObject.name == "Side4")
        {
            return 3;
        }
        else if (collider.gameObject.name == "Side5")
        {
            return 2;
        }
        else if (collider.gameObject.name == "Side6")
        {
            return 1;
        }
        return 0;
    }

        void getMove() {
        int total = 0;
        Hashtable values = new Hashtable();
        string move = "No hay jugada";

        for (int i = 0; i < dicesNumber.Length; i++) {
            //Debug.Log(("i:" + i ) + " - " + dicesNumber[i]);
            int value = 1;
            total += dicesNumber[i];
            if (values.ContainsKey(dicesNumber[i])) {
                int aux = (int) values[dicesNumber[i]];
                value = value + aux;
                values.Remove(dicesNumber[i]);
            }
            values.Add(dicesNumber[i], value);
            Debug.Log(value);
        }

        if (values.ContainsValue(2) && values.ContainsValue(3))
        {
            move = "FULL";
        }

        else if (values.ContainsValue(4) && values.ContainsValue(1))
        {
            move = "POKER";
        }

        else if (values.ContainsValue(5))
        {
            move = "GRANDE";
        }

        else if (((values.ContainsValue(1) && total == 15) || (values.ContainsValue(1) && total == 20 )) && !values.ContainsValue(2))
        {
            move = "ESCALERA";
        }
        else if (values.ContainsValue(3))
        {
            move = "TRICA DE DADOS";
        }
        else if (values.ContainsValue(2))
        {
            move = "PAR DE DADOS";
        }

        DiceScript.diceNumber = move;

    }
}
