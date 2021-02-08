using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HamCorGames.Gameplay
{
    public class Unit : MonoBehaviour
    {
        [SerializeField] private UnitSO unitSO;
        private BoxCollider boxCollider;
        private Renderer rend;
        private Material[] objSharedMats;
        private Light unitSpotLight;
        private int unitIndex = 0; // redundant delete
        
        public int UnitIndex // redundant delete
        {
            get => unitIndex;
            set => unitIndex = Mathf.Clamp(value, 0, unitSO.UnitPrefabs.Length);
        }

        private void Awake()
        {
            boxCollider = GetComponent<BoxCollider>();
            unitSpotLight = GetComponentInChildren<Light>(true);
        }

        private void Start()
        {
            // we can set the unit index with its setter from PlayerNetworkBehaviour
            

            // unitIndex = 0; // !!!!
            // GameObject unitGo = Instantiate(unitSO.UnitPrefabs[unitIndex], this.transform);
            
            GameObject unitGo = unitSO.GetUnit(UnitType.unit0_bot, PlayerNo.player0_red, 
                           out var boxColliderCenter, out var boxColliderSize,
                           out var unitSpotLightSpotAngle, out var unitSpotLightInnerSpotAngle);

            Instantiate(unitGo, this.transform);

            rend = GetComponentInChildren<Renderer>();
            objSharedMats = rend.sharedMaterials;
            
            boxCollider.isTrigger = true;
            boxCollider.center = boxColliderCenter;
            boxCollider.size = boxColliderSize;

            unitSpotLight.spotAngle = unitSpotLightSpotAngle;
            unitSpotLight.innerSpotAngle = unitSpotLightInnerSpotAngle;


            // Use this Script for also Structures and Turrests instead of the Structure Script


            // Save these values below as defaults in the UnitSO , make a method rightClick with Attributes, make ToolTips to tell 

            // switch (unitIndex) 
            // {
            //     case var index when index <= 11: // unit0
            //         boxCollider.center = new Vector3(0.0008863807f, 0.2524748f, -0.001553059f); 
            //         boxCollider.size = new Vector3(0.5978431f, 0.4915521f, 0.7022448f);

            //         unitSpotLight.spotAngle = 40f;
            //         unitSpotLight.innerSpotAngle = 30f;
            //         break;

            //     case var index when (index >= 12 && index <= 15): // unit1
            //         unitGo.transform.localPosition = new Vector3(0f, 4f, 0f);

            //         boxCollider.center = new Vector3(0.0008863211f, 4.321574f, 0.001817703f); 
            //         boxCollider.size = new Vector3(1.602302f, 0.6432323f, 1.672997f);

            //         unitSpotLight.spotAngle = 50f;
            //         unitSpotLight.innerSpotAngle = 40f;
            //         break; 

            //     case var index when (index >= 16 && index <= 19): // unit2
            //         unitGo.transform.localPosition = new Vector3(0f, 4f, 0f);
            //         boxCollider.center = new Vector3(0.002809644f, 4.44966f, 0.003503323f); 
            //         boxCollider.size = new Vector3(2.798561f, 0.8994007f, 2.222415f);

            //         unitSpotLight.spotAngle = 60f;
            //         unitSpotLight.innerSpotAngle = 50f;
            //         break;

            //     case var index when (index >= 20 && index <= 23 ): // unit3
            //         unitGo.transform.localPosition = new Vector3(0f, 4f, 0f);
            //         boxCollider.center = new Vector3(-0.001036882f, 4.245796f, -0.002266407f); 
            //         boxCollider.size = new Vector3(2.160044f, 0.4916716f, 1.826226f);

            //         unitSpotLight.spotAngle = 60f;
            //         unitSpotLight.innerSpotAngle = 50f;
            //         break;

            //     case var index when (index >= 24 && index <= 27 ): // unit4
            //         unitGo.transform.localPosition = new Vector3(0f, 4f, 0f);
            //         boxCollider.center = new Vector3(0.004679322f, 4.483024f, 0.003449917f); 
            //         boxCollider.size = new Vector3(2.091449f, 0.966115f, 2.94661f);

            //         unitSpotLight.spotAngle = 70f;
            //         unitSpotLight.innerSpotAngle = 60f;
            //         break;

            //     case var index when (index >= 28 && index <= 31 ): // unit5
            //         unitGo.transform.localPosition = new Vector3(0f, 4f, 0f);
            //         boxCollider.center = new Vector3(0.00182128f, 4.67452f, 0.00344944f); 
            //         boxCollider.size = new Vector3(2.234355f, 1.3491f, 2.980907f);

            //         unitSpotLight.spotAngle = 70f;
            //         unitSpotLight.innerSpotAngle = 60f;
            //         break;
            // }
            



        }



        // Listen to an event and activate/diactivate the outline effect



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
            if (Input.GetKeyDown(KeyCode.A))
            {
                objSharedMats[0] = unitSO.DamagedMat;

                if (objSharedMats[1] != unitSO.OutlineMat)
                {
                    objSharedMats[1] = null;
                }

                rend.sharedMaterials = objSharedMats;
            }

            if (Input.GetKeyDown(KeyCode.D))
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


