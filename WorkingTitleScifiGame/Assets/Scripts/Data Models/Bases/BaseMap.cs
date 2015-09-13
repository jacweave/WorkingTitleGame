using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class BaseMap : BaseObject
{

    //Fields
    #region BaseMap/Fields
    private Dimension _dim;
    private BaseTile[,] _tiles;
    private Sprite _bg;
    #endregion

    //Properties
    #region BaseMap/Properties
    public int DimensionX { get { return _dim.X; } set { _dim.X = value; } }
    public int DimensionY { get { return _dim.Y; } set { _dim.Y = value; } }
    public Dimension Dimensions { get { return _dim; } set { _dim = value; } }
    public BaseTile[,] Tiles { get { return _tiles; } set { _tiles = value; } }
    public Sprite Background { get { return _bg; } set { _bg = value; } }
    #endregion

    //Constructors
    #region BaseMap/Constructors
    protected override void Init()
    {
        base.Init();
        Background = Resources.Load<Sprite>("Art/Backgrounds/BackgroundPH");
        Renderer.sortingLayerName = Enums.GetLayerName(Enums.SortingLayers.BgLayer);
        Renderer.sprite = Resources.Load<Sprite>("Art/Backgrounds/BackgroundPH");
        Transform.localScale = new Vector3(100f, 100f, 0f);
        Transform.position = new Vector3(-10f, -10f, 0f);
    }
    public BaseMap() : base()
    {
        Init();
    }

    public BaseMap(Dimension dim) : base()
    {
        Init();
        Dimensions = dim;
        Tiles = new BaseTile[dim.X, dim.Y];
        Background = Resources.Load<Sprite>("Art/Backgrounds/BackgroundPHMat");
    }

    public BaseMap(BaseTile[,] tile)
    {
        Init();
        Tiles = tile;
        Dimensions = new Dimension(tile.GetUpperBound(0) + 1, tile.GetUpperBound(1) + 1);
        Background = Resources.Load<Sprite>("Art/Backgrounds/BackgroundPHMat");
    }

    public BaseMap(Dimension dim, BaseTile[,] tile)
    {
        Init();
        Dimensions = dim;
        Tiles = tile;
        Background = Resources.Load<Sprite>("Art/Backgrounds/BackgroundPHMat");
    }
    #endregion

    #region BaseMap/GetTile
    public BaseTile GetTileAt(Dimension location)
    {
        try
        {
            return Tiles[location.X, location.Y];
        }
        catch
        {
            return null;
        }
    }

    public BaseTile GetTileAt(int x, int y)
    {
        try
        {
            return Tiles[x, y];
        }
        catch
        {
            return null;
        }
    }
    #endregion

    public int GetDistance(BaseTile t1, BaseTile t2)
    {
        return Math.Abs(t1.PositionX - t2.PositionX) + Math.Abs(t1.PositionY - t2.PositionY);
    }

    public List<Dimension> GetPath(BaseTile t1, BaseTile t2)
    {
        List<Dimension> ret = new List<Dimension>();
        Dictionary<Dimension, bool> checkDict = new Dictionary<Dimension, bool>();
        Queue<Node> nodeQueue = new Queue<Node>();
        Node start = new Node(t1.Position);
        nodeQueue.Enqueue(start);
        checkDict.Add(start.dim, true);

        while (nodeQueue.Count > 0)
        {
            Node head = nodeQueue.Dequeue();
            if (Tiles[head.dim.X,head.dim.Y].Equals(t2))
            {
                var parent = head;
                while (parent.dim != t1.Position)
                {
                    ret.Add(parent.dim);
                    parent = parent.parent;
                }

                return ret; 
            }

            foreach(var t in GetNeighbors(Tiles[head.dim.X,head.dim.Y]))
            {
                if (checkDict.ContainsKey(t.Position))
                    continue;
                nodeQueue.Enqueue(new Node(head, t.Position));
                checkDict.Add(t.Position, true);
            }
        }

        return null;
    }

    public List<BaseTile> GetNeighbors(BaseTile tile)
    {
       var neighbors = new List<Dimension> 
                        {
                           new Dimension(tile.PositionX + 1, tile.PositionY),
                            new Dimension(tile.PositionX - 1, tile.PositionY),
                            new Dimension(tile.PositionX, tile.PositionY + 1),
                            new Dimension(tile.PositionX, tile.PositionY - 1)
                        };

       var ret = new List<BaseTile>();

        foreach(var t in neighbors)
        {
            if (Inbounds(t))
                ret.Add(Tiles[t.X,t.Y]);
        }

        return ret;
    }

    private bool Inbounds(Dimension d)
    {
        return d.X >= 0 && d.X < DimensionX && d.Y >= 0 && d.Y < DimensionY;
    }

    public void MoveControllable(UnitControllable controllable, BaseTile tile)
    {
        var controllableX = controllable.Position.X;
        var controllableY = controllable.Position.Y;
        var path = GetPath(Tiles[controllableX, controllableY], tile);

        if (path != null && path.Count <= controllable.MoveStatus)
        {
            Tiles[controllableX, controllableY].Contents.Remove(controllable);
            tile.Contents.Add(controllable);
            controllable.Move(tile.Position, path.Count);
        }
    }

    public static BaseMap RandomMap()
    {
        var rX = UnityEngine.Random.Range(15, 51);
        var rY = UnityEngine.Random.Range(15, 51);

        return new BaseMap(new Dimension(rX, rY));
    }
}
