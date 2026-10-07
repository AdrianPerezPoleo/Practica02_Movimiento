using UnityEngine;

public class Ejercicio06_Velocidad : MonoBehaviour
{
    public int velocity;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log($"Up Arrow. Velocity: {velocity} * {Input.GetAxis("Vertical")} = {velocity * Input.GetAxis("Vertical")}");
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log($"Down Arrow. Velocity:{velocity} * {Input.GetAxis("Vertical")} = {velocity * Input.GetAxis("Vertical")}");
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log($"Left Arrow. Velocity:{velocity} * {Input.GetAxis("Horizontal")} = {velocity * Input.GetAxis("Horizontal")}");
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log($"Right Arrow. Velocity:{velocity} * {Input.GetAxis("Horizontal")} = {velocity * Input.GetAxis("Horizontal")}");
        }
    }
}
