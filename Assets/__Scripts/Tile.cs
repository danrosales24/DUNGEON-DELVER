using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{

    [Header("Set Dynamically")]
    public int x;
    public int y;
    public int titleNum;

    public void SetTitle(int eX, int eY, int EtileNum = -1)
    {
        x = eX;
        y = eY;
        transform.localPosition = new Vector3(x, y, 0);
        gameObject.name =x.ToString("D3")+"+y.ToString("D3");
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
