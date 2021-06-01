using UnityEngine;
using TMPro;

public class Cube : MonoBehaviour
{
    static int staticID = 0;

    [SerializeField] private TMP_Text[] numbersText;

    [HideInInspector] public int CubeID;
    [HideInInspector] public Color cubeColor;
    [HideInInspector] public int cubeNumber;
    [HideInInspector] public Rigidbody cubeRigid;
    [HideInInspector] public bool isMainCube;

    private MeshRenderer cubeMesh;

    private void Awake()
    {
        CubeID = staticID++;
        cubeMesh = GetComponent<MeshRenderer>();
        cubeRigid = GetComponent<Rigidbody>();        
    }

    public void SetColor(Color color)
    {
        cubeColor = color;
        cubeMesh.material.color = color;
    }
    
    public void SetNumber(int number)
    {
        cubeNumber = number;
        for (int i = 0; i < 6; i++)
        {
            numbersText[i].text = number.ToString();
        }

    }
}
