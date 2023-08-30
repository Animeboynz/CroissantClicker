using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{  
    // Start is called before the first frame update
    public int orange;
    public int bgcolour;
    public Sprite BlueBackground;
    public Sprite OrangeBackgrounds;
    public Sprite PinkBackground;
    public Sprite BWBackground;
    public SpriteRenderer spriteRenderer;
    
    void Start()
    {

        gameObject.GetComponent<SpriteRenderer>().sprite = BlueBackground;
    }

    // Update is called once per frame
    void Update()
    {
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
