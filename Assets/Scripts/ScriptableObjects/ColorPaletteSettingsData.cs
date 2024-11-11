using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ColorPicker
{
    [CreateAssetMenu(fileName = "ColorPaletteSettingsData", menuName = "Assets/ColorPaletteSettingsData")]
    public class ColorPaletteSettingsData : ScriptableObject
    {
        public Color[] colors;
    }
}