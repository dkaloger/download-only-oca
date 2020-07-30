using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class enemy_patroll : MonoBehaviour
{

    public master_tick tick;
    public Tile e_tile;
    public Tilemap e_tilemap;
    public Vector3Int a;
    public Vector3Int b;
    public Vector3Int target;
    public Vector3Int my_pos;
    public Vector3Int my_move;

    public bool can_move;
    public bool targeting_A;
    // Start is called before the first frame update
    void Start()
    {
        target = a;
        targeting_A = true;
    }

    // Update is called once per frame
    void Update()
    {
        can_move = tick.tick;


            if (my_pos.x < target.x && can_move == true)
            {
                my_move.x += 1;

            can_move = false;
            }
            if (my_pos.x > target.x && can_move == true)
            {
                my_move.x -= 1;

            can_move = false;
        }

            if (my_pos.y < target.y && can_move == true)
            {
                  my_move.y += 1;

            can_move = false;
        }
            if (my_pos.y > target.y && can_move == true)
            {
                 my_move.y -= 1;

            can_move = false;
        }

    if(my_pos == target)
        {
            if(targeting_A == true)
            {
                target = b;
            }
            if (targeting_A == false)
            {
                target = a;
            }
            targeting_A = !targeting_A;

        }
     
        e_tilemap.ClearAllTiles();
        my_pos += my_move;
        e_tilemap.SetTile(my_pos, e_tile);
        my_move = Vector3Int.zero;
    }
}
