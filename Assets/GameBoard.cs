using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameBoard : MonoBehaviour
{
    Tile[] tiles = new Tile[64];
    int[] pieces = {0,1,2,3,4,5,6};
    bool player_turn;
    bool white_check;
    bool black_check;

    // Start is called before the first frame update
    void Start()
    {
        populate_board();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    private void populate_board()
    {
        tiles[0] = new Tile(1, 0, 2, 0);
    }

    // private string get_piece_at(int row, int col)
    // {

    // }

    // private string set_piece_at(int row, int col)
    // {
        
    // }

    private void calculate_checks()
    {

    }

    private void update_pieces()
    {

    }
}
