using UnityEngine;

public class ParentOfMaterials: MonoBehaviour
{
    //Variables are entered here
    [SerializeField] bool fuel = false;
    [SerializeField] float CombustionTemperature = 100f;
    [SerializeField] float Temperature = 20f;
    [SerializeField] float EnergyPotential = 0f;
    [SerializeField] float BurningRate = 1f;

    [SerializeField] float ElectricalConductivityc = 1.0f;
    protected bool IsBurn = false;
    

    public void CheckForChanges() //here is the logic that should fire every frame 
    {

    }
    //Next we write your methods for simulating your chemical processes.
}
