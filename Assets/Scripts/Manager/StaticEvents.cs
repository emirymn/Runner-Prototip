using System;

public class StaticEvents
{
    public static Action<int> OnFinish;
    public static Action OnTakeNos;
    public static Action HitThorn;
    public static Action HitObstable;
    public static Action LevelLoss;
    public static Action LevelFinish;
    public static Action GameStart;
    public static Action LevelWin;
    public static Action EatFood;
    public static Action<int> InLevelPortal;
    public static Action TakeLwUPCollectables;
    public static Action NextLevel;
}
