using UnityEngine;

public class Colision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
       private void Start()
    {
    }

    private void OnCollisionEnter(Collision collisioncactus)
    {
        if (collisioncactus.gameObject.CompareTag("Cactus"))
        {
            Debug.Log("Game Over");
            // Aquí puedes agregar la lógica que quieras ejecutar cuando el dinosaurio colisione con un cactus
        }
       
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
