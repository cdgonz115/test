using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public int lol=0;
	// Update is called once per frame
	void Update ()
    {
        increase(5);
	}
    void increase(int passed)
    {
        lol = lol + passed;
    }
}
