using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using SpawnCubesGame.Model;
using System;
using SpawnCubesGame.Controller;

namespace SpawnCubesGame.View
{
    public abstract class InputSpawnCubesValueFieldAbstract : MonoBehaviour
    {
        [SerializeField] protected CubesSpawnController _cubesSpawnController = default;
        [SerializeField] protected TMP_InputField _inputField = default;

        protected virtual void Start()
        {
            _cubesSpawnController.OnSpawnDataValueChanged += OnCubesSpawnDataValueChanged;
            _inputField.onEndEdit.AddListener(OnInputValueChanged);
        }

        protected virtual void OnInputValueChanged(string inputValue)
        {
            var floatValueParsed = float.TryParse(inputValue, out var floatValue);
            if (floatValueParsed)
            {
                OnInputFloatValueChanged(floatValue);             
            }
            else
            {
                Debug.LogError($"{GetType()} float.TryParse failed {inputValue}");
            }
        }

        protected abstract void OnInputFloatValueChanged(float value);

        protected abstract void OnCubesSpawnDataValueChanged();
    }
}