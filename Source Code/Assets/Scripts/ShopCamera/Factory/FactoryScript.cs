using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class FactoryScript : MonoBehaviour
{
    public int Purchased;
    public double Cost;
    public double TotalBank;
    public double TotalCost;
    public Text Owned;
    public Text CostDisplay;
    public bool Restarting;
    // Start is called before the first frame update
    void Start()
    {
        Cost = 200;
        TotalCost = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //This allows us to grab variables from the script on the Game Object Croissant
        GameObject mainCamera = GameObject.Find("Main Camera");
        PerSecond perSecond = mainCamera.GetComponent<PerSecond>();
        //This grabs the specific value of how many times the Croissant has been clicked
        TotalBank = perSecond.TotalBank;
        Owned.text = "Owned: " + Purchased;
        CostDisplay.text = "Cost: " + Math.Round(Cost);

        //This just checks if the user wants to restart the game and if they do then it resets the variable to starting point
        GameObject restartgame = GameObject.Find("Restart Game");
        Restart restart = restartgame.GetComponent<Restart>();
        Restarting = restart.Restarting;
        if (Restarting == true)
        {
            Cost = 20;
            TotalCost = 0;
            Purchased = 0;
        }
    }
    void OnMouseDown()
    {
        if (TotalBank >= Cost)
        {
            //This checks if they have enough croissants to buy the cursor and if they do this
            //value goes to another script and updates everything.
            Purchased = Purchased + 1;
            //
            TotalCost = TotalCost + Cost;
            // increased the cost after every purchase of a Cursor
            Cost = Cost + 100 + (Cost / 100 * 5);
            //

        }
    }
}
