using System;
using UnityEngine;

public class Chat : MonoBehaviour
{
  [SerializeField] private string name;
  private int age;
  private float weight;
  private string race;

  public string GetName()
  {
    return name;
  }

  public int GetAge()
  {
    return age;
  }

  

  void Start()
  {
    
  }
}
