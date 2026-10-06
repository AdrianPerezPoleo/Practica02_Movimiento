using UnityEngine;

public class Ejercicio12_LookAt : MonoBehaviour
{
    private Transform sphereTransform;
    public float speed = 1f;

    void Start()
    {
        sphereTransform = GameObject.FindWithTag("sphere").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 spherePosition = sphereTransform.position;
        Vector3 cubePosition = transform.position;
        Vector3 moveDirection = spherePosition - cubePosition;
        moveDirection.y = 0;  // Para no modificar la altura
        transform.LookAt(sphereTransform);
        transform.Translate(moveDirection.normalized * speed * Time.deltaTime, Space.World);
    }
}
