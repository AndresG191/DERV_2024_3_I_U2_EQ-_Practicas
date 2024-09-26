using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class S3_CambioEscena : MonoBehaviour
{
    // Start is called before the first frame update
    
    // Update is called once per frame
    public void cambioEscena(){
        SceneManager.LoadScene(5);
    }
}
