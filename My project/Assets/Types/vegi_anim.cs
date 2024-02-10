using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vegi_anim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void button_touchV()
    {
        GetComponent<Animation>().Play("Vegi");
    }
    public void button_touchFL()
    {
        GetComponent<Animation>().Play("Flower");
    }
    public void button_touchFR()
    {
        GetComponent<Animation>().Play("Fruit");
    }
}
