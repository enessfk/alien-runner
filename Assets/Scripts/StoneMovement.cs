using UnityEngine;

public class StoneMovement : MonoBehaviour
{
    public float speedX,speedY,speedZ;
    private int repeater;
    public int moveTime;

    void Start()
    {
        repeater = 0;    
    }
    void FixedUpdate()
    {
        repeater++;
        if (repeater <= moveTime)
        {
            transform.Translate(speedX * Time.deltaTime, speedY * Time.deltaTime, speedZ * Time.deltaTime);
        }
        else
        {
            transform.Translate(-speedX * Time.deltaTime, -speedY * Time.deltaTime, -speedZ * Time.deltaTime);

            if (repeater == moveTime*2)
            {
                repeater = 0;
            }
        }
    }

}
