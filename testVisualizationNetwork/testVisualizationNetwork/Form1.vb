


''Public Class _Lines
''    Inherits Control

''    Public Sub New()

''    End Sub

''    'Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
''    '    MyBase.OnPaint(e)
''    '    Dim myPen As Pen = New Pen(Color.Red)
''    '    myPen.Width = 3
''    '    e.Graphics.DrawLine(myPen, 100, 100, 100, 100)
''    'End Sub



''    Protected Overrides Sub OnPaint(ByVal args As PaintEventArgs)
''        'Get the Graphics object from PaintEventArgs
''        Dim g As Graphics = args.Graphics
''        'Draw rectangle
''        g.DrawRectangle(New Pen(Color.Blue, 3), New Rectangle(10, 10, 50, 50))
''        'Fill ellipse
''        g.FillEllipse(Brushes.Red, New Rectangle(60, 60, 100, 100))
''        'Draw text
''        g.DrawString("Text", New Font("Verdana", 14), New SolidBrush(Color.Green), 200, 200)
''    End Sub

''End Class

'Imports System.Numerics
Imports Microsoft.DirectX
Imports Microsoft.DirectX.Direct3D
Imports Microsoft.DirectX.PrivateImplementationDetails
Imports System.Threading

Imports System.Threading.Tasks
Imports System.ComponentModel

Imports Cudafy
Imports Cudafy.Host
Imports Cudafy.Translator


'Imports System.Runtime.InteropServices
'Imports OpenCL

