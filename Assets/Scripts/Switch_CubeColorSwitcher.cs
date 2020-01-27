using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_CubeColorSwitcher : MonoBehaviour
{

    //1 = blue
    //2 = red
    //3 = green
    //4 = black

    public GameObject cube;
    private int _color;

    // Start is called before the first frame update
    void Start()
    {
      //   cube.GetComponent<Renderer>().material.color = new Vector4(1, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _color = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _color = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _color = 3;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _color = 4;
        }
        else if (Input.anyKeyDown)
        {
            _color = 5;
        }


        switch (_color)
        {
            case 1: //easy
                cube.GetComponent<Renderer>().material.color = new Vector4(1, 0, 0, 0);
                break;
            case 2: //medium
                cube.GetComponent<Renderer>().material.color = new Vector4(0, 0, 1, 0);
                break;
            case 3:
                cube.GetComponent<Renderer>().material.color = new Vector4(0, 1, 0, 0);
                break;
            case 4:
                cube.GetComponent<Renderer>().material.color = new Vector4(0, 0, 0, 0);
                break;
            default:
                cube.GetComponent<Renderer>().material.color = new Vector4(1, 1, 1, 0);
                break;
        }


    }
}
