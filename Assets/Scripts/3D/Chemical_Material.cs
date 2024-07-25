using UnityEngine;

public class Chemical_Material : MonoBehaviour
{
    //here the choice of the form of matter is made
    public enum StateOfMatter
    {
        Liquid,
        Gas,
        Solid
    }

    //Variables are entered here
    [SerializeField] StateOfMatter MatterState;
    [SerializeField] ParentOfMaterials Material;
    Component _material;
    void Awake()
    {

    }

    void FixedUpdate()//Here logic is implemented for each form of matter
    {
        switch (MatterState)
        {
            case StateOfMatter.Liquid:

                break;
            case StateOfMatter.Gas:

                break;
            case StateOfMatter.Solid:
                if (Material != null)
                {
                    Material.CheckForChanges();
                }
                break;

        }
    }
}
