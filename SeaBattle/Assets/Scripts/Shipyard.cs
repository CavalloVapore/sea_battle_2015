using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Shipyard : MonoBehaviour {
    public List<Index_Units> unit = new List<Index_Units>();
    private Unit_Database database;
    private bool showTooltip;
    private string tooltip;
    public TextAsset imageTextAsset;
    

	// Use this for initialization
	void Start () {
	
        database = GameObject.FindGameObjectWithTag("unit database").GetComponent<Unit_Database>();
        unit.Add(database.units[0]);
        

	}

    void OnGUI()
    {
        if (showTooltip)
        {
            GUI.Box(new Rect(Event.current.mousePosition.x, Event.current.mousePosition.y-200, 200, 200), tooltip);
        }
    }

    public void VerifyTooltip0()
    {
        showTooltip = true;
        CreateTooltip(database.units[0]);
        
    }
    public void VerifyTooltip1()
    {
        showTooltip = true;
        CreateTooltip(database.units[1]);

    }
    public void VerifyTooltip2()
    {
        showTooltip = true;
        CreateTooltip(database.units[2]);
    }

    public void VerifyTooltip3()
    {
        showTooltip = true;
        CreateTooltip(database.units[3]);
    }
    
    
    //public void VerifyTooltip4()
    //{
    //    showTooltip = true;
    //    CreateTooltip(unit[4]);

    //}
    //public void VerifyTooltip5()
    //{
    //    showTooltip = true;
    //    CreateTooltip(unit[5]);

    //}
    //public void VerifyTooltip6()
    //{
    //    showTooltip = true;
    //    CreateTooltip(unit[6]);

    //}
    

    public void StopTooltip()
    {
        showTooltip = false;
    }

    public string CreateTooltip(Index_Units unit)
    {
        tooltip = "<color=#3906D1>" + unit.ShipName + "</color> \n\n Health Points:" + unit.HealthPoints.ToString() + "\n Attack Points: " + unit.MinAttack.ToString() + "-" + unit.MaxAttack.ToString() + "\n Movement Points: " + unit.MovementPoint.ToString() + "\n Attack Range: " + unit.AttackRange.ToString() + "\n Cost: <color=#C9E339>" + unit.Cost.ToString() + " Gold </color> \n Shipyard Lvl Req: " + unit.LevelReq.ToString() + "\n Supply Req: " + unit.SupplyReq.ToString() + "\n<color=#FA1626> Ship Type: " + unit.sShipType.ToString() + "</color>";
        return tooltip;
    }

    public void BuildScout()
    {
        if (Income.Gold > unit[0].Cost && Resources.MSupply <= Resources.SupplyLimit)
        {


            unit.Add(database.units[0]);
            Income.Gold -= unit[0].Cost;
            
        }
    }
    public void BuildArrow()
    {
       if(Income.Gold > unit[1].Cost && Resources.MSupply <= Resources.SupplyLimit )
        unit.Add(database.units[1]);
        Income.Gold -= unit[1].Cost;

    }
    public void BuildRam()
    {
        if (Income.Gold > unit[2].Cost && Resources.MSupply <= Resources.SupplyLimit)
        {
            unit.Add(database.units[2]);
            Income.Gold -= unit[2].Cost;
        }
    }
    public void BuildCannon()
    {
        if (Income.Gold > unit[3].Cost && Resources.MSupply <= Resources.SupplyLimit)
        {
            unit.Add(database.units[3] );
            Income.Gold -= unit[3].Cost;
        }
    }
    public void DeleteElement()
    {
      
           unit.RemoveAt(1);
       
        
    }
    
    public void Produce(Texture name){
        GUI.DrawTexture(new Rect(3 * Screen.width / 4 + 5, 4 * Screen.height/5 + 250, 27, 27), name, ScaleMode.ScaleToFit, true, 0);
    }
    


          
    

	
}
