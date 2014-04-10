''' <summary>
''' Class with static methods for validating input for the StudData Database
''' </summary>
''' <remarks></remarks>
Public Class DatabaseValidation

    ''' <summary>
    ''' Validates a Student Number
    ''' </summary>
    ''' <param name="text"></param>
    ''' <param name="errors"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function StudentNumber(text As String, Optional ByRef errors As String = Nothing) As Boolean
        ' Constants
        ' Length of a student number
        Const STUDENT_NUMBER_LENGTH As Integer = 5
        ' Whether Valid Or Not
        Dim valid As Boolean = True

        ' Variables
        ' Current Student Number
        Dim outputStudentNumber As Integer

        ' Trim Before Checks
        text = text.Trim()

        ' Check that entry is long enough to be a full student number
        If text.Length = STUDENT_NUMBER_LENGTH Then

            ' Try to get the student number
            If Integer.TryParse(text, outputStudentNumber) Then

            Else ' Failed Parsing Number
                ' Display Error Status
                errors = "Student Number Must be Numeric"
                ' Not Valid
                valid = False
            End If

        Else ' Entry Not Long Enough
            ' Display Error Status
            errors = "Student Number Must be " & STUDENT_NUMBER_LENGTH & " Long"
            ' Not Valid
            valid = False
        End If

        ' Return Whether Valid Student Number
        Return valid
    End Function

    ''' <summary>
    ''' Validates a Student Name
    ''' </summary>
    ''' <param name="text"></param>
    ''' <param name="errors"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function StudentName(text As String, Optional ByRef errors As String = Nothing) As Boolean
        ' Constants
        ' Min Length of a student name
        Const STUDENT_NAME_MINIMUM_LENGTH As Integer = 4
        ' Max Length of a student name
        Const STUDENT_NAME_MAXIMUM_LENGTH As Integer = 50
        ' Whether Valid Or Not
        Dim valid As Boolean = True

        ' Check length of name
        If text.Length < STUDENT_NAME_MINIMUM_LENGTH Then
            ' Invalid Name
            valid = False

            ' Specify Error
            errors = "The student's name must be at least " & STUDENT_NAME_MINIMUM_LENGTH & " character long."

        ElseIf text.Length > STUDENT_NAME_MAXIMUM_LENGTH Then
            ' Invalid Name
            valid = False

            ' Specify Error
            errors = "The student's name must be " & STUDENT_NAME_MAXIMUM_LENGTH & " character long or less."
        End If

        ' Return Whether Valid Student Name
        Return valid
    End Function

    ''' <summary>
    ''' Validates a Phone Number
    ''' </summary>
    ''' <param name="text"></param>
    ''' <param name="errors"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function PhoneNumber(text As String, Optional ByRef errors As String = Nothing) As Boolean
        ' Constants
        ' Length of a student number
        Const PHONE_NUMBER_MINIMUM_LENGTH As Integer = 10
        ' Whether Valid Or Not
        Dim valid As Boolean = True

        ' Check length of number, numeric & if there is a decimal
        If text.Length < PHONE_NUMBER_MINIMUM_LENGTH Then
            ' Invalid Name
            valid = False

            ' Specify Error
            errors = "The phone number must be at least " & PHONE_NUMBER_MINIMUM_LENGTH & " digits long."
        ElseIf IsNumeric(text) And (Not text.IndexOf(".") = -1) Then
            ' Invalid Name
            valid = False

            ' Specify Error
            errors = "The phone number cannot contain decimals."
        End If

        ' Return Whether Valid Phone Number
        Return valid
    End Function

    ''' <summary>
    ''' Validates an Enroll Date
    ''' </summary>
    ''' <param name="text"></param>
    ''' <param name="errors"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function EnrollDate(text As String, Optional ByRef errors As String = Nothing) As Boolean
        ' Whether Valid Or Not
        Dim valid As Boolean = True

        ' Check if Date
        If Not IsDate(text) Then
            ' Invalid Name
            valid = False

            ' Specify Error
            errors = "The enroll date must be a valid date."
        End If

        ' Return Whether Valid Date
        Return valid
    End Function

    ''' <summary>
    ''' Validates a Student Loan
    ''' </summary>
    ''' <param name="text"></param>
    ''' <param name="errors"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function StudentLoan(text As String, Optional ByRef errors As String = Nothing) As Boolean
        ' Whether Valid Or Not
        Dim valid As Boolean = True

        ' Check Loan
        If Not IsNumeric(text) Then
            ' Invalid Name
            valid = False

            ' Specify Error
            errors = "The student loan must be a number."
        End If

        ' Return Whether Valid Student Loan
        Return valid
    End Function

    ''' <summary>
    ''' Validates a Major
    ''' </summary>
    ''' <param name="text"></param>
    ''' <param name="errors"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Major(text As String, Optional ByRef errors As String = Nothing) As Boolean
        ' Whether Valid Or Not
        Dim valid As Boolean = True

        ' Check for either CPA or CST
        If Not (text.Equals("CPA") Or text.Equals("CST")) Then
            ' Invalid Name
            valid = False

            ' Specify Error
            errors = "The major must be one of CPA or CST"
        End If

        ' Return Whether Valid Major
        Return valid
    End Function
End Class
