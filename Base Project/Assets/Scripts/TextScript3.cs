using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript3 : MonoBehaviour
{
    static Text number3;
    // Start is called before the first frame update
    void Start()
    {
        number3 = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        number3.text = Dice3Script.diceNumber3;
    }
}
