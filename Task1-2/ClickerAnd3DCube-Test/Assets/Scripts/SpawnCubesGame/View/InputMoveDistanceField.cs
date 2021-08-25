using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpawnCubesGame.View
{
    public class InputMoveDistanceField : InputSpawnCubesValueFieldAbstract
    {
        protected override void OnCubesSpawnDataValueChanged()
        {
            _inputField.text = _cubesSpawnController.CubeDistanceMove.ToString();
        }

        protected override void OnInputFloatValueChanged(float value)
        {
            _cubesSpawnController.CubeDistanceMove = value;
        }
    }
}