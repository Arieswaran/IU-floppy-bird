using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject pipePrefab;
    private float timer;
    [SerializeField]
    private float timeBetweenSpawns;
    [SerializeField]
    private float height;

    private void Update() {
        timer += Time.deltaTime;
        if (timer >= timeBetweenSpawns) {
            SpawnPipe();
            timer = 0f;
        }
    }

    private void SpawnPipe() {
        GameObject pipe = ObjectPooler.Instance.SpawnFromPool("Pipe", new Vector3(transform.position.x, transform.position.y + Random.Range(-height, height), transform.position.z), Quaternion.identity);
        StartCoroutine(DeactivatePipe(pipe));
    }

    IEnumerator DeactivatePipe(GameObject pipe) {
        yield return new WaitForSeconds(5f);
        pipe.SetActive(false);
    }
}
