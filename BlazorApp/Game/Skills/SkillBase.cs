using System;
using Colombus.Game;

namespace BlazorApp.Game.Skills;

public abstract class SkillBase:ISkill
{
    protected readonly GameState GameState;

    public abstract string Name{get;}

    public int Level{get; protected set;}=1;
    public double Experience{get;protected set;}

    protected SkillBase(GameState gameState)
    {
        GameState=gameState;
    }
    
    public virtual void Start(){}
    public virtual void Stop(){}

    public abstract void Tick();

    protected void AddXP(double xp)
    {
        Experience +=xp;
        //Level up logikk kommer senere. 
    }

}
