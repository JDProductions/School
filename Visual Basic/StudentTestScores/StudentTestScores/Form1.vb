Imports System.IO

Module StudentTestScoresModule

    Const intMAX_SUBSCRIPT_STUDENT As Integer = 6
    Const intMAX_SUBSCRIPT_STUDENT_SCORES As Integer = 5
   'create structure
    Public Structure StudentData
       Dim strName As String
       Dim dblTestScoresArray() As Double
       Dim dblAverage As Double
    End Structure

Dim dblTotalStd1 As Double
Dim dblTotalStd2 As Double
Dim dblTotalStd3 As Double
Dim dblTotalStd4 As Double
Dim dblTotalStd5 As Double
Dim dblTotalStd6 As Double
Dim dblScore As Double

Dim StudentsArray(intMAX_SUBSCRIPT_STUDENT) As StudentData

Sub StudentNameDataInput()
    StudentsArray(0).strName = Form1.txtName1.Text
    StudentsArray(1).strName = Form1.txtName2.Text
    StudentsArray(2).strName = Form1.txtName3.Text
    StudentsArray(3).strName = Form1.txtName4.Text
    StudentsArray(4).strName = Form1.txtName5.Text
    StudentsArray(5).strName = Form1.txtName6.Text
End Sub

Sub StudentScoreDataInput()
    For intIndex = 0 To intMAX_SUBSCRIPT_STUDENT
        ReDim StudentsArray(intIndex).dblTestScoresArray(4)
    Next
        'test scores for first student
    If Form1.txtS11.Text < 0 Or Form1.txtS11.Text > 100 Then
      MessageBox.Show("Please enter positive integers only- Program Closing")
          Form1.Close()  
            Throw New ArgumentException("Exception Occured")
              
    End If
        
    StudentsArray(0).dblTestScoresArray(0) = CDbl(Form1.txtS11.Text)
    StudentsArray(1).dblTestScoresArray(1) = CDbl(Form1.txtS12.Text)
    StudentsArray(2).dblTestScoresArray(2) = CDbl(Form1.txtS13.Text)
    StudentsArray(3).dblTestScoresArray(3) = CDbl(Form1.txtS14.Text)
    StudentsArray(4).dblTestScoresArray(4) = CDbl(Form1.txtS15.Text)


    For Each i As StudentData In StudentsArray
    For Each S as Double in i.dblTestScoresArray
        dblTotalStd1 += s
    Next
Next
    Dim dblAverage As Double = dblTotalStd1/intMAX_SUBSCRIPT_STUDENT_SCORES
    Form1.lblAvg1.Text = (dblAverage.ToString)
End Sub

    Sub StudentScoreDataInput2()
    For intIndex = 0 To intMAX_SUBSCRIPT_STUDENT
        ReDim StudentsArray(intIndex).dblTestScoresArray(4)
    Next
    
            If Form1.txtS21.Text < 0 Or Form1.txtS21.Text > 100 Then
      MessageBox.Show("Please enter positive integers only- Program Closing")
          Form1.Close()
    End If
    StudentsArray(0).dblTestScoresArray(0) = CDbl(Form1.txtS21.Text)
    StudentsArray(1).dblTestScoresArray(1) = CDbl(Form1.txtS22.Text)
    StudentsArray(2).dblTestScoresArray(2) = CDbl(Form1.txtS23.Text)
    StudentsArray(3).dblTestScoresArray(3) = CDbl(Form1.txtS24.Text)
    StudentsArray(4).dblTestScoresArray(4) = CDbl(Form1.txtS25.Text)

    For Each i As StudentData In StudentsArray
    For Each S as Double in i.dblTestScoresArray
        dblTotalStd2 += s
    Next
Next
    Dim dblAverage2 As Double = dblTotalStd2/intMAX_SUBSCRIPT_STUDENT_SCORES
    Form1.lblAvg2.Text = (dblAverage2.ToString)
End Sub

        Sub StudentScoreDataInput3()
    For intIndex = 0 To intMAX_SUBSCRIPT_STUDENT
        ReDim StudentsArray(intIndex).dblTestScoresArray(4)
    Next
    
            If Form1.txtS31.Text < 0 Or Form1.txtS31.Text > 100 Then
      MessageBox.Show("Please enter positive integers only- Program Closing")
          Form1.Close()
    End If
    StudentsArray(0).dblTestScoresArray(0) = CDbl(Form1.txtS31.Text)
    StudentsArray(1).dblTestScoresArray(1) = CDbl(Form1.txtS32.Text)
    StudentsArray(2).dblTestScoresArray(2) = CDbl(Form1.txtS33.Text)
    StudentsArray(3).dblTestScoresArray(3) = CDbl(Form1.txtS34.Text)
    StudentsArray(4).dblTestScoresArray(4) = CDbl(Form1.txtS35.Text)

    For Each i As StudentData In StudentsArray
    For Each S as Double in i.dblTestScoresArray
        dblTotalStd3 += s
    Next
