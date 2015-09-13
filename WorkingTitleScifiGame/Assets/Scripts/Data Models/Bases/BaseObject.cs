using UnityEngine;
using System.Collections;

public class BaseObject {

    private GameObject _object;

    public GameObject Obj { get { return _object; } set { _object = value; } }
    public SpriteRenderer Renderer { get { return _object.GetComponent<SpriteRenderer>(); } }
    public Transform Transform { get { return _object.transform; } }

    protected virtual void Init()
    {
        Obj = new GameObject();
        Obj.AddComponent<ObjectHandler>();
        Obj.AddComponent<SpriteRenderer>();
        Obj.GetComponent<ObjectHandler>().Updater = OnUpdate;
    }

    protected void DestroyObject()
    {
        GameObject.Destroy(Obj);
    }

    public virtual void OnUpdate()
    {

    }
}
