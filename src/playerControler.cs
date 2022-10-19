using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerControler : MonoBehaviour
{
    [Header("Player")]
    [Tooltip("Movement of the character in m/s")]
    private float MoveSpeed = 5.0f;
    [Header("Keys to move the player")]
    public bool wasd = true;
    public bool arrows = false;

    // Start is called before the first frame update

    private float puntuacion = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (wasd) {
            if (Input.GetKey("d")) {
                gameObject.transform.Translate(MoveSpeed * Time.deltaTime, 0, 0);
            //gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(2000 * Time.deltaTime, 0, 0));
            }
            if (Input.GetKey("a")) {
                gameObject.transform.Translate(-MoveSpeed * Time.deltaTime, 0, 0);
                //gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-2000 * Time.deltaTime, 0, 0));
            }
            if (Input.GetKey("w")) {
                gameObject.transform.Translate(0, 0, MoveSpeed * Time.deltaTime);
                //gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 2000 * Time.deltaTime));
            }
            if (Input.GetKey("s")) {
                gameObject.transform.Translate(0, 0, -MoveSpeed * Time.deltaTime);
                //gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -2000 * Time.deltaTime));
            }   
        }
        if (arrows) {
            if (Input.GetKey("right")) {
                gameObject.transform.Translate(MoveSpeed * Time.deltaTime, 0, 0);
            //gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(2000 * Time.deltaTime, 0, 0));
            }
            if (Input.GetKey("left")) {
                gameObject.transform.Translate(-MoveSpeed * Time.deltaTime, 0, 0);
                //gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-2000 * Time.deltaTime, 0, 0));
            }
            if (Input.GetKey("up")) {
                gameObject.transform.Translate(0, 0, MoveSpeed * Time.deltaTime);
                //gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 2000 * Time.deltaTime));
            }
            if (Input.GetKey("down")) {
                gameObject.transform.Translate(0, 0, -MoveSpeed * Time.deltaTime);
                //gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -2000 * Time.deltaTime));
            }
        }
        if (Input.GetKeyDown("space")) {
            GameObject[] tipoA = GameObject.FindGameObjectsWithTag("tipoA");
            for (int i = 0; i < tipoA.Length; i++) {
                float distancia = Vector3.Distance(tipoA[i].transform.position, gameObject.transform.position);
                if (distancia < 10f) {
                    tipoA[i].GetComponent<typeAControler>().pushCylinder(gameObject);
                }
            }
        }
    }
    private void OnCollisionEnter(Collision collision) {
        if (collision.transform.tag == "cylinder") {
            puntuacion += 1;
            Debug.Log("Puntuacion: " + puntuacion);
        }
    }
}