Public Class Form1
    'Private g As Graphics


    Dim myPen As Pen = New Pen(Color.Red)
    Dim random As New Random()


    Public Shared device As Direct3D.Device
    Public Sub Initialize()
        Dim present As PresentParameters = New PresentParameters
        present.Windowed = True 'we?ll draw on a window
        present.SwapEffect = SwapEffect.Discard 'discuss later

        device = New Direct3D.Device(0, DeviceType.Hardware, Me, CreateFlags.SoftwareVertexProcessing, present)



    End Sub


    '    Dim vecSum As String = "
    '                     __kernel void floatVectorSum(__global float * v1, __global float * v2)
    '{
    '// Vector element index
    'int i = get_global_id(0);
    'v1[i] = v1[i] + v2[i];

    '}"

    '    Dim TestRep As String = "
    '                     __kernel void floatVectorSum(__global float * n1, __global float * n2)
    '{
    '// Vector element index
    'int i = get_global_id(0);
    'v1[i] = v1[i] + v2[i];

    '}"
    'Private Shared ReadOnly Property IsPrime As String
    '    Get
    '        Return "
    '    kernel void GetIfPrime(global int* num, int period)
    '    {
    '        int index = get_global_id(0);

    '        int sum = (2.0 / (1.0 + period)) * (num[index] - num[0]);
    '        printf("" %d \n"",sum);
    '    }"
    '    End Get
    'End Property
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()


        'cl.LoadKernel(IsPrime)
        'cl.Invoke("GetIfPrime", 0, Primes.Length, Primes, 1.0)


        'OpenCLTemplate.CLCalc.InitCL()
        'OpenCLTemplate.CLCalc.Program.Compile(New String() {vecSum})
        'Dim VectorSum As OpenCLTemplate.CLCalc.Program.Kernel = New OpenCLTemplate.CLCalc.Program.Kernel("floatVectorSum")


        'Dim n As Integer = 20000000
        'Dim v1 As Single() = New Single(n - 1) {}, v2 As Single() = New Single(n - 1) {}



        'For i As Integer = 0 To n - 1
        '    v1(i) = CSng(i) / 10
        '    v2(i) = -CSng(i) / 9
        'Next


        'Dim a As Integer = 0

        'Dim time As Stopwatch
        'time = Stopwatch.StartNew()


        'For i As Integer = 0 To n - 2
        '    a = v1(i) + v2(i)
        'Next

        'time.Stop()
        'MsgBox(time.ElapsedMilliseconds)


        'Dim args As OpenCLTemplate.CLCalc.Program.Variable()

        'time = Stopwatch.StartNew()



        ''Dim varV1 As OpenCLTemplate.CLCalc.Program.Variable = New OpenCLTemplate.CLCalc.Program.Variable(v1)
        ''Dim varV2 As OpenCLTemplate.CLCalc.Program.Variable = New OpenCLTemplate.CLCalc.Program.Variable(v2)



        'args = New OpenCLTemplate.CLCalc.Program.Variable() {New OpenCLTemplate.CLCalc.Program.Variable(v1), New OpenCLTemplate.CLCalc.Program.Variable(v2)}
        '' Dim workers As Integer() = New Integer(0) {n}



        'VectorSum.Execute(args, New Integer(0) {n})


        'args(0).ReadFromDeviceTo(v1)


        'time.Stop()













        'MsgBox(time.ElapsedMilliseconds)

        'System.Array.Clear(v1, 0, v1.Length)
        ' System.Array.Clear(v2, 0, v1.Length)

        'varV1.Dispose()
        'varV2.Dispose()


        'MsgBox(v1(1))


        'GC.Collect()









        ''Dim _Line As _Lines = New _Lines
        ''_Line.Size = New Size(300, 300)
        ''_Line.Text
        ''Me.Controls.Add(_Line)

        ''Dim _Line2 As _Lines = New _Lines
        ''_Line2.Size = New Size(10, 10)
        ''Me.Controls.Add(_Line2)
        'Dim A As Point = New Point(50, 150)
        'Dim B As Point = New Point(100, 350)
        'p = New Pen(Color.Red)
        'g.DrawLine(p, A, B)
        'Lines.Add(A)
        'Lines.Add(B)
        'Refresh()
        ' Initialize()




        Initialize() ' after
        CCreate()
        'Initialize() ' before
        InitiateTexture()

        'device.Clear(ClearFlags.Target, Color.White, 1.0F, 0)
    End Sub
    Private Sub Task1(ByVal state As Object)

        Try




        Catch ex As Exception
            ' Catch exs As ArgumentOutOfRangeException


        End Try

        'For i = 0 To N - 1
        '    node1 = listofnodes.item(i)
        '    myPen.Color = node1.BackColor
        '    For j = 0 To node1.neighbors.Count - 1
        '        node2 = node1.neighbors(j)

        '        g.DrawLine(myPen, node1.Location.X + 15, node1.Location.Y + 15, node2.Location.X + 15, node2.Location.Y + 15)
        '    Next
        '    ' node.BringToFront()
        'Next
        ' Catch ex As Exception
        '    MsgBox(ex.ToString)
        '  End Try
    End Sub
    Dim myBrush As System.Drawing.SolidBrush = New SolidBrush(System.Drawing.Color.Black)
    Sub loc()
        ' node.Location = New Point(node.Loca.X + dx, node.Loca.Y + dy)
    End Sub


    ' if location of node = mouse then property enabled insted of searching each time? or gpu ... etc. hmm...
    <Cudafy>
    Public Structure NodeStruct
        Public X As Integer
        Public Y As Integer
        Public Force_X As Integer
        Public Force_Y As Integer
        '<VBFixedArray(N)> Dim i As Integer
    End Structure



    <Cudafy>
    Public Shared Sub thekernel(ByVal thread As GThread, ByVal a As NodeStruct(), ByVal Props As Integer())
        Dim tid As Integer = thread.threadIdx.x + thread.blockIdx.x * thread.blockDim.x 'thread.threadIdx.x

        Dim ffx, ffy, distanceSquared_1, distance_1, force_1, ddx, ddy As Integer

        For i = tid + 1 To Props(1) - 1



            ddx = a(i).X - a(tid).X
            ddy = a(i).Y - a(tid).Y

            If Not ddx = 0 Or Not ddy = 0 Then
                distanceSquared_1 = ddx * ddx + ddy * ddy
                distance_1 = GMath.Sqrt(distanceSquared_1)
                force_1 = Props(0) / distanceSquared_1 ' K_r

                ffx = force_1 * ddx / distance_1
                ffy = force_1 * ddy / distance_1

                a(tid).Force_X -= ffx
                a(tid).Force_Y -= ffy
                a(i).Force_X += ffx
                a(i).Force_Y += ffy

                ' 


            End If
            If ddx = 0 Then ' meh
                ' Dim rd As New Random()

                a(tid).Force_X += GMath.Round(1 + 1 / i) ' 0 <----------------
                a(i).Force_X += GMath.Round(-1 + 1 / tid)

            End If

            If ddy = 0 Then '
                'Dim rd1 As New Random()

                a(tid).Force_Y += GMath.Round(-1 + 1 / i)
                a(i).Force_Y += GMath.Round(1 + 1 / tid)
            End If
            'If tid < N Then
            ' c(tid).x = a(tid).x * b(tid).x / 2
            '    c(tid).y = a(tid).y * b(tid).y / 2
            '  c(tid).z = a(tid).z * b(tid).z / 2
            ' End If
        Next
    End Sub


    Dim km As CudafyModule
    Dim gpu As GPGPU

    Dim listofnodes As List(Of myButton)
    Dim Connections As Integer = 0
    Sub CCreate()


        CudafyModes.Target = eGPUType.OpenCL

        CudafyModes.DeviceId = 0


        ' forgive me :P 
        If CudafyHost.GetDevice(CudafyModes.Target, CudafyModes.DeviceId).GetDeviceProperties.Name.Contains("CPU") Then
            CudafyModes.DeviceId = 1
        End If

        CudafyTranslator.Language = eLanguage.OpenCL
        km = CudafyTranslator.Cudafy()
        gpu = CudafyHost.GetDevice(CudafyModes.Target, CudafyModes.DeviceId)
        gpu.EnableMultithreading()



        gpu.LoadModule(km)


        Timer1.Enabled = False

        Me.Controls.Clear()
        Me.Controls.Add(Label1)
        Me.Controls.Add(TrackBar1)
        Me.Controls.Add(TrackBar2)
        Me.Controls.Add(TrackBar3)
        Me.Controls.Add(TrackBar4)
        Me.Controls.Add(Button13)
        Me.Controls.Add(Button12)
        Me.Controls.Add(CheckBox1)

        ' Me.Controls.Add(PictureBox1)

        Button12.Location = New Point(Button12.Location.X + 20, Button12.Location.Y)



        g = Me.CreateGraphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        myPen.Width = 1
        Label1.Text = ""
        Timer1.Enabled = False

        myPen.Width = 1
        'MsgBox((Me.Width + Me.Height) * 2)
        MAX_DISPLACEMENT_SQUARED = Me.Height * Me.Width ' / 2 ''  10000

        listofnodes = New List(Of myButton)
        '======= myButtons Create
        For i = 1 To 50 ' <===================================================================================== FOR -==================================================================================================================================================================================================================================================
            'Me.Controls.Add(New myButton With {
            '                .Name = "myButton" & i,
            '                .Text = i,
            '                .Size = New Drawing.Size(30, 30),
            '                .Anchor = Nothing,
            '                .Location = New Point(0, 0),
            '                .Loca = New Point(Me.Width / 2, Me.Height / 2),
            '                .BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255))}) '+ 31 * i
            listofnodes.Add(New myButton With {
                            .Text = i,
                            .Size = New Drawing.Size(30, 30),
                            .Loca = New Point(Me.Width / 2, Me.Height / 2),
                            .BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255))}) '+ 31 * i)

        Next
        'listofnodes = listofnodes.Item.ToList

        '


        '======= myButtons Initialize Forces
        N = listofnodes.Count 'Me.Controls.OfType(Of myButton).Count



        If N > 256 Then
            thr = 256
        Else
            thr = N
        End If



        Gui_Nodes = New List(Of Node_GUI)

        For i = 0 To N - 1

            Dim nodeI As myButton = listofnodes.Item(i)


            Gui_Nodes.Add(New Node_GUI With {.position = nodeI.Loca, .Btmap = ReturnCreateBitmapAtRuntime(nodeI.Text, nodeI.Size, nodeI.BackColor), .Texture_ = New Texture(device, .Btmap, Usage.None, Pool.Managed)})
            'nodeI.Hide()

            nodeI.Force_X = 0
            nodeI.Force_Y = 0

        Next

        'listofnodes(1).Show()
        '======= Add Neighbors
        'For i = 0 To N - 1 'Step 2
        '    Label1.Text &= "Negh of " & i + 1 & ": "
        '    For j = i + 1 To N - 1 Step 2
        '        listofnodes.item(i).neighbors.Add(listofnodes.item(j))
        '        Label1.Text &= j + 1 & ","
        '    Next
        '    Label1.Text &= vbNewLine
        'Next


        'Dim b As Integer = 5
        For i = 0 To N - 1 'Step 2
            'Label1.Text &= "Negh of " & i + 1 & ": "

            'If i = 10 Then
            '    b = N - 1
            'End If


            For j = 0 To random.Next(-1, 8) Step 2
                node1 = listofnodes.Item(random.Next(0, N - j)) ' j
                If Not node1 Is listofnodes.Item(i) And Not listofnodes.Item(i).neighbors.Contains(node1) Then
                    listofnodes.Item(i).neighbors.Add(node1)

                    listofnodes.Item(i).Connections += 1
                    node1.Connections += 1

                    Connections += 1
                    ' Label1.Text &= node1.Text & ", "
                End If

                'Label1.Text &= j + 1 & ","
            Next
            'Label1.Text &= vbNewLine
        Next

        MsgBox("Runs on: " & gpu.GetDeviceProperties.Name & vbNewLine & vbNewLine & "Connections\Edges: " & Connections & vbNewLine & "Nodes: " & N)
        'Dim j As Integer = 0
        counter = 0
        For i = 0 To N - 1

            For j = 0 To listofnodes.Item(i).neighbors.Count - 1
                counter += 1
            Next
        Next
        counter *= N + 1

        ' N = Me.Controls.OfType(Of myButton).Count

        Dim myCallback As New System.Threading.TimerCallback(AddressOf Task1)
        ' myCallback.Method.


        myTimer = New System.Threading.Timer(myCallback, Nothing, 1, 1)


        a_Col = TrackBar4.Value

        BackgroundWorker2.RunWorkerAsync()
        BackgroundWorker1.RunWorkerAsync()
        'BackgroundWorker3.RunWorkerAsync()
        ' Timer1.Enabled = True ' <========================================================================================================================
    End Sub

    Dim g As Graphics



    Dim node As myButton

    Dim node1 As myButton
    Dim node2 As myButton


    Dim N As Integer

    Dim dx As Long
    Dim dy As Long
    Dim fx As Long 'Double
    Dim fy As Long 'Double

    Dim s As Integer
    Dim MAX_DISPLACEMENT_SQUARED As Long


    Dim distanceSquared As Long
    Dim distance As Long 'Double 'Long
    Dim displacementSquared As Long
    Dim force As Long ' Double ' long

    Dim L As Integer = 4 '50 'spring rest length
    Dim K_r As Integer = 22 '6250 'repulsive force constant
    Dim K_s As Double = 0.5 ' spring constant 0.5 ...
    Dim delta_t As Double = 0.04

    Dim clust1 As Integer
    Dim clust2 As Integer


    Private myTimer As System.Threading.Timer
    Private myTimer2 As System.Threading.Timer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        '============================================================================== No Reasone Timer lol :P i am sorry

        'device.Clear(ClearFlags.Target, Color.White, 1.0F, 0)
        'device.BeginScene()

        ''DrawLine(Color.Black)

        ''


        'Using l As Line = New Line(device)

        '    Dim vecs As Vector2() = New Vector2(counter - 1) {}


        '    Dim a As Integer = 0
        '    For i = 0 To N - 1

        '        For j = 0 To listofnodes.item(i).neighbors.Count - 1
        '            'If listofnodes.item(i).neighbors.Count - 1 = 0 Then MsgBox(1)

        '            vecs(a) = New Vector2(listofnodes.item(i).Loca.X + 15, listofnodes.item(i).Loca.Y + 15)
        '            vecs(a + 1) = New Vector2(listofnodes.item(i).neighbors(j).Loca.X + 15, listofnodes.item(i).neighbors(j).Loca.Y + 15)
        '            a += 2
        '        Next

        '    Next

        '    l.Width = 2
        '    l.Antialias = If(6, True, False) '10
        '    l.Begin()

        '    l.Draw(vecs, Color.Black)
        '    l.[End]()
        'End Using

        'device.EndScene()
        'device.Present()


        ''g.Clear(Me.BackColor)
        ''Try


        ''    For i = 0 To N - 1
        ''        myPen.Color = listofnodes.item(i).BackColor
        ''        listofnodes.item(i).Location = listofnodes.item(i).Loca
        ''        For j = 0 To listofnodes.item(i).neighbors.Count - 1
        ''            g.DrawLine(myPen, listofnodes.item(i).Loca.X + 15, listofnodes.item(i).Loca.Y + 15, listofnodes.item(i).neighbors(j).Loca.X + 15, listofnodes.item(i).neighbors(j).Loca.Y + 15) ' <=========================
        ''        Next
        ''    Next
        ''Catch ex As Exception

        ''End Try
    End Sub

    Dim deg, count As Integer
    Dim node_ As myButton
    Dim node_2 As myButton
    Dim node_3 As myButton

    Public Shared connectnods As myButton = Nothing
    Function ClusteringCoefficient(i As Integer) As Double
        node_ = listofnodes.Item(i)
        deg = node_.neighbors.Count
        If deg = 0 Then Return 0 ' this Is arbitrary
        If deg = 1 Then Return 1 ' this Is arbitrary

        count = 0 ' num.edges present between neighbors

        For j = 0 To deg - 2
            node_2 = node_.neighbors(j)

            For k = j + 1 To deg - 1
                node_3 = node_.neighbors(k)
                If EdgeExistsBetween(node_2, node_3) Then count = count + 1

            Next
        Next
        If Not count / (deg * (deg - 1) / 2) = 1 Then
            Return count / (deg * (deg - 1) / 2)
        End If
        Return 0
    End Function

    Function EdgeExistsBetween(node__2 As myButton, node__3 As myButton) As Boolean
        If node__2.neighbors.Contains(node__3) Or node__3.neighbors.Contains(node__2) Then Return True
        Return False
    End Function





    Public Class myButton
        'Inherits Button
        'Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        '    MyBase.OnPaint(e)

        '    'Add your custom paint code here
        'End Sub

        'Dim msedown As Boolean = False
        'Private Sub myButton_Click(sender As Object, e As EventArgs) Handles Me.Click

        '    'Form1.Label1.Show()  ' <=============================================

        '    'Form1.g.Clear(Color.White)

        '    'Form1.myPen.Color = Me.BackColor

        '    'For Each neigh As myButton In Me.neighbors


        '    '    Form1.g.DrawLine(Form1.myPen, Me.Location.X + 15, Me.Location.Y + 15, neigh.Location.X + 15, neigh.Location.Y + 15)
        '    'Next

        '    ' MsgBox(Me.Connections)


        'End Sub

        'Private Sub myButton_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        '    msedown = True
        'End Sub

        'Private Sub myButton_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        '    msedown = False

        '    If e.Button = MouseButtons.Right Then

        '    End If

        'End Sub
        'Private Sub myButton_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick

        'End Sub
        'Private Sub myButton_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        '    If msedown = False Then Exit Sub

        '    Me.Location = New Point(Me.Location.X + e.X, Me.Location.Y + e.Y)
        '    Me.Loca = New Point(Me.Loca.X + e.X, Me.Loca.Y + e.Y)
        'End Sub


        'Private Sub myButton_Move(sender As Object, e As EventArgs) Handles Me.Move
        '    'Try


        '    '    Form1.g.Clear(Color.White)
        '    '    Dim done1, done2 As myButton

        '    '    For i = 0 To Form1.N - 1
        '    '        done1 = Form1.Controls.OfType(Of myButton)()(i)
        '    '        Form1.myPen.Color = done1.BackColor
        '    '        done1.Location = done1.Loca
        '    '        For j = 0 To done1.neighbors.Count - 1
        '    '            done2 = done1.neighbors(j)

        '    '            Form1.g.DrawLine(Form1.myPen, done1.Loca.X + 15, done1.Loca.Y + 15, done2.Loca.X + 15, done2.Loca.Y + 15)
        '    '        Next
        '    '        node.BringToFront()
        '    '    Next
        '    'Catch ex As Exception

        '    'End Try
        '    'device.Clear(ClearFlags.Target, Color.White, 1.0F, 0)
        '    'device.BeginScene()
        '    ''DrawRandomLines()



        '    ' Form1.g.Clear(Color.White) ' <====== only

        '    ''Form1.g.Clear(Color.White)
        '    ''For Each btn As myButton In Form1.Controls.OfType(Of myButton)
        '    ''    Form1.myPen.Color = btn.BackColor
        '    ''    For Each nei As myButton In btn.neighbors
        '    ''        Form1.g.DrawLine(Form1.myPen, btn.Location.X + 15, btn.Location.Y + 15, nei.Location.X + 15, nei.Location.Y + 15)
        '    ''    Next
        '    ''Next

        '    'For Each neigh As myButton In Me.neighbors


        '    '    Form1.g.DrawLine(Form1.myPen, Me.Location.X + 15, Me.Location.Y + 15, neigh.Location.X + 15, neigh.Location.Y + 15)
        '    'Next
        'End Sub

        'Private Sub myButton_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        '    If e.KeyData = Keys.KeyCode.A Then
        '        If connectnods Is Nothing Then
        '            connectnods = Me
        '            Form1.Text = "MEEEEEEEEEEEEEEEEEEEEEEEEEEE"
        '        Else
        '            Form1.Text = "COOOOOOOOOOOOOOOON"
        '            connectnods.neighbors.Add(Me)
        '            connectnods.Connections += 1
        '            Me.Connections += 1
        '            connectnods = Nothing
        '        End If
        '    End If
        'End Sub

        Private _Force_X As Integer = 0
        Private _Force_Y As Integer = 0
        Private _Connections As Integer = 0

        Private _Loca As Point = New Point(0, 0)
        Private _Size As Size = New Size(0, 0)


        Private _Text As String

        Private _BackColor As Color

        Public neighbors As List(Of myButton) = New List(Of myButton)

        ' The Category attribute tells the designer to set the the lower case and upper case of the text

        Public Property BackColor() As Color
            Get
                Return _BackColor
            End Get
            Set(ByVal value As Color)
                _BackColor = value
            End Set
        End Property

        Public Property Text() As String
            Get
                Return _Text
            End Get
            Set(ByVal value As String)
                _Text = value
            End Set
        End Property


        Public Property Size() As Size
            Get
                Return _Size
            End Get
            Set(ByVal value As Size)
                _Size = value
            End Set
        End Property


        Public Property Loca() As Point
            Get
                Return _Loca
            End Get
            Set(ByVal value As Point)
                _Loca = value
            End Set
        End Property

        Public Property Connections() As Integer
            Get
                Return _Connections
            End Get
            Set(ByVal value As Integer)
                _Connections = value
            End Set
        End Property


        Public Property Force_X() As Integer
            Get
                Return _Force_X
            End Get
            Set(ByVal value As Integer)
                _Force_X = value
            End Set
        End Property


        Public Property Force_Y() As Integer
            Get
                Return _Force_Y
            End Get
            Set(ByVal value As Integer)
                _Force_Y = value
            End Set
        End Property
    End Class


    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)

        'g.DrawLine(myPen, 100, 100, 45, 65)
    End Sub

    Dim vecs As Vector2() = New Vector2(1) {}
    Private Sub DrawLine(Colr As Color, x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer)
        ' Dim vertices As CustomVertex.TransformedColored() = New CustomVertex.TransformedColored(0 To 2) {}

        Using l As Line = New Line(device)




            vecs(0) = New Vector2(x1, y1)
            vecs(1) = New Vector2(x2, y2)



            l.Width = 2
            l.Antialias = If(6, True, False) '10
            l.Begin()

            l.Draw(vecs, Colr)
            l.[End]()
        End Using
    End Sub

    Dim counter As Long = 0

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        'myTimer.Change(1000, 1000)
        Label1.Hide()

        'CreateBitmapAtRuntime("Test")

        'For i = 0 To N - 1
        '    listofnodes.Item(i).Loca = New Point(listofnodes.Item(i).Loca.X + i, listofnodes.Item(i).Loca.Y - i)
        'Next

        'Exit Sub
        'MsgBox(ClusteringCoefficient(1) &
        '       ClusteringCoefficient(2) &
        '       ClusteringCoefficient(3) &
        '       ClusteringCoefficient(4) &
        '       ClusteringCoefficient(5))
        ''Try

        ''    Label1.Hide()
        ''    g.Clear(Color.White)
        ''    Dim done1, done2 As myButton

        ''    For i = 0 To N - 1
        ''        done1 = listofnodes.item(i)
        ''        myPen.Color = done1.BackColor
        ''        done1.Location = done1.Loca
        ''        For j = 0 To done1.neighbors.Count - 1
        ''            done2 = done1.neighbors(j)

        ''            g.DrawLine(myPen, done1.Loca.X + 15, done1.Loca.Y + 15, done2.Loca.X + 15, done2.Loca.Y + 15)
        ''        Next
        ''        ' node.BringToFront()
        ''    Next

        ''Catch ex As Exception

        ''End Try
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll

        K_r = TrackBar1.Value
        Me.Text = "K_r: " & K_r
        'K_r = L
    End Sub

    Private Sub TrackBar3_Scroll(sender As Object, e As EventArgs) Handles TrackBar3.Scroll

        L = TrackBar3.Value
        Me.Text = "L: " & L
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll

        K_s = 1 / TrackBar2.Value
        Me.Text = "K_s: " & K_s

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        CCreate()
        'Me.Invalidate()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp


    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click

    End Sub

    Private texture As Texture
    Private textureSize As Rectangle

    Dim flag As Bitmap = New Bitmap(30, 30)

    Private Function ReturnCreateBitmapAtRuntime(text_ As String, size_ As Size, color_ As Color) As Bitmap
        Dim flg As Bitmap = New Bitmap(size_.Width, size_.Height)

        Dim flagGraphics As Graphics = Graphics.FromImage(flg)
        Dim red As Integer = 0
        Dim white As Integer = 11

        Dim down_border As Integer = (4 * size_.Height) \ 30

        Dim rect1 As Rectangle = New Rectangle(0, 0, size_.Width, size_.Height - down_border) ' 26 h 

        Dim stringFormat As StringFormat = New StringFormat()
        stringFormat.Alignment = StringAlignment.Center
        stringFormat.LineAlignment = StringAlignment.Center

        ' While white <= 100
        flagGraphics.FillRectangle(New SolidBrush(color_), 0, 0, size_.Width, size_.Height - down_border) ' 26 h
        flagGraphics.FillRectangle(ManipulateColor(color_, 0.8F), 0, 26, size_.Width, down_border) ' 4 down_border
        flagGraphics.DrawString(text_, New Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.White, rect1, stringFormat)
        'red += 20
        'white += 20
        ' End While

        'Me.BackgroundImage = flag



        'Dim text1 As String = "Use StringFormat and Rectangle objects to" & " center text in a rectangle."

        'Dim font1 As Drawing.Font = New Drawing.Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point)




        'flagGraphics.DrawString(text1, font1, Brushes.Blue, rect1, stringFormat)
        'flagGraphics.DrawRectangle(Pens.Black, rect1)

        ' End Using
        '  PictureBox1.Image = flag
        Return flg
    End Function

    Public Sub CreateBitmapAtRuntime(text_ As String)


        Dim flagGraphics As Graphics = Graphics.FromImage(flag)
        Dim red As Integer = 0
        Dim white As Integer = 11

        Dim rect1 As Rectangle = New Rectangle(0, 0, 30, 26)

        Dim stringFormat As StringFormat = New StringFormat()
        stringFormat.Alignment = StringAlignment.Center
        stringFormat.LineAlignment = StringAlignment.Center

        ' While white <= 100
        flagGraphics.FillRectangle(Brushes.Red, 0, 0, 30, 26)
        flagGraphics.FillRectangle(ManipulateColor(Color.Red, 0.8F), 0, 26, 30, 4)
        flagGraphics.DrawString(text_, New Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.White, rect1, stringFormat)
        'red += 20
        'white += 20
        ' End While

        'Me.BackgroundImage = flag



        'Dim text1 As String = "Use StringFormat and Rectangle objects to" & " center text in a rectangle."

        'Dim font1 As Drawing.Font = New Drawing.Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point)




        'flagGraphics.DrawString(text1, font1, Brushes.Blue, rect1, stringFormat)
        'flagGraphics.DrawRectangle(Pens.Black, rect1)

        ' End Using
        '  PictureBox1.Image = flag

    End Sub

    Public Shared Function ManipulateColor(ByVal _color As Color, ByVal factor As Single) As Brush ' 0.8F
        Dim a As Byte = _color.A
        Dim r As Integer = Math.Round(_color.R * factor)
        Dim g As Integer = Math.Round(_color.G * factor)
        Dim b As Integer = Math.Round(_color.B * factor)
        Return New Drawing.SolidBrush(Color.FromArgb(a, Math.Min(r, 255), Math.Min(g, 255), Math.Min(b, 255)))
    End Function
    Private Sub InitiateTexture()

        CreateBitmapAtRuntime("T")

        texture = New Texture(device, flag, Usage.None, Pool.Managed)

        Using surface As Surface = texture.GetSurfaceLevel(0)
            Dim surfaceDescription As SurfaceDescription = surface.Description
            textureSize = New Rectangle(0, 0, surfaceDescription.Width, surfaceDescription.Height)
        End Using
    End Sub

    Dim Gui_Nodes As List(Of Node_GUI)

    Private Structure Node_GUI
        Dim Btmap As Bitmap
        Dim position As Point ' doesnt need but lol :P anywayzZzZZz
        Dim Texture_ As Texture
    End Structure




    Public Sub DrawString()
        Dim formGraphics As System.Drawing.Graphics = Me.CreateGraphics()
        Dim drawString As String = "Sample Text"
        Dim drawFont As System.Drawing.Font = New System.Drawing.Font("Arial", 16)
        Dim drawBrush As System.Drawing.SolidBrush = New System.Drawing.SolidBrush(System.Drawing.Color.Black)
        Dim x As Single = 150.0F
        Dim y As Single = 50.0F
        Dim drawFormat As System.Drawing.StringFormat = New System.Drawing.StringFormat()
        formGraphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat)
        drawFont.Dispose()
        drawBrush.Dispose()
        formGraphics.Dispose()
    End Sub


    Dim myT As New Stopwatch()
    Dim n1, n2 As myButton

    Dim vecss As Vector2() = New Vector2(1) {}
    Dim listvecss As List(Of Vector2) = New List(Of Vector2)

    Dim Worker1_Runs As Boolean = True
    Dim Worker2_Runs As Boolean = True
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork ' ================ Drawing

        If Worker1_Runs = false Then Exit sub
            'gpu.Default.For(0, 2,
            '        Sub(i)
            '            Dim Level_1 = 2 'Exception on this line, doesn't happen if commented out.
            '        End Sub)


            device.Clear(ClearFlags.Target, Color.White, 1.0F, 0)

        device.BeginScene()



        'Parallel.For(0, 12, Sub(i)

        '                        Dim temp As New Dummy(sNames(i)) '-- Create an instance of our dummy class with a string name.
        '                        lReturedVal = temp.Process2(lIntervalHolder(i * 2), lIntervalHolder(i * 2 + 1)) '-- start the processing.

        '                        lTotal += lReturedVal   '-- add the returned total to the general total.

        '                    End Sub)


        Using sprite As Sprite = New Sprite(device)


            sprite.Begin(SpriteFlags.None)




            Using l As Line = New Line(device)







                l.Antialias = 6 'If(6, True, False) '10


                For i = 0 To N - 1
                    n1 = listofnodes.Item(i)



                    For j = 0 To n1.neighbors.Count - 1
                        l.Width = 3 ' the only reason why i have the begin here and not out


                        l.Begin()

                        n2 = n1.neighbors(j)


                        vecs(0) = New Vector2(n1.Loca.X + 15 + Navigate_Plus.X, n1.Loca.Y + 15 + Navigate_Plus.Y)
                        vecs(1) = New Vector2(n2.Loca.X + 15 + Navigate_Plus.X, n2.Loca.Y + 15 + Navigate_Plus.Y)



                        l.Draw(vecs, Color.FromArgb(a_Col, n1.BackColor.R, n1.BackColor.G, n1.BackColor.B))

                        'DrawLine(n1.BackColor, ,, ,)
                        l.[End]()
                    Next

                    If hide_btns = True Then ' :P
                        sprite.Draw(Gui_Nodes(i).Texture_, New Rectangle(New Point(0, 0), Gui_Nodes(i).Btmap.Size), New Vector3(0, 0, 0), New Vector3(listofnodes.Item(i).Loca.X + Navigate_Plus.X, listofnodes.Item(i).Loca.Y + Navigate_Plus.Y, 0), Color.White) 'after 
                    End If


                Next

            End Using


            'sprite.Draw(texture, textureSize, New Vector3(0, 0, 0), New Vector3(50, 50, 0), Color.White) ' before

            sprite.[End]()

        End Using
        ' BOXES ?
        'Using b As Line = New Line(device)

        '    b.Width = 15
        '    b.Antialias = If(6, True, False) '10
        '    b.Begin()

        '    For i = 0 To N - 1
        '        n1 = listofnodes.Item(i)
        '        vecs(0) = New Vector2(n1.Loca.X + 8, n1.Loca.Y + 15)
        '        vecs(1) = New Vector2(n1.Loca.X + 23, n1.Loca.Y + 15)


        '        b.Draw(vecs, n1.BackColor)
        '    Next


        '    b.[End]()
        'End Using


        device.EndScene()
        device.Present()


    End Sub

    Private Sub BackgroundWorker3_DoWork(sender As Object, e As DoWorkEventArgs)

        'Me.Invoke(Sub()
        '              'safe to access the form or controls in here
        '              For i = 0 To N - 1


        '                  listofnodes.Item(i).Location = listofnodes.Item(i).Loca

        '              Next
        '          End Sub)





    End Sub

    'Private Sub Timer2_Tick(sender As Object, e As EventArgs)
    '    g.Clear(Me.BackColor)
    '    For Each btn As myButton In Me.Controls.OfType(Of myButton)
    '        myPen.Color = btn.BackColor
    '        For Each nei As myButton In btn.neighbors
    '            g.DrawLine(myPen, btn.Location.X + 15, btn.Location.Y + 15, nei.Location.X + 15, nei.Location.Y + 15)
    '        Next
    '    Next
    'End Sub

    Sub RepultionAllPairs(i As Integer, j As Integer) '

        Dim ffx, ffy, distanceSquared_1, distance_1, force_1, ddx, ddy As Integer

        Dim node_1 As myButton
        Dim node_2 As myButton

        node_1 = listofnodes.Item(i)
        node_2 = listofnodes.Item(j)
        ddx = node_2.Loca.X - node_1.Loca.X
        ddy = node_2.Loca.Y - node_1.Loca.Y

        If Not ddx = 0 Or Not ddy = 0 Then
            distanceSquared_1 = ddx * ddx + ddy * ddy
            distance_1 = Math.Sqrt(distanceSquared_1)
            force_1 = K_r / distanceSquared_1

            ffx = force_1 * ddx / distance_1
            ffy = force_1 * ddy / distance_1

            node_1.Force_X -= ffx
            node_1.Force_Y -= ffy
            node_2.Force_X += ffx
            node_2.Force_Y += ffy

            ' 


        End If
        If ddx = 0 Then

            node_1.Force_X += random.Next(-1, 1) * 1 ' 0 <----------------
            node_2.Force_X += random.Next(-1, 1) * 1

        End If

        If ddy = 0 Then '
            node_1.Force_Y += random.Next(-1, 1) * 1
            node_2.Force_Y += random.Next(-1, 1) * 1
        End If

        'g.DrawLine(myPen, node1.Location.X + 10, node1.Location.Y + 10, node2.Location.X + 10, node2.Location.Y + 10)
    End Sub




    Dim homiostasis As Integer = 0
    Dim nodeI As myButton


    Dim nodd As NodeStruct()
    Dim dev_nodd As NodeStruct()
    Dim Props As Integer() = New Integer(1) {}
    Dim dev_K_R As Integer()

    Dim thr As Integer = 0

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker2.DoWork

        If Worker2_Runs = False Then Exit Sub

        'For i = Me.Controls.OfType(Of Button).Count - 1 To 0 Step -1
        '    MsgBox(Me.Controls.OfType(Of Button)()(i).Text)
        'Next

        '  Try
        'g.Clear(Color.White)


        myT = Stopwatch.StartNew

        myT.Start()


        Parallel.For(0, N, Sub(i) ' its weird n why not n-1


                               listofnodes.Item(i).Force_X = 0
                               listofnodes.Item(i).Force_Y = 0
                           End Sub)

        'For i = 0 To N - 1
        '    nodeI = listofnodes.Item(i)


        '    nodeI.Force_X = 0
        '    nodeI.Force_Y = 0
        'Next







        nodd = New NodeStruct(N - 1) {}


        Parallel.For(0, N, Sub(i)
                               nodd(i).X = listofnodes.Item(i).Loca.X
                               nodd(i).Y = listofnodes.Item(i).Loca.Y
                               nodd(i).Force_X = listofnodes.Item(i).Force_X
                               nodd(i).Force_Y = listofnodes.Item(i).Force_Y
                           End Sub)


        'For i = 0 To N - 1


        'Next


        dev_nodd = gpu.Allocate(Of NodeStruct)(N)
        ' Dim dev_b As VectorStruct() = gpu.Allocate(Of VectorStruct)(N)

        'Dim Dev_par As Integer(,) = gpu.Allocate(Of Integer)(N, 2)

        ' Dim lock As New Object
        ' SyncLock lock

        ' Dim d As New List(Of Integer)

        'retry: 'this is the most fucked up part of my code, lol , "Goto" with "Try" plus list.ToArray in a loop ...


        dev_K_R = gpu.Allocate(Of Integer)(2)

        Props(0) = K_r
        Props(1) = N

        gpu.CopyToDevice(nodd, dev_nodd)
        gpu.CopyToDevice(Props, dev_K_R)
        ' Dim dev_n As NodeStruct() = gpu.Allocate(Of NodeStruct)(N)

        ' Try
        'dev_c = gpu.Allocate(Of VectorStruct)(c)
        '  Catch ex As Cloo.MemoryObjectAllocationFailureComputeException
        '      GoTo retry
        ' End Try

        gpu.Launch(N / thr, thr, (CType(AddressOf thekernel, Action(Of GThread, NodeStruct(), Integer()))), dev_nodd, dev_K_R)
        'gpu.LaunchAsync(N / thr, thr, N, (CType(AddressOf thekernel, Action(Of GThread, NodeStruct(), Integer()))), dev_nodd, dev_K_R)
        gpu.Synchronize()
        gpu.CopyFromDevice(Of NodeStruct)(dev_nodd, nodd)

        'gpu.CopyFromDeviceAsync(Of NodeStruct)(dev_nodd, N, nodd, N, N, N)


        Parallel.For(0, N, Sub(i)


                               If move_Down = False Then
                                   listofnodes.Item(i).Loca = New Point(nodd(i).X, nodd(i).Y)
                               ElseIf Not selectd = -1 Then

                                   listofnodes(selectd).Loca = Navigate_Mouse_Hover
                               End If



                               listofnodes.Item(i).Force_X = nodd(i).Force_X
                               listofnodes.Item(i).Force_Y = nodd(i).Force_Y
                           End Sub)



        gpu.FreeAll()
        gpu.HostFreeAll()




        ' Dim a As Integer = 0





        '=========================================================================para repult
        'Parallel.For(0, N - 1, Sub(i) ' n-2


        '                           ' node1 = listofnodes.Item(i)


        '                           Parallel.For(i + 1, N , Sub(j) ' n-1

        '                                                          RepultionAllPairs(i, j)

        '                                                      End Sub)

        '                       End Sub)










        'repulsion between all pairs
        ''RepultionAllPairs()

        'For i = 0 To N - 2
        '    node1 = listofnodes.Item(i)

        '    For j = i + 1 To N - 1
        '        node2 = listofnodes.Item(j)
        '        dx = node2.Loca.X - node1.Loca.X
        '        dy = node2.Loca.Y - node1.Loca.Y

        '        If Not dx = 0 Or Not dy = 0 Then
        '            distanceSquared = dx * dx + dy * dy
        '            distance = Math.Sqrt(distanceSquared)
        '            force = K_r / distanceSquared

        '            fx = force * dx / distance
        '            fy = force * dy / distance

        '            node1.Force_X = node1.Force_X - fx
        '            node1.Force_Y = node1.Force_Y - fy
        '            node2.Force_X = node2.Force_X + fx
        '            node2.Force_Y = node2.Force_Y + fy

        '            ' 


        '        End If
        '        If dx = 0 Then

        '            node1.Force_X += random.Next(-1, 1) * 30 ' 0 <----------------
        '            node2.Force_X += random.Next(-1, 1) * 10

        '        End If

        '        If dy = 0 Then
        '            node1.Force_Y += random.Next(-1, 1) * 30
        '            node2.Force_Y += random.Next(-1, 1) * 30
        '        End If

        '        'g.DrawLine(myPen, node1.Location.X + 10, node1.Location.Y + 10, node2.Location.X + 10, node2.Location.Y + 10)
        '    Next
        'Next




        '  device.Clear(ClearFlags.Target, Color.White, 1.0F, 0)

        ' Dim i2 As Integer
        ' spring force between adjacent pairs
        For i = 0 To N - 1

            node1 = listofnodes.Item(i)
            'myPen.Color = node1.BackColor

            For j = 0 To (node1.neighbors.Count - 1) Step 1
                'i2 = node1.neighbors(j)
                node2 = node1.neighbors.Item(j)


                '
                'g.DrawLine(myPen, node1.Loca.X + 15, node1.Loca.Y + 15, node2.Loca.X + 15, node2.Loca.Y + 15) ' <=========================



                'If i < j Then

                dx = node2.Loca.X - node1.Loca.X
                dy = node2.Loca.Y - node1.Loca.Y



                If Not dx = 0 Or Not dy = 0 Then ' kati edv gia clusters???

                    'clust1 = 1
                    'clust2 = 1
                    'If EdgeExistsBetween(node1, node2) Then

                    '    clust1 = node1.Connections
                    '    clust2 = node2.Connections
                    '    'If node1.Connections = 1 Then
                    '    '    clust1 = 10
                    '    'End If
                    '    'If node2.Connections = 1 Then
                    '    '    clust2 = 10
                    '    'End If
                    'End If

                    distance = Math.Sqrt(dx * dx + dy * dy)
                    force = (K_s) * (distance - L) ' / (clust1 + clust2)
                    fx = force * dx / distance
                    fy = force * dy / distance



                    node1.Force_X = node1.Force_X + fx
                    node1.Force_Y = node1.Force_Y + fy
                    node2.Force_X = node2.Force_X - fx
                    node2.Force_Y = node2.Force_Y - fy
                End If

                'End If

            Next
        Next


        'Parallel.For(0, N, Sub(i) ' weird N-1 :/

        '                       Dim nodee As myButton = listofnodes.Item(i)
        '                       Dim dxx As Integer
        '                       Dim dyy As Integer
        '                       Dim s_ As Integer
        '                       Dim displacementSquared_ As Long

        '                       dxx = delta_t * nodee.Force_X
        '                       dyy = delta_t * nodee.Force_Y

        '                       displacementSquared_ = dxx * dxx + dyy * dyy

        '                       If (displacementSquared_ > MAX_DISPLACEMENT_SQUARED) Then

        '                           s_ = Math.Sqrt(MAX_DISPLACEMENT_SQUARED / displacementSquared_)
        '                           dxx = dxx * s_
        '                           dyy = dyy * s_


        '                       End If


        '                       nodee.Loca = New Point(nodee.Loca.X + dxx, nodee.Loca.Y + dyy)


        '                   End Sub)

        For i = 0 To N - 1
            node = listofnodes.Item(i)

            dx = delta_t * node.Force_X
            dy = delta_t * node.Force_Y

            displacementSquared = dx * dx + dy * dy

            If (displacementSquared > MAX_DISPLACEMENT_SQUARED) Then

                s = Math.Sqrt(MAX_DISPLACEMENT_SQUARED / displacementSquared)
                dx = dx * s
                dy = dy * s


            End If


            node.Loca = New Point(node.Loca.X + dx, node.Loca.Y + dy)




            'If node.Loca.X > Me.Width Then ' <============================================================================================-
            '    node.Loca = New Point(node.Loca.X - dx, node.Loca.Y)
            'End If


            'If node.Loca.Y > Me.Height Then
            '    node.Loca = New Point(node.Loca.X, node.Loca.Y - dy)

            'End If

            'If node.Loca.Y < 0 Then
            '    node.Loca = New Point(node.Loca.X, 0 + dy)
            'End If

            'If node.Loca.X < 0 Then
            '    node.Loca = New Point(0 + dx, node.Loca.Y)
            'End If



            'g.FillEllipse(myBrush, New Rectangle(node.Loca.X, node.Loca.Y, 20, 20))
            'loc()
        Next

        myT.Stop()
        Console.WriteLine(myT.Elapsed.ToString)

    End Sub

    'Private Sub BackgroundWorker3_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
    '    BackgroundWorker3.RunWorkerAsync()
    'End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If Worker1_Runs = False Then Exit Sub
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        If Worker2_Runs = False Then Exit Sub
        BackgroundWorker2.RunWorkerAsync()
    End Sub

    Dim selectedtxtbtn As String
    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        Parallel.For(0, N, Sub(i) ' overlapping error , fixed lol
                               If e.Location.X <= listofnodes(i).Loca.X + listofnodes(i).Size.Width + Navigate_Plus.X AndAlso e.Location.X >= listofnodes(i).Loca.X + Navigate_Plus.X Then
                                   If e.Location.Y <= listofnodes(i).Loca.Y + listofnodes(i).Size.Height + Navigate_Plus.Y AndAlso e.Location.Y >= listofnodes(i).Loca.Y + Navigate_Plus.Y Then

                                       selectedtxtbtn = listofnodes(i).Text
                                       ' End SyncLock

                                   End If
                               End If
                           End Sub)
        'MsgBox(Connections)
        Me.Text = "Selected Button: " & selectedtxtbtn
        'MsgBox(Connections)
    End Sub



    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        move_Down = False

        If e.Button = MouseButtons.Right Then
            myPen.Width = 3

            'Add Control

            ' Me.Controls.Add(New myButton With {.Name = "myButton" & N + 1, .Text = N + 1, .Size = New Drawing.Size(30, 30), .Anchor = Nothing, .Location = New Point(Me.Width / 2, Me.Height / 2), .BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255))})  '+ 31 * i
            ' listofnodes.Add(listofnodes.Item(N))
            N += 1
        Else
            If Not selectd = -1 Then


                selectd = -1

            Else
                Navigate = New Point(Navigate_Plus.X, Navigate_Plus.Y)
            End If

        End If

    End Sub


    Dim Navigate As Point = New Point(0,0)
    Dim Navigate_Plus As Point = New Point(0, 0)
    Dim Navigate_Mouse_Hover As Point = New Point(0, 0)


    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If move_Down = True Then
            If selectd = -1 Then
                Me.Text = e.X - Navigate_Minus.X
                Navigate_Plus = New Point(e.X - Navigate_Minus.X + Navigate.X, e.Y - Navigate_Minus.Y + Navigate.Y)
            Else
                'Navigate_Plus_2
                'move_Down = False
                'Me.Text = (listofnodes(selectd).Loca.X + e.X)

                listofnodes(selectd).Loca = New Point(e.X - Navigate_Plus.X, e.Y - Navigate_Plus.Y)
                Navigate_Mouse_Hover = listofnodes(selectd).Loca
            End If


        End If
    End Sub

    Dim a_Col As Integer
    Private Sub TrackBar4_Scroll(sender As Object, e As EventArgs) Handles TrackBar4.Scroll
        a_Col = TrackBar4.Value
    End Sub

    Dim move_Down As Boolean = False
    Dim Navigate_Minus As Point = New Point(0, 0)
    Dim selectd As Integer = -1

    Dim hide_btns As Boolean = False
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then hide_btns = True Else hide_btns = False

    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            Navigate_Minus = New Point(e.X, e.Y)

            If move_Down = False Then

                Parallel.For(0, N, Sub(i) ' overlapping error , fixed lol
                                       If e.Location.X <= listofnodes(i).Loca.X + listofnodes(i).Size.Width + Navigate_Plus.X AndAlso e.Location.X >= listofnodes(i).Loca.X + Navigate_Plus.X Then
                                           If e.Location.Y <= listofnodes(i).Loca.Y + listofnodes(i).Size.Height + Navigate_Plus.Y AndAlso e.Location.Y >= listofnodes(i).Loca.Y + Navigate_Plus.Y Then

                                               selectd = i
                                               ' End SyncLock

                                           End If
                                       End If
                                   End Sub)


            End If



            move_Down = True

            If Not selectd = -1 Then ' because of first run , mousedown false
                Navigate_Mouse_Hover = listofnodes(selectd).Loca
            End If
        End If


    End Sub

    Private Sub Form1_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        'If move_Down = True And Not selectd = -1 Then
        '    listofnodes(selectd).Loca = New Point(Exception. - Navigate_Plus.X, e.Y - Navigate_Plus.Y)
        'End If
    End Sub

    Private Sub Form1_ResizeBegin(sender As Object, e As EventArgs) Handles Me.ResizeBegin
        BackgroundWorker1.CancelAsync()
        BackgroundWorker2.CancelAsync()

        Worker2_Runs = False
        Worker1_Runs = False

    End Sub

    Private Sub Form1_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        BackgroundWorker1.RunWorkerAsync()
        BackgroundWorker2.RunWorkerAsync()
        Worker2_Runs = True
        Worker1_Runs = True
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        ' BackgroundWorker1.Dispose()
        'BackgroundWorker2.Dispose()
        ' BackgroundWorker2.CancelAsync()

    End Sub
