using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

var builder = Engine.GetBuilder();

var bottomHexagon = new Hexagon(new Vector3[] {
    new Vector3(0,0,0),
    new Vector3(86.6f,-50,0),
    new Vector3(173.21f,0,0),
    new Vector3(173.21f,100,0),
    new Vector3(86.6f,150,0),
    new Vector3(0,100,0), 
}, Color.White);

var sidePentagon = new Pentagon(new Vector3[] {
    new Vector3(0,0,0),
    new Vector3(0,100,0),
    new Vector3(-75.6f,130.09f,57.7f),
    new Vector3(-122.3f,50,93.4f),
    new Vector3(-75.6f,-30.09f,57.7f)
}, Color.DarkBlue);

var side2Pentagon = new Pentagon(new Vector3[] {
    new Vector3(86.6f,150,0),
    new Vector3(173.21f,100,0),
    new Vector3(237.8f,150,57.7f),
    new Vector3(191,230.9f,93.4f),
    new Vector3(97.7f,230.9f,57.7f)
}, Color.DarkBlue);

var side3Pentagon = new Pentagon(new Vector3[] {
    new Vector3(173.21f,0,0),
    new Vector3(86.6f,-50,0),
    new Vector3(97.7f,-130.9f,57.7f),
    new Vector3(191,-130.9f,93.4f),
    new Vector3(237.8f,-50,57.7f)
}, Color.DarkBlue);

var side4Pentagon = new Pentagon(new Vector3[] {
    new Vector3(-100.36f, -111.23f, 207.38f),
    new Vector3(-64.5f, -111.8f, 115.5f),
    new Vector3(22.1f, -161.8f, 115.5f),
    new Vector3(39.97f, -192.66f, 208.98f),
    new Vector3(-37.19f, -160.33f, 265.05f)
}, Color.DarkBlue);

var side5Pentagon = new Pentagon(new Vector3[] {
    new Vector3(39.634033f, 292.70303f, 208.80328f),
    new Vector3(22.1f, 261.8f, 115.5f),
    new Vector3(-64.5f, 211.8f, 115.5f),
    new Vector3(-100.36f, 212.31f, 209.45f),
    new Vector3(-35.91f, 262.97f, 267.51f)
}, Color.DarkBlue);

var side6Pentagon = new Pentagon(new Vector3[] {
    new Vector3(320.49f, -30.79f, 208.52f),
    new Vector3(302.38f, 0, 115.5f),
    new Vector3(302.38f, 99.99f, 115.5f),
    new Vector3(320.14f, 130.89f, 208.99f),
    new Vector3(331.68f, 49.82f, 266f),
}, Color.DarkBlue);

var side7Pentagon = new Pentagon(new Vector3[] {
    new Vector3(151.26f,261.98f,337.57f),
    new Vector3(133.48f,292.2f,243.83f),
    new Vector3(208.75f,261.81f,186.89f),
    new Vector3(273.33f,211.8f,244.69f),
    new Vector3(238.09f,210.39f,338.65f),
}, Color.DarkBlue);

var side8Pentagon = new Pentagon(new Vector3[] {
    new Vector3(-129.32f,-0.03f,333.78f),
    new Vector3(-146.42f,-31.08f,241.74f),
    new Vector3(-158.03f,49.49f,186.09f),
    new Vector3(-148.06f,131.11f,245.61f),
    new Vector3(-130.43f,100.61f,340.06f),
}, Color.DarkBlue);

var side9Pentagon = new Pentagon(new Vector3[] {
    new Vector3(239.36f,-111.59f,337.63f),
    new Vector3(274.33f,-111.59f,244.33f),
    new Vector3(209.05f,-161.73f,186.86f),
    new Vector3(133.44f,-192.62f,244.66f),
    new Vector3(149.62f,-158.74f,340.33f),
}, Color.DarkBlue);

var side10Pentagon = new Pentagon(new Vector3[] {
    new Vector3(174.55f,97.77f,453.31f),
    new Vector3(249.63f,129.32f,395.66f),
    new Vector3(296.42f,49.03f,359.33f),
    new Vector3(250.55f,-30.98f,395.11f),
    new Vector3(169.82f,6.47f,453.75f),
}, Color.DarkBlue);

var side11Pentagon = new Pentagon(new Vector3[] {
    new Vector3(-4.49f,107.33f,451.39f),
    new Vector3(-65.6f,151.27f,398.12f),
    new Vector3(-18.34f,232.45f,361.84f),
    new Vector3(76.26f,232.25f,396.28f),
    new Vector3(82.76f,157.61f,452.03f),
}, Color.DarkBlue);

var lastPentagon = new Pentagon(new Vector3[] {
    new Vector3(82.56f,-43.8f,453.11f),
    new Vector3(72.46f,-126.41f,396.4f),
    new Vector3(-20.94f,-127.2f,358.76f),
    new Vector3(-66.15f,-49.13f,391.45f),
    new Vector3(-4.59f,6.63f,451.93f),
}, Color.DarkBlue);

