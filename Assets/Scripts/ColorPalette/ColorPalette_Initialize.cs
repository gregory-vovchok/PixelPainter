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
        public static int SupportedNumberOfColors = 18;


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
            buttonContainer.spacing = new Vector2(colorPaletteSettings.SpacingX, colorPaletteSettings.SpacingY);
            #endregion

            #region colors
            for (int i = 0; i < colorPaletteSettings.colors.Length; i++)
            {
                if ((i + 1) > SupportedNumberOfColors)
                {
                    Debug.LogWarning($"<color=yellow>We support up to {SupportedNumberOfColors} colors!</color>");
                    break;
                }

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
