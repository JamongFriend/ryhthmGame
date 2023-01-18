using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressButtonA : MonoBehaviour
{
    public GameObject press;
    private bool state;

    // Start is called before the first frame update
    void Start()
    {
        state = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)){
            if(state == true){
                press.SetActive(false);
                state = false;
            }
        }
        if(Input.GetKeyUp(KeyCode.A)) {
            if(state == false){
                press.SetActive(true);
                state = true;
            }
        }
    }
}