using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;
public class p_e_interface : MonoBehaviour
{
    public Tilemap myt;
    public enemy_patroll ep;
    public Vector3Int pos;
    public astar_to_tile astar;
    public player p;
    public int my_size;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(p.player_location == pos)
        {
            if(my_size > p.size || my_size == p.size)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            if (my_size < p.size)
            {
                p.size++;
                print(my_size);
                myt.ClearAllTiles();
                Destroy(gameObject);
            }

        }
        if (ep == null) {
            pos = astar.player_location;
        }
        else
        {
            pos = ep.my_pos;
        }
     
    }
}
