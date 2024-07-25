using UnityEngine;
using System.Collections.Generic;

public class Fire2D : MonoBehaviour
{
    [SerializeField] CapsuleCollider2D CC2d;
    private List<GameObject> objectsInTrigger = new List<GameObject>();
    private float TimeLeft=1f;
    private float Timer = 10f;
    private GameObject creator;
    private ParentOfMaterials2D POM2D;

    private void Start()
    {
        creator = transform.parent.gameObject;
        POM2D = creator.GetComponent<ParentOfMaterials2D>();

        if (creator == null)
        {
            Destroy(gameObject);
        }
        else  if(POM2D != null)
        {
            Timer *= POM2D.EnergyPotential;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject obj = other.gameObject;
        if (!objectsInTrigger.Contains(obj))
        {
            objectsInTrigger.Add(obj);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        GameObject obj = other.gameObject;
        if (objectsInTrigger.Contains(obj))
        {
            objectsInTrigger.Remove(obj);
        }
    }

    private void Update()
    {
        Timer -= Time.deltaTime;
        TimeLeft -= Time.deltaTime;
        if (TimeLeft <= 0)
        {
            TimeLeft = 1f;
            foreach (GameObject obj in objectsInTrigger)
            {
                ParentOfMaterials2D Material = obj.GetComponent<ParentOfMaterials2D>();
                if (Material != null)
                {
                    Material.Heating(30f);
                }
            }
        }
        if(Timer <= 0)
        {
            creator.GetComponent<ParentOfMaterials2D>().EndBurn();
            Destroy(gameObject);
        }
        
    }
    
}
