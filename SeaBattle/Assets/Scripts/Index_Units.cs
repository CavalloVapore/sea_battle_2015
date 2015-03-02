using UnityEngine;
using System.Collections;

[System.Serializable]
public class Index_Units
{
    
    public string ShipName;   //name of ship
    public int HealthPoints;  //base hp of ship
    public int MinAttack;        //min. attack value of ships
    public int MaxAttack;        //max. attack value
    public int MovementPoint;  //movement points of ships
    public int AttackRange;   //attack range
    public int Cost;          //how much resources does a unit need to be built?
    public int LevelReq;      //required level of the shipyard to construct a ship
    public ShipType sShipType;    //declares which type of ship 
    public int ShieldPoints;     //shield value(explicit to "defender"
    public int SupplyReq = 1;        //supply needed to build this ship
    public GameObject Ship;
    public Texture2D ShipIcon; 
    public int ShipID;
    

    public enum ShipType
    {
        ranged,
        melee,
        defense,
        mainbase
    }

   
}
