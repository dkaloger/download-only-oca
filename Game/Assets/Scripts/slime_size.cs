using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class slime_size : MonoBehaviour
{
    public p_e_interface me;
    public int olds;
    public Tile t;
    public Texture2D texture;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(me.my_size != olds)
        {
            t.sprite = Sprite.Create(texture, new Rect(0, 0, 33, 21), new Vector2(0.5f, 0.5f), me.my_size);
                                   
 
        }
            olds = me.my_size;
    }
}
