using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _Rigidbody2D;

    

    private float xSpeed;
    private float ySpeed;

    public float speed = 3;

    private string InputX = "Horizontal";
    private string InputY = "Vertical";
    private void Start()
    {
        _Rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        xSpeed = Input.GetAxis(InputX);
        ySpeed = Input.GetAxis(InputY);

        _Rigidbody2D.velocity = new Vector2(xSpeed, ySpeed) * speed;
    }

}
