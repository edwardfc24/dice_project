﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoScript : MonoBehaviour {

    public Text texto;
    public  string obtenido="";
    public VerificadorScript tablero;
    
	// Use this for initialization
	void Start () {
        texto = GetComponent < Text > ();
        actualizar();
    }
	
	// Update is called once per frame
	void Update () {
        texto.text = obtenido;
	}

    void actualizar()
    {
        obtenido = tablero.resultado;
        Invoke("actualizar", 0.5f);
    }
}
