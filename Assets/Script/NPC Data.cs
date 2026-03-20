using UnityEngine;

public class NPCData : MonoBehaviour
{
    public bool ObtainedCard;
    public LevelManager levelManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   

    public void Setup()
    {
        float chance = 0.3f; 

       // if (levelManager.currentLevel == 1)
          //  chance = 0.2f; 

     //   if (levelManager.currentLevel == 2)
         //   chance = 0.4f;

     //   if (levelManager.currentLevel == 3)
         //   chance = 0.6f;   

        ObtainedCard = Random.value > chance;
    }
}
