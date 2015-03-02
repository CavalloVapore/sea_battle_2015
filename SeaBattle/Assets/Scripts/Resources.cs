using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Resources : MonoBehaviour {
     
    public static int Gold;            //the player's gold
    public static int SupplyLimit;      //The limit for the amount of ships that can be built in one round
    public static int MSupply;                 //Momentary Supply, the ships that are being built at that round
    public static int NumberShips;             //The number of ships the player controls.(max)
    public static int MShips;                  //the momentary number of ships you control.
    Text text;

	// Use this for initialization
	void Awake () {
        text = GetComponent<Text>();    //set up the reference??

    //reset all the integers!
        Gold = 0;
        SupplyLimit = 1;
        NumberShips = 12;
        MSupply = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
        //Set the displayed text to be the word gold followed by the gold value.
        text.text = "Gold: " + Gold + "\n\n Supply Limit: " + MSupply + " / " +  SupplyLimit + "\n\n Number of ships: "+ MShips + " / " + NumberShips;
	}
}
