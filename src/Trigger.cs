using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter() {
        Debug.Log("Acaba de colisionar");
    }

    private void OnTriggerStay() {
        Debug.Log("Un cuerpo está colisionando");
    }

    private void OnTriggerExit() {
        Debug.Log("Un cuerpo ha dejado de colisionar");
    }
}
