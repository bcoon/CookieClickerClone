﻿Public Class Cursor
    Inherits Generator

    Private baseCost As Integer = 15        'cost of the first one purchased
    Private CpS As Double = 0.1             'cookies per second generated by one of this object
    Private amount As Integer = 0           'number of this type of generator created
    Private total As Double = 0             'number of cookies produced since beginning of game
    Private currentCost As Long = baseCost  'base cost * 1.15 (accurate for non-cursors?)

End Class

