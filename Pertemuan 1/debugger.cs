using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debugger : MonoBehaviour
{
    int x = 28;
    public int z = 10;
    public string name; 
    // Start is called before the first frame update
    void Start()
    {
        Debut.Log("Hello, my name is " + name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
