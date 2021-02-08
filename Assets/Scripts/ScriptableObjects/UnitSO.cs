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
        [SerializeField] private GameObject[] unitPrefabs;
        [SerializeField] private GameObject[] structurePrefabs;

        // private UnitType unitType;
        // private PlayerNo playerNo;

        [SerializeField] private Vector3 unit0BoxColliderCenter;
        [SerializeField] private Vector3 unit0BoxColliderSize;
        [SerializeField] private float unit0SpotLightOuterAngle; 
        [SerializeField] private Vector3 unit1BoxColliderCenter;
        [SerializeField] private Vector3 unit1BoxColliderSize;
        [SerializeField] private float unit1SpotLightOuterAngle; 
        [SerializeField] private Vector3 unit2BoxColliderCenter;
        [SerializeField] private Vector3 unit2BoxColliderSize;
        [SerializeField] private float unit2SpotLightOuterAngle;
        [SerializeField] private Vector3 unit3BoxColliderCenter;
        [SerializeField] private Vector3 unit3BoxColliderSize;
        [SerializeField] private float unit3SpotLightOuterAngle;
        [SerializeField] private Vector3 unit4BoxColliderCenter;
        [SerializeField] private Vector3 unit4BoxColliderSize;
        [SerializeField] private float unit4SpotLightOuterAngle;
        [SerializeField] private Vector3 unit5BoxColliderCenter;
        [SerializeField] private Vector3 unit5BoxColliderSize;
        [SerializeField] private float unit5SpotLightOuterAngle;
        [SerializeField] private Vector3 building0BoxColliderCenter;
        [SerializeField] private Vector3 building0BoxColliderSize;
        [SerializeField] private float building0SpotLightOuterAngle;
        [SerializeField] private Vector3 building1BoxColliderCenter;
        [SerializeField] private Vector3 building1BoxColliderSize;
        [SerializeField] private float building1SpotLightOuterAngle;
        [SerializeField] private Vector3 building2BoxColliderCenter;
        [SerializeField] private Vector3 building2BoxColliderSize;
        [SerializeField] private float building2SpotLightOuterAngle;
        [SerializeField] private Vector3 building3BoxColliderCenter;
        [SerializeField] private Vector3 building3BoxColliderSize;
        [SerializeField] private float building3SpotLightOuterAngle;
        [SerializeField] private Vector3 turretBoxColliderCenter;
        [SerializeField] private Vector3 turretBoxColliderSize;
        [SerializeField] private float turretSpotLightOuterAngle;

        public Material NormalMat => normalMat;
        public Material DamagedMat => damagedMat;
        public Material OutlineMat => outlineMat;
        public Color Player0Color => player0Color;
        public Color Player1Color => player1Color;
        public Color Player2Color => player2Color;
        public Color Player3Color => player3Color;
        public GameObject[] UnitPrefabs => unitPrefabs;
        public GameObject[] StructurePrefabs => structurePrefabs;
        
        // make a set to defaults in the so with a right click, 
        // tell that in the tooltips hover over values.

        public GameObject GetUnit(UnitType unitType, PlayerNo playerNo, 
                                  out Vector3 boxColliderCenter, out Vector3 boxColliderSize, 
                                  out float spotLightOuterAngle, out float spotLightInnerAngle)
        {
            GameObject unitToReturn = null;
            boxColliderCenter = Vector3.zero;
            boxColliderSize = Vector3.zero;
            spotLightOuterAngle = 0;
            spotLightInnerAngle = 0; // innerAngle is always -10 from the outerAngle

            switch (unitType)
            {
                case UnitType.unit0_bot:

                    switch (playerNo)
                    {
                        case PlayerNo.player0_red:
                        unitToReturn = unitPrefabs[0];
                        break;

                        case PlayerNo.player1_blue:
                        unitToReturn = unitPrefabs[1];
                        break;

                        case PlayerNo.player2_yellow:
                        unitToReturn = unitPrefabs[2];
                        break;

                        case PlayerNo.player3_purple:
                        unitToReturn = unitPrefabs[3];
                        break;
                    }

                    boxColliderCenter = unit0BoxColliderCenter;
                    boxColliderSize = unit0BoxColliderSize;
                    spotLightOuterAngle = unit0SpotLightOuterAngle;
                    spotLightInnerAngle = unit0SpotLightOuterAngle - 10f;

                break;

                case UnitType.unit1_fighterSmall:

                    switch (playerNo)
                    {
                        case PlayerNo.player0_red:
                        unitToReturn = unitPrefabs[12];
                        break;

                        case PlayerNo.player1_blue:
                        unitToReturn = unitPrefabs[13];
                        break;

                        case PlayerNo.player2_yellow:
                        unitToReturn = unitPrefabs[14];
                        break;

                        case PlayerNo.player3_purple:
                        unitToReturn = unitPrefabs[15];
                        break;
                    }

                    boxColliderCenter = unit1BoxColliderCenter;
                    boxColliderSize = unit1BoxColliderSize;
                    spotLightOuterAngle = unit1SpotLightOuterAngle;
                    spotLightInnerAngle = unit1SpotLightOuterAngle - 10f;

                break;

                case UnitType.unit2_fighterBig:

                    switch (playerNo)
                    {
                        case PlayerNo.player0_red:
                        unitToReturn = unitPrefabs[16];
                        break;

                        case PlayerNo.player1_blue:
                        unitToReturn = unitPrefabs[17];
                        break;

                        case PlayerNo.player2_yellow:
                        unitToReturn = unitPrefabs[18];
                        break;

                        case PlayerNo.player3_purple:
                        unitToReturn = unitPrefabs[19];
                        break;
                    }

                    boxColliderCenter = unit2BoxColliderCenter;
                    boxColliderSize = unit2BoxColliderSize;
                    spotLightOuterAngle = unit2SpotLightOuterAngle;
                    spotLightInnerAngle = unit2SpotLightOuterAngle - 10f;

                break;

                case UnitType.unit3_repairBot:

                    switch (playerNo)
                    {
                        case PlayerNo.player0_red:
                        unitToReturn = unitPrefabs[20];
                        break;

                        case PlayerNo.player1_blue:
                        unitToReturn = unitPrefabs[21];
                        break;

                        case PlayerNo.player2_yellow:
                        unitToReturn = unitPrefabs[22];
                        break;

                        case PlayerNo.player3_purple:
                        unitToReturn = unitPrefabs[23];
                        break;
                    }

                    boxColliderCenter = unit3BoxColliderCenter;
                    boxColliderSize = unit3BoxColliderSize;
                    spotLightOuterAngle = unit3SpotLightOuterAngle;
                    spotLightInnerAngle = unit3SpotLightOuterAngle - 10f;

                break;

                case UnitType.unit4_bomberSmall:

                    switch (playerNo)
                    {
                        case PlayerNo.player0_red:
                        unitToReturn = unitPrefabs[24];
                        break;

                        case PlayerNo.player1_blue:
                        unitToReturn = unitPrefabs[25];
                        break;

                        case PlayerNo.player2_yellow:
                        unitToReturn = unitPrefabs[26];
                        break;

                        case PlayerNo.player3_purple:
                        unitToReturn = unitPrefabs[27];
                        break;
                    }

                    boxColliderCenter = unit4BoxColliderCenter;
                    boxColliderSize = unit4BoxColliderSize;
                    spotLightOuterAngle = unit4SpotLightOuterAngle;
                    spotLightInnerAngle = unit4SpotLightOuterAngle - 10f;

                break;

                case UnitType.unit5_bomberBig:

                    switch (playerNo)
                    {
                        case PlayerNo.player0_red:
                        unitToReturn = unitPrefabs[28];
                        break;

                        case PlayerNo.player1_blue:
                        unitToReturn = unitPrefabs[29];
                        break;

                        case PlayerNo.player2_yellow:
                        unitToReturn = unitPrefabs[30];
                        break;

                        case PlayerNo.player3_purple:
                        unitToReturn = unitPrefabs[31];
                        break;
                    }

                    boxColliderCenter = unit5BoxColliderCenter;
                    boxColliderSize = unit5BoxColliderSize;
                    spotLightOuterAngle = unit5SpotLightOuterAngle;
                    spotLightInnerAngle = unit5SpotLightOuterAngle - 10f;

                break;

                case UnitType.building0_comCenter:

                    switch (playerNo)
                    {
                        case PlayerNo.player0_red:
                        unitToReturn = structurePrefabs[0];
                        break;

                        case PlayerNo.player1_blue:
                        unitToReturn = structurePrefabs[1];
                        break;

                        case PlayerNo.player2_yellow:
                        unitToReturn = structurePrefabs[2];
                        break;

                        case PlayerNo.player3_purple:
                        unitToReturn = structurePrefabs[3];
                        break;
                    }

                    boxColliderCenter = building0BoxColliderCenter;
                    boxColliderSize = building0BoxColliderSize;
                    spotLightOuterAngle = building0SpotLightOuterAngle;
                    spotLightInnerAngle = building0SpotLightOuterAngle - 10f;

                break;

                case UnitType.building1_hangar:

                    switch (playerNo)
                    {
                        case PlayerNo.player0_red:
                        unitToReturn = structurePrefabs[4];
                        break;

                        case PlayerNo.player1_blue:
                        unitToReturn = structurePrefabs[5];
                        break;

                        case PlayerNo.player2_yellow:
                        unitToReturn = structurePrefabs[6];
                        break;

                        case PlayerNo.player3_purple:
                        unitToReturn = structurePrefabs[7];
                        break;
                    }

                    boxColliderCenter = building1BoxColliderCenter;
                    boxColliderSize = building1BoxColliderSize;
                    spotLightOuterAngle = building1SpotLightOuterAngle;
                    spotLightInnerAngle = building1SpotLightOuterAngle - 10f;

                break;

                case UnitType.building2_refinery:

                    switch (playerNo)
                    {
                        case PlayerNo.player0_red:
                        unitToReturn = structurePrefabs[8];
                        break;

                        case PlayerNo.player1_blue:
                        unitToReturn = structurePrefabs[9];
                        break;

                        case PlayerNo.player2_yellow:
                        unitToReturn = structurePrefabs[10];
                        break;

                        case PlayerNo.player3_purple:
                        unitToReturn = structurePrefabs[11];
                        break;
                    }

                    boxColliderCenter = building2BoxColliderCenter;
                    boxColliderSize = building2BoxColliderSize;
                    spotLightOuterAngle = building2SpotLightOuterAngle;
                    spotLightInnerAngle = building2SpotLightOuterAngle - 10f;

                break;

                case UnitType.building3_pylon:

                    switch (playerNo)
                    {
                        case PlayerNo.player0_red:
                        unitToReturn = structurePrefabs[24];
                        break;

                        case PlayerNo.player1_blue:
                        unitToReturn = structurePrefabs[25];
                        break;

                        case PlayerNo.player2_yellow:
                        unitToReturn = structurePrefabs[26];
                        break;

                        case PlayerNo.player3_purple:
                        unitToReturn = structurePrefabs[27];
                        break;
                    }

                    boxColliderCenter = building3BoxColliderCenter;
                    boxColliderSize = building3BoxColliderSize;
                    spotLightOuterAngle = building3SpotLightOuterAngle;
                    spotLightInnerAngle = building3SpotLightOuterAngle - 10f;

                break;

                case UnitType.turret0_single:

                    switch (playerNo)
                    {
                        case PlayerNo.player0_red:
                        unitToReturn = structurePrefabs[28];
                        break;

                        case PlayerNo.player1_blue:
                        unitToReturn = structurePrefabs[29];
                        break;

                        case PlayerNo.player2_yellow:
                        unitToReturn = structurePrefabs[30];
                        break;

                        case PlayerNo.player3_purple:
                        unitToReturn = structurePrefabs[31];
                        break;
                    }

                    boxColliderCenter = turretBoxColliderCenter;
                    boxColliderSize = turretBoxColliderSize;
                    spotLightOuterAngle = turretSpotLightOuterAngle;
                    spotLightInnerAngle = turretSpotLightOuterAngle - 10f;

                break;
                
                case UnitType.turret1_double:

                    switch (playerNo)
                    {
                        case PlayerNo.player0_red:
                        unitToReturn = structurePrefabs[32];
                        break;

                        case PlayerNo.player1_blue:
                        unitToReturn = structurePrefabs[33];
                        break;

                        case PlayerNo.player2_yellow:
                        unitToReturn = structurePrefabs[34];
                        break;

                        case PlayerNo.player3_purple:
                        unitToReturn = structurePrefabs[35];
                        break;
                    }

                    boxColliderCenter = turretBoxColliderCenter;
                    boxColliderSize = turretBoxColliderSize;
                    spotLightOuterAngle = turretSpotLightOuterAngle;
                    spotLightInnerAngle = turretSpotLightOuterAngle - 10f;

                break;
            }

            return unitToReturn;
        }






       




    }
}
