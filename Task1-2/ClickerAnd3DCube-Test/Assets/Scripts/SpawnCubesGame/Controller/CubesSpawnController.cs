using System;
using System.Collections;
using System.Collections.Generic;
using SpawnCubesGame.Model;
using UnityEngine;

namespace SpawnCubesGame.Controller
{
    public class CubesSpawnController : MonoBehaviour
    {
        [SerializeField] private CubesSpawnDataScriptableObject _cubesSpawnData = default;
        private WaitForSeconds _waitForSeconds;
        private bool _timerActive;
        private Coroutine _currentSpawnTimer;

        public float SpawnRate
        {
            get => _cubesSpawnData.SpawnRate; 
            set
            {
                if (value > 0)
                {
                    _cubesSpawnData.SpawnRate = value;
                    _waitForSeconds = new WaitForSeconds(value);
                    StopSpawnTimer();
                    StartSpawnTimer();
                }
                OnSpawnDataValueChanged?.Invoke();
            }
        }
        public float CubeIniSpeed
        {
            get => _cubesSpawnData.CubeInitSpeed; 
            set
            {
                if (value > 0)
                {
                    _cubesSpawnData.CubeInitSpeed = value;
                }
                OnSpawnDataValueChanged?.Invoke();
            }
        }
        public float CubeDistanceMove
        {
            get => _cubesSpawnData.CubeDistanceMove; 
            set
            {
                if (value > 0)
                {
                    _cubesSpawnData.CubeDistanceMove = value;
                }
                OnSpawnDataValueChanged?.Invoke();
            }
        }

        public event Action OnSpawnDataValueChanged;

        private void Awake()
        {
            _cubesSpawnData = Instantiate(_cubesSpawnData);
        }

        private void Start()
        {
            _timerActive = true;
            _waitForSeconds = new WaitForSeconds(_cubesSpawnData.SpawnRate);
            StartSpawnTimer();
            OnSpawnDataValueChanged?.Invoke();
        }

        private void StartSpawnTimer()
        {
            _currentSpawnTimer = StartCoroutine(SpawnCubesTimer());                        
        }

        private void StopSpawnTimer()
        {
            StopCoroutine(_currentSpawnTimer);
        }

        private IEnumerator SpawnCubesTimer()
        {
            while (_timerActive)
            {
                SpawnCube();
                yield return _waitForSeconds;
            }
            yield break;
        }

        private void SpawnCube()
        {
            var cubeInstance = Instantiate(_cubesSpawnData.CubePrefab, transform.position, Quaternion.identity);
            cubeInstance.GetComponent<CubeMovement>().Init(new CubeMovementData(_cubesSpawnData.CubeInitSpeed, _cubesSpawnData.CubeDistanceMove));
        }
    }
}