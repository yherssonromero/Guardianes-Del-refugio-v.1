using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goomba : MonoBehaviour
{
    //Atributos 
    public float velocidad = 5.0f;
    //sustantivos que dan a entender características
    //se escriben en minúscula

    public float altura;
    //cuando hay varias palabras, se escribe con mayúscula cada palabra excepto la primera
    Color colorDeLaRopa;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * velocidad * Time.deltaTime);
    }
    //se escribe inicialmente con mayúscula, es un verbo en infitivo que da a entender una acción
    void Atacar()
    {

    }


}