End Class




''timer

'' Timer1.Enabled = False
'For Each btn1 As Button In Me.Controls.OfType(Of Button)

'For Each btn2 As Button In Me.Controls.OfType(Of Button)
''Me.Text = btn1.Text & " "  &  Math.Abs(btn1.Location.X - btn2.Location.X)
''Me.Text = btn1.Text & " " & btn2.Text & " " & Math.Abs(btn1.Location.X - btn2.Location.X)
''Label1.Text &= btn1.Text & " " & btn2.Text & " " & Math.Abs(btn1.Location.X - btn2.Location.X) & vbNewLine
'Dim dif As Integer = Math.Abs(btn1.Location.X - btn2.Location.X)

'If Not dif > 50 Then
'Me.Text = dif
'g.Clear(Color.White)
''left
'If btn1.Location.X - btn2.Location.X < 0 Then


'btn1.Location = New Point(btn1.Location.X - 1, btn1.Location.Y)

'g.DrawLine(myPen, btn1.Location.X + 10, btn1.Location.Y + 10, btn2.Location.X + 10, btn2.Location.Y + 10)

'ElseIf Not dif = 0 Then 'right 

'btn1.Location = New Point(btn1.Location.X + 1, btn1.Location.Y)

'g.DrawLine(myPen, btn1.Location.X + 10, btn1.Location.Y + 10, btn2.Location.X + 10, btn2.Location.Y + 10)


