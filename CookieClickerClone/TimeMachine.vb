﻿Imports Microsoft.VisualBasic

Public Class TimeMachine
    Inherits Generator

    Private Static baseCost As Integer = 123456789  'cost of the first one purchased
    Private Static CpS As Double = 98765.0          'cookies per second generated by one of this object
    Private Static quantity As Integer = 0          'number of this type of generator created
    Private Static totalProduced As Double = 0      'number of cookies produced since beginning of game
End Class
