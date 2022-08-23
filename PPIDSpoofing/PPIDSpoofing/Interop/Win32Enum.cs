﻿using System;

namespace PPIDSpoofing.Interop
{
    [Flags]
    internal enum FormatMessageFlags : uint
    {
        FORMAT_MESSAGE_ALLOCATE_BUFFER = 0x00000100,
        FORMAT_MESSAGE_IGNORE_INSERTS = 0x00000200,
        FORMAT_MESSAGE_FROM_STRING = 0x00000400,
        FORMAT_MESSAGE_FROM_HMODULE = 0x00000800,
        FORMAT_MESSAGE_FROM_SYSTEM = 0x00001000,
        FORMAT_MESSAGE_ARGUMENT_ARRAY = 0x00002000
    }

    [Flags]
    internal enum ProcessAccessFlags : uint
    {
        PROCESS_ALL_ACCESS = 0x001F0FFF,
        Terminate = 0x00000001,
        PROCESS_CREATE_THREAD = 0x00000002,
        PROCESS_VM_OPERATION = 0x00000008,
        PROCESS_VM_READ = 0x00000010,
        PROCESS_VM_WRITE = 0x00000020,
        PROCESS_DUP_HANDLE = 0x00000040,
        PROCESS_CREATE_PROCESS = 0x000000080,
        PROCESS_SET_QUOTA = 0x00000100,
        PROCESS_SET_INFORMATION = 0x00000200,
        PROCESS_QUERY_INFORMATION = 0x00000400,
        PROCESS_QUERY_LIMITED_INFORMATION = 0x00001000,
        SYNCHRONIZE = 0x00100000,
        MAXIMUM_ALLOWED = 0x02000000
    }

    [Flags]
    internal enum ProcessCreationFlags : uint
    {
        DEBUG_PROCESS = 0x00000001,
        DEBUG_ONLY_THIS_PROCESS = 0x00000002,
        CREATE_SUSPENDED = 0x00000004,
        DETACHED_PROCESS = 0x00000008,
        CREATE_NEW_CONSOLE = 0x00000010,
        CREATE_NEW_PROCESS_GROUP = 0x00000200,
        CREATE_UNICODE_ENVIRONMENT = 0x00000400,
        CREATE_SEPARATE_WOW_VDM = 0x00000800,
        CREATE_SHARED_WOW_VDM = 0x00001000,
        INHERIT_PARENT_AFFINITY = 0x00010000,
        CREATE_PROTECTED_PROCESS = 0x00040000,
        EXTENDED_STARTUPINFO_PRESENT = 0x00080000,
        CREATE_BREAKAWAY_FROM_JOB = 0x01000000,
        CREATE_PRESERVE_CODE_AUTHZ_LEVEL = 0x02000000,
        CREATE_DEFAULT_ERROR_MODE = 0x04000000,
        CREATE_NO_WINDOW = 0x08000000,
    }

    internal enum PROC_THREAD_ATTRIBUTES
    {
        PROC_THREAD_ATTRIBUTE_GROUP_AFFINITY = 0x00030003,
        PROC_THREAD_ATTRIBUTE_HANDLE_LIST = 0x00020002,
        PROC_THREAD_ATTRIBUTE_IDEAL_PROCESSOR = 0x00030005,
        PROC_THREAD_ATTRIBUTE_MITIGATION_POLICY = 0x00020007,
        PROC_THREAD_ATTRIBUTE_PARENT_PROCESS = 0x00020000,
        PROC_THREAD_ATTRIBUTE_PREFERRED_NODE = 0x00020004,
        PROC_THREAD_ATTRIBUTE_UMS_THREAD = 0x00030006,
        PROC_THREAD_ATTRIBUTE_SECURITY_CAPABILITIES = 0x00020009,
        PROC_THREAD_ATTRIBUTE_PROTECTION_LEVEL = 0x0002000B,
        PROC_THREAD_ATTRIBUTE_CHILD_PROCESS_POLICY = 0x0002000E,
        PROC_THREAD_ATTRIBUTE_DESKTOP_APP_POLICY = 0x00020012,
        PROC_THREAD_ATTRIBUTE_JOB_LIST = 0x0002000D,
        PROC_THREAD_ATTRIBUTE_ENABLE_OPTIONAL_XSTATE_FEATURES = 0x0003001B
    }
}