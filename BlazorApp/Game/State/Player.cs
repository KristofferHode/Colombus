


using System.Dynamic;
using BlazorApp.Game.Skills;
namespace Colombus.Game;

public class PlayerState
{
    public int HitPoints{get;set;} = 10;
    public int WoodCuttingLvl{get;set;}=1;
    public double WoodcuttingXP{get;set;}
    public int Logs{get;set;}

    public Dictionary<string, ISkill> Skills{get;}=new();
    public T GetSkill<t>() where t:ISkill
    =>(T)Skills.Values.First(s=>s is T);
}
