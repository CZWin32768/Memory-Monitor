Imports System.Runtime.InteropServices
Imports MemoryMonitor.Types
Imports MemoryMonitor.Win32api
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Threading
Imports System.Collections.ObjectModel

Public Class Form1
    Dim valuesY As New List(Of Double)
    Dim timer As Timer
    Dim si As _SYSTEM_INFO
    Const VAL_NUM As Integer = 100
    Const PROC_NUM As Integer = 2000
    Dim ProcMap(PROC_NUM) As _PROCESSENTRY32


    Private Sub ChartInit()
        For i = 1 To VAL_NUM
            valuesY.Add(0)
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChartInit()
        Dim ms = New _MEMORYSTATUSEX()
        ms.dwLength = Marshal.SizeOf(ms)
        GlobalMemoryStatusEx(ms)
        si = New _SYSTEM_INFO()
        GetSystemInfo(si)
        Label3.Text = "Minimum Application Address:" + CType(si.lpMinimumApplicationAddress, UInt32).ToString("X")
        Label4.Text = "Maximum Application Address:" + CType(si.lpMaximumApplicationAddress, UInt32).ToString("X")

        DataGrid_Update()

        Dim autoEvent As New AutoResetEvent(False)
        timer = New Timer(AddressOf TimerCallBack, autoEvent, 0, 500)

        Dim chartArea
        chartArea = MemoryChart.ChartAreas(0)
        chartArea.AxisX.Minimum = 0
        chartArea.AxisX.Maximum = 100
        chartArea.AxisY.Minimum = 0
        chartArea.AxisY.Maximum = ms.ullTotalPhys / 1024 / 1024
        chartArea.AxisY.Interval = 2048
        chartArea.AxisX.LabelStyle.Enabled = False
        chartArea.AxisX.MajorGrid.LineColor = Color.LightGray
        chartArea.AxisY.MajorGrid.LineColor = Color.LightGray

        MemoryChart.Series(0).ChartType = SeriesChartType.Spline
        MemoryChart.Series(0).BorderWidth = 2
        MemoryChart.Series(0).Name = "Memory in use"

    End Sub

    Private Sub TimerCallBack(stateInfo As Object)
        Dim ms = New _MEMORYSTATUSEX()
        ms.dwLength = Marshal.SizeOf(ms)
        GlobalMemoryStatusEx(ms)
        valuesY.Add((ms.ullTotalPhys - ms.ullAvailPhys) / 1024 / 1024)
        valuesY.RemoveAt(0)
        Invoke(New Action(AddressOf Chart_Update))
        Invoke(New Action(Of _MEMORYSTATUSEX)(AddressOf Label_MemUsage_Update), ms)

    End Sub

    Private Sub DataGrid_Update()
        Dim hProcessSnap = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, 0)
        Dim ProEntry32 = New _PROCESSENTRY32()
        Dim l As New List(Of _PROCESSENTRY32)
        ProEntry32.dwSize = Marshal.SizeOf(ProEntry32)
        Process32First(hProcessSnap, ProEntry32)
        Do While Process32Next(hProcessSnap, ProEntry32)
            l.Add(ProEntry32)
        Loop
        DataGridView1.Rows.Clear()
        Dim cnt = 0
        For Each p In l
            DataGridView1.Rows.Add({p.szExeFile, p.th32ProcessID, p.pcPriClassBase})
            ProcMap(cnt) = p
            cnt += 1
        Next
        CloseHandle(hProcessSnap)
    End Sub

    Private Sub Label_MemUsage_Update(ms As _MEMORYSTATUSEX)
        Dim gb = 1024 * 1024 * 1024
        Dim now = (ms.ullTotalPhys - ms.ullAvailPhys) / gb
        Dim tot = (ms.ullTotalPhys) / gb
        Label_MemUsage.Text = "Memory " + now.ToString("0.0") + "/" + tot.ToString("0.0") + " GB " + ms.dwMemoryLoad.ToString() + "%"
    End Sub

    Private Sub Chart_Update()
        MemoryChart.Series(0).Points.DataBindY(valuesY)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.CellMouseClick
        TextBox1.Text = ""
        Dim ProEntry32 = ProcMap(DataGridView1.SelectedRows(0).Index)
        Dim hProcess As UIntPtr
        hProcess = OpenProcess(PROCESS_QUERY_INFORMATION + PROCESS_VM_READ, False, ProEntry32.th32ProcessID)
        If hProcess = 0 Then
            TextBox1.Text = "open process failed."
            Return
        End If
        Dim mbi = New _MEMORY_BASIC_INFORMATION()
        Dim pBlock = si.lpMinimumApplicationAddress

        Dim txt As String = ""
        While pBlock.ToUInt32 < si.lpMaximumApplicationAddress.ToUInt32
            Dim res = VirtualQueryEx(hProcess, pBlock, mbi, Marshal.SizeOf(mbi))
            If res = 0 Then
                Exit While
            End If
            Dim pEnd As UIntPtr
            pEnd = CType(pBlock, UInt32) + CType(mbi.RegionSize, UInt32)
            txt += " " + CType(pBlock, UInt32).ToString("X") + "-" + CType(pEnd, UInt32).ToString("X") + "  "
            Select Case mbi.State
                Case MEM_COMMIT
                    txt += "Committed"
                Case MEM_FREE
                    txt += "Free"
                Case MEM_RESERVE
                    txt += "Reserved"
            End Select

            txt += "  "

            If mbi.Protect = 0 And mbi.State <> MEM_FREE Then
                mbi.Protect = PAGE_READONLY
            End If
            'show protection
            If mbi.Protect = PAGE_READONLY Then
                txt += "PAGE_READONLY"
            End If
            If mbi.Protect = PAGE_GUARD Then
                txt += "PAGE_GUARD"
            End If
            If mbi.Protect = PAGE_NOCACHE Then
                txt += "PAGE_NOCACHE"
            End If
            If mbi.Protect = PAGE_READWRITE Then
                txt += "PAGE_READWRITE"
            End If
            If mbi.Protect = PAGE_WRITECOPY Then
                txt += "PAGE_WRITECOPY"
            End If
            If mbi.Protect = PAGE_EXECUTE Then
                txt += "PAGE_EXECUTE"
            End If
            If mbi.Protect = PAGE_EXECUTE_READ Then
                txt += "PAGE_EXECUTE_READ"
            End If
            If mbi.Protect = PAGE_EXECUTE_READWRITE Then
                txt += "PAGE_EXECUTE_READWRITE"
            End If
            If mbi.Protect = PAGE_EXECUTE_WRITECOPY Then
                txt += "PAGE_EXECUTE_WRITECOPY"
            End If
            If mbi.Protect = PAGE_NOACCESS Then
                txt += "PAGE_NOACCESS"
            End If

            txt += "  "

            Select Case mbi.Type
                Case MEM_IMAGE
                    txt += "Image"
                Case MEM_MAPPED
                    txt += "Mapped"
                Case MEM_PRIVATE
                    txt += "Private"


            End Select
            txt += vbCrLf
            pBlock = pEnd
        End While
        CloseHandle(hProcess)
        TextBox1.Text = txt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGrid_Update()
    End Sub
End Class
