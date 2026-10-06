using UnityEngine;
using UnityEngine.InputSystem;

public class Ejercicio09_MovimientoConTeclasCubo : MonoBehaviour
{
    public float speed = 0.05f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(speed * Input.GetAxis("Vertical") * Vector3.forward);
        } 
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Input.GetAxis("Horizontal") * Vector3.right);
        }
    }
}