'End If

'End If

'Dim dif2 As Integer = Math.Abs(btn1.Location.Y - btn2.Location.Y)

'If Not dif2 > 50 Then

'g.Clear(Color.White)
''left
'If btn1.Location.X - btn2.Location.X < 0 Then


'btn1.Location = New Point(btn1.Location.X, btn1.Location.Y - 1)

'g.DrawLine(myPen, btn1.Location.X + 10, btn1.Location.Y + 10, btn2.Location.X + 10, btn2.Location.Y + 10)

'ElseIf Not dif2 = 0 Then 'right 

'btn1.Location = New Point(btn1.Location.X, btn1.Location.Y + 1)

'g.DrawLine(myPen, btn1.Location.X + 10, btn1.Location.Y + 10, btn2.Location.X + 10, btn2.Location.Y + 10)

'' Else

'End If

'End If

'If (Not btn1 Is btn2 And btn1.Location.X = btn2.Location.X And btn1.Location.Y = btn2.Location.Y) = True Then
'If b = True Then
'btn1.Location = New Point(btn1.Location.X + 1, btn1.Location.Y + 1)

'b = False
'Else
'btn1.Location = New Point(btn1.Location.X - 1, btn1.Location.Y - 1)

'b = True
'End If
'btn1.Location = New Point(btn1.Location.X + 1, btn1.Location.Y + 1)

