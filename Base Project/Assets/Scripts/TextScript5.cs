using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript5 : MonoBehaviour
{
    static Text number5;
    // Start is called before the first frame update
    void Start()
    {
        number5= GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        number5.text = Dice5Script.diceNumber5;
    }
}
