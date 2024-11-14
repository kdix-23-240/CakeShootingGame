using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleMaterial : Material
{
    public SampleMaterial()
    {
        this.hp = 10;
        this.speed = 0.01f;
    }

    public string GetCreamName()
    {
        return "SampleMaterail";
    }
}
