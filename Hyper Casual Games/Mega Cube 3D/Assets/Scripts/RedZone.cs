using UnityEngine ;
using TMPro;
using UnityEngine.UI;


public class RedZone : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI gameoverTile;
    
     private void OnTriggerStay (Collider other)
     {
        Cube cube = other.GetComponent <Cube> () ;
        if (cube != null)
         {
           if (!cube.isMainCube && cube.cubeRigid.velocity.magnitude < .1f)
           {
                gameoverTile.gameObject.SetActive(true);
                GameManager.Instance.isGameOver = true;
                GameManager.Instance.pauseButton.gameObject.SetActive(false);
                GameManager.Instance.GameOverButt();
           }
        }
     }
   
}
