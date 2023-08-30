using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class PerSecond : MonoBehaviour
{
    public double CroissantsOnClick;
    public double CroissantsPerSecond;
    public int seconds;
    //Most of these variables are only here because we need to create a variable for stuff from the other scripts to be assigned to.
    public double TotalCursorCost;
    public double TotalFrenchManCost;
    public double TotalBakeryCost;
    public double TotalMineCost;
    public double TotalFactoryCost;
    public double TotalShipmentCost;
    //Total Croissants users got
    public double TotalBank;
    //Total money spent by user
    public double TotalCost;
    //Varibles from other scripts
    public int PurchasedCursors;
    public int PurchasedFrenchMan;
    public int PurchasedBakery;
    public int PurchasedMine;
    public int PurchasedFactory;
    public int PurchasedShipment;
    //Varibles from other scripts
    public int PerSecondCursors;
    public int PerSecondFrenchMan;
    public int PerSecondBakery;
    public int PerSecondMine;
    public int PerSecondFactory;
    public int PerSecondShipment;
    //Varibles from other scripts
    public Text DisplayPerSecond;
    public int TotalPerSecond;
    public Text Statistics;
    public Text OneScore;
    public Text TwoScore;
    public Text ThreeScore;
    public Text ShopCroissantDisplay;
    //Restarting variable, if true then the user just decided to restart game
    public bool Restarting;
    //public button LoadState

    // Start is called before the first frame update
    void Start()
    {
        //repeats the function EverySecond every second.
        InvokeRepeating("EverySecond", 1f, 1f);
        //resets all purchases
        TotalCursorCost = 0;
        TotalFrenchManCost = 0;
        TotalBakeryCost = 0;
        TotalMineCost = 0;
        TotalFactoryCost = 0; 
        TotalShipmentCost = 0;
        CroissantsPerSecond = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        //This allows us to grab variables from the script on the Game Object Croissant
        GameObject croissant = GameObject.Find("Croissant");
        OnClick onClick = croissant.GetComponent<OnClick>();
        //This grabs the specific value of how many times the Croissant has been clicked
        CroissantsOnClick = onClick.CroissantOnClick;
        //This is used to grab variables from Cursor Script
        GameObject cursorObject = GameObject.Find("CursorObject");
        Cursor cursor = cursorObject.GetComponent<Cursor>();
        //This is used to figure out how many cursors have been purchased
        PurchasedCursors = cursor.Purchased;
        TotalCursorCost = cursor.TotalCost;
        //Allows variables from the French Man script to be accessed
        GameObject French_Man_Object = GameObject.Find("French_Man_Object");
        FrenchMan frenchMan = French_Man_Object.GetComponent<FrenchMan>();
        //Grabs variables from frenchman Script
        PurchasedFrenchMan = frenchMan.Purchased;
        TotalFrenchManCost = frenchMan.TotalCost;
        //Allows variables from the Bakery script to be accessed
        GameObject bakery = GameObject.Find("Bakery");
        BakeryScript bakeryScript = bakery.GetComponent<BakeryScript>();
        //Grabs variables from bakery Script
        PurchasedBakery = bakeryScript.Purchased;
        TotalBakeryCost = bakeryScript.TotalCost;
        //Allows variables from the Mine script to be accessed
        GameObject mine = GameObject.Find("Mine");
        MineScript mineScript = mine.GetComponent<MineScript>();
        //Grabs variables from mine Script
        PurchasedMine = mineScript.Purchased;
        TotalMineCost = mineScript.TotalCost;
        //Allows variables from the Factory script to be accessed
        GameObject factory = GameObject.Find("Factory");
        FactoryScript factoryScript = factory.GetComponent<FactoryScript>();
        //Grabs variables from Factory Script
        PurchasedFactory = factoryScript.Purchased;
        TotalFactoryCost = factoryScript.TotalCost;
        //Allows variables from the Shipmentscript to be accessed
        GameObject shipment = GameObject.Find("Shipment");
        ShipmentScript shipmentScript = shipment.GetComponent<ShipmentScript>();
        //Grabs variables from Shipment Script
        PurchasedShipment = shipmentScript.Purchased;
        TotalShipmentCost = shipmentScript.TotalCost;
        //Allows variables from the Restart script to be accessed
        GameObject restartgame = GameObject.Find("Restart Game");
        Restart restart = restartgame.GetComponent<Restart>();
        Restarting = restart.Restarting;
        //Calculates the amount of croissants you have ever spent
        TotalCost = Math.Round(TotalCursorCost) + Math.Round(TotalFrenchManCost) + Math.Round(TotalBakeryCost) + Math.Round(TotalMineCost) + Math.Round(TotalFactoryCost) + Math.Round(TotalShipmentCost);
        //Total croissants the user has at this point in time
        TotalBank = CroissantsOnClick + CroissantsPerSecond - TotalCost;
        //Total amount of croissants user earns per second
        TotalPerSecond = PerSecondCursors + PerSecondFrenchMan + PerSecondBakery + PerSecondMine + PerSecondFactory + PerSecondShipment;
        //Updates text ui that shows amount of croissants user earns per second
        DisplayPerSecond.text = TotalPerSecond + " Per Second";
        //This is the statistics code to show the statistics of the game
        Statistics.text = "Clicked on the Croissant " + CroissantsOnClick + " times\n\nEarned " + CroissantsPerSecond + " Croissants passively \n\nTotal croissants earned is " + (CroissantsOnClick + CroissantsPerSecond) + "\n\nTotal Croissants spent is "+ TotalCost + "\n\nShop purchases " + (PurchasedCursors + PerSecondFrenchMan + PerSecondBakery + PerSecondMine + PerSecondFactory + PerSecondShipment) + "\n\nYou've played for " + seconds + " seconds!";
        //Leaderboard code
        OneScore.text = (CroissantsOnClick + CroissantsPerSecond).ToString();
        // 2nd person on leaderboard
        TwoScore.text = Math.Round(Math.Round(CroissantsOnClick + CroissantsPerSecond) / 1.483290849880800027377).ToString();
        //third number on leaderboard
        ThreeScore.text = Math.Round(Math.Round(CroissantsOnClick + CroissantsPerSecond) / 2.32348239048029384092).ToString();
        //Updates text ui that shows amount of croissants bought
        ShopCroissantDisplay.text = (TotalBank).ToString() + " Croissants";
    }

    void EverySecond()
    {
        //This all calculates how much each of the factories gives you in croissants per second then adds them to how much you should have in total
        PerSecondCursors = PurchasedCursors * 1;
        PerSecondFrenchMan = PurchasedFrenchMan * 2;
        PerSecondBakery = PurchasedBakery * 3;
        PerSecondMine = PurchasedMine * 4;
        PerSecondFactory = PurchasedFactory * 5;
        PerSecondShipment = PurchasedShipment * 6;
        CroissantsPerSecond = CroissantsPerSecond + PurchasedCursors + PerSecondFrenchMan + PerSecondBakery + PerSecondMine + PerSecondFactory + PerSecondShipment;
        seconds = seconds + 1;


        if (Restarting == true)
        {
            //Sets the croisssants the user has earned passively to zero
            CroissantsPerSecond = 0;
            //sets time played on the game to zero
            seconds = 0;
        }
    }

    
}
