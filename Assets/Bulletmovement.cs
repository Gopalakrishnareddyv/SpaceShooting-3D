using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletmovement : MonoBehaviour
{
    Rigidbody rbbullet;
    public float bulletspeed=5.0f;
    Animator anim;
    public GameObject particle;
    ScoreScript scorescript;
    // Start is called before the first frame update
    void Start()
    {
        rbbullet = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        scorescript = GameObject.Find("ScoreManage").GetComponent<ScoreScript>();
    }

    // Update is called once per frame
    void Update()
    {
        rbbullet.velocity = Vector3.forward * bulletspeed;


    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            //Destroy(collision.gameObject);
            Destroy(this.gameObject);
            Instantiate(particle, transform.position, Quaternion.identity);
            scorescript.Increment();
        }
        else
        {
            StartCoroutine(nameof(Bulletadd));
        }
    }
    IEnumerator Bulletadd()
    {
        yield return new WaitForSeconds(7);
        print("Missed the ball");
        if (rbbullet.gameObject.name == "Bullet")
        {
            BulletSpawn.Instance.addBullet(rbbullet.gameObject);
            print(rbbullet.gameObject.name);
            print("Adding cannon ball to player");
        }
    }
}
