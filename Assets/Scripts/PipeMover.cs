using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMover : MonoBehaviour
{
    [SerializeField]
    private float speed = 1f;
    // Start is called before the first frame update
    private bool is_active = false;
    void Start()
    {
        
    }

    private void OnEnable() {
        is_active = true;
    }

    private void OnDisable() {
        is_active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(is_active){
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }
}
