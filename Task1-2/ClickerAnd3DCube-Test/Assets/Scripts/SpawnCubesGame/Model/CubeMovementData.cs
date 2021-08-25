using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpawnCubesGame.Model
{
    public class CubeMovementData
    {
        private float _movementSpeed;
        private float _moveDistance;

        public float MovementSpeed => _movementSpeed;
        public float MoveDistance => _moveDistance;

        public CubeMovementData(float movementSpeed, float moveDistance)
        {
            _movementSpeed = movementSpeed;
            _moveDistance = moveDistance;
        }
    }
}