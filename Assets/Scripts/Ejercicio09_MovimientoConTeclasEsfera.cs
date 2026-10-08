using UnityEngine;
using UnityEngine.InputSystem;

public class Ejercicio09_MovimientoConTeclasEsfera : MonoBehaviour
{
    public float speed = 0.05f;
    
    // Update is called once per frame
    void Update()
    {
        float verticalAxis = Input.GetAxis("WSVertical");
        float horizontalAxis = Input.GetAxis("ADHorizontal");

        transform.Translate(speed * verticalAxis * Vector3.forward);
        transform.Translate(speed * horizontalAxis * Vector3.right);
    }
}
