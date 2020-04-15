using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;


public class DetectorScript : MonoBehaviour
{

    public BoxCollider collider1;

    public BoxCollider collider2;

    public BoxCollider collider3;

    public BoxCollider collider4;

    public BoxCollider collider5;

    public int dice1;

    public int dice2;

    public int dice3;

    public int dice4;

    public int dice5;

    static Vector3[] velocity;

    private GameObject[] dicesNow;
    // Start is called before the first frame update
    public string jugada = "";

    public int[] valores = new int[5];

    public bool[] isStop;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        dicesNow = DiceScript.dices;

        Vector3[] velocities = new Vector3[dicesNow.Length];

        for (int i = 0; i < dicesNow.Length; i++)
        {
            velocities[i] = dicesNow[i].GetComponent<Rigidbody>().velocity;
        }

        collider1 = dicesNow[0].GetComponent<BoxCollider>();
        collider2 = dicesNow[1].GetComponent<BoxCollider>();
        collider3 = dicesNow[2].GetComponent<BoxCollider>();
        collider4 = dicesNow[3].GetComponent<BoxCollider>();
        collider5 = dicesNow[4].GetComponent<BoxCollider>();

        velocity = velocities;

        armaJugada();


        //DiceScript.diceNumber = valores[0].ToString();
    }

    void OnTriggerStay(Collider collider)
    {

        for (int i = 0; i < velocity.Length; i++)
        {
            if (velocity[i].x == 0f && velocity[i].y == 0f && velocity[i].z == 0f)
            {

                if (collider.transform.parent.GetComponent<BoxCollider>() == collider1)
                {
                    switch (collider.gameObject.name)
                    {
                        case "Side1":
                            valores[0] = 6;
                            break;
                        case "Side2":
                            valores[0] = 5;
                            break;
                        case "Side3":
                            valores[0] = 4;
                            break;
                        case "Side4":
                            valores[0] = 3;
                            break;
                        case "Side5":
                            valores[0] = 2;
                            break;
                        default:
                            valores[0] = 1;
                            break;
                    }
                }
                if (collider.transform.parent.GetComponent<BoxCollider>() == collider2)
                {
                    switch (collider.gameObject.name)
                    {
                        case "Side1":
                            valores[1] = 6;
                            break;
                        case "Side2":
                            valores[1] = 5;
                            break;
                        case "Side3":
                            valores[1] = 4;
                            break;
                        case "Side4":
                            valores[1] = 3;
                            break;
                        case "Side5":
                            valores[1] = 2;
                            break;
                        default:
                            valores[1] = 1;
                            break;
                    }
                }
                if (collider.transform.parent.GetComponent<BoxCollider>() == collider3)
                {
                    switch (collider.gameObject.name)
                    {
                        case "Side1":
                            valores[2] = 6;
                            break;
                        case "Side2":
                            valores[2] = 5;
                            break;
                        case "Side3":
                            valores[2] = 4;
                            break;
                        case "Side4":
                            valores[2] = 3;
                            break;
                        case "Side5":
                            valores[2] = 2;
                            break;
                        default:
                            valores[2] = 1;
                            break;
                    }
                }
                if (collider.transform.parent.GetComponent<BoxCollider>() == collider4)
                {
                    switch (collider.gameObject.name)
                    {
                        case "Side1":
                            valores[3] = 6;
                            break;
                        case "Side2":
                            valores[3] = 5;
                            break;
                        case "Side3":
                            valores[3] = 4;
                            break;
                        case "Side4":
                            valores[3] = 3;
                            break;
                        case "Side5":
                            valores[3] = 2;
                            break;
                        default:
                            valores[3] = 1;
                            break;
                    }
                }
                if (collider.transform.parent.GetComponent<BoxCollider>() == collider5)
                {
                    switch (collider.gameObject.name)
                    {
                        case "Side1":
                            valores[4] = 6;
                            break;
                        case "Side2":
                            valores[4] = 5;
                            break;
                        case "Side3":
                            valores[4] = 4;
                            break;
                        case "Side4":
                            valores[4] = 3;
                            break;
                        case "Side5":
                            valores[4] = 2;
                            break;
                        default:
                            valores[4] = 1;
                            break;
                    }
                }
            }
        }



    }

    void armaJugada()
    {
        string jugada = "";
        Array.Sort(valores);//ordenamos para facilitar jugadas val dados
        //escaleras
        int[] escalera = new int[5] { 1, 2, 3, 4, 5 };
        int[] escalera2 = new int[5] { 1, 3, 4, 5, 6 };
        int[] escalera3 = new int[5] { 2, 3, 4, 5, 6 };
        List<int> values = new List<int>(valores);
        List<int> escal = new List<int>(escalera);
        List<int> escal2 = new List<int>(escalera2);
        List<int> escal3 = new List<int>(escalera3);
        ////

        Hashtable shash = new Hashtable();


        for (int i = 0; i < valores.Length; i++)
        {
            int repeat = 1;
            if (shash.ContainsKey(valores[i]))///si esta para quitar la llave y sumar el valor afuera del if
            {
                int temp = (int)shash[valores[i]];
                repeat = repeat + temp;
                shash.Remove(valores[i]);
            }
            shash.Add(valores[i], repeat); //con la llave concatena y suma digitos

        }

        if (shash.ContainsValue(2) && shash.ContainsValue(3))
        {
            jugada = "Sacaste full";
        }

        else if (shash.ContainsValue(4) && shash.ContainsValue(1))
        {
            jugada = "Sacaste poker";
        }

        else if (shash.ContainsValue(3))
        {
            for (int i = 0; i < valores.Length; i++) /// 1 2 2 2 4
            {
                if (shash.ContainsKey(valores[i]))
                {
                    int temp = (int)shash[valores[i]];
                    if (temp == 3)
                    {
                        jugada = "Sacaste triple dados: " + valores[i].ToString();
                    }
                }

            }

        }
        else if (shash.ContainsValue(2))
        {
            List<int> dobles = new List<int>();
            for (int i = 0; i < valores.Length; i++) /// 1 1 2 2 4
            {
                if (shash.ContainsKey(valores[i]))
                {
                    int temp = (int)shash[valores[i]];
                    if (temp == 2)
                    {
                        dobles.Add(valores[i]);
                    }
                }

            }
            if (dobles.Count > 2)
            {

                jugada = "Sacaste doble dados: " + dobles[0].ToString() + "," + dobles[2].ToString();
            }
            else
            {
                jugada = "Sacaste doble dados: " + dobles[0].ToString();
            }


        }
        else if (CheckMatch(values, escal) || CheckMatch(values, escal2) || CheckMatch(values, escal3))
        {
            jugada = "Sacaste escalera";
        }

        else if (values.Contains(valores[0]))//un numero esta igual adentro shash contains 5
        {
            if (CheckGrande(values, valores[0]))
            {
                jugada = "Sacaste la grande";
            }
        }
        else{
            jugada = "No Sacaste jugadas";
        }


        DiceScript.diceNumber = jugada;

    }

    bool CheckMatch(List<int> l1, List<int> l2) //copara arry
    {
        if (l1.Count != l2.Count)
            return false;
        for (int i = 0; i < l1.Count; i++)
        {
            if (l1[i] != l2[i])
                return false;
        }
        return true;
    }

    bool CheckGrande(List<int> l1, int value)//todos iguales
    {

        for (int i = 0; i < l1.Count; i++)
        {
            if (l1[i] != value)
                return false;
        }
        return true;
    }

}

