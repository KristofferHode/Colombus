namespace Colombus.Game;
using System.Security;
using System;
using BlazorApp.Game.Skills;

public class GameState
{
    public PlayerState Player {get;} = new ();
    /*public bool IsBusy{get;set;}*/
    public ISkill? ActiveSkill{get;private set;}

    public event Action? OnChange;

    public void StartSkill(ISkill skill)
    {
        ActiveSkill?.Stop();
        ActiveSkill=skill;
        skill.Start();
        OnChange?.Invoke();
    }

    public void Tick()
    {
        ActiveSkill?.Tick();
    }

}

