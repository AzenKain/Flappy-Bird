using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTon<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instant;
    public static T Instant => _instant;
    private void Awake()
    {
        if (_instant == null)
            _instant = this.GetComponent<T>();
        else if (_instant.GetInstanceID() != this.GetComponent<T>().GetInstanceID())
        {
            Destroy(this.GetComponent<T>());
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
