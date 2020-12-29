using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyFeedback : MonoBehaviour
{
    public bool keyHit = false;
    public bool keyCanBeHitAgain = false;
    private float originalYPosition;
    
    private TextMeshPro playerTextOutput;

    
    // Start is called before the first frame update
    void Start()
    {
        originalYPosition = transform.position.y;               playerTextOutput = GameObject.FindGameObjectWithTag("PlayerTextOutput").GetComponentInChildren<TextMeshPro>();

    }

    // Update is called once per frame
    void Update(){
        var key = gameObject.GetComponentInChildren<TextMeshPro>();
        
        if(keyHit){
                if(key.text == "SPACE"){
                    playerTextOutput.text += " ";
                }else if(key.text == "<-"){
                    playerTextOutput.text = playerTextOutput.text.Substring(0, playerTextOutput.text.Length-1);
                }else{
                    playerTextOutput.text += key.text;
                }            keyCanBeHitAgain = false;
            keyHit = false;
            transform.position += new Vector3(0, -0.03f, 0);
        }   
        if(transform.position.y < originalYPosition){
            transform.position += new Vector3(0, 0.005f, 0);
        } else{
            keyCanBeHitAgain = true;
        }
    }
}
