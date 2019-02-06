'
' This is a form that performs as a basic calculator.
'
' Written by: Brianna Drew (0622446) - February 2018
'
' Purpose: To perform basic addition, subtraction, multipication, and division as a basic calculator.
'
' Parameters: None
'
' Subroutine Required: Each button on the form has it's own subroutine.
'
' Modifications: - February 8/18 - Program started, basic features dragged to form (buttons, text box, label) as well as general design.
'                - February 13/18 - Functions added to some of the buttons (clearing text/list boxes, adding items to list box, close button).
'                - February 14-15/18 - Added a bunch of stuff that I ended up not needing, so they are now deleted (i.e. I unintentionally wasted my time).
'                - February 16/18 - Program completed (added everything actually required to make calculations).
'

Public Class Form1


    ' This section of code defines the variables required for making calculations.
    Dim Number1 As Double = 0.0 ' Definition for variable to hold the first number the user enters of equation.
    Dim Number2 As Double = 0.0 ' Definition for variable to hold the second number the user enters of equation.
    Dim Result As Double = 0.0 ' Definition for variable to hold the result of the equation.
    Dim is_Add As Boolean = False ' Definition for variable to hold whether the operator in the equation is addition or not.
    Dim is_Subtract As Boolean = False ' Definition for variable to hold whether the operator in the equation is subtraction or not.
    Dim is_Multiply As Boolean = False ' Definition for variable to hold whether the operator in the equation is multipication or not.
    Dim is_Divide As Boolean = False ' Definition for variable to hold whether the operator in the equation is division or not.


    Private Sub Addition_Click(sender As Object, e As EventArgs) Handles Addition.Click
        ' This subroutine runs when the addition button is clicked.

        Operator_Symbol.Text = "+" ' Changes the operator symbol label text to addition symbol.
        Number1 = (Convert.ToDouble(Input_1.Text)) ' Assigns what the user entered as the first number to it's designated variable.
        ListBox.Items.Add(Input_1.Text) ' Adds what the user entered as the first number to the list box.
        ListBox.Items.Add("+") ' Adds a addition sign to the list box.
        is_Add = True ' Makes it so that the operator in the equation is addition.

    End Sub


    Private Sub Subtraction_Click(sender As Object, e As EventArgs) Handles Subtraction.Click
        ' This subroutine runs when the subtraction button is clicked.

        Operator_Symbol.Text = "-" ' Changes the operator symbol label text to a subtraction symbol.
        Number1 = (Convert.ToDouble(Input_1.Text)) ' Assigns what the user entered as the first number to it's designated variable.
        ListBox.Items.Add(Input_1.Text) ' Adds what the user entered as the first number to the list box.
        ListBox.Items.Add("-") ' Adds a subtraction sign to the list box.
        is_Subtract = True ' Makes it so that the operator in the equation is subtraction.

    End Sub


    Private Sub Multipication_Click(sender As Object, e As EventArgs) Handles Multipication.Click
        ' This subroutine runs when the multipication button is clicked.

        Operator_Symbol.Text = "x" ' Changes the operator symbol label text to a multipication symbol.
        Number1 = (Convert.ToDouble(Input_1.Text)) ' Assigns what the user entered as the first number to it's designated variable.
        ListBox.Items.Add(Input_1.Text) ' Adds what the user entered as the first number to the list box.
        ListBox.Items.Add("x") ' Adds a multipication sign to the list box.
        is_Multiply = True ' Makes it so that the operator in the equation is multipication.

    End Sub


    Private Sub Division_Click(sender As Object, e As EventArgs) Handles Division.Click
        ' This subroutine runs when the division button is clicked.

        Operator_Symbol.Text = "/" ' Changes the operator symbol label text to a division symbol.
        Number1 = (Convert.ToDouble(Input_1.Text)) ' Assigns what the user entered as the first number to it's designated variable.
        ListBox.Items.Add(Input_1.Text) ' Adds what the user entered as the first number to the list box.
        ListBox.Items.Add("/") ' Adds a division sign to the list box.
        is_Divide = True ' Makes it so that the operator in the equation is division.

    End Sub


    Private Sub Equals_Button_Click(sender As Object, e As EventArgs) Handles Equals_Button.Click
        ' This subroutine runs when the equals button is clicked.

        Number2 = (Convert.ToDouble(Input_2.Text)) ' Assigns what the user entered as the second number to it's designated variable.
        ListBox.Items.Add(Input_2.Text) ' Adds what the user entered as the second number to the list box.
        ListBox.Items.Add("=") ' Adds an equals sign to the list box.

        If is_Add = True Then ' If the operator to be used is addition, then...
            Result = Number1 + Number2 ' Add the two user inputted numbers together.
            Output.Text = Result ' Show the result of the calculation in the result text box.
        Else
            If is_Subtract = True Then ' If the operator to be used is subtraction, then...
                Result = Number1 - Number2 ' Subtract the second user inputted number from the first user inputted number.
                Output.Text = Result ' Show the result of the calculation in the result text box.
            Else
                If is_Multiply = True Then ' If the operator to be used is multipication, then...
                    Result = Number1 * Number2 ' Multiply the two user inputted numbers together.
                    Output.Text = Result ' Show the result of the calculation in the result text box.
                Else
                    If is_Divide = True Then ' If the operator to be used is division, then...
                        If Number2 = 0 Then ' If the second user inputted number is 0, then...
                            Output.Text = "Error" ' Print "Error" in the result text box.
                        Else ' If the second user inputted number is any number other than 0, then...
                            Result = Number1 / Number2 ' Divide the first user inputted number by the second user inputted number.
                            Output.Text = Result ' Show the result of the calculation in the result text box.
                        End If
                    End If
                End If
            End If
        End If

        ListBox.Items.Add(Output.Text) ' Adds the result of the equation to the list box.

    End Sub


    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        ' This subroutine runs when the clear button is clicked.

        Input_1.Clear() ' Clears what's in the first number text box.
        Input_2.Clear() ' Clears what's in the second number text box.
        Output.Clear() ' Clears what's in the result text box.
        Operator_Symbol.ResetText() ' Resets the label text that holds the operator symbol to it's default value (which is nothing).
        Number1 = 0.0 ' Resets the value of the first number to 0.
        Number2 = 0.0 ' Resets the value of the second number to 0.
        Result = 0.0 ' Resets the value of the result of the equation to 0.
        is_Add = False ' Resets whether it's calculating addition or not to False (not using addition).
        is_Subtract = False ' Resets whether it's calculating subtraction or not to False (not using subtraction).
        is_Multiply = False ' Resets whether it's calculating multipication or not to False (not using multipication).
        is_Divide = False ' Resets whether it's calculating division or not to False (not using division).

    End Sub


    Private Sub Clear_List_Click(sender As Object, e As EventArgs) Handles Clear_List.Click
        ' This subroutine runs when the reset button is clicked.

        ListBox.Items.Clear() ' Clears everything in the list box.

    End Sub


    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        ' This subroutine runs when the quit button is clicked.

        Me.Close() ' Closes the application.

    End Sub


End Class