var sideHexagon = new Hexagon(new Vector3[] {
    new Vector3(0,100,0),
    new Vector3(86.6f,150,0),
    new Vector3(97.7f,230.9f,57.7f),
    new Vector3(22.1f,261.8f,115.5f),
    new Vector3(-64.5f,211.8f,115.5f),
    new Vector3(-75.6f,130.09f,57.7f), 
}, Color.White);

var side2Hexagon = new Hexagon(new Vector3[] {
    new Vector3(86.6f,-50,0),
    new Vector3(0,0,0),
    new Vector3(-75.6f,-30.09f,57.7f),
    new Vector3(-64.5f,-111.8f,115.5f),
    new Vector3(22.1f,-161.8f,115.5f),
    new Vector3(97.7f,-130.9f,57.7f), 
}, Color.White);

var side3Hexagon = new Hexagon(new Vector3[] {
    new Vector3(173.21f,0,0),
    new Vector3(173.21f,100,0),
    new Vector3(237.8f,150,57.7f),
    new Vector3(302.38f, 99.99f, 115.5f),
    new Vector3(302.38f, 0, 115.5f),
    new Vector3(237.8f,-50,57.7f), 
}, Color.White);

var side4Hexagon = new Hexagon(new Vector3[] {
    new Vector3(-100.36f,-111.23f,207.38f),
    new Vector3(-147.06f,-31.16f,243.08f),
    new Vector3(-158.03f, 49.46f,186.09f),
    new Vector3(-122.3f,50,93.4f),
    new Vector3(-75.6f, -30.09f,57.7f),
    new Vector3(-64.5f, -111.8f, 115.5f), 
}, Color.White);

var side5Hexagon = new Hexagon(new Vector3[] {
    new Vector3(-148.06f, 131.11f, 245.61f),
    new Vector3(-100.73f, 212.31f, 209.45f),
    new Vector3(-64.5f, 211.8f, 115.5f),
    new Vector3(-75.6f, 130.09f, 57.7f),
    new Vector3(-122.3f, 50, 93.4f),
    new Vector3(-158.03f, 49.49f, 186.09f), 
}, Color.White);

var side6Hexagon = new Hexagon(new Vector3[] {
    new Vector3(237.8f, -50, 57.7f),
    new Vector3(191,-130.9f, 93.4f),
    new Vector3(209.05f, -161.73f, 186.86f),
    new Vector3(273.79f, -111.67f, 244.42f),
    new Vector3(320.49f, -30.79f, 208.52f),
    new Vector3(302.38f, 0, 115.5f)
}, Color.White);

var side7Hexagon = new Hexagon(new Vector3[] {
    new Vector3(97.7f, -130.9f, 57.7f),
    new Vector3(22.1f, -161.8f, 115.5f),
    new Vector3(39.97f, -192.66f, 208.98f),
    new Vector3(133.44022f, -192.6222f, 244.66624f),
    new Vector3(209.0405f, -161.72437f, 186.87248f),
    new Vector3(191.17056f, -130.86432f, 93.3924f)
}, Color.White);

var side8Hexagon = new Hexagon(new Vector3[] {
new Vector3(191f, 230.9f, 93.4f),
new Vector3(237.8f, 150f, 57.7f),
new Vector3(302.38f, 99.99f, 115.5f),
new Vector3(320.14f, 130.89f, 208.99f),
new Vector3(273.33f, 211.8f, 244.69f),
new Vector3(208.75f, 261.81f, 186.89f)
}, Color.White);

var side9Hexagon = new Hexagon(new Vector3[] {
new Vector3(97.7f, 230.9f, 57.7f),
new Vector3(191f, 230.9f, 93.4f),
new Vector3(208.75f, 261.81f, 186.89f),
new Vector3(133.07f, 292.71f, 244.59f),
new Vector3(39.63f, 292.70f, 208.8f),
new Vector3(21.87f, 261.78f, 115.5f)
}, Color.White);

var side10Hexagon = new Hexagon(new Vector3[] {
    new Vector3(273.33f, 211.8f, 244.69f),
    new Vector3(320.14f, 130.89f, 208.99f),
    new Vector3(331.68f, 49.82f, 266f),
    new Vector3(296.42554f, 49.037846f, 359.339f),
    new Vector3(249.63109f, 129.3257f, 395.66803f),
    new Vector3(238.0911f, 210.39574f, 338.65805f)
}, Color.White);

var side11Hexagon = new Hexagon(new Vector3[] {
    new Vector3(296.42f, 49.03f, 359.33f),
    new Vector3(331.68f, 49.82f, 266f),
    new Vector3(320.49f, -30.79f, 208.52f),
    new Vector3(274.33298f, -111.49794f, 244.33755f),
    new Vector3(239.36592f, -111.5959f, 337.63513f),
    new Vector3(250.55588f, -30.9859f, 395.11517f)
}, Color.White);

