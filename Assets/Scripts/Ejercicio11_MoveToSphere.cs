using UnityEngine;

public class Ejercicio11_MoveToSphere : MonoBehaviour
{
    private Vector3 moveDirection;
    public float speed = 2f;

    // Update is called once per frame
    void Update()
    {
        Vector3 spherePosition = GameObject.FindWithTag("sphere").transform.position;
        Vector3 cubePosition = transform.position;
        moveDirection = spherePosition - cubePosition;
        moveDirection.y = 0;  // Para no modificar la altura
        transform.Translate(moveDirection.normalized * speed * Time.deltaTime);
    }
}
