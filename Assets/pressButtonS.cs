using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressButtonS : MonoBehaviour
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
        if(Input.GetKeyDown(KeyCode.S)){
            if(state == true){
                press.SetActive(false);
                state = false;
            }
        }
        if(Input.GetKeyUp(KeyCode.S)) {
            if(state == false){
                press.SetActive(true);
                state = true;
            }
        }
    }
}
