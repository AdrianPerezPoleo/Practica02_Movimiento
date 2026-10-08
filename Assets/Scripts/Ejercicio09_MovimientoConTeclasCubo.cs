using UnityEngine;

public class Ejercicio09_MovimientoConTeclasCubo : MonoBehaviour
{
    public float speed = 0.05f;

    // Update is called once per frame
    void Update()
    {
        float verticalAxis = Input.GetAxis("FlechasVertical");
        float horizontalAxis = Input.GetAxis("FlechasHorizontal");

        transform.Translate(speed * verticalAxis * Vector3.forward);
        transform.Translate(speed * horizontalAxis * Vector3.right);
    }
}
