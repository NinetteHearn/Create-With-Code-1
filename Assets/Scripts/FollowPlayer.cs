using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    [SerializeField] Vector3 offsetThird = new Vector3(0, 5, -7);
    [SerializeField] Vector3 offsetFirst = new Vector3(0, 2.5f, 0.8f);
    [SerializeField] Vector3 offsetView;

    // Start is called before the first frame update
    void Start()
    {
        offsetView = offsetThird;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offsetView;

        if (Input.GetKeyDown(KeyCode.Q))
        {
            ChangeView();
        }
    }

    void ChangeView()
    {
        if (offsetView == offsetThird)
        {
            offsetView = offsetFirst;
        }
        else 
        {
            offsetView = offsetThird;        
        }
    }
}
