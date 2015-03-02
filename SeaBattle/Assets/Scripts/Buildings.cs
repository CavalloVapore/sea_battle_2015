using UnityEngine;
using System.Collections;

public class Buildings : MonoBehaviour {
    public GameObject TRPost;
	// Use this for initialization
	void Start () {
         GameObject.Find("Trading Post Info").SetActive(false);
         GameObject.Find("Main Base Info").SetActive(false);
         GameObject.Find("Gold Mine Info").SetActive(false);
         GameObject.Find("Shipyard Info").SetActive(false);
         GameObject.Find("Production Info").SetActive(true);

         GameObject.Find("Shipyard Util").SetActive(true);
         GameObject.Find("Main Base Util").SetActive(false);
         GameObject.Find("Gold Mine Util").SetActive(false);
         GameObject.Find("Trading Post Util").SetActive(false);
         
       
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void TradingPostInfo()
    {
        GameObject.Find("Trading Post Info").SetActive(true);
        GameObject.Find("Main Base Info").SetActive(false);
        GameObject.Find("Gold Mine Info").SetActive(false);
        GameObject.Find("Shipyard Info").SetActive(false);
        GameObject.Find("Production Info").SetActive(false);

        GameObject.Find("Shipyard Util").SetActive(false);
        GameObject.Find("Main Base Util").SetActive(false);
        GameObject.Find("Gold Mine Util").SetActive(false);
        GameObject.Find("Trading Post Util").SetActive(true);
    }
    public void MainBaseInfo()
    {
        GameObject.Find("Trading Post Info").SetActive(false);
        GameObject.Find("Main Base Info").SetActive(true);
        GameObject.Find("Gold Mine Info").SetActive(false);
        GameObject.Find("Shipyard Info").SetActive(false);
        GameObject.Find("Production Info").SetActive(false);

        GameObject.Find("Shipyard Util").SetActive(false);
        GameObject.Find("Main Base Util").SetActive(true);
        GameObject.Find("Gold Mine Util").SetActive(false);
        GameObject.Find("Trading Post Util").SetActive(false);
    }
    public void GoldMineInfo()
    {
        GameObject.Find("Trading Post Info").SetActive(false);
        GameObject.Find("Main Base Info").SetActive(false);
        GameObject.Find("Gold Mine Info").SetActive(true);
        GameObject.Find("Shipyard Info").SetActive(false);
        GameObject.Find("Production Info").SetActive(false);

        GameObject.Find("Shipyard Util").SetActive(false);
        GameObject.Find("Main Base Util").SetActive(false);
        GameObject.Find("Gold Mine Util").SetActive(true);
        GameObject.Find("Trading Post Util").SetActive(false);
    }
    public void ShipyardInfo()
    {
        GameObject.Find("Trading Post Info").SetActive(false);
        GameObject.Find("Main Base Info").SetActive(false);
        GameObject.Find("Gold Mine Info").SetActive(false);
        GameObject.Find("Shipyard Info").SetActive(true);
        GameObject.Find("Production Info").SetActive(false);

        
    }
    public void ProductionInfo()
    {
        GameObject.Find("Trading Post Info").SetActive(false);
        GameObject.Find("Main Base Info").SetActive(false);
        GameObject.Find("Gold Mine Info").SetActive(false);
        GameObject.Find("Shipyard Info").SetActive(false);
        GameObject.Find("Production Info").SetActive(true);
    }
    public void InfoMouseExit()
    {
        if (Input.GetKeyDown("Esc"))
        {
            GameObject.Find("Trading Post Info").SetActive(false);
            GameObject.Find("Main Base Info").SetActive(false);
            GameObject.Find("Gold Mine Info").SetActive(false);
            GameObject.Find("Shipyard Info").SetActive(false);
            GameObject.Find("Production Info").SetActive(true);

            GameObject.Find("Shipyard Util").SetActive(true);
            GameObject.Find("Main Base Util").SetActive(false);
            GameObject.Find("Gold Mine Util").SetActive(false);
            GameObject.Find("Trading Post Util").SetActive(false);
        }
    }
}
