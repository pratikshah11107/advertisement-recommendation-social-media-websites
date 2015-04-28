Imports System.IO
Public Class _Default
    Inherits System.Web.UI.Page
    Shared temp As String
    Dim chk1cm As Integer = 2615313
    Dim chk2cm As Integer = 3748615

    Dim chk3cm As Integer = 1917896

    Dim chk4cm As Integer = 435885

    Dim chk1Im As Integer = 27275781

    Dim chk2Im As Integer = 15910872

    Dim chk3Im As Integer = 1818385

    Dim chk4Im As Integer = 454596

    Dim chk1Sm As Integer = 1613260

    Dim chk2Sm As Integer = 2192379

    Dim chk3Sm As Integer = 206828

    Dim chk4Sm As Integer = 41365

    Dim chk1Um As Integer = 24719243

    Dim chk2Um As Integer = 31671530

    Dim chk3Um As Integer = 16994479

    Dim chk4Um As Integer = 3862381

    Dim chk1cf As Integer = 2949182

    Dim chk2cf As Integer = 4227162

    Dim chk3cf As Integer = 2162734

    Dim chk4cf As Integer = 491530

    Dim chk1If As Integer = 9583382

    Dim chk2If As Integer = 5590306

    Dim chk3If As Integer = 638892

    Dim chk4If As Integer = 159722

    Dim chk1Sf As Integer = 691397

    Dim chk2Sf As Integer = 939591

    Dim chk3Sf As Integer = 88640

    Dim chk4Sf As Integer = 17727

    Dim chk1Uf As Integer = 29018241

    Dim chk2Uf As Integer = 37179622

    Dim chk3Uf As Integer = 19950040

    Dim chk4Uf As Integer = 4534100

    Dim Audiance As Integer = 0
    Dim Male As Integer = 0
    Dim Female As Integer = 0
    Dim Male1 As Integer = 0
    Dim Female1 As Integer = 0
    Dim Male2 As Integer = 0
    Dim Female2 As Integer = 0
    Dim Male3 As Integer = 0
    Dim Female3 As Integer = 0
    Dim Male4 As Integer = 0
    Dim Female4 As Integer = 0

    Dim Users1 As Integer = 0
    Dim Users2 As Integer = 0
    Dim Users3 As Integer = 0
    Dim Users4 As Integer = 0

    Dim Usersg1 As String = ""
    Dim Usersg2 As String = ""
    Dim Usersg3 As String = ""
    Dim Usersg4 As String = ""
    Dim Price As String = ""
    Dim Age As String = ""
    Dim cpcm1 As Double = 0
    Dim cpcm2 As Double = 0
    Dim cpcm3 As Double = 0
    Dim cpcm4 As Double = 0
    Dim cpcf1 As Double = 0
    Dim cpcf2 As Double = 0
    Dim cpcf3 As Double = 0
    Dim cpcf4 As Double = 0
    Dim cpmm1 As Double = 0
    Dim cpmm2 As Double = 0
    Dim cpmm3 As Double = 0
    Dim cpmm4 As Double = 0
    Dim cpmf1 As Double = 0
    Dim cpmf2 As Double = 0
    Dim cpmf3 As Double = 0
    Dim cpmf4 As Double = 0
    Dim cpcc As Double = 0.7
    Dim cpcs As Double = 0.34
    Dim cpcI As Double = 0.32
    Dim cpcu As Double = 1.05
    Dim cpmc As Double = 0.17
    Dim cpms As Double = 0.08
    Dim cpmI As Double = 0.07
    Dim cpmu As Double = 0.21
    Dim c1 As Double = 0
    Dim c2 As Double = 0
    Dim c3 As Double = 0
    Dim c4 As Double = 0

    Dim Cost1 As String = ""
    Dim Cost2 As String = ""
    Dim Cost3 As String = ""
    Dim Cost4 As String = ""

    Dim opd As String = ""
    Dim Opcost As Double = 0
    Dim Usersg As String = ""
    Dim Users As Integer = 0
   

#Region "Fields"

    Private dbOperations As New clsDbOperations

#End Region

