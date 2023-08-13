using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
#pragma warning disable CA1050
public abstract class KeyMap 
{
    public Point CursorLocation { get; set; }
    public Point ScreenCenter { get; set; }
    public Dictionary<Keys, bool> MappedKeys { get; set; }
    public bool Moved { get; set; } = false;
    public abstract void SetAction();
}

public class DefaultKeyMap : KeyMap
{
    public DefaultKeyMap()
    {
        ScreenCenter = new Point(
            Screen.PrimaryScreen.Bounds.Width/2, 
            Screen.PrimaryScreen.Bounds.Height/2
        );

        MappedKeys = new Dictionary<Keys, bool>()
        {
            {Keys.W, false},
            {Keys.A, false},
            {Keys.S, false},
            {Keys.D, false},
            {Keys.Right, false},
            {Keys.Left, false},
            {Keys.Up, false},
            {Keys.Down, false},
            {Keys.ShiftKey, false},
            {Keys.Escape, false}
        };
    }

    public override void SetAction()
    {
        Engine.Current.Forms.KeyDown += (s, e) =>
        {
            if (MappedKeys.ContainsKey(e.KeyCode))
                MappedKeys[e.KeyCode] = true;
            else if(e.KeyCode == Keys.Escape)
                Application.Exit();
        };

        Engine.Current.Forms.KeyUp += (s, e) =>
        {
            if (MappedKeys.ContainsKey(e.KeyCode))
                MappedKeys[e.KeyCode] = false;
        };

        Engine.Current.Pb.MouseMove += (s, e) =>
        {
            CursorLocation = e.Location;
            Cursor.Position = ScreenCenter;

            if (Moved)
                CursorLocation = ScreenCenter;

            Moved = false;
        };
    }
}
