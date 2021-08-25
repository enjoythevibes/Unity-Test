using System;
using System.Collections;
using System.Collections.Generic;
using ClickerGame.Controller;
using UnityEngine;
using UnityEngine.UI;

namespace ClickerGame.View
{
    public class ClickerButton : MonoBehaviour
    {
        [SerializeField] private ClickerGameController _clickerGameController = default;

        private void Awake()
        {
            GetComponent<Button>().onClick.AddListener(OnButtonClicked);
        }

        private void OnButtonClicked()
        {
            _clickerGameController.OnClickerButtonClicked();
        }
    }
}