#Region "System Methods"

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click

        chk4.Checked = False
        RadioButton1.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        chk1.Checked = False
        chk2.Checked = False
        chk3.Checked = False
        txtURL.Text = String.Empty
        txtTitle.Text = String.Empty
        cmbCountries.SelectedIndex = 0
        lstCategories.SelectedIndex = -1
        lbPreHeader.Text = ""
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        If fuImage.HasFile Then
            fuImage.PostedFile.InputStream.Dispose()
        End If

    End Sub

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click

        
        lbPreHeader.Text = "<br />" + txtTitle.Text
        Label2.Text = txtURL.Text
        If fuImage.HasFile Then
            Try
                Dim filename As String = Path.GetFileName(fuImage.FileName)
                fuImage.SaveAs(Server.MapPath("~/") & filename)
                temp = "~/" & filename
                Image1.Visible = True
                Image1.ImageUrl = temp
            Catch ex As Exception
                lbPreHeader.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message
            End Try
        End If

        Label1.Text = txtDescription.InnerText
        'Canada Statistics
        If cmbCountries.SelectedItem.Text = "Canada" Then
            If RadioButton4.Checked = True Then
                If lstCategories.SelectedItem.Text = "Food" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1cm * 10) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.08
                        cpcm1 = cpcm1 * cpcc
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2cm * 7) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.05
                        cpcm2 = cpcm2 * cpcc
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3cm * 15) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.03
                        cpcm3 = cpcm3 * cpcc
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4cm * 9) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcc
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Movie" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1cm * 20) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.06
                        cpcm1 = cpcm1 * cpcc
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2cm * 20) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.08
                        cpcm2 = cpcm2 * cpcc
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3cm * 9) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.04
                        cpcm3 = cpcm3 * cpcc
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4cm * 6) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.03
                        cpcm4 = cpcm4 * cpcc
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Music" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1cm * 19) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.09
                        cpcm1 = cpcm1 * cpcc
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2cm * 18) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.06
                        cpcm2 = cpcm2 * cpcc
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3cm * 7) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.03
                        cpcm3 = cpcm3 * cpcc
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4cm * 1) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.01
                        cpcm4 = cpcm4 * cpcc
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Shopping" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1cm * 16) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.05
                        cpcm1 = cpcm1 * cpcc
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2cm * 18) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.07
                        cpcm2 = cpcm2 * cpcc
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3cm * 4) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.04
                        cpcm3 = cpcm3 * cpcc
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4cm * 1) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcc
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Sport" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1cm * 14) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.07
                        cpcm1 = cpcm1 * cpcc
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2cm * 23) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.05
                        cpcm2 = cpcm2 * cpcc
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3cm * 13) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.05
                        cpcm3 = cpcm3 * cpcc
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4cm * 9) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.03
                        cpcm4 = cpcm4 * cpcc
                    End If
                End If
            End If
            If RadioButton5.Checked = True Then
                If lstCategories.SelectedItem.Text = "Food" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1cf * 9) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.08
                        cpcf1 = cpcf1 * cpcc
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2cf * 30) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.05
                        cpcf2 = cpcf2 * cpcc
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3cf * 9) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.03
                        cpcf3 = cpcf3 * cpcc
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4cf * 12) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.02
                        cpcf4 = cpcf4 * cpcc
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Movie" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1cf * 15) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.06
                        cpcf1 = cpcf1 * cpcc
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2cf * 25) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.08
                        cpcf2 = cpcf2 * cpcc
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3cf * 11) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.04
                        cpcf3 = cpcf3 * cpcc
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4cf * 4) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.03
                        cpcf4 = cpcf4 * cpcc

                    End If
                End If
                If lstCategories.SelectedItem.Text = "Music" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1cf * 23) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.09
                        cpcf1 = cpcf1 * cpcc
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2cf * 22) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.06
                        cpcf2 = cpcf2 * cpcc
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3cf * 8) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.03
                        cpcf3 = cpcf3 * cpcc
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4cf * 2) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.01
                        cpcf4 = cpcf4 * cpcc
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Shopping" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1cf * 19) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.05
                        cpcf1 = cpcf1 * cpcc
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2cf * 31) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.07
                        cpcf2 = cpcf2 * cpcc
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3cf * 10) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.04
                        cpcf3 = cpcf3 * cpcc
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4cf * 1) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.02
                        cpcf4 = cpcf4 * cpcc
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Sport" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1cf * 12) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.07
                        cpcf1 = cpcf1 * cpcc
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2cf * 15) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.05
                        cpcf2 = cpcf2 * cpcc
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3cf * 11) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.05
                        cpcf3 = cpcf3 * cpcc
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4cf * 13) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.03
                        cpcf4 = cpcf4 * cpcc
                    End If
                End If

            End If
            If RadioButton6.Checked = True Then
                If lstCategories.SelectedItem.Text = "Food" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1cm * 10) / 100)
                        cpcm1 = Male1 * 0.08
                        cpcm1 = cpcm1 * cpcc
                        Female1 = ((chk1cf * 9) / 100)
                        cpcf1 = Female1 * 0.08
                        cpcf1 = cpcf1 * cpcc
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2cm * 7) / 100)
                        cpcm2 = Male2 * 0.05
                        cpcm2 = cpcm2 * cpcc
                        Female2 = ((chk2cf * 30) / 100)
                        cpcf2 = Female2 * 0.05
                        cpcf2 = cpcf2 * cpcc
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3cm * 15) / 100)
                        cpcm3 = Male3 * 0.03
                        cpcm3 = cpcm3 * cpcc
                        Female3 = ((chk3cf * 9) / 100)
                        cpcf3 = Female3 * 0.03
                        cpcf3 = cpcf3 * cpcc
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4cm * 9) / 100)
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcc
                        Female4 = ((chk4cf * 12) / 100)
                        cpcf4 = Female4 * 0.02
                        cpcf4 = cpcf4 * cpcc
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Movie" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1cm * 20) / 100)
                        cpcm1 = Male1 * 0.06
                        cpcm1 = cpcm1 * cpcc
                        Female1 = ((chk1cf * 15) / 100)
                        cpcf1 = Female1 * 0.06
                        cpcf1 = cpcf1 * cpcc
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2cm * 20) / 100)
                        cpcm2 = Male2 * 0.08
                        cpcm2 = cpcm2 * cpcc
                        Female2 = ((chk2cf * 25) / 100)
                        cpcf2 = Female2 * 0.08
                        cpcf2 = cpcf2 * cpcc
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3cm * 9) / 100)
                        cpcm3 = Male3 * 0.04
                        cpcm3 = cpcm3 * cpcc
                        Female3 = ((chk3cf * 11) / 100)
                        cpcf3 = Female3 * 0.04
                        cpcf3 = cpcf3 * cpcc
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4cm * 6) / 100)
                        cpcm4 = Male4 * 0.03
                        cpcm4 = cpcm4 * cpcc
                        Female4 = ((chk4cf * 4) / 100)
                        cpcf4 = Female4 * 0.03
                        cpcf4 = cpcf4 * cpcc
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Music" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1cm * 19) / 100)
                        cpcm1 = Male1 * 0.09
                        cpcm1 = cpcm1 * cpcc
                        Female1 = ((chk1cf * 23) / 100)
                        cpcf1 = Female1 * 0.09
                        cpcf1 = cpcf1 * cpcc
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2cm * 18) / 100)
                        cpcm2 = Male2 * 0.06
                        cpcm2 = cpcm2 * cpcc
                        Female2 = ((chk2cf * 22) / 100)
                        cpcf2 = Female2 * 0.06
                        cpcf2 = cpcf2 * cpcc
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3cm * 7) / 100)
                        cpcm3 = Male3 * 0.03
                        cpcm3 = cpcm3 * cpcc
                        Female3 = ((chk3cf * 8) / 100)
                        cpcf3 = Female3 * 0.03
                        cpcf3 = cpcf3 * cpcc
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4cm * 1) / 100)
                        cpcm4 = Male4 * 0.01
                        cpcm4 = cpcm4 * cpcc
                        Female4 = ((chk4cf * 2) / 100)
                        cpcf4 = Female4 * 0.01
                        cpcf4 = cpcf4 * cpcc
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Shopping" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1cm * 16) / 100)
                        cpcm1 = Male1 * 0.05
                        cpcm1 = cpcm1 * cpcc
                        Female1 = ((chk1cf * 19) / 100)
                        cpcf1 = Female1 * 0.05
                        cpcf1 = cpcf1 * cpcc
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2cm * 18) / 100)
                        cpcm2 = Male2 * 0.07
                        cpcm2 = cpcm2 * cpcc
                        Female2 = ((chk2cf * 31) / 100)
                        cpcf2 = Female2 * 0.07
                        cpcf2 = cpcf2 * cpcc
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3cm * 4) / 100)
                        cpcm3 = Male3 * 0.04
                        cpcm3 = cpcm3 * cpcc
                        Female3 = ((chk3cf * 10) / 100)
                        cpcf3 = Female3 * 0.04
                        cpcf3 = cpcf3 * cpcc
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4cm * 1) / 100)
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcc
                        Female4 = ((chk4cf * 1) / 100)
                        cpcf4 = Female4 * 0.02
                        cpcf4 = cpcf4 * cpcc
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Sport" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1cm * 14) / 100)
                        cpcm1 = Male1 * 0.07
                        cpcm1 = cpcm1 * cpcc
                        Female1 = ((chk1cf * 12) / 100)
                        cpcf1 = Female1 * 0.07
                        cpcf1 = cpcf1 * cpcc
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2cm * 23) / 100)
                        cpcm2 = Male2 * 0.05
                        cpcm2 = cpcm2 * cpcc
                        Female2 = ((chk2cf * 15) / 100)
                        cpcf2 = Female2 * 0.05
                        cpcf2 = cpcf2 * cpcc
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3cm * 13) / 100)
                        cpcm3 = Male3 * 0.05
                        cpcm3 = cpcm3 * cpcc
                        Female3 = ((chk3cf * 11) / 100)
                        cpcf3 = Female3 * 0.05
                        cpcf3 = cpcf3 * cpcc
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4cm * 9) / 100)
                        cpcm4 = Male4 * 0.03
                        cpcm4 = cpcm4 * cpcc
                        Female4 = ((chk4cf * 13) / 100)
                        cpcf4 = Female4 * 0.03
                        cpcf4 = cpcf4 * cpcc
                        Age = Age + "65+"
                    End If
                End If

            End If
            If RadioButton1.Checked = True Then
                Price = "* The CPC is $0.67"
            End If
            If RadioButton3.Checked = True Then
                Price = "* The CPM is $0.13"
            End If
            cpmm1 = (Male1 * cpmc)
            cpmm2 = (Male2 * cpmc)
            cpmm3 = (Male3 * cpmc)
            cpmm4 = (Male4 * cpmc)
            cpmf1 = (Female1 * cpmc)
            cpmf2 = (Female2 * cpmc)
            cpmf3 = (Female3 * cpmc)
            cpmf4 = (Female4 * cpmc)
        End If
        'India Statistics
        If cmbCountries.SelectedItem.Text = "India" Then
            If RadioButton4.Checked = True Then
                If lstCategories.SelectedItem.Text = "Food" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Im * 16) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.06
                        cpcm1 = cpcm1 * cpcI
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Im * 15) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.09
                        cpcm2 = cpcm2 * cpcI
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Im * 3) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.05
                        cpcm3 = cpcm3 * cpcI
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Im * 1) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.04
                        cpcm4 = cpcm4 * cpcI
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Movie" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Im * 11) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.08
                        cpcm1 = cpcm1 * cpcI
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Im * 19) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.07
                        cpcm2 = cpcm2 * cpcI
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Im * 1) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.02
                        cpcm3 = cpcm3 * cpcI
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Im * 1) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.01
                        cpcm4 = cpcm4 * cpcI
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Music" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Im * 21) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.09
                        cpcm1 = cpcm1 * cpcI
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Im * 7) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.09
                        cpcm2 = cpcm2 * cpcI
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Im * 1) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.08
                        cpcm3 = cpcm3 * cpcI
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Im * 1) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.03
                        cpcm4 = cpcm4 * cpcI
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Shopping" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Im * 9) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.05
                        cpcm1 = cpcm1 * cpcI
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Im * 12) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.06
                        cpcm2 = cpcm2 * cpcI
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Im * 4) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.02
                        cpcm3 = cpcm3 * cpcI
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Im * 1) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcI
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Sport" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Im * 12) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.07
                        cpcm1 = cpcm1 * cpcI
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Im * 24) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.05
                        cpcm2 = cpcm2 * cpcI
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Im * 1) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.05
                        cpcm3 = cpcm3 * cpcI
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Im * 1) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.03
                        cpcm4 = cpcm4 * cpcI
                    End If
                End If

            End If
            If RadioButton5.Checked = True Then
                If lstCategories.SelectedItem.Text = "Food" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1If * 32) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.06
                        cpcf1 = cpcf1 * cpcI
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2If * 24) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.09
                        cpcf2 = cpcf2 * cpcI
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3If * 6) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.05
                        cpcf3 = cpcf3 * cpcI
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4If * 3) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.04
                        cpcf4 = cpcf4 * cpcI
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Movie" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1If * 33) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.08
                        cpcf1 = cpcf1 * cpcI
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2If * 29) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.07
                        cpcf2 = cpcf2 * cpcI
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3If * 5) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.02
                        cpcf3 = cpcf3 * cpcI
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4If * 1) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.01
                        cpcf4 = cpcf4 * cpcI
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Music" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1If * 31) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.09
                        cpcf1 = cpcf1 * cpcI
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2If * 13) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.09
                        cpcf2 = cpcf2 * cpcI
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3If * 3) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.08
                        cpcf3 = cpcf3 * cpcI
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4If * 4) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.03
                        cpcf4 = cpcf4 * cpcI
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Shopping" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1If * 27) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.05
                        cpcf1 = cpcf1 * cpcI
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2If * 37) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.06
                        cpcf2 = cpcf2 * cpcI
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3If * 8) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.02
                        cpcf3 = cpcf3 * cpcI
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4If * 2) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.02
                        cpcf4 = cpcf4 * cpcI
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Sport" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1If * 31) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.07
                        cpcf1 = cpcf1 * cpcI
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2If * 29) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.05
                        cpcf2 = cpcf2 * cpcI
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3If * 1) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.05
                        cpcf3 = cpcf3 * cpcI
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4If * 1) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.03
                        cpcf4 = cpcf4 * cpcI
                    End If
                End If

            End If
            If RadioButton6.Checked = True Then
                If lstCategories.SelectedItem.Text = "Food" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Im * 16) / 100)
                        cpcm1 = Male1 * 0.06
                        cpcm1 = cpcm1 * cpcI
                        Female1 = ((chk1If * 32) / 100)
                        cpcf1 = Female1 * 0.06
                        cpcf1 = cpcf1 * cpcI
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Im * 15) / 100)
                        cpcm2 = Male2 * 0.09
                        cpcm2 = cpcm2 * cpcI
                        Female2 = ((chk2If * 24) / 100)
                        cpcf2 = Female2 * 0.09
                        cpcf2 = cpcf2 * cpcI
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Im * 3) / 100)
                        cpcm3 = Male3 * 0.05
                        cpcm3 = cpcm3 * cpcI
                        Female3 = ((chk3If * 6) / 100)
                        cpcf3 = Female3 * 0.05
                        cpcf3 = cpcf3 * cpcI
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Im * 1) / 100)
                        cpcm4 = Male4 * 0.04
                        cpcm4 = cpcm4 * cpcI
                        Female4 = ((chk4If * 3) / 100)
                        cpcf4 = Female4 * 0.04
                        cpcf4 = cpcf4 * cpcI
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Movie" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Im * 11) / 100)
                        cpcm1 = Male1 * 0.08
                        cpcm1 = cpcm1 * cpcI
                        Female1 = ((chk1If * 33) / 100)
                        cpcf1 = Female1 * 0.08
                        cpcf1 = cpcf1 * cpcI
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Im * 19) / 100)
                        cpcm2 = Male2 * 0.07
                        cpcm2 = cpcm2 * cpcI
                        Female2 = ((chk2If * 29) / 100)
                        cpcf2 = Female2 * 0.07
                        cpcf2 = cpcf2 * cpcI
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Im * 1) / 100)
                        cpcm3 = Male3 * 0.02
                        cpcm3 = cpcm3 * cpcI
                        Female3 = ((chk3If * 5) / 100)
                        cpcf3 = Female3 * 0.02
                        cpcf3 = cpcf3 * cpcI
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Im * 1) / 100)
                        cpcm4 = Male4 * 0.01
                        cpcm4 = cpcm4 * cpcI
                        Female4 = ((chk4If * 1) / 100)
                        cpcf4 = Female4 * 0.01
                        cpcf4 = cpcf4 * cpcI
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Music" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Im * 21) / 100)
                        cpcm1 = Male1 * 0.09
                        cpcm1 = cpcm1 * cpcI
                        Female1 = ((chk1If * 31) / 100)
                        cpcf1 = Female1 * 0.09
                        cpcf1 = cpcf1 * cpcI
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Im * 7) / 100)
                        cpcm2 = Male2 * 0.09
                        cpcm2 = cpcm2 * cpcI
                        Female2 = ((chk2If * 13) / 100)
                        cpcf2 = Female2 * 0.09
                        cpcf2 = cpcf2 * cpcI
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Im * 1) / 100)
                        cpcm3 = Male3 * 0.08
                        cpcm3 = cpcm3 * cpcI
                        Female3 = ((chk3If * 3) / 100)
                        cpcf3 = Female3 * 0.08
                        cpcf3 = cpcf3 * cpcI
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Im * 1) / 100)
                        cpcm4 = Male4 * 0.03
                        cpcm4 = cpcm4 * cpcI
                        Female4 = ((chk4If * 4) / 100)
                        cpcf4 = Female4 * 0.03
                        cpcf4 = cpcf4 * cpcI
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Shopping" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Im * 9) / 100)
                        cpcm1 = Male1 * 0.05
                        cpcm1 = cpcm1 * cpcI
                        Female1 = ((chk1If * 27) / 100)
                        cpcf1 = Female1 * 0.05
                        cpcf1 = cpcf1 * cpcI
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Im * 12) / 100)
                        cpcm2 = Male2 * 0.06
                        cpcm2 = cpcm2 * cpcI
                        Female2 = ((chk2If * 37) / 100)
                        cpcf2 = Female2 * 0.06
                        cpcf2 = cpcf2 * cpcI
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Im * 4) / 100)
                        cpcm3 = Male3 * 0.02
                        cpcm3 = cpcm3 * cpcI
                        Female3 = ((chk3If * 8) / 100)
                        cpcf3 = Female3 * 0.02
                        cpcf3 = cpcf3 * cpcI
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Im * 1) / 100)
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcI
                        Female4 = ((chk4If * 2) / 100)
                        cpcf4 = Female4 * 0.02
                        cpcf4 = cpcf4 * cpcI
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Sport" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Im * 12) / 100)
                        cpcm1 = Male1 * 0.07
                        cpcm1 = cpcm1 * cpcI
                        Female1 = ((chk1If * 31) / 100)
                        cpcf1 = Female1 * 0.07
                        cpcf1 = cpcf1 * cpcI
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Im * 24) / 100)
                        cpcm2 = Male2 * 0.05
                        cpcm2 = cpcm2 * cpcI
                        Female2 = ((chk2If * 29) / 100)
                        cpcf2 = Female2 * 0.05
                        cpcf2 = cpcf2 * cpcI
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Im * 1) / 100)
                        cpcm3 = Male3 * 0.05
                        cpcm3 = cpcm3 * cpcI
                        Female3 = ((chk3If * 1) / 100)
                        cpcf3 = Female3 * 0.05
                        cpcf3 = cpcf3 * cpcI
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Im * 1) / 100)
                        cpcm4 = Male4 * 0.03
                        cpcm4 = cpcm4 * cpcI
                        Female4 = ((chk4If * 1) / 100)
                        cpcf4 = Female4 * 0.03
                        cpcf4 = cpcf4 * cpcI
                        Age = Age + "65+"
                    End If
                End If

            End If
            If RadioButton1.Checked = True Then
                Price = "* The CPC is $0.29"
            End If
            If RadioButton3.Checked = True Then
                Price = "* The CPM is $0.06"
            End If
            cpmm1 = (Male1 * cpmI)
            cpmm2 = (Male2 * cpmI)
            cpmm3 = (Male3 * cpmI)
            cpmm4 = (Male4 * cpmI)
            cpmf1 = (Female1 * cpmI)
            cpmf2 = (Female2 * cpmI)
            cpmf3 = (Female3 * cpmI)
            cpmf4 = (Female4 * cpmI)
        End If
        'Saudi Arabia Statistics
        If cmbCountries.SelectedItem.Text = "Saudi Arabia" Then
            If RadioButton4.Checked = True Then
                If lstCategories.SelectedItem.Text = "Food" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Sm * 11) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.05
                        cpcm1 = cpcm1 * cpcs
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Sm * 14) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.09
                        cpcm2 = cpcm2 * cpcs
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Sm * 11) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.08
                        cpcm3 = cpcm3 * cpcs
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Sm * 3) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcs
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Movie" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Sm * 20) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.08
                        cpcm1 = cpcm1 * cpcs
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Sm * 22) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.08
                        cpcm2 = cpcm2 * cpcs
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Sm * 5) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.03
                        cpcm3 = cpcm3 * cpcs
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Sm * 4) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.01
                        cpcm4 = cpcm4 * cpcs
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Music" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Sm * 22) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.09
                        cpcm1 = cpcm1 * cpcs
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Sm * 11) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.07
                        cpcm2 = cpcm2 * cpcs
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Sm * 2) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.06
                        cpcm3 = cpcm3 * cpcs
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Sm * 1) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.03
                        cpcm4 = cpcm4 * cpcs
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Shopping" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Sm * 9) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.04
                        cpcm1 = cpcm1 * cpcs
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Sm * 13) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.07
                        cpcm2 = cpcm2 * cpcs
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Sm * 5) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.09
                        cpcm3 = cpcm3 * cpcs
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Sm * 2) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcs
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Sport" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Sm * 22) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.03
                        cpcm1 = cpcm1 * cpcs
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Sm * 28) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.05
                        cpcm2 = cpcm2 * cpcs
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Sm * 3) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.06
                        cpcm3 = cpcm3 * cpcs
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Sm * 1) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcs
                    End If
                End If

            End If
            If RadioButton5.Checked = True Then
                If lstCategories.SelectedItem.Text = "Food" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1Sf * 29) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.05
                        cpcf1 = cpcf1 * cpcs
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2Sf * 17) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.09
                        cpcf2 = cpcf2 * cpcs
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3Sf * 9) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.08
                        cpcf3 = cpcf3 * cpcs
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4Sf * 6) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.2
                        cpcf4 = cpcf4 * cpcs
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Movie" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1Sf * 13) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.08
                        cpcf1 = cpcf1 * cpcs
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2Sf * 15) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.08
                        cpcf2 = cpcf2 * cpcs
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3Sf * 14) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.03
                        cpcf3 = cpcf3 * cpcs
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4Sf * 7) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.01
                        cpcf4 = cpcf4 * cpcs
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Music" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1Sf * 27) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.09
                        cpcf1 = cpcf1 * cpcs
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2Sf * 33) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.07
                        cpcf2 = cpcf2 * cpcs
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3Sf * 3) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.06
                        cpcf3 = cpcf3 * cpcs
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4Sf * 1) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.03
                        cpcf4 = cpcf4 * cpcs
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Shopping" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1Sf * 26) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.04
                        cpcf1 = cpcf1 * cpcs
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2Sf * 32) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.07
                        cpcf2 = cpcf2 * cpcs
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3Sf * 8) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.09
                        cpcf3 = cpcf3 * cpcs
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4Sf * 5) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.02
                        cpcf4 = cpcf4 * cpcs
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Sport" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1Sf * 19) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.03
                        cpcf1 = cpcf1 * cpcs
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2Sf * 22) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.05
                        cpcf2 = cpcf2 * cpcs
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3Sf * 2) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.06
                        cpcf3 = cpcf3 * cpcs
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4Sf * 1) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.02
                        cpcf4 = cpcf4 * cpcs
                    End If
                End If

            End If
            If RadioButton6.Checked = True Then
                If lstCategories.SelectedItem.Text = "Food" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Sm * 11) / 100)
                        cpcm1 = Male1 * 0.05
                        cpcm1 = cpcm1 * cpcs
                        Female1 = ((chk1Sf * 29) / 100)
                        cpcf1 = Female1 * 0.05
                        cpcf1 = cpcf1 * cpcs
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Sm * 14) / 100)
                        cpcm2 = Male2 * 0.09
                        cpcm2 = cpcm2 * cpcs
                        Female2 = ((chk2Sf * 17) / 100)
                        cpcf2 = Female2 * 0.09
                        cpcf2 = cpcf2 * cpcs
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Sm * 11) / 100)
                        cpcm3 = Male3 * 0.08
                        cpcm3 = cpcm3 * cpcs
                        Female3 = ((chk3Sf * 9) / 100)
                        cpcf3 = Female3 * 0.08
                        cpcf3 = cpcf3 * cpcs
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Sm * 3) / 100)
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcs
                        Female4 = ((chk4Sf * 6) / 100)
                        cpcf4 = Female4 * 0.02
                        cpcf4 = cpcf4 * cpcs
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Movie" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Sm * 20) / 100)
                        cpcm1 = Male1 * 0.08
                        cpcm1 = cpcm1 * cpcs
                        Female1 = ((chk1Sf * 13) / 100)
                        cpcf1 = Female1 * 0.08
                        cpcf1 = cpcf1 * cpcs
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Sm * 22) / 100)
                        cpcm2 = Male2 * 0.08
                        cpcm2 = cpcm2 * cpcs
                        Female2 = ((chk2Sf * 15) / 100)
                        cpcf2 = Female2 * 0.08
                        cpcf2 = cpcf2 * cpcs
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Sm * 5) / 100)
                        cpcm3 = Male3 * 0.03
                        cpcm3 = cpcm3 * cpcs
                        Female3 = ((chk3Sf * 14) / 100)
                        cpcf3 = Female3 * 0.03
                        cpcf3 = cpcf3 * cpcs
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Sm * 4) / 100)
                        cpcm4 = Male4 * 0.01
                        cpcm4 = cpcm4 * cpcs
                        Female4 = ((chk4Sf * 7) / 100)
                        cpcf4 = Female4 * 0.01
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Music" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Sm * 22) / 100)
                        cpcm1 = Male1 * 0.09
                        cpcm1 = cpcm1 * cpcs
                        Female1 = ((chk1Sf * 27) / 100)
                        cpcf1 = Female1 * 0.07
                        cpcf1 = cpcf1 * cpcs
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Sm * 11) / 100)
                        cpcm2 = Male2 * 0.06
                        cpcm2 = cpcm2 * cpcs
                        Female2 = ((chk2Sf * 33) / 100)
                        cpcf2 = Female2 * 0.03
                        cpcf2 = cpcf2 * cpcs
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Sm * 2) / 100)
                        cpcm3 = Male3 * 0.06
                        cpcm3 = cpcm3 * cpcs
                        Female3 = ((chk3Sf * 3) / 100)
                        cpcf3 = Female3 * 0.06
                        cpcf3 = cpcf3 * cpcs
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Sm * 1) / 100)
                        cpcm4 = Male4 * 0.03
                        cpcm4 = cpcm4 * cpcs
                        Female4 = ((chk4Sf * 1) / 100)
                        cpcf4 = Female4 * 0.03
                        cpcf4 = cpcf4 * cpcs
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Shopping" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Sm * 9) / 100)
                        cpcm1 = Male1 * 0.04
                        cpcm1 = cpcm1 * cpcs
                        Female1 = ((chk1Sf * 26) / 100)
                        cpcf1 = Female1 * 0.04
                        cpcf1 = cpcf1 * cpcs
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Sm * 13) / 100)
                        cpcm2 = Male2 * 0.07
                        cpcm2 = cpcm2 * cpcs
                        Female2 = ((chk2Sf * 32) / 100)
                        cpcf2 = Female2 * 0.07
                        cpcf2 = cpcf2 * cpcs
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Sm * 5) / 100)
                        cpcm3 = Male3 * 0.09
                        cpcm3 = cpcm3 * cpcs
                        Female3 = ((chk3Sf * 8) / 100)
                        cpcf3 = Female3 * 0.09
                        cpcf3 = cpcf3 * cpcs
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Sm * 2) / 100)
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcs
                        Female4 = ((chk4Sf * 5) / 100)
                        cpcf4 = Female4 * 0.02
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Sport" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Sm * 22) / 100)
                        cpcm1 = Male1 * 0.03
                        cpcm1 = cpcm1 * cpcs
                        Female1 = ((chk1Sf * 19) / 100)
                        cpcf1 = Female1 * 0.03
                        cpcf1 = cpcf1 * cpcs
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Sm * 28) / 100)
                        cpcm2 = Male2 * 0.05
                        cpcm2 = cpcm2 * cpcs
                        Female2 = ((chk2Sf * 22) / 100)
                        cpcf2 = Female2 * 0.05
                        cpcf2 = cpcf2 * cpcs
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Sm * 3) / 100)
                        cpcm3 = Male3 * 0.06
                        cpcm3 = cpcm3 * cpcs
                        Female3 = ((chk3Sf * 2) / 100)
                        cpcf3 = Female3 * 0.06
                        cpcf3 = cpcf3 * cpcs
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Sm * 1) / 100)
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcs
                        Female4 = ((chk4Sf * 1) / 100)
                        cpcf4 = Female4 * 0.02
                        cpcf4 = cpcf4 * cpcs
                        Age = Age + "65+"

                    End If
                End If

            End If
            If RadioButton1.Checked = True Then
                Price = "* The CPC is $0.34"
            End If
            If RadioButton3.Checked = True Then
                Price = "* The CPM is $0.07"
            End If
            cpmm1 = (Male1 * cpms)
            cpmm2 = (Male2 * cpms)
            cpmm3 = (Male3 * cpms)
            cpmm4 = (Male4 * cpms)
            cpmf1 = (Female1 * cpms)
            cpmf2 = (Female2 * cpms)
            cpmf3 = (Female3 * cpms)
            cpmf4 = (Female4 * cpms)

        End If

        'United State Statistics 
        If cmbCountries.SelectedItem.Text = "United State" Then
            If RadioButton4.Checked = True Then
                If lstCategories.SelectedItem.Text = "Food" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Um * 17) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.06
                        cpcm1 = cpcm1 * cpcu
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Um * 17) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.09
                        cpcm2 = cpcm2 * cpcu
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Um * 10) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.04
                        cpcm3 = cpcm3 * cpcu
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Um * 5) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcu
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Movie" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Um * 34) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.09
                        cpcm1 = cpcm1 * cpcu
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Um * 26) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.07
                        cpcm2 = cpcm2 * cpcu
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Um * 7) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.05
                        cpcm3 = cpcm3 * cpcu
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Um * 1) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.04
                        cpcm4 = cpcm4 * cpcu
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Music" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Um * 17) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.08
                        cpcm1 = cpcm1 * cpcu
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Um * 13) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.09
                        cpcm2 = cpcm2 * cpcu
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Um * 22) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.04
                        cpcm3 = cpcm3 * cpcu
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Um * 5) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.03
                        cpcm4 = cpcm4 * cpcu
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Shopping" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Um * 5) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.07
                        cpcm1 = cpcm1 * cpcu
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Um * 13) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.06
                        cpcm2 = cpcm2 * cpcu
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Um * 17) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.03
                        cpcm3 = cpcm3 * cpcu
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Um * 4) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcu
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Sport" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Um * 16) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.06
                        cpcm1 = cpcm1 * cpcu
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Um * 23) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.04
                        cpcm2 = cpcm2 * cpcu
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Um * 15) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.02
                        cpcm3 = cpcm3 * cpcu
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Um * 2) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.01
                        cpcm4 = cpcm4 * cpcu
                    End If
                End If

            End If
            If RadioButton5.Checked = True Then
                If lstCategories.SelectedItem.Text = "Food" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1Uf * 22) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.06
                        cpcf1 = cpcf1 * cpcu
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2Uf * 13) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.09
                        cpcf2 = cpcf2 * cpcu
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3Uf * 8) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.04
                        cpcf3 = cpcf3 * cpcu
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4Uf * 8) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.02
                        cpcf4 = cpcf4 * cpcu
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Movie" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1Uf * 11) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.09
                        cpcf1 = cpcf1 * cpcu
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2Uf * 17) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.07
                        cpcf2 = cpcf2 * cpcu
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3Uf * 3) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.05
                        cpcf3 = cpcf3 * cpcu
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4Uf * 1) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.04
                        cpcf4 = cpcf4 * cpcu
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Music" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1Uf * 15) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.08
                        cpcf1 = cpcf1 * cpcu
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2Uf * 12) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.09
                        cpcf2 = cpcf2 * cpcu
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3Uf * 14) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.04
                        cpcf3 = cpcf3 * cpcu
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4Uf * 2) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.03
                        cpcf4 = cpcf4 * cpcu
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Shopping" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1Uf * 16) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.07
                        cpcf1 = cpcf1 * cpcu
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2Uf * 21) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.06
                        cpcf2 = cpcf2 * cpcu
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3Uf * 19) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.03
                        cpcf3 = cpcf3 * cpcu
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4Uf * 5) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.02
                        cpcf4 = cpcf4 * cpcu
                    End If
                    If lstCategories.SelectedItem.Text = "Sport" Then
                        If chk1.Checked = True Then
                            Female1 = ((chk1Uf * 13) / 100)
                            Age = "13-24, "
                            cpcf1 = Female1 * 0.06
                            cpcf1 = cpcf1 * cpcu
                        End If
                        If chk2.Checked = True Then
                            Female2 = ((chk2Uf * 15) / 100)
                            Age = Age + "25-44, "
                            cpcf2 = Female2 * 0.04
                            cpcf2 = cpcf2 * cpcu
                        End If
                        If chk3.Checked = True Then
                            Female3 = ((chk3Uf * 12) / 100)
                            Age = Age + "45-64, "
                            cpcf3 = Female3 * 0.02
                            cpcf3 = cpcf3 * cpcu
                        End If
                        If chk4.Checked = True Then
                            Female4 = ((chk4Uf * 4) / 100)
                            Age = Age + "65+"
                            cpcf4 = Female4 * 0.01
                            cpcf4 = cpcf4 * cpcu
                        End If
                    End If

                End If
            End If
            If RadioButton6.Checked = True Then
                If lstCategories.SelectedItem.Text = "Food" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Um * 17) / 100)
                        cpcm1 = Male1 * 0.06
                        cpcm1 = cpcm1 * cpcu
                        Female1 = ((chk1Uf * 22) / 100)
                        cpcf1 = Female1 * 0.06
                        cpcf1 = cpcf1 * cpcu
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Um * 17) / 100)
                        cpcm2 = Male2 * 0.09
                        cpcm2 = cpcm2 * cpcu
                        Female2 = ((chk2Uf * 13) / 100)
                        cpcf2 = Female2 * 0.09
                        cpcf2 = cpcf2 * cpcu
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Um * 10) / 100)
                        cpcm3 = Male3 * 0.04
                        cpcm3 = cpcm3 * cpcu
                        Female3 = ((chk3Uf * 8) / 100)
                        cpcf3 = Female3 * 0.04
                        cpcf3 = cpcf3 * cpcu
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Um * 5) / 100)
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcu
                        Female4 = ((chk4Uf * 8) / 100)
                        cpcf4 = Female4 * 0.02
                        cpcf4 = cpcf4 * cpcu
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Movie" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Um * 34) / 100)
                        cpcm1 = Male1 * 0.09
                        cpcm1 = cpcm1 * cpcu
                        Female1 = ((chk1Uf * 11) / 100)
                        cpcf1 = Female1 * 0.09
                        cpcf1 = cpcf1 * cpcu
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Um * 26) / 100)
                        cpcm2 = Male2 * 0.07
                        cpcm2 = cpcm2 * cpcu
                        Female2 = ((chk2Uf * 17) / 100)
                        cpcf2 = Female2 * 0.07
                        cpcf2 = cpcf2 * cpcu
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Um * 7) / 100)
                        cpcm3 = Male3 * 0.05
                        cpcm3 = cpcm3 * cpcu
                        Female3 = ((chk3Uf * 3) / 100)
                        cpcf3 = Female3 * 0.05
                        cpcf3 = cpcf3 * cpcu
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Um * 1) / 100)
                        cpcm4 = Male4 * 0.04
                        cpcm4 = cpcm4 * cpcu
                        Female4 = ((chk4Uf * 1) / 100)
                        cpcf4 = Female4 * 0.04
                        cpcf4 = cpcf4 * cpcu
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Music" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Um * 17) / 100)
                        cpcm1 = Male1 * 0.08
                        cpcm1 = cpcm1 * cpcu
                        Female1 = ((chk1Uf * 15) / 100)
                        cpcf1 = Female1 * 0.08
                        cpcf1 = cpcf1 * cpcu
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Um * 13) / 100)
                        cpcm2 = Male2 * 0.09
                        cpcm2 = cpcm2 * cpcu
                        Female2 = ((chk2Uf * 12) / 100)
                        cpcf2 = Female2 * 0.09
                        cpcf2 = cpcf2 * cpcu
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Um * 22) / 100)
                        cpcm3 = Male3 * 0.04
                        cpcm3 = cpcm3 * cpcu
                        Female3 = ((chk3Uf * 14) / 100)
                        cpcf3 = Female3 * 0.04
                        cpcf3 = cpcf3 * cpcu
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Um * 5) / 100)
                        cpcm4 = Male4 * 0.03
                        cpcm4 = cpcm4 * cpcu
                        Female4 = ((chk4Uf * 2) / 100)
                        cpcf4 = Female4 * 0.03
                        cpcf4 = cpcf4 * cpcu
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Shopping" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Um * 5) / 100)
                        cpcm1 = Male1 * 0.07
                        cpcm1 = cpcm1 * cpcu
                        Female1 = ((chk1Uf * 16) / 100)
                        cpcf1 = Female1 * 0.07
                        cpcf1 = cpcf1 * cpcu
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Um * 13) / 100)
                        cpcm2 = Male2 * 0.06
                        cpcm2 = cpcm2 * cpcu
                        Female2 = ((chk2Uf * 21) / 100)
                        cpcf2 = Female2 * 0.06
                        cpcf2 = cpcf2 * cpcu
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Um * 17) / 100)
                        cpcm3 = Male3 * 0.03
                        cpcm3 = cpcm3 * cpcu
                        Female3 = ((chk3Uf * 19) / 100)
                        cpcf3 = Female3 * 0.03
                        cpcf3 = cpcf3 * cpcu
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Um * 4) / 100)
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcu
                        Female4 = ((chk4Uf * 5) / 100)
                        cpcf4 = Female4 * 0.02
                        cpcf4 = cpcf4 * cpcu
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Sport" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Um * 16) / 100)
                        cpcm1 = Male1 * 0.06
                        cpcm1 = cpcm1 * cpcu
                        Female1 = ((chk1Uf * 13) / 100)
                        cpcf1 = Female1 * 0.06
                        cpcf1 = cpcf1 * cpcu
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Um * 23) / 100)
                        cpcm2 = Male2 * 0.04
                        cpcm2 = cpcm2 * cpcu
                        Female2 = ((chk2Uf * 15) / 100)
                        cpcf2 = Female2 * 0.04
                        cpcf2 = cpcf2 * cpcu
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Um * 15) / 100)
                        cpcm3 = Male3 * 0.02
                        cpcm3 = cpcm3 * cpcu
                        Female3 = ((chk3Uf * 12) / 100)
                        cpcf3 = Female3 * 0.02
                        cpcf3 = cpcf3 * cpcu
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Um * 2) / 100)
                        cpcm4 = Male4 * 0.01
                        cpcm4 = cpcm4 * cpcu
                        Female4 = ((chk4Uf * 4) / 100)
                        cpcf4 = Female4 * 0.01
                        cpcf4 = cpcf4 * cpcu
                        Age = Age + "65+"
                    End If
                End If

            End If
            If RadioButton1.Checked = True Then
                Price = "* The CPC is $1.12"
            End If
            If RadioButton3.Checked = True Then
                Price = "* The CPM is $0.24"
            End If
            cpmm1 = (Male1 * cpmu)
            cpmm2 = (Male2 * cpmu)
            cpmm3 = (Male3 * cpmu)
            cpmm4 = (Male4 * cpmu)
            cpmf1 = (Female1 * cpmu)
            cpmf2 = (Female2 * cpmu)
            cpmf3 = (Female3 * cpmu)
            cpmf4 = (Female4 * cpmu)
        End If
        'Audiance
        Male = Male1 + Male2 + Male3 + Male4
        Female = Female1 + Female2 + Female3 + Female4
        Audiance = Male + Female

        'Compare
        If Male1 > Female1 Then
            Users1 = Male1
            Usersg1 = "Male between age of 13 and 24 "
            If cpcm1 < cpmm1 Then
                c1 = cpcm1
                Cost1 = "Go with Cost Per Click (CPC) and pay only $"
            Else
                c1 = cpmm1
                Cost1 = "Go with Cost Per Thousand Impression (CPM) and pay only $"
            End If
        Else
            Users1 = Female1
            Usersg1 = "Female between age of 13 and 24 "
            If cpcf1 < cpmf1 Then
                c1 = cpcf1
                Cost1 = "Go with Cost Per Click (CPC) and pay only $"
            Else
                c1 = cpmf1
                Cost1 = "Go with Cost Per Thousand Impression (CPM) and pay only $"
            End If
        End If

        If Male2 > Female2 Then
            Users2 = Male2
            Usersg2 = "Male between age of 25 and 44 "
            If cpcm2 < cpmm2 Then
                c2 = cpcm2
                Cost2 = "Go with Cost Per Click (CPC) and pay only $"
            Else
                c2 = cpmm2
                Cost2 = "Go with Cost Per Thousand Impression (CPM) and pay only $"
            End If
        Else
            Users2 = Female2
            Usersg2 = "Female between age of 25 and 44 "
            If cpcf2 < cpmf2 Then
                c2 = cpcf2
                Cost2 = "Go with Cost Per Click (CPC) and pay only $"
            Else
                c2 = cpmf2
                Cost2 = "Go with Cost Per Thousand Impression (CPM) and pay only $"
            End If
        End If

        If Male3 > Female3 Then
            Users3 = Male3
            Usersg3 = "Male between age of 45 and 64 "
            If cpcm3 < cpmm3 Then
                c3 = cpcm3
                Cost3 = "Go with Cost Per Click (CPC) and pay only $"
            Else
                c3 = cpmm3
                Cost3 = "Go with Cost Per Thousand Impression (CPM) and pay only $"
            End If
        Else
            Users3 = Female3
            Usersg3 = "Female between age of 45 and 64 "
            If cpcf3 < cpmf3 Then
                c3 = cpcf3
                Cost3 = "Go with Cost Per Click (CPC) and pay only $"
            Else
                c3 = cpmf3
                Cost3 = "Go with Cost Per Thousand Impression (CPM) and pay only $"
            End If
        End If

        If Male4 > Female4 Then
            Users4 = Male4
            Usersg4 = "Male of age 65+ "
            If cpcm4 < cpmm4 Then
                c4 = cpcm4
                Cost4 = "Go with Cost Per Click (CPC) and pay only $"
            Else
                c4 = cpmm4
                Cost4 = "Go with Cost Per Thousand Impression (CPM) and pay only $"
            End If
        Else
            Users4 = Female4
            Usersg4 = "Female of age 65+ "
            If cpcf4 < cpmf4 Then
                c4 = cpcf4
                Cost4 = "Go with Cost Per Click (CPC) and pay only $"
            Else
                c4 = cpmf4
                Cost4 = "Go with Cost Per Thousand Impression (CPM) and pay only $"
            End If
        End If

        'Min COST
        'If c1 > 0 And c2 > 0 And c1 < c2 Then
        '    If Opcost = 0 Then
        '        Opcost = c1
        '        opd = Cost1
        '        Users = Users1
        '        Usersg = Usersg1
        '    Else
        '        If c1 < Opcost Then
        '            Opcost = c1
        '            opd = Cost1
        '            Users = Users1
        '            Usersg = Usersg1
        '        End If
        '    End If
        'Else
        '    If c1 > 0 And c2 > 0 And c2 < c1 Then
        '        If Opcost = 0 Then
        '            Opcost = c2
        '            opd = Cost2
        '            Users = Users2
        '            Usersg = Usersg2
        '        Else
        '            If c2 < Opcost Then
        '                Opcost = c2
        '                opd = Cost2
        '                Users = Users2
        '                Usersg = Usersg2
        '            End If
        '        End If
        '    End If
        'End If

        'If c1 > 0 And c3 > 0 And c1 < c3 Then
        '    If Opcost = 0 Then
        '        Opcost = c1
        '        opd = Cost1
        '        Users = Users1
        '        Usersg = Usersg1
        '    Else
        '        If c1 < Opcost Then
        '            Opcost = c1
        '            opd = Cost1
        '            Users = Users1
        '            Usersg = Usersg1
        '        End If
        '    End If
        'Else
        '    If c1 > 0 And c3 > 0 And c3 < c1 Then
        '        If Opcost = 0 Then
        '            Opcost = c3
        '            opd = Cost3
        '            Users = Users3
        '            Usersg = Usersg3
        '        Else
        '            If c3 < Opcost Then
        '                Opcost = c3
        '                opd = Cost3
        '                Users = Users3
        '                Usersg = Usersg3
        '            End If
        '        End If
        '    End If
        'End If

        'If c1 > 0 And c4 > 0 And c1 < c4 Then
        '    If Opcost = 0 Then
        '        Opcost = c1
        '        opd = Cost1
        '        Users = Users1
        '        Usersg = Usersg1
        '    Else
        '        If c1 < Opcost Then
        '            Opcost = c1
        '            opd = Cost1
        '            Users = Users1
        '            Usersg = Usersg1
        '        End If
        '    End If
        'Else
        '    If c1 > 0 And c4 > 0 And c4 < c1 Then
        '        If Opcost = 0 Then
        '            Opcost = c4
        '            opd = Cost4
        '            Users = Users4
        '            Usersg = Usersg4
        '        Else
        '            If c4 < Opcost Then
        '                Opcost = c4
        '                opd = Cost4
        '                Users = Users4
        '                Usersg = Usersg4
        '            End If
        '        End If
        '    End If
        'End If

        'If c2 > 0 And c3 > 0 And c2 < c3 Then
        '    If Opcost = 0 Then
        '        Opcost = c2
        '        opd = Cost2
        '        Users = Users2
        '        Usersg = Usersg2
        '    Else
        '        If c2 < Opcost Then
        '            Opcost = c2
        '            opd = Cost2
        '            Users = Users2
        '            Usersg = Usersg2
        '        End If
        '    End If
        'Else
        '    If c2 > 0 And c3 > 0 And c3 < c2 Then
        '        If Opcost = 0 Then
        '            Opcost = c3
        '            opd = Cost3
        '            Users = Users3
        '            Usersg = Usersg3
        '        Else
        '            If c3 < Opcost Then
        '                Opcost = c3
        '                opd = Cost3
        '                Users = Users3
        '                Usersg = Usersg3
        '            End If
        '        End If
        '    End If
        'End If

        'If c2 > 0 And c4 > 0 And c2 < c4 Then
        '    If Opcost = 0 Then
        '        Opcost = c2
        '        opd = Cost2
        '        Users = Users2
        '        Usersg = Usersg2
        '    Else
        '        If c2 < Opcost Then
        '            Opcost = c2
        '            opd = Cost2
        '            Users = Users2
        '            Usersg = Usersg2
        '        End If
        '    End If
        'Else
        '    If c2 > 0 And c4 > 0 And c4 < c2 Then
        '        If Opcost = 0 Then
        '            Opcost = c4
        '            opd = Cost4
        '            Users = Users4
        '            Usersg = Usersg4
        '        Else
        '            If c4 < Opcost Then
        '                Opcost = c4
        '                opd = Cost4
        '                Users = Users4
        '                Usersg = Usersg4
        '            End If
        '        End If
        '    End If
        'End If

        'If c3 > 0 And c4 > 0 And c3 < c4 Then
        '    If Opcost = 0 Then
        '        Opcost = c3
        '        opd = Cost3
        '        Users = Users3
        '        Usersg = Usersg3
        '    Else
        '        If c3 < Opcost Then
        '            Opcost = c3
        '            opd = Cost3
        '            Users = Users3
        '            Usersg = Usersg3
        '        End If
        '    End If
        'Else
        '    If c3 > 0 And c4 > 0 And c4 < c3 Then
        '        If Opcost = 0 Then
        '            Opcost = c4
        '            opd = Cost4
        '        Else
        '            If c4 < Opcost Then
        '                Opcost = c4
        '                opd = Cost4
        '            End If
        '        End If
        '    End If
        'End If

        Label3.Text = "Audiance" & "<br />" & "Estimated Reach" &
            "<br />" & Male & " male" & "<br />" &
            "and " & Female & " Female" & "<br />" &
            "in total of " & Audiance & " people" & "<br />" &
            "* Who live in " & cmbCountries.SelectedItem.Text & "<br />" &
            "* Between the age of " & Age & "<br />" &
            "* Who like " & lstCategories.SelectedItem.Text & "<br />" &
            Price & "<br />"
           

        If fuImage.PostedFile IsNot Nothing And Not String.IsNullOrEmpty(fuImage.PostedFile.FileName) And fuImage.PostedFile.InputStream IsNot Nothing Then

        End If


    End Sub

