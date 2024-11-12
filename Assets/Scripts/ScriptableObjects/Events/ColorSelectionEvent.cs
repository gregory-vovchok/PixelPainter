using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ColorPicker
{
    [CreateAssetMenu(fileName = "ColorSelectionEvent", menuName = "Assets/Events/ColorSelectionEvent")]
    public class ColorSelectionEvent : ScriptableObject
    {
        public event Action<ColorSample> OnColorSelected;


        public void RaiseEvent(ColorSample colorSample)
        {
            OnColorSelected?.Invoke(colorSample);
        }
    }
}