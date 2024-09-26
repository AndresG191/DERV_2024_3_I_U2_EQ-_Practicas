using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class AuxContador : MonoBehaviour
{
    
    // Start is called before the first frame update
   [SerializeField] TextMeshProUGUI mensaje;
    [SerializeField] ColectorObj aux_cont_enemigos;
    int contador;
    [SerializeField] TextMeshProUGUI texto_contador;
    [SerializeField] ColectorObj aux;
    void Start()
    {
        contador = 30;
        StartCoroutine(corrutina_contador());
    }

    IEnumerator corrutina_contador(){
        while(contador >= 0){
            contador--;
            texto_contador.text = contador.ToString();
             if(aux.contador >= 9) break;
            yield return new WaitForSeconds(0.5f); 
        }
        if(aux.contador >= 9){
            insertarMensaje("Ganaste");
        }else{
            insertarMensaje("Terminaste");
        }
       
    }

    public void insertarMensaje(String mensajeLabel){
         mensaje.text = (mensajeLabel);
    }
}
