using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class astar_to_tile : MonoBehaviour
{
    public AIPath a_star;
    public master_tick tick;
    public GridLayout gridLayout;
    public Vector3Int player_location;

    public Tilemap player_tilemap;
    public Tile player_tile;


    public Vector3Int old_cell;


    public bool can_move;
    public int placed_cells;
 //   public Vector3 enemy_location;
    public bool test_can_move;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void go()
    {
        test_can_move = true;
    }
    // Update is called once per frame
    void Update()
    {
        a_star.canMove = test_can_move;
        can_move = tick.tick;

        old_cell = player_location;
        player_location= gridLayout.WorldToCell(transform.position);

        if (can_move == true)
        {
            player_tilemap.ClearAllTiles();
            player_tilemap.SetTile(player_location, player_tile);
        }
    
        if (old_cell != player_location)
        {
            test_can_move = false;
        }

     
    }
}
