using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Sonido : MonoBehaviour
{
    public AudioSource EmisorCubo; //quien emite el sonido
    public AudioClip Archivo; //archivo que se descargo
    public float volumen; //manejo de volumen

    private void OnTriggerEnter(Collider other){

        EmisorCubo.PlayOneShot(Archivo, volumen);
    }

    
}
