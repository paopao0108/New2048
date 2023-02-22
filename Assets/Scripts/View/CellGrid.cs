using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellGrid : MonoBehaviour
{
    private int _cellWidth;
    private int _cellHeight;
    private UILabel label;
    private string bgColor;
    private int _num;
    


    public int Num { get => _num;}
    public int CellWidth { get => _cellWidth; set => _cellWidth = value; }
    public int CellHeight { get => _cellHeight; set => _cellHeight = value; }

    public int cellSize = 80; // TODO

    public CellGrid(int cellWidth, int cellHeight)
    {
        //CellWidth = cellSize;
        //CellHeight = cellSize;
    }

    private void Awake()
    {
        label = GetComponentInChildren<UILabel>();
        //this.GetComponent<UIWidget>().width = CellWidth;
        //this.GetComponent<UIWidget>().height = CellHeight;
        CellHeight = this.GetComponent<UIWidget>().height;
        CellWidth = this.GetComponent<UIWidget>().width;
        Debug.Log("height  "  + CellHeight);
        //Width = GetComponent<UISprite>();
        //Debug.Log("size:   " + GetComponent<UISprite>().width);
        Debug.Log("label:  " + label.text);
        //Debug.Log(label + ", " + GetComponent<UISprite>());
        //Debug.Log(GetComponent<UISprite>().color); 
    }

    private void Start()
    {
        //label.text = "";
        CellHeight = 100;
        Debug.Log("height  " + _cellHeight);
    }



    public void ClearNumber()
    {
        label.text = "";
    }

    public void SetNumber(int num)
    {
        label.text = num.ToString();
    }

    public int GetNumber()
    {
        return int.Parse(label.text);
    }
}
