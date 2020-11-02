using UnityEngine;
using System.Collections;

namespace JP.Gameplay
{
    public class Oscilator : MonoBehaviour
    {
        public float smoothTime;
        public float maxDisplacement;

        private Vector3 initialPosition;
        // Use this for initialization
        void Start()
        {
            initialPosition = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            float movement = Mathf.PingPong( Time.time * smoothTime, maxDisplacement);
            transform.position = initialPosition +( Vector3.up  * movement);
        }
    }
}