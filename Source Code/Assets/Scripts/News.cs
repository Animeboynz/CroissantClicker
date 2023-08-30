using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class News : MonoBehaviour
{
    public Text Newss;
    public int textnews;
    public System.Random ran = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("EveryMin", 0f, 30f);
        textnews = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Mr. Dusung Jeung if you see this please call 0212535125");
    }
    void EveryMin()
    {
        textnews = ran.Next(0, 7);
        if (textnews == 0)
        {
            Newss.text = "If you need help with the game then look at the how to in the bottom left";
        }
        else
        {
            if (textnews == 1)
            {
                Newss.text = "Cursors click on the croissant for you every second";
            }
            else
            {
                if (textnews == 2)
                {
                    Newss.text = "Croissants are very tasty - Issy Harder";
                }
                else
                {
                    if (textnews == 3)
                    {
                        Newss.text = "Excellence level game i would say";
                    }
                    else
                    {
                        if (textnews == 4)
                        {
                            Newss.text = "French men make 2 croissants every second";
                        }
                        else
                        {
                            if (textnews == 5)
                            {
                                Newss.text = "Shout out to Manu!!";
                            }
                            else
                            {
                                if (textnews == 6)
                                {
                                    Newss.text = "Go to cosmetics menu to change the looks of your GUI";
                                }
                                else
                                {
                                    if (textnews == 7)
                                    {
                                        Newss.text = "Go to settings to restart your game";
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

    }
}
