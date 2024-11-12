using DG.Tweening;
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
        [SerializeField] ColorSampleSelectionOutline selectionOutline;
        ColorSample selectedColorSample;

        public Color SelectedColor { get => selectedColorSample.Color; }


        public void SelectColor(ColorSample colorSample)
        {
            selectedColorSample = colorSample;

            selectionOutline.SetParent(colorSample);
        }
    }
}