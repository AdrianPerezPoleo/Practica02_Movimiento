using UnityEngine;
using UnityEngine.InputSystem;

public class Ejercicio09_MovimientoConTeclasEsfera : MonoBehaviour
{
    public float speed = 0.05f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(speed * Input.GetAxis("Vertical") * Vector3.forward);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Input.GetAxis("Horizontal") * Vector3.right);
        }
    }
}
