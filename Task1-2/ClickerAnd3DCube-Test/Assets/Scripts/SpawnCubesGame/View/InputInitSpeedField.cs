using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpawnCubesGame.View
{
    public class InputInitSpeedField : InputSpawnCubesValueFieldAbstract
    {
        protected override void OnCubesSpawnDataValueChanged()
        {
            _inputField.text = _cubesSpawnController.CubeIniSpeed.ToString();
        }

        protected override void OnInputFloatValueChanged(float value)
        {
            _cubesSpawnController.CubeIniSpeed = value;
        }
    }
}