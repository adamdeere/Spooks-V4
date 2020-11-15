using UnityEngine;

public class Shape : PersistableObject
{
    static int colourBlockID = Shader.PropertyToID("_Color");
    static MaterialPropertyBlock sharedPropertyBlock;
    private int shapeId = int.MinValue;
    private Color _colour;
    private SpriteRenderer _renderer;
    public int MaterialId { get; private set; }


    private void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
    }
    public void SetMaterial(Material matt, int mattId)
    {
        //TODO this will need to be changed to mesh renderer for 3d or 2.5d
        _renderer.material = matt;
        MaterialId = mattId;
    }

    public void SetColour(Color colour)
    {
        _colour = colour;
        if (sharedPropertyBlock == null)
            sharedPropertyBlock = new MaterialPropertyBlock();

        sharedPropertyBlock.SetColor(colourBlockID, _colour);
        _renderer.SetPropertyBlock(sharedPropertyBlock);
      
    }

    public int ShapeID
    {
        get
        {
            return shapeId;
        }
        set
        {
            if (shapeId == int.MinValue && value != int.MinValue)
            {
                shapeId = value;
            }
            else
            {
                Debug.LogError("not allowed to change shape id");
            }
            shapeId = value;
        }
    }

    public override void Load(GameDataReader reader)
    {
        base.Load(reader);
        SetColour(reader.ReadColour());
    }
    public override void Save(GameDataWriter writer)
    {
        base.Save(writer);
        writer.Write(_colour);
    }
}