var side12Hexagon = new Hexagon(new Vector3[] {
    new Vector3(-148.06f, 131.11f, 245.61f),
    new Vector3(-100.73f, 212.31f, 209.45f),
    new Vector3(-35.91f, 262.97f, 267.51f),
    new Vector3(-18.34996f, 232.45422f, 361.84702f),
    new Vector3(-65.609955f, 151.27841f, 398.12405f),
    new Vector3(-130.43002f, 100.61833f, 340.0641f)
}, Color.White);

var side13Hexagon = new Hexagon(new Vector3[] {
    new Vector3(-18.34f, 232.45f, 361.84f),
    new Vector3(-35.91f, 262.97f, 267.51f),
    new Vector3(39.63f, 292.7f, 208.8f),
    new Vector3(133.48839f, 292.206f, 243.83418f),
    new Vector3(151.8068f, 261.98196f, 337.5784f),
    new Vector3(76.266815f, 232.25194f, 396.28848f)
}, Color.White);

var side14Hexagon = new Hexagon(new Vector3[] {
    new Vector3(133.44f, -192.62f, 244.66f),
    new Vector3(39.97f, -192.66f, 208.98f),
    new Vector3(-37.19f, -160.33f, 265.05f),
    new Vector3(-20.940807f, -127.209236f, 358.76083f),
    new Vector3(72.46843f, -126.418465f, 396.4017f),
    new Vector3(149.62848f, -158.74846f, 340.33173f)
}, Color.White);

var side15Hexagon = new Hexagon(new Vector3[] {
    new Vector3(-20.94f, -127.2f, 358.76f),
    new Vector3(-37.19f, -160.33f, 265.05f),
    new Vector3(-100.36f, -111.23f, 207.38f),
    new Vector3(-146.42953f, -31.08245f, 241.74646f),
    new Vector3(-129.32907f, -0.03485489f, 333.7829f),
    new Vector3(-66.159065f, -49.134808f, 391.4529f)
}, Color.White);

var side16Hexagon = new Hexagon(new Vector3[] {
    new Vector3(151.8f, 261.98f, 337.57f),
    new Vector3(238.09f, 210.39f, 338.65f),
    new Vector3(249.63f, 129.32f, 395.66f),
    new Vector3(174.55f, 97.77f, 453.31f),
    new Vector3(82.761696f, 157.61002f, 452.03265f),
    new Vector3(76.266815f, 232.25194f, 396.28848f)
}, Color.White);

var side17Hexagon = new Hexagon(new Vector3[] {
    new Vector3(-129.32f, -0.03f, 333.78f),
    new Vector3(-130.43f, 100.61f, 340.06f),
    new Vector3(-65.6f, 151.27f, 398.12f),
    new Vector3(-4.498313f, 107.339966f, 451.39264f),
    new Vector3(-4.5991516f, 6.634968f, 451.9313f),
    new Vector3(-66.159065f, -49.134808f, 391.4529f)
}, Color.White);

var side18Hexagon = new Hexagon(new Vector3[] {
    new Vector3(239.36f, -111.59f, 337.63f),
    new Vector3(149.62f, -158.74f, 340.33f),
    new Vector3(72.46f, -126.41f, 396.4f),
    new Vector3(82.56012f, -43.80081f, 453.11374f),
    new Vector3(169.82024f, 6.478409f, 453.75748f),
    new Vector3(250.55588f, -30.9859f, 395.11517f)
}, Color.White);

var lastHexagon = new Hexagon(new Vector3[] {
    new Vector3(174.55f, 97.77f, 453.31f),
    new Vector3(169.82f, 6.47f, 453.75f),
    new Vector3(82.56f, -43.8f, 453.11f),
    new Vector3(-4.5991516f, 6.634968f, 451.9313f),
    new Vector3(-4.498313f, 107.339966f, 451.39264f),
    new Vector3(82.761696f, 157.61002f, 452.03265f)
}, Color.White);

builder
    .SetCameraStartingPosition(0, 2000, 0)
    .SetCameraStartingDirection(0, 0 ,0)
    .SetCameraMovementSpeed(5)
    .SetFovAngle(60, 90)
    .SetArgs()
    .SetKeyMapping<DefaultKeyMap>()
    .SetCamera<DefaultCamera>()
    .SetFov<DefaultFov>()
    .SetPolygons(new List<Polygon>() {
        bottomHexagon, 
        sidePentagon, 
        sideHexagon, 
        side2Pentagon, 
        side2Hexagon,
        side3Pentagon,
        side3Hexagon,
        side4Hexagon,
        side5Hexagon,
        side6Hexagon,
        side7Hexagon,
        side8Hexagon,
        side9Hexagon,
        side4Pentagon,
        side5Pentagon,
        side6Pentagon,
        side10Hexagon,
        side11Hexagon,
        side12Hexagon,
        side13Hexagon,
        side14Hexagon,
        side15Hexagon,
        side7Pentagon,
        side8Pentagon,
        side9Pentagon,
        side16Hexagon,
        side17Hexagon,
        side18Hexagon,
        side10Pentagon,
        lastHexagon,
        side11Pentagon,
        lastPentagon
    });

Engine.New(builder);

Engine.Current.Run();