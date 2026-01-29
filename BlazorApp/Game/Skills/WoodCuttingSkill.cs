using System;
using Colombus.Game;

namespace BlazorApp.Game.Skills;

public class WoodCuttingSkill : SkillBase
{
    public override string Name => "Woodcutting";

    public WoodCuttingSkill(GameState gameState)
        :base (gameState){}

    public override void Tick()
    {
        GameState.Player.Logs++;
        AddXP(5);
    }
}
