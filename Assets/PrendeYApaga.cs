using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrendeYApaga : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    float accum;
    void Update()
    {
        accum+= Time.deltaTime;
        if (accum > 0.1f)
        {
            accum = 0;
            
            this.gameObject.GetComponent<Light>().enabled = !this.gameObject.GetComponent<Light>().enabled;

        }
    }
}
