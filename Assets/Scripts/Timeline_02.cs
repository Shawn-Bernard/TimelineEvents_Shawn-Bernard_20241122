using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Timeline_02 : MonoBehaviour
{
    public PlayableDirector Timeline;
    private void OnTriggerEnter(Collider other)
    {
        Timeline.Play();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
