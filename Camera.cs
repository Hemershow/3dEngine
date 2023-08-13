using System;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;
using System.Collections.Generic;

public abstract class Camera
{
    public Vector3 CameraDirection { get; protected set; }
    public Vector3 CameraPosition { get; protected set; }
    public float CameraSpeed { get; protected set; }
    public abstract void MoveCamera();
    public abstract void ChangeDirection();
}
public class DefaultCamera : Camera
{
    public DefaultCamera(CameraArgs args)
    {
        CameraPosition = args.CameraStartingPosition;
        CameraDirection = args.CameraStartingDirection;
        CameraSpeed = args.CameraSpeed;
    }

    public override void ChangeDirection() 
    {
        var MappedKeys = Engine.Current.KeyMapping.MappedKeys;
        var Fov = Engine.Current.FieldOfView;

        var translatedDirection = Vector3.Subtract(CameraDirection, CameraPosition);
        
        var verticalRotationAxis = new Vector3(
            -translatedDirection.Y, 
            translatedDirection.X, 
            0
        );

        var horizontalRotationAxis = Fov.RotatePoint(verticalRotationAxis, -90f, translatedDirection);

        if (MappedKeys[Keys.Left])
            translatedDirection = Fov.RotatePoint(
                horizontalRotationAxis, 
                1, 
                translatedDirection
            );

        if (MappedKeys[Keys.Right])
            translatedDirection = Fov.RotatePoint(
                horizontalRotationAxis, 
                -1, 
                translatedDirection
            );

        if (MappedKeys[Keys.Up])
            translatedDirection = Fov.RotatePoint(
                verticalRotationAxis, 
                -1, 
                translatedDirection
            );

        if (MappedKeys[Keys.Down])
            translatedDirection = Fov.RotatePoint(
                verticalRotationAxis, 
                1, 
                translatedDirection
            );

        CameraDirection = Vector3.Add(translatedDirection, CameraPosition);
        Engine.Current.FieldOfView.SetPoints();
    }

    public override void MoveCamera()
    {
        var MappedKeys = Engine.Current.KeyMapping.MappedKeys;
        var Fov = Engine.Current.FieldOfView;

        var translatedDirection = Vector3.Subtract(CameraDirection, CameraPosition);
        var normalizedDirection = Vector3.Normalize(translatedDirection);

        var verticalRotationAxis = new Vector3(
            -normalizedDirection.Y, 
            normalizedDirection.X, 
            0
        );

        var horizontalRotationAxis = Fov.RotatePoint(
            verticalRotationAxis, 
            -90f, 
            normalizedDirection
        );

        var lateralDirection = Fov.RotatePoint(
            horizontalRotationAxis, 
            -90f, 
            normalizedDirection
        );

        var normalizedLateralDirection = Vector3.Normalize(lateralDirection);
        var sideMovement = Vector3.Multiply(CameraSpeed, normalizedLateralDirection);
        var forwardMovement = Vector3.Multiply(CameraSpeed, normalizedDirection);

        if (!(MappedKeys[Keys.W] && MappedKeys[Keys.S]))
        {
            if (MappedKeys[Keys.W])
            {
                CameraDirection = Vector3.Add(CameraDirection, forwardMovement);
                CameraPosition = Vector3.Add(CameraPosition, forwardMovement);
            }
            if (MappedKeys[Keys.S])
            {
                CameraDirection = Vector3.Add(CameraDirection, -forwardMovement);
                CameraPosition = Vector3.Add(CameraPosition, -forwardMovement);
            }
        }
        if (!(MappedKeys[Keys.A] && MappedKeys[Keys.D]))
        {
            if (MappedKeys[Keys.A])
            {
                CameraDirection = Vector3.Add(CameraDirection, -sideMovement);
                CameraPosition = Vector3.Add(CameraPosition, -sideMovement);
            }
            if (MappedKeys[Keys.D])
            {
                CameraDirection = Vector3.Add(CameraDirection, sideMovement);
                CameraPosition = Vector3.Add(CameraPosition, sideMovement);
            }
        }
    }
}

