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
        [SerializeField] GridHistoryManager historyManager;
        public GridHistoryManager HistoryManager { get => historyManager; }

        #region events
        [SerializeField] ColorSelectionEvent colorSelectionEvent;
        #endregion

        [SerializeField] ColorSample colorSamplePrefab;
        [SerializeField] GridLayoutGroup buttonContainer;


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

        void OnColorSelected(ColorSample colorSample)
        {
            Debug.Log($"OnColorSelected: {colorSample.Color.GetHashCode()}");

            SelectColor(colorSample);
        }
    }
}