using UnityEngine;

public class Ejercicio10_MovimientoEnTiempoEsfera : MonoBehaviour
{
    public float speed = 2f;
    
    // Update is called once per frame
    void Update()
    {
        float verticalAxis = Input.GetAxis("WSVertical");
        float horizontalAxis = Input.GetAxis("ADHorizontal");

        transform.Translate(speed * verticalAxis * Vector3.forward * Time.deltaTime);
        transform.Translate(speed * horizontalAxis * Vector3.right * Time.deltaTime);
    }
}
