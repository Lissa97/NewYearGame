using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateFon : MonoBehaviour
{

    public Fon firstFon;
    public Fon secondFon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!firstFon.isRender) {

            firstFon.transform.position = 2 * secondFon.transform.position - firstFon.transform.position;
            firstFon.Refresh();
            
            var tmp = firstFon;
            firstFon = secondFon;
            secondFon = tmp;
        
        }
    }
}
