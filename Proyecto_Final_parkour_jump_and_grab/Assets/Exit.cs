using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

//SABIO1
public class Exit : MonoBehaviour
{
    //variables para dar al color a la pelota , si me acerco o me alejo
   
    public GameObject Textocult;
    public GameObject imgocult;
   

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }

        //Dar color cuando se acerque, y que el usuario lo pueda colocar el color que quiera
        //render = GetComponent<Renderer>();
        //render.material.color = AcercarColor;


        //Debug.Log("Entró en el área");
        //isInsideZone = true;
        
        //Oculta la imagen y el texto de cuando nos alejamos del objeto a recoger
        Textocult.gameObject.SetActive(true);
        imgocult.gameObject.SetActive(true);
        //imageOcult.gameObject.SetActive(true);
         
    }

    void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        
        //aparece la imagen y el texto de cuando nos acercamos al objeto a recoger
        Textocult.gameObject.SetActive(false);
        imgocult.gameObject.SetActive(false);

        Debug.Log("Salió del juego");
        Application.Quit();
    }

    

     public virtual void Interact()
    {
         
    }   
}
