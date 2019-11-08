Imports System.Threading

' https://www.techcoil.com/blog/implementing-the-singleton-pattern-in-visual-basic-dot-net/
Public Class Connection

    ' For SyncLock to mark a critical section
    Private Shared classLocker As New Object()

    ' Allocate memory space to hold the 
    ' single object instance
    Private Shared singletonObj As Connection


    Private connection As New Npgsql.NpgsqlConnection

    ' Make the only constructor private 
    ' to prevent initialization outside of 
    ' the class.
    Private Sub New()
        ' Heavy configuration works
    End Sub

    ' Expose getInstance() for the retrieval 
    ' of the single object instance.
    Public Shared Function GetInstance() As Npgsql.NpgsqlConnection

        ' Initialize singleton through lazy 
        ' initialization to prevent unused 
        ' singleton from taking up program 
        ' memory
        If (singletonObj Is Nothing) Then
            ' Mark a critical section where 
            ' threads take turns to execute
            SyncLock (classLocker)
                If (singletonObj Is Nothing) Then
                    singletonObj = New Connection()
                    singletonObj.connection = New Npgsql.NpgsqlConnection("Server=127.0.0.1;Port=5432;Username=postgres;Password=123;Database=vp;")
                End If
            End SyncLock
        End If

        Return singletonObj.GetConnection()

    End Function

    Public Function GetConnection() As Npgsql.NpgsqlConnection
        Return connection
    End Function

End Class