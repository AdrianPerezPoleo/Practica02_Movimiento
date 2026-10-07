using UnityEngine;

public class Ejercicio05_Desplazamiento : MonoBehaviour
{
    public Vector3 objectMovement;

    public Transform objectTransform;

    private Vector3 initialPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialPosition = objectTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Jump") == 1)
        {
            objectTransform.position = initialPosition + objectMovement;   
        }

    }
}
