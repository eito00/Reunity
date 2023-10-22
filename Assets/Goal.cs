using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject clearText;
    public GameObject nextButton;
    public AudioSource AudioSource;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ÉSÅ[ÉãÅI");

        clearText.SetActive(true);
        nextButton.SetActive(true);
        AudioSource.Play();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
