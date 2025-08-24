using UnityEngine;

public class BoatMovement : MonoBehaviour
{
    public float speed = 10f;
    public float limit = 8f; // How far boat can move

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        //Vector3 newPos = transform.position + new Vector3(horizontal * speed * Time.deltaTime, 0, 0);
        transform.Translate(Vector3.left * horizontal * speed * Time.deltaTime, Space.World);
        // Clamp position so boat doesn't go off-screen
        //ewPos.x = Mathf.Clamp(newPos.x, -limit, limit);
        ///transform.position = newPos;
    }
}
