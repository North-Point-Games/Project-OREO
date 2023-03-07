using UnityEngine;

public class WASDMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(horizontal, 0f, vertical) * Time.deltaTime * moveSpeed;
    }
}
