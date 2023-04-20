'The main components Of the code are:
'       +   The three Color variables (RedLight, YellowLight, And GreenLight) that store the current state Of the traffic lights.             
'       +   The three Event handlers For the Red, Yellow, And Green buttons, which change the state Of the traffic lights And invalidate the Panel1 control To trigger a repaint.
'                    -      These Colors set to ON/OFF
'                                   Red = ON    , DarkRed = OFF
'                                   Yellow = ON , Khaki = OFF
'                                   Lime = On   , DarkGreen = OFF   
'       +   The Panel1_Paint Event handler, which draws the traffic lights And robot frame Using the DrawRedLight, DrawYellowLight, DrawGreenLight, And DrawRobotFrame methods.
'       +   The DrawRedLight, DrawYellowLight, DrawGreenLight, and DrawRobotFrame methods, which use the Graphics Class To draw the corresponding shapes And colors.

Imports System.Drawing.Design

Public Class Form1

    'Traffic Lights
    Dim RedLight As Color = Color.DarkRed
    Dim YellowLight As Color = Color.Khaki
    Dim GreenLight As Color = Color.DarkGreen
    'Traffic Light Frame
    Dim RobotFrame As Color = Color.Black
    'Cycle Status - TRUE when "start" is clicked, FALSE when "stop" is clicked
    Dim IsCycling As Boolean = False

    'Timer to control traffic light timing
    Dim TrafficLightTimer As New Timer()
    Dim TickCounter As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Invalidate()
        'Initialize timer
        TrafficLightTimer.Interval = 1000 '1 seconds
        AddHandler TrafficLightTimer.Tick, AddressOf Timer1_Tick
        TickCounter = 0
    End Sub

    Private Sub Button_Red_Click(sender As Object, e As EventArgs) Handles Button_Red.Click
        'Set Traffic Light to RED
        RedLight = Color.Red            'ON
        YellowLight = Color.Khaki       'OFF
        GreenLight = Color.DarkGreen    'OFF
        Panel1.Invalidate()
        'Stop timer if it's running
        If TrafficLightTimer.Enabled Then
            TrafficLightTimer.Stop()
        End If
    End Sub

    Private Sub Button_Yellow_Click(sender As Object, e As EventArgs) Handles Button_Yellow.Click
        'Set Traffic Light To YELLOW
        RedLight = Color.DarkRed        'OFF
        YellowLight = Color.Yellow      'ON
        GreenLight = Color.DarkGreen    'OFF
        Panel1.Invalidate()
        'Stop timer if it's running
        If TrafficLightTimer.Enabled Then
            TrafficLightTimer.Stop()
        End If
    End Sub

    Private Sub Button_Green_Click(sender As Object, e As EventArgs) Handles Button_Green.Click
        'Set Traffic Light To GREEN
        RedLight = Color.DarkRed        'OFF
        YellowLight = Color.Khaki       'OFF
        GreenLight = Color.Lime         'ON
        Panel1.Invalidate()
        'Stop timer if it's running
        If TrafficLightTimer.Enabled Then
            TrafficLightTimer.Stop()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        'Draw Robot frame to prevent it from overlaying the traffic lights
        DrawRobotFrame(e.Graphics, RobotFrame)
        'Draw Traffic lights next
        DrawRedLight(e.Graphics, RedLight)
        DrawYellowLight(e.Graphics, YellowLight)
        DrawGreenLight(e.Graphics, GreenLight)
    End Sub




    Private Sub DrawYellowLight(g As Graphics, color As Color)
        Dim brush As New SolidBrush(YellowLight)
        'Panel1 Dimensions:  (Width, Height) = (258, 336)

        'Center of the panel are at: (258, 336)/2 = (129,168)

        'The coordinates of the circle (top left vertex) is ( 129-width_of_circle/2 , 168 - height_of_circle/2)

        'Dimensions of the Circle: ( Width , Height ) = ( 50, 50)
        '129 - 50/2 = 104
        '168 - 50/2 = 143
        'Coordinates of the circle: ( X , Y ) = ( 104 , 143 )
        g.FillEllipse(brush, 104, 143, 50, 50)
    End Sub


    Private Sub DrawRedLight(g As Graphics, color As Color)
        Dim brush As New SolidBrush(RedLight)
        'The Red light lies 50 + 10 points above the yellow light
        'The coordinates of the top left vertex of the red light is at ( 104, 143 - 50 - 10 ) = ( 104 , 83 )
        g.FillEllipse(brush, 104, 83, 50, 50)
    End Sub

    Private Sub DrawGreenLight(g As Graphics, color As Color)
        Dim brush As New SolidBrush(GreenLight)
        'The green light lies 50 + 10 points below the yellow light
        'The coordinates of the top left vertex of the green light is at ( 104, 178 + 50 + 10 ) = ( 104 , 203 )
        g.FillEllipse(brush, 104, 203, 50, 50)
    End Sub

    Private Sub DrawRobotFrame(g As Graphics, color As Color)
        Dim brush As New SolidBrush(RobotFrame)
        'Panel1 Dimensions:  (Width, Height) = (258, 336)

        'Center of the panel are at: (258, 336)/2 = (129,168)

        'The rectangle will have an offset of 20 points from the circle.

        'Dimensions of the Rectangle: ( Width , Height ) = ( 50 + 2*20, 3*50 + 2*20) = ( 90 , 190 )
        '90/2 = 45 -> 129 - 45 = 84
        '190/2 = 95 -> 168 - 95 = 73
        g.FillRectangle(brush, 84, 73, 90, 190)
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim RedTime As Integer = Convert.ToInt16(TextBox_Red.Text)
            Dim YellowTime As Integer = Convert.ToInt16(TextBox_Yellow.Text)
            Dim GreenTime As Integer = Convert.ToInt16(TextBox_Green.Text)

            Dim untilyellow As Integer = RedTime
            Dim untilgreen As Integer = RedTime + YellowTime
            Dim untilred As Integer = RedTime + YellowTime + GreenTime

            If IsCycling Then
                If TickCounter >= untilred Then
                    TickCounter = 0
                ElseIf TickCounter <= untilyellow Then
                    'Set Traffic Light to RED
                    RedLight = Color.Red            'ON
                    YellowLight = Color.Khaki       'OFF
                    GreenLight = Color.DarkGreen    'OFF
                    Panel1.Invalidate()
                ElseIf TickCounter > untilyellow And TickCounter <= untilgreen Then
                    'Set Traffic Light To YELLOW
                    RedLight = Color.DarkRed        'OFF
                    YellowLight = Color.Yellow      'ON
                    GreenLight = Color.DarkGreen    'OFF
                    Panel1.Invalidate()
                ElseIf TickCounter > untilgreen And TickCounter <= untilred Then
                    'Set Traffic Light To GREEN
                    RedLight = Color.DarkRed        'OFF
                    YellowLight = Color.Khaki       'OFF
                    GreenLight = Color.Lime         'ON
                    Panel1.Invalidate()
                End If

                TickCounter += 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button_Start_Click(sender As Object, e As EventArgs) Handles Button_Start.Click
        'Start cycling through traffic lights
        IsCycling = True
        'Start timer
        TrafficLightTimer.Start()
    End Sub

    Private Sub Button_Stop_Click(sender As Object, e As EventArgs) Handles Button_Stop.Click
        'Stop cycling through traffic lights
        IsCycling = False
        'Stop timer
        TrafficLightTimer.Stop()
    End Sub
End Class
