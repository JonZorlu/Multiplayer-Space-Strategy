using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HamCorGames.Gameplay
{
    public class Unit : MonoBehaviour
    {
        [SerializeField] private Material normalMat;
        [SerializeField] private Material damagedMat;
        [SerializeField] private Material outlineMat;
        [SerializeField] private Color player0Color;
        [SerializeField] private Color player1Color;
        [SerializeField] private Color player2Color;
        [SerializeField] private Color player3Color;
        [SerializeField] private GameObject[] unitPrefabs;

        private BoxCollider boxCollider;
        private Renderer rend;
        private Material[] objSharedMats;
        private Light unitSpotLight;
        private int unitIndex = 0;
        
        public int UnitIndex
        {
            get => unitIndex;
            set => unitIndex = Mathf.Clamp(value, 0, unitPrefabs.Length);
        }

        private void Awake()
        {
            boxCollider = GetComponent<BoxCollider>();
            unitSpotLight = GetComponentInChildren<Light>(true);
        }

        private void Start()
        {
            // we can set the unit index with its setter from PlayerNetworkBehaviour
            
            Instantiate(unitPrefabs[unitIndex], this.transform);

            rend = GetComponentInChildren<Renderer>();

            objSharedMats = rend.sharedMaterials;
            
            boxCollider.isTrigger = true;

            switch (unitIndex) 
            {
                case var index when index <= 11: // unit0
                    boxCollider.center = new Vector3(0.0008863807f, 0.2524748f, -0.001553059f); 
                    boxCollider.size = new Vector3(0.5978431f, 0.4915521f, 0.7022448f);

                    unitSpotLight.innerSpotAngle = 30f;
                    unitSpotLight.spotAngle = 40f;
                    break;

                case var index when (index >= 12 && index <= 15): // unit1
                    // boxCollider.center = new Vector3(0.0008863807f, 0.2524748f, -0.001553059f); 
                    // boxCollider.size = new Vector3(0.5978431f, 0.4915521f, 0.7022448f);

                    // unitSpotLight.innerSpotAngle = 30f;
                    // unitSpotLight.spotAngle = 40f;
                    break; 

                case var index when (index >= 16 && index <= 19): // unit2
                    // boxCollider.center = new Vector3(0.0008863807f, 0.2524748f, -0.001553059f); 
                    // boxCollider.size = new Vector3(0.5978431f, 0.4915521f, 0.7022448f);

                    // unitSpotLight.innerSpotAngle = 30f;
                    // unitSpotLight.spotAngle = 40f;
                    break;

                case var index when (index >= 20 && index <= 23 ): // unit3
                    // boxCollider.center = new Vector3(0.0008863807f, 0.2524748f, -0.001553059f); 
                    // boxCollider.size = new Vector3(0.5978431f, 0.4915521f, 0.7022448f);

                    // unitSpotLight.innerSpotAngle = 30f;
                    // unitSpotLight.spotAngle = 40f;
                    break;

                case var index when (index >= 24 && index <= 27 ): // unit4
                    // boxCollider.center = new Vector3(0.0008863807f, 0.2524748f, -0.001553059f); 
                    // boxCollider.size = new Vector3(0.5978431f, 0.4915521f, 0.7022448f);

                    // unitSpotLight.innerSpotAngle = 30f;
                    // unitSpotLight.spotAngle = 40f;
                    break;

                case var index when (index >= 28 && index <= 31 ): // unit5
                    // boxCollider.center = new Vector3(0.0008863807f, 0.2524748f, -0.001553059f); 
                    // boxCollider.size = new Vector3(0.5978431f, 0.4915521f, 0.7022448f);

                    // unitSpotLight.innerSpotAngle = 30f;
                    // unitSpotLight.spotAngle = 40f;
                    break;
            }
            



        }



        // Listen to an event and activate/diactivate the outline effect



        private void OnMouseEnter() 
        {
            objSharedMats[0] = normalMat;
            objSharedMats[1] = outlineMat;

            rend.sharedMaterials = objSharedMats;
            rend.sharedMaterials[1].SetColor("_Color", player0Color); // change p1 2 3 4 
        }

        private void OnMouseExit() 
        {
            objSharedMats[0] = normalMat;
            objSharedMats[1] = null;

            rend.sharedMaterials = objSharedMats;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                objSharedMats[0] = damagedMat;

                if (objSharedMats[1] != outlineMat)
                {
                    objSharedMats[1] = null;
                }

                rend.sharedMaterials = objSharedMats;
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                objSharedMats[0] = normalMat;

                if (objSharedMats[1] != outlineMat)
                {
                    objSharedMats[1] = null;
                }

                rend.sharedMaterials = objSharedMats;
            }

        }

    
    }
}


