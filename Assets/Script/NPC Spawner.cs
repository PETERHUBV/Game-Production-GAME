using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public GameObject[] NPC;
    public Transform spawnPoint;
    public Transform door;
    public float spawnRate = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnNPC", 1f, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  

   

    void SpawnNPC()
    {
        int index = Random.Range(0,NPC.Length);

        GameObject npc = Instantiate(NPC[index], spawnPoint.position, Quaternion.identity);

        NPCMovement move = npc.GetComponent<NPCMovement>();
        move.target = door;

        npc.GetComponent<NPCData>().Setup();
    }
}
