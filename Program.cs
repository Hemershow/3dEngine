using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

var builder = Engine.GetBuilder();

var bottomTriangle = new Triangle(new Vector3[] {
    new Vector3(0,400,0), 
    new Vector3(0,500,0),
    new Vector3(100,500,0)
}, Color.Red);

var frontTriangle = new Triangle(new Vector3[] {
    new Vector3(100,500,0),
    new Vector3(0,500,100),
    new Vector3(0, 400,0)
},
    Color.Cyan
);

var leftTriangle = new Triangle(new Vector3[] {
    bottomTriangle.Points[0],
    bottomTriangle.Points[1],
    new Vector3(0,500,100)
}, Color.White);

var rightTriangle = new Triangle(new Vector3[] {
    bottomTriangle.Points[2],
    bottomTriangle.Points[1],
    leftTriangle.Points[2]
}, Color.Blue);

var rndTraingle = new Triangle(new Vector3[] {
    new Vector3(-39.32289f,489.74084f,160.16958f),
    new Vector3(-39.32289f,489.74084f,215.7771f),
    new Vector3(-75.85123f,492.37773f,215.7771f)
}, Color.Yellow);

builder
    .SetCameraStartingPosition(0, 2000, 0)
    .SetCameraStartingDirection(0, 0, 0)
    .SetCameraMovementSpeed(5)
    .SetFovAngle(60, 90)
    .SetArgs()
    .SetKeyMapping<DefaultKeyMap>()
    .SetCamera<DefaultCamera>()
    .SetFov<DefaultFov>()
    .SetPolygons(new List<Polygon>() {frontTriangle, bottomTriangle, leftTriangle, rightTriangle, rndTraingle});

Engine.New(builder);

Engine.Current.Run();