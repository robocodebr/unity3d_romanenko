﻿using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class MainGame : MonoBehaviour
{

    public GameObject SnakeHead;

    GameObject SnakeObj;

    int gameMode = 0;
    // Start is called before the first frame update
    void Start()
    {
       //createSnake();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void createSnake()
    {


        SnakeObj = Instantiate(SnakeHead) as GameObject;
        SnakeObj.name = "Snake";
        gameMode = 1;


    }


    void OnGUI()
    {
        int posX = Screen.width / 2;
        int posY = Screen.height / 2;
        switch (gameMode)
        {

            case 0:
                GUI.Button(new Rect(new Vector2(posX - 100, posY), new Vector2(200, 30)), "START GAME");
                break;
            case 1: break;

        }
    }

}
