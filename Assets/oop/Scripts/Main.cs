using UnityEngine;

namespace oop.Scripts
{
    public class Main : MonoBehaviour
    {
        private AsteroidManager _asteroidManager;

        private void Start()
        {
            _asteroidManager = new AsteroidManager(100);
        }

        private void Update()
        {
            _asteroidManager.Update(Time.deltaTime);
        }
    }
}