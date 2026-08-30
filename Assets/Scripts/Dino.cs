using UnityEngine;

public class Dino : MonoBehaviour
{
    public bool estaSaltando = false;
    public float AlturaMin = 0.2f; //La altura en la que se considera aterrizado
    ParticleSystem particulasEstrellas;
    public float gravedad = -9.8f;
    public float velocidadSalto = 8.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Al dinosaurio en la posición inicial donde Y es la altura mínima 
        //transform = "Mi objeto transform". (se refiere al componente Transform de este objeto de juego)
        //this.transform = "El objeto transform de este objeto que está corriendo este método"
        this.transform.position = new Vector3(this.transform.position.x, AlturaMin, this.transform.position.z);
        estaSaltando = false;//Inicia aterrizado (no saltando)
    }

    // Update is called once per frame
    void Update()
    {
        //Al presionar la tecla espacio, se inicia a saltar. 
        if (Input.GetKeyDown(KeyCode.Space) && !estaSaltando)
        {
            //Se inicia el salto
            estaSaltando = true;  
                   
        }

        //Si el dinosaurio está saltando, invocar el método saltar. 
        if(estaSaltando)
        {
            Saltar();
        }
        
    }

    void Saltar()
    {
        //Se calcula la nueva posición del dinosaurio en Y, sumando la velocidad de salto multiplicada por el tiempo que tarda cada cuadro en ejecutarse
        float nuevaPosicionY = this.transform.position.y + (velocidadSalto * Time.deltaTime);
        //Se calcula la nueva posición del dinosaurio en Y, sumando la gravedad multiplicada por el tiempo que tarda cada cuadro en ejecutarse
        velocidadSalto += (gravedad * Time.deltaTime);
        //Se establece la nueva posición del dinosaurio en Y
        this.transform.position = new Vector3(this.transform.position.x, nuevaPosicionY, this.transform.position.z);

        //Si la nueva posición del dinosaurio es menor o igual a la altura mínima, se considera aterrizado
          Debug.Log("Posición Y: " + this.transform.position.y); 
        if (this.transform.position.y <= AlturaMin)
        {
            //Se establece la posición del dinosaurio en la altura mínima
            this.transform.position = new Vector3(this.transform.position.x, AlturaMin, this.transform.position.z);
            estaSaltando = false; //Se considera aterrizado
            velocidadSalto = 8.0f; //Se reinicia la velocidad de salto
        }
        
    }
}
