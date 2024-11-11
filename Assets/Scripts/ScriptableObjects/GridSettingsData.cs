using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ColorPicker
{
    [CreateAssetMenu(fileName = "GridSettingsData", menuName = "Assets/GridSettingsData")]
    public class GridSettingsData : ScriptableObject
    {
        public int Rows = 10;
        public int Columns = 10;
        public float CellSize = 1.0f;
        public float Spacing = 0.1f;
    }
}
