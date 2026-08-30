using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mario : MonoBehaviour
{
    public float velocidad = 5.0f;
    public float rotacion = 20.0f;

    CharacterController controller;
    Animator animator;
    AudioSource audioSource;
    // Este método se ejecuta una sola vez al inicio de cada objeto
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();       
    


    }

    // Este método se ejecuta una vez cada cuadro (una vez cada 60vo de segundo)
    private void Update()
    {
        // El personaje no se mueve, no rota, no hace nada
        animator.SetBool("Caminando", false);
        
        // El personaje se mueve hacia adelante

        //si la tecla de flecha hacia arriba está siendo presionada, entonces haz algo
        if(Input.GetKey(KeyCode.UpArrow))
        {
            // el controlador del personaje se mueve hacia adelante, multiplicado por el tiempo que tarda cada cuadro en ejecutarse, multiplicado por la velocidad

            controller.Move(transform.forward * Time.deltaTime * velocidad);
            // establezca el animador en caminando...
            animator.SetBool("Caminando", true);
        }
        
        //si la tecla de flecha hacia la derecha está siendo presionada, entonces haz algo
        if(Input.GetKey(KeyCode.RightArrow))
        {

            Debug.Log("Rotating");
            //rote el personaje alrededor del eje vertical (arriba) multiplicado por la rotación multiplicada por el tiempo que tarda cada cuadro en ejecutarse
            transform.Rotate(transform.up, rotacion * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Rotating");
            transform.Rotate(transform.up, -rotacion * Time.deltaTime);
            
        }

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "moneda")
        {
            Destroy(other.gameObject);
            audioSource.Play();
        }
    }


}
