using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CicleFlight : Flight
{
    public CicleFlight()
    {
        type = FlightType.Triangle;
        name = "Enemy1";
        hp = 50;
        power = 5;
        speed = 2;
    }

    public override void Attack()
    {
        throw new System.NotImplementedException();
    }
}
