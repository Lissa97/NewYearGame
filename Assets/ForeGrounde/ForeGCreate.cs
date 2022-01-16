using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeGCreate : MonoBehaviour
{

    public GameObject lvl1;
    public GameObject lvl2;

    public Transform curLvl;
    public Transform nextLvl;


    Fon curLvlFon;
    // Start is called before the first frame update
    void Start()
    {
        curLvlFon = curLvl.GetComponentInChildren<Fon>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!curLvlFon.isRender)
        {

            var newLvl = Instantiate(randomLvl(), 2 * nextLvl.position - curLvl.position, Quaternion.identity, transform);

            Destroy(curLvl.gameObject);

            curLvl = nextLvl;
            nextLvl = newLvl.transform;
            curLvlFon = curLvl.GetComponentInChildren<Fon>();



        }
    }

    GameObject randomLvl() {

        int c = Random.Range(0, 2);

        if (c > 0) {
            return lvl1;
        
        }
        else return lvl2;
    }

}
