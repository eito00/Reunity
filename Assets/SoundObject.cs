using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundObject : MonoBehaviour
{
    private static SoundObject instance;

    public static SoundObject Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<SoundObject>();
                if(instance == null)
                {
                    GameObject obj = new GameObject("oundObject");
                    instance = obj.AddComponent<SoundObject>();
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
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
