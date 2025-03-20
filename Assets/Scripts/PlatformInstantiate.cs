using System.Collections.Generic;
using UnityEngine;

public class PlatformInstantiate : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> platforms;
    [SerializeField]
    private int initialPlatforms = 10;
    private float offsetPositionX = 0f;

    public void Start()
    {
        offsetPositionX = 0;
        InstantiatePlatforms(initialPlatforms);  
    }

    public void InstantiatePlatforms(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            int randomIndex = Random.Range(0, platforms.Count);
            if (offsetPositionX != 0) 
            {
                offsetPositionX += platforms[randomIndex].GetComponent<BoxCollider>().size.x * 0.5f;
            }
            GameObject plataform = Instantiate(platforms[randomIndex], Vector3.zero, Quaternion.identity);
            offsetPositionX += plataform.GetComponent<BoxCollider>().size.x * 0.5f;
            plataform.transform.SetParent(transform);
            plataform.transform.localPosition = new Vector3(offsetPositionX, 0,0);            
        }
    }

    public void Restart()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
        Start();
    }
}
