using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineMatOnOff : MonoBehaviour
{
    [SerializeField] private Material normalMat;
    [SerializeField] private Material outlineMat;
    [SerializeField] private Color player1Color;
    [SerializeField] private Color player2Color;
    [SerializeField] private Color player3Color;
    [SerializeField] private Color player4Color;
    private Renderer rend;
    private Material[] selectedMats;
    
    private void Awake()
    {
        rend = GetComponent<Renderer>();
    }

    private void Start()
    {
        selectedMats = rend.sharedMaterials;
    }



    // Listen to an event and activate/diactivate the outline effect



    private void OnMouseEnter() // needs a collider on the object
    {
        selectedMats[0] = normalMat;
        selectedMats[1] = outlineMat;

        rend.sharedMaterials = selectedMats;
        rend.sharedMaterials[1].SetColor("_Color", player1Color); // change p1 2 3 4 
        // rend.sharedMaterials[1].
    }

    private void OnMouseExit() // needs a collider on the object
    {
        selectedMats[0] = normalMat;
        selectedMats[1] = null;

        rend.sharedMaterials = selectedMats;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            selectedMats[0] = normalMat;
            selectedMats[1] = outlineMat;

            rend.sharedMaterials = selectedMats;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            selectedMats[0] = normalMat;
            selectedMats[1] = null;

            rend.sharedMaterials = selectedMats;
        }

    }


}
