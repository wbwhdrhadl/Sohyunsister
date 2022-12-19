using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectScript : MonoBehaviour
{
    Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        Anim.SetFloat("Speed", 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            Anim.SetFloat("Speed", 1f);
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            Anim.SetFloat("Speed", 0f);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            Anim.SetFloat("Speed", -1f);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Anim.GetFloat("Speed") == 0f)
            {
                Anim.SetFloat("Speed", 1f);
            }
            else 
            {
                Anim.SetFloat("Speed", 0f);
            }
        }
    }

    private void OnMouseDown()
    {
        if (Anim.GetFloat("Speed") == 0f)
        {
            Anim.SetFloat("Speed", 1f);
        }
        else 
        {
            Anim.SetFloat("Speed", 0f);
        }
    }
}
