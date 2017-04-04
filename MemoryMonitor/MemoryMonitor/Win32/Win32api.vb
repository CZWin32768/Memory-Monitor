Imports System.Runtime.InteropServices
Imports MemoryMonitor.Types
Public Class Win32api
    <DllImport("kernel32.dll", CallingConvention:=CallingConvention.Winapi)>
    Public Shared Function CloseHandle(ByVal handle As UIntPtr) As Boolean
    End Function
    <DllImport("kernel32.dll", CallingConvention:=CallingConvention.Winapi)>
    Public Shared Function GetSystemInfo(ByRef lpSystemInfo As _SYSTEM_INFO) As UInt32
    End Function
    <DllImport("kernel32.dll", CallingConvention:=CallingConvention.Winapi)>
    Public Shared Function GlobalMemoryStatusEx(ByRef lpBuffer As _MEMORYSTATUSEX) As Boolean
    End Function
    <DllImport("kernel32.dll", CallingConvention:=CallingConvention.Winapi)>
    Public Shared Function CreateToolhelp32Snapshot(ByVal dwFlags As UInt32, ByVal processID As UInt32) As UIntPtr
    End Function
    <DllImport("kernel32.dll", CallingConvention:=CallingConvention.Winapi)>
    Public Shared Function Process32First(ByVal hSnapshot As UIntPtr, ByRef llpe As _PROCESSENTRY32) As Boolean
    End Function
    <DllImport("kernel32.dll", CallingConvention:=CallingConvention.Winapi)>
    Public Shared Function Process32Next(ByVal hSnapshot As UIntPtr, ByRef llpe As _PROCESSENTRY32) As Boolean
    End Function
    <DllImport("kernel32.dll", CallingConvention:=CallingConvention.Winapi)>
    Public Shared Function VirtualQueryEx(ByVal hProcess As UIntPtr, ByVal lpAddress As UIntPtr, ByRef lpBuffer As _MEMORY_BASIC_INFORMATION, ByVal dwLength As UInt32) As UInt32
    End Function
    <DllImport("kernel32.dll", CallingConvention:=CallingConvention.Winapi)>
    Public Shared Function OpenProcess(ByVal dwDesiredAccess As UInt32, ByVal bInheriteHandle As Boolean, ByVal dwProcessID As UInt32) As UIntPtr
    End Function
End Class
