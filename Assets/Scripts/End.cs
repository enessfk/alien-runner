using UnityEngine;

public class End : MonoBehaviour
{

    public GameMenager gameMenager;
    
    private void OnTriggerEnter(Collider other)
    {
        gameMenager.CompleteLevel();
        
    }
}
