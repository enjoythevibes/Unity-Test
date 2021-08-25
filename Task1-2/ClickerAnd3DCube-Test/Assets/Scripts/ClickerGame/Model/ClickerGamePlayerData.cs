using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClickerGame.Model
{
    public class ClickerGamePlayerData
    {
        private int _playerScore;
        public int PlayerScore { get => _playerScore; set => _playerScore = value; }

        public ClickerGamePlayerData(int defaultPlayerScore)
        {
            _playerScore = defaultPlayerScore;
        }
    }
}