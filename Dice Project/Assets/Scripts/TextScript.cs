using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    static Text number;
    // Start is called before the first frame update
    void Start()
    {
        number = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        number.text = DiceScript.diceNumber;
    }
}
