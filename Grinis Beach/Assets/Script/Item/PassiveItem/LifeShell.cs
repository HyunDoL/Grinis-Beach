﻿
public class LifeShell : PassiveItem
{
    public override string Name()
    {
        return "생명조개";
    }

    public override void Ability()
    {
        GameManager.Instance.InGameUIManager_readonly.MAXHP += 1;
    }
}