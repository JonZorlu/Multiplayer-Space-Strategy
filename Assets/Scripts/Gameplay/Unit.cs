using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HamCorGames.Gameplay
{
    public class Unit : MonoBehaviour
    {
        [Header("Right Click Unit Script Header to Spawn & Despawn Model")]
        [SerializeField] private UnitType unitType;
        [SerializeField] private PlayerNo playerNo;
        [SerializeField] private UnitSO unitSO;
        private BoxCollider boxCollider;
        private Renderer rend;
        private Material[] objSharedMats;
        private Light unitSpotLight;

        private void OnValidate()
        {
            boxCollider = GetComponent<BoxCollider>();
            unitSpotLight = GetComponentInChildren<Light>(true);
        }

        private void Awake()
        {
            boxCollider = GetComponent<BoxCollider>();
            unitSpotLight = GetComponentInChildren<Light>(true);
        }

        private void Start()
        {
            SpawnUnitModel();
        }

        [ContextMenu("Spawn Unit Model")]
        private void SpawnUnitModel()
        {
            GameObject unitToSpawn = unitSO.GetUnit(unitType, playerNo, 
                           out var boxColliderCenter, out var boxColliderSize,
                           out var unitSpotLightSpotAngle, out var unitSpotLightInnerSpotAngle, out var unitModelSpawnHeight);

            GameObject unitGo = Instantiate(unitToSpawn, this.transform); 
            unitGo.transform.localPosition = new Vector3(0f, unitModelSpawnHeight, 0f);

            rend = GetComponentInChildren<Renderer>();
            objSharedMats = rend.sharedMaterials;
            
            boxCollider.isTrigger = true;
            boxCollider.center = boxColliderCenter;
            boxCollider.size = boxColliderSize;

            unitSpotLight.spotAngle = unitSpotLightSpotAngle;
            unitSpotLight.innerSpotAngle = unitSpotLightInnerSpotAngle;
        }

        [ContextMenu("Despawn Unit Model")]
        private void DespawnUnitMoidel()
        {
            if (GetComponentInChildren<Renderer>(true) != null)
                DestroyImmediate(GetComponentInChildren<Renderer>(true).gameObject);
        }




        // Listen to an event and activate/diactivate the outline effect
        // Below is for testing purposes, wip


        private void OnMouseEnter() 
        {
            objSharedMats[0] = unitSO.NormalMat;
            objSharedMats[1] = unitSO.OutlineMat;

            rend.sharedMaterials = objSharedMats;
            rend.sharedMaterials[1].SetColor("_Color", unitSO.Player0Color); // change p1 2 3 4 
        }

        private void OnMouseExit() 
        {
            objSharedMats[0] = unitSO.NormalMat;
            objSharedMats[1] = null;

            rend.sharedMaterials = objSharedMats;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                objSharedMats[0] = unitSO.DamagedMat;

                if (objSharedMats[1] != unitSO.OutlineMat)
                {
                    objSharedMats[1] = null;
                }

                rend.sharedMaterials = objSharedMats;
            }

            if (Input.GetKeyDown(KeyCode.H))
            {
                objSharedMats[0] = unitSO.NormalMat;

                if (objSharedMats[1] != unitSO.OutlineMat)
                {
                    objSharedMats[1] = null;
                }

                rend.sharedMaterials = objSharedMats;
            }

        }

    
    }
}


