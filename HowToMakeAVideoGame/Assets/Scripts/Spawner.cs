using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstacles;
    public Transform player;
    
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startwait;
    public int dist;

    int randobstacles;
    private void Start()
    {
        StartCoroutine(WaitSpawner());
       
    }
    private void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
    }
    IEnumerator spawnObs(int obsID)
    {
        if (obsID == 0)
        {
            Vector3 SpawnPosi = new Vector3(Random.Range(-6, 6), 1.25f, Random.Range(0, spawnValues.z));
            Instantiate(obstacles[obsID], SpawnPosi + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

        }
        else if (obsID == 4)
        {
            Vector3 SpawnPosition = new Vector3(Random.Range(-7, 0), 1, Random.Range(0, spawnValues.z));
            Instantiate(obstacles[obsID], SpawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            yield return new WaitForSeconds(0.2f);
        }
        else
        {
            Vector3 spawnPost = new Vector3(Random.Range(-4, 6), 1, Random.Range(0, spawnValues.z));
            Instantiate(obstacles[obsID], spawnPost + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            yield return new WaitForSeconds(0.2f);
        }
        yield return new WaitForSeconds(spawnWait);
    }

    IEnumerator WaitSpawner()
    {
        yield return new WaitForSeconds(startwait);
        while(true)
        {
            if (player.position.z >= 0 && player.position.z < 200)
            {

                StartCoroutine(spawnObs(0));
                StartCoroutine(spawnObs(4));
                


            }








            else if (player.position.z >= 200 && player.position.z < 800)
            {
                StartCoroutine(spawnObs(0));

                Vector3 SpawnPosi = new Vector3(Random.Range(4,7), 1, Random.Range(0, spawnValues.z));
                Instantiate(obstacles[4], SpawnPosi + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
                yield return new WaitForSeconds(0.1f);

                StartCoroutine(spawnObs(1));
                StartCoroutine(spawnObs(6));
            }

           else  if (player.position.z > 800 && player.position.z < 1200)
            {
                StartCoroutine(spawnObs(0));
                randobstacles = Random.Range(1,5);
                spawnObs(randobstacles);

            }
            else if(player.position.z >=1200 && player.position.z<2000)
            {
                randobstacles = Random.Range(3, obstacles.Length);
                StartCoroutine(spawnObs(randobstacles));

            }
            else
            {
                randobstacles = Random.Range(0, obstacles.Length);
                StartCoroutine(spawnObs(randobstacles));
            }






            
        }

    }
    

}
