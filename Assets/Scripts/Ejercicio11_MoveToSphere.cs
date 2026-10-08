using UnityEngine;

public class Ejercicio11_MoveToSphere : MonoBehaviour
{
    private Vector3 moveDirection;
    private Transform sphereTransform;
    public float speed = 2f;
 
    void Start()
    {
        sphereTransform = GameObject.FindWithTag("sphere").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cubePosition = transform.position;
        moveDirection = sphereTransform.position - cubePosition;
        moveDirection.y = 0;  // Para no modificar la altura
        transform.Translate(moveDirection.normalized * speed * Time.deltaTime);
    }
}
