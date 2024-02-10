using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_anim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void button_touch()
    {
        GetComponent<Animation>().Play("Button");
    }
    public void button_touch2()
    {
        GetComponent<Animation>().Play("Button2");
    }
    public void button_touch3()
    {
        GetComponent<Animation>().Play("Button3");
    }
    public void button_touch4()
    {
        GetComponent<Animation>().Play("Button4");
    }
}
