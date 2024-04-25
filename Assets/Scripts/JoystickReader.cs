using UnityEngine;
public class JoystickReader : MonoBehaviour
{
    private Vector3 touchDirection = Vector3.zero;
    [SerializeField] private float speed = 5f;
    private void Start()
    {
        //Subscribe to the action in JoyStick.cs
        JoyStick.onJoyStickMoved += GetJoyStickDirection;
    }

    void GetJoyStickDirection(Vector2 touchPosition)
    {
        //Touch direction updating every time joystick is moved.
        touchDirection = touchPosition;
        //Call player move function here to move player.
      
    }
    private void Update()
    {
        if (touchDirection.magnitude != 0)
        {

            transform.position += touchDirection * speed * Time.deltaTime;
        }
    }
}