﻿using System.Collections;using System.Collections.Generic;using UnityEngine;using UnityEngine.UI;public class HUD : MonoBehaviour {    public Sprite[] HeartSprites;    public Image HeartUI;    private PlayerController player;    private void Start()    {        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();    }    private void Update()    {        if(HeartUI) HeartUI.sprite = HeartSprites[player.currentHealth];    }}