using System.Collections;
using System.Collections.Generic;
using SpawnCubesGame.Model;
using UnityEngine;

namespace SpawnCubesGame.Controller
{
    public class CubeMovement : MonoBehaviour
    {
        [SerializeField] private DestroyObjectAnimDataScriptableObject _destroyCubeAnimData = default;
        private CubeMovementData _cubeData;
        private float _distancePassed;
        
        public void Init(CubeMovementData cubeData)
        {
            _cubeData = cubeData;
        }

        private void Update()
        {
            var movementVector = transform.forward * _cubeData.MovementSpeed * Time.deltaTime;
            _distancePassed += movementVector.magnitude;
            if (_distancePassed >= _cubeData.MoveDistance)
            {
                gameObject.AddComponent<ObjectDestroyer>().Init(_destroyCubeAnimData);
                enabled = false;
                return;
            }
            transform.Translate(movementVector);
        }
    }
}