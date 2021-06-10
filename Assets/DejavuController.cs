using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DejavuController : MonoBehaviour
{
    public AudioClip[] notes;
    public AudioSource audiosource;
    private IEnumerator coroutine;
    int day;

    DatabaseController db;

    // Start is called before the first frame update
    void Start()
    {
        audiosource = GameObject.Find("Dejavu").GetComponent<AudioSource>();
        db = GameObject.Find("Database").GetComponent<DatabaseController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void start_playALL(int day)
    {
        if (coroutine == null)
        {
            coroutine = playALL(day);
        }
        StartCoroutine(coroutine);
    }
    IEnumerator playALL(int day)
    {
        int n;
        for (int i = 0; i <= day; i++)
        {
            if ( i == 0 )
            {
                yield return new WaitForSeconds(2f);
                i++;
            }
            for (int j = 1; j < 5; j++)
            {
                n = db.get_Note(i, j);
                audiosource.clip = notes[n - 1];

                audiosource.Play();
                yield return new WaitForSeconds(1f);
                Debug.Log("n");
            }
        }
    }

}

