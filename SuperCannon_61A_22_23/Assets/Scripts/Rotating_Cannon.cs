using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class Rotating_Cannon : MonoBehaviour
{
    Vector3 mousePoint3D;
    Quaternion newrotation;

    Quaternion clampRotationLow, clampRotationHigh;

    public ObjectPool bullet1pool, bullet2pool;

    private CannonFiring _firingInstance;

  //  public Transform fireposition;
    // Start is called before the first frame update
    void Start()
    {
        clampRotationLow = Quaternion.Euler(0, 0, -70);
        Debug.Log(clampRotationLow);
        clampRotationHigh = Quaternion.Euler(0, 0, 70);
        Debug.Log(clampRotationHigh);

        _firingInstance = GetComponentInChildren(typeof(CannonFiring)) as CannonFiring;

    }

    // Update is called once per frame
    void Update()
    {
        PointAtMouse();
        BulletFiring();
    }

    void PointAtMouse()
    {
        mousePoint3D = GameData.MousePos;
        newrotation = Quaternion.LookRotation(transform.position - mousePoint3D, Vector3.forward);
        newrotation.x = 0;
        newrotation.y = 0;
        newrotation.z = Mathf.Clamp(newrotation.z, clampRotationLow.z, clampRotationHigh.z);
        newrotation.w = Mathf.Clamp(newrotation.w, clampRotationLow.w, clampRotationHigh.w);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, newrotation, Time.deltaTime * 3f);
        //this.transform.rotation = newrotation;
    }


    void BulletFiring()
    {
        if (CrossPlatformInputManager.GetButtonDown("Fire1"))
        {
            GameObject smallbullet = bullet1pool.GetPooledObject();
            if (_firingInstance != null) _firingInstance.CannonFire(smallbullet);
           // Instantiate(bullet1prefab, this.gameObject.transform.GetChild(0).position, Quaternion.identity);
        }

        if (CrossPlatformInputManager.GetButtonDown("Fire2"))
        {
            GameObject largebullet = bullet2pool.GetPooledObject();
            if (_firingInstance != null) _firingInstance.CannonFire(largebullet);

        }

    }




}
