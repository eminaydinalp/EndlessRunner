using System;
using TMPro;
using UnityEngine;

namespace _Game.Scripts.Concrates.Uis
{
    public class TimeCounter : MonoBehaviour
    {
        private TMP_Text _timeText;

        private float _currentTime;


        private void Awake()
        {
            _timeText = GetComponent<TMP_Text>();
        }

        private void Update()
        {
            _currentTime += Time.deltaTime;

            _timeText.text = _currentTime.ToString("0");
        }
    }
}
