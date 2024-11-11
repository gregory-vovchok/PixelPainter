using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

namespace ColorPicker
{
    public partial class ColorPaletteToolbar : MonoBehaviour
    {
        [SerializeField] ColorPaletteToolbarSettingsData colorPaletteSettings;

        #region events
        [SerializeField] ColorSelectionEvent colorSelectionEvent;
        #endregion

        [SerializeField] ColorButton colorButtonPrefab;
        [SerializeField] GridLayoutGroup buttonContainer;

        public Color SelectedColor { get; set; }



        void OnEnable()
        {
            if (colorSelectionEvent != null)
            {
                colorSelectionEvent.OnColorSelected += OnColorSelected;
            }
        }

        void OnDisable()
        {
            if (colorSelectionEvent != null)
            {
                colorSelectionEvent.OnColorSelected -= OnColorSelected;
            }
        }

        void OnColorSelected(Color color)
        {
            Debug.Log($"OnColorSelected: {color.GetHashCode()}");

            SelectedColor = color;
        }
    }
}