using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Restart : MonoBehaviour
{
    public bool Restarting;
    public int milliseconds = 1000;
    void Start()
    {
        Restarting = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        //if clicked on then the user wants to restart
        Restarting = true;
        //this fucntion time was used so that we could sleep the code for a second
        StartCoroutine(SecondWait());
    }
    IEnumerator SecondWait()
    {
        if (Restarting == true)
        {
            //sleeps the code for a second
            yield return new WaitForSeconds(1);
            //stops all the variables in the game from being set to starting point so user can actually play
            Restarting = false;
        }
    }
}
