using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript2 : MonoBehaviour
{
    static Text number2;
    // Start is called before the first frame update
    void Start()
    {
        number2 = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        number2.text =  Dice2Script.diceNumber2;
    }
}
