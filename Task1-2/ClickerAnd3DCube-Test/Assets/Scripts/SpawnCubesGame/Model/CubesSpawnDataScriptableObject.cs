using System;
using UnityEngine;

namespace SpawnCubesGame.Model
{
    [CreateAssetMenu(fileName = "CubesSpawnData", menuName = "ClickerAnd3DCube-Test/CubesSpawnDataScriptableObject", order = 0)]
    public class CubesSpawnDataScriptableObject : ScriptableObject
    {
        [SerializeField] private GameObject _cubePrefab = default;
        [SerializeField] private float _spawnRate = 1f;
        [SerializeField] private float _cubeInitSpeed = 1f;
        [SerializeField] private float _cubeDistanceMove = 5f;

        public GameObject CubePrefab => _cubePrefab;

        public float SpawnRate { get => _spawnRate; set => _spawnRate = value; }
        public float CubeInitSpeed { get => _cubeInitSpeed; set => _cubeInitSpeed = value; }
        public float CubeDistanceMove { get => _cubeDistanceMove; set => _cubeDistanceMove = value; }
    }
}