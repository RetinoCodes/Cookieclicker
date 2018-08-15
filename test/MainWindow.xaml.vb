Class MainWindow
    Dim count As Double
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
End Class
