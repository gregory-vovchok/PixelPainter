using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ColorPicker
{
    [CreateAssetMenu(fileName = "ColorPaletteSettingsData", menuName = "Assets/ColorPaletteSettingsData")]
    public class ColorPaletteSettingsData : ScriptableObject
    {
        public int CellSize = 50;// in pixels
        public int Spacing = 20;// in pixes
        public Color[] colors;
    }
}