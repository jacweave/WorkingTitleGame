using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.IO;

public class XMLHandler : MonoBehaviour {

    //Fields
    #region XMLHandler/Fields
    private static XmlTextReader _reader;
    #endregion

    //Properties
    #region XMLHandler/Properties
    public static XmlTextReader Reader { get { return _reader; } set { _reader = value; } }
    #endregion

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private static Dictionary<string,object> ReadBuildable(string path)
    {
        Reader = new XmlTextReader(path);
        Dictionary<string, object> attrDict = new Dictionary<string, object>();
        Reader.ReadToFollowing("Buildable");
        Reader.ReadToFollowing("BuildableType");
        attrDict.Add("BuildableType", Reader.Value);
        Reader.ReadToFollowing("BuildableAttributes");

        while (Reader.Read())
        {
            var name = "";
            var value = "";
            switch (Reader.NodeType)
            {
                case XmlNodeType.Element:
                    name = Reader.Name;
                    Reader.Read();
                    value = Reader.Value;
                    attrDict.Add(name, value);
                    Reader.Read();
                    break;
                default:
                    continue;
            }
            
        }

        Reader.Close();

        return attrDict;
    }

    public static UnitBuildable FillUnit(string path)
    {
        var attrDict = ReadBuildable(path);

        UnitBuildable unit = new UnitBuildable
        {
            VisibilityRange = (int)attrDict["VisibilityRange"],
            Size = (int)attrDict["Size"],
            Sprite = new SpriteRenderer(),
            MoveRange = (int)attrDict["MoveRange"],
            HealthCapacity = (int)attrDict["HealthCapacity"],
            DefenseStat = (int)attrDict["DefenseStat"],
            OffenseStat = (int)attrDict["OffenseStat"],
            MainActionRange = (int)attrDict["MainActionRange"]
        };
        unit.Sprite.sprite = Resources.Load<Sprite>(attrDict["SpritePath"].ToString());

        return unit;
    }

    public static BuildingBuildable FillBuilding(string path)
    {
        var attrDict = ReadBuildable(path);

        BuildingBuildable building = new BuildingBuildable
        {
            VisibilityRange = (int)attrDict["VisibilityRange"],
            Size = (int)attrDict["Size"],
            Sprite = new SpriteRenderer(),
            CapturePoints = (int)attrDict["CapturePoints"]
        };
        building.Sprite.sprite = Resources.Load<Sprite>(attrDict["SpritePath"].ToString());

        return building;
    }

    public static List<BuildingBuildable> LoadBuildingBuildables()
    {
        List<BuildingBuildable> buildables = new List<BuildingBuildable>();
        var xmls = Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Assets\\Resources\\XML\\Buildings");
        foreach (var p in xmls)
        {
            buildables.Add(FillBuilding(p));
        }

        return buildables;
    }

    public static List<UnitBuildable> LoadUnitBuildables()
    {
        List<UnitBuildable> buildables = new List<UnitBuildable>();
        var xmls = Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Assets\\Resources\\XML\\Units");
        foreach (var p in xmls)
        {
            buildables.Add(FillUnit(p));
        }

        return buildables;
    }
}
