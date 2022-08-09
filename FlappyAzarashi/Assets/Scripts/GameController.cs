﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    enum State
    {
        Ready,
        Play,
        GameOver
    }
    State state;
    int score;

    public AzarashiController azarashi;
    public GameObject blocks;
    public Text scoreText;
    public Text stateText;
    // Start is called before the first frame update
    void Start()
    {
        Ready();

    }

    // Update is called once per frame
    void LateUpdate()
    {
        switch(state)
        {
            case State.Ready:
                if (Input.GetButtonDown("Fire1")) GameStart();
                break;
            case State.Play:
                if (azarashi.IsDead()) GameOver();
                break;
            case State.GameOver:
                if (Input.GetButtonDown("Fire1")) Reload();
                break;
        }

    }
    void Ready()
    {
        state=State.Ready;

        azarashi.SetSteerAvtive(false);
        blocks.SetActive(false);

        scoreText.text="Score :"+0;

        stateText.gameObject.SetActive(true);
        stateText.text="Ready";
    }

    void GameStart()
    {
        state=State.Play;

        azarashi.SetSteerAvtive(true);
        blocks.SetActive(false);

        azarashi.Flap();

        stateText.gameObject.SetActive(false);
        stateText.text="";
    }

    void GameOver()
    {
        state=State.GameOver;

        ScrollObject[] scrollObjects=FindObjectsOfType<ScrollObject>();

        foreach(ScrollObject so in scrollObjects)so.enabled=false;

        stateText.gameObject.SetActive(true);
        stateText.text="GameOver";

    }
    void Reload()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text="Score :"+score;
    }
}
