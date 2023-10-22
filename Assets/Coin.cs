using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource AudioSource;

    private void Start()
    {
        // AudioSource�R���|�[�l���g���擾
        AudioSource = GetComponent<AudioSource>();

        // AudioSource���擾�ł��Ă��邩�f�o�b�O���O�Ŋm�F
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
        // AudioSource�R���|�[�l���g�������ł���ΗL�������Ă���Đ�
        if (!AudioSource.isPlaying)
        {
            AudioSource.enabled = true;
        }

        // SE���Đ�
        AudioSource.Play();
    }
}
