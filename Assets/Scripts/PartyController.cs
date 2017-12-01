﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils.Extensions;

public class PartyController : MonoBehaviour
{
    private List<CharacterComponent> _charactersQueue;
    private CharacterComponent _currentCharacter;

    void Awake()
    {
        _charactersQueue = new List<CharacterComponent>();
        GenerateQueue();
        _currentCharacter = _charactersQueue[0];
    }
	
    // Update is called once per frame
    void Update()
    {
		
    }

    private void GenerateQueue()
    {
        CharacterComponent[] characters = Resources.FindObjectsOfTypeAll<CharacterComponent>();
        _charactersQueue.AddRange(characters);
        _charactersQueue.Shuffle();
    }

    void Next()
    {
        
    }
}