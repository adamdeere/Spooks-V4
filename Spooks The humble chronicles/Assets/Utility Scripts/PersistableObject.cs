using UnityEngine;

[DisallowMultipleComponent]
public class PersistableObject : MonoBehaviour
{
    public virtual void Save(GameDataWriter writer)
    {
        writer.Write(transform.localPosition);
        writer.Write(transform.localRotation);
        writer.Write(transform.localScale);
    }

    public virtual void Load(GameDataReader reader)
    {
        transform.localPosition = reader.ReadVectorThree();
        transform.localRotation = reader.ReadQuatenion();
        transform.localScale = reader.ReadVectorThree();
    }
}
