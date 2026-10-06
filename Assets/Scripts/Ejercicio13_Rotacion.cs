using UnityEditor.UI;
using UnityEngine;

public class Ejercicio13_Rotacion : MonoBehaviour
{
    public float speed = 3.0f;
    public float rotationSpeed = 30.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            transform.Rotate(rotationSpeed * Vector3.up * Input.GetAxis("Horizontal") * Time.deltaTime, Space.Self);
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(speed * transform.forward * Input.GetAxis("Vertical") * Time.deltaTime, Space.World);
        }
    }
}