Next
    Dim dblAverage3 As Double = dblTotalStd3/intMAX_SUBSCRIPT_STUDENT_SCORES
    Form1.lblAvg3.Text = (dblAverage3.ToString)
End Sub

            Sub StudentScoreDataInput4()
    For intIndex = 0 To intMAX_SUBSCRIPT_STUDENT
        ReDim StudentsArray(intIndex).dblTestScoresArray(4)
    Next
        If Form1.txtS41.Text < 0 Or Form1.txtS41.Text > 100 Then
      MessageBox.Show("Please enter positive integers only- Program Closing")
          Form1.Close()
    End If
    StudentsArray(0).dblTestScoresArray(0) = CDbl(Form1.txtS41.Text)
    StudentsArray(1).dblTestScoresArray(1) = CDbl(Form1.txtS42.Text)
    StudentsArray(2).dblTestScoresArray(2) = CDbl(Form1.txtS43.Text)
    StudentsArray(3).dblTestScoresArray(3) = CDbl(Form1.txtS44.Text)
    StudentsArray(4).dblTestScoresArray(4) = CDbl(Form1.txtS45.Text)

    For Each i As StudentData In StudentsArray
    For Each S as Double in i.dblTestScoresArray
        dblTotalStd4 += s
    Next
Next
    Dim dblAverage4 As Double = dblTotalStd4/intMAX_SUBSCRIPT_STUDENT_SCORES
    Form1.lblAvg4.Text = (dblAverage4.ToString)
End Sub

    Sub StudentScoreDataInput5()
    For intIndex = 0 To intMAX_SUBSCRIPT_STUDENT
        ReDim StudentsArray(intIndex).dblTestScoresArray(4)
    Next
    
        If Form1.txtS51.Text < 0 Or Form1.txtS51.Text > 100 Then
      MessageBox.Show("Please enter positive integers only- Program Closing")
          Form1.Close()
    End If
    StudentsArray(0).dblTestScoresArray(0) = CDbl(Form1.txtS51.Text)
    StudentsArray(1).dblTestScoresArray(1) = CDbl(Form1.txtS52.Text)
    StudentsArray(2).dblTestScoresArray(2) = CDbl(Form1.txtS53.Text)
    StudentsArray(3).dblTestScoresArray(3) = CDbl(Form1.txtS54.Text)
    StudentsArray(4).dblTestScoresArray(4) = CDbl(Form1.txtS55.Text)

    For Each i As StudentData In StudentsArray
    For Each S as Double in i.dblTestScoresArray
        dblTotalStd5 += s
    Next
Next
    Dim dblAverage5 As Double = dblTotalStd5/intMAX_SUBSCRIPT_STUDENT_SCORES
    Form1.lblAvg5.Text = (dblAverage5.ToString)
End Sub

    Sub StudentScoreDataInput6()
    For intIndex = 0 To intMAX_SUBSCRIPT_STUDENT
        ReDim StudentsArray(intIndex).dblTestScoresArray(4)
    Next
        If Form1.txtS61.Text < 0 Or Form1.txtS61.Text > 100 Then
      MessageBox.Show("Please enter positive integers only- Program Closing")
          Form1.Close()
    End If
    StudentsArray(0).dblTestScoresArray(0) = CDbl(Form1.txtS61.Text)
    StudentsArray(1).dblTestScoresArray(1) = CDbl(Form1.txtS62.Text)
    StudentsArray(2).dblTestScoresArray(2) = CDbl(Form1.txtS63.Text)
    StudentsArray(3).dblTestScoresArray(3) = CDbl(Form1.txtS64.Text)
    StudentsArray(4).dblTestScoresArray(4) = CDbl(Form1.txtS65.Text)

    For Each i As StudentData In StudentsArray
    For Each S as Double in i.dblTestScoresArray
        dblTotalStd6 += s
    Next
Next
    Dim dblAverage6 As Double = dblTotalStd6/intMAX_SUBSCRIPT_STUDENT_SCORES
    Form1.lblAvg6.Text = (dblAverage6.ToString)
End Sub

Sub CalculateAverage()
End Sub

End Module

 Public Class Form1


Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculateAverage.Click
    StudentScoreDataInput()
    StudentScoreDataInput2()
    StudentScoreDataInput3()
    StudentScoreDataInput4()
    StudentScoreDataInput5()
    StudentScoreDataInput6()
End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SaveData_Click(sender As Object, e As EventArgs) Handles SaveData.Click
        Dim strFile As String = "Testscores.txt"
