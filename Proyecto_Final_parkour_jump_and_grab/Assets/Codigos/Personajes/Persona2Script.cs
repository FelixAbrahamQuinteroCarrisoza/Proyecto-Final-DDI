using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

//HERRERO
public class Persona2Script : MonoBehaviour
{
    //variables para dar al color a la pelota , si me acerco o me alejo
   
    public GameObject Textocult;
    public GameObject imgocult;
    public GameObject persona3oculta;  
    public GameObject persona1oculta; 
    
         

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
        persona3oculta.gameObject.SetActive(true);        
        persona1oculta.gameObject.SetActive(false);             
    }

    void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        
        //Dar color cuando se aleje, y que el usuario lo pueda colocar el color que quiera
        //render = GetComponent<Renderer>();
        //render.material.color = AlejarColor;

        //Debug.Log("Salió en el área");
        //isInsideZone = false;
        
        //aparece la imagen y el texto de cuando nos acercamos al objeto a recoger
        Textocult.gameObject.SetActive(false);
        imgocult.gameObject.SetActive(false);
        //imageOcult.gameObject.SetActive(false);
        
    }

     public virtual void Interact()
    {
         
    }   
}
