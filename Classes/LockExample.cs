﻿using System;

public class LockExample
{
    private readonly object _lock = new();

    private decimal _balance;
    private bool _isOpen;

    public void Open() => _isOpen = true;

    public void Close() => _isOpen = false;

    public decimal Balance => _isOpen ? _balance : throw new InvalidOperationException("Account is closed");

    public void UpdateBalance(decimal change)
    {
        if (!_isOpen)
            throw new InvalidOperationException("Account is closed");

        lock (_lock)
            _balance += change;
    }
}