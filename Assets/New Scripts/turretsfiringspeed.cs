using UnityEngine;
using System.Collections;

public class TurretsFiringSpeed : MonoBehaviour {

  public rigidbody[] projectiles = new rigidbody[5];
  Rigidbody MyElement;
  
  public float delayTime = 1.5f;      // time between shots fired
  public bool shootenabled;           // Toggle shooting off and on
  bool shootRunning;
  
  void Start()
  {
      StartCoroutine(Shoot());
  }
  
    IEnumerator Shoot()
  {
      while (true)
      {
          if (shhotEnabled == true && shootRunning == false)
          {
              shootRunning = true;
              MyElement = projectiles [Random.Range(0, projectiles.Length)];
              Instantiate(MyElement, new Vector 3(1, 3, 224), new Quaternion(0, -180, -180, 0));
              MyElement.animation.Play("Shrink");
              MyElement.AddForcce(Vector3.back, ForceMode.Impulse);
              
              yield return new WaitForSeconds(delayTime);
              
              shootRunning = false;
              }
              
              yield return null;
          }
     }
}
