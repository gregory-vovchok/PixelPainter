using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

namespace ColorPicker
{
    public partial class ColorPalette : MonoBehaviour
    {
        void Start()
        {
            Initialize();
        }

        public void Initialize()
        {
            Assert.IsNotNull(colorSelectionEvent, $"ColorSelectionEvent reference is missing.");
            Assert.IsNotNull(colorButtonPrefab, $"ColorButtonPrefab reference is missing.");
            Assert.IsNotNull(buttonContainer, $"ButtonContainer reference is missing.");
            Assert.IsNotNull(colorPaletteSettings, $"ColorPaletteData reference is missing.");
            Assert.IsFalse(colorPaletteSettings.colors.Length == 0, "ColorPaletteData's colors are not defined");

            #region setup layout
            buttonContainer.spacing = colorPaletteSettings.Spacing;
            #endregion

            #region colors
            for (int i = 0; i < colorPaletteSettings.colors.Length; i++)
            {
                var colorButton = Instantiate(colorButtonPrefab, buttonContainer.transform);

                var color = colorPaletteSettings.colors[i];
                colorButton.Initialize(color, colorSelectionEvent);
                colorButton.SetSize(colorPaletteSettings.CellSize, colorPaletteSettings.CellSize);
            }
            #endregion

            SelectedColor = colorPaletteSettings.colors[0];
        }
    }
}
