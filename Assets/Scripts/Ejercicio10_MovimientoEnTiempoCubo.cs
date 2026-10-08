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
        float verticalAxis = Input.GetAxis("FlechasVertical");
        float horizontalAxis = Input.GetAxis("FlechasHorizontal");

        transform.Translate(speed * verticalAxis * Vector3.forward * Time.deltaTime);
        transform.Translate(speed * horizontalAxis * Vector3.right * Time.deltaTime);
    }
}
