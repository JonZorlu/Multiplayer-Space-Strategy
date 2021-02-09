using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HamCorGames.Gameplay
{
    [CreateAssetMenu(fileName = "UnitCardSO", menuName = "ScriptableObjects/UnitCardSO", order = 1)]
    public class UnitCardSO : ScriptableObject
    {
        [SerializeField] private UnitType unitType;

        [SerializeField] 
        private GameObject[] unitModelPrefabs;

        [SerializeField] [Tooltip("Right Click to Reset")] [ContextMenuItem("Reset to Default", nameof(SetBoxColliderCenterToDefault))] 
        private Vector3 boxColliderCenter;

        [SerializeField] [Tooltip("Right Click to Reset")] [ContextMenuItem("Reset to Default", nameof(SetBoxColliderSizeToDefault))]
        private Vector3 boxColliderSize;

        [SerializeField] [Tooltip("Right Click to Reset")] [ContextMenuItem("Reset to Default", nameof(SetOuterRangeToDefault))]
        private float outerRange;

        [SerializeField] [Tooltip("Right Click to Reset")] [ContextMenuItem("Reset to Default", nameof(SetInnerRangeToDefault))]
        private float innerRange;

        [SerializeField] [Tooltip("Right Click to Reset")] [ContextMenuItem("Reset to Default", nameof(SetModelSpawnHeightToDefault))]
        private float modelSpawnHeight = 0f;

        public GameObject[] UnitPrefabs => unitModelPrefabs;
        public Vector3 BoxColliderCenter => boxColliderCenter;
        public Vector3 BoxColliderSize => boxColliderSize;
        public float UnitOuterRange => outerRange;
        public float UnitInnerRange => innerRange;
        public float ModelSpawnHeight => modelSpawnHeight;

        #region Default Values

        private Vector3 defaultUnit0BoxColliderCenter = new Vector3(0.0008863807f, 0.2524748f, -0.001553059f);
        private Vector3 defaultUnit1BoxColliderCenter = new Vector3(0.0008863211f, 4.321574f, 0.001817703f);
        private Vector3 defaultUnit2BoxColliderCenter = new Vector3(0.002809644f, 4.44966f, 0.003503323f);
        private Vector3 defaultUnit3BoxColliderCenter = new Vector3(-0.001036882f, 4.245796f, -0.002266407f);
        private Vector3 defaultUnit4BoxColliderCenter = new Vector3(0.004679322f, 4.483024f, 0.003449917f);
        private Vector3 defaultUnit5BoxColliderCenter = new Vector3(0.00182128f, 4.67452f, 0.00344944f);
        private Vector3 defaultBuilding0BoxColliderCenter = new Vector3(0.0008864403f, 0.6546624f, 0.00185585f);
        private Vector3 defaultBuilding1BoxColliderCenter = new Vector3(-0.01516378f, 0.5663951f, -0.0001058578f);
        private Vector3 defaultBuilding2BoxColliderCenter = new Vector3(0.0008860826f, 0.4237281f, 0.002895832f);
        private Vector3 defaultBuilding3BoxColliderCenter = new Vector3(-0.0002839565f, 0.4016272f, 0.001251698f);
        private Vector3 defaultTurretBoxColliderCenter = new Vector3(-0.003050566f, 0.3255454f, 0.01093483f);

        private Vector3 defaultUnit0BoxColliderSize = new Vector3(0.5978431f, 0.4915521f, 0.7022448f);
        private Vector3 defaultUnit1BoxColliderSize = new Vector3(1.602302f, 0.6432323f, 1.672997f);
        private Vector3 defaultUnit2BoxColliderSize = new Vector3(2.798561f, 0.8994007f, 2.222415f);
        private Vector3 defaultUnit3BoxColliderSize = new Vector3(2.160044f, 0.4916716f, 1.826226f);
        private Vector3 defaultUnit4BoxColliderSize = new Vector3(2.091449f, 0.966115f, 2.94661f);
        private Vector3 defaultUnit5BoxColliderSize = new Vector3(2.234355f, 1.3491f, 2.980907f);
        private Vector3 defaultBuilding0BoxColliderSize = new Vector3(2.983703f, 1.295927f, 2.985853f);
        private Vector3 defaultBuilding1BoxColliderSize = new Vector3(2.293972f, 1.119393f, 2.016874f);
        private Vector3 defaultBuilding2BoxColliderSize = new Vector3(1.117439f, 0.8340586f, 0.9627981f);
        private Vector3 defaultBuilding3BoxColliderSize = new Vector3(0.6760273f, 0.8003228f, 0.6755228f);
        private Vector3 defaultTurretBoxColliderSize = new Vector3(0.5985622f, 0.6481593f, 0.7170219f);

        private float defaultUnit0OuterRange = 40f;
        private float defaultUnit1OuterRange = 50f;
        private float defaultUnit2OuterRange = 60f;
        private float defaultUnit3OuterRange = 60f;
        private float defaultUnit4OuterRange = 70f;
        private float defaultUnit5OuterRange = 70f;
        private float defaultBuilding0OuterRange = 80f;
        private float defaultBuilding1OuterRange = 70f;
        private float defaultBuilding2OuterRange = 50f;
        private float defaultBuilding3OuterRange = 40f;
        private float defaultTurretOuterRange = 60f;

        private float defaultUnit0InnerRange = 30f;
        private float defaultUnit1InnerRange = 40f;
        private float defaultUnit2InnerRange = 50f;
        private float defaultUnit3InnerRange = 50f;
        private float defaultUnit4InnerRange = 60f;
        private float defaultUnit5InnerRange = 60f;
        private float defaultBuilding0InnerRange = 70f;
        private float defaultBuilding1InnerRange = 60f;
        private float defaultBuilding2InnerRange = 40f;
        private float defaultBuilding3InnerRange = 30f;
        private float defaultTurretInnerRange = 50f;

        private float defaultUnit0ModelSpawnHeight = 0f;
        private float defaultUnit1ModelSpawnHeight = 4f;
        private float defaultUnit2ModelSpawnHeight = 4f;
        private float defaultUnit3ModelSpawnHeight = 4f;
        private float defaultUnit4ModelSpawnHeight = 4f;
        private float defaultUnit5ModelSpawnHeight = 4f;
        private float defaultBuilding0ModelSpawnHeight = 0f;
        private float defaultBuilding1ModelSpawnHeight = 0f;
        private float defaultBuilding2ModelSpawnHeight = 0f;
        private float defaultBuilding3ModelSpawnHeight = 0f;
        private float defaultTurretModelSpawnHeight = 0f;

        # endregion

        #region Default Setters

        private void SetBoxColliderCenterToDefault()
        {
            switch (unitType)
            {
                case UnitType.unit0_bot:
                boxColliderCenter = defaultUnit0BoxColliderCenter;
                break;

                case UnitType.unit1_fighterSmall:
                boxColliderCenter = defaultUnit1BoxColliderCenter;
                break;

                case UnitType.unit2_fighterBig:
                boxColliderCenter = defaultUnit2BoxColliderCenter;
                break;

                case UnitType.unit3_repairBot:
                boxColliderCenter = defaultUnit3BoxColliderCenter;
                break;

                case UnitType.unit4_bomberSmall:
                boxColliderCenter = defaultUnit4BoxColliderCenter;
                break;

                case UnitType.unit5_bomberBig:
                boxColliderCenter = defaultUnit5BoxColliderCenter;
                break;

                case UnitType.building0_comCenter:
                boxColliderCenter = defaultBuilding0BoxColliderCenter;
                break;

                case UnitType.building1_hangar:
                boxColliderCenter = defaultBuilding1BoxColliderCenter;
                break;

                case UnitType.building2_refinery:
                boxColliderCenter = defaultBuilding2BoxColliderCenter;
                break;

                case UnitType.building3_pylon:
                boxColliderCenter = defaultBuilding3BoxColliderCenter;
                break;

                case var unit when (unit == UnitType.turret0_single || unit == UnitType.turret1_double):
                boxColliderCenter = defaultTurretBoxColliderCenter;
                break;
            }
            
        }

        private void SetBoxColliderSizeToDefault()
        {
            switch (unitType)
            {
                case UnitType.unit0_bot:
                boxColliderSize = defaultUnit0BoxColliderSize;
                break;

                case UnitType.unit1_fighterSmall:
                boxColliderSize = defaultUnit1BoxColliderSize;
                break;

                case UnitType.unit2_fighterBig:
                boxColliderSize = defaultUnit2BoxColliderSize;
                break;

                case UnitType.unit3_repairBot:
                boxColliderSize = defaultUnit3BoxColliderSize;
                break;

                case UnitType.unit4_bomberSmall:
                boxColliderSize = defaultUnit4BoxColliderSize;
                break;

                case UnitType.unit5_bomberBig:
                boxColliderSize = defaultUnit5BoxColliderSize;
                break;

                case UnitType.building0_comCenter:
                boxColliderSize = defaultBuilding0BoxColliderSize;
                break;

                case UnitType.building1_hangar:
                boxColliderSize = defaultBuilding1BoxColliderSize;
                break;

                case UnitType.building2_refinery:
                boxColliderSize = defaultBuilding2BoxColliderSize;
                break;

                case UnitType.building3_pylon:
                boxColliderSize = defaultBuilding3BoxColliderSize;
                break;

                case var unit when (unit == UnitType.turret0_single || unit == UnitType.turret1_double):
                boxColliderSize = defaultTurretBoxColliderSize;
                break;
            }
        }

        private void SetOuterRangeToDefault()
        {
            switch (unitType)
            {
                case UnitType.unit0_bot:
                outerRange = defaultUnit0OuterRange;
                break;

                case UnitType.unit1_fighterSmall:
                outerRange = defaultUnit1OuterRange;
                break;

                case UnitType.unit2_fighterBig:
                outerRange = defaultUnit2OuterRange;
                break;

                case UnitType.unit3_repairBot:
                outerRange = defaultUnit3OuterRange;
                break;

                case UnitType.unit4_bomberSmall:
                outerRange = defaultUnit4OuterRange;
                break;

                case UnitType.unit5_bomberBig:
                outerRange = defaultUnit5OuterRange;
                break;

                case UnitType.building0_comCenter:
                outerRange = defaultBuilding0OuterRange;
                break;

                case UnitType.building1_hangar:
                outerRange = defaultBuilding1OuterRange;
                break;

                case UnitType.building2_refinery:
                outerRange = defaultBuilding2OuterRange;
                break;

                case UnitType.building3_pylon:
                outerRange = defaultBuilding3OuterRange;
                break;

                case var unit when (unit == UnitType.turret0_single || unit == UnitType.turret1_double):
                outerRange = defaultTurretOuterRange;
                break;
            }
        }

        private void SetInnerRangeToDefault()
        {
            // innerRange = defaultUnit0InnerRange;
            switch (unitType)
            {
                case UnitType.unit0_bot:
                innerRange = defaultUnit0InnerRange;
                break;

                case UnitType.unit1_fighterSmall:
                innerRange = defaultUnit1InnerRange;
                break;

                case UnitType.unit2_fighterBig:
                innerRange = defaultUnit2InnerRange;
                break;

                case UnitType.unit3_repairBot:
                innerRange = defaultUnit3InnerRange;
                break;

                case UnitType.unit4_bomberSmall:
                innerRange = defaultUnit4InnerRange;
                break;

                case UnitType.unit5_bomberBig:
                innerRange = defaultUnit5InnerRange;
                break;

                case UnitType.building0_comCenter:
                innerRange = defaultBuilding0InnerRange;
                break;

                case UnitType.building1_hangar:
                innerRange = defaultBuilding1InnerRange;
                break;

                case UnitType.building2_refinery:
                innerRange = defaultBuilding2InnerRange;
                break;

                case UnitType.building3_pylon:
                innerRange = defaultBuilding3InnerRange;
                break;

                case var unit when (unit == UnitType.turret0_single || unit == UnitType.turret1_double):
                innerRange = defaultTurretInnerRange;
                break;
            }
        }

        private void SetModelSpawnHeightToDefault()
        {
            switch (unitType)
            {
                case UnitType.unit0_bot:
                modelSpawnHeight = defaultUnit0ModelSpawnHeight;
                break;

                case UnitType.unit1_fighterSmall:
                modelSpawnHeight = defaultUnit1ModelSpawnHeight;
                break;

                case UnitType.unit2_fighterBig:
                modelSpawnHeight = defaultUnit2ModelSpawnHeight;
                break;

                case UnitType.unit3_repairBot:
                modelSpawnHeight = defaultUnit3ModelSpawnHeight;
                break;

                case UnitType.unit4_bomberSmall:
                modelSpawnHeight = defaultUnit4ModelSpawnHeight;
                break;

                case UnitType.unit5_bomberBig:
                modelSpawnHeight = defaultUnit5ModelSpawnHeight;
                break;

                case UnitType.building0_comCenter:
                modelSpawnHeight = defaultBuilding0ModelSpawnHeight;
                break;

                case UnitType.building1_hangar:
                modelSpawnHeight = defaultBuilding1ModelSpawnHeight;
                break;

                case UnitType.building2_refinery:
                modelSpawnHeight = defaultBuilding2ModelSpawnHeight;
                break;

                case UnitType.building3_pylon:
                modelSpawnHeight = defaultBuilding3ModelSpawnHeight;
                break;

                case var unit when (unit == UnitType.turret0_single || unit == UnitType.turret1_double):
                modelSpawnHeight = defaultTurretModelSpawnHeight;
                break;
            }
        }

        #endregion

    }

}