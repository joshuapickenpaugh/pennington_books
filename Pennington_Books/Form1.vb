'Joshua Pickenpaugh
'September 23rd, 2016
'"Pennington Books" sales calculator. 

Public Class frmMain

    'Instantiates an object at class-level, so it can be seen by all:
    Dim booksale As New Booksale

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click

        'Clears the text boxes and labels:
        txtQuantity.Text = String.Empty
        txtPrice.Text = String.Empty
        lblTotal.Text = String.Empty

        'Clears the running total:
        booksale.ClearTotal()

    End Sub

    Private Sub btnAddToSale_Click(sender As Object, e As EventArgs) Handles btnAddToSale.Click

        'Assigns text boxes to object properties:
        Integer.TryParse(txtQuantity.Text, booksale.Quantity)
        Double.TryParse(txtPrice.Text, booksale.Price)

        'Calls object method:
        lblTotal.Text = booksale.KeepRunningTotal().ToString("C2")

    End Sub
End Class
