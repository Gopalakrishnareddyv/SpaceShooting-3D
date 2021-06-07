using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySPawn : MonoBehaviour
{
    public GameObject Enemy;
    float time = 0;
    PlayerMovement player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 2.0f && player!=null)
        {
            float value = Random.Range(1.0f, 9.24f);
            GameObject enemyref = Instantiate(Enemy);
            enemyref.transform.position = new Vector3(value,-4, 4.28f);
            time = 0;
        }
        
    }
}
