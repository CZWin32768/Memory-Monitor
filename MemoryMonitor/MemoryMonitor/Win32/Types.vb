Imports System.Runtime.InteropServices

Public Class Types
    <StructLayout(LayoutKind.Sequential)>
    Public Structure _SYSTEM_INFO
        Dim wProcessorArchitecture As UShort
        Dim wReserved As UShort
        Dim dwPageSize As UInt32
        Dim lpMinimumApplicationAddress As UIntPtr ' 最小寻址空间
        Dim lpMaximumApplicationAddress As UIntPtr
        Dim dwActiveProcessorMask As UInt32
        Dim dwNumberOfProcessors As UInt32
        Dim dwProcessorType As UInt32
        Dim dwAllocationGranularity As UInt32      ' 虚拟内存空间的粒度
        Dim wProcessorLevel As UShort
        Dim wProcessorRevision As UShort
    End Structure
    <StructLayout(LayoutKind.Sequential)>
    Public Structure _PROCESS_MEMORY_COUNTERS
        Dim cb As UInt32
        Dim PageFaultCount As UInt32
        Dim PeakWorkingSetSize As UInt32
        Dim WorkingSetSize As UInt32
        Dim QuotaPeakPagedPoolUsage As UInt32
        Dim QuotaPagedPoolUsage As UInt32
        Dim QuotaPeakNonPagedPoolUsage As UInt32
        Dim QuotaNonPagedPoolUsage As UInt32
        Dim PagefileUsage As UInt32
        Dim PeakPagefileUsage As UInt32
    End Structure
    <StructLayout(LayoutKind.Sequential)>
    Public Structure _PROCESSENTRY32
        Dim dwSize As UInt32
        Dim cntUsage As UInt32
        Dim th32ProcessID As UInt32
        Dim th32DefaultHeapID As UInt32
        Dim th32ModuleID As UInt32
        Dim cntThreads As UInt32
        Dim th32ParentProcessID As UInt32
        Dim pcPriClassBase As Int32
        Dim dwFlags As UInt32
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)>
        Dim szExeFile As String
    End Structure
    <StructLayout(LayoutKind.Sequential)>
    Public Structure _PERFORMANCE_INFORMATION

        Dim cb As UInt32
        Dim CommitTotal As UInt32 ' 系统提交的分页数
        Dim CommitLimit As UInt32 ' 在不改变页面文件大小的情况下 分页最大提交数量
        Dim CommitPeak As UInt32 ' 上一次系统重启过后页面分页最大提交数量
        Dim PhysicalTotal As UInt32 ' 以页面数计算的物理内存总量
        Dim PhysicalAvailable As UInt32 ' 以页面数计算的可用物理内存数量
        Dim SystemCache As UInt32 ' 以页面数计算的系统缓存
        Dim KernelTotal As UInt32
        Dim KernelPaged As UInt32
        Dim KernelNonpaged As UInt32
        Dim PageSize As UInt32
        Dim HandleCount As UInt32
        Dim ProcessCount As UInt32
        Dim ThreadCount As UInt32
    End Structure
    <StructLayout(LayoutKind.Sequential)>
    Public Structure _MEMORYSTATUSEX

        Dim dwLength As UInt32
        Dim dwMemoryLoad As UInt32
        Dim ullTotalPhys As UInt64
        Dim ullAvailPhys As UInt64
        Dim ullTotalPageFile As UInt64
        Dim ullAvailPageFile As UInt64
        Dim ullTotalVirtual As UInt64
        Dim ullAvailVirtual As UInt64
        Dim ullAvailExtendedVirtual As UInt64
    End Structure
    <StructLayout(LayoutKind.Sequential)>
    Public Structure _MEMORY_BASIC_INFORMATION

        Dim BaseAddress As UIntPtr
        Dim AllocationBase As UIntPtr
        Dim AllocationProtect As UInt32
        Dim RegionSize As UInt32
        Dim State As UInt32
        Dim Protect As UInt32
        Dim Type As UInt32
    End Structure

    Public Const TH32CS_SNAPPROCESS As UInt32 = &H2
    Public Const PROCESS_QUERY_INFORMATION As UInt32 = &H400
    Public Const PROCESS_VM_READ As UInt32 = &H10

    Public Const MEM_COMMIT As UInt32 = &H1000
    Public Const MEM_FREE As UInt32 = &H10000
    Public Const MEM_RESERVE As UInt32 = &H2000

    Public Const MEM_IMAGE As UInt32 = &H1000000
    Public Const MEM_MAPPED As UInt32 = &H40000
    Public Const MEM_PRIVATE As UInt32 = &H20000

    Public Const PAGE_READONLY As UInt32 = &H2
    Public Const PAGE_GUARD As UInt32 = &H100
    Public Const PAGE_NOCACHE As UInt32 = &H200
    Public Const PAGE_READWRITE As UInt32 = &H4
    Public Const PAGE_WRITECOPY As UInt32 = &H8
    Public Const PAGE_EXECUTE As UInt32 = &H10
    Public Const PAGE_EXECUTE_READ As UInt32 = &H20
    Public Const PAGE_EXECUTE_READWRITE As UInt32 = &H40
    Public Const PAGE_EXECUTE_WRITECOPY As UInt32 = &H80
    Public Const PAGE_NOACCESS As UInt32 = &H1
End Class
