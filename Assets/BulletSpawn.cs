using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject bullet;
    public GameObject currentbullet;
    public AudioClip sound;
    AudioSource audio;
    Stack<GameObject> bulletpool = new Stack<GameObject>();
    private static BulletSpawn instance;

    public static BulletSpawn Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<BulletSpawn>();
            }
            return instance;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            BulletSpawning();
            audio.clip = sound;
            audio.Play();
        }

    }
    public void CreatePool()
    {
        {
            bulletpool.Push(Instantiate(bullet));
            bulletpool.Peek().SetActive(false);
            bulletpool.Peek().name = "Bullet";
        }

    }
    public void addBullet(GameObject bullettemp)
    {
        bulletpool.Push(bullettemp);
        bulletpool.Peek().SetActive(false);
    }
    public void BulletSpawning()
    {
        if (bulletpool.Count == 0)
        {
            CreatePool();
        }
        GameObject temp = bulletpool.Pop();
        temp.SetActive(true);
        temp.transform.position = transform.position + new Vector3(0, 1f, 0);
        currentbullet = temp;
    }
}