using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject tramYesil;
    public GameObject tramKirmizi;
    public GameObject araba;
    public GameObject kestane;

    public float spawnSuresi = 2.5f;
    public float spawnX = 12f;
    float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnSuresi)
        {
            SpawnDalga();
            timer = 0;
        }
    }

    void SpawnDalga()
    {
        int sans = Random.Range(0, 100);

        if (sans < 40)
        {
            GameObject tram = (Random.value > 0.5f) ? tramYesil : tramKirmizi;
            Instantiate(tram, new Vector3(spawnX, -2.2f, 0), Quaternion.identity);
            Instantiate(kestane, new Vector3(spawnX + 2.2f, -0.5f, 0), Quaternion.identity);
        }
        else if (sans < 70)
        {
            Instantiate(araba, new Vector3(spawnX, -2.2f, 0), Quaternion.identity);
        }
        else
        {
            int adet = Random.Range(1, 3);
            for (int i = 0; i < adet; i++)
            {
                float y = Random.Range(-1.8f, -0.8f);
                Instantiate(kestane, new Vector3(spawnX + i * 1.4f, y, 0), Quaternion.identity);
            }
        }
    }
}