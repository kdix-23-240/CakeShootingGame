using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleMaterial1 : Material
{
    public SampleMaterial1()
    {
        this.hp = 10;
        this.speed = 0.01f;
    }

    public string GetCreamName()
    {
        return "SampleMaterail";
    }
}
