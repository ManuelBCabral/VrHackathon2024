using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;

    public Transform spawnPoint;

    public float timeBetweenWaves = 2f;
    private float countdown = 15f;

    public Text waveCountdownText;

    private int waveNumber = 1;

    public Text healthtxt;
    public int health;


    private void Start()
    {
        health = 100;
        healthtxt.text = "Health: " + health;
    }
    void Update ()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            SpawnWave();
            if (waveNumber >= 5)
            {
                countdown = timeBetweenWaves + waveNumber;
            }
            else
            {
                countdown = timeBetweenWaves * waveNumber;
            }

        }

        countdown -= Time.deltaTime;

        waveCountdownText.text = "Next Round In: " + Mathf.Floor(countdown).ToString();
    }

    IEnumerator SpawnWave()
    {
        for (int i = 0; i < waveNumber; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.8f);
        }
        waveNumber += 2;
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }

    public void LoseHealth()
    {
        health -= 5;
        healthtxt.text = "Health: " + health;
    }
}
