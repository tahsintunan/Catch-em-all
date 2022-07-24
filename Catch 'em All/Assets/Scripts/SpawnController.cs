using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnController : MonoBehaviour
{
    public Item item;
    public float initialTimeBetweenSpawn;
    public float timeDecrement;
    public float minTimeBetweenSpawn;
    public float maxY;
    public float minY;
    public float spawnX;
    private float _timeBetweenSpawn;
    private float _curTimeBetweenSpawn;
    
    private void Start()
    {
        _timeBetweenSpawn = initialTimeBetweenSpawn;
        _curTimeBetweenSpawn = _timeBetweenSpawn;
    }

    private void Update()
    {
        if (_curTimeBetweenSpawn > 0)
        {
            _curTimeBetweenSpawn -= Time.deltaTime;
        }
        else
        {
            SpawnItem();
            _curTimeBetweenSpawn = _timeBetweenSpawn;
            if (_timeBetweenSpawn > minTimeBetweenSpawn)
                _timeBetweenSpawn -= timeDecrement;
        }
    }

    private void SpawnItem()
    {
        var position = new Vector3(spawnX,Random.Range(minY, maxY),0);
        Instantiate(item, position, Quaternion.identity);
    }
}
