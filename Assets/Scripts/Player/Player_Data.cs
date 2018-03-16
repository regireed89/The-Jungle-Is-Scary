﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "PlayerData")]
public class Player_Data : ScriptableObject {

    public int hp = 4;
    public int lives = 3;
    public bool alive;
    public int damage;
}
