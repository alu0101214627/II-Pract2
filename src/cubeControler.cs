using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeControler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.transform.tag == "Player") {
            gameObject.transform.localScale -= new Vector3(1f, 1f, 1f);
        }
        if (collision.transform.tag == "esfera") {
            gameObject.transform.localScale += new Vector3(1f, 1f, 1f);
        }
    }
}
