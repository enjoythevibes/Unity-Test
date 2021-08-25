using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using ClickerGame.Controller;

namespace ClickerGame.View
{
    public class ScoreValueField : MonoBehaviour
    {
        [SerializeField] private ClickerGameController _clickerGameController = default;
        [SerializeField] private TextMeshProUGUI _scoreField = default;
        private string _scoreFieldFormat;

        private void Start()
        {
            _clickerGameController.OnPlayerScoreValueChanged += OnScoreValueChanged;
            _scoreFieldFormat = _scoreField.text;            
        }

        private void OnScoreValueChanged(int value)
        {
            _scoreField.text = string.Format(_scoreFieldFormat, value);
        }
    }
}