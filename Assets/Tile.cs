using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    GamePiece gamepiece;
    int piece;
    int color;
    int row;
    int col;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Tile(int p=0, int c=0, int ro=0, int co=0)
    {
        piece = p;
        color = c;
        row = ro;
        col = co;
    }

    // private bool is_at_position(int row, int col)
    // {

    // }

    // private int get_piece()
    // {

    // }

    // private bool get_color()
    // {

    // }

    private void set_tile(int piece, bool color)
    {

    }
}
