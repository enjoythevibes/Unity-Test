using System;
using System.Collections;
using System.Collections.Generic;
using ClickerGame.Model;
using UnityEngine;

namespace ClickerGame.Controller
{
    public class ClickerGameController : MonoBehaviour
    {
        [SerializeField] private int _scoresPerClick = 1;
        private ClickerGamePlayerData _clickerGamePlayerData;

        public event Action<int> OnPlayerScoreValueChanged;

        private void Awake()
        {
            _clickerGamePlayerData = new ClickerGamePlayerData(0);
        }

        private void Start()
        {
            OnPlayerScoreValueChanged?.Invoke(_clickerGamePlayerData.PlayerScore);
        }

        public void OnClickerButtonClicked()
        {
            _clickerGamePlayerData.PlayerScore += _scoresPerClick;
            OnPlayerScoreValueChanged?.Invoke(_clickerGamePlayerData.PlayerScore);
        }
    }
}