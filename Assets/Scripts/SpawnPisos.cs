using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPisos : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject piso;
    public GameObject pisoConCactus;
    void Start()
    {
        StartCoroutine(InstanciarPiso());
    }

    // Update is called once per frame
    //Se llama 60 veces por segundo.
    void Update()
    {
        
    }

    private IEnumerator InstanciarPiso()
    {
        //Para Siempre...
        while (true)
        {
            /*
             * Generar un numero aleatorio entre 0 y 100
             * Si el número es menor o igual que 30
             * Entonces instanciar pisoconCactus
             * sino instanciar piso 
             */

            // Genera un entero entre 0 y 100 (incluyendo 100)
            int valor = Random.Range(0, 101);

            if (valor <= 30)
            {
                // Instanciar piso con cactus
                Instantiate(pisoConCactus, this.transform.position, this.transform.rotation);
            }
            else
            {
                // Instanciar piso normal
                Instantiate(piso, this.transform.position, this.transform.rotation);
            }

            // Espera 1 segundo antes de continuar la ejecución de la coroutine.
            // `yield return new WaitForSeconds(1);` cede el control a Unity y
            // reanuda la coroutine tras 1 segundo sin bloquear el hilo principal.
            yield return new WaitForSeconds(1);
        }
    }
}
