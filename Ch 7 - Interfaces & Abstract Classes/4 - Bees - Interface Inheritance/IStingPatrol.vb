Option Strict On
Option Explicit On

Public Interface IStingPatrol
    ReadOnly Property AlertLevel As Integer
    Property StingerLength As Integer
    Function LookForEnemies() As Boolean
    Function SharpenStinger(ByVal length As Integer) As Boolean
End Interface
