using System;

public struct Point3D
{
    private readonly double _x;
    private readonly double _y;
    private readonly double _z;
    public double X
    {
        get { return _x; }
    }
    public double Y
    {
        get { return _y; }
    }

    public double Z
    {
        get { return _y; }
    }
    public Point3D(double x, double y, double z)
    {
        _x = x;
        _y = y;
        _z = z;
    }
}

public struct Fov
{
    private readonly Point3D _downLeft;
    private readonly Point3D _downRight;
    private readonly Point3D _upLeft;
    private readonly Point3D _upRight;
    public Point3D DownLeft
    {
        get { return _downLeft; }
    }
    public Point3D DownRight
    {
        get { return _downRight; }
    }
    public Point3D UpLeft
    {
        get { return _upLeft; }
    }
    public Point3D UpRight
    {
        get { return _upRight; }
    }
    public Fov(
        Point3D LookingAt,
        Point3D CameraPosition, 
        double FovRange, 
        float FovHorizontalAngle, 
        float FovVerticalAngle
    )
    {
        double HorizontalRadians = FovHorizontalAngle/2 * (Math.PI/180);
        double VerticalRadians = FovHorizontalAngle/2 * (Math.PI/180);
        
        double HAngleCos = FovRange*Math.Cos(HorizontalRadians);
        double HAngleSin = FovRange*Math.Sin(HorizontalRadians);
        double VAngleCos = FovRange*Math.Cos(VerticalRadians);
        double VAngleSin = FovRange*Math.Sin(VerticalRadians);

        var leftSide = new Point3D(
            LookingAt.X - HAngleSin, 
            LookingAt.Y, 
            LookingAt.Z - HAngleCos
        );

        // var rightSide = new Point3D(
        //     LookingAt.X + rightSideX, 
        //     LookingAt.Y, 
        //     LookingAt.Z + rightSideZ
        // );

        _downLeft = new Point3D(
            leftSide.X, 
            leftSide.Y - VAngleCos, 
            leftSide.Z - VAngleSin
        );
        // _upLeft = new Point3D(
        //     leftSide.X, 
        //     leftSide.Y + leftUpNewY, 
        //     leftSide.Z + leftUpNewZ
        //     );
        // _downRight = new Point3D(
        //     rightSide.X, 
        //     rightSide.Y + rightBotomNewY, 
        //     rightSide.Z + rightBotomNewZ
        // );
        // _upRight = new Point3D(
        //     rightSide.X, 
        //     rightSide.Y + rightUpNewY, 
        //     rightSide.Z + rightUpNewZ
        // );
    }
}
