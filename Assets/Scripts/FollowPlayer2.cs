using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer2 : MonoBehaviour
{
    [SerializeField] GameObject player;
    private Vector3 offsetThirdPT = new Vector3(0, 5, 7);
    private Vector3 offsetFirstPT = new Vector3(0, 2.5f, -1.4f);
    private Vector3 offsetViewPT;

    // Start is called before the first frame update
    void Start()
    {
        offsetViewPT = offsetThirdPT;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offsetViewPT;

        if (Input.GetKeyDown(KeyCode.P))
        {
            ChangeView();
        }
    }

    void ChangeView()
    {
        if (offsetViewPT == offsetThirdPT)
        {
            offsetViewPT = offsetFirstPT;
        }
        else
        {
            offsetViewPT = offsetThirdPT;
        }
    }
}
