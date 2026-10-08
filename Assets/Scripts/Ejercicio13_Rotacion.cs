using UnityEditor.UI;
using UnityEngine;

public class Ejercicio13_Rotacion : MonoBehaviour
{
    public float speed = 3.0f;
    public float rotationSpeed = 30.0f;

    // Update is called once per frame
    void Update()
    {
        float horizontalAxis = Input.GetAxis("Horizontal");
        float verticalAxis = Input.GetAxis("Vertical");
        transform.Rotate(rotationSpeed * transform.up * horizontalAxis * Time.deltaTime);
        transform.Translate(speed * Vector3.forward * verticalAxis * Time.deltaTime);
        Debug.DrawRay(transform.position, transform.forward * 2, Color.red);
    }
}
