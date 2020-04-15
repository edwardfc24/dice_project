using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texto_probabilidad : MonoBehaviour {
    public TextoScript dato1;
    public TextoScript2 dato2;
    public TextoScript3 dato3;
    public TextoScript4 dato4;
    public TextoScript5 dato5;
    

    public DadoScript velocidad;
    public DadoScript2 velocidad2;
    public DadoScript3 velocidad3;
    public DadoScript4 velocidad4;
    public DadoScript5 velocidad5;
   

    public Text texto;
    public string resultado;

    // Use this for initialization
    void Start () {
        texto = GetComponent<Text>();
        actualizar();
    }
	
	// Update is called once per frame
	void Update () {
        texto.text = resultado;
        if (Input.GetKey(KeyCode.L))
        {
            texto.text = "Numero del dados";
        }
    }



    


    void actualizar(){
        
        if (dato1.obtenido == dato2.obtenido)
        {
          string valor1 = "Doble Servido";
            resultado =  "1 "+(valor1);
          
            if (dato3.obtenido == dato4.obtenido)
            {
                string r = "Doble Servido";
                resultado ="2 "+(r);
            }
            else{
                 resultado =  "Tira los dados  ";
            }
            
        }
        else
        {
            
           
            resultado =  "Tira los dados  ";
            
        }
        
    

    }
 
}