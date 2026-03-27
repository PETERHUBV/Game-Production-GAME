using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int Level = 1;

    public NPCSpawner spawner;
    public PlayerData player;

    public int level2 = 200;
    public int level3 = 500;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // ApplyLevelSettings();
    }

    // Update is called once per frame
    void Update()
    {
        if (Level == 1 && player.Money >= level2)
        {
            Level = 2;
            spawner.spawnRate = 2.5f;
        }
        else if (Level == 2 && player.Money >= level3)
        {
            Level = 3;
            spawner.spawnRate = 1.5f;
            // CheckLevelUp();
        }



    

 
 


    

   // void CheckLevelUp()
   // {
   //     if (currentLevel == 1 && player.Money >= level2Money)
     //   {
   //         NextLevel();
    //    }
      //  else if (currentLevel == 2 && player.Money >= level3Money)
     //   {
         //   NextLevel();
      //  }
  //  }

  //  public void NextLevel()
   // {
     //   if (currentLevel < 3)
      //  {
       //     currentLevel++;
       //     ApplyLevelSettings();
     //       Debug.Log("Level Up: " + currentLevel);
      //  }
   // }

   // void ApplyLevelSettings()
  //  {
     //   if (currentLevel == 1)
     //   {
       ///     spawner.spawnRate = 4f;
      //  }
      //  else if (currentLevel == 2)
       // {
        ///    spawner.spawnRate = 2.5f;
    //    }
      //  else if (currentLevel == 3)
      //  {
      //      spawner.spawnRate = 1.5f;
      //  }
    }
}