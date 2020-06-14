Imports Microsoft.Office.Interop.Excel

Public Class IncidentStatusForm
    Private Sub Result_A_Click(sender As Object, e As EventArgs) Handles Result_A.Click
        MessageBox.Show("Resolved Permanent fix", "Incident Status", MessageBoxButtons.OK)
    End Sub
    Private Sub Result_B_Click(sender As Object, e As EventArgs) Handles Result_B.Click
        MessageBox.Show("Resolved workaround and Mark PMC for re-occuring issues", "Incident Status", MessageBoxButtons.OK)
    End Sub
    Private Sub Result_C_Click(sender As Object, e As EventArgs) Handles Result_C.Click
        MessageBox.Show("Not resolved, withdrawn from user", "Incident Status", MessageBoxButtons.OK)
    End Sub
    Private Sub Result_D_Click(sender As Object, e As EventArgs) Handles Result_D.Click
        MessageBox.Show("Not resolved, no response from user", "Incident Status", MessageBoxButtons.OK)
    End Sub
End Class
