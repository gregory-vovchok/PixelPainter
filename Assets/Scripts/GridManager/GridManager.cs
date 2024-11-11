using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ColorPicker
{
    public class GridManager : MonoBehaviour
    {
        [SerializeField] GridCell cellPrefab;
        [SerializeField] Transform cellContainer;
        [SerializeField] GridSettingsData gridSettings;


        void Start()
        {
            GenerateGrid();
        }

        void GenerateGrid()
        {
            Vector2 startPos = new Vector2(
                -gridSettings.Columns / 2f * (gridSettings.CellSize + gridSettings.Spacing), 
                -gridSettings.Rows / 2f * (gridSettings.CellSize + gridSettings.Spacing));

            for (int i = 0; i < gridSettings.Rows; i++)
            {
                for (int j = 0; j < gridSettings.Columns; j++)
                {
                    Vector2 position = startPos + new Vector2(
                        j * (gridSettings.CellSize + gridSettings.Spacing), 
                        i * (gridSettings.CellSize + gridSettings.Spacing));

                    var cell = Instantiate(
                        cellPrefab, 
                        position, 
                        Quaternion.identity,
                        cellContainer);

                    cell.SetScale(gridSettings.CellSize);
                }
            }
        }
    }
}