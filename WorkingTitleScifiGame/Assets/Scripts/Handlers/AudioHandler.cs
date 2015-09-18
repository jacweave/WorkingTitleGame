using UnityEngine;
using System.Collections;

public class AudioHandler : MonoBehaviour {

    private static AudioHandler instance = null;
    public static AudioHandler Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this) 
        {
            Destroy(this.gameObject);
            return;
        } 
        else 
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
