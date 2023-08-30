using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClick : MonoBehaviour
{
    public double CroissantOnClick;
    public Text ShowCroissants;
    public bool Restarting;
    public GameObject croissant;
    // Start is called before the first frame update
    void Start()
    {
        croissant = GameObject.Find("Croissant");
    }

    // Update is called once per frame
    void Update()
    {
        //This just checks if the user wants to restart the game and if they do then it resets the variable to starting point
        GameObject restartgame = GameObject.Find("Restart Game");
        Restart restart = restartgame.GetComponent<Restart>();
        Restarting = restart.Restarting;
        if (Restarting == true)
        {
            CroissantOnClick = 0;
        }
    }
    void OnMouseDown()
    {
        //The Croissant has been clicked on which means the total has increased by one
        CroissantOnClick = CroissantOnClick + 1;
        transform.localScale = new Vector3(110f, 110f, 10f);
        StartCoroutine(EveryClick());
    }
    IEnumerator EveryClick()
    {
        yield return new WaitForSeconds(1f);
        transform.localScale = new Vector3(100f, 100f, 10f);
    }
}
