using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Manager;
using Cinemachine;

namespace Player {
    public class PlayerSpawnpoint : MonoBehaviour
    {
        public Controller player;

        private GameObject inst;

        public void Start()
        {
            SpawnPlayer();
        }

        public void SpawnPlayer()
        {
            if (player == null) return;
            inst = Instantiate(player.prefab);
            inst.name = player.name;
            inst.transform.position = transform.position;
        }
    }
}
