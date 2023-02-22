using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private List<List<CellGrid>> grids = new List<List<CellGrid>>();

    public CellGrid cellGrid;
    public UITable GridTable;
    public int row = 4; // TODO


    private void Awake()
    {
        //GridTable.columns = row; 

        //Debug.Log("Table:  " + GridTable.columns);

    }

    private void Start()
    {
    }

    public void CreateEmptyGrid()
    {

    }
}
