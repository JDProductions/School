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
    'test scores for first student
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

Sub CalculateAverage()
End Sub

End Module

 Public Class Form1


Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculateAverage.Click
    StudentScoreDataInput()
    StudentScoreDataInput2()
End Sub
End Class