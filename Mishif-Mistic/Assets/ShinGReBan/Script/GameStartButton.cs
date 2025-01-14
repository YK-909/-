﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SelectCharacter
{
    public class GameStartButton : MonoBehaviour
    {
        private SceneTransition sceneTransition;
        public static int head2;
        public static int head;

        //ADX設定
        public CriAtomSource SlotDecisionSrc;

        public GameObject KimariButton1;
        public GameObject KimeraButton2;

        // Start is called before the first frame update
        void Start()
        {
            sceneTransition = FindObjectOfType<SceneTransition>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnGameStart()
        {
            //音鳴らす
            SlotDecisionSrc.Play();
            
            Invoke("OnGameStart2", 2.0f);
            
        }

        public void OnGameStart2()
        {
            //MyGameManagerDateに保存されている次のシーンに移動
            sceneTransition.GameStart();
        }
    }
}
