<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
    Me.btnGPGGA = New System.Windows.Forms.Button
    Me.Label1 = New System.Windows.Forms.Label
    Me.lfixstatus = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.tLongitude = New System.Windows.Forms.TextBox
    Me.tLatitude = New System.Windows.Forms.TextBox
    Me.tFixStatus = New System.Windows.Forms.TextBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.Label5 = New System.Windows.Forms.Label
    Me.Label7 = New System.Windows.Forms.Label
    Me.tlatHemis = New System.Windows.Forms.TextBox
    Me.Label9 = New System.Windows.Forms.Label
    Me.tlonHemis = New System.Windows.Forms.TextBox
    Me.Label6 = New System.Windows.Forms.Label
    Me.tSats = New System.Windows.Forms.TextBox
    Me.Label8 = New System.Windows.Forms.Label
    Me.Label10 = New System.Windows.Forms.Label
    Me.Label11 = New System.Windows.Forms.Label
    Me.tLatDec = New System.Windows.Forms.TextBox
    Me.tLonDec = New System.Windows.Forms.TextBox
    Me.Label12 = New System.Windows.Forms.Label
    Me.Label13 = New System.Windows.Forms.Label
    Me.Label14 = New System.Windows.Forms.Label
    Me.Label15 = New System.Windows.Forms.Label
    Me.tLatNaval = New System.Windows.Forms.TextBox
    Me.tLonNaval = New System.Windows.Forms.TextBox
    Me.Label16 = New System.Windows.Forms.Label
    Me.Label17 = New System.Windows.Forms.Label
    Me.tGoogle = New System.Windows.Forms.TextBox
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.tGPGGA = New System.Windows.Forms.TextBox
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.lblSpDesc = New System.Windows.Forms.Label
    Me.Button2 = New System.Windows.Forms.Button
    Me.Button1 = New System.Windows.Forms.Button
    Me.Label19 = New System.Windows.Forms.Label
    Me.Label18 = New System.Windows.Forms.Label
    Me.cboSpeed = New System.Windows.Forms.ComboBox
    Me.cboCom = New System.Windows.Forms.ComboBox
    Me.GroupBox3 = New System.Windows.Forms.GroupBox
    Me.lstLog = New System.Windows.Forms.ListBox
    Me.GroupBox4 = New System.Windows.Forms.GroupBox
    Me.lstGPS = New System.Windows.Forms.ListBox
    Me.Button3 = New System.Windows.Forms.Button
    Me.Label20 = New System.Windows.Forms.Label
    Me.tElevation = New System.Windows.Forms.TextBox
    Me.Label21 = New System.Windows.Forms.Label
    Me.GroupBox5 = New System.Windows.Forms.GroupBox
    Me.TabControl1 = New System.Windows.Forms.TabControl
    Me.UnoTab = New System.Windows.Forms.TabPage
    Me.lblKnt = New System.Windows.Forms.Label
    Me.Label28 = New System.Windows.Forms.Label
    Me.lblKmt = New System.Windows.Forms.Label
    Me.lblHdg = New System.Windows.Forms.Label
    Me.Label27 = New System.Windows.Forms.Label
    Me.Label26 = New System.Windows.Forms.Label
    Me.TabPage1 = New System.Windows.Forms.TabPage
    Me.chkTrack = New System.Windows.Forms.CheckBox
    Me.Label23 = New System.Windows.Forms.Label
    Me.Label22 = New System.Windows.Forms.Label
    Me.tarLon = New System.Windows.Forms.TextBox
    Me.tarLat = New System.Windows.Forms.TextBox
    Me.TabPage2 = New System.Windows.Forms.TabPage
    Me.Label25 = New System.Windows.Forms.Label
    Me.tarDist = New System.Windows.Forms.TextBox
    Me.tarDir = New System.Windows.Forms.TextBox
    Me.Label24 = New System.Windows.Forms.Label
    Me.GroupBox6 = New System.Windows.Forms.GroupBox
    Me.TabControl2 = New System.Windows.Forms.TabControl
    Me.TabPage4 = New System.Windows.Forms.TabPage
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.pb1 = New System.Windows.Forms.PictureBox
    Me.TabPage5 = New System.Windows.Forms.TabPage
    Me.lblTgtRange = New System.Windows.Forms.Label
    Me.proSpd = New System.Windows.Forms.ProgressBar
    Me.lblTgtTange = New System.Windows.Forms.Label
    Me.lblSpd = New System.Windows.Forms.Label
    Me.pb2 = New System.Windows.Forms.PictureBox
    Me.GroupBox1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.GroupBox3.SuspendLayout()
    Me.GroupBox4.SuspendLayout()
    Me.GroupBox5.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.UnoTab.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    Me.GroupBox6.SuspendLayout()
    Me.TabControl2.SuspendLayout()
    Me.TabPage4.SuspendLayout()
    Me.Panel1.SuspendLayout()
    CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabPage5.SuspendLayout()
    CType(Me.pb2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnGPGGA
    '
    Me.btnGPGGA.Location = New System.Drawing.Point(262, 9)
    Me.btnGPGGA.Name = "btnGPGGA"
    Me.btnGPGGA.Size = New System.Drawing.Size(93, 23)
    Me.btnGPGGA.TabIndex = 0
    Me.btnGPGGA.Text = "Manual GPGGA"
    Me.btnGPGGA.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(9, 19)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(50, 13)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "FixStatus"
    '
    'lfixstatus
    '
    Me.lfixstatus.AutoSize = True
    Me.lfixstatus.Location = New System.Drawing.Point(275, 19)
    Me.lfixstatus.Name = "lfixstatus"
    Me.lfixstatus.Size = New System.Drawing.Size(0, 13)
    Me.lfixstatus.TabIndex = 2
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(9, 45)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(45, 13)
    Me.Label3.TabIndex = 3
    Me.Label3.Text = "Latitude"
    '
    'tLongitude
    '
    Me.tLongitude.Location = New System.Drawing.Point(129, 64)
    Me.tLongitude.Name = "tLongitude"
    Me.tLongitude.Size = New System.Drawing.Size(130, 20)
    Me.tLongitude.TabIndex = 6
    '
    'tLatitude
    '
    Me.tLatitude.Location = New System.Drawing.Point(129, 38)
    Me.tLatitude.Name = "tLatitude"
    Me.tLatitude.Size = New System.Drawing.Size(130, 20)
    Me.tLatitude.TabIndex = 7
    '
    'tFixStatus
    '
    Me.tFixStatus.Location = New System.Drawing.Point(129, 12)
    Me.tFixStatus.Name = "tFixStatus"
    Me.tFixStatus.Size = New System.Drawing.Size(130, 20)
    Me.tFixStatus.TabIndex = 8
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(9, 71)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(54, 13)
    Me.Label2.TabIndex = 9
    Me.Label2.Text = "Longitude"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(277, 45)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(77, 13)
    Me.Label4.TabIndex = 10
    Me.Label4.Text = "WGS84 format"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(275, 71)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(77, 13)
    Me.Label5.TabIndex = 11
    Me.Label5.Text = "WGS84 format"
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(9, 229)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(102, 13)
    Me.Label7.TabIndex = 13
    Me.Label7.Text = "Latitude hemisphere"
    '
    'tlatHemis
    '
    Me.tlatHemis.Location = New System.Drawing.Point(129, 222)
    Me.tlatHemis.Name = "tlatHemis"
    Me.tlatHemis.Size = New System.Drawing.Size(130, 20)
    Me.tlatHemis.TabIndex = 12
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(9, 255)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(111, 13)
    Me.Label9.TabIndex = 16
    Me.Label9.Text = "Longitude hemisphere"
    '
    'tlonHemis
    '
    Me.tlonHemis.Location = New System.Drawing.Point(129, 248)
    Me.tlonHemis.Name = "tlonHemis"
    Me.tlonHemis.Size = New System.Drawing.Size(130, 20)
    Me.tlonHemis.TabIndex = 15
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(9, 281)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(86, 13)
    Me.Label6.TabIndex = 18
    Me.Label6.Text = "Sattelites in view"
    '
    'tSats
    '
    Me.tSats.Location = New System.Drawing.Point(129, 274)
    Me.tSats.Name = "tSats"
    Me.tSats.Size = New System.Drawing.Size(130, 20)
    Me.tSats.TabIndex = 17
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(275, 123)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(77, 13)
    Me.Label8.TabIndex = 24
    Me.Label8.Text = "Decimal format"
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(275, 97)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(77, 13)
    Me.Label10.TabIndex = 23
    Me.Label10.Text = "Decimal format"
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(9, 123)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(54, 13)
    Me.Label11.TabIndex = 22
    Me.Label11.Text = "Longitude"
    '
    'tLatDec
    '
    Me.tLatDec.Location = New System.Drawing.Point(129, 90)
    Me.tLatDec.Name = "tLatDec"
    Me.tLatDec.Size = New System.Drawing.Size(130, 20)
    Me.tLatDec.TabIndex = 21
    '
    'tLonDec
    '
    Me.tLonDec.Location = New System.Drawing.Point(129, 116)
    Me.tLonDec.Name = "tLonDec"
    Me.tLonDec.Size = New System.Drawing.Size(130, 20)
    Me.tLonDec.TabIndex = 20
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Location = New System.Drawing.Point(9, 97)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(45, 13)
    Me.Label12.TabIndex = 19
    Me.Label12.Text = "Latitude"
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Location = New System.Drawing.Point(277, 175)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(67, 13)
    Me.Label13.TabIndex = 30
    Me.Label13.Text = "Naval format"
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Location = New System.Drawing.Point(275, 149)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(67, 13)
    Me.Label14.TabIndex = 29
    Me.Label14.Text = "Naval format"
    '
    'Label15
    '
    Me.Label15.AutoSize = True
    Me.Label15.Location = New System.Drawing.Point(9, 175)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(54, 13)
    Me.Label15.TabIndex = 28
    Me.Label15.Text = "Longitude"
    '
    'tLatNaval
    '
    Me.tLatNaval.Location = New System.Drawing.Point(129, 142)
    Me.tLatNaval.Name = "tLatNaval"
    Me.tLatNaval.Size = New System.Drawing.Size(130, 20)
    Me.tLatNaval.TabIndex = 27
    '
    'tLonNaval
    '
    Me.tLonNaval.Location = New System.Drawing.Point(129, 168)
    Me.tLonNaval.Name = "tLonNaval"
    Me.tLonNaval.Size = New System.Drawing.Size(130, 20)
    Me.tLonNaval.TabIndex = 26
    '
    'Label16
    '
    Me.Label16.AutoSize = True
    Me.Label16.Location = New System.Drawing.Point(9, 149)
    Me.Label16.Name = "Label16"
    Me.Label16.Size = New System.Drawing.Size(45, 13)
    Me.Label16.TabIndex = 25
    Me.Label16.Text = "Latitude"
    '
    'Label17
    '
    Me.Label17.AutoSize = True
    Me.Label17.Location = New System.Drawing.Point(9, 307)
    Me.Label17.Name = "Label17"
    Me.Label17.Size = New System.Drawing.Size(78, 13)
    Me.Label17.TabIndex = 32
    Me.Label17.Text = "Google map url"
    '
    'tGoogle
    '
    Me.tGoogle.Location = New System.Drawing.Point(129, 300)
    Me.tGoogle.Name = "tGoogle"
    Me.tGoogle.Size = New System.Drawing.Size(215, 20)
    Me.tGoogle.TabIndex = 31
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.tGPGGA)
    Me.GroupBox1.Controls.Add(Me.btnGPGGA)
    Me.GroupBox1.Location = New System.Drawing.Point(12, 327)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(361, 41)
    Me.GroupBox1.TabIndex = 33
    Me.GroupBox1.TabStop = False
    '
    'tGPGGA
    '
    Me.tGPGGA.Location = New System.Drawing.Point(8, 11)
    Me.tGPGGA.Name = "tGPGGA"
    Me.tGPGGA.Size = New System.Drawing.Size(248, 20)
    Me.tGPGGA.TabIndex = 1
    Me.tGPGGA.Text = "$GPGGA,165113.000,5601.0318,N,01211.3503,E,1,07,1.2,22.4,M,41.6,M,,0000*60"
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.lblSpDesc)
    Me.GroupBox2.Controls.Add(Me.Button2)
    Me.GroupBox2.Controls.Add(Me.Button1)
    Me.GroupBox2.Controls.Add(Me.Label19)
    Me.GroupBox2.Controls.Add(Me.Label18)
    Me.GroupBox2.Controls.Add(Me.cboSpeed)
    Me.GroupBox2.Controls.Add(Me.cboCom)
    Me.GroupBox2.Location = New System.Drawing.Point(3, 374)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(256, 120)
    Me.GroupBox2.TabIndex = 34
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Comport"
    '
    'lblSpDesc
    '
    Me.lblSpDesc.AutoSize = True
    Me.lblSpDesc.Location = New System.Drawing.Point(176, 29)
    Me.lblSpDesc.Name = "lblSpDesc"
    Me.lblSpDesc.Size = New System.Drawing.Size(0, 13)
    Me.lblSpDesc.TabIndex = 37
    '
    'Button2
    '
    Me.Button2.Location = New System.Drawing.Point(176, 19)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(75, 23)
    Me.Button2.TabIndex = 36
    Me.Button2.Text = "Close"
    Me.Button2.UseVisualStyleBackColor = True
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(176, 44)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(75, 23)
    Me.Button1.TabIndex = 4
    Me.Button1.Text = "Open"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'Label19
    '
    Me.Label19.AutoSize = True
    Me.Label19.Location = New System.Drawing.Point(6, 29)
    Me.Label19.Name = "Label19"
    Me.Label19.Size = New System.Drawing.Size(46, 13)
    Me.Label19.TabIndex = 3
    Me.Label19.Text = "Comport"
    '
    'Label18
    '
    Me.Label18.AutoSize = True
    Me.Label18.Location = New System.Drawing.Point(6, 56)
    Me.Label18.Name = "Label18"
    Me.Label18.Size = New System.Drawing.Size(38, 13)
    Me.Label18.TabIndex = 2
    Me.Label18.Text = "Speed"
    '
    'cboSpeed
    '
    Me.cboSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSpeed.FormattingEnabled = True
    Me.cboSpeed.Location = New System.Drawing.Point(68, 46)
    Me.cboSpeed.Name = "cboSpeed"
    Me.cboSpeed.Size = New System.Drawing.Size(102, 21)
    Me.cboSpeed.TabIndex = 1
    '
    'cboCom
    '
    Me.cboCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCom.FormattingEnabled = True
    Me.cboCom.Location = New System.Drawing.Point(68, 21)
    Me.cboCom.Name = "cboCom"
    Me.cboCom.Size = New System.Drawing.Size(102, 21)
    Me.cboCom.TabIndex = 0
    '
    'GroupBox3
    '
    Me.GroupBox3.Controls.Add(Me.lstLog)
    Me.GroupBox3.Location = New System.Drawing.Point(382, 300)
    Me.GroupBox3.Name = "GroupBox3"
    Me.GroupBox3.Size = New System.Drawing.Size(252, 68)
    Me.GroupBox3.TabIndex = 35
    Me.GroupBox3.TabStop = False
    Me.GroupBox3.Text = "Log"
    '
    'lstLog
    '
    Me.lstLog.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lstLog.FormattingEnabled = True
    Me.lstLog.Location = New System.Drawing.Point(3, 16)
    Me.lstLog.Name = "lstLog"
    Me.lstLog.Size = New System.Drawing.Size(246, 43)
    Me.lstLog.TabIndex = 0
    '
    'GroupBox4
    '
    Me.GroupBox4.Controls.Add(Me.lstGPS)
    Me.GroupBox4.Location = New System.Drawing.Point(3, 500)
    Me.GroupBox4.Name = "GroupBox4"
    Me.GroupBox4.Size = New System.Drawing.Size(631, 104)
    Me.GroupBox4.TabIndex = 36
    Me.GroupBox4.TabStop = False
    Me.GroupBox4.Text = "GPS data v4"
    '
    'lstGPS
    '
    Me.lstGPS.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lstGPS.FormattingEnabled = True
    Me.lstGPS.Location = New System.Drawing.Point(3, 16)
    Me.lstGPS.Name = "lstGPS"
    Me.lstGPS.Size = New System.Drawing.Size(625, 82)
    Me.lstGPS.TabIndex = 0
    '
    'Button3
    '
    Me.Button3.Location = New System.Drawing.Point(350, 297)
    Me.Button3.Name = "Button3"
    Me.Button3.Size = New System.Drawing.Size(23, 23)
    Me.Button3.TabIndex = 37
    Me.Button3.Text = ".."
    Me.Button3.UseVisualStyleBackColor = True
    '
    'Label20
    '
    Me.Label20.AutoSize = True
    Me.Label20.Location = New System.Drawing.Point(9, 201)
    Me.Label20.Name = "Label20"
    Me.Label20.Size = New System.Drawing.Size(51, 13)
    Me.Label20.TabIndex = 39
    Me.Label20.Text = "Elevation"
    '
    'tElevation
    '
    Me.tElevation.Location = New System.Drawing.Point(129, 194)
    Me.tElevation.Name = "tElevation"
    Me.tElevation.Size = New System.Drawing.Size(130, 20)
    Me.tElevation.TabIndex = 38
    '
    'Label21
    '
    Me.Label21.AutoSize = True
    Me.Label21.Location = New System.Drawing.Point(277, 201)
    Me.Label21.Name = "Label21"
    Me.Label21.Size = New System.Drawing.Size(39, 13)
    Me.Label21.TabIndex = 40
    Me.Label21.Text = "Meters"
    '
    'GroupBox5
    '
    Me.GroupBox5.Controls.Add(Me.TabControl1)
    Me.GroupBox5.Location = New System.Drawing.Point(265, 374)
    Me.GroupBox5.Name = "GroupBox5"
    Me.GroupBox5.Size = New System.Drawing.Size(369, 120)
    Me.GroupBox5.TabIndex = 41
    Me.GroupBox5.TabStop = False
    Me.GroupBox5.Text = "Direction and heading to target"
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.UnoTab)
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Location = New System.Drawing.Point(6, 14)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(357, 100)
    Me.TabControl1.TabIndex = 2
    '
    'UnoTab
    '
    Me.UnoTab.Controls.Add(Me.lblKnt)
    Me.UnoTab.Controls.Add(Me.Label28)
    Me.UnoTab.Controls.Add(Me.lblKmt)
    Me.UnoTab.Controls.Add(Me.lblHdg)
    Me.UnoTab.Controls.Add(Me.Label27)
    Me.UnoTab.Controls.Add(Me.Label26)
    Me.UnoTab.Location = New System.Drawing.Point(4, 22)
    Me.UnoTab.Name = "UnoTab"
    Me.UnoTab.Size = New System.Drawing.Size(349, 74)
    Me.UnoTab.TabIndex = 2
    Me.UnoTab.Text = "Heading & Speed"
    Me.UnoTab.UseVisualStyleBackColor = True
    '
    'lblKnt
    '
    Me.lblKnt.AutoSize = True
    Me.lblKnt.Location = New System.Drawing.Point(101, 52)
    Me.lblKnt.Name = "lblKnt"
    Me.lblKnt.Size = New System.Drawing.Size(13, 13)
    Me.lblKnt.TabIndex = 5
    Me.lblKnt.Text = "0"
    '
    'Label28
    '
    Me.Label28.AutoSize = True
    Me.Label28.Location = New System.Drawing.Point(20, 52)
    Me.Label28.Name = "Label28"
    Me.Label28.Size = New System.Drawing.Size(60, 13)
    Me.Label28.TabIndex = 4
    Me.Label28.Text = "Speed(Knt)"
    '
    'lblKmt
    '
    Me.lblKmt.AutoSize = True
    Me.lblKmt.Location = New System.Drawing.Point(101, 30)
    Me.lblKmt.Name = "lblKmt"
    Me.lblKmt.Size = New System.Drawing.Size(13, 13)
    Me.lblKmt.TabIndex = 3
    Me.lblKmt.Text = "0"
    '
    'lblHdg
    '
    Me.lblHdg.AutoSize = True
    Me.lblHdg.Location = New System.Drawing.Point(101, 8)
    Me.lblHdg.Name = "lblHdg"
    Me.lblHdg.Size = New System.Drawing.Size(17, 13)
    Me.lblHdg.TabIndex = 2
    Me.lblHdg.Text = "0°"
    '
    'Label27
    '
    Me.Label27.AutoSize = True
    Me.Label27.Location = New System.Drawing.Point(20, 30)
    Me.Label27.Name = "Label27"
    Me.Label27.Size = New System.Drawing.Size(67, 13)
    Me.Label27.TabIndex = 1
    Me.Label27.Text = "Speed(KMT)"
    '
    'Label26
    '
    Me.Label26.AutoSize = True
    Me.Label26.Location = New System.Drawing.Point(20, 8)
    Me.Label26.Name = "Label26"
    Me.Label26.Size = New System.Drawing.Size(50, 13)
    Me.Label26.TabIndex = 0
    Me.Label26.Text = "Heading "
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.chkTrack)
    Me.TabPage1.Controls.Add(Me.Label23)
    Me.TabPage1.Controls.Add(Me.Label22)
    Me.TabPage1.Controls.Add(Me.tarLon)
    Me.TabPage1.Controls.Add(Me.tarLat)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(349, 74)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Target coordinates"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'chkTrack
    '
    Me.chkTrack.AutoSize = True
    Me.chkTrack.Location = New System.Drawing.Point(204, 39)
    Me.chkTrack.Name = "chkTrack"
    Me.chkTrack.Size = New System.Drawing.Size(89, 17)
    Me.chkTrack.TabIndex = 42
    Me.chkTrack.Text = "Start tracking"
    Me.chkTrack.UseVisualStyleBackColor = True
    '
    'Label23
    '
    Me.Label23.AutoSize = True
    Me.Label23.Location = New System.Drawing.Point(6, 41)
    Me.Label23.Name = "Label23"
    Me.Label23.Size = New System.Drawing.Size(54, 13)
    Me.Label23.TabIndex = 3
    Me.Label23.Text = "Longitude"
    '
    'Label22
    '
    Me.Label22.AutoSize = True
    Me.Label22.Location = New System.Drawing.Point(6, 15)
    Me.Label22.Name = "Label22"
    Me.Label22.Size = New System.Drawing.Size(45, 13)
    Me.Label22.TabIndex = 2
    Me.Label22.Text = "Latitude"
    '
    'tarLon
    '
    Me.tarLon.Location = New System.Drawing.Point(98, 34)
    Me.tarLon.Name = "tarLon"
    Me.tarLon.Size = New System.Drawing.Size(100, 20)
    Me.tarLon.TabIndex = 1
    '
    'tarLat
    '
    Me.tarLat.Location = New System.Drawing.Point(98, 8)
    Me.tarLat.Name = "tarLat"
    Me.tarLat.Size = New System.Drawing.Size(100, 20)
    Me.tarLat.TabIndex = 0
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.Label25)
    Me.TabPage2.Controls.Add(Me.tarDist)
    Me.TabPage2.Controls.Add(Me.tarDir)
    Me.TabPage2.Controls.Add(Me.Label24)
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(349, 74)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "Direction & range to target"
    Me.TabPage2.UseVisualStyleBackColor = True
    '
    'Label25
    '
    Me.Label25.AutoSize = True
    Me.Label25.Location = New System.Drawing.Point(6, 39)
    Me.Label25.Name = "Label25"
    Me.Label25.Size = New System.Drawing.Size(39, 13)
    Me.Label25.TabIndex = 3
    Me.Label25.Text = "Range"
    '
    'tarDist
    '
    Me.tarDist.Location = New System.Drawing.Point(97, 32)
    Me.tarDist.Name = "tarDist"
    Me.tarDist.Size = New System.Drawing.Size(100, 20)
    Me.tarDist.TabIndex = 2
    '
    'tarDir
    '
    Me.tarDir.Location = New System.Drawing.Point(97, 6)
    Me.tarDir.Name = "tarDir"
    Me.tarDir.Size = New System.Drawing.Size(100, 20)
    Me.tarDir.TabIndex = 1
    '
    'Label24
    '
    Me.Label24.AutoSize = True
    Me.Label24.Location = New System.Drawing.Point(6, 13)
    Me.Label24.Name = "Label24"
    Me.Label24.Size = New System.Drawing.Size(49, 13)
    Me.Label24.TabIndex = 0
    Me.Label24.Text = "Direction"
    '
    'GroupBox6
    '
    Me.GroupBox6.Controls.Add(Me.TabControl2)
    Me.GroupBox6.Location = New System.Drawing.Point(379, 12)
    Me.GroupBox6.Name = "GroupBox6"
    Me.GroupBox6.Size = New System.Drawing.Size(255, 282)
    Me.GroupBox6.TabIndex = 42
    Me.GroupBox6.TabStop = False
    Me.GroupBox6.Text = "Compas"
    '
    'TabControl2
    '
    Me.TabControl2.Controls.Add(Me.TabPage4)
    Me.TabControl2.Controls.Add(Me.TabPage5)
    Me.TabControl2.Location = New System.Drawing.Point(3, 16)
    Me.TabControl2.Name = "TabControl2"
    Me.TabControl2.SelectedIndex = 0
    Me.TabControl2.Size = New System.Drawing.Size(252, 266)
    Me.TabControl2.TabIndex = 45
    '
    'TabPage4
    '
    Me.TabPage4.BackColor = System.Drawing.Color.White
    Me.TabPage4.Controls.Add(Me.Panel1)
    Me.TabPage4.Location = New System.Drawing.Point(4, 22)
    Me.TabPage4.Name = "TabPage4"
    Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage4.Size = New System.Drawing.Size(244, 240)
    Me.TabPage4.TabIndex = 0
    Me.TabPage4.Text = "Compas"
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.Color.White
    Me.Panel1.Controls.Add(Me.pb1)
    Me.Panel1.Location = New System.Drawing.Point(6, 6)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(232, 228)
    Me.Panel1.TabIndex = 44
    '
    'pb1
    '
    Me.pb1.BackColor = System.Drawing.Color.White
    Me.pb1.Image = Global.tmagpsapiwin.My.Resources.Resources.compas2
    Me.pb1.InitialImage = CType(resources.GetObject("pb1.InitialImage"), System.Drawing.Image)
    Me.pb1.Location = New System.Drawing.Point(10, 7)
    Me.pb1.Name = "pb1"
    Me.pb1.Size = New System.Drawing.Size(211, 210)
    Me.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.pb1.TabIndex = 43
    Me.pb1.TabStop = False
    '
    'TabPage5
    '
    Me.TabPage5.BackColor = System.Drawing.Color.White
    Me.TabPage5.Controls.Add(Me.lblTgtRange)
    Me.TabPage5.Controls.Add(Me.proSpd)
    Me.TabPage5.Controls.Add(Me.lblTgtTange)
    Me.TabPage5.Controls.Add(Me.lblSpd)
    Me.TabPage5.Controls.Add(Me.pb2)
    Me.TabPage5.Location = New System.Drawing.Point(4, 22)
    Me.TabPage5.Name = "TabPage5"
    Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage5.Size = New System.Drawing.Size(244, 240)
    Me.TabPage5.TabIndex = 1
    Me.TabPage5.Text = "Track arraow"
    '
    'lblTgtRange
    '
    Me.lblTgtRange.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTgtRange.Location = New System.Drawing.Point(122, 172)
    Me.lblTgtRange.Name = "lblTgtRange"
    Me.lblTgtRange.Size = New System.Drawing.Size(101, 25)
    Me.lblTgtRange.TabIndex = 4
    Me.lblTgtRange.Text = "0"
    Me.lblTgtRange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'proSpd
    '
    Me.proSpd.Location = New System.Drawing.Point(11, 205)
    Me.proSpd.Maximum = 150
    Me.proSpd.Name = "proSpd"
    Me.proSpd.Size = New System.Drawing.Size(219, 23)
    Me.proSpd.TabIndex = 3
    '
    'lblTgtTange
    '
    Me.lblTgtTange.AutoSize = True
    Me.lblTgtTange.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTgtTange.Location = New System.Drawing.Point(152, 172)
    Me.lblTgtTange.Name = "lblTgtTange"
    Me.lblTgtTange.Size = New System.Drawing.Size(0, 25)
    Me.lblTgtTange.TabIndex = 2
    '
    'lblSpd
    '
    Me.lblSpd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSpd.Location = New System.Drawing.Point(6, 174)
    Me.lblSpd.Name = "lblSpd"
    Me.lblSpd.Size = New System.Drawing.Size(110, 23)
    Me.lblSpd.TabIndex = 1
    Me.lblSpd.Text = "0 km/t"
    '
    'pb2
    '
    Me.pb2.Image = Global.tmagpsapiwin.My.Resources.Resources.arraw
    Me.pb2.Location = New System.Drawing.Point(30, 4)
    Me.pb2.Name = "pb2"
    Me.pb2.Size = New System.Drawing.Size(193, 183)
    Me.pb2.TabIndex = 0
    Me.pb2.TabStop = False
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(642, 611)
    Me.Controls.Add(Me.GroupBox3)
    Me.Controls.Add(Me.GroupBox6)
    Me.Controls.Add(Me.GroupBox5)
    Me.Controls.Add(Me.Label21)
    Me.Controls.Add(Me.Label20)
    Me.Controls.Add(Me.tElevation)
    Me.Controls.Add(Me.Button3)
    Me.Controls.Add(Me.GroupBox4)
    Me.Controls.Add(Me.GroupBox2)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.Label17)
    Me.Controls.Add(Me.tGoogle)
    Me.Controls.Add(Me.Label13)
    Me.Controls.Add(Me.Label14)
    Me.Controls.Add(Me.Label15)
    Me.Controls.Add(Me.tLatNaval)
    Me.Controls.Add(Me.tLonNaval)
    Me.Controls.Add(Me.Label16)
    Me.Controls.Add(Me.Label8)
    Me.Controls.Add(Me.Label10)
    Me.Controls.Add(Me.Label11)
    Me.Controls.Add(Me.tLatDec)
    Me.Controls.Add(Me.tLonDec)
    Me.Controls.Add(Me.Label12)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.tSats)
    Me.Controls.Add(Me.Label9)
    Me.Controls.Add(Me.tlonHemis)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.tlatHemis)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.tFixStatus)
    Me.Controls.Add(Me.tLatitude)
    Me.Controls.Add(Me.tLongitude)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.lfixstatus)
    Me.Controls.Add(Me.Label1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.Name = "Form1"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "tma.dk - GPS API"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.GroupBox3.ResumeLayout(False)
    Me.GroupBox4.ResumeLayout(False)
    Me.GroupBox5.ResumeLayout(False)
    Me.TabControl1.ResumeLayout(False)
    Me.UnoTab.ResumeLayout(False)
    Me.UnoTab.PerformLayout()
    Me.TabPage1.ResumeLayout(False)
    Me.TabPage1.PerformLayout()
    Me.TabPage2.ResumeLayout(False)
    Me.TabPage2.PerformLayout()
    Me.GroupBox6.ResumeLayout(False)
    Me.TabControl2.ResumeLayout(False)
    Me.TabPage4.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabPage5.ResumeLayout(False)
    Me.TabPage5.PerformLayout()
    CType(Me.pb2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnGPGGA As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents lfixstatus As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents tLongitude As System.Windows.Forms.TextBox
  Friend WithEvents tLatitude As System.Windows.Forms.TextBox
  Friend WithEvents tFixStatus As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents tlatHemis As System.Windows.Forms.TextBox
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents tlonHemis As System.Windows.Forms.TextBox
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents tSats As System.Windows.Forms.TextBox
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents tLatDec As System.Windows.Forms.TextBox
  Friend WithEvents tLonDec As System.Windows.Forms.TextBox
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents Label15 As System.Windows.Forms.Label
  Friend WithEvents tLatNaval As System.Windows.Forms.TextBox
  Friend WithEvents tLonNaval As System.Windows.Forms.TextBox
  Friend WithEvents Label16 As System.Windows.Forms.Label
  Friend WithEvents Label17 As System.Windows.Forms.Label
  Friend WithEvents tGoogle As System.Windows.Forms.TextBox
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents tGPGGA As System.Windows.Forms.TextBox
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents Label19 As System.Windows.Forms.Label
  Friend WithEvents Label18 As System.Windows.Forms.Label
  Friend WithEvents cboSpeed As System.Windows.Forms.ComboBox
  Friend WithEvents cboCom As System.Windows.Forms.ComboBox
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
  Friend WithEvents lstLog As System.Windows.Forms.ListBox
  Friend WithEvents Button2 As System.Windows.Forms.Button
  Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
  Friend WithEvents lstGPS As System.Windows.Forms.ListBox
  Friend WithEvents Button3 As System.Windows.Forms.Button
  Friend WithEvents Label20 As System.Windows.Forms.Label
  Friend WithEvents tElevation As System.Windows.Forms.TextBox
  Friend WithEvents Label21 As System.Windows.Forms.Label
  Friend WithEvents lblSpDesc As System.Windows.Forms.Label
  Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents Label23 As System.Windows.Forms.Label
  Friend WithEvents Label22 As System.Windows.Forms.Label
  Friend WithEvents tarLon As System.Windows.Forms.TextBox
  Friend WithEvents tarLat As System.Windows.Forms.TextBox
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents chkTrack As System.Windows.Forms.CheckBox
  Friend WithEvents tarDir As System.Windows.Forms.TextBox
  Friend WithEvents Label24 As System.Windows.Forms.Label
  Friend WithEvents Label25 As System.Windows.Forms.Label
  Friend WithEvents tarDist As System.Windows.Forms.TextBox
  Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
  Friend WithEvents pb1 As System.Windows.Forms.PictureBox
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents UnoTab As System.Windows.Forms.TabPage
  Friend WithEvents lblKnt As System.Windows.Forms.Label
  Friend WithEvents Label28 As System.Windows.Forms.Label
  Friend WithEvents lblKmt As System.Windows.Forms.Label
  Friend WithEvents lblHdg As System.Windows.Forms.Label
  Friend WithEvents Label27 As System.Windows.Forms.Label
  Friend WithEvents Label26 As System.Windows.Forms.Label
  Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
  Friend WithEvents pb2 As System.Windows.Forms.PictureBox
  Friend WithEvents lblSpd As System.Windows.Forms.Label
  Friend WithEvents proSpd As System.Windows.Forms.ProgressBar
  Friend WithEvents lblTgtTange As System.Windows.Forms.Label
  Friend WithEvents lblTgtRange As System.Windows.Forms.Label

End Class
