using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource AudioSource;

    private void Start()
    {
        // AudioSourceコンポーネントを取得
        AudioSource = GetComponent<AudioSource>();

        // AudioSourceが取得できているかデバッグログで確認
        if (AudioSource != null)
        {
            Debug.Log("AudioSource is valid.");
        }
        else
        {
            Debug.Log("AudioSource is null.");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            PlaySE();
        }
    }

    private void PlaySE()
    {
        // AudioSourceコンポーネントが無効であれば有効化してから再生
        if (!AudioSource.isPlaying)
        {
            AudioSource.enabled = true;
        }

        // SEを再生
        AudioSource.Play();
    }
}
