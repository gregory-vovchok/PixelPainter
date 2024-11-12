using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ColorPicker
{
    public class SimpleButton : MonoBehaviour
    {
        [SerializeField] Button button;
        public bool Interactable { get => button.interactable; set => button.interactable = value; }
        public event Action OnClick;


        void Start()
        {
            button.onClick.AddListener(() => OnClick?.Invoke());
        }
    }
}
