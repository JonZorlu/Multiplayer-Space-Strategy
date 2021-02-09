using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HamCorGames.Gameplay
{
    public enum UnitType 
    { 
        unit0_bot, unit1_fighterSmall, unit2_fighterBig, unit3_repairBot, unit4_bomberSmall, unit5_bomberBig,
        building0_comCenter, building1_hangar, building2_refinery, building3_pylon, turret0_single, turret1_double
    }
    public enum PlayerNo { player0_red, player1_blue, player2_yellow, player3_purple }

    [CreateAssetMenu(fileName = "UnitSO", menuName = "ScriptableObjects/UnitSO", order = 0)]
    public class UnitSO : ScriptableObject
    {
        [SerializeField] private Material normalMat;
        [SerializeField] private Material damagedMat;
        [SerializeField] private Material outlineMat;
        [SerializeField] private Color player0Color;
        [SerializeField] private Color player1Color;
        [SerializeField] private Color player2Color;
        [SerializeField] private Color player3Color;
        [SerializeField] private UnitCardSO[] unitCards;

        // [SerializeField] private GameObject[] unitPrefabs;
        // [SerializeField] private GameObject[] structurePrefabs;


        // [SerializeField] private Vector3 unit0BoxColliderCenter;
        // [SerializeField] private Vector3 unit0BoxColliderSize;
        // [SerializeField] private float unit0SpotLightOuterAngle; 
        // [SerializeField] private Vector3 unit1BoxColliderCenter;
        // [SerializeField] private Vector3 unit1BoxColliderSize;
        // [SerializeField] private float unit1SpotLightOuterAngle; 
        // [SerializeField] private Vector3 unit2BoxColliderCenter;
        // [SerializeField] private Vector3 unit2BoxColliderSize;
        // [SerializeField] private float unit2SpotLightOuterAngle;
        // [SerializeField] private Vector3 unit3BoxColliderCenter;
        // [SerializeField] private Vector3 unit3BoxColliderSize;
        // [SerializeField] private float unit3SpotLightOuterAngle;
        // [SerializeField] private Vector3 unit4BoxColliderCenter;
        // [SerializeField] private Vector3 unit4BoxColliderSize;
        // [SerializeField] private float unit4SpotLightOuterAngle;
        // [SerializeField] private Vector3 unit5BoxColliderCenter;
        // [SerializeField] private Vector3 unit5BoxColliderSize;
        // [SerializeField] private float unit5SpotLightOuterAngle;
        // [SerializeField] private Vector3 building0BoxColliderCenter;
        // [SerializeField] private Vector3 building0BoxColliderSize;
        // [SerializeField] private float building0SpotLightOuterAngle;
        // [SerializeField] private Vector3 building1BoxColliderCenter;
        // [SerializeField] private Vector3 building1BoxColliderSize;
        // [SerializeField] private float building1SpotLightOuterAngle;
        // [SerializeField] private Vector3 building2BoxColliderCenter;
        // [SerializeField] private Vector3 building2BoxColliderSize;
        // [SerializeField] private float building2SpotLightOuterAngle;
        // [SerializeField] private Vector3 building3BoxColliderCenter;
        // [SerializeField] private Vector3 building3BoxColliderSize;
        // [SerializeField] private float building3SpotLightOuterAngle;
        // [SerializeField] private Vector3 turretBoxColliderCenter;
        // [SerializeField] private Vector3 turretBoxColliderSize;
        // [SerializeField] private float turretSpotLightOuterAngle;

        public Material NormalMat => normalMat;
        public Material DamagedMat => damagedMat;
        public Material OutlineMat => outlineMat;
        public Color Player0Color => player0Color;
        public Color Player1Color => player1Color;
        public Color Player2Color => player2Color;
        public Color Player3Color => player3Color;
        public UnitCardSO[] UnitCards => unitCards;
        // public GameObject[] UnitPrefabs => unitPrefabs;
        // public GameObject[] StructurePrefabs => structurePrefabs;

        public GameObject GetUnit(UnitType unitType, PlayerNo playerNo, 
                                  out Vector3 boxColliderCenter, out Vector3 boxColliderSize, 
                                  out float spotLightOuterAngle, out float spotLightInnerAngle, out float spawnHeight)
        {
            GameObject unitToReturn = null;
            boxColliderCenter = Vector3.zero;
            boxColliderSize = Vector3.zero;
            spotLightOuterAngle = 0f;
            spotLightInnerAngle = 0f; 
            spawnHeight = 0f;

            switch (unitType)
            {
                case UnitType.unit0_bot:

                    switch (playerNo)
                    {
                        case PlayerNo.player0_red:
                        unitToReturn = unitCards[6].UnitPrefabs[0];
                        break;

                        case PlayerNo.player1_blue:
                        unitToReturn = unitCards[6].UnitPrefabs[1];
                        break;

                        case PlayerNo.player2_yellow:
                        unitToReturn = unitCards[6].UnitPrefabs[2];
                        break;

                        case PlayerNo.player3_purple:
                        unitToReturn = unitCards[6].UnitPrefabs[3];
                        break;
                    }

                    boxColliderCenter = unitCards[6].BoxColliderCenter;
                    boxColliderSize = unitCards[6].BoxColliderSize;
                    spotLightOuterAngle = unitCards[6].UnitOuterRange;
                    spotLightInnerAngle = unitCards[6].UnitInnerRange;
                    spawnHeight = unitCards[6].ModelSpawnHeight;

                break;

                case UnitType.unit1_fighterSmall:

                    switch (playerNo)
                    {
                        case PlayerNo.player0_red:
                        unitToReturn = unitCards[7].UnitPrefabs[0];
                        break;

                        case PlayerNo.player1_blue:
                        unitToReturn = unitCards[7].UnitPrefabs[1];
                        break;

                        case PlayerNo.player2_yellow:
                        unitToReturn = unitCards[7].UnitPrefabs[2];
                        break;

                        case PlayerNo.player3_purple:
                        unitToReturn = unitCards[7].UnitPrefabs[3];
                        break;
                    }

                    boxColliderCenter = unitCards[7].BoxColliderCenter;
                    boxColliderSize = unitCards[7].BoxColliderSize;
                    spotLightOuterAngle = unitCards[7].UnitOuterRange;
                    spotLightInnerAngle = unitCards[7].UnitInnerRange;
                    spawnHeight = unitCards[7].ModelSpawnHeight;

                break;

                case UnitType.unit2_fighterBig:

                    switch (playerNo)
                    {
                        case PlayerNo.player0_red:
                        unitToReturn = unitCards[8].UnitPrefabs[0];
                        break;

                        case PlayerNo.player1_blue:
                        unitToReturn = unitCards[8].UnitPrefabs[1];
                        break;

                        case PlayerNo.player2_yellow:
                        unitToReturn = unitCards[8].UnitPrefabs[2];
                        break;

                        case PlayerNo.player3_purple:
                        unitToReturn = unitCards[8].UnitPrefabs[3];
                        break;
                    }

                    boxColliderCenter = unitCards[8].BoxColliderCenter;
                    boxColliderSize = unitCards[8].BoxColliderSize;
                    spotLightOuterAngle = unitCards[8].UnitOuterRange;
                    spotLightInnerAngle = unitCards[8].UnitInnerRange;
                    spawnHeight = unitCards[8].ModelSpawnHeight;

                break;

                case UnitType.unit3_repairBot:

                    switch (playerNo)
                    {
                        case PlayerNo.player0_red:
                        unitToReturn = unitCards[9].UnitPrefabs[0];
                        break;

                        case PlayerNo.player1_blue:
                        unitToReturn = unitCards[9].UnitPrefabs[1];
                        break;

                        case PlayerNo.player2_yellow:
                        unitToReturn = unitCards[9].UnitPrefabs[2];
                        break;

                        case PlayerNo.player3_purple:
                        unitToReturn = unitCards[9].UnitPrefabs[3];
                        break;
                    }

                    boxColliderCenter = unitCards[9].BoxColliderCenter;
                    boxColliderSize = unitCards[9].BoxColliderSize;
                    spotLightOuterAngle = unitCards[9].UnitOuterRange;
                    spotLightInnerAngle = unitCards[9].UnitInnerRange;
                    spawnHeight = unitCards[9].ModelSpawnHeight;

                break;

                case UnitType.unit4_bomberSmall:

                    switch (playerNo)
                    {
                        case PlayerNo.player0_red:
                        unitToReturn = unitCards[10].UnitPrefabs[0];
                        break;

                        case PlayerNo.player1_blue:
                        unitToReturn = unitCards[10].UnitPrefabs[1];
                        break;

                        case PlayerNo.player2_yellow:
                        unitToReturn = unitCards[10].UnitPrefabs[2];
                        break;

                        case PlayerNo.player3_purple:
                        unitToReturn = unitCards[10].UnitPrefabs[3];
                        break;
                    }

                    boxColliderCenter = unitCards[10].BoxColliderCenter;
                    boxColliderSize = unitCards[10].BoxColliderSize;
                    spotLightOuterAngle = unitCards[10].UnitOuterRange;
                    spotLightInnerAngle = unitCards[10].UnitInnerRange;
                    spawnHeight = unitCards[10].ModelSpawnHeight;

                break;

                case UnitType.unit5_bomberBig:

                    switch (playerNo)
                    {
                        case PlayerNo.player0_red:
                        unitToReturn = unitCards[11].UnitPrefabs[0];
                        break;

                        case PlayerNo.player1_blue:
                        unitToReturn = unitCards[11].UnitPrefabs[1];
                        break;

                        case PlayerNo.player2_yellow:
                        unitToReturn = unitCards[11].UnitPrefabs[2];
                        break;

                        case PlayerNo.player3_purple:
                        unitToReturn = unitCards[11].UnitPrefabs[3];
                        break;
                    }

                    boxColliderCenter = unitCards[11].BoxColliderCenter;
                    boxColliderSize = unitCards[11].BoxColliderSize;
                    spotLightOuterAngle = unitCards[11].UnitOuterRange;
                    spotLightInnerAngle = unitCards[11].UnitInnerRange;
                    spawnHeight = unitCards[11].ModelSpawnHeight;

                break;

                case UnitType.building0_comCenter:

                    switch (playerNo)
                    {
                        case PlayerNo.player0_red:
                        unitToReturn = unitCards[0].UnitPrefabs[0];
                        break;

                        case PlayerNo.player1_blue:
                        unitToReturn = unitCards[0].UnitPrefabs[1];
                        break;

                        case PlayerNo.player2_yellow:
                        unitToReturn = unitCards[0].UnitPrefabs[2];
                        break;

                        case PlayerNo.player3_purple:
                        unitToReturn = unitCards[0].UnitPrefabs[3];
                        break;
                    }

                    boxColliderCenter = unitCards[0].BoxColliderCenter;
                    boxColliderSize = unitCards[0].BoxColliderSize;
                    spotLightOuterAngle = unitCards[0].UnitOuterRange;
                    spotLightInnerAngle = unitCards[0].UnitInnerRange;
                    spawnHeight = unitCards[0].ModelSpawnHeight;

                break;

                case UnitType.building1_hangar:

                    switch (playerNo)
                    {
                        case PlayerNo.player0_red:
                        unitToReturn = unitCards[1].UnitPrefabs[0];
                        break;

                        case PlayerNo.player1_blue:
                        unitToReturn = unitCards[1].UnitPrefabs[1];
                        break;

                        case PlayerNo.player2_yellow:
                        unitToReturn = unitCards[1].UnitPrefabs[2];
                        break;

                        case PlayerNo.player3_purple:
                        unitToReturn = unitCards[1].UnitPrefabs[3];
                        break;
                    }

                    boxColliderCenter = unitCards[1].BoxColliderCenter;
                    boxColliderSize = unitCards[1].BoxColliderSize;
                    spotLightOuterAngle = unitCards[1].UnitOuterRange;
                    spotLightInnerAngle = unitCards[1].UnitInnerRange;
                    spawnHeight = unitCards[1].ModelSpawnHeight;

                break;

                case UnitType.building2_refinery:

                    switch (playerNo)
                    {
                        case PlayerNo.player0_red:
                        unitToReturn = unitCards[2].UnitPrefabs[0];
                        break;

                        case PlayerNo.player1_blue:
                        unitToReturn = unitCards[2].UnitPrefabs[1];
                        break;

                        case PlayerNo.player2_yellow:
                        unitToReturn = unitCards[2].UnitPrefabs[2];
                        break;

                        case PlayerNo.player3_purple:
                        unitToReturn = unitCards[2].UnitPrefabs[3];
                        break;
                    }

                    boxColliderCenter = unitCards[2].BoxColliderCenter;
                    boxColliderSize = unitCards[2].BoxColliderSize;
                    spotLightOuterAngle = unitCards[2].UnitOuterRange;
                    spotLightInnerAngle = unitCards[2].UnitInnerRange;
                    spawnHeight = unitCards[2].ModelSpawnHeight;

                break;

                case UnitType.building3_pylon:

                    switch (playerNo)
                    {
                        case PlayerNo.player0_red:
                        unitToReturn = unitCards[3].UnitPrefabs[0];
                        break;

                        case PlayerNo.player1_blue:
                        unitToReturn = unitCards[3].UnitPrefabs[1];
                        break;

                        case PlayerNo.player2_yellow:
                        unitToReturn = unitCards[3].UnitPrefabs[2];
                        break;

                        case PlayerNo.player3_purple:
                        unitToReturn = unitCards[3].UnitPrefabs[3];
                        break;
                    }

                    boxColliderCenter = unitCards[3].BoxColliderCenter;
                    boxColliderSize = unitCards[3].BoxColliderSize;
                    spotLightOuterAngle = unitCards[3].UnitOuterRange;
                    spotLightInnerAngle = unitCards[3].UnitInnerRange;
                    spawnHeight = unitCards[3].ModelSpawnHeight;

                break;

                case UnitType.turret0_single:

                    switch (playerNo)
                    {
                        case PlayerNo.player0_red:
                        unitToReturn = unitCards[4].UnitPrefabs[0];
                        break;

                        case PlayerNo.player1_blue:
                        unitToReturn = unitCards[4].UnitPrefabs[1];
                        break;

                        case PlayerNo.player2_yellow:
                        unitToReturn = unitCards[4].UnitPrefabs[2];
                        break;

                        case PlayerNo.player3_purple:
                        unitToReturn = unitCards[4].UnitPrefabs[3];
                        break;
                    }

                    boxColliderCenter = unitCards[4].BoxColliderCenter;
                    boxColliderSize = unitCards[4].BoxColliderSize;
                    spotLightOuterAngle = unitCards[4].UnitOuterRange;
                    spotLightInnerAngle = unitCards[4].UnitInnerRange;
                    spawnHeight = unitCards[4].ModelSpawnHeight;

                break;
                
                case UnitType.turret1_double:

                    switch (playerNo)
                    {
                        case PlayerNo.player0_red:
                        unitToReturn = unitCards[5].UnitPrefabs[0];
                        break;

                        case PlayerNo.player1_blue:
                        unitToReturn = unitCards[5].UnitPrefabs[1];
                        break;

                        case PlayerNo.player2_yellow:
                        unitToReturn = unitCards[5].UnitPrefabs[2];
                        break;

                        case PlayerNo.player3_purple:
                        unitToReturn = unitCards[5].UnitPrefabs[3];
                        break;
                    }

                    boxColliderCenter = unitCards[5].BoxColliderCenter;
                    boxColliderSize = unitCards[5].BoxColliderSize;
                    spotLightOuterAngle = unitCards[5].UnitOuterRange;
                    spotLightInnerAngle = unitCards[5].UnitInnerRange;
                    spawnHeight = unitCards[5].ModelSpawnHeight;

                break;
            }

            return unitToReturn;
        }






       




    }
}
