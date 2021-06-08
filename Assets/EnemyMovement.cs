using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    float enemyspeed=3.0f;
    Animator anim;
    AudioSource enemyaudio;
    public AudioClip sound;
    ScoreScript score;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        enemyaudio = GetComponent<AudioSource>();
        score = GetComponent<ScoreScript>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            enemyaudio.clip = sound;
            enemyaudio.Play();
            anim.SetTrigger("Die");
            StartCoroutine("Wait");
            score.Increment();
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*enemyspeed*Time.deltaTime);
    }
}
