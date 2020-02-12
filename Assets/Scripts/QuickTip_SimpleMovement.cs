using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickTip_SimpleMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    [SerializeField]
    private float _horizontalInput;
    [SerializeField]
    private float _verticalInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(_horizontalInput, _verticalInput, 0) * _speed * Time.deltaTime);
        
    }
}
