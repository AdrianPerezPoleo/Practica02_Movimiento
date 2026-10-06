using UnityEngine;

public class Ejercicio08_Movimiento : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(1, 0, 1);
    public float speed = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);  // Para que inicialmente y = 0
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection.normalized * speed * Time.deltaTime, Space.World);
    }
}
