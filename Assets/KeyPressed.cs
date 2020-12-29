using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyPressed : MonoBehaviour
{
    public bool keyHit = false;
    public bool keyCanBeHitAgain = false;
    private float originalYPosition;
    private TextMeshPro playerTextOutput;
    
    // Start is called before the first frame update
    void Start()
    {
        originalYPosition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(keyHit){
            keyCanBeHitAgain = false;
            keyHit = false;
            transform.position += new Vector3(0, -0.03f, 0);
            playerTextOutput.text += "A";
        }   
        if(transform.position.y < originalYPosition){
            transform.position += new Vector3(0, 0.005f, 0);
        } else{
            keyCanBeHitAgain = true;
        }
    }
    
}
