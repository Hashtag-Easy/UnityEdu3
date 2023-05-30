using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
   
public class GameManager : MonoBehaviour
{
   public GameObject endPanel;
   private GameObject[] allBoxes;
   
   public void RestartGame()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

   public void Update()
   {
      allBoxes = GameObject.FindGameObjectsWithTag("Box");

      if (allBoxes.Length == 0)
      {
         endPanel.SetActive(true);
      }
   }
}
