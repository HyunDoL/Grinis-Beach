﻿using System;
using UnityEngine;

public class PassiveItem : Item
{
    protected PlayerStatus status;

    protected override ItemSheet Sheet()
    {
        return GameManager.Instance.passiveItemSheet_readonly;
    }

    private void Awake()
    {
        status = InGameManager.Instance.PlayerStatus_readonly;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            Ability();
            Destroy(this.gameObject); // 고치자
        }
    }
}