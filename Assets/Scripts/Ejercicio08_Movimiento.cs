using UnityEngine;

public class Ejercicio08_Movimiento : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(0.005f, 0, 0.005f);
    public float speed = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 initialPosition = transform.position;
        transform.position = new Vector3(initialPosition.x, 0, initialPosition.z);

        if (speed < 1f)
        {
            speed = 1.05f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection * speed, Space.Self); // Cambiar Space.Self por Space.World para el último apartado
    }
}