Dim fileExists As Boolean = File.Exists(strFile)
Using sw As New StreamWriter(File.Open(strFile, FileMode.OpenOrCreate))
    sw.WriteLine(Me.txtName1.Text)
    sw.WriteLine(Me.txtS11.Text)
    sw.WriteLine(Me.txtS12.Text)
    sw.WriteLine(Me.txtS13.Text)
    sw.WriteLine(Me.txtS14.Text)
    sw.WriteLine(Me.txtS15.Text)
    sw.WriteLine(Me.lblAvg1.Text)

    sw.WriteLine(Me.txtName2.Text)
    sw.WriteLine(Me.txtS21.Text)
    sw.WriteLine(Me.txtS22.Text)
    sw.WriteLine(Me.txtS23.Text)
    sw.WriteLine(Me.txtS24.Text)
    sw.WriteLine(Me.txtS25.Text)
    sw.WriteLine(Me.lblAvg2.Text)
    
    
    sw.WriteLine(Me.txtName3.Text)
    sw.WriteLine(Me.txtS31.Text)
    sw.WriteLine(Me.txtS32.Text)
    sw.WriteLine(Me.txtS33.Text)
    sw.WriteLine(Me.txtS34.Text)
    sw.WriteLine(Me.txtS35.Text)
    sw.WriteLine(Me.lblAvg3.Text)

    sw.WriteLine(Me.txtName4.Text)
    sw.WriteLine(Me.txtS41.Text)
    sw.WriteLine(Me.txtS42.Text)
    sw.WriteLine(Me.txtS43.Text)
    sw.WriteLine(Me.txtS44.Text)
    sw.WriteLine(Me.txtS45.Text)
    sw.WriteLine(Me.lblAvg4.Text)

    sw.WriteLine(Me.txtName5.Text)
    sw.WriteLine(Me.txtS51.Text)
    sw.WriteLine(Me.txtS52.Text)
    sw.WriteLine(Me.txtS53.Text)
    sw.WriteLine(Me.txtS54.Text)
    sw.WriteLine(Me.txtS55.Text)
    sw.WriteLine(Me.lblAvg5.Text)

    sw.WriteLine(Me.txtName6.Text)
    sw.WriteLine(Me.txtS61.Text)
    sw.WriteLine(Me.txtS62.Text)
    sw.WriteLine(Me.txtS63.Text)
    sw.WriteLine(Me.txtS64.Text)
    sw.WriteLine(Me.txtS65.Text)
    sw.WriteLine(Me.lblAvg6.Text)
      
    MessageBox.Show("All Data is Written")

    End Using

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim strFile As String = "Testscores.txt"
        Dim fileExists As Boolean = File.Exists(strFile)
Using sw As New StreamReader(File.Open(strFile, FileMode.Open))
            txtName1.Text = sw.ReadLine()
            txtS11.Text = sw.ReadLine()
            txtS12.Text = sw.ReadLine()
            txtS13.Text = sw.ReadLine()
            txtS14.Text = sw.ReadLine()
            txtS15.Text = sw.ReadLine()
            lblAvg1.Text = sw.ReadLine()

            txtName2.Text = sw.ReadLine()
            txtS21.Text = sw.ReadLine()
            txtS22.Text = sw.ReadLine()
            txtS23.Text = sw.ReadLine()
            txtS24.Text = sw.ReadLine()
            txtS25.Text = sw.ReadLine()
            lblAvg2.Text = sw.ReadLine()

            txtName3.Text = sw.ReadLine()
            txtS31.Text = sw.ReadLine()
            txtS32.Text = sw.ReadLine()
            txtS33.Text = sw.ReadLine()
            txtS34.Text = sw.ReadLine()
            txtS35.Text = sw.ReadLine()
            lblAvg3.Text = sw.ReadLine()

            txtName4.Text = sw.ReadLine()
            txtS41.Text = sw.ReadLine()
            txtS42.Text = sw.ReadLine()
            txtS43.Text = sw.ReadLine()
            txtS44.Text = sw.ReadLine()
            txtS45.Text = sw.ReadLine()
            lblAvg4.Text = sw.ReadLine()

            txtName5.Text = sw.ReadLine()
            txtS51.Text = sw.ReadLine()
            txtS52.Text = sw.ReadLine()
            txtS53.Text = sw.ReadLine()
            txtS54.Text = sw.ReadLine()
            txtS55.Text = sw.ReadLine()
            lblAvg5.Text = sw.ReadLine()

            txtName6.Text = sw.ReadLine()
            txtS61.Text = sw.ReadLine()
            txtS62.Text = sw.ReadLine()
            txtS63.Text = sw.ReadLine()
            txtS64.Text = sw.ReadLine()
            txtS65.Text = sw.ReadLine()
            lblAvg6.Text = sw.ReadLine()

End Using
        ' Open the file

    End Sub
End Class