'g.DrawLine(myPen, btn1.Location.X + 10, btn1.Location.Y + 10, btn2.Location.X + 10, btn2.Location.Y + 10)

'End If
'Next
'Next











'Dim Net As List(Of String) = New List(Of String)
'Dim PureKnow As List(Of Button) = New List(Of Button)
'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


'    create_Random_List_Object()


'End Sub


'Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
'    create_Random_List_Object()
'End Sub

'Private Sub create_Random_List_Object()
'    Dim random As New Random()

'    'MsgBox(Chr(64).ToString)

'    Me.Controls.Clear()
'    PureKnow.Clear()

'    Me.Controls.Add(Label1)

'    Dim range As Size = Me.Size

'    Label1.Text = ""


'    For i As Integer = 0 To 25
'        PureKnow.Add(New Button With {.Text = Chr(i + 65).ToString, .Tag = " -> " & Chr(random.Next(65, 70)).ToString & "," & Chr(random.Next(70, 75)).ToString & "," & Chr(random.Next(75, 80)).ToString & " .", .Anchor = Nothing, .Size = New Size(50, 50), .Location = New Point((Me.Size.Width / 2) - (.Size.Width / 2) - 10, (Me.Size.Height / 2) - (.Size.Height / 2) - 17)})
'        'Net.Add(Chr(i + 65).ToString & " -> " & Chr(random.Next(65, 80)).ToString & " " & Convert.ToString(random.Next(1, 30)))

