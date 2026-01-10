using SFML.System;

namespace Engine;

public static class Time
{
    private const int TargetFps = 60;
    private const float UntilUpdateTime = 1f / TargetFps;
    
    public static float DeltaTime { get; private set; }
    private static readonly Clock Clock = new();

    public static void Update()
    {
        Clock.Restart();
        
        while (Clock.ElapsedTime.AsSeconds() < UntilUpdateTime) {}

        DeltaTime = Clock.ElapsedTime.AsSeconds();
    }
}