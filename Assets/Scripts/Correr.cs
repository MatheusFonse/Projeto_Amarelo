using UnityEngine;

public class Correr : MonoBehaviour
{
    public float walkSpeed = 5f;
    public float runSpeed = 9f;
    public float gravity = -9.81f;


    private CharacterController controller;
    private Vector3 velocity;


    void Start()
    {
        controller = GetComponent<CharacterController>();
    }


    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");



        bool isRunning = Input.GetKey(KeyCode.LeftShift);
        float currentSpeed = isRunning ? runSpeed : walkSpeed;


        Vector3 move = transform.right * moveX + transform.forward * moveZ;
        controller.Move(move * currentSpeed * Time.deltaTime);


        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}