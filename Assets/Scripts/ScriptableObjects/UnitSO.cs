using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HamCorGames.Gameplay
{
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

        public Material NormalMat => normalMat;
        public Material DamagedMat => damagedMat;
        public Material OutlineMat => outlineMat;
        public Color Player0Color => player0Color;
        public Color Player1Color => player1Color;
        public Color Player2Color => player2Color;
        public Color Player3Color => player3Color;
        public GameObject[] UnitPrefabs => unitPrefabs;
        public GameObject[] StructurePrefabs => structurePrefabs;
        
        






       




    }
}