#End Region

#Region "User Methods"

    ''' <summary>
    ''' show message box
    ''' </summary>
    ''' <param name="parentForm">الفورم الرئيسيه</param>
    ''' <param name="sMsg">نص الرساله</param>
    ''' <remarks></remarks>
    Public Sub UserMsgBox(ByVal parentForm As Object, ByVal sMsg As String)

        Dim sb As New StringBuilder()
        Dim oFormObject As System.Web.UI.Control = Nothing
        Try
            sMsg = sMsg.Replace("'", "\'")
            sMsg = sMsg.Replace(Chr(34), "\" & Chr(34))
            sMsg = sMsg.Replace(vbCrLf, "\n")
            sMsg = "<script language='javascript'>alert('" & sMsg & "');</script>"
            sb = New StringBuilder()
            sb.Append(sMsg)
            For Each oFormObject In parentForm.Controls
                If TypeOf oFormObject Is HtmlForm Then
                    Exit For
                End If
            Next
            oFormObject.Controls.AddAt(oFormObject.Controls.Count, New LiteralControl(sb.ToString()))
        Catch ex As Exception

        End Try

    End Sub

#End Region


    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Canada Statistics
        If cmbCountries.SelectedItem.Text = "Canada" Then
            If RadioButton4.Checked = True Then
                If lstCategories.SelectedItem.Text = "Food" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1cm * 10) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.08
                        cpcm1 = cpcm1 * cpcc
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2cm * 7) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.05
                        cpcm2 = cpcm2 * cpcc
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3cm * 15) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.03
                        cpcm3 = cpcm3 * cpcc
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4cm * 9) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcc
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Movie" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1cm * 20) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.06
                        cpcm1 = cpcm1 * cpcc
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2cm * 20) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.08
                        cpcm2 = cpcm2 * cpcc
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3cm * 9) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.04
                        cpcm3 = cpcm3 * cpcc
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4cm * 6) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.03
                        cpcm4 = cpcm4 * cpcc
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Music" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1cm * 19) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.09
                        cpcm1 = cpcm1 * cpcc
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2cm * 18) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.06
                        cpcm2 = cpcm2 * cpcc
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3cm * 7) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.03
                        cpcm3 = cpcm3 * cpcc
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4cm * 1) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.01
                        cpcm4 = cpcm4 * cpcc
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Shopping" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1cm * 16) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.05
                        cpcm1 = cpcm1 * cpcc
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2cm * 18) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.07
                        cpcm2 = cpcm2 * cpcc
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3cm * 4) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.04
                        cpcm3 = cpcm3 * cpcc
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4cm * 1) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcc
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Sport" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1cm * 14) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.07
                        cpcm1 = cpcm1 * cpcc
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2cm * 23) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.05
                        cpcm2 = cpcm2 * cpcc
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3cm * 13) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.05
                        cpcm3 = cpcm3 * cpcc
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4cm * 9) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.03
                        cpcm4 = cpcm4 * cpcc
                    End If
                End If
            End If
            If RadioButton5.Checked = True Then
                If lstCategories.SelectedItem.Text = "Food" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1cf * 9) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.08
                        cpcf1 = cpcf1 * cpcc
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2cf * 30) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.05
                        cpcf2 = cpcf2 * cpcc
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3cf * 9) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.03
                        cpcf3 = cpcf3 * cpcc
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4cf * 12) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.02
                        cpcf4 = cpcf4 * cpcc
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Movie" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1cf * 15) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.06
                        cpcf1 = cpcf1 * cpcc
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2cf * 25) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.08
                        cpcf2 = cpcf2 * cpcc
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3cf * 11) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.04
                        cpcf3 = cpcf3 * cpcc
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4cf * 4) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.03
                        cpcf4 = cpcf4 * cpcc

                    End If
                End If
                If lstCategories.SelectedItem.Text = "Music" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1cf * 23) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.09
                        cpcf1 = cpcf1 * cpcc
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2cf * 22) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.06
                        cpcf2 = cpcf2 * cpcc
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3cf * 8) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.03
                        cpcf3 = cpcf3 * cpcc
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4cf * 2) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.01
                        cpcf4 = cpcf4 * cpcc
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Shopping" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1cf * 19) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.05
                        cpcf1 = cpcf1 * cpcc
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2cf * 31) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.07
                        cpcf2 = cpcf2 * cpcc
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3cf * 10) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.04
                        cpcf3 = cpcf3 * cpcc
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4cf * 1) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.02
                        cpcf4 = cpcf4 * cpcc
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Sport" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1cf * 12) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.07
                        cpcf1 = cpcf1 * cpcc
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2cf * 15) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.05
                        cpcf2 = cpcf2 * cpcc
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3cf * 11) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.05
                        cpcf3 = cpcf3 * cpcc
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4cf * 13) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.03
                        cpcf4 = cpcf4 * cpcc
                    End If
                End If

            End If
            If RadioButton6.Checked = True Then
                If lstCategories.SelectedItem.Text = "Food" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1cm * 10) / 100)
                        cpcm1 = Male1 * 0.08
                        cpcm1 = cpcm1 * cpcc
                        Female1 = ((chk1cf * 9) / 100)
                        cpcf1 = Female1 * 0.08
                        cpcf1 = cpcf1 * cpcc
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2cm * 7) / 100)
                        cpcm2 = Male2 * 0.05
                        cpcm2 = cpcm2 * cpcc
                        Female2 = ((chk2cf * 30) / 100)
                        cpcf2 = Female2 * 0.05
                        cpcf2 = cpcf2 * cpcc
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3cm * 15) / 100)
                        cpcm3 = Male3 * 0.03
                        cpcm3 = cpcm3 * cpcc
                        Female3 = ((chk3cf * 9) / 100)
                        cpcf3 = Female3 * 0.03
                        cpcf3 = cpcf3 * cpcc
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4cm * 9) / 100)
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcc
                        Female4 = ((chk4cf * 12) / 100)
                        cpcf4 = Female4 * 0.02
                        cpcf4 = cpcf4 * cpcc
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Movie" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1cm * 20) / 100)
                        cpcm1 = Male1 * 0.06
                        cpcm1 = cpcm1 * cpcc
                        Female1 = ((chk1cf * 15) / 100)
                        cpcf1 = Female1 * 0.06
                        cpcf1 = cpcf1 * cpcc
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2cm * 20) / 100)
                        cpcm2 = Male2 * 0.08
                        cpcm2 = cpcm2 * cpcc
                        Female2 = ((chk2cf * 25) / 100)
                        cpcf2 = Female2 * 0.08
                        cpcf2 = cpcf2 * cpcc
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3cm * 9) / 100)
                        cpcm3 = Male3 * 0.04
                        cpcm3 = cpcm3 * cpcc
                        Female3 = ((chk3cf * 11) / 100)
                        cpcf3 = Female3 * 0.04
                        cpcf3 = cpcf3 * cpcc
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4cm * 6) / 100)
                        cpcm4 = Male4 * 0.03
                        cpcm4 = cpcm4 * cpcc
                        Female4 = ((chk4cf * 4) / 100)
                        cpcf4 = Female4 * 0.03
                        cpcf4 = cpcf4 * cpcc
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Music" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1cm * 19) / 100)
                        cpcm1 = Male1 * 0.09
                        cpcm1 = cpcm1 * cpcc
                        Female1 = ((chk1cf * 23) / 100)
                        cpcf1 = Female1 * 0.09
                        cpcf1 = cpcf1 * cpcc
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2cm * 18) / 100)
                        cpcm2 = Male2 * 0.06
                        cpcm2 = cpcm2 * cpcc
                        Female2 = ((chk2cf * 22) / 100)
                        cpcf2 = Female2 * 0.06
                        cpcf2 = cpcf2 * cpcc
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3cm * 7) / 100)
                        cpcm3 = Male3 * 0.03
                        cpcm3 = cpcm3 * cpcc
                        Female3 = ((chk3cf * 8) / 100)
                        cpcf3 = Female3 * 0.03
                        cpcf3 = cpcf3 * cpcc
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4cm * 1) / 100)
                        cpcm4 = Male4 * 0.01
                        cpcm4 = cpcm4 * cpcc
                        Female4 = ((chk4cf * 2) / 100)
                        cpcf4 = Female4 * 0.01
                        cpcf4 = cpcf4 * cpcc
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Shopping" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1cm * 16) / 100)
                        cpcm1 = Male1 * 0.05
                        cpcm1 = cpcm1 * cpcc
                        Female1 = ((chk1cf * 19) / 100)
                        cpcf1 = Female1 * 0.05
                        cpcf1 = cpcf1 * cpcc
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2cm * 18) / 100)
                        cpcm2 = Male2 * 0.07
                        cpcm2 = cpcm2 * cpcc
                        Female2 = ((chk2cf * 31) / 100)
                        cpcf2 = Female2 * 0.07
                        cpcf2 = cpcf2 * cpcc
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3cm * 4) / 100)
                        cpcm3 = Male3 * 0.04
                        cpcm3 = cpcm3 * cpcc
                        Female3 = ((chk3cf * 10) / 100)
                        cpcf3 = Female3 * 0.04
                        cpcf3 = cpcf3 * cpcc
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4cm * 1) / 100)
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcc
                        Female4 = ((chk4cf * 1) / 100)
                        cpcf4 = Female4 * 0.02
                        cpcf4 = cpcf4 * cpcc
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Sport" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1cm * 14) / 100)
                        cpcm1 = Male1 * 0.07
                        cpcm1 = cpcm1 * cpcc
                        Female1 = ((chk1cf * 12) / 100)
                        cpcf1 = Female1 * 0.07
                        cpcf1 = cpcf1 * cpcc
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2cm * 23) / 100)
                        cpcm2 = Male2 * 0.05
                        cpcm2 = cpcm2 * cpcc
                        Female2 = ((chk2cf * 15) / 100)
                        cpcf2 = Female2 * 0.05
                        cpcf2 = cpcf2 * cpcc
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3cm * 13) / 100)
                        cpcm3 = Male3 * 0.05
                        cpcm3 = cpcm3 * cpcc
                        Female3 = ((chk3cf * 11) / 100)
                        cpcf3 = Female3 * 0.05
                        cpcf3 = cpcf3 * cpcc
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4cm * 9) / 100)
                        cpcm4 = Male4 * 0.03
                        cpcm4 = cpcm4 * cpcc
                        Female4 = ((chk4cf * 13) / 100)
                        cpcf4 = Female4 * 0.03
                        cpcf4 = cpcf4 * cpcc
                        Age = Age + "65+"
                    End If
                End If

            End If
            If RadioButton1.Checked = True Then
                Price = "* The CPC is $0.67"
            End If
            If RadioButton3.Checked = True Then
                Price = "* The CPM is $0.13"
            End If
            cpmm1 = (Male1 * cpmc)
            cpmm2 = (Male2 * cpmc)
            cpmm3 = (Male3 * cpmc)
            cpmm4 = (Male4 * cpmc)
            cpmf1 = (Female1 * cpmc)
            cpmf2 = (Female2 * cpmc)
            cpmf3 = (Female3 * cpmc)
            cpmf4 = (Female4 * cpmc)
        End If
        'India Statistics
        If cmbCountries.SelectedItem.Text = "India" Then
            If RadioButton4.Checked = True Then
                If lstCategories.SelectedItem.Text = "Food" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Im * 16) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.06
                        cpcm1 = cpcm1 * cpcI
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Im * 15) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.09
                        cpcm2 = cpcm2 * cpcI
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Im * 3) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.05
                        cpcm3 = cpcm3 * cpcI
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Im * 1) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.04
                        cpcm4 = cpcm4 * cpcI
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Movie" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Im * 11) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.08
                        cpcm1 = cpcm1 * cpcI
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Im * 19) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.07
                        cpcm2 = cpcm2 * cpcI
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Im * 1) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.02
                        cpcm3 = cpcm3 * cpcI
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Im * 1) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.01
                        cpcm4 = cpcm4 * cpcI
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Music" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Im * 21) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.09
                        cpcm1 = cpcm1 * cpcI
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Im * 7) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.09
                        cpcm2 = cpcm2 * cpcI
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Im * 1) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.08
                        cpcm3 = cpcm3 * cpcI
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Im * 1) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.03
                        cpcm4 = cpcm4 * cpcI
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Shopping" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Im * 9) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.05
                        cpcm1 = cpcm1 * cpcI
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Im * 12) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.06
                        cpcm2 = cpcm2 * cpcI
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Im * 4) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.02
                        cpcm3 = cpcm3 * cpcI
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Im * 1) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcI
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Sport" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Im * 12) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.07
                        cpcm1 = cpcm1 * cpcI
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Im * 24) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.05
                        cpcm2 = cpcm2 * cpcI
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Im * 1) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.05
                        cpcm3 = cpcm3 * cpcI
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Im * 1) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.03
                        cpcm4 = cpcm4 * cpcI
                    End If
                End If

            End If
            If RadioButton5.Checked = True Then
                If lstCategories.SelectedItem.Text = "Food" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1If * 32) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.06
                        cpcf1 = cpcf1 * cpcI
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2If * 24) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.09
                        cpcf2 = cpcf2 * cpcI
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3If * 6) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.05
                        cpcf3 = cpcf3 * cpcI
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4If * 3) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.04
                        cpcf4 = cpcf4 * cpcI
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Movie" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1If * 33) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.08
                        cpcf1 = cpcf1 * cpcI
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2If * 29) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.07
                        cpcf2 = cpcf2 * cpcI
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3If * 5) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.02
                        cpcf3 = cpcf3 * cpcI
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4If * 1) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.01
                        cpcf4 = cpcf4 * cpcI
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Music" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1If * 31) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.09
                        cpcf1 = cpcf1 * cpcI
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2If * 13) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.09
                        cpcf2 = cpcf2 * cpcI
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3If * 3) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.08
                        cpcf3 = cpcf3 * cpcI
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4If * 4) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.03
                        cpcf4 = cpcf4 * cpcI
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Shopping" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1If * 27) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.05
                        cpcf1 = cpcf1 * cpcI
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2If * 37) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.06
                        cpcf2 = cpcf2 * cpcI
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3If * 8) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.02
                        cpcf3 = cpcf3 * cpcI
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4If * 2) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.02
                        cpcf4 = cpcf4 * cpcI
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Sport" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1If * 31) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.07
                        cpcf1 = cpcf1 * cpcI
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2If * 29) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.05
                        cpcf2 = cpcf2 * cpcI
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3If * 1) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.05
                        cpcf3 = cpcf3 * cpcI
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4If * 1) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.03
                        cpcf4 = cpcf4 * cpcI
                    End If
                End If

            End If
            If RadioButton6.Checked = True Then
                If lstCategories.SelectedItem.Text = "Food" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Im * 16) / 100)
                        cpcm1 = Male1 * 0.06
                        cpcm1 = cpcm1 * cpcI
                        Female1 = ((chk1If * 32) / 100)
                        cpcf1 = Female1 * 0.06
                        cpcf1 = cpcf1 * cpcI
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Im * 15) / 100)
                        cpcm2 = Male2 * 0.09
                        cpcm2 = cpcm2 * cpcI
                        Female2 = ((chk2If * 24) / 100)
                        cpcf2 = Female2 * 0.09
                        cpcf2 = cpcf2 * cpcI
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Im * 3) / 100)
                        cpcm3 = Male3 * 0.05
                        cpcm3 = cpcm3 * cpcI
                        Female3 = ((chk3If * 6) / 100)
                        cpcf3 = Female3 * 0.05
                        cpcf3 = cpcf3 * cpcI
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Im * 1) / 100)
                        cpcm4 = Male4 * 0.04
                        cpcm4 = cpcm4 * cpcI
                        Female4 = ((chk4If * 3) / 100)
                        cpcf4 = Female4 * 0.04
                        cpcf4 = cpcf4 * cpcI
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Movie" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Im * 11) / 100)
                        cpcm1 = Male1 * 0.08
                        cpcm1 = cpcm1 * cpcI
                        Female1 = ((chk1If * 33) / 100)
                        cpcf1 = Female1 * 0.08
                        cpcf1 = cpcf1 * cpcI
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Im * 19) / 100)
                        cpcm2 = Male2 * 0.07
                        cpcm2 = cpcm2 * cpcI
                        Female2 = ((chk2If * 29) / 100)
                        cpcf2 = Female2 * 0.07
                        cpcf2 = cpcf2 * cpcI
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Im * 1) / 100)
                        cpcm3 = Male3 * 0.02
                        cpcm3 = cpcm3 * cpcI
                        Female3 = ((chk3If * 5) / 100)
                        cpcf3 = Female3 * 0.02
                        cpcf3 = cpcf3 * cpcI
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Im * 1) / 100)
                        cpcm4 = Male4 * 0.01
                        cpcm4 = cpcm4 * cpcI
                        Female4 = ((chk4If * 1) / 100)
                        cpcf4 = Female4 * 0.01
                        cpcf4 = cpcf4 * cpcI
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Music" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Im * 21) / 100)
                        cpcm1 = Male1 * 0.09
                        cpcm1 = cpcm1 * cpcI
                        Female1 = ((chk1If * 31) / 100)
                        cpcf1 = Female1 * 0.09
                        cpcf1 = cpcf1 * cpcI
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Im * 7) / 100)
                        cpcm2 = Male2 * 0.09
                        cpcm2 = cpcm2 * cpcI
                        Female2 = ((chk2If * 13) / 100)
                        cpcf2 = Female2 * 0.09
                        cpcf2 = cpcf2 * cpcI
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Im * 1) / 100)
                        cpcm3 = Male3 * 0.08
                        cpcm3 = cpcm3 * cpcI
                        Female3 = ((chk3If * 3) / 100)
                        cpcf3 = Female3 * 0.08
                        cpcf3 = cpcf3 * cpcI
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Im * 1) / 100)
                        cpcm4 = Male4 * 0.03
                        cpcm4 = cpcm4 * cpcI
                        Female4 = ((chk4If * 4) / 100)
                        cpcf4 = Female4 * 0.03
                        cpcf4 = cpcf4 * cpcI
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Shopping" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Im * 9) / 100)
                        cpcm1 = Male1 * 0.05
                        cpcm1 = cpcm1 * cpcI
                        Female1 = ((chk1If * 27) / 100)
                        cpcf1 = Female1 * 0.05
                        cpcf1 = cpcf1 * cpcI
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Im * 12) / 100)
                        cpcm2 = Male2 * 0.06
                        cpcm2 = cpcm2 * cpcI
                        Female2 = ((chk2If * 37) / 100)
                        cpcf2 = Female2 * 0.06
                        cpcf2 = cpcf2 * cpcI
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Im * 4) / 100)
                        cpcm3 = Male3 * 0.02
                        cpcm3 = cpcm3 * cpcI
                        Female3 = ((chk3If * 8) / 100)
                        cpcf3 = Female3 * 0.02
                        cpcf3 = cpcf3 * cpcI
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Im * 1) / 100)
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcI
                        Female4 = ((chk4If * 2) / 100)
                        cpcf4 = Female4 * 0.02
                        cpcf4 = cpcf4 * cpcI
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Sport" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Im * 12) / 100)
                        cpcm1 = Male1 * 0.07
                        cpcm1 = cpcm1 * cpcI
                        Female1 = ((chk1If * 31) / 100)
                        cpcf1 = Female1 * 0.07
                        cpcf1 = cpcf1 * cpcI
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Im * 24) / 100)
                        cpcm2 = Male2 * 0.05
                        cpcm2 = cpcm2 * cpcI
                        Female2 = ((chk2If * 29) / 100)
                        cpcf2 = Female2 * 0.05
                        cpcf2 = cpcf2 * cpcI
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Im * 1) / 100)
                        cpcm3 = Male3 * 0.05
                        cpcm3 = cpcm3 * cpcI
                        Female3 = ((chk3If * 1) / 100)
                        cpcf3 = Female3 * 0.05
                        cpcf3 = cpcf3 * cpcI
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Im * 1) / 100)
                        cpcm4 = Male4 * 0.03
                        cpcm4 = cpcm4 * cpcI
                        Female4 = ((chk4If * 1) / 100)
                        cpcf4 = Female4 * 0.03
                        cpcf4 = cpcf4 * cpcI
                        Age = Age + "65+"
                    End If
                End If

            End If
            If RadioButton1.Checked = True Then
                Price = "* The CPC is $0.29"
            End If
            If RadioButton3.Checked = True Then
                Price = "* The CPM is $0.06"
            End If
            cpmm1 = (Male1 * cpmI)
            cpmm2 = (Male2 * cpmI)
            cpmm3 = (Male3 * cpmI)
            cpmm4 = (Male4 * cpmI)
            cpmf1 = (Female1 * cpmI)
            cpmf2 = (Female2 * cpmI)
            cpmf3 = (Female3 * cpmI)
            cpmf4 = (Female4 * cpmI)
        End If
        'Saudi Arabia Statistics
        If cmbCountries.SelectedItem.Text = "Saudi Arabia" Then
            If RadioButton4.Checked = True Then
                If lstCategories.SelectedItem.Text = "Food" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Sm * 11) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.05
                        cpcm1 = cpcm1 * cpcs
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Sm * 14) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.09
                        cpcm2 = cpcm2 * cpcs
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Sm * 11) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.08
                        cpcm3 = cpcm3 * cpcs
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Sm * 3) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcs
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Movie" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Sm * 20) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.08
                        cpcm1 = cpcm1 * cpcs
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Sm * 22) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.08
                        cpcm2 = cpcm2 * cpcs
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Sm * 5) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.03
                        cpcm3 = cpcm3 * cpcs
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Sm * 4) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.01
                        cpcm4 = cpcm4 * cpcs
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Music" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Sm * 22) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.09
                        cpcm1 = cpcm1 * cpcs
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Sm * 11) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.07
                        cpcm2 = cpcm2 * cpcs
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Sm * 2) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.06
                        cpcm3 = cpcm3 * cpcs
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Sm * 1) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.03
                        cpcm4 = cpcm4 * cpcs
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Shopping" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Sm * 9) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.04
                        cpcm1 = cpcm1 * cpcs
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Sm * 13) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.07
                        cpcm2 = cpcm2 * cpcs
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Sm * 5) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.09
                        cpcm3 = cpcm3 * cpcs
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Sm * 2) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcs
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Sport" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Sm * 22) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.03
                        cpcm1 = cpcm1 * cpcs
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Sm * 28) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.05
                        cpcm2 = cpcm2 * cpcs
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Sm * 3) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.06
                        cpcm3 = cpcm3 * cpcs
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Sm * 1) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcs
                    End If
                End If

            End If
            If RadioButton5.Checked = True Then
                If lstCategories.SelectedItem.Text = "Food" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1Sf * 29) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.05
                        cpcf1 = cpcf1 * cpcs
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2Sf * 17) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.09
                        cpcf2 = cpcf2 * cpcs
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3Sf * 9) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.08
                        cpcf3 = cpcf3 * cpcs
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4Sf * 6) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.2
                        cpcf4 = cpcf4 * cpcs
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Movie" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1Sf * 13) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.08
                        cpcf1 = cpcf1 * cpcs
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2Sf * 15) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.08
                        cpcf2 = cpcf2 * cpcs
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3Sf * 14) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.03
                        cpcf3 = cpcf3 * cpcs
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4Sf * 7) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.01
                        cpcf4 = cpcf4 * cpcs
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Music" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1Sf * 27) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.09
                        cpcf1 = cpcf1 * cpcs
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2Sf * 33) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.07
                        cpcf2 = cpcf2 * cpcs
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3Sf * 3) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.06
                        cpcf3 = cpcf3 * cpcs
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4Sf * 1) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.03
                        cpcf4 = cpcf4 * cpcs
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Shopping" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1Sf * 26) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.04
                        cpcf1 = cpcf1 * cpcs
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2Sf * 32) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.07
                        cpcf2 = cpcf2 * cpcs
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3Sf * 8) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.09
                        cpcf3 = cpcf3 * cpcs
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4Sf * 5) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.02
                        cpcf4 = cpcf4 * cpcs
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Sport" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1Sf * 19) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.03
                        cpcf1 = cpcf1 * cpcs
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2Sf * 22) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.05
                        cpcf2 = cpcf2 * cpcs
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3Sf * 2) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.06
                        cpcf3 = cpcf3 * cpcs
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4Sf * 1) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.02
                        cpcf4 = cpcf4 * cpcs
                    End If
                End If

            End If
            If RadioButton6.Checked = True Then
                If lstCategories.SelectedItem.Text = "Food" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Sm * 11) / 100)
                        cpcm1 = Male1 * 0.05
                        cpcm1 = cpcm1 * cpcs
                        Female1 = ((chk1Sf * 29) / 100)
                        cpcf1 = Female1 * 0.05
                        cpcf1 = cpcf1 * cpcs
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Sm * 14) / 100)
                        cpcm2 = Male2 * 0.09
                        cpcm2 = cpcm2 * cpcs
                        Female2 = ((chk2Sf * 17) / 100)
                        cpcf2 = Female2 * 0.09
                        cpcf2 = cpcf2 * cpcs
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Sm * 11) / 100)
                        cpcm3 = Male3 * 0.08
                        cpcm3 = cpcm3 * cpcs
                        Female3 = ((chk3Sf * 9) / 100)
                        cpcf3 = Female3 * 0.08
                        cpcf3 = cpcf3 * cpcs
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Sm * 3) / 100)
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcs
                        Female4 = ((chk4Sf * 6) / 100)
                        cpcf4 = Female4 * 0.02
                        cpcf4 = cpcf4 * cpcs
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Movie" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Sm * 20) / 100)
                        cpcm1 = Male1 * 0.08
                        cpcm1 = cpcm1 * cpcs
                        Female1 = ((chk1Sf * 13) / 100)
                        cpcf1 = Female1 * 0.08
                        cpcf1 = cpcf1 * cpcs
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Sm * 22) / 100)
                        cpcm2 = Male2 * 0.08
                        cpcm2 = cpcm2 * cpcs
                        Female2 = ((chk2Sf * 15) / 100)
                        cpcf2 = Female2 * 0.08
                        cpcf2 = cpcf2 * cpcs
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Sm * 5) / 100)
                        cpcm3 = Male3 * 0.03
                        cpcm3 = cpcm3 * cpcs
                        Female3 = ((chk3Sf * 14) / 100)
                        cpcf3 = Female3 * 0.03
                        cpcf3 = cpcf3 * cpcs
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Sm * 4) / 100)
                        cpcm4 = Male4 * 0.01
                        cpcm4 = cpcm4 * cpcs
                        Female4 = ((chk4Sf * 7) / 100)
                        cpcf4 = Female4 * 0.01
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Music" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Sm * 22) / 100)
                        cpcm1 = Male1 * 0.09
                        cpcm1 = cpcm1 * cpcs
                        Female1 = ((chk1Sf * 27) / 100)
                        cpcf1 = Female1 * 0.07
                        cpcf1 = cpcf1 * cpcs
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Sm * 11) / 100)
                        cpcm2 = Male2 * 0.06
                        cpcm2 = cpcm2 * cpcs
                        Female2 = ((chk2Sf * 33) / 100)
                        cpcf2 = Female2 * 0.03
                        cpcf2 = cpcf2 * cpcs
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Sm * 2) / 100)
                        cpcm3 = Male3 * 0.06
                        cpcm3 = cpcm3 * cpcs
                        Female3 = ((chk3Sf * 3) / 100)
                        cpcf3 = Female3 * 0.06
                        cpcf3 = cpcf3 * cpcs
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Sm * 1) / 100)
                        cpcm4 = Male4 * 0.03
                        cpcm4 = cpcm4 * cpcs
                        Female4 = ((chk4Sf * 1) / 100)
                        cpcf4 = Female4 * 0.03
                        cpcf4 = cpcf4 * cpcs
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Shopping" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Sm * 9) / 100)
                        cpcm1 = Male1 * 0.04
                        cpcm1 = cpcm1 * cpcs
                        Female1 = ((chk1Sf * 26) / 100)
                        cpcf1 = Female1 * 0.04
                        cpcf1 = cpcf1 * cpcs
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Sm * 13) / 100)
                        cpcm2 = Male2 * 0.07
                        cpcm2 = cpcm2 * cpcs
                        Female2 = ((chk2Sf * 32) / 100)
                        cpcf2 = Female2 * 0.07
                        cpcf2 = cpcf2 * cpcs
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Sm * 5) / 100)
                        cpcm3 = Male3 * 0.09
                        cpcm3 = cpcm3 * cpcs
                        Female3 = ((chk3Sf * 8) / 100)
                        cpcf3 = Female3 * 0.09
                        cpcf3 = cpcf3 * cpcs
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Sm * 2) / 100)
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcs
                        Female4 = ((chk4Sf * 5) / 100)
                        cpcf4 = Female4 * 0.02
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Sport" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Sm * 22) / 100)
                        cpcm1 = Male1 * 0.03
                        cpcm1 = cpcm1 * cpcs
                        Female1 = ((chk1Sf * 19) / 100)
                        cpcf1 = Female1 * 0.03
                        cpcf1 = cpcf1 * cpcs
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Sm * 28) / 100)
                        cpcm2 = Male2 * 0.05
                        cpcm2 = cpcm2 * cpcs
                        Female2 = ((chk2Sf * 22) / 100)
                        cpcf2 = Female2 * 0.05
                        cpcf2 = cpcf2 * cpcs
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Sm * 3) / 100)
                        cpcm3 = Male3 * 0.06
                        cpcm3 = cpcm3 * cpcs
                        Female3 = ((chk3Sf * 2) / 100)
                        cpcf3 = Female3 * 0.06
                        cpcf3 = cpcf3 * cpcs
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Sm * 1) / 100)
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcs
                        Female4 = ((chk4Sf * 1) / 100)
                        cpcf4 = Female4 * 0.02
                        cpcf4 = cpcf4 * cpcs
                        Age = Age + "65+"

                    End If
                End If

            End If
            If RadioButton1.Checked = True Then
                Price = "* The CPC is $0.34"
            End If
            If RadioButton3.Checked = True Then
                Price = "* The CPM is $0.07"
            End If
            cpmm1 = (Male1 * cpms)
            cpmm2 = (Male2 * cpms)
            cpmm3 = (Male3 * cpms)
            cpmm4 = (Male4 * cpms)
            cpmf1 = (Female1 * cpms)
            cpmf2 = (Female2 * cpms)
            cpmf3 = (Female3 * cpms)
            cpmf4 = (Female4 * cpms)

        End If

        'United State Statistics 
        If cmbCountries.SelectedItem.Text = "United State" Then
            If RadioButton4.Checked = True Then
                If lstCategories.SelectedItem.Text = "Food" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Um * 17) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.06
                        cpcm1 = cpcm1 * cpcu
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Um * 17) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.09
                        cpcm2 = cpcm2 * cpcu
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Um * 10) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.04
                        cpcm3 = cpcm3 * cpcu
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Um * 5) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcu
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Movie" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Um * 34) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.09
                        cpcm1 = cpcm1 * cpcu
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Um * 26) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.07
                        cpcm2 = cpcm2 * cpcu
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Um * 7) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.05
                        cpcm3 = cpcm3 * cpcu
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Um * 1) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.04
                        cpcm4 = cpcm4 * cpcu
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Music" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Um * 17) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.08
                        cpcm1 = cpcm1 * cpcu
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Um * 13) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.09
                        cpcm2 = cpcm2 * cpcu
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Um * 22) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.04
                        cpcm3 = cpcm3 * cpcu
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Um * 5) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.03
                        cpcm4 = cpcm4 * cpcu
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Shopping" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Um * 5) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.07
                        cpcm1 = cpcm1 * cpcu
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Um * 13) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.06
                        cpcm2 = cpcm2 * cpcu
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Um * 17) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.03
                        cpcm3 = cpcm3 * cpcu
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Um * 4) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcu
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Sport" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Um * 16) / 100)
                        Age = "13-24, "
                        cpcm1 = Male1 * 0.06
                        cpcm1 = cpcm1 * cpcu
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Um * 23) / 100)
                        Age = Age + "25-44, "
                        cpcm2 = Male2 * 0.04
                        cpcm2 = cpcm2 * cpcu
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Um * 15) / 100)
                        Age = Age + "45-64, "
                        cpcm3 = Male3 * 0.02
                        cpcm3 = cpcm3 * cpcu
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Um * 2) / 100)
                        Age = Age + "65+"
                        cpcm4 = Male4 * 0.01
                        cpcm4 = cpcm4 * cpcu
                    End If
                End If

            End If
            If RadioButton5.Checked = True Then
                If lstCategories.SelectedItem.Text = "Food" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1Uf * 22) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.06
                        cpcf1 = cpcf1 * cpcu
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2Uf * 13) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.09
                        cpcf2 = cpcf2 * cpcu
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3Uf * 8) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.04
                        cpcf3 = cpcf3 * cpcu
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4Uf * 8) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.02
                        cpcf4 = cpcf4 * cpcu
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Movie" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1Uf * 11) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.09
                        cpcf1 = cpcf1 * cpcu
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2Uf * 17) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.07
                        cpcf2 = cpcf2 * cpcu
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3Uf * 3) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.05
                        cpcf3 = cpcf3 * cpcu
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4Uf * 1) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.04
                        cpcf4 = cpcf4 * cpcu
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Music" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1Uf * 15) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.08
                        cpcf1 = cpcf1 * cpcu
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2Uf * 12) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.09
                        cpcf2 = cpcf2 * cpcu
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3Uf * 14) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.04
                        cpcf3 = cpcf3 * cpcu
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4Uf * 2) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.03
                        cpcf4 = cpcf4 * cpcu
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Shopping" Then
                    If chk1.Checked = True Then
                        Female1 = ((chk1Uf * 16) / 100)
                        Age = "13-24, "
                        cpcf1 = Female1 * 0.07
                        cpcf1 = cpcf1 * cpcu
                    End If
                    If chk2.Checked = True Then
                        Female2 = ((chk2Uf * 21) / 100)
                        Age = Age + "25-44, "
                        cpcf2 = Female2 * 0.06
                        cpcf2 = cpcf2 * cpcu
                    End If
                    If chk3.Checked = True Then
                        Female3 = ((chk3Uf * 19) / 100)
                        Age = Age + "45-64, "
                        cpcf3 = Female3 * 0.03
                        cpcf3 = cpcf3 * cpcu
                    End If
                    If chk4.Checked = True Then
                        Female4 = ((chk4Uf * 5) / 100)
                        Age = Age + "65+"
                        cpcf4 = Female4 * 0.02
                        cpcf4 = cpcf4 * cpcu
                    End If
                    If lstCategories.SelectedItem.Text = "Sport" Then
                        If chk1.Checked = True Then
                            Female1 = ((chk1Uf * 13) / 100)
                            Age = "13-24, "
                            cpcf1 = Female1 * 0.06
                            cpcf1 = cpcf1 * cpcu
                        End If
                        If chk2.Checked = True Then
                            Female2 = ((chk2Uf * 15) / 100)
                            Age = Age + "25-44, "
                            cpcf2 = Female2 * 0.04
                            cpcf2 = cpcf2 * cpcu
                        End If
                        If chk3.Checked = True Then
                            Female3 = ((chk3Uf * 12) / 100)
                            Age = Age + "45-64, "
                            cpcf3 = Female3 * 0.02
                            cpcf3 = cpcf3 * cpcu
                        End If
                        If chk4.Checked = True Then
                            Female4 = ((chk4Uf * 4) / 100)
                            Age = Age + "65+"
                            cpcf4 = Female4 * 0.01
                            cpcf4 = cpcf4 * cpcu
                        End If
                    End If

                End If
            End If
            If RadioButton6.Checked = True Then
                If lstCategories.SelectedItem.Text = "Food" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Um * 17) / 100)
                        cpcm1 = Male1 * 0.06
                        cpcm1 = cpcm1 * cpcu
                        Female1 = ((chk1Uf * 22) / 100)
                        cpcf1 = Female1 * 0.06
                        cpcf1 = cpcf1 * cpcu
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Um * 17) / 100)
                        cpcm2 = Male2 * 0.09
                        cpcm2 = cpcm2 * cpcu
                        Female2 = ((chk2Uf * 13) / 100)
                        cpcf2 = Female2 * 0.09
                        cpcf2 = cpcf2 * cpcu
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Um * 10) / 100)
                        cpcm3 = Male3 * 0.04
                        cpcm3 = cpcm3 * cpcu
                        Female3 = ((chk3Uf * 8) / 100)
                        cpcf3 = Female3 * 0.04
                        cpcf3 = cpcf3 * cpcu
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Um * 5) / 100)
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcu
                        Female4 = ((chk4Uf * 8) / 100)
                        cpcf4 = Female4 * 0.02
                        cpcf4 = cpcf4 * cpcu
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Movie" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Um * 34) / 100)
                        cpcm1 = Male1 * 0.09
                        cpcm1 = cpcm1 * cpcu
                        Female1 = ((chk1Uf * 11) / 100)
                        cpcf1 = Female1 * 0.09
                        cpcf1 = cpcf1 * cpcu
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Um * 26) / 100)
                        cpcm2 = Male2 * 0.07
                        cpcm2 = cpcm2 * cpcu
                        Female2 = ((chk2Uf * 17) / 100)
                        cpcf2 = Female2 * 0.07
                        cpcf2 = cpcf2 * cpcu
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Um * 7) / 100)
                        cpcm3 = Male3 * 0.05
                        cpcm3 = cpcm3 * cpcu
                        Female3 = ((chk3Uf * 3) / 100)
                        cpcf3 = Female3 * 0.05
                        cpcf3 = cpcf3 * cpcu
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Um * 1) / 100)
                        cpcm4 = Male4 * 0.04
                        cpcm4 = cpcm4 * cpcu
                        Female4 = ((chk4Uf * 1) / 100)
                        cpcf4 = Female4 * 0.04
                        cpcf4 = cpcf4 * cpcu
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Music" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Um * 17) / 100)
                        cpcm1 = Male1 * 0.08
                        cpcm1 = cpcm1 * cpcu
                        Female1 = ((chk1Uf * 15) / 100)
                        cpcf1 = Female1 * 0.08
                        cpcf1 = cpcf1 * cpcu
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Um * 13) / 100)
                        cpcm2 = Male2 * 0.09
                        cpcm2 = cpcm2 * cpcu
                        Female2 = ((chk2Uf * 12) / 100)
                        cpcf2 = Female2 * 0.09
                        cpcf2 = cpcf2 * cpcu
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Um * 22) / 100)
                        cpcm3 = Male3 * 0.04
                        cpcm3 = cpcm3 * cpcu
                        Female3 = ((chk3Uf * 14) / 100)
                        cpcf3 = Female3 * 0.04
                        cpcf3 = cpcf3 * cpcu
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Um * 5) / 100)
                        cpcm4 = Male4 * 0.03
                        cpcm4 = cpcm4 * cpcu
                        Female4 = ((chk4Uf * 2) / 100)
                        cpcf4 = Female4 * 0.03
                        cpcf4 = cpcf4 * cpcu
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Shopping" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Um * 5) / 100)
                        cpcm1 = Male1 * 0.07
                        cpcm1 = cpcm1 * cpcu
                        Female1 = ((chk1Uf * 16) / 100)
                        cpcf1 = Female1 * 0.07
                        cpcf1 = cpcf1 * cpcu
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Um * 13) / 100)
                        cpcm2 = Male2 * 0.06
                        cpcm2 = cpcm2 * cpcu
                        Female2 = ((chk2Uf * 21) / 100)
                        cpcf2 = Female2 * 0.06
                        cpcf2 = cpcf2 * cpcu
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Um * 17) / 100)
                        cpcm3 = Male3 * 0.03
                        cpcm3 = cpcm3 * cpcu
                        Female3 = ((chk3Uf * 19) / 100)
                        cpcf3 = Female3 * 0.03
                        cpcf3 = cpcf3 * cpcu
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Um * 4) / 100)
                        cpcm4 = Male4 * 0.02
                        cpcm4 = cpcm4 * cpcu
                        Female4 = ((chk4Uf * 5) / 100)
                        cpcf4 = Female4 * 0.02
                        cpcf4 = cpcf4 * cpcu
                        Age = Age + "65+"
                    End If
                End If
                If lstCategories.SelectedItem.Text = "Sport" Then
                    If chk1.Checked = True Then
                        Male1 = ((chk1Um * 16) / 100)
                        cpcm1 = Male1 * 0.06
                        cpcm1 = cpcm1 * cpcu
                        Female1 = ((chk1Uf * 13) / 100)
                        cpcf1 = Female1 * 0.06
                        cpcf1 = cpcf1 * cpcu
                        Age = "13-24, "
                    End If
                    If chk2.Checked = True Then
                        Male2 = ((chk2Um * 23) / 100)
                        cpcm2 = Male2 * 0.04
                        cpcm2 = cpcm2 * cpcu
                        Female2 = ((chk2Uf * 15) / 100)
                        cpcf2 = Female2 * 0.04
                        cpcf2 = cpcf2 * cpcu
                        Age = Age + "25-44, "
                    End If
                    If chk3.Checked = True Then
                        Male3 = ((chk3Um * 15) / 100)
                        cpcm3 = Male3 * 0.02
                        cpcm3 = cpcm3 * cpcu
                        Female3 = ((chk3Uf * 12) / 100)
                        cpcf3 = Female3 * 0.02
                        cpcf3 = cpcf3 * cpcu
                        Age = Age + "45-64, "
                    End If
                    If chk4.Checked = True Then
                        Male4 = ((chk4Um * 2) / 100)
                        cpcm4 = Male4 * 0.01
                        cpcm4 = cpcm4 * cpcu
                        Female4 = ((chk4Uf * 4) / 100)
                        cpcf4 = Female4 * 0.01
                        cpcf4 = cpcf4 * cpcu
                        Age = Age + "65+"
                    End If
                End If

            End If
            If RadioButton1.Checked = True Then
                Price = "* The CPC is $1.12"
            End If
            If RadioButton3.Checked = True Then
                Price = "* The CPM is $0.24"
            End If
            cpmm1 = (Male1 * cpmu)
            cpmm2 = (Male2 * cpmu)
            cpmm3 = (Male3 * cpmu)
            cpmm4 = (Male4 * cpmu)
            cpmf1 = (Female1 * cpmu)
            cpmf2 = (Female2 * cpmu)
            cpmf3 = (Female3 * cpmu)
            cpmf4 = (Female4 * cpmu)
        End If
        'Audiance
        Male = Male1 + Male2 + Male3 + Male4
        Female = Female1 + Female2 + Female3 + Female4
        Audiance = Male + Female

        'Compare
        If Male1 > Female1 Then
            Users1 = Male1
            Usersg1 = "Male between age of 13 and 24 "
            If cpcm1 < cpmm1 Then
                c1 = cpcm1
                Cost1 = "Go with Cost Per Click (CPC) and pay only $"
            Else
                c1 = cpmm1
                Cost1 = "Go with Cost Per Thousand Impression (CPM) and pay only $"
            End If
        Else
            Users1 = Female1
            Usersg1 = "Female between age of 13 and 24 "
            If cpcf1 < cpmf1 Then
                c1 = cpcf1
                Cost1 = "Go with Cost Per Click (CPC) and pay only $"
            Else
                c1 = cpmf1
                Cost1 = "Go with Cost Per Thousand Impression (CPM) and pay only $"
            End If
        End If

        If Male2 > Female2 Then
            Users2 = Male2
            Usersg2 = "Male between age of 25 and 44 "
            If cpcm2 < cpmm2 Then
                c2 = cpcm2
                Cost2 = "Go with Cost Per Click (CPC) and pay only $"
            Else
                c2 = cpmm2
                Cost2 = "Go with Cost Per Thousand Impression (CPM) and pay only $"
            End If
        Else
            Users2 = Female2
            Usersg2 = "Female between age of 25 and 44 "
            If cpcf2 < cpmf2 Then
                c2 = cpcf2
                Cost2 = "Go with Cost Per Click (CPC) and pay only $"
            Else
                c2 = cpmf2
                Cost2 = "Go with Cost Per Thousand Impression (CPM) and pay only $"
            End If
        End If

        If Male3 > Female3 Then
            Users3 = Male3
            Usersg3 = "Male between age of 45 and 64 "
            If cpcm3 < cpmm3 Then
                c3 = cpcm3
                Cost3 = "Go with Cost Per Click (CPC) and pay only $"
            Else
                c3 = cpmm3
                Cost3 = "Go with Cost Per Thousand Impression (CPM) and pay only $"
            End If
        Else
            Users3 = Female3
            Usersg3 = "Female between age of 45 and 64 "
            If cpcf3 < cpmf3 Then
                c3 = cpcf3
                Cost3 = "Go with Cost Per Click (CPC) and pay only $"
            Else
                c3 = cpmf3
                Cost3 = "Go with Cost Per Thousand Impression (CPM) and pay only $"
            End If
        End If

        If Male4 > Female4 Then
            Users4 = Male4
            Usersg4 = "Male of age 65+ "
            If cpcm4 < cpmm4 Then
                c4 = cpcm4
                Cost4 = "Go with Cost Per Click (CPC) and pay only $"
            Else
                c4 = cpmm4
                Cost4 = "Go with Cost Per Thousand Impression (CPM) and pay only $"
            End If
        Else
            Users4 = Female4
            Usersg4 = "Female of age 65+ "
            If cpcf4 < cpmf4 Then
                c4 = cpcf4
                Cost4 = "Go with Cost Per Click (CPC) and pay only $"
            Else
                c4 = cpmf4
                Cost4 = "Go with Cost Per Thousand Impression (CPM) and pay only $"
            End If
        End If

        'Min COST
        If Users1 > Users2 And Users1 > 0 And Users2 > 0 Then
            If Opcost = 0 Then
                Opcost = c1
                opd = Cost1
                Users = Users1
                Usersg = Usersg1
            Else
                If c1 < Opcost Then
                    Opcost = c1
                    opd = Cost1
                    Users = Users1
                    Usersg = Usersg1
                End If
            End If
        Else
            If Users2 > Users1 And Users1 > 0 And Users2 > 0 Then
                If Opcost = 0 Then
                    Opcost = c2
                    opd = Cost2
                    Users = Users2
                    Usersg = Usersg2
                Else
                    If c2 < Opcost Then
                        Opcost = c2
                        opd = Cost2
                        Users = Users2
                        Usersg = Usersg2
                    End If
                End If
            End If
        End If

        If Users1 > Users3 And Users1 > 0 And Users3 > 0 Then
            If Opcost = 0 Then
                Opcost = c1
                opd = Cost1
                Users = Users1
                Usersg = Usersg1
            Else
                If c1 < Opcost Then
                    Opcost = c1
                    opd = Cost1
                    Users = Users1
                    Usersg = Usersg1
                End If
            End If
        Else
            If Users3 > Users1 And Users1 > 0 And Users3 > 0 Then
                If Opcost = 0 Then
                    Opcost = c3
                    opd = Cost3
                    Users = Users3
                    Usersg = Usersg3
                Else
                    If c3 < Opcost Then
                        Opcost = c3
                        opd = Cost3
                        Users = Users3
                        Usersg = Usersg3
                    End If
                End If
            End If
        End If

        If Users1 > Users4 And Users1 > 0 And Users4 > 0 Then
            If Opcost = 0 Then
                Opcost = c1
                opd = Cost1
                Users = Users1
                Usersg = Usersg1
            Else
                If c1 < Opcost Then
                    Opcost = c1
                    opd = Cost1
                    Users = Users1
                    Usersg = Usersg1
                End If
            End If
        Else
            If Users4 > Users1 And Users1 > 0 And Users4 > 0 Then
                If Opcost = 0 Then
                    Opcost = c4
                    opd = Cost4
                    Users = Users4
                    Usersg = Usersg4
                Else
                    If c4 < Opcost Then
                        Opcost = c4
                        opd = Cost4
                        Users = Users4
                        Usersg = Usersg4
                    End If
                End If
            End If
        End If

        If Users2 > Users3 And Users2 > 0 And Users3 > 0 Then
            If Opcost = 0 Then
                Opcost = c2
                opd = Cost2
                Users = Users2
                Usersg = Usersg2
            Else
                If c2 < Opcost Then
                    Opcost = c2
                    opd = Cost2
                    Users = Users2
                    Usersg = Usersg2
                End If
            End If
        Else
            If Users3 > Users2 And Users2 > 0 And Users3 > 0 Then
                If Opcost = 0 Then
                    Opcost = c3
                    opd = Cost3
                    Users = Users3
                    Usersg = Usersg3
                Else
                    If c3 < Opcost Then
                        Opcost = c3
                        opd = Cost3
                        Users = Users3
                        Usersg = Usersg3
                    End If
                End If
            End If
        End If

        If Users2 > Users4 And Users2 > 0 And Users4 > 0 Then
            If Opcost = 0 Then
                Opcost = c2
                opd = Cost2
                Users = Users2
                Usersg = Usersg2
            Else
                If c2 < Opcost Then
                    Opcost = c2
                    opd = Cost2
                    Users = Users2
                    Usersg = Usersg2
                End If
            End If
        Else
            If Users4 > Users2 And Users2 > 0 And Users4 > 0 Then
                If Opcost = 0 Then
                    Opcost = c4
                    opd = Cost4
                    Users = Users4
                    Usersg = Usersg4
                Else
                    If c4 < Opcost Then
                        Opcost = c4
                        opd = Cost4
                        Users = Users4
                        Usersg = Usersg4
                    End If
                End If
            End If
        End If

        If Users3 > Users4 And Users3 > 0 And Users4 > 0 Then
            If Opcost = 0 Then
                Opcost = c3
                opd = Cost3
                Users = Users3
                Usersg = Usersg3
            Else
                If c3 < Opcost Then
                    Opcost = c3
                    opd = Cost3
                    Users = Users3
                    Usersg = Usersg3
                End If
            End If
        Else
            If Users4 > Users2 And Users3 > 0 And Users4 > 0 Then
                If Opcost = 0 Then
                    Opcost = c4
                    opd = Cost4
                Else
                    If c4 < Opcost Then
                        Opcost = c4
                        opd = Cost4
                    End If
                End If
            End If
        End If
       
        MsgBox("The Optimal Decission for advertising product " & " in " & cmbCountries.SelectedItem.Text &
               " will be target " &
             Users & " " & Usersg & " Who like " & lstCategories.SelectedItem.Text &
             opd & Opcost )
    End Sub
End Class