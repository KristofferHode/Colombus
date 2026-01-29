namespace Colombus.Game;
using System.Security;
using System;

public class GameState
{
    public PlayerState Player {get;} = new ();
    public bool IsBusy{get;set;}

}

