using UnityEngine;
using TMPro;

public class Cube : MonoBehaviour
{
    [SerializeField] private TMP_Text[] numbersText;

    [HideInInspector] public Color cubeColor;
    [HideInInspector] public int numberCube;
    [HideInInspector] public Rigidbody cubeRigid;
    [HideInInspector] public bool isMainCube;

    private MeshRenderer cubeMesh;

    private void Awake()
    {
        cubeMesh = GetComponent<MeshRenderer>();
        cubeRigid = GetComponent<Rigidbody>();        
    }

    private void SetColor(Color color)
    {
        cubeColor = color;
        cubeMesh.material.color = color;
    }
    
    private void SetNumber(int number)
    {
        numberCube = number;
        for (int i = 0; i < 6; i++)
        {
            numbersText[i].text = number.ToString();
        }

    }
}
