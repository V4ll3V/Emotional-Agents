﻿using Assets.Scripts.Emotions;
using Assets.Scripts.Goals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Agents
{
    public enum EmotionState
    {
        happy,
        pride,
        resilent,
        fearfull,
        angry,
        sad,
        supprised,
        hate,
    }

    public enum ActiveEmotionPair
    {
        JoyDispair,
        FearHope,
        ShamePride,
        DisappointmentRelief,
        AngerGratitude,
        ReporachAdmiration,
        LoveHate,
    }

    public class Agent
    {
        public AgentModule AgentModule;

        public List<Emotion> ActiveEmotions;
        public Dictionary<ActiveEmotionPair, float> ActiveEmotionPairs;
        public AgentPersonality AgentPersontality;

        public List<Goal> ActiveGoals;
        public List<GameObject> Attitudes;
        public int HP;
        public EmotionState EmotionState;

        public AgentType AgentType;

        public Agent (AgentModule module, AgentType type, int hp)
        {
            AgentModule = module;
            AgentModule.Agent = this;
            ActiveEmotions = new List<Emotion>();
            ActiveEmotionPairs = new Dictionary<ActiveEmotionPair, float>();
            AgentType = type;
            HP = hp;
            EmotionState = EmotionState.resilent;
        }
    }
}
