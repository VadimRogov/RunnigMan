using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BoxMove : MonoBehaviour {
    
    
    //GetKey        - срабатывает пока кнопка зажата
    //GetKeyDown    - срабатывает когда вы нажимаете кнопку
    //GetKeyUp      - срабатывает когда вы отпускаете кнопку
    private void Update() {
        if(Input.GetKey(KeyCode.W))  
        {
            transform.position += new Vector3(0, 0.03f, 0);
        }else if(Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, 0.03f, 0);
        }
        if(Input.GetMouseButtonDown(0))
        {
            transform.localScale *= 1.2f;
        }else if(Input.GetMouseButtonDown(1))
        {
            transform.localScale *= 0.8f;
        }

        transform.localEulerAngles = new Vector3(0, Input.mousePosition.x, 0);
    
    }
}
