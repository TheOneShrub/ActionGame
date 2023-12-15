using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    // Start is called before the first frame update

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            source.PlayOneShot(clip);
        }
    }
}
