using UnityEngine;
using UnityEditor;

public class MaterialLog2D : ParentOfMaterials2D
{
    [MenuItem("AssetDatabase/LoadAssetExample")]
    private void Reset()//The starting values for other materials change here
    {
        fuel = true;
        CombustionTemperature = 100f;
        Temperature = 20f;
        EnergyPotential = 3f;
        ElectricalConductivityc = 0f;
        FirePrefab = (GameObject)AssetDatabase.LoadAssetAtPath("Assets/Scripts/2D/FirePF.prefab",typeof(GameObject));
        
}
public override void CheckForChanges()
    {
    base.CheckForChanges();
    //here the parent method CheckForChanges is complemented()
    }
}