public class Camera
{
    public float FovHorizontalAngle { get; set; } = 90;
    public float FovVerticalAngle { get; set; } = 60;
    public double FovDistance { get; set; }
    public Point3D LookingAt { get; set; }
    public Point3D CameraPosition { get; set; }
    private Fov Fov { get; set;}

    
}