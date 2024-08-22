using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    private GameObject player;
    public GameObject particles;
    private AudioClip dieEffect;
    GameObject sounds;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        dieEffect = Resources.Load<AudioClip>("splash-death-splash-46048");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            StartCoroutine(CDieEffect());
        }
    }

    IEnumerator CDieEffect()
    {
        Instantiate(particles, player.transform.position, player.transform.rotation);
        sounds = GameObject.Find("SoundEffects(Clone)");
        sounds.GetComponent<AudioSource>().PlayOneShot(dieEffect);
        if(player.activeSelf)
        {
            SceneLoader.deathCounter++;
        }
        player.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        SceneLoader.reloadScene();
    }
}