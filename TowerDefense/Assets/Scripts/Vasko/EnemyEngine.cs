﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Threading;

    class EnemyEngine : MonoBehaviour
    {
        public GameObject enemy;
        public GameObject startPos;
        public int enemies = 10;
        public float timeBetweenWaves = 5;
        public float timeThicks = 0.3f;

        private int DefaultEnemies;
        private float DefaultTimeBetweenWaves;


        void Start()
        {
            DefaultEnemies = enemies;
            DefaultTimeBetweenWaves = timeBetweenWaves;
        }

        void Update()
        {
            timeBetweenWaves -= Time.deltaTime;
            if (timeBetweenWaves <= 0)
            {
                Instantiate(enemy, startPos.transform.position, this.transform.rotation);
                enemies--;
                timeBetweenWaves = timeThicks;

                if (enemies < 0)
                {
                    timeBetweenWaves = DefaultTimeBetweenWaves;
                    enemies = DefaultEnemies;
                }
            }
        }

        public bool MeasureTime(float time)
        {
            time -= Time.deltaTime;
            if (time <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
