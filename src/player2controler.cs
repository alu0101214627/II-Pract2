using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2controler : MonoBehaviour
{
    private float MoveSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("l")) {
                gameObject.transform.Translate(MoveSpeed * Time.deltaTime, 0, 0);
            //gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(2000 * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey("j")) {
            gameObject.transform.Translate(-MoveSpeed * Time.deltaTime, 0, 0);
            //gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-2000 * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey("i")) {
            gameObject.transform.Translate(0, 0, MoveSpeed * Time.deltaTime);
            //gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 2000 * Time.deltaTime));
        }
        if (Input.GetKey("m")) {
            gameObject.transform.Translate(0, 0, -MoveSpeed * Time.deltaTime);
            //gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -2000 * Time.deltaTime));
        }
    }
}
