﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueLCD
{
    namespace Models
    {
        public class E
        {
            public int abilityLevel { get; set; }
            public string displayName { get; set; }
            public string id { get; set; }
            public string rawDescription { get; set; }
            public string rawDisplayName { get; set; }
        }

        public class Passive
        {
            public string displayName { get; set; }
            public string id { get; set; }
            public string rawDescription { get; set; }
            public string rawDisplayName { get; set; }
        }

        public class Q
        {
            public int abilityLevel { get; set; }
            public string displayName { get; set; }
            public string id { get; set; }
            public string rawDescription { get; set; }
            public string rawDisplayName { get; set; }
        }

        public class R
        {
            public int abilityLevel { get; set; }
            public string displayName { get; set; }
            public string id { get; set; }
            public string rawDescription { get; set; }
            public string rawDisplayName { get; set; }
        }

        public class W
        {
            public int abilityLevel { get; set; }
            public string displayName { get; set; }
            public string id { get; set; }
            public string rawDescription { get; set; }
            public string rawDisplayName { get; set; }
        }

        public class Abilities
        {
            public E E { get; set; }
            public Passive Passive { get; set; }
            public Q Q { get; set; }
            public R R { get; set; }
            public W W { get; set; }
        }

        public class ChampionStats
        {
            public double abilityPower { get; set; }
            public double armor { get; set; }
            public double armorPenetrationFlat { get; set; }
            public double armorPenetrationPercent { get; set; }
            public double attackDamage { get; set; }
            public double attackRange { get; set; }
            public double attackSpeed { get; set; }
            public double bonusArmorPenetrationPercent { get; set; }
            public double bonusMagicPenetrationPercent { get; set; }
            public double cooldownReduction { get; set; }
            public double critChance { get; set; }
            public double critDamage { get; set; }
            public double currentHealth { get; set; }
            public double healthRegenRate { get; set; }
            public double lifeSteal { get; set; }
            public double magicLethality { get; set; }
            public double magicPenetrationFlat { get; set; }
            public double magicPenetrationPercent { get; set; }
            public double magicResist { get; set; }
            public double maxHealth { get; set; }
            public double moveSpeed { get; set; }
            public double physicalLethality { get; set; }
            public double resourceMax { get; set; }
            public double resourceRegenRate { get; set; }
            public string resourceType { get; set; }
            public double resourceValue { get; set; }
            public double spellVamp { get; set; }
            public double tenacity { get; set; }
        }

        public class GeneralRune
        {
            public string displayName { get; set; }
            public int id { get; set; }
            public string rawDescription { get; set; }
            public string rawDisplayName { get; set; }
        }

        public class Keystone
        {
            public string displayName { get; set; }
            public int id { get; set; }
            public string rawDescription { get; set; }
            public string rawDisplayName { get; set; }
        }

        public class PrimaryRuneTree
        {
            public string displayName { get; set; }
            public int id { get; set; }
            public string rawDescription { get; set; }
            public string rawDisplayName { get; set; }
        }

        public class SecondaryRuneTree
        {
            public string displayName { get; set; }
            public int id { get; set; }
            public string rawDescription { get; set; }
            public string rawDisplayName { get; set; }
        }

        public class StatRune
        {
            public int id { get; set; }
            public string rawDescription { get; set; }
        }

        public class FullRunes
        {
            public List<GeneralRune> generalRunes { get; set; }
            public Keystone keystone { get; set; }
            public PrimaryRuneTree primaryRuneTree { get; set; }
            public SecondaryRuneTree secondaryRuneTree { get; set; }
            public List<StatRune> statRunes { get; set; }
        }

        public class ActivePlayer
        {
            public Abilities abilities { get; set; }
            public ChampionStats championStats { get; set; }
            public double currentGold { get; set; }
            public FullRunes fullRunes { get; set; }
            public int level { get; set; }
            public string summonerName { get; set; }
        }

        public class Runes
        {
            public Keystone keystone { get; set; }
            public PrimaryRuneTree primaryRuneTree { get; set; }
            public SecondaryRuneTree secondaryRuneTree { get; set; }
        }

        public class Scores
        {
            public int assists { get; set; }
            public int creepScore { get; set; }
            public int deaths { get; set; }
            public int kills { get; set; }
            public double wardScore { get; set; }
        }

        public class SummonerSpellOne
        {
            public string displayName { get; set; }
            public string rawDescription { get; set; }
            public string rawDisplayName { get; set; }
        }

        public class SummonerSpellTwo
        {
            public string displayName { get; set; }
            public string rawDescription { get; set; }
            public string rawDisplayName { get; set; }
        }

        public class SummonerSpells
        {
            public SummonerSpellOne summonerSpellOne { get; set; }
            public SummonerSpellTwo summonerSpellTwo { get; set; }
        }

        public class AllPlayer
        {
            public string championName { get; set; }
            public bool isBot { get; set; }
            public bool isDead { get; set; }
            public List<object> items { get; set; }
            public int level { get; set; }
            public string position { get; set; }
            public string rawChampionName { get; set; }
            public double respawnTimer { get; set; }
            public Runes runes { get; set; }
            public Scores scores { get; set; }
            public int skinID { get; set; }
            public string summonerName { get; set; }
            public SummonerSpells summonerSpells { get; set; }
            public string team { get; set; }
        }

        public class Event
        {
            public int EventID { get; set; }
            public string EventName { get; set; }
            public double EventTime { get; set; }
        }

        public class Events
        {
            [JsonProperty("Events")]
            public List<Event> GameEvents { get; set; }
        }

        public class GameData
        {
            public string gameMode { get; set; }
            public double gameTime { get; set; }
            public string mapName { get; set; }
            public int mapNumber { get; set; }
            public string mapTerrain { get; set; }
        }

        public class LiveGame
        {
            public ActivePlayer activePlayer { get; set; }
            public List<AllPlayer> allPlayers { get; set; }
            public Events events { get; set; }
            public GameData gameData { get; set; }
        }


    }
}
