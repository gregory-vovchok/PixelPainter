using UnityEngine;

namespace ColorPicker
{
    [CreateAssetMenu(fileName = "ColorPaletteToolbarSettingsData", menuName = "Assets/ColorPaletteToolbarSettingsData")]
    public class ColorPaletteToolbarSettingsData : ScriptableObject
    {
        public int CellSize = 50;// in pixels
        public int SpacingX = 20;// in pixes
        public int SpacingY = 20;// in pixes
        public bool EnableSelectionOutlineAnimation = true;
        public float SelectionOutlineBlinkingDuration = 1f;
        public Color[] Colors;
    }
}