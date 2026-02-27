using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class ObjectPool : MonoBehaviour
{
    // create a field for the prefab GameObject. 

    public GameObject bullet;

    // create a field for the number of GameObjects to spawn
    public int numberOfBullets = 20;
    // create a list of GameObjects called _pool which will hold references to all spawned GameObjects
    List<GameObject> _pool = new List<GameObject>();
    // in Awake, spawn the appropriate amount of bullets. 
    // be sure to disable them and add them to your list as you go. 
    private void Awake()
    {
        for (int i = 0; i < numberOfBullets; i++)
        {
            Instantiate(bullet);
            bullet.SetActive(false);
            _pool.Add(bullet);
        }
    }

    // create a method called GetGameObject which returns a GameObject. 
    // It should look for a GameObject which is not active, returning the first one that it finds. 
    // If there is no inactive one, return null. 

    public GameObject GetGameObject()
    {
        if (bullet.activeInHierarchy == false)
        {
            return bullet;
        }

        else
        {
            return null;
        }
    }

}
