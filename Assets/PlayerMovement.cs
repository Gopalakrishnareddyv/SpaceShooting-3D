using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    Animator anim;
    AudioSource audio;
    public AudioClip sound;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            audio.clip = sound;
            audio.Play();
            anim.SetTrigger("Die");
            StartCoroutine("Wait");
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        //Destroy(this.gameObject);\
        SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)&&transform.position.x>=1)
        {
            transform.Translate(Vector3.left);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow)&& transform.position.x<=9.3f)
        {
            transform.Translate(Vector3.right);
        }
       
    }
}
