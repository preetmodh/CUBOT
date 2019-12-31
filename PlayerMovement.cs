using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;


    void FixedUpdate()
    {

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector3 TouchPosition = Input.GetTouch(0).deltaPosition;
            transform.Translate(TouchPosition.x * sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
