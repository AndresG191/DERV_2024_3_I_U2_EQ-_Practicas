using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ColectorObj : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI cont1;
    public int contador;
    void Start()
    {
        contador = 0;
    }

    // Update is called once per frame
   private void OnCollisionEnter(Collision other){
        GameObject objeto = other.gameObject;
        //if (objeto.name != "Plane" && objeto.name !="Muro" && objeto.name !="Muro2")
        if (objeto.CompareTag("ConoMalo")){
            Destroy(objeto);
            contador++;
            cont1.text = contador.ToString();
           
        }
    }
}
