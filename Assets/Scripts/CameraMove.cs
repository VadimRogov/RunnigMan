using UnityEngine;

public class CameraMove : MonoBehaviour
{
   [SerializeField]
   Transform _target;

   private void Start() 
   {
      transform.parent = null;
   }

   private void LateUpdate() 
   {
    transform.position = _target.position; // Позиция этого объекта, должна быть каждый кадр равна позиции цели
   }
}
