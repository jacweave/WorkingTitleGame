using UnityEngine;
using System.Collections;

public class BaseObject {
    
    public GameObject Obj;
    public SpriteRenderer Renderer { get { return Obj.GetComponent<SpriteRenderer>(); } }
    public Transform Transform { get { return Obj.transform; } }

    protected virtual void Init()
    {
        if (Obj == null)
        {
            Obj = new GameObject();
            Obj.AddComponent<ObjectHandler>();
            Obj.AddComponent<SpriteRenderer>();
            Obj.GetComponent<ObjectHandler>().Updater = OnUpdate;
        }
    }

    protected void DestroyObject()
    {

    }

    public virtual void OnUpdate()
    {

    }
}
