using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    
    [SerializeField] private float _speed;
    private float _oldMousePositionX;
    private float _eulerY; // Угол поворота
    [SerializeField] private Animator _animator;
    
    private void Update() {

        if(Input.GetMouseButtonDown(0)) // Действия при нажатой левой кнопки мыши
        {
            _oldMousePositionX = Input.mousePosition.x;
            _animator.SetBool("Run", true);
        }

        if(Input.GetMouseButton(0)) 
        {
            Vector3 newPosition = transform.position + transform.forward  * Time.deltaTime * _speed; // Направление оси Z, Time.deltaTime - время одного кадра
            newPosition.x = Mathf.Clamp(newPosition.x, -2.5f, 2.5f);
            transform.position = newPosition;

            float deltaX = Input.mousePosition.x - _oldMousePositionX; // Смещение мыши которое произошло в этом кадре (изменение за один кадр)
            _oldMousePositionX = Input.mousePosition.x; 

            _eulerY += deltaX;
            _eulerY = Mathf.Clamp(_eulerY, -70, 70); // Ограничиваем углы поворота до +/-70
            transform.eulerAngles = new Vector3(0, _eulerY, 0);
        }

        if(Input.GetMouseButtonUp(0)) // Действия при отпущеной левой кнопки мыши
        {
            _animator.SetBool("Run", false);
        }
    }
}