'        'Label1.Text &= Net(i) & vbNewLine



'        Me.Controls.Add(PureKnow(i))
'    Next

'    For i As Integer = 97 To 122
'        PureKnow.Add(New Button With {.Text = Chr(i).ToString, .Tag = " -> " & Chr(random.Next(97, 102)).ToString & "," & Chr(random.Next(70, 75)).ToString & "," & Chr(random.Next(102, 122)).ToString & " .", .Anchor = Nothing, .Size = New Size(50, 50), .Location = New Point((Me.Size.Width / 2) - (.Size.Width / 2) - 10, (Me.Size.Height / 2) - (.Size.Height / 2) - 17)})
'        'Net.Add(Chr(i + 65).ToString & " -> " & Chr(random.Next(65, 80)).ToString & " " & Convert.ToString(random.Next(1, 30)))

'        'Label1.Text &= Net(i) & vbNewLine



'        Me.Controls.Add(PureKnow(i - 72))
'    Next

'    '97 122

'    Dim max = 0, min = 51
'    Dim b As Integer = 0
'    For i = 0 To 51
'        For j = 0 To 51
'            If Not i = j Then
'                If PureKnow(j).Tag.contains(PureKnow(i).Text) Then
'                    b += 1
'                End If
'            End If


'        Next

'        If b < min Then min = b
'        If b > max Then max = b

