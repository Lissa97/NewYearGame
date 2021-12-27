using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GanerateLamppost : MonoBehaviour
{
    public Fon lamp1;
    public Fon lamp2;
    public Fon lamp3;
    public Fon lamp4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lamp4.isVisible) { 
        
            lamp1.transform.position = new Vector3(lamp4.transform.position.x + lamp2.transform.position.x - lamp1.transform.position.x,
                                                     lamp1.transform.position.y,
                                                      lamp1.transform.position.z);

            lamp1.Refresh();

            var tmp = lamp1;
            lamp1 = lamp2;
            lamp2 = lamp3;
            lamp3 = lamp4;
            lamp4 = tmp;

        }
    }
}
