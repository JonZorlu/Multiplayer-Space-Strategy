using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HamCorGames.Gameplay
{
    public class Structure : MonoBehaviour
    {
        [SerializeField] private UnitSO unitSO;
        private BoxCollider boxCollider;
        private Renderer rend;
        private Material[] objSharedMats;
        private Light unitSpotLight;
        private int unitIndex = 0;
        
        public int UnitIndex
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
            

            unitIndex = 32; // !!!!


            GameObject unitGo = Instantiate(unitSO.StructurePrefabs[unitIndex], this.transform); 

            rend = GetComponentInChildren<Renderer>();

            objSharedMats = rend.sharedMaterials;
            
            boxCollider.isTrigger = true;

            switch (unitIndex) 
            {
                case var index when index <= 3: // building0_commandCenter
                    boxCollider.center = new Vector3(0.0008864403f, 0.6546624f, 0.00185585f); 
                    boxCollider.size = new Vector3(2.983703f, 1.295927f, 2.985853f);

                    unitSpotLight.spotAngle = 80f;
                    unitSpotLight.innerSpotAngle = 70f;
                    break;

                case var index when (index >= 4 && index <= 7): // building1_hangar
                    boxCollider.center = new Vector3(-0.01516378f, 0.5663951f, -0.0001058578f); 
                    boxCollider.size = new Vector3(2.293972f, 1.119393f, 2.016874f);

                    unitSpotLight.spotAngle = 70f;
                    unitSpotLight.innerSpotAngle = 60f;
                    break; 

                case var index when (index >= 8 && index <= 23): // building2_refinery
                    boxCollider.center = new Vector3(0.0008860826f, 0.4237281f, 0.002895832f); 
                    boxCollider.size = new Vector3(1.117439f, 0.8340586f, 0.9627981f);

                    unitSpotLight.spotAngle = 50f;
                    unitSpotLight.innerSpotAngle = 40f;
                    break;

                case var index when (index >= 24 && index <= 27 ): // building3_pylon
                    boxCollider.center = new Vector3(-0.0002839565f, 0.4016272f, 0.001251698f); 
                    boxCollider.size = new Vector3(0.6760273f, 0.8003228f, 0.6755228f);

                    unitSpotLight.spotAngle = 40f;
                    unitSpotLight.innerSpotAngle = 30f;
                    break;

                case var index when (index >= 28 && index <= 31 ): // turret0_single
                    boxCollider.center = new Vector3(-0.003050566f, 0.3255454f, 0.01093483f); 
                    boxCollider.size = new Vector3(0.5985622f, 0.6481593f, 0.7170219f);

                    unitSpotLight.spotAngle = 60f;
                    unitSpotLight.innerSpotAngle = 50f;
                    break;

                case var index when (index >= 32 && index <= 35 ): // turret0_double
                    boxCollider.center = new Vector3(-0.003050566f, 0.3255454f, 0.01093483f); 
                    boxCollider.size = new Vector3(0.5985622f, 0.6481593f, 0.7170219f);

                    unitSpotLight.spotAngle = 60f;
                    unitSpotLight.innerSpotAngle = 50f;
                    break;
            }
            



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