'        PureKnow(i).Tag &= b
'        Label1.Text &= PureKnow(i).Text & PureKnow(i).Tag & vbNewLine
'        b = 0

'    Next

'    MsgBox(min & " " & max)

'    Dim individual_Size_Max = 100

'    'PureKnow(1).Location = New Point(200, 200)

'    'sort
'    'MsgBox(PureKnow(0).Tag.Remove(0, 11))

'    'PureKnow = PureKnow.OrderBy(Function(x) x.Tag.Remove(0, 11)).ToList
'    PureKnow.Sort(Function(x, y) Int(y.Tag.Remove(0, 11)).CompareTo(Int(x.Tag.Remove(0, 11))))

'    'PureKnow.Sort(Name)
'    Label1.Text = ""
'    For i = 0 To 51
'        Label1.Text &= PureKnow(i).Text & PureKnow(i).Tag & vbNewLine
'    Next


'End Sub




''Dim N As Integer = 10
''Dim dx As Integer = 10
''Dim dy As Integer = 10
''Dim fx As Integer = 10
''Dim fy As Integer = 10

''Dim distanceSquared As Integer = 0
''Dim distance As Integer = 0
''Dim displacementSquared As Integer

''Sub test()

''    For i1 = 0 To N - 2

''        node1 = Nodes[i1]

''        For i2 = i1 + 1 To N - 1

''            node2 = Nodes[i2]
''            dx = node2.x - node1.x
''            dy = node2.y - node1.y

''            If Not dx = 0 Or Not dy = 0 Then
''                distanceSquared = dx * dx + dy * dy
''                distance = sqrt(distanceSquared)
''                force = K_r / distanceSquared
''                fx = force * dx / distance
''                fy = force * dy / distance
''                node1.force_x = node1.force_x - fx
''                node1.force_y = node1.force_y - fy
''                node2.force_x = node2.force_x + fx
''                node2.force_y = node2.force_y + fy
''            End If

''        Next
''    Next

''    ' spring force between adjacent pairs
''    For i1 = 0 To N - 1

''        node1 = Nodes[i1] 

''        For j = 0 To node1.neighbors.length - 1
''            i2 = node1.neighbors[j]
''            node2 = Nodes[i2]

''            If i1 < i2 Then

''                dx = node2.x - node1.x
''                dy = node2.y - node1.y

''                If dx! = 0 Or dy! = 0 Then
''                    distance = sqrt(dx * dx + dy * dy)
''                    force = K_s * (distance - L)
''                    fx = force * dx / distance
''                    fy = force * dy / distance
''                    node1.force_x = node1.force_x + fx
''                    node1.force_y = node1.force_y + fy
''                    node2.force_x = node2.force_x - fx
''                    node2.force_y = node2.force_y - fy
''                End If

''            End If

''        Next
''    Next

''    ' update positions
''    For i = 0 To N - 1

