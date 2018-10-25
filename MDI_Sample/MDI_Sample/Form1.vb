Imports System.Threading
Imports Issuer
Imports Security

Public Class MainForm
    Private Shared securityCount As Integer
    Private Shared issuerCount As Integer

    Private Sub NewIssuerMenuItem_Click(sender As Object, e As EventArgs) Handles NewIssuerMenuItem.Click
        Dim issuerDetails As New IssuerDetails()
        issuerDetails.MdiParent = Me
        issuerDetails.Text = "Issuer" + Interlocked.Increment(issuerCount).ToString()
        issuerDetails.Show()
    End Sub

    Private Sub NewSecurityMenuItem_Click(sender As Object, e As EventArgs) Handles NewSecurityMenuItem.Click
        Dim securityDetails As New SecurityDetails()
        securityDetails.MdiParent = Me
        securityDetails.Text = "Security" + Interlocked.Increment(securityCount).ToString()
        securityDetails.Show()
    End Sub

    Private Sub ViewIssuerSecurityMenuItem_Click(sender As Object, e As EventArgs) Handles ViewIssuerSecurityMenuItem.Click

    End Sub

    Private Sub ViewSecurityMenuItem_Click(sender As Object, e As EventArgs) Handles ViewSecurityMenuItem.Click

    End Sub

    Private Sub SearchIssuersMenuItem_Click(sender As Object, e As EventArgs) Handles SearchIssuersMenuItem.Click

    End Sub

    Private Sub SearchSecuritiesMenuItem_Click(sender As Object, e As EventArgs) Handles SearchSecuritiesMenuItem.Click

    End Sub
End Class
