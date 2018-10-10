﻿using System;
using System.Collections.Generic;
using UnityEngine;
using PlayerInterface;

class DefaultOperate : IControl
{
    private int _index;
    private static KeyCode[] _up = { KeyCode.UpArrow, KeyCode.W, KeyCode.T, KeyCode.I };
    private static KeyCode[] _dwon = { KeyCode.DownArrow, KeyCode.S, KeyCode.G, KeyCode.K };
    private static KeyCode[] _left = { KeyCode.LeftArrow, KeyCode.A, KeyCode.F, KeyCode.J };
    private static KeyCode[] _right = { KeyCode.RightArrow, KeyCode.D, KeyCode.H, KeyCode.L };

    private static KeyCode[] _shoot = { KeyCode.LeftControl, KeyCode.E, KeyCode.Y, KeyCode.O };
    private static KeyCode[] _bomb = { KeyCode.Space, KeyCode.Q, KeyCode.R, KeyCode.U };

    private static KeyCode[] _buffSpeed = { KeyCode.Alpha1, KeyCode.Alpha8, KeyCode.F8, KeyCode.Keypad4 };
    private static KeyCode[] _buffShoot = { KeyCode.Alpha2, KeyCode.Alpha6, KeyCode.F6, KeyCode.Keypad2 };
    private static KeyCode[] _buffBomb = { KeyCode.Alpha3, KeyCode.Alpha5, KeyCode.F5, KeyCode.Keypad1 };
    private static KeyCode[] _buffHP = { KeyCode.Alpha4, KeyCode.Alpha7, KeyCode.F7, KeyCode.Keypad3 };

    internal DefaultOperate(int i)
    {
        _index = i % 4;
    }

    public string GetTeamName()
    {
        return "键盘控制器";
    }

    public void Update(IEntity entity)
    {
        //不再允许键盘操作
        if (_index != 0)
        {
            return;
        }
        Move(entity);
        Attack(entity);
        Buff(entity);
        return;
    }

    private void Move(IEntity entity)
    {
        if (Input.GetKey(_up[_index]))
        {
            entity.MoveNorth();
        }
        if (Input.GetKey(_dwon[_index]))
        {
            entity.MoveSouth();
        }
        if (Input.GetKey(_left[_index]))
        {
            entity.MoveWest();
        }
        if (Input.GetKey(_right[_index]))
        {
            entity.MoveEast();
        }
    }

    private void Attack(IEntity entity)
    {
        if (Input.GetKey(_shoot[_index]))
        {
            entity.Shoot();
        }
        if (Input.GetKey(_bomb[_index]))
        {
            entity.SetBomb();
        }
    }

    private void Buff(IEntity entity)
    {
        if (Input.GetKey(_buffSpeed[_index]))
        {
            entity.BuffSpeed();
        }
        if (Input.GetKey(_buffShoot[_index]))
        {
            entity.BuffShoot();
        }
        if (Input.GetKey(_buffBomb[_index]))
        {
            entity.BuffBomb();
        }
        if (Input.GetKey(_buffHP[_index]))
        {
            entity.BuffHP();
        }
    }
}
