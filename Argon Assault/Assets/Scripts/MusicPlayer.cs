﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadNextScene", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(1);
    }

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
}