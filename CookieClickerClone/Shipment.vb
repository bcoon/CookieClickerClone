﻿Imports Microsoft.VisualBasic

Public Class Shipment
    Inherits Generator

    Private Static baseCost As Integer = 40000  'cost of the first one purchased
    Private Static CpS As Double = 100.0        'cookies per second generated by one of this object
    Private Static quantity As Integer = 0      'number of this type of generator created
    Private Static totalProduced As Double = 0  'number of cookies produced since beginning of game

End Class
