using UnityEngine;

namespace oop.Scripts
{
    public class Ship : MonoBehaviour
    {
        private Transform _transform;
        private Transform _child;
        private Vector3 _velocity;
        private float _rotation;
        private Camera _camera;

        private void Start()
        {
            // Cache transform for faster access
            _transform = transform;
            _child = transform.GetChild(0);
            _velocity = Vector3.zero;
            _rotation = 0f;
            _camera = Camera.main;
        }

        private void Update()
        {
            _child.LookAt(_camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 30f)));

            _velocity -= _velocity / 200f;

            if (Input.GetKey(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                _velocity += Vector3.forward * Time.deltaTime * 4f;
            }

            if (Input.GetKey(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                _velocity += Vector3.left * Time.deltaTime * 4f;
            }

            if (Input.GetKey(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                _velocity += Vector3.back * Time.deltaTime * 4f;
            }

            if (Input.GetKey(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                _velocity += Vector3.right * Time.deltaTime * 4f;
            }

            _transform.Translate(_velocity * Time.deltaTime * 10f);
        }
    }
}