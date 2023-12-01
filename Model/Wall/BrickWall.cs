﻿namespace HouseBuilder.Model.Wall;

public class BrickWall : AWall
{
    private const string MATERIAL = "Brick";
    
    public BrickWall(double height, double length) : base(MATERIAL, height, length)
    {
    }
}