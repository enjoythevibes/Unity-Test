using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpawnCubesGame.View
{
    public class InputSpawnRateField : InputSpawnCubesValueFieldAbstract
    {
        protected override void OnCubesSpawnDataValueChanged()
        {
            _inputField.text = _cubesSpawnController.SpawnRate.ToString();
        }

        protected override void OnInputFloatValueChanged(float value)
        {
            _cubesSpawnController.SpawnRate = value;       
        }
    }
}