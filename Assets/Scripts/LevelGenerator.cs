using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public Transform Player;
    public LevelChunk[] ChunkPrefabs;
    public LevelChunk FirstCnunk;

    private List<LevelChunk> _spawnedChunks = new List<LevelChunk>();

    private void Start()
    {
        _spawnedChunks.Add(FirstCnunk);
    }

    private void Update()
    {
        if(Player.position.z > _spawnedChunks[_spawnedChunks.Count - 1].End.position.z - 50)
        {
            SpawnLevelChunk();
        }
    }

    private void SpawnLevelChunk()
    {
        LevelChunk newChunk = Instantiate(ChunkPrefabs[Random.Range(0, ChunkPrefabs.Length)]);
        newChunk.transform.position = _spawnedChunks[_spawnedChunks.Count-1].End.position - newChunk.Begin.localPosition;
        _spawnedChunks.Add(newChunk);

        if(_spawnedChunks.Count >= 5)
        {
            Destroy(_spawnedChunks[0].gameObject);
            _spawnedChunks.RemoveAt(0);
        }
    }
}






