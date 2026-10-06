using UnityEngine;

public class Ejercicio05_Desplazamiento : MonoBehaviour
{
    public Vector3 firstObjectMovement;
    public Vector3 secondObjectMovement;
    public Vector3 thirdObjectMovement;

    public Transform firstObject;
    public Transform secondObject;
    public Transform thirdObject;

    private Vector3 firstObjectInitialPosition;
    private Vector3 secondObjectInitialPosition;
    private Vector3 thirdObjectInitialPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        firstObjectInitialPosition = firstObject.position;
        secondObjectInitialPosition = secondObject.position;
        thirdObjectInitialPosition = thirdObject.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Jump") == 1)
        {
            firstObject.position = firstObjectInitialPosition + firstObjectMovement;
            secondObject.position = secondObjectInitialPosition + secondObjectMovement;
            thirdObject.position = thirdObjectInitialPosition + thirdObjectMovement;      
        }

    }
}
