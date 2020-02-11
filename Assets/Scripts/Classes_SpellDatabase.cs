using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes_SpellDatabase : MonoBehaviour
{

    public Classes_SpellDefinitions[] spells;


    public int level = 1;
    public int exp;


    // Start is called before the first frame update
    public void Start()
    {
        //fireBlast = new Classes_SpellDefinitions("FireBlast", 1, 27, 35);
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var spell in spells)
            // iterate through spell list and 
            {
                if (spell.levelRequired <= level)
                //Check to see if level is high enough for spell req...
                {
                    spell.Cast();
                    exp += spell.expGained;

                    if (exp >=250)
                    {

                        level += 1;
                        exp = 0;
                    }
                }


                //before casting spell...

                //or not.

            }

            //Debug.Log("GetKeyDown...");
            //fireBlast.Cast();
            //exp += fireBlast.expGained;
        }
    }
}
