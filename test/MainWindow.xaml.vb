Imports System.Windows.Threading
Class MainWindow
    Dim angle As Double = 0
    Dim count As Double = 0
    Dim perSec As Double = 0
    Dim cursorCount As Double = 0
    Dim cursorCost As Double = 15
    Dim grandmaCount As Double = 0
    Dim grandmaCost As Double = 100
    Dim RotateTransformAngle As New RotateTransform
    Dim leftButton As Boolean
    Dim rightButton As Boolean
    Private dpTimer As DispatcherTimer = New DispatcherTimer
    Private shineTimer As DispatcherTimer = New DispatcherTimer

    Private Sub Window_Activated(sender As Object, e As EventArgs)
        shineTimer.Interval = TimeSpan.FromMilliseconds(10)
        AddHandler shineTimer.Tick, AddressOf ShineTick
        shineTimer.Start()

        dpTimer.Interval = TimeSpan.FromMilliseconds(1000)
        AddHandler dpTimer.Tick, AddressOf TickMe
        dpTimer.Start()
    End Sub

    Private Sub ShineTick()
        angle += 1
        RotateTransformAngle.Angle = angle
        cookie_shine1.RenderTransform = RotateTransformAngle
        cookie_shine2.RenderTransform = RotateTransformAngle
    End Sub

    Private Sub TickMe()
        count += perSec
        cookie_counter.Content = Math.Round(count, 2)
        coockie_per_second_counter.Content = Math.Round(perSec, 2)
    End Sub
    Private Sub Cookie_MouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs) Handles Cookie.MouseLeftButtonUp
        If leftButton = True Then
            count += 1
            cookie_counter.Content = count.ToString()
        End If
    End Sub

    Private Sub Cookie_MouseRightButtonUp(sender As Object, e As MouseButtonEventArgs) Handles Cookie.MouseRightButtonUp
        If rightButton = True Then
            count += 1
            cookie_counter.Content = count.ToString()
        End If
    End Sub

    Private Sub right_click_Checked(sender As Object, e As RoutedEventArgs) Handles right_click.Checked
        rightButton = True
    End Sub

    Private Sub right_click_Unchecked(sender As Object, e As RoutedEventArgs) Handles right_click.Unchecked
        rightButton = False
    End Sub

    Private Sub left_click_Unchecked(sender As Object, e As RoutedEventArgs) Handles left_click.Unchecked
        leftButton = False
    End Sub

    Private Sub left_click_Checked(sender As Object, e As RoutedEventArgs) Handles left_click.Checked
        leftButton = True
    End Sub

    Private Sub Buyorsell_curser_Button_Click(sender As Object, e As RoutedEventArgs) Handles Buyorsell_curser_Button.Click
        If orBuy_CheckBox.IsChecked = True And orSell_CheckBox.IsChecked = False Then
            If count >= cursorCost Then
                count -= cursorCost
                cursorCount += 1
                cursorCost = Math.Round(cursorCost * 1.15, 2)
                perSec += 0.1
                Count_cursor.Content = cursorCount.ToString()
                cookie_counter.Content = count.ToString()
                Cursor_costs_Label.Content = "Ein Cursor kostet: " + Math.Round(cursorCost, 2).ToString()
            End If
        ElseIf orBuy_CheckBox.IsChecked = False And orSell_CheckBox.IsChecked = True Then
            If cursorCount > 0 Then
                cursorCount -= 1
                count += cursorCost * 0.5
                cursorCost -= Math.Round(cursorCost / 1.15, 2)
                perSec -= 0.1
                Count_cursor.Content = cursorCount.ToString()
                cookie_counter.Content = count.ToString()
                Cursor_costs_Label.Content = "Ein Cursor kostet: " + cursorCost.ToString()
            End If
        End If
    End Sub

    Private Sub orBuy_CheckBox_Checked(sender As Object, e As RoutedEventArgs) Handles orBuy_CheckBox.Checked
        If orSell_CheckBox.IsChecked = True Then
            orSell_CheckBox.IsChecked = False
        End If
    End Sub

    Private Sub orSell_CheckBox_Checked(sender As Object, e As RoutedEventArgs) Handles orSell_CheckBox.Checked
        If orBuy_CheckBox.IsChecked = True Then
            orBuy_CheckBox.IsChecked = False
        End If
    End Sub

    Private Sub Buyorsell_Grandma_Button_Click(sender As Object, e As RoutedEventArgs) Handles Buyorsell_Grandma_Button.Click
        If orBuy_CheckBox.IsChecked = True And orSell_CheckBox.IsChecked = False Then
            If count >= grandmaCost Then
                count -= grandmaCost
                grandmaCount += 1
                grandmaCost = grandmaCost * 1.15
                perSec += 1
                Count_Grandma.Content = grandmaCount.ToString()
                cookie_counter.Content = count.ToString()
                Grandma_costs_Label_Copy.Content = "Eine Grandma kostet: " + Math.Round(grandmaCost, 2).ToString()
            End If
        ElseIf orBuy_CheckBox.IsChecked = False And orSell_CheckBox.IsChecked = True Then
            If grandmaCount > 0 Then
                grandmaCount -= 14
                perSec -= 1
                count += 50
                Count_Grandma.Content = grandmaCount.ToString()
                cookie_counter.Content = count.ToString()
                Grandma_costs_Label_Copy.Content = "Eine Grandma kostet: " + Math.Round(grandmaCost, 2).ToString()
            End If
        End If
    End Sub


    'Imports System.Windows.Threading
    '
    'Private dpTimer As DispatcherTimer = New DispatcherTimer
    '
    'Private Sub Window_Activated(sender as Object, e as EventArgs)
    '
    '   dpTimer.Interval = TimeSpan.FromMilliseconds(1000)
    '   AddHandler dpTimer.Tick, AddressOf TickMe
    '   dpTimer.Start()
    '
    'End Sub
    '
    'Private Sub TickMe()
    '   (was man machen will)
    'End Sub
End Class
