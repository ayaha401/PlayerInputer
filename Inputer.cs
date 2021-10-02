using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inputer : IInputer
{
    float IInputer.HoriMove()
    {
        return Input.GetAxisRaw("Horizontal");
    }

    float IInputer.VertMove()
    {
        return Input.GetAxisRaw("Vertical");
    }
}