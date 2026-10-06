using UnityEngine;

public class Ejercicio10_MovimientoEnTiempoEsfera : MonoBehaviour
{
    public float speed = 2f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(speed * Input.GetAxis("Vertical") * Vector3.forward * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Input.GetAxis("Horizontal") * Vector3.right * Time.deltaTime);
        }
    }
}
