using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript4 : MonoBehaviour
{
    static Text number4;
    // Start is called before the first frame update
    void Start()
    {
        number4 = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        number4.text =  Dice4Script.diceNumber4;
    }
}
