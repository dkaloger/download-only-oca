using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

using System;
public class player : MonoBehaviour
{
   
    public    Vector3Int player_location;
    public Vector3Int move;
    public Tilemap player_tilemap;
    public Tile player_tile;
    public astar_to_tile t;
    public master_tick ti;

    bool iswalkable;
   public Tilemap obstacles;
    player p;
    public Tile[] nonwalkable_tiles;
    public int size;
    public GridLayout gridLayout;
    private bool cooldown = false;
    // Start is called before the first frame update
    void Start()
    {
     //   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void ResetCooldown()
    {
        cooldown = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position  =gridLayout.CellToWorld(player_location);

        if (Input.GetKeyDown(KeyCode.A))
        {

           
            if (cooldown == false)
            {
                move.y -= 1;
                ti.tick = true;
                t.go();
                Invoke("ResetCooldown", 0.25f);
                cooldown = true;
                  
}


        }
        if (Input.GetKeyDown(KeyCode.D))
        {
         
            if (cooldown == false)
            {
                move.y += 1;
                ti.tick = true;
                t.go();
                Invoke("ResetCooldown", 0.25f);
                cooldown = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
          
            if (cooldown == false)
            {
                move.x += 1;
                ti.tick = true;
                t.go();
                Invoke("ResetCooldown", 0.25f);
                cooldown = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
        
            if (cooldown == false)
            {
                move.x -= 1;
                ti.tick = true;
                t.go();
                Invoke("ResetCooldown", 0.25f);
                cooldown = true;
            }
        }


       /// Debug.Log(System.Array.IndexOf(nonwalkable_tiles, obstacles.GetTile(player_location)) == -1);
        if (System.Array.IndexOf(nonwalkable_tiles, obstacles.GetTile(player_location + move)) == -1)
        {
            player_location += move;
            player_tilemap.ClearAllTiles();
            player_tilemap.SetTile(player_location, player_tile);
        }
        move = Vector3Int.zero;
    }
}
