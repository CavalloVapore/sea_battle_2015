using UnityEngine;
using System.Collections;


[System.Serializable]
public class Tiles
{

    public string sTileName;            //Name of Tile
    public int iTileID;                 //Tile ID
    public string sTileDesc;            //description of tile
    public GameObject goTile;           //gameobject for tile
    public TileType ttTileType;         //type of tile
    public bool bUnit = false;
    public bool bBuilding = false;
    public int iShipID;
    public int iBuildingID;

    //defines tile type
    public enum TileType
    {
        Land,
        Water,
        Base
    }


    
}
