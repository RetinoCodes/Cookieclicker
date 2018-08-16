Class MainWindow
    Dim count As Double = 0
    Dim perSec As Double = 0
    Dim cursorCount As Double = 0
    Dim grandmaCount As Double = 0
    Dim leftButton As Boolean
    Dim rightButton As Boolean
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
            If count >= 15 Then
                count -= 15
                cursorCount += 1
                perSec += 0.1
                Count_cursor.Content = cursorCount.ToString()
                cookie_counter.Content = count.ToString()
            End If
        ElseIf orBuy_CheckBox.IsChecked = False And orSell_CheckBox.IsChecked = True Then
            If cursorCount > 0 Then
                cursorCount -= 1
                perSec -= 0.1
                count += 10
                Count_cursor.Content = cursorCount.ToString()
                cookie_counter.Content = count.ToString()
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
            If count >= 100 Then
                count -= 100
                grandmaCount += 1
                perSec += 1
                Count_Grandma.Content = grandmaCount.ToString()
                cookie_counter.Content = count.ToString()
            End If
        ElseIf orBuy_CheckBox.IsChecked = False And orSell_CheckBox.IsChecked = True Then
            If grandmaCount > 0 Then
                grandmaCount -= 14
                perSec -= 1
                count += 50
                Count_Grandma.Content = grandmaCount.ToString()
                cookie_counter.Content = count.ToString()
            End If
        End If
    End Sub
End Class
