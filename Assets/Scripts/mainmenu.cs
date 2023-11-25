using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainmenu : MonoBehaviour
{
 public void LoadScene(string scenename){
 SceneManager.LoadScene(scenename);
 }
 public void Keluar(){
 Application.Quit();
}
public void LoadRandomScene(){
    int index = Random.Range(1, 3);
    SceneManager.LoadScene(index);
    Debug.Log("Scene Loaded");
}
}