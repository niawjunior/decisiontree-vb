Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Website.SelectedIndexChanged
        Label1.Text = Website.SelectedItem

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Desktop.SelectedIndexChanged
        Label2.Text = Desktop.SelectedItem
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Mobile.SelectedIndexChanged
        Label3.Text = Mobile.SelectedItem
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Game.SelectedIndexChanged
        Label4.Text = Game.SelectedItem
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Salary.SelectedIndexChanged
        Label5.Text = Salary.SelectedItem
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Demand.SelectedIndexChanged
        Label6.Text = Demand.SelectedItem
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Popular.SelectedIndexChanged
        Label7.Text = Popular.SelectedItem
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Difficulty.SelectedIndexChanged
        Label8.Text = Difficulty.SelectedItem
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (String.IsNullOrEmpty(Website.Text)) Then

            MessageBox.Show("Not Select " + "No.1")

        ElseIf (String.IsNullOrEmpty(Desktop.Text)) Then

            MessageBox.Show("Not Select " + "No.2")

        ElseIf (String.IsNullOrEmpty(Mobile.Text)) Then

            MessageBox.Show("Not Select " + "No.3")

        ElseIf (String.IsNullOrEmpty(Mobile.Text)) Then

            MessageBox.Show("Not Select " + "No.3")

        ElseIf (String.IsNullOrEmpty(Game.Text)) Then

            MessageBox.Show("Not Select " + "No.4")

        ElseIf (String.IsNullOrEmpty(Salary.Text)) Then

            MessageBox.Show("Not Select " + "No.5")

        ElseIf (String.IsNullOrEmpty(Demand.Text)) Then

            MessageBox.Show("Not Select " + "No.6")

        ElseIf (String.IsNullOrEmpty(Popular.Text)) Then

            MessageBox.Show("Not Select " + "No.7")

        ElseIf (String.IsNullOrEmpty(Difficulty.Text)) Then

            MessageBox.Show("Not Select " + "No.8")

        Else
            Timer1.Start()
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Website.SelectedIndex = -1
        Label1.Text = "none"
        Desktop.SelectedIndex = -1
        Label2.Text = "none"
        Mobile.SelectedIndex = -1
        Label3.Text = "none"
        Game.SelectedIndex = -1
        Label4.Text = "none"
        Salary.SelectedIndex = -1
        Label5.Text = "none"
        Demand.SelectedIndex = -1
        Label6.Text = "none"
        Popular.SelectedIndex = -1
        Label7.Text = "none"
        Difficulty.SelectedIndex = -1
        Label8.Text = "none"
        Answer.Text = ""
        Label9.Text = ""
        ProgressBar1.Value = 0
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Increment(10)
        Label9.Text = ProgressBar1.Value & ("%")
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Dim lang(100, 100) As Double

            If (Website.Text = "yes") Then
                lang(0, 0) = 0.8  'website(javascript)'
                lang(1, 0) = 1  'website(php)'
                lang(2, 0) = 1  'website(sql)'
                lang(3, 0) = 1  'website(python)'
                lang(4, 0) = 0.666666  'website(java)'
                lang(5, 0) = 0  'website(swift)'
                lang(6, 0) = 1  'website(html5)'
                lang(7, 0) = 0  'website(c)'
                lang(8, 0) = 0  'website(c++)'
                lang(9, 0) = 0  'website(c#)'

            ElseIf (Website.Text = "no") Then
                lang(0, 0) = 0.2  'website(javascript)'
                lang(1, 0) = 0  'website(php)'
                lang(2, 0) = 0  'website(sql)'
                lang(3, 0) = 0  'website(python)'
                lang(4, 0) = 0.333333  'website(java)'
                lang(5, 0) = 1  'website(swift)'
                lang(6, 0) = 0  'website(html5)'
                lang(7, 0) = 1  'website(c)'
                lang(8, 0) = 1  'website(c++)'
                lang(9, 0) = 1  'website(c#)'
            End If

            If (Desktop.Text = "yes") Then
                lang(0, 1) = 0.2  'desktop(javascript)'
                lang(1, 1) = 0  'desktop(php)'
                lang(2, 1) = 0  'desktop(sql)'
                lang(3, 1) = 0.166666  'desktop(python)'
                lang(4, 1) = 1  'desktop(java)'
                lang(5, 1) = 1  'desktop(swift)'
                lang(6, 1) = 0  'desktop(html5)'
                lang(7, 1) = 1  'desktop(c)'
                lang(8, 1) = 0.5  'desktop(c++)'
                lang(9, 1) = 0.5  'desktop(c#)'

            ElseIf (Desktop.Text = "no") Then
                lang(0, 1) = 0.8  'desktop(javascript)'
                lang(1, 1) = 1  'desktop(php)'
                lang(2, 1) = 1  'desktop(sql)'
                lang(3, 1) = 0.833333  'desktop(python)'
                lang(4, 1) = 0  'desktop(java)'
                lang(5, 1) = 0  'desktop(swift)'
                lang(6, 1) = 1  'desktop(html5)'
                lang(7, 1) = 0  'desktop(c)'
                lang(8, 1) = 0.5  'desktop(c++)'
                lang(9, 1) = 0  'desktop(c#)'
            End If


            If (Mobile.Text = "yes") Then
                lang(0, 2) = 0.8  'mobile(javascript)'
                lang(1, 2) = 0  'mobile(php)'
                lang(2, 2) = 0  'mobile(sql)'
                lang(3, 2) = 0.833333  'mobile(python)'
                lang(4, 2) = 0.333333  'mobile(java)'
                lang(5, 2) = 0.5  'mobile(swift)'
                lang(6, 2) = 1  'mobile(html5)'
                lang(7, 2) = 0  'mobile(c)'
                lang(8, 2) = 0 'mobile(c++)'
                lang(9, 2) = 0.5  'mobile(c#)'

            ElseIf (Mobile.Text = "no") Then
                lang(0, 2) = 0.2  'mobile(javascript)'
                lang(1, 2) = 1  'mobile(php)'
                lang(2, 2) = 1  'mobile(sql)'
                lang(3, 2) = 0.166666  'mobile(python)'
                lang(4, 2) = 0.666666  'mobile(java)'
                lang(5, 2) = 0  'mobile(swift)'
                lang(6, 2) = 0  'mobile(html5)'
                lang(7, 2) = 1  'mobile(c)'
                lang(8, 2) = 1  'mobile(c++)'
                lang(9, 2) = 0  'mobile(c#)'
            End If


            If (Game.Text = "yes") Then
                lang(0, 3) = 0.8  'game(javascript)'
                lang(1, 3) = 0  'game(php)'
                lang(2, 3) = 0  'game(sql)'
                lang(3, 3) = 0.666666  'game(python)'
                lang(4, 3) = 0.666666  'game(java)'
                lang(5, 3) = 0 'game(swift)'
                lang(6, 3) = 1  'game(html5)'
                lang(7, 3) = 1  'game(c)'
                lang(8, 3) = 1  'game(c++)'
                lang(9, 3) = 1  'game(c#)'

            ElseIf (Game.Text = "no") Then
                lang(0, 3) = 0.6  'game(javascript)'
                lang(1, 3) = 1  'game(php)'
                lang(2, 3) = 1  'game(sql)'
                lang(3, 3) = 0.333333  'game(python)'
                lang(4, 3) = 0.333333  'game(java)'
                lang(5, 3) = 1  'game(swift)'
                lang(6, 3) = 0  'game(html5)'
                lang(7, 3) = 0  'game(c)'
                lang(8, 3) = 0  'game(c++)'
                lang(9, 3) = 0  'game(c#)'
            End If


            If (Salary.Text = "low") Then
                lang(0, 4) = 0.2  'salary(javascript)'
                lang(1, 4) = 0.333333  'salary(php)'
                lang(2, 4) = 0  'salary(sql)'
                lang(3, 4) = 0  'salary(python)'
                lang(4, 4) = 0  'salary(java)'
                lang(5, 4) = 0  'salary(swift)'
                lang(6, 4) = 0.5  'salary(html5)'
                lang(7, 4) = 0  'salary(c)'
                lang(8, 4) = 0  'salary(c++)'
                lang(9, 4) = 0  'salary(c#)'

            ElseIf (Salary.Text = "medium") Then
                lang(0, 4) = 0.6  'salary(javascript)'
                lang(1, 4) = 0.333333  'salary(php)'
                lang(2, 4) = 0.5  'salary(sql)'
                lang(3, 4) = 0.166666  'salary(python)'
                lang(4, 4) = 0  'salary(java)'
                lang(5, 4) = 0  'salary(swift)'
                lang(6, 4) = 0.5  'salary(html5)'
                lang(7, 4) = 0.333333  'salary(c)'
                lang(8, 4) = 0  'salary(c++)'
                lang(9, 4) = 0  'salary(c#)'

            ElseIf (Salary.Text = "hight") Then
                lang(0, 4) = 0.2 'salary(javascript)'
                lang(1, 4) = 0.333333  'salary(php)'
                lang(2, 4) = 0.5  'salary(sql)'
                lang(3, 4) = 0.833333  'salary(python)'
                lang(4, 4) = 1  'salary(java)'
                lang(5, 4) = 1  'salary(swift)'
                lang(6, 4) = 0  'salary(html5)'
                lang(7, 4) = 0.666666  'salary(c)'
                lang(8, 4) = 1  'salary(c++)'
                lang(9, 4) = 1  'salary(c#)'
            End If

            If (Demand.Text = "yes") Then
                lang(0, 5) = 0.6  'demand(javascript)'
                lang(1, 5) = 1  'demand(php)'
                lang(2, 5) = 1  'demand(sql)'
                lang(3, 5) = 1  'demand(python)'
                lang(4, 5) = 1  'demand(java)'
                lang(5, 5) = 1  'demand(swift)'
                lang(6, 5) = 0  'demand(html5)'
                lang(7, 5) = 0  'demand(c)'
                lang(8, 5) = 1  'demand(c++)'
                lang(9, 5) = 1  'demand(c#)'

            ElseIf (Demand.Text = "no") Then
                lang(0, 5) = 0.4  'demand(javascript)'
                lang(1, 5) = 0  'demand(php)'
                lang(2, 5) = 0  'demand(sql)'
                lang(3, 5) = 0  'demand(python)'
                lang(4, 5) = 0  'demand(java)'
                lang(5, 5) = 0  'demand(swift)'
                lang(6, 5) = 1  'demand(html5)'
                lang(7, 5) = 1  'demand(c)'
                lang(8, 5) = 0  'demand(c++)'
                lang(9, 5) = 0  'demand(c#)'

            End If

            If (Popular.Text = "yes") Then
                lang(0, 6) = 1 'popular(javascript)'
                lang(1, 6) = 1  'popular(php)'
                lang(2, 6) = 0  'popular(sql)'
                lang(3, 6) = 0.833333  'popular(python)'
                lang(4, 6) = 0.333333  'popular(java)'
                lang(5, 6) = 0.5  'popular(swift)'
                lang(6, 6) = 0  'popular(html5)'
                lang(7, 6) = 1  'popular(c)'
                lang(8, 6) = 1  'popular(c++)'
                lang(9, 6) = 1  'popular(c#)'

            ElseIf (Popular.Text = "no") Then
                lang(0, 6) = 0  'popular(javascript)'
                lang(1, 6) = 0  'popular(php)'
                lang(2, 6) = 1  'popular(sql)'
                lang(3, 6) = 0.166666  'popular(python)'
                lang(4, 6) = 0.666666  'popular(java)'
                lang(5, 6) = 0  'popular(swift)'
                lang(6, 6) = 1  'popular(html5)'
                lang(7, 6) = 0  'popular(c)'
                lang(8, 6) = 0  'popular(c++)'
                lang(9, 6) = 0  'popular(c#)'

            End If

            If (Difficulty.Text = "easy") Then
                lang(0, 7) = 0.6  'difficulty(javascript)'
                lang(1, 7) = 0.333333  'difficulty(php)'
                lang(2, 7) = 1  'difficulty(sql)'
                lang(3, 7) = 0  'difficulty(python)'
                lang(4, 7) = 0 'difficulty(java)'
                lang(5, 7) = 0  'difficulty(swift)'
                lang(6, 7) = 1  'difficulty(html5)'
                lang(7, 7) = 0.333333  'difficulty(c)'
                lang(8, 7) = 0  'difficulty(c++)'
                lang(9, 7) = 0  'difficulty(c#)'

            ElseIf (Difficulty.Text = "medium") Then
                lang(0, 7) = 0.2  'difficulty(javascript)'
                lang(1, 7) = 0.666666  'difficulty(php)'
                lang(2, 7) = 0  'difficulty(sql)'
                lang(3, 7) = 1  'difficulty(python)'
                lang(4, 7) = 0  'difficulty(java)'
                lang(5, 7) = 0  'difficulty(swift)'
                lang(6, 7) = 0  'difficulty(html5)'
                lang(7, 7) = 0.333333  'difficulty(c)'
                lang(8, 7) = 1 'difficulty(c++)'
                lang(9, 7) = 1  'difficulty(c#)'

            ElseIf (Difficulty.Text = "hard") Then
                lang(0, 7) = 0.2  'difficulty(javascript)'
                lang(1, 7) = 0  'difficulty(php)'
                lang(2, 7) = 0  'difficulty(sql)'
                lang(3, 7) = 0  'difficulty(python)'
                lang(4, 7) = 1  'difficulty(java)'
                lang(5, 7) = 1  'difficulty(swift)'
                lang(6, 7) = 0  'difficulty(html5)'
                lang(7, 7) = 0.333333  'difficulty(c)'
                lang(8, 7) = 0  'difficulty(c++)'
                lang(9, 7) = 0  'difficulty(c#)'

            End If
            'ans0,ans1,ans2,ans3,ans4,ans5,ans6,ans7'
            'javascript,php,sql,python,java,swift,html5,c,c++,c#'
            Dim ans(10) As Double
            ans(0) = (5 / 30) * (lang(0, 0)) * (lang(0, 1)) * (lang(0, 2)) * (lang(0, 3)) * (lang(0, 4)) * (lang(0, 5)) * (lang(0, 6)) * (lang(0, 7)) * 100
            ans(1) = (3 / 30) * (lang(1, 0)) * (lang(1, 1)) * (lang(1, 2)) * (lang(1, 3)) * (lang(1, 4)) * (lang(1, 5)) * (lang(1, 6)) * (lang(1, 7)) * 100
            ans(2) = (2 / 30) * (lang(2, 0)) * (lang(2, 1)) * (lang(2, 2)) * (lang(2, 3)) * (lang(2, 4)) * (lang(2, 5)) * (lang(2, 6)) * (lang(2, 7)) * 100
            ans(3) = (6 / 30) * (lang(3, 0)) * (lang(3, 1)) * (lang(3, 2)) * (lang(3, 3)) * (lang(3, 4)) * (lang(3, 5)) * (lang(3, 6)) * (lang(3, 7)) * 100
            ans(4) = (3 / 30) * (lang(4, 0)) * (lang(4, 1)) * (lang(4, 2)) * (lang(4, 3)) * (lang(4, 4)) * (lang(4, 5)) * (lang(4, 6)) * (lang(4, 7)) * 100
            ans(5) = (2 / 30) * (lang(5, 0)) * (lang(5, 1)) * (lang(5, 2)) * (lang(5, 3)) * (lang(5, 4)) * (lang(5, 5)) * (lang(5, 6)) * (lang(5, 7)) * 100
            ans(6) = (2 / 30) * (lang(6, 0)) * (lang(6, 1)) * (lang(6, 2)) * (lang(6, 3)) * (lang(6, 4)) * (lang(6, 5)) * (lang(6, 6)) * (lang(6, 7)) * 100
            ans(7) = (3 / 30) * (lang(7, 0)) * (lang(7, 1)) * (lang(7, 2)) * (lang(7, 3)) * (lang(7, 4)) * (lang(7, 5)) * (lang(7, 6)) * (lang(7, 7)) * 100
            ans(8) = (2 / 30) * (lang(8, 0)) * (lang(8, 1)) * (lang(8, 2)) * (lang(8, 3)) * (lang(8, 4)) * (lang(8, 5)) * (lang(8, 6)) * (lang(8, 7)) * 100
            ans(9) = (2 / 30) * (lang(9, 0)) * (lang(9, 1)) * (lang(9, 2)) * (lang(9, 3)) * (lang(9, 4)) * (lang(9, 5)) * (lang(9, 6)) * (lang(9, 7)) * 100



            Dim max As Double
            max = 0
            For i As Integer = 0 To 9
                If (ans(i) > max) Then
                    max = ans(i)
                    If (i = 0) Then
                        Answer.Text = "คุณควรศึกษาภาษา  " + "javascript"
                    ElseIf (i = 1) Then
                        Answer.Text = "คุณควรศึกษาภาษา  " + "php"
                    ElseIf (i = 2) Then
                        Answer.Text = "คุณควรศึกษาภาษา  " + "sql"
                    ElseIf (i = 3) Then
                        Answer.Text = "คุณควรศึกษาภาษา  " + "python"
                    ElseIf (i = 4) Then
                        Answer.Text = "คุณควรศึกษาภาษา  " + "java"
                    ElseIf (i = 5) Then
                        Answer.Text = "คุณควรศึกษาภาษา  " + "swift"
                    ElseIf (i = 6) Then
                        Answer.Text = "คุณควรศึกษาภาษา  " + "html5"
                    ElseIf (i = 7) Then
                        Answer.Text = "คุณควรศึกษาภาษา  " + "c"
                    ElseIf (i = 8) Then
                        Answer.Text = "คุณควรศึกษาภาษา  " + "c++"
                    ElseIf (i = 9) Then
                        Answer.Text = "คุณควรศึกษาภาษา  " + "c#"
                    End If
                End If
            Next

        End If

    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object,
                   e As LinkLabelLinkClickedEventArgs) Handles link.LinkClicked
        Process.Start("chrome.exe", "https://www.facebook.com/niawjunior.Official")
    End Sub

End Class
