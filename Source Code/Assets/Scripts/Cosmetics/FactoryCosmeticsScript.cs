using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryCosmeticsScript : MonoBehaviour
{
    public int bgcolour;
    public Sprite BlueBackground;
    public Sprite OrangeBackgrounds;
    public Sprite PinkBackground;
    public Sprite BWBackground;
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject background = GameObject.Find("Background");
        BackgroundScript backgroundscript = background.GetComponent<BackgroundScript>();
        bgcolour = backgroundscript.bgcolour;

        if (bgcolour == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = BlueBackground;
        }
        if (bgcolour == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = OrangeBackgrounds;
        }
        if (bgcolour == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = PinkBackground;
        }
        if (bgcolour == 3)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = BWBackground;
        }
    }   
}
