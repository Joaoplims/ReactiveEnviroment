using UnityEngine;
using System.Collections;

namespace Assets.Scripts.Gameplay
{
    public class CharacterMovemment : MonoBehaviour
    {
        [SerializeField, Range(0f, 20f)] private float maxSpeed = 10f;
        private Vector3 acceleration = new Vector3();
        private Vector3 velocity = new Vector3();
        private Rigidbody rb;
        private Vector2 playerInput = new Vector2();
        private bool jump = false;
        private void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            playerInput.x = Input.GetAxis("Horizontal");
            playerInput.y = Input.GetAxis("Vertical");

        }

        private void FixedUpdate()
        {
            playerInput = Vector2.ClampMagnitude(playerInput, 1f);
            acceleration.x = playerInput.x;
            acceleration.z = playerInput.y;
            acceleration.y = 0f;
            acceleration *= maxSpeed;
            velocity += acceleration * Time.deltaTime;
            rb.velocity = velocity;
        }

 
    }   
}