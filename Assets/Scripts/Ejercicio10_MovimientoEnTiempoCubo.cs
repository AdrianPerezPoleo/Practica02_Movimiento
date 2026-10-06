using UnityEngine;

public class Ejercicio10_MovimientoEnTiempoCubo : MonoBehaviour
{
    public float speed = 2f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(speed * Input.GetAxis("Vertical") * Vector3.forward * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Input.GetAxis("Horizontal") * Vector3.right * Time.deltaTime);
        }
    }
}
