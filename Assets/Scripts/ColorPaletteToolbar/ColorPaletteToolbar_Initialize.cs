using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

namespace ColorPicker
{
    public partial class ColorPaletteToolbar
    {
        void Start()
        {
            Initialize();
        }

        public void Initialize()
        {
            Assert.IsNotNull(colorSelectionEvent, $"ColorSelectionEvent reference is missing.");
            Assert.IsNotNull(colorSamplePrefab, $"ColorSamplePrefab reference is missing.");
            Assert.IsNotNull(buttonContainer, $"ButtonContainer reference is missing.");
            Assert.IsNotNull(colorPaletteSettings, $"ColorPaletteData reference is missing.");
            Assert.IsFalse(colorPaletteSettings.Colors.Length == 0, "ColorPaletteData's colors are not defined");

            #region setup layout
            buttonContainer.spacing = new Vector2(colorPaletteSettings.SpacingX, colorPaletteSettings.SpacingY);
            #endregion

            #region color sample selection outline
            if (colorPaletteSettings.EnableSelectionOutlineAnimation)
                selectionOutline.StartBlinking(colorPaletteSettings.SelectionOutlineBlinkingDuration);

            selectionOutline.SetSize(colorPaletteSettings.CellSize, colorPaletteSettings.CellSize);
            #endregion

            #region colors
            ColorSample colorSample = null;

            for (int i = 0; i < colorPaletteSettings.Colors.Length; i++)
            {
                colorSample = Instantiate(colorSamplePrefab, buttonContainer.transform);

                colorSample.Initialize(
                    colorPaletteSettings.Colors[i], 
                    colorSelectionEvent);

                colorSample.SetSize(colorPaletteSettings.CellSize, colorPaletteSettings.CellSize);
            }
            #endregion

            SelectColor(colorSample);// by default we select the last created color sample
        }
    }
}
