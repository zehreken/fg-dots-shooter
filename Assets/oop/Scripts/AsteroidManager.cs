using System.Collections.Generic;
using Common.MiniPool;
using UnityEngine;

namespace oop.Scripts
{
    public class AsteroidManager
    {
        private uint _maxAsteroids;
        private List<Asteroid> _asteroids;

        public AsteroidManager(uint maxAsteroids)
        {
            _maxAsteroids = maxAsteroids;
            _asteroids = new List<Asteroid>((int) _maxAsteroids);

            for (int i = 0; i < _maxAsteroids; i++)
            {
                var asteroidView = MiniPool.Create(PrefabName.Asteroid, Vector3.zero);
                var asteroid = new Asteroid(asteroidView);
                _asteroids.Add(asteroid);
            }
        }

        public void Update(float deltaTime)
        {
            foreach (var asteroid in _asteroids)
            {
                asteroid.Update(deltaTime);
            }
        }
    }
}