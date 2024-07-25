using Unity.VisualScripting;
using UnityEngine;

public class ParentOfMaterials2D : MonoBehaviour
{
    //Variables are entered here
    [SerializeField] protected bool fuel = false;
    [SerializeField] protected float CombustionTemperature = 100f;
    [SerializeField] protected float Temperature = 20f;
    public float EnergyPotential = 1f;
    [SerializeField] protected Sprite BurntSprite;
    protected SpriteRenderer spriteRenderer;
    public GameObject FirePrefab;

    [SerializeField] protected float ElectricalConductivityc = 1.0f;
    protected bool IsBurn = false;
    
    

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
        {
            Debug.LogError("Add SpriteRenderer.");
        }
    }
    public virtual void CheckForChanges() //here is the logic that should fire every frame 
    {
        StartBurn();
    }
    //Next we write your methods for simulating your chemical processes.


   
    public void Heating(float tempretureScale)
    {
        if (fuel)
        {
            Temperature += tempretureScale;
            if (Temperature > CombustionTemperature)
            {
                Temperature = CombustionTemperature;
            }
        }
    }
    private void StartBurn()
    {

        if (fuel && (CombustionTemperature <= Temperature))
        {
            Instantiate(FirePrefab, transform.position, Quaternion.identity, this.transform);
            EnergyPotential -= 1;
            fuel = false;
            if (EnergyPotential > 0)
            {
               
            }

        }

    }
    public void EndBurn()
    {
        if (spriteRenderer != null && BurntSprite != null)
        {
            spriteRenderer.sprite = BurntSprite;
        }
    }



}
