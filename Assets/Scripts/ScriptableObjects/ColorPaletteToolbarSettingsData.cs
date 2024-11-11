using UnityEngine;

namespace ColorPicker
{
    [CreateAssetMenu(fileName = "ColorPaletteSettingsData", menuName = "Assets/ColorPaletteSettingsData")]
    public class ColorPaletteToolbarSettingsData : ScriptableObject
    {
        public int CellSize = 50;// in pixels
        public int SpacingX = 20;// in pixes
        public int SpacingY = 20;// in pixes
        public Color[] colors;
    }
}