using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScriptResult : MonoBehaviour
{
    public static Text Resultado;
    public static int punto;

    // Start is called before the first frame update
    void Start()
    {
        Resultado = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
       
        if(punto==1){
            Resultado.text="Escalera";
        }if(punto==2){
            Resultado.text="FULL";
        }if(punto==3){
            Resultado.text="POKER";
        }if(punto==4){
            Resultado.text="Grande";
        }if(punto==0){
            Resultado.text=" ";
        }
        punto=0;


    }
}
