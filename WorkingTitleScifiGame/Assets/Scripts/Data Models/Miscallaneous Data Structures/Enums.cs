using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enums {

	public enum SessVars
    {
        LocalPlayer = 1,
        ActiveInst = 2,
        Camera = 3
    }

    public enum SortingLayers
    {
        BgLayer = 1,
        TilesLayer = 2,
        BuildingsLayer = 3,
        UnitsLayer = 4,
        FogLayer = 5,
        IndicLayer = 6
    }

    private static Dictionary<SortingLayers, string> _layersDict = new Dictionary<SortingLayers, string>
    {
        { SortingLayers.BgLayer, "BackGround" },
        { SortingLayers.TilesLayer, "Tiles" },
        { SortingLayers.BuildingsLayer, "Buildings" },
        { SortingLayers.UnitsLayer, "Units" },
        { SortingLayers.FogLayer, "Fog" },
        { SortingLayers.IndicLayer, "Indicators" },
    };

    public static string GetLayerName(SortingLayers l)
    {
        return _layersDict[l];
    }
}
