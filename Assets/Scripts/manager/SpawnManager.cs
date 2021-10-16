using UnityEngine;

public class SpawnManager : MonoBehaviour
{
   
    public GameObject box;
    public GameObject enemy;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;



    void Start()
    {
        //Mengeksekusi fungs Spawn setiap beberapa detik sesui dengan nilai spawnTime
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }


    void Spawn()
    {
      

    
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

       
        Instantiate(box, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

    }
}