using UnityEngine;

namespace oop.Scripts
{
    public class Asteroid
    {
        private Transform _transform;
        private Vector3 _velocity;
        private float _velocityFactor;

        public Asteroid(GameObject view)
        {
            _transform = view.transform;
            _velocity = new Vector3(Random.Range(-1f, 1f), 0f, Random.Range(-1f, 1f));
            _velocityFactor = 10f; // Random.Range(0f, 100f);
        }

        public void Update(float deltaTime)
        {
            _transform.Translate(_velocity * deltaTime * _velocityFactor);
        }
    }
}