using UnityEngine;
using System.Collections;
public class MovePlayers : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 05f;
    [SerializeField] private VJHandler jsMovement;
    [SerializeField] private Camera cameraMain;
    private Vector3 direction;
    private float xMin, xMax, yMin, yMax;

    void Update()
    {

        direction =  jsMovement.InputDirection; //InputDirection can be used as per the need of your project
      
        if (direction.magnitude != 0)
        {

            transform.position += direction * moveSpeed * Time.deltaTime;

            //Vector2 currentPosition = cameraMain.WorldToScreenPoint(transform.position);
            //currentPosition = new Vector3(Mathf.Clamp(currentPosition.x, xMin, xMax), Mathf.Clamp(currentPosition.y, yMin, yMax), 0f);//to restric movement of player
            //currentPosition = cameraMain.ScreenToWorldPoint(currentPosition);
            //transform.position = new Vector3(currentPosition.x, currentPosition.y, 0);
        }
    }

    void Start()
    {
      
        //Initialization of boundaries
        xMax = Screen.width - 50; // I used 50 because the size of player is 100*100
        xMin = 50;
        yMax = Screen.height - 50;
        yMin = 50;
    }
}