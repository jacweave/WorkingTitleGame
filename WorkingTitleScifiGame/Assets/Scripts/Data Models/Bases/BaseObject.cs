using UnityEngine;
using System.Collections;

public class BaseObject {

    private GameObject _object;

    public GameObject Object { get { return _object; } set { _object = value; } }
    public SpriteRenderer Renderer { get { return _object.GetComponent<SpriteRenderer>(); } }
    public Transform Transform { get { return _object.transform; } }

    protected virtual void Init()
    {
        Object = new GameObject();
        Object.AddComponent<ObjectHandler>();
        Object.AddComponent<SpriteRenderer>();
        Object.GetComponent<ObjectHandler>().Updater = OnUpdate;
    }

    protected void DestroyObject()
    {
        GameObject.Destroy(Object);
    }

    public virtual void OnUpdate()
    {

    }
}