''        node = Nodes[i]     
''        dx = delta_t * node.force_x
''        dy = delta_t * node.force_y
''        displacementSquared = dx * dx + dy * dy

''        If (displacementSquared > MAX_DISPLACEMENT_SQUARED) Then
''            s = sqrt(MAX_DISPLACEMENT_SQUARED / displacementSquared)
''            dx = dx * s
''            dy = dy * s
''        End If

''        node.x = node.x + dx
''        node.y = node.y + dy

''    Next


''End Sub


'Public Class Form1

'    Dim myPen As Pen = New Pen(Color.Red)
'    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        g = Me.CreateGraphics

'        myPen.Width = 1
'        Label1.Text = ""

'        Dim i As Integer = 0
'        For Each btn1 As Button In Me.Controls.OfType(Of Button)
'            btn1.Location = New Point(btn1.Location.X + btn1.Size.Width * i, btn1.Location.Y)


'            i += 1
'        Next
'        'Timer1.Enabled = False
'    End Sub

'    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
'        Dim btn1 As Button = Button1
'        btn1.Location = New Point(btn1.Location.X - 100, btn1.Location.Y - 100)
'        ' MsgBox(Button7.Location.ToString & vbNewLine & Button4.Location.ToString & vbNewLine & Button5.Location.ToString)
'        'g.DrawLine(myPen, btn1.Location.X + 10, btn1.Location.Y + 10, btn2.Location.X + 10, btn2.Location.Y + 10)

'    End Sub
'    Dim g As Graphics


'    Dim range As Integer = 300
'    Dim b As Boolean = False

'    'if colaide do loop ?

'    Private Function connected(bt1 As Button, bt2 As Button)
'        Dim a As Boolean = False

'        ' 1 - 5 - 2
'        ' 1 - 2 - 9





'        If (bt1.Text = "1" And bt2.Text = "5") Or (bt1.Text = "5" And bt2.Text = "1") Or
'            (bt1.Text = "2" And bt2.Text = "5") Or (bt1.Text = "5" And bt2.Text = "2") Or
'            (bt1.Text = "2" And bt2.Text = "1") Or (bt1.Text = "1" And bt2.Text = "2") Or
'            (bt1.Text = "9" And bt2.Text = "2") Or (bt1.Text = "2" And bt2.Text = "9") Or
'            (bt1.Text = "9" And bt2.Text = "5") Or (bt1.Text = "5" And bt2.Text = "9") Or
'            (bt1.Text = "1" And bt2.Text = "6") Or (bt1.Text = "6" And bt2.Text = "1") Or
'            (bt1.Text = "4" And bt2.Text = "8") Or (bt1.Text = "8" And bt2.Text = "4") Or
'            (bt1.Text = "4" And bt2.Text = "12") Or (bt1.Text = "12" And bt2.Text = "4") Or
'            (bt1.Text = "8" And bt2.Text = "12") Or (bt1.Text = "12" And bt2.Text = "8") Then
'            a = True
'            ' bt1.Enabled = False
'            ' bt2.Enabled = False

'        End If
'        Return a
'    End Function

'    Dim rememb1 As Button
'    Dim rememb2 As Button

'    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

'        '

'        For Each btn1 As Button In Me.Controls.OfType(Of Button)
'            For Each btn2 As Button In Me.Controls.OfType(Of Button)
'                If Not btn1 Is btn2 Then

'                    Dim dif1 As Integer = btn1.Location.X - btn2.Location.X
'                    Dim dif2 As Integer = btn1.Location.Y - btn2.Location.Y

'                    range = 300

'                    If Not connected(btn1, btn2) Then ' And btn1.Enabled = True Or btn2.Enabled = True



'                        If Not Math.Abs(dif1) + Math.Abs(dif2) > range Then

'                            ' g.Clear(Color.White)


'                            If dif1 > 0 Then
'                                If dif2 > 0 Then

'                                    btn1.Location = New Point(btn1.Location.X + 1, btn1.Location.Y + 1)

'                                    g.DrawLine(myPen, btn1.Location.X + 10, btn1.Location.Y + 10, btn2.Location.X + 10, btn2.Location.Y + 10)
'                                Else
'                                    btn1.Location = New Point(btn1.Location.X + 1, btn1.Location.Y - 1)

'                                    g.DrawLine(myPen, btn1.Location.X + 10, btn1.Location.Y + 10, btn2.Location.X + 10, btn2.Location.Y + 10)
'                                End If
'                            Else
'                                If dif2 > 0 Then
'                                    btn1.Location = New Point(btn1.Location.X - 1, btn1.Location.Y + 1)

'                                    g.DrawLine(myPen, btn1.Location.X + 10, btn1.Location.Y + 10, btn2.Location.X + 10, btn2.Location.Y + 10)
'                                Else
'                                    btn1.Location = New Point(btn1.Location.X - 1, btn1.Location.Y - 1)

'                                    g.DrawLine(myPen, btn1.Location.X + 10, btn1.Location.Y + 10, btn2.Location.X + 10, btn2.Location.Y + 10)
'                                End If
'                            End If

'                        End If

'                    Else

'                        Do
'                            dif1 = btn1.Location.X - btn2.Location.X
'                            dif2 = btn1.Location.Y - btn2.Location.Y
'                            Dim chdif As Integer = Math.Abs(dif1) + Math.Abs(dif2)

'                            If Not chdif > 50 Then

'                                'g.Clear(Color.White)

'                                If dif1 > 0 Then
'                                    If dif2 > 0 Then

'                                        btn1.Location = New Point(btn1.Location.X + 1, btn1.Location.Y + 1)

'                                        g.DrawLine(myPen, btn1.Location.X + 10, btn1.Location.Y + 10, btn2.Location.X + 10, btn2.Location.Y + 10)
'                                    Else
'                                        btn1.Location = New Point(btn1.Location.X + 1, btn1.Location.Y - 1)

'                                        g.DrawLine(myPen, btn1.Location.X + 10, btn1.Location.Y + 10, btn2.Location.X + 10, btn2.Location.Y + 10)
'                                    End If
'                                Else
'                                    If dif2 > 0 Then
'                                        btn1.Location = New Point(btn1.Location.X - 1, btn1.Location.Y + 1)

'                                        g.DrawLine(myPen, btn1.Location.X + 10, btn1.Location.Y + 10, btn2.Location.X + 10, btn2.Location.Y + 10)
'                                    Else
'                                        btn1.Location = New Point(btn1.Location.X - 1, btn1.Location.Y - 1)

'                                        g.DrawLine(myPen, btn1.Location.X + 10, btn1.Location.Y + 10, btn2.Location.X + 10, btn2.Location.Y + 10)
'                                    End If
'                                End If

'                            ElseIf chdif > 52 Then
'                                'g.Clear(Color.White)

'                                If dif1 > 0 Then
'                                    If dif2 > 0 Then

'                                        btn1.Location = New Point(btn1.Location.X - 1, btn1.Location.Y - 1)

'                                        g.DrawLine(myPen, btn1.Location.X + 10, btn1.Location.Y + 10, btn2.Location.X + 10, btn2.Location.Y + 10)
'                                    Else
'                                        btn1.Location = New Point(btn1.Location.X - 1, btn1.Location.Y + 1)

'                                        g.DrawLine(myPen, btn1.Location.X + 10, btn1.Location.Y + 10, btn2.Location.X + 10, btn2.Location.Y + 10)
'                                    End If
'                                Else
'                                    If dif2 > 0 Then
'                                        btn1.Location = New Point(btn1.Location.X + 1, btn1.Location.Y - 1)

'                                        g.DrawLine(myPen, btn1.Location.X + 10, btn1.Location.Y + 10, btn2.Location.X + 10, btn2.Location.Y + 10)
'                                    Else
'                                        btn1.Location = New Point(btn1.Location.X + 1, btn1.Location.Y + 1)

'                                        g.DrawLine(myPen, btn1.Location.X + 10, btn1.Location.Y + 10, btn2.Location.X + 10, btn2.Location.Y + 10)
'                                    End If
'                                End If
'                            Else
'                                '  btn1.Enabled = True
'                                '  btn2.Enabled = True
'                                Exit Do
'                            End If
'                        Loop
'                    End If
'                End If


'            Next
'        Next

'        '

'    End Sub

'    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)

'        'g.DrawLine(myPen, 100, 100, 45, 65)
'    End Sub
'End Class


'https://docs.microsoft.com/en-us/previous-versions/windows/desktop/bb295952(v%3dvs.85)