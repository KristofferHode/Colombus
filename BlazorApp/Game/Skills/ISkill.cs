using System;

namespace BlazorApp.Game.Skills;

public interface ISkill
{
    string Name {get;}
    int Level{get;}
    double Experience {get;}

    void Start();
    void Stop();
    void Tick();

}
