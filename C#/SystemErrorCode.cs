using System.ComponentModel;

/// <summary>
/// List of system error codes.
/// </summary>
public enum SystemErrorCode : int
{
    [Description("The operation completed successfully.")]
    ERROR_SUCCESS = 0,
    [Description("Incorrect function.")]
    ERROR_INVALID_FUNCTION = 1,
    [Description("The system cannot find the file specified.")]
    ERROR_FILE_NOT_FOUND = 2,
    [Description("The system cannot find the path specified.")]
    ERROR_PATH_NOT_FOUND = 3,
    [Description("The system cannot open the file.")]
    ERROR_TOO_MANY_OPEN_FILES = 4,
    [Description("Access is denied.")]
    ERROR_ACCESS_DENIED = 5,
    [Description("The handle is invalid.")]
    ERROR_INVALID_HANDLE = 6,
    [Description("The storage control blocks were destroyed.")]
    ERROR_ARENA_TRASHED = 7,
    [Description("Not enough storage is available to process this command.")]
    ERROR_NOT_ENOUGH_MEMORY = 8,
    [Description("The storage control block address is invalid.")]
    ERROR_INVALID_BLOCK = 9,
    [Description("The environment is incorrect.")]
    ERROR_BAD_ENVIRONMENT = 10,
    [Description("An attempt was made to load a program with an incorrect format.")]
    ERROR_BAD_FORMAT = 11,
    [Description("The access code is invalid.")]
    ERROR_INVALID_ACCESS = 12,
    [Description("The data is invalid.")]
    ERROR_INVALID_DATA = 13,
    [Description("Not enough storage is available to complete this operation.")]
    ERROR_OUTOFMEMORY = 14,
    [Description("The system cannot find the drive specified.")]
    ERROR_INVALID_DRIVE = 15,
    [Description("The directory cannot be removed.")]
    ERROR_CURRENT_DIRECTORY = 16,
    [Description("The system cannot move the file to a different disk drive.")]
    ERROR_NOT_SAME_DEVICE = 17,
    [Description("There are no more files.")]
    ERROR_NO_MORE_FILES = 18,
    [Description("The media is write protected.")]
    ERROR_WRITE_PROTECT = 19,
    [Description("The system cannot find the device specified.")]
    ERROR_BAD_UNIT = 20,
    [Description("The device is not ready.")]
    ERROR_NOT_READY = 21,
    [Description("The device does not recognize the command.")]
    ERROR_BAD_COMMAND = 22,
    [Description("Data error (cyclic redundancy check).")]
    ERROR_CRC = 23,
    [Description("The program issued a command but the command length is incorrect.")]
    ERROR_BAD_LENGTH = 24,
    [Description("The drive cannot locate a specific area or track on the disk.")]
    ERROR_SEEK = 25,
    [Description("The specified disk or diskette cannot be accessed.")]
    ERROR_NOT_DOS_DISK = 26,
    [Description("The drive cannot find the sector requested.")]
    ERROR_SECTOR_NOT_FOUND = 27,
    [Description("The printer is out of paper.")]
    ERROR_OUT_OF_PAPER = 28,
    [Description("The system cannot write to the specified device.")]
    ERROR_WRITE_FAULT = 29,
    [Description("The system cannot read from the specified device.")]
    ERROR_READ_FAULT = 30,
    [Description("A device attached to the system is not functioning.")]
    ERROR_GEN_FAILURE = 31,
    [Description("The process cannot access the file because it is being used by another process.")]
    ERROR_SHARING_VIOLATION = 32,
    [Description("The process cannot access the file because another process has locked a portion of the file.")]
    ERROR_LOCK_VIOLATION = 33,
    [Description("The wrong diskette is in the drive. Insert %2 (Volume Serial Number: %3) into drive %1.")]
    ERROR_WRONG_DISK = 34,
    [Description("Too many files opened for sharing.")]
    ERROR_SHARING_BUFFER_EXCEEDED = 36,
    [Description("Reached the end of the file.")]
    ERROR_HANDLE_EOF = 38,
    [Description("The disk is full.")]
    ERROR_HANDLE_DISK_FULL = 39,
    [Description("The request is not supported.")]
    ERROR_NOT_SUPPORTED = 50,
    [Description("Windows cannot find the network path. Verify that the network path is correct and the destination computer is not busy or turned off. If Windows still cannot find the network path, contact your network administrator.")]
    ERROR_REM_NOT_LIST = 51,
    [Description("You were not connected because a duplicate name exists on the network. If joining a domain, go to System in Control Panel to change the computer name and try again. If joining a workgroup, choose another workgroup name.")]
    ERROR_DUP_NAME = 52,
    [Description("The network path was not found.")]
    ERROR_BAD_NETPATH = 53,
    [Description("The network is busy.")]
    ERROR_NETWORK_BUSY = 54,
    [Description("The specified network resource or device is no longer available.")]
    ERROR_DEV_NOT_EXIST = 55,
    [Description("The network BIOS command limit has been reached.")]
    ERROR_TOO_MANY_CMDS = 56,
    [Description("A network adapter hardware error occurred.")]
    ERROR_ADAP_HDW_ERR = 57,
    [Description("The specified server cannot perform the requested operation.")]
    ERROR_BAD_NET_RESP = 58,
    [Description("An unexpected network error occurred.")]
    ERROR_UNEXP_NET_ERR = 59,
    [Description("The remote adapter is not compatible.")]
    ERROR_BAD_REM_ADAP = 60,
    [Description("The printer queue is full.")]
    ERROR_PRINTQ_FULL = 61,
    [Description("Space to store the file waiting to be printed is not available on the server.")]
    ERROR_NO_SPOOL_SPACE = 62,
    [Description("Your file waiting to be printed was deleted.")]
    ERROR_PRINT_CANCELLED = 63,
    [Description("The specified network name is no longer available.")]
    ERROR_NETNAME_DELETED = 64,
    [Description("Network access is denied.")]
    ERROR_NETWORK_ACCESS_DENIED = 65,
    [Description("The network resource type is not correct.")]
    ERROR_BAD_DEV_TYPE = 66,
    [Description("The network name cannot be found.")]
    ERROR_BAD_NET_NAME = 67,
    [Description("The name limit for the local computer network adapter card was exceeded.")]
    ERROR_TOO_MANY_NAMES = 68,
    [Description("The network BIOS session limit was exceeded.")]
    ERROR_TOO_MANY_SESS = 69,
    [Description("The remote server has been paused or is in the process of being started.")]
    ERROR_SHARING_PAUSED = 70,
    [Description("No more connections can be made to this remote computer at this time because there are already as many connections as the computer can accept.")]
    ERROR_REQ_NOT_ACCEP = 71,
    [Description("The specified printer or disk device has been paused.")]
    ERROR_REDIR_PAUSED = 72,
    [Description("The file exists.")]
    ERROR_FILE_EXISTS = 80,
    [Description("The directory or file cannot be created.")]
    ERROR_CANNOT_MAKE = 82,
    [Description("Fail on INT 24.")]
    ERROR_FAIL_I24 = 83,
    [Description("Storage to process this request is not available.")]
    ERROR_OUT_OF_STRUCTURES = 84,
    [Description("The local device name is already in use.")]
    ERROR_ALREADY_ASSIGNED = 85,
    [Description("The specified network password is not correct.")]
    ERROR_INVALID_PASSWORD = 86,
    [Description("The parameter is incorrect.")]
    ERROR_INVALID_PARAMETER = 87,
    [Description("A write fault occurred on the network.")]
    ERROR_NET_WRITE_FAULT = 88,
    [Description("The system cannot start another process at this time.")]
    ERROR_NO_PROC_SLOTS = 89,
    [Description("Cannot create another system semaphore.")]
    ERROR_TOO_MANY_SEMAPHORES = 100,
    [Description("The exclusive semaphore is owned by another process.")]
    ERROR_EXCL_SEM_ALREADY_OWNED = 101,
    [Description("The semaphore is set and cannot be closed.")]
    ERROR_SEM_IS_SET = 102,
    [Description("The semaphore cannot be set again.")]
    ERROR_TOO_MANY_SEM_REQUESTS = 103,
    [Description("Cannot request exclusive semaphores at interrupt time.")]
    ERROR_INVALID_AT_INTERRUPT_TIME = 104,
    [Description("The previous ownership of this semaphore has ended.")]
    ERROR_SEM_OWNER_DIED = 105,
    [Description("Insert the diskette for drive %1.")]
    ERROR_SEM_USER_LIMIT = 106,
    [Description("The program stopped because an alternate diskette was not inserted.")]
    ERROR_DISK_CHANGE = 107,
    [Description("The disk is in use or locked by another process.")]
    ERROR_DRIVE_LOCKED = 108,
    [Description("The pipe has been ended.")]
    ERROR_BROKEN_PIPE = 109,
    [Description("The system cannot open the device or file specified.")]
    ERROR_OPEN_FAILED = 110,
    [Description("The file name is too long.")]
    ERROR_BUFFER_OVERFLOW = 111,
    [Description("There is not enough space on the disk.")]
    ERROR_DISK_FULL = 112,
    [Description("No more internal file identifiers available.")]
    ERROR_NO_MORE_SEARCH_HANDLES = 113,
    [Description("The target internal file identifier is incorrect.")]
    ERROR_INVALID_TARGET_HANDLE = 114,
    [Description("The IOCTL call made by the application program is not correct.")]
    ERROR_INVALID_CATEGORY = 117,
    [Description("The verify-on-write switch parameter value is not correct.")]
    ERROR_INVALID_VERIFY_SWITCH = 118,
    [Description("The system does not support the command requested.")]
    ERROR_BAD_DRIVER_LEVEL = 119,
    [Description("This function is not supported on this system.")]
    ERROR_CALL_NOT_IMPLEMENTED = 120,
    [Description("The semaphore timeout period has expired.")]
    ERROR_SEM_TIMEOUT = 121,
    [Description("The data area passed to a system call is too small.")]
    ERROR_INSUFFICIENT_BUFFER = 122,
    [Description("The filename, directory name, or volume label syntax is incorrect.")]
    ERROR_INVALID_NAME = 123,
    [Description("The system call level is not correct.")]
    ERROR_INVALID_LEVEL = 124,
    [Description("The disk has no volume label.")]
    ERROR_NO_VOLUME_LABEL = 125,
    [Description("The specified module could not be found.")]
    ERROR_MOD_NOT_FOUND = 126,
    [Description("The specified procedure could not be found.")]
    ERROR_PROC_NOT_FOUND = 127,
    [Description("There are no child processes to wait for.")]
    ERROR_WAIT_NO_CHILDREN = 128,
    [Description("The %1 application cannot be run in Win32 mode.")]
    ERROR_CHILD_NOT_COMPLETE = 129,
    [Description("Attempt to use a file handle to an open disk partition for an operation other than raw disk I/O.")]
    ERROR_DIRECT_ACCESS_HANDLE = 130,
    [Description("An attempt was made to move the file pointer before the beginning of the file.")]
    ERROR_NEGATIVE_SEEK = 131,
    [Description("The file pointer cannot be set on the specified device or file.")]
    ERROR_SEEK_ON_DEVICE = 132,
    [Description("A JOIN or SUBST command cannot be used for a drive that contains previously joined drives.")]
    ERROR_IS_JOIN_TARGET = 133,
    [Description("An attempt was made to use a JOIN or SUBST command on a drive that has already been joined.")]
    ERROR_IS_JOINED = 134,
    [Description("An attempt was made to use a JOIN or SUBST command on a drive that has already been substituted.")]
    ERROR_IS_SUBSTED = 135,
    [Description("The system tried to delete the JOIN of a drive that is not joined.")]
    ERROR_NOT_JOINED = 136,
    [Description("The system tried to delete the substitution of a drive that is not substituted.")]
    ERROR_NOT_SUBSTED = 137,
    [Description("The system tried to join a drive to a directory on a joined drive.")]
    ERROR_JOIN_TO_JOIN = 138,
    [Description("The system tried to substitute a drive to a directory on a substituted drive.")]
    ERROR_SUBST_TO_SUBST = 139,
    [Description("The system tried to join a drive to a directory on a substituted drive.")]
    ERROR_JOIN_TO_SUBST = 140,
    [Description("The system tried to SUBST a drive to a directory on a joined drive.")]
    ERROR_SUBST_TO_JOIN = 141,
    [Description("The system cannot perform a JOIN or SUBST at this time.")]
    ERROR_BUSY_DRIVE = 142,
    [Description("The system cannot join or substitute a drive to or for a directory on the same drive.")]
    ERROR_SAME_DRIVE = 143,
    [Description("The directory is not a subdirectory of the root directory.")]
    ERROR_DIR_NOT_ROOT = 144,
    [Description("The directory is not empty.")]
    ERROR_DIR_NOT_EMPTY = 145,
    [Description("The path specified is being used in a substitute.")]
    ERROR_IS_SUBST_PATH = 146,
    [Description("Not enough resources are available to process this command.")]
    ERROR_IS_JOIN_PATH = 147,
    [Description("The path specified cannot be used at this time.")]
    ERROR_PATH_BUSY = 148,
    [Description("An attempt was made to join or substitute a drive for which a directory on the drive is the target of a previous substitute.")]
    ERROR_IS_SUBST_TARGET = 149,
    [Description("System trace information was not specified in your CONFIG.SYS file, or tracing is disallowed.")]
    ERROR_SYSTEM_TRACE = 150,
    [Description("The number of specified semaphore events for DosMuxSemWait is not correct.")]
    ERROR_INVALID_EVENT_COUNT = 151,
    [Description("DosMuxSemWait did not execute; too many semaphores are already set.")]
    ERROR_TOO_MANY_MUXWAITERS = 152,
    [Description("The DosMuxSemWait list is not correct.")]
    ERROR_INVALID_LIST_FORMAT = 153,
    [Description("The volume label you entered exceeds the label character limit of the target file system.")]
    ERROR_LABEL_TOO_LONG = 154,
    [Description("Cannot create another thread.")]
    ERROR_TOO_MANY_TCBS = 155,
    [Description("The recipient process has refused the signal.")]
    ERROR_SIGNAL_REFUSED = 156,
    [Description("The segment is already discarded and cannot be locked.")]
    ERROR_DISCARDED = 157,
    [Description("The segment is already unlocked.")]
    ERROR_NOT_LOCKED = 158,
    [Description("The address for the thread ID is not correct.")]
    ERROR_BAD_THREADID_ADDR = 159,
    [Description("One or more arguments are not correct.")]
    ERROR_BAD_ARGUMENTS = 160,
    [Description("The specified path is invalid.")]
    ERROR_BAD_PATHNAME = 161,
    [Description("A signal is already pending.")]
    ERROR_SIGNAL_PENDING = 162,
    [Description("No more threads can be created in the system.")]
    ERROR_MAX_THRDS_REACHED = 164,
    [Description("Unable to lock a region of a file.")]
    ERROR_LOCK_FAILED = 167,
    [Description("The requested resource is in use.")]
    ERROR_BUSY = 170,
    [Description("Device's command support detection is in progress.")]
    ERROR_DEVICE_SUPPORT_IN_PROGRESS = 171,
    [Description("A lock request was not outstanding for the supplied cancel region.")]
    ERROR_CANCEL_VIOLATION = 173,
    [Description("The file system does not support atomic changes to the lock type.")]
    ERROR_ATOMIC_LOCKS_NOT_SUPPORTED = 174,
    [Description("The system detected a segment number that was not correct.")]
    ERROR_INVALID_SEGMENT_NUMBER = 180,
    [Description("The operating system cannot run %1.")]
    ERROR_INVALID_ORDINAL = 182,
    [Description("Cannot create a file when that file already exists.")]
    ERROR_ALREADY_EXISTS = 183,
    [Description("The flag passed is not correct.")]
    ERROR_INVALID_FLAG_NUMBER = 186,
    [Description("The specified system semaphore name was not found.")]
    ERROR_SEM_NOT_FOUND = 187,
    [Description("The operating system cannot run %1.")]
    ERROR_INVALID_STARTING_CODESEG = 188,
    [Description("The operating system cannot run %1.")]
    ERROR_INVALID_STACKSEG = 189,
    [Description("The operating system cannot run %1.")]
    ERROR_INVALID_MODULETYPE = 190,
    [Description("Cannot run %1 in Win32 mode.")]
    ERROR_INVALID_EXE_SIGNATURE = 191,
    [Description("The operating system cannot run %1.")]
    ERROR_EXE_MARKED_INVALID = 192,
    [Description("%1 is not a valid Win32 application.")]
    ERROR_BAD_EXE_FORMAT = 193,
    [Description("The operating system cannot run %1.")]
    ERROR_ITERATED_DATA_EXCEEDS_64k = 194,
    [Description("The operating system cannot run %1.")]
    ERROR_INVALID_MINALLOCSIZE = 195,
    [Description("The operating system cannot run this application program.")]
    ERROR_DYNLINK_FROM_INVALID_RING = 196,
    [Description("The operating system is not presently configured to run this application.")]
    ERROR_IOPL_NOT_ENABLED = 197,
    [Description("The operating system cannot run %1.")]
    ERROR_INVALID_SEGDPL = 198,
    [Description("The operating system cannot run this application program.")]
    ERROR_AUTODATASEG_EXCEEDS_64k = 199,
    [Description("The code segment cannot be greater than or equal to 64K.")]
    ERROR_RING2SEG_MUST_BE_MOVABLE = 200,
    [Description("The operating system cannot run %1.")]
    ERROR_RELOC_CHAIN_XEEDS_SEGLIM = 201,
    [Description("The operating system cannot run %1.")]
    ERROR_INFLOOP_IN_RELOC_CHAIN = 202,
    [Description("The system could not find the environment option that was entered.")]
    ERROR_ENVVAR_NOT_FOUND = 203,
    [Description("No process in the command subtree has a signal handler.")]
    ERROR_NO_SIGNAL_SENT = 205,
    [Description("The filename or extension is too long.")]
    ERROR_FILENAME_EXCED_RANGE = 206,
    [Description("The ring 2 stack is in use.")]
    ERROR_RING2_STACK_IN_USE = 207,
    [Description("The global filename characters, * or ?, are entered incorrectly or too many global filename characters are specified.")]
    ERROR_META_EXPANSION_TOO_LONG = 208,
    [Description("The signal being posted is not correct.")]
    ERROR_INVALID_SIGNAL_NUMBER = 209,
    [Description("The signal handler cannot be set.")]
    ERROR_THREAD_1_INACTIVE = 210,
    [Description("The segment is locked and cannot be reallocated.")]
    ERROR_LOCKED = 212,
    [Description("Too many dynamic-link modules are attached to this program or dynamic-link module.")]
    ERROR_TOO_MANY_MODULES = 214,
    [Description("Cannot nest calls to LoadModule.")]
    ERROR_NESTING_NOT_ALLOWED = 215,
    [Description("This version of %1 is not compatible with the version of Windows you're running. Check your computer's system information and then contact the software publisher.")]
    ERROR_EXE_MACHINE_TYPE_MISMATCH = 216,
    [Description("The image file %1 is signed, unable to modify.")]
    ERROR_EXE_CANNOT_MODIFY_SIGNED_BINARY = 217,
    [Description("The image file %1 is strong signed, unable to modify.")]
    ERROR_EXE_CANNOT_MODIFY_STRONG_SIGNED_BINARY = 218,
    [Description("This file is checked out or locked for editing by another user.")]
    ERROR_FILE_CHECKED_OUT = 220,
    [Description("The file must be checked out before saving changes.")]
    ERROR_CHECKOUT_REQUIRED = 221,
    [Description("The file type being saved or retrieved has been blocked.")]
    ERROR_BAD_FILE_TYPE = 222,
    [Description("The file size exceeds the limit allowed and cannot be saved.")]
    ERROR_FILE_TOO_LARGE = 223,
    [Description("Access Denied. Before opening files in this location, you must first add the web site to your trusted sites list, browse to the web site, and select the option to login automatically.")]
    ERROR_FORMS_AUTH_REQUIRED = 224,
    [Description("Operation did not complete successfully because the file contains a virus or potentially unwanted software.")]
    ERROR_VIRUS_INFECTED = 225,
    [Description("This file contains a virus or potentially unwanted software and cannot be opened. Due to the nature of this virus or potentially unwanted software, the file has been removed from this location.")]
    ERROR_VIRUS_DELETED = 226,
    [Description("The pipe is local.")]
    ERROR_PIPE_LOCAL = 229,
    [Description("The pipe state is invalid.")]
    ERROR_BAD_PIPE = 230,
    [Description("All pipe instances are busy.")]
    ERROR_PIPE_BUSY = 231,
    [Description("The pipe is being closed.")]
    ERROR_NO_DATA = 232,
    [Description("No process is on the other end of the pipe.")]
    ERROR_PIPE_NOT_CONNECTED = 233,
    [Description("More data is available.")]
    ERROR_MORE_DATA = 234,
    [Description("The session was canceled.")]
    ERROR_VC_DISCONNECTED = 240,
    [Description("The specified extended attribute name was invalid.")]
    ERROR_INVALID_EA_NAME = 254,
    [Description("The extended attributes are inconsistent.")]
    ERROR_EA_LIST_INCONSISTENT = 255,
    [Description("The wait operation timed out.")]
    WAIT_TIMEOUT = 258,
    [Description("No more data is available.")]
    ERROR_NO_MORE_ITEMS = 259,
    [Description("The copy functions cannot be used.")]
    ERROR_CANNOT_COPY = 266,
    [Description("The directory name is invalid.")]
    ERROR_DIRECTORY = 267,
    [Description("The extended attributes did not fit in the buffer.")]
    ERROR_EAS_DIDNT_FIT = 275,
    [Description("The extended attribute file on the mounted file system is corrupt.")]
    ERROR_EA_FILE_CORRUPT = 276,
    [Description("The extended attribute table file is full.")]
    ERROR_EA_TABLE_FULL = 277,
    [Description("The specified extended attribute handle is invalid.")]
    ERROR_INVALID_EA_HANDLE = 278,
    [Description("The mounted file system does not support extended attributes.")]
    ERROR_EAS_NOT_SUPPORTED = 282,
    [Description("Attempt to release mutex not owned by caller.")]
    ERROR_NOT_OWNER = 288,
    [Description("Too many posts were made to a semaphore.")]
    ERROR_TOO_MANY_POSTS = 298,
    [Description("Only part of a ReadProcessMemory or WriteProcessMemory request was completed.")]
    ERROR_PARTIAL_COPY = 299,
    [Description("The oplock request is denied.")]
    ERROR_OPLOCK_NOT_GRANTED = 300,
    [Description("An invalid oplock acknowledgment was received by the system.")]
    ERROR_INVALID_OPLOCK_PROTOCOL = 301,
    [Description("The volume is too fragmented to complete this operation.")]
    ERROR_DISK_TOO_FRAGMENTED = 302,
    [Description("The file cannot be opened because it is in the process of being deleted.")]
    ERROR_DELETE_PENDING = 303,
    [Description("Short name settings may not be changed on this volume due to the global registry setting.")]
    ERROR_INCOMPATIBLE_WITH_GLOBAL_SHORT_NAME_REGISTRY_SETTING = 304,
    [Description("Short names are not enabled on this volume.")]
    ERROR_SHORT_NAMES_NOT_ENABLED_ON_VOLUME = 305,
    [Description("The security stream for the given volume is in an inconsistent state. Please run CHKDSK on the volume.")]
    ERROR_SECURITY_STREAM_IS_INCONSISTENT = 306,
    [Description("A requested file lock operation cannot be processed due to an invalid byte range.")]
    ERROR_INVALID_LOCK_RANGE = 307,
    [Description("The subsystem needed to support the image type is not present.")]
    ERROR_IMAGE_SUBSYSTEM_NOT_PRESENT = 308,
    [Description("The specified file already has a notification GUID associated with it.")]
    ERROR_NOTIFICATION_GUID_ALREADY_DEFINED = 309,
    [Description("An invalid exception handler routine has been detected.")]
    ERROR_INVALID_EXCEPTION_HANDLER = 310,
    [Description("Duplicate privileges were specified for the token.")]
    ERROR_DUPLICATE_PRIVILEGES = 311,
    [Description("No ranges for the specified operation were able to be processed.")]
    ERROR_NO_RANGES_PROCESSED = 312,
    [Description("Operation is not allowed on a file system internal file.")]
    ERROR_NOT_ALLOWED_ON_SYSTEM_FILE = 313,
    [Description("The physical resources of this disk have been exhausted.")]
    ERROR_DISK_RESOURCES_EXHAUSTED = 314,
    [Description("The token representing the data is invalid.")]
    ERROR_INVALID_TOKEN = 315,
    [Description("The device does not support the command feature.")]
    ERROR_DEVICE_FEATURE_NOT_SUPPORTED = 316,
    [Description("The system cannot find message text for message number 0x%1 in the message file for %2.")]
    ERROR_MR_MID_NOT_FOUND = 317,
    [Description("The scope specified was not found.")]
    ERROR_SCOPE_NOT_FOUND = 318,
    [Description("The Central Access Policy specified is not defined on the target machine.")]
    ERROR_UNDEFINED_SCOPE = 319,
    [Description("The Central Access Policy obtained from Active Directory is invalid.")]
    ERROR_INVALID_CAP = 320,
    [Description("The device is unreachable.")]
    ERROR_DEVICE_UNREACHABLE = 321,
    [Description("The target device has insufficient resources to complete the operation.")]
    ERROR_DEVICE_NO_RESOURCES = 322,
    [Description("A data integrity checksum error occurred. Data in the file stream is corrupt.")]
    ERROR_DATA_CHECKSUM_ERROR = 323,
    [Description("An attempt was made to modify both a KERNEL and normal Extended Attribute (EA) in the same operation.")]
    ERROR_INTERMIXED_KERNEL_EA_OPERATION = 324,
    [Description("Device does not support file-level TRIM.")]
    ERROR_FILE_LEVEL_TRIM_NOT_SUPPORTED = 326,
    [Description("The command specified a data offset that does not align to the device's granularity/alignment.")]
    ERROR_OFFSET_ALIGNMENT_VIOLATION = 327,
    [Description("The command specified an invalid field in its parameter list.")]
    ERROR_INVALID_FIELD_IN_PARAMETER_LIST = 328,
    [Description("An operation is currently in progress with the device.")]
    ERROR_OPERATION_IN_PROGRESS = 329,
    [Description("An attempt was made to send down the command via an invalid path to the target device.")]
    ERROR_BAD_DEVICE_PATH = 330,
    [Description("The command specified a number of descriptors that exceeded the maximum supported by the device.")]
    ERROR_TOO_MANY_DESCRIPTORS = 331,
    [Description("Scrub is disabled on the specified file.")]
    ERROR_SCRUB_DATA_DISABLED = 332,
    [Description("The storage device does not provide redundancy.")]
    ERROR_NOT_REDUNDANT_STORAGE = 333,
    [Description("An operation is not supported on a resident file.")]
    ERROR_RESIDENT_FILE_NOT_SUPPORTED = 334,
    [Description("An operation is not supported on a compressed file.")]
    ERROR_COMPRESSED_FILE_NOT_SUPPORTED = 335,
    [Description("An operation is not supported on a directory.")]
    ERROR_DIRECTORY_NOT_SUPPORTED = 336,
    [Description("The specified copy of the requested data could not be read.")]
    ERROR_NOT_READ_FROM_COPY = 337,
    [Description("No action was taken as a system reboot is required.")]
    ERROR_FAIL_NOACTION_REBOOT = 350,
    [Description("The shutdown operation failed.")]
    ERROR_FAIL_SHUTDOWN = 351,
    [Description("The restart operation failed.")]
    ERROR_FAIL_RESTART = 352,
    [Description("The maximum number of sessions has been reached.")]
    ERROR_MAX_SESSIONS_REACHED = 353,
    [Description("The thread is already in background processing mode.")]
    ERROR_THREAD_MODE_ALREADY_BACKGROUND = 400,
    [Description("The thread is not in background processing mode.")]
    ERROR_THREAD_MODE_NOT_BACKGROUND = 401,
    [Description("The process is already in background processing mode.")]
    ERROR_PROCESS_MODE_ALREADY_BACKGROUND = 402,
    [Description("The process is not in background processing mode.")]
    ERROR_PROCESS_MODE_NOT_BACKGROUND = 403,
    [Description("Attempt to access invalid address.")]
    ERROR_INVALID_ADDRESS = 487,
    [Description("User profile cannot be loaded.")]
    ERROR_USER_PROFILE_LOAD = 500,
    [Description("Arithmetic result exceeded 32 bits.")]
    ERROR_ARITHMETIC_OVERFLOW = 534,
    [Description("There is a process on other end of the pipe.")]
    ERROR_PIPE_CONNECTED = 535,
    [Description("Waiting for a process to open the other end of the pipe.")]
    ERROR_PIPE_LISTENING = 536,
    [Description("Application verifier has found an error in the current process.")]
    ERROR_VERIFIER_STOP = 537,
    [Description("An error occurred in the ABIOS subsystem.")]
    ERROR_ABIOS_ERROR = 538,
    [Description("A warning occurred in the WX86 subsystem.")]
    ERROR_WX86_WARNING = 539,
    [Description("An error occurred in the WX86 subsystem.")]
    ERROR_WX86_ERROR = 540,
    [Description("An attempt was made to cancel or set a timer that has an associated APC and the subject thread is not the thread that originally set the timer with an associated APC routine.")]
    ERROR_TIMER_NOT_CANCELED = 541,
    [Description("Unwind exception code.")]
    ERROR_UNWIND = 542,
    [Description("An invalid or unaligned stack was encountered during an unwind operation.")]
    ERROR_BAD_STACK = 543,
    [Description("An invalid unwind target was encountered during an unwind operation.")]
    ERROR_INVALID_UNWIND_TARGET = 544,
    [Description("Invalid Object Attributes specified to NtCreatePort or invalid Port Attributes specified to NtConnectPort")]
    ERROR_INVALID_PORT_ATTRIBUTES = 545,
    [Description("Length of message passed to NtRequestPort or NtRequestWaitReplyPort was longer than the maximum message allowed by the port.")]
    ERROR_PORT_MESSAGE_TOO_LONG = 546,
    [Description("An attempt was made to lower a quota limit below the current usage.")]
    ERROR_INVALID_QUOTA_LOWER = 547,
    [Description("An attempt was made to attach to a device that was already attached to another device.")]
    ERROR_DEVICE_ALREADY_ATTACHED = 548,
    [Description("An attempt was made to execute an instruction at an unaligned address and the host system does not support unaligned instruction references.")]
    ERROR_INSTRUCTION_MISALIGNMENT = 549,
    [Description("Profiling not started.")]
    ERROR_PROFILING_NOT_STARTED = 550,
    [Description("Profiling not stopped.")]
    ERROR_PROFILING_NOT_STOPPED = 551,
    [Description("The passed ACL did not contain the minimum required information.")]
    ERROR_COULD_NOT_INTERPRET = 552,
    [Description("The number of active profiling objects is at the maximum and no more may be started.")]
    ERROR_PROFILING_AT_LIMIT = 553,
    [Description("Used to indicate that an operation cannot continue without blocking for I/O.")]
    ERROR_CANT_WAIT = 554,
    [Description("Indicates that a thread attempted to terminate itself by default (called NtTerminateThread with NULL) and it was the last thread in the current process.")]
    ERROR_CANT_TERMINATE_SELF = 555,
    [Description("If an MM error is returned which is not defined in the standard FsRtl filter, it is converted to one of the following errors which is guaranteed to be in the filter. In this case information is lost, however, the filter correctly handles the exception.")]
    ERROR_UNEXPECTED_MM_CREATE_ERR = 556,
    [Description("If an MM error is returned which is not defined in the standard FsRtl filter, it is converted to one of the following errors which is guaranteed to be in the filter. In this case information is lost, however, the filter correctly handles the exception.")]
    ERROR_UNEXPECTED_MM_MAP_ERROR = 557,
    [Description("If an MM error is returned which is not defined in the standard FsRtl filter, it is converted to one of the following errors which is guaranteed to be in the filter. In this case information is lost, however, the filter correctly handles the exception.")]
    ERROR_UNEXPECTED_MM_EXTEND_ERR = 558,
    [Description("A malformed function table was encountered during an unwind operation.")]
    ERROR_BAD_FUNCTION_TABLE = 559,
    [Description("Indicates that an attempt was made to assign protection to a file system file or directory and one of the SIDs in the security descriptor could not be translated into a GUID that could be stored by the file system. This causes the protection attempt to fail, which may cause a file creation attempt to fail.")]
    ERROR_NO_GUID_TRANSLATION = 560,
    [Description("Indicates that an attempt was made to grow an LDT by setting its size, or that the size was not an even number of selectors.")]
    ERROR_INVALID_LDT_SIZE = 561,
    [Description("Indicates that the starting value for the LDT information was not an integral multiple of the selector size.")]
    ERROR_INVALID_LDT_OFFSET = 563,
    [Description("Indicates that the user supplied an invalid descriptor when trying to set up Ldt descriptors.")]
    ERROR_INVALID_LDT_DESCRIPTOR = 564,
    [Description("Indicates a process has too many threads to perform the requested action. For example, assignment of a primary token may only be performed when a process has zero or one threads.")]
    ERROR_TOO_MANY_THREADS = 565,
    [Description("An attempt was made to operate on a thread within a specific process, but the thread specified is not in the process specified.")]
    ERROR_THREAD_NOT_IN_PROCESS = 566,
    [Description("Page file quota was exceeded.")]
    ERROR_PAGEFILE_QUOTA_EXCEEDED = 567,
    [Description("The Netlogon service cannot start because another Netlogon service running in the domain conflicts with the specified role.")]
    ERROR_LOGON_SERVER_CONFLICT = 568,
    [Description("The SAM database on a Windows Server is significantly out of synchronization with the copy on the Domain Controller. A complete synchronization is required.")]
    ERROR_SYNCHRONIZATION_REQUIRED = 569,
    [Description("The NtCreateFile API failed. This error should never be returned to an application, it is a place holder for the Windows Lan Manager Redirector to use in its internal error mapping routines.")]
    ERROR_NET_OPEN_FAILED = 570,
    [Description("{Privilege Failed} The I/O permissions for the process could not be changed.")]
    ERROR_IO_PRIVILEGE_FAILED = 571,
    [Description("{Application Exit by CTRL+C} The application terminated as a result of a CTRL+C.")]
    ERROR_CONTROL_C_EXIT = 572,
    [Description("{Missing System File} The required system file %hs is bad or missing.")]
    ERROR_MISSING_SYSTEMFILE = 573,
    [Description("{Application Error} The exception %s (0x%08lx) occurred in the application at location 0x%08lx.")]
    ERROR_UNHANDLED_EXCEPTION = 574,
    [Description("{Application Error} The application was unable to start correctly (0x%lx). Click OK to close the application.")]
    ERROR_APP_INIT_FAILURE = 575,
    [Description("{Unable to Create Paging File} The creation of the paging file %hs failed (%lx). The requested size was %ld.")]
    ERROR_PAGEFILE_CREATE_FAILED = 576,
    [Description("Windows cannot verify the digital signature for this file. A recent hardware or software change might have installed a file that is signed incorrectly or damaged, or that might be malicious software from an unknown source.")]
    ERROR_INVALID_IMAGE_HASH = 577,
    [Description("{No Paging File Specified} No paging file was specified in the system configuration.")]
    ERROR_NO_PAGEFILE = 578,
    [Description("{EXCEPTION} A real-mode application issued a floating-point instruction and floating-point hardware is not present.")]
    ERROR_ILLEGAL_FLOAT_CONTEXT = 579,
    [Description("An event pair synchronization operation was performed using the thread specific client/server event pair object, but no event pair object was associated with the thread.")]
    ERROR_NO_EVENT_PAIR = 580,
    [Description("A Windows Server has an incorrect configuration.")]
    ERROR_DOMAIN_CTRLR_CONFIG_ERROR = 581,
    [Description("An illegal character was encountered. For a multi-byte character set this includes a lead byte without a succeeding trail byte. For the Unicode character set this includes the characters 0xFFFF and 0xFFFE.")]
    ERROR_ILLEGAL_CHARACTER = 582,
    [Description("The Unicode character is not defined in the Unicode character set installed on the system.")]
    ERROR_UNDEFINED_CHARACTER = 583,
    [Description("The paging file cannot be created on a floppy diskette.")]
    ERROR_FLOPPY_VOLUME = 584,
    [Description("The system BIOS failed to connect a system interrupt to the device or bus for which the device is connected.")]
    ERROR_BIOS_FAILED_TO_CONNECT_INTERRUPT = 585,
    [Description("This operation is only allowed for the Primary Domain Controller of the domain.")]
    ERROR_BACKUP_CONTROLLER = 586,
    [Description("An attempt was made to acquire a mutant such that its maximum count would have been exceeded.")]
    ERROR_MUTANT_LIMIT_EXCEEDED = 587,
    [Description("A volume has been accessed for which a file system driver is required that has not yet been loaded.")]
    ERROR_FS_DRIVER_REQUIRED = 588,
    [Description("{Registry File Failure} The registry cannot load the hive (file): %hs or its log or alternate. It is corrupt, absent, or not writable.")]
    ERROR_CANNOT_LOAD_REGISTRY_FILE = 589,
    [Description("{Unexpected Failure in DebugActiveProcess} An unexpected failure occurred while processing a DebugActiveProcess API request. You may choose OK to terminate the process, or Cancel to ignore the error.")]
    ERROR_DEBUG_ATTACH_FAILED = 590,
    [Description("{Fatal System Error} The %hs system process terminated unexpectedly with a status of 0x%08x (0x%08x 0x%08x). The system has been shut down.")]
    ERROR_SYSTEM_PROCESS_TERMINATED = 591,
    [Description("{Data Not Accepted} The TDI client could not handle the data received during an indication.")]
    ERROR_DATA_NOT_ACCEPTED = 592,
    [Description("NTVDM encountered a hard error.")]
    ERROR_VDM_HARD_ERROR = 593,
    [Description("{Cancel Timeout} The driver %hs failed to complete a cancelled I/O request in the allotted time.")]
    ERROR_DRIVER_CANCEL_TIMEOUT = 594,
    [Description("{Reply Message Mismatch} An attempt was made to reply to an LPC message, but the thread specified by the client ID in the message was not waiting on that message.")]
    ERROR_REPLY_MESSAGE_MISMATCH = 595,
    [Description("{Delayed Write Failed} Windows was unable to save all the data for the file %hs. The data has been lost. This error may be caused by a failure of your computer hardware or network connection. Please try to save this file elsewhere.")]
    ERROR_LOST_WRITEBEHIND_DATA = 596,
    [Description("The parameter(s) passed to the server in the client/server shared memory window were invalid. Too much data may have been put in the shared memory window.")]
    ERROR_CLIENT_SERVER_PARAMETERS_INVALID = 597,
    [Description("The stream is not a tiny stream.")]
    ERROR_NOT_TINY_STREAM = 598,
    [Description("The request must be handled by the stack overflow code.")]
    ERROR_STACK_OVERFLOW_READ = 599,
    [Description("Internal OFS status codes indicating how an allocation operation is handled. Either it is retried after the containing onode is moved or the extent stream is converted to a large stream.")]
    ERROR_CONVERT_TO_LARGE = 600,
    [Description("The attempt to find the object found an object matching by ID on the volume but it is out of the scope of the handle used for the operation.")]
    ERROR_FOUND_OUT_OF_SCOPE = 601,
    [Description("The bucket array must be grown. Retry transaction after doing so.")]
    ERROR_ALLOCATE_BUCKET = 602,
    [Description("The user/kernel marshalling buffer has overflowed.")]
    ERROR_MARSHALL_OVERFLOW = 603,
    [Description("The supplied variant structure contains invalid data.")]
    ERROR_INVALID_VARIANT = 604,
    [Description("The specified buffer contains ill-formed data.")]
    ERROR_BAD_COMPRESSION_BUFFER = 605,
    [Description("{Audit Failed} An attempt to generate a security audit failed.")]
    ERROR_AUDIT_FAILED = 606,
    [Description("The timer resolution was not previously set by the current process.")]
    ERROR_TIMER_RESOLUTION_NOT_SET = 607,
    [Description("There is insufficient account information to log you on.")]
    ERROR_INSUFFICIENT_LOGON_INFO = 608,
    [Description("{Invalid DLL Entrypoint} The dynamic link library %hs is not written correctly. The stack pointer has been left in an inconsistent state. The entrypoint should be declared as WINAPI or STDCALL. Select YES to fail the DLL load. Select NO to continue execution. Selecting NO may cause the application to operate incorrectly.")]
    ERROR_BAD_DLL_ENTRYPOINT = 609,
    [Description("{Invalid Service Callback Entrypoint} The %hs service is not written correctly. The stack pointer has been left in an inconsistent state. The callback entrypoint should be declared as WINAPI or STDCALL. Selecting OK will cause the service to continue operation. However, the service process may operate incorrectly.")]
    ERROR_BAD_SERVICE_ENTRYPOINT = 610,
    [Description("There is an IP address conflict with another system on the network.")]
    ERROR_IP_ADDRESS_CONFLICT1 = 611,
    [Description("There is an IP address conflict with another system on the network.")]
    ERROR_IP_ADDRESS_CONFLICT2 = 612,
    [Description("{Low On Registry Space} The system has reached the maximum size allowed for the system part of the registry. Additional storage requests will be ignored.")]
    ERROR_REGISTRY_QUOTA_LIMIT = 613,
    [Description("A callback return system service cannot be executed when no callback is active.")]
    ERROR_NO_CALLBACK_ACTIVE = 614,
    [Description("The password provided is too short to meet the policy of your user account. Please choose a longer password.")]
    ERROR_PWD_TOO_SHORT = 615,
    [Description("The policy of your user account does not allow you to change passwords too frequently. This is done to prevent users from changing back to a familiar, but potentially discovered, password. If you feel your password has been compromised then please contact your administrator immediately to have a new one assigned.")]
    ERROR_PWD_TOO_RECENT = 616,
    [Description("You have attempted to change your password to one that you have used in the past. The policy of your user account does not allow this. Please select a password that you have not previously used.")]
    ERROR_PWD_HISTORY_CONFLICT = 617,
    [Description("The specified compression format is unsupported.")]
    ERROR_UNSUPPORTED_COMPRESSION = 618,
    [Description("The specified hardware profile configuration is invalid.")]
    ERROR_INVALID_HW_PROFILE = 619,
    [Description("The specified Plug and Play registry device path is invalid.")]
    ERROR_INVALID_PLUGPLAY_DEVICE_PATH = 620,
    [Description("The specified quota list is internally inconsistent with its descriptor.")]
    ERROR_QUOTA_LIST_INCONSISTENT = 621,
    [Description("{Windows Evaluation Notification} The evaluation period for this installation of Windows has expired. This system will shutdown in 1 hour. To restore access to this installation of Windows, please upgrade this installation using a licensed distribution of this product.")]
    ERROR_EVALUATION_EXPIRATION = 622,
    [Description("{Illegal System DLL Relocation} The system DLL %hs was relocated in memory. The application will not run properly. The relocation occurred because the DLL %hs occupied an address range reserved for Windows system DLLs. The vendor supplying the DLL should be contacted for a new DLL.")]
    ERROR_ILLEGAL_DLL_RELOCATION = 623,
    [Description("{DLL Initialization Failed} The application failed to initialize because the window station is shutting down.")]
    ERROR_DLL_INIT_FAILED_LOGOFF = 624,
    [Description("The validation process needs to continue on to the next step.")]
    ERROR_VALIDATE_CONTINUE = 625,
    [Description("There are no more matches for the current index enumeration.")]
    ERROR_NO_MORE_MATCHES = 626,
    [Description("The range could not be added to the range list because of a conflict.")]
    ERROR_RANGE_LIST_CONFLICT = 627,
    [Description("The server process is running under a SID different than that required by client.")]
    ERROR_SERVER_SID_MISMATCH = 628,
    [Description("A group marked use for deny only cannot be enabled.")]
    ERROR_CANT_ENABLE_DENY_ONLY = 629,
    [Description("{EXCEPTION} Multiple floating point faults.")]
    ERROR_FLOAT_MULTIPLE_FAULTS = 630,
    [Description("{EXCEPTION} Multiple floating point traps.")]
    ERROR_FLOAT_MULTIPLE_TRAPS = 631,
    [Description("The requested interface is not supported.")]
    ERROR_NOINTERFACE = 632,
    [Description("{System Standby Failed} The driver %hs does not support standby mode. Updating this driver may allow the system to go to standby mode.")]
    ERROR_DRIVER_FAILED_SLEEP = 633,
    [Description("The system file %1 has become corrupt and has been replaced.")]
    ERROR_CORRUPT_SYSTEM_FILE = 634,
    [Description("{Virtual Memory Minimum Too Low} Your system is low on virtual memory. Windows is increasing the size of your virtual memory paging file. During this process, memory requests for some applications may be denied. For more information, see Help.")]
    ERROR_COMMITMENT_MINIMUM = 635,
    [Description("A device was removed so enumeration must be restarted.")]
    ERROR_PNP_RESTART_ENUMERATION = 636,
    [Description("{Fatal System Error} The system image %s is not properly signed. The file has been replaced with the signed file. The system has been shut down.")]
    ERROR_SYSTEM_IMAGE_BAD_SIGNATURE = 637,
    [Description("Device will not start without a reboot.")]
    ERROR_PNP_REBOOT_REQUIRED = 638,
    [Description("There is not enough power to complete the requested operation.")]
    ERROR_INSUFFICIENT_POWER = 639,
    [Description("ERROR_MULTIPLE_FAULT_VIOLATION")]
    ERROR_MULTIPLE_FAULT_VIOLATION = 640,
    [Description("The system is in the process of shutting down.")]
    ERROR_SYSTEM_SHUTDOWN = 641,
    [Description("An attempt to remove a processes DebugPort was made, but a port was not already associated with the process.")]
    ERROR_PORT_NOT_SET = 642,
    [Description("This version of Windows is not compatible with the behavior version of directory forest, domain or domain controller.")]
    ERROR_DS_VERSION_CHECK_FAILURE = 643,
    [Description("The specified range could not be found in the range list.")]
    ERROR_RANGE_NOT_FOUND = 644,
    [Description("The driver was not loaded because the system is booting into safe mode.")]
    ERROR_NOT_SAFE_MODE_DRIVER = 646,
    [Description("The driver was not loaded because it failed its initialization call.")]
    ERROR_FAILED_DRIVER_ENTRY = 647,
    [Description("The \"%hs\" encountered an error while applying power or reading the device configuration. This may be caused by a failure of your hardware or by a poor connection.")]
    ERROR_DEVICE_ENUMERATION_ERROR = 648,
    [Description("The create operation failed because the name contained at least one mount point which resolves to a volume to which the specified device object is not attached.")]
    ERROR_MOUNT_POINT_NOT_RESOLVED = 649,
    [Description("The device object parameter is either not a valid device object or is not attached to the volume specified by the file name.")]
    ERROR_INVALID_DEVICE_OBJECT_PARAMETER = 650,
    [Description("A Machine Check Error has occurred. Please check the system eventlog for additional information.")]
    ERROR_MCA_OCCURED = 651,
    [Description("There was error [%2] processing the driver database.")]
    ERROR_DRIVER_DATABASE_ERROR = 652,
    [Description("System hive size has exceeded its limit.")]
    ERROR_SYSTEM_HIVE_TOO_LARGE = 653,
    [Description("The driver could not be loaded because a previous version of the driver is still in memory.")]
    ERROR_DRIVER_FAILED_PRIOR_UNLOAD = 654,
    [Description("{Volume Shadow Copy Service} Please wait while the Volume Shadow Copy Service prepares volume %hs for hibernation.")]
    ERROR_VOLSNAP_PREPARE_HIBERNATE = 655,
    [Description("The system has failed to hibernate (The error code is %hs). Hibernation will be disabled until the system is restarted.")]
    ERROR_HIBERNATION_FAILURE = 656,
    [Description("The password provided is too long to meet the policy of your user account. Please choose a shorter password.")]
    ERROR_PWD_TOO_LONG = 657,
    [Description("The requested operation could not be completed due to a file system limitation.")]
    ERROR_FILE_SYSTEM_LIMITATION = 665,
    [Description("An assertion failure has occurred.")]
    ERROR_ASSERTION_FAILURE = 668,
    [Description("An error occurred in the ACPI subsystem.")]
    ERROR_ACPI_ERROR = 669,
    [Description("WOW Assertion Error.")]
    ERROR_WOW_ASSERTION = 670,
    [Description("A device is missing in the system BIOS MPS table. This device will not be used. Please contact your system vendor for system BIOS update.")]
    ERROR_PNP_BAD_MPS_TABLE = 671,
    [Description("A translator failed to translate resources.")]
    ERROR_PNP_TRANSLATION_FAILED = 672,
    [Description("A IRQ translator failed to translate resources.")]
    ERROR_PNP_IRQ_TRANSLATION_FAILED = 673,
    [Description("Driver %2 returned invalid ID for a child device (%3).")]
    ERROR_PNP_INVALID_ID = 674,
    [Description("{Kernel Debugger Awakened} the system debugger was awakened by an interrupt.")]
    ERROR_WAKE_SYSTEM_DEBUGGER = 675,
    [Description("{Handles Closed} Handles to objects have been automatically closed as a result of the requested operation.")]
    ERROR_HANDLES_CLOSED = 676,
    [Description("{Too Much Information} The specified access control list (ACL) contained more information than was expected.")]
    ERROR_EXTRANEOUS_INFORMATION = 677,
    [Description("This warning level status indicates that the transaction state already exists for the registry sub-tree, but that a transaction commit was previously aborted. The commit has NOT been completed, but has not been rolled back either (so it may still be committed if desired).")]
    ERROR_RXACT_COMMIT_NECESSARY = 678,
    [Description("{Media Changed} The media may have changed.")]
    ERROR_MEDIA_CHECK = 679,
    [Description("{GUID Substitution} During the translation of a global identifier (GUID) to a Windows security ID (SID), no administratively-defined GUID prefix was found. A substitute prefix was used, which will not compromise system security. However, this may provide a more restrictive access than intended.")]
    ERROR_GUID_SUBSTITUTION_MADE = 680,
    [Description("The create operation stopped after reaching a symbolic link.")]
    ERROR_STOPPED_ON_SYMLINK = 681,
    [Description("A long jump has been executed.")]
    ERROR_LONGJUMP = 682,
    [Description("The Plug and Play query operation was not successful.")]
    ERROR_PLUGPLAY_QUERY_VETOED = 683,
    [Description("A frame consolidation has been executed.")]
    ERROR_UNWIND_CONSOLIDATE = 684,
    [Description("{Registry Hive Recovered} Registry hive (file): %hs was corrupted and it has been recovered. Some data might have been lost.")]
    ERROR_REGISTRY_HIVE_RECOVERED = 685,
    [Description("The application is attempting to run executable code from the module %hs. This may be insecure. An alternative, %hs, is available. Should the application use the secure module %hs?")]
    ERROR_DLL_MIGHT_BE_INSECURE = 686,
    [Description("The application is loading executable code from the module %hs. This is secure, but may be incompatible with previous releases of the operating system. An alternative, %hs, is available. Should the application use the secure module %hs?")]
    ERROR_DLL_MIGHT_BE_INCOMPATIBLE = 687,
    [Description("Debugger did not handle the exception.")]
    ERROR_DBG_EXCEPTION_NOT_HANDLED = 688,
    [Description("Debugger will reply later.")]
    ERROR_DBG_REPLY_LATER = 689,
    [Description("Debugger cannot provide handle.")]
    ERROR_DBG_UNABLE_TO_PROVIDE_HANDLE = 690,
    [Description("Debugger terminated thread.")]
    ERROR_DBG_TERMINATE_THREAD = 691,
    [Description("Debugger terminated process.")]
    ERROR_DBG_TERMINATE_PROCESS = 692,
    [Description("Debugger got control C.")]
    ERROR_DBG_CONTROL_C = 693,
    [Description("Debugger printed exception on control C.")]
    ERROR_DBG_PRINTEXCEPTION_C = 694,
    [Description("Debugger received RIP exception.")]
    ERROR_DBG_RIPEXCEPTION = 695,
    [Description("Debugger received control break.")]
    ERROR_DBG_CONTROL_BREAK = 696,
    [Description("Debugger command communication exception.")]
    ERROR_DBG_COMMAND_EXCEPTION = 697,
    [Description("{Object Exists} An attempt was made to create an object and the object name already existed.")]
    ERROR_OBJECT_NAME_EXISTS = 698,
    [Description("{Thread Suspended} A thread termination occurred while the thread was suspended. The thread was resumed, and termination proceeded.")]
    ERROR_THREAD_WAS_SUSPENDED = 699,
    [Description("{Image Relocated} An image file could not be mapped at the address specified in the image file. Local fixups must be performed on this image.")]
    ERROR_IMAGE_NOT_AT_BASE = 700,
    [Description("This informational level status indicates that a specified registry sub-tree transaction state did not yet exist and had to be created.")]
    ERROR_RXACT_STATE_CREATED = 701,
    [Description("{Segment Load} A virtual DOS machine (VDM) is loading, unloading, or moving an MS-DOS or Win16 program segment image. An exception is raised so a debugger can load, unload or track symbols and breakpoints within these 16-bit segments.")]
    ERROR_SEGMENT_NOTIFICATION = 702,
    [Description("{Invalid Current Directory} The process cannot switch to the startup current directory %hs. Select OK to set current directory to %hs, or select CANCEL to exit.")]
    ERROR_BAD_CURRENT_DIRECTORY = 703,
    [Description("{Redundant Read} To satisfy a read request, the NT fault-tolerant file system successfully read the requested data from a redundant copy. This was done because the file system encountered a failure on a member of the fault-tolerant volume, but was unable to reassign the failing area of the device.")]
    ERROR_FT_READ_RECOVERY_FROM_BACKUP = 704,
    [Description("{Redundant Write} To satisfy a write request, the NT fault-tolerant file system successfully wrote a redundant copy of the information. This was done because the file system encountered a failure on a member of the fault-tolerant volume, but was not able to reassign the failing area of the device.")]
    ERROR_FT_WRITE_RECOVERY = 705,
    [Description("{Machine Type Mismatch} The image file %hs is valid, but is for a machine type other than the current machine. Select OK to continue, or CANCEL to fail the DLL load.")]
    ERROR_IMAGE_MACHINE_TYPE_MISMATCH = 706,
    [Description("{Partial Data Received} The network transport returned partial data to its client. The remaining data will be sent later.")]
    ERROR_RECEIVE_PARTIAL = 707,
    [Description("{Expedited Data Received} The network transport returned data to its client that was marked as expedited by the remote system.")]
    ERROR_RECEIVE_EXPEDITED = 708,
    [Description("{Partial Expedited Data Received} The network transport returned partial data to its client and this data was marked as expedited by the remote system. The remaining data will be sent later.")]
    ERROR_RECEIVE_PARTIAL_EXPEDITED = 709,
    [Description("{TDI Event Done} The TDI indication has completed successfully.")]
    ERROR_EVENT_DONE = 710,
    [Description("{TDI Event Pending} The TDI indication has entered the pending state.")]
    ERROR_EVENT_PENDING = 711,
    [Description("Checking file system on %wZ.")]
    ERROR_CHECKING_FILE_SYSTEM = 712,
    [Description("{Fatal Application Exit} %hs.")]
    ERROR_FATAL_APP_EXIT = 713,
    [Description("The specified registry key is referenced by a predefined handle.")]
    ERROR_PREDEFINED_HANDLE = 714,
    [Description("{Page Unlocked} The page protection of a locked page was changed to 'No Access' and the page was unlocked from memory and from the process.")]
    ERROR_WAS_UNLOCKED = 715,
    [Description("%hs")]
    ERROR_SERVICE_NOTIFICATION = 716,
    [Description("{Page Locked} One of the pages to lock was already locked.")]
    ERROR_WAS_LOCKED = 717,
    [Description("Application popup: %1 : %2")]
    ERROR_LOG_HARD_ERROR = 718,
    [Description("ERROR_ALREADY_WIN32")]
    ERROR_ALREADY_WIN32 = 719,
    [Description("{Machine Type Mismatch} The image file %hs is valid, but is for a machine type other than the current machine.")]
    ERROR_IMAGE_MACHINE_TYPE_MISMATCH_EXE = 720,
    [Description("A yield execution was performed and no thread was available to run.")]
    ERROR_NO_YIELD_PERFORMED = 721,
    [Description("The resumable flag to a timer API was ignored.")]
    ERROR_TIMER_RESUME_IGNORED = 722,
    [Description("The arbiter has deferred arbitration of these resources to its parent.")]
    ERROR_ARBITRATION_UNHANDLED = 723,
    [Description("The inserted CardBus device cannot be started because of a configuration error on \"%hs\".")]
    ERROR_CARDBUS_NOT_SUPPORTED = 724,
    [Description("The CPUs in this multiprocessor system are not all the same revision level. To use all processors the operating system restricts itself to the features of the least capable processor in the system. Should problems occur with this system, contact the CPU manufacturer to see if this mix of processors is supported.")]
    ERROR_MP_PROCESSOR_MISMATCH = 725,
    [Description("The system was put into hibernation.")]
    ERROR_HIBERNATED = 726,
    [Description("The system was resumed from hibernation.")]
    ERROR_RESUME_HIBERNATION = 727,
    [Description("Windows has detected that the system firmware (BIOS) was updated [previous firmware date = %2, current firmware date %3].")]
    ERROR_FIRMWARE_UPDATED = 728,
    [Description("A device driver is leaking locked I/O pages causing system degradation. The system has automatically enabled tracking code in order to try and catch the culprit.")]
    ERROR_DRIVERS_LEAKING_LOCKED_PAGES = 729,
    [Description("The system has awoken.")]
    ERROR_WAKE_SYSTEM = 730,
    [Description("ERROR_WAIT_1")]
    ERROR_WAIT_1 = 731,
    [Description("ERROR_WAIT_2")]
    ERROR_WAIT_2 = 732,
    [Description("ERROR_WAIT_3")]
    ERROR_WAIT_3 = 733,
    [Description("ERROR_WAIT_63")]
    ERROR_WAIT_63 = 734,
    [Description("ERROR_ABANDONED_WAIT_0")]
    ERROR_ABANDONED_WAIT_0 = 735,
    [Description("ERROR_ABANDONED_WAIT_63")]
    ERROR_ABANDONED_WAIT_63 = 736,
    [Description("ERROR_USER_APC")]
    ERROR_USER_APC = 737,
    [Description("ERROR_KERNEL_APC")]
    ERROR_KERNEL_APC = 738,
    [Description("ERROR_ALERTED")]
    ERROR_ALERTED = 739,
    [Description("The requested operation requires elevation.")]
    ERROR_ELEVATION_REQUIRED = 740,
    [Description("A reparse should be performed by the Object Manager since the name of the file resulted in a symbolic link.")]
    ERROR_REPARSE = 741,
    [Description("An open/create operation completed while an oplock break is underway.")]
    ERROR_OPLOCK_BREAK_IN_PROGRESS = 742,
    [Description("A new volume has been mounted by a file system.")]
    ERROR_VOLUME_MOUNTED = 743,
    [Description("This success level status indicates that the transaction state already exists for the registry sub-tree, but that a transaction commit was previously aborted. The commit has now been completed.")]
    ERROR_RXACT_COMMITTED = 744,
    [Description("This indicates that a notify change request has been completed due to closing the handle which made the notify change request.")]
    ERROR_NOTIFY_CLEANUP = 745,
    [Description("{Connect Failure on Primary Transport} An attempt was made to connect to the remote server %hs on the primary transport, but the connection failed. The computer WAS able to connect on a secondary transport.")]
    ERROR_PRIMARY_TRANSPORT_CONNECT_FAILED = 746,
    [Description("Page fault was a transition fault.")]
    ERROR_PAGE_FAULT_TRANSITION = 747,
    [Description("Page fault was a demand zero fault.")]
    ERROR_PAGE_FAULT_DEMAND_ZERO = 748,
    [Description("Page fault was a demand zero fault.")]
    ERROR_PAGE_FAULT_COPY_ON_WRITE = 749,
    [Description("Page fault was a demand zero fault.")]
    ERROR_PAGE_FAULT_GUARD_PAGE = 750,
    [Description("Page fault was satisfied by reading from a secondary storage device.")]
    ERROR_PAGE_FAULT_PAGING_FILE = 751,
    [Description("Cached page was locked during operation.")]
    ERROR_CACHE_PAGE_LOCKED = 752,
    [Description("Crash dump exists in paging file.")]
    ERROR_CRASH_DUMP = 753,
    [Description("Specified buffer contains all zeros.")]
    ERROR_BUFFER_ALL_ZEROS = 754,
    [Description("A reparse should be performed by the Object Manager since the name of the file resulted in a symbolic link.")]
    ERROR_REPARSE_OBJECT = 755,
    [Description("The device has succeeded a query-stop and its resource requirements have changed.")]
    ERROR_RESOURCE_REQUIREMENTS_CHANGED = 756,
    [Description("The translator has translated these resources into the global space and no further translations should be performed.")]
    ERROR_TRANSLATION_COMPLETE = 757,
    [Description("A process being terminated has no threads to terminate.")]
    ERROR_NOTHING_TO_TERMINATE = 758,
    [Description("The specified process is not part of a job.")]
    ERROR_PROCESS_NOT_IN_JOB = 759,
    [Description("The specified process is part of a job.")]
    ERROR_PROCESS_IN_JOB = 760,
    [Description("{Volume Shadow Copy Service} The system is now ready for hibernation.")]
    ERROR_VOLSNAP_HIBERNATE_READY = 761,
    [Description("A file system or file system filter driver has successfully completed an FsFilter operation.")]
    ERROR_FSFILTER_OP_COMPLETED_SUCCESSFULLY = 762,
    [Description("The specified interrupt vector was already connected.")]
    ERROR_INTERRUPT_VECTOR_ALREADY_CONNECTED = 763,
    [Description("The specified interrupt vector is still connected.")]
    ERROR_INTERRUPT_STILL_CONNECTED = 764,
    [Description("An operation is blocked waiting for an oplock.")]
    ERROR_WAIT_FOR_OPLOCK = 765,
    [Description("Debugger handled exception.")]
    ERROR_DBG_EXCEPTION_HANDLED = 766,
    [Description("Debugger continued.")]
    ERROR_DBG_CONTINUE = 767,
    [Description("An exception occurred in a user mode callback and the kernel callback frame should be removed.")]
    ERROR_CALLBACK_POP_STACK = 768,
    [Description("Compression is disabled for this volume.")]
    ERROR_COMPRESSION_DISABLED = 769,
    [Description("The data provider cannot fetch backwards through a result set.")]
    ERROR_CANTFETCHBACKWARDS = 770,
    [Description("The data provider cannot scroll backwards through a result set.")]
    ERROR_CANTSCROLLBACKWARDS = 771,
    [Description("The data provider requires that previously fetched data is released before asking for more data.")]
    ERROR_ROWSNOTRELEASED = 772,
    [Description("The data provider was not able to interpret the flags set for a column binding in an accessor.")]
    ERROR_BAD_ACCESSOR_FLAGS = 773,
    [Description("One or more errors occurred while processing the request.")]
    ERROR_ERRORS_ENCOUNTERED = 774,
    [Description("The implementation is not capable of performing the request.")]
    ERROR_NOT_CAPABLE = 775,
    [Description("The client of a component requested an operation which is not valid given the state of the component instance.")]
    ERROR_REQUEST_OUT_OF_SEQUENCE = 776,
    [Description("A version number could not be parsed.")]
    ERROR_VERSION_PARSE_ERROR = 777,
    [Description("The iterator's start position is invalid.")]
    ERROR_BADSTARTPOSITION = 778,
    [Description("The hardware has reported an uncorrectable memory error.")]
    ERROR_MEMORY_HARDWARE = 779,
    [Description("The attempted operation required self healing to be enabled.")]
    ERROR_DISK_REPAIR_DISABLED = 780,
    [Description("The Desktop heap encountered an error while allocating session memory. There is more information in the system event log.")]
    ERROR_INSUFFICIENT_RESOURCE_FOR_SPECIFIED_SHARED_SECTION_SIZE = 781,
    [Description("The system power state is transitioning from %2 to %3.")]
    ERROR_SYSTEM_POWERSTATE_TRANSITION = 782,
    [Description("The system power state is transitioning from %2 to %3 but could enter %4.")]
    ERROR_SYSTEM_POWERSTATE_COMPLEX_TRANSITION = 783,
    [Description("A thread is getting dispatched with MCA EXCEPTION because of MCA.")]
    ERROR_MCA_EXCEPTION = 784,
    [Description("Access to %1 is monitored by policy rule %2.")]
    ERROR_ACCESS_AUDIT_BY_POLICY = 785,
    [Description("Access to %1 has been restricted by your Administrator by policy rule %2.")]
    ERROR_ACCESS_DISABLED_NO_SAFER_UI_BY_POLICY = 786,
    [Description("A valid hibernation file has been invalidated and should be abandoned.")]
    ERROR_ABANDON_HIBERFILE = 787,
    [Description("{Delayed Write Failed} Windows was unable to save all the data for the file %hs; the data has been lost. This error may be caused by network connectivity issues. Please try to save this file elsewhere.")]
    ERROR_LOST_WRITEBEHIND_DATA_NETWORK_DISCONNECTED = 788,
    [Description("{Delayed Write Failed} Windows was unable to save all the data for the file %hs; the data has been lost. This error was returned by the server on which the file exists. Please try to save this file elsewhere.")]
    ERROR_LOST_WRITEBEHIND_DATA_NETWORK_SERVER_ERROR = 789,
    [Description("{Delayed Write Failed} Windows was unable to save all the data for the file %hs; the data has been lost. This error may be caused if the device has been removed or the media is write-protected.")]
    ERROR_LOST_WRITEBEHIND_DATA_LOCAL_DISK_ERROR = 790,
    [Description("The resources required for this device conflict with the MCFG table.")]
    ERROR_BAD_MCFG_TABLE = 791,
    [Description("The volume repair could not be performed while it is online. Please schedule to take the volume offline so that it can be repaired.")]
    ERROR_DISK_REPAIR_REDIRECTED = 792,
    [Description("The volume repair was not successful.")]
    ERROR_DISK_REPAIR_UNSUCCESSFUL = 793,
    [Description("One of the volume corruption logs is full. Further corruptions that may be detected won't be logged.")]
    ERROR_CORRUPT_LOG_OVERFULL = 794,
    [Description("One of the volume corruption logs is internally corrupted and needs to be recreated. The volume may contain undetected corruptions and must be scanned.")]
    ERROR_CORRUPT_LOG_CORRUPTED = 795,
    [Description("One of the volume corruption logs is unavailable for being operated on.")]
    ERROR_CORRUPT_LOG_UNAVAILABLE = 796,
    [Description("One of the volume corruption logs was deleted while still having corruption records in them. The volume contains detected corruptions and must be scanned.")]
    ERROR_CORRUPT_LOG_DELETED_FULL = 797,
    [Description("One of the volume corruption logs was cleared by chkdsk and no longer contains real corruptions.")]
    ERROR_CORRUPT_LOG_CLEARED = 798,
    [Description("Orphaned files exist on the volume but could not be recovered because no more new names could be created in the recovery directory. Files must be moved from the recovery directory.")]
    ERROR_ORPHAN_NAME_EXHAUSTED = 799,
    [Description("The oplock that was associated with this handle is now associated with a different handle.")]
    ERROR_OPLOCK_SWITCHED_TO_NEW_HANDLE = 800,
    [Description("An oplock of the requested level cannot be granted. An oplock of a lower level may be available.")]
    ERROR_CANNOT_GRANT_REQUESTED_OPLOCK = 801,
    [Description("The operation did not complete successfully because it would cause an oplock to be broken. The caller has requested that existing oplocks not be broken.")]
    ERROR_CANNOT_BREAK_OPLOCK = 802,
    [Description("The handle with which this oplock was associated has been closed. The oplock is now broken.")]
    ERROR_OPLOCK_HANDLE_CLOSED = 803,
    [Description("The specified access control entry (ACE) does not contain a condition.")]
    ERROR_NO_ACE_CONDITION = 804,
    [Description("The specified access control entry (ACE) contains an invalid condition.")]
    ERROR_INVALID_ACE_CONDITION = 805,
    [Description("Access to the specified file handle has been revoked.")]
    ERROR_FILE_HANDLE_REVOKED = 806,
    [Description("An image file was mapped at a different address from the one specified in the image file but fixups will still be automatically performed on the image.")]
    ERROR_IMAGE_AT_DIFFERENT_BASE = 807,
    [Description("Access to the extended attribute was denied.")]
    ERROR_EA_ACCESS_DENIED = 994,
    [Description("The I/O operation has been aborted because of either a thread exit or an application request.")]
    ERROR_OPERATION_ABORTED = 995,
    [Description("Overlapped I/O event is not in a signaled state.")]
    ERROR_IO_INCOMPLETE = 996,
    [Description("Overlapped I/O operation is in progress.")]
    ERROR_IO_PENDING = 997,
    [Description("Invalid access to memory location.")]
    ERROR_NOACCESS = 998,
    [Description("Error performing inpage operation.")]
    ERROR_SWAPERROR = 999,
    [Description("Recursion too deep; the stack overflowed.")]
    ERROR_STACK_OVERFLOW = 1001,
    [Description("The window cannot act on the sent message.")]
    ERROR_INVALID_MESSAGE = 1002,
    [Description("Cannot complete this function.")]
    ERROR_CAN_NOT_COMPLETE = 1003,
    [Description("Invalid flags.")]
    ERROR_INVALID_FLAGS = 1004,
    [Description("The volume does not contain a recognized file system. Please make sure that all required file system drivers are loaded and that the volume is not corrupted.")]
    ERROR_UNRECOGNIZED_VOLUME = 1005,
    [Description("The volume for a file has been externally altered so that the opened file is no longer valid.")]
    ERROR_FILE_INVALID = 1006,
    [Description("The requested operation cannot be performed in full-screen mode.")]
    ERROR_FULLSCREEN_MODE = 1007,
    [Description("An attempt was made to reference a token that does not exist.")]
    ERROR_NO_TOKEN = 1008,
    [Description("The configuration registry database is corrupt.")]
    ERROR_BADDB = 1009,
    [Description("The configuration registry key is invalid.")]
    ERROR_BADKEY = 1010,
    [Description("The configuration registry key could not be opened.")]
    ERROR_CANTOPEN = 1011,
    [Description("The configuration registry key could not be read.")]
    ERROR_CANTREAD = 1012,
    [Description("The configuration registry key could not be written.")]
    ERROR_CANTWRITE = 1013,
    [Description("One of the files in the registry database had to be recovered by use of a log or alternate copy. The recovery was successful.")]
    ERROR_REGISTRY_RECOVERED = 1014,
    [Description("The registry is corrupted. The structure of one of the files containing registry data is corrupted, or the system's memory image of the file is corrupted, or the file could not be recovered because the alternate copy or log was absent or corrupted.")]
    ERROR_REGISTRY_CORRUPT = 1015,
    [Description("An I/O operation initiated by the registry failed unrecoverably. The registry could not read in, or write out, or flush, one of the files that contain the system's image of the registry.")]
    ERROR_REGISTRY_IO_FAILED = 1016,
    [Description("The system has attempted to load or restore a file into the registry, but the specified file is not in a registry file format.")]
    ERROR_NOT_REGISTRY_FILE = 1017,
    [Description("Illegal operation attempted on a registry key that has been marked for deletion.")]
    ERROR_KEY_DELETED = 1018,
    [Description("System could not allocate the required space in a registry log.")]
    ERROR_NO_LOG_SPACE = 1019,
    [Description("Cannot create a symbolic link in a registry key that already has subkeys or values.")]
    ERROR_KEY_HAS_CHILDREN = 1020,
    [Description("Cannot create a stable subkey under a volatile parent key.")]
    ERROR_CHILD_MUST_BE_VOLATILE = 1021,
    [Description("A notify change request is being completed and the information is not being returned in the caller's buffer. The caller now needs to enumerate the files to find the changes.")]
    ERROR_NOTIFY_ENUM_DIR = 1022,
    [Description("A stop control has been sent to a service that other running services are dependent on.")]
    ERROR_DEPENDENT_SERVICES_RUNNING = 1051,
    [Description("The requested control is not valid for this service.")]
    ERROR_INVALID_SERVICE_CONTROL = 1052,
    [Description("The service did not respond to the start or control request in a timely fashion.")]
    ERROR_SERVICE_REQUEST_TIMEOUT = 1053,
    [Description("A thread could not be created for the service.")]
    ERROR_SERVICE_NO_THREAD = 1054,
    [Description("The service database is locked.")]
    ERROR_SERVICE_DATABASE_LOCKED = 1055,
    [Description("An instance of the service is already running.")]
    ERROR_SERVICE_ALREADY_RUNNING = 1056,
    [Description("The account name is invalid or does not exist, or the password is invalid for the account name specified.")]
    ERROR_INVALID_SERVICE_ACCOUNT = 1057,
    [Description("The service cannot be started, either because it is disabled or because it has no enabled devices associated with it.")]
    ERROR_SERVICE_DISABLED = 1058,
    [Description("Circular service dependency was specified.")]
    ERROR_CIRCULAR_DEPENDENCY = 1059,
    [Description("The specified service does not exist as an installed service.")]
    ERROR_SERVICE_DOES_NOT_EXIST = 1060,
    [Description("The service cannot accept control messages at this time.")]
    ERROR_SERVICE_CANNOT_ACCEPT_CTRL = 1061,
    [Description("The service has not been started.")]
    ERROR_SERVICE_NOT_ACTIVE = 1062,
    [Description("The service process could not connect to the service controller.")]
    ERROR_FAILED_SERVICE_CONTROLLER_CONNECT = 1063,
    [Description("An exception occurred in the service when handling the control request.")]
    ERROR_EXCEPTION_IN_SERVICE = 1064,
    [Description("The database specified does not exist.")]
    ERROR_DATABASE_DOES_NOT_EXIST = 1065,
    [Description("The service has returned a service-specific error code.")]
    ERROR_SERVICE_SPECIFIC_ERROR = 1066,
    [Description("The process terminated unexpectedly.")]
    ERROR_PROCESS_ABORTED = 1067,
    [Description("The dependency service or group failed to start.")]
    ERROR_SERVICE_DEPENDENCY_FAIL = 1068,
    [Description("The service did not start due to a logon failure.")]
    ERROR_SERVICE_LOGON_FAILED = 1069,
    [Description("After starting, the service hung in a start-pending state.")]
    ERROR_SERVICE_START_HANG = 1070,
    [Description("The specified service database lock is invalid.")]
    ERROR_INVALID_SERVICE_LOCK = 1071,
    [Description("The specified service has been marked for deletion.")]
    ERROR_SERVICE_MARKED_FOR_DELETE = 1072,
    [Description("The specified service already exists.")]
    ERROR_SERVICE_EXISTS = 1073,
    [Description("The system is currently running with the last-known-good configuration.")]
    ERROR_ALREADY_RUNNING_LKG = 1074,
    [Description("The dependency service does not exist or has been marked for deletion.")]
    ERROR_SERVICE_DEPENDENCY_DELETED = 1075,
    [Description("The current boot has already been accepted for use as the last-known-good control set.")]
    ERROR_BOOT_ALREADY_ACCEPTED = 1076,
    [Description("No attempts to start the service have been made since the last boot.")]
    ERROR_SERVICE_NEVER_STARTED = 1077,
    [Description("The name is already in use as either a service name or a service display name.")]
    ERROR_DUPLICATE_SERVICE_NAME = 1078,
    [Description("The account specified for this service is different from the account specified for other services running in the same process.")]
    ERROR_DIFFERENT_SERVICE_ACCOUNT = 1079,
    [Description("Failure actions can only be set for Win32 services, not for drivers.")]
    ERROR_CANNOT_DETECT_DRIVER_FAILURE = 1080,
    [Description("This service runs in the same process as the service control manager. Therefore, the service control manager cannot take action if this service's process terminates unexpectedly.")]
    ERROR_CANNOT_DETECT_PROCESS_ABORT = 1081,
    [Description("No recovery program has been configured for this service.")]
    ERROR_NO_RECOVERY_PROGRAM = 1082,
    [Description("The executable program that this service is configured to run in does not implement the service.")]
    ERROR_SERVICE_NOT_IN_EXE = 1083,
    [Description("This service cannot be started in Safe Mode.")]
    ERROR_NOT_SAFEBOOT_SERVICE = 1084,
    [Description("The physical end of the tape has been reached.")]
    ERROR_END_OF_MEDIA = 1100,
    [Description("A tape access reached a filemark.")]
    ERROR_FILEMARK_DETECTED = 1101,
    [Description("The beginning of the tape or a partition was encountered.")]
    ERROR_BEGINNING_OF_MEDIA = 1102,
    [Description("A tape access reached the end of a set of files.")]
    ERROR_SETMARK_DETECTED = 1103,
    [Description("No more data is on the tape.")]
    ERROR_NO_DATA_DETECTED = 1104,
    [Description("Tape could not be partitioned.")]
    ERROR_PARTITION_FAILURE = 1105,
    [Description("When accessing a new tape of a multivolume partition, the current block size is incorrect.")]
    ERROR_INVALID_BLOCK_LENGTH = 1106,
    [Description("Tape partition information could not be found when loading a tape.")]
    ERROR_DEVICE_NOT_PARTITIONED = 1107,
    [Description("Unable to lock the media eject mechanism.")]
    ERROR_UNABLE_TO_LOCK_MEDIA = 1108,
    [Description("Unable to unload the media.")]
    ERROR_UNABLE_TO_UNLOAD_MEDIA = 1109,
    [Description("The media in the drive may have changed.")]
    ERROR_MEDIA_CHANGED = 1110,
    [Description("The I/O bus was reset.")]
    ERROR_BUS_RESET = 1111,
    [Description("No media in drive.")]
    ERROR_NO_MEDIA_IN_DRIVE = 1112,
    [Description("No mapping for the Unicode character exists in the target multi-byte code page.")]
    ERROR_NO_UNICODE_TRANSLATION = 1113,
    [Description("A dynamic link library (DLL) initialization routine failed.")]
    ERROR_DLL_INIT_FAILED = 1114,
    [Description("A system shutdown is in progress.")]
    ERROR_SHUTDOWN_IN_PROGRESS = 1115,
    [Description("Unable to abort the system shutdown because no shutdown was in progress.")]
    ERROR_NO_SHUTDOWN_IN_PROGRESS = 1116,
    [Description("The request could not be performed because of an I/O device error.")]
    ERROR_IO_DEVICE = 1117,
    [Description("No serial device was successfully initialized. The serial driver will unload.")]
    ERROR_SERIAL_NO_DEVICE = 1118,
    [Description("Unable to open a device that was sharing an interrupt request (IRQ) with other devices. At least one other device that uses that IRQ was already opened.")]
    ERROR_IRQ_BUSY = 1119,
    [Description("A serial I/O operation was completed by another write to the serial port. The IOCTL_SERIAL_XOFF_COUNTER reached zero.)")]
    ERROR_MORE_WRITES = 1120,
    [Description("A serial I/O operation completed because the timeout period expired. The IOCTL_SERIAL_XOFF_COUNTER did not reach zero.)")]
    ERROR_COUNTER_TIMEOUT = 1121,
    [Description("No ID address mark was found on the floppy disk.")]
    ERROR_FLOPPY_ID_MARK_NOT_FOUND = 1122,
    [Description("Mismatch between the floppy disk sector ID field and the floppy disk controller track address.")]
    ERROR_FLOPPY_WRONG_CYLINDER = 1123,
    [Description("The floppy disk controller reported an error that is not recognized by the floppy disk driver.")]
    ERROR_FLOPPY_UNKNOWN_ERROR = 1124,
    [Description("The floppy disk controller returned inconsistent results in its registers.")]
    ERROR_FLOPPY_BAD_REGISTERS = 1125,
    [Description("While accessing the hard disk, a recalibrate operation failed, even after retries.")]
    ERROR_DISK_RECALIBRATE_FAILED = 1126,
    [Description("While accessing the hard disk, a disk operation failed even after retries.")]
    ERROR_DISK_OPERATION_FAILED = 1127,
    [Description("While accessing the hard disk, a disk controller reset was needed, but even that failed.")]
    ERROR_DISK_RESET_FAILED = 1128,
    [Description("Physical end of tape encountered.")]
    ERROR_EOM_OVERFLOW = 1129,
    [Description("Not enough server storage is available to process this command.")]
    ERROR_NOT_ENOUGH_SERVER_MEMORY = 1130,
    [Description("A potential deadlock condition has been detected.")]
    ERROR_POSSIBLE_DEADLOCK = 1131,
    [Description("The base address or the file offset specified does not have the proper alignment.")]
    ERROR_MAPPED_ALIGNMENT = 1132,
    [Description("An attempt to change the system power state was vetoed by another application or driver.")]
    ERROR_SET_POWER_STATE_VETOED = 1140,
    [Description("The system BIOS failed an attempt to change the system power state.")]
    ERROR_SET_POWER_STATE_FAILED = 1141,
    [Description("An attempt was made to create more links on a file than the file system supports.")]
    ERROR_TOO_MANY_LINKS = 1142,
    [Description("The specified program requires a newer version of Windows.")]
    ERROR_OLD_WIN_VERSION = 1150,
    [Description("The specified program is not a Windows or MS-DOS program.")]
    ERROR_APP_WRONG_OS = 1151,
    [Description("Cannot start more than one instance of the specified program.")]
    ERROR_SINGLE_INSTANCE_APP = 1152,
    [Description("The specified program was written for an earlier version of Windows.")]
    ERROR_RMODE_APP = 1153,
    [Description("One of the library files needed to run this application is damaged.")]
    ERROR_INVALID_DLL = 1154,
    [Description("No application is associated with the specified file for this operation.")]
    ERROR_NO_ASSOCIATION = 1155,
    [Description("An error occurred in sending the command to the application.")]
    ERROR_DDE_FAIL = 1156,
    [Description("One of the library files needed to run this application cannot be found.")]
    ERROR_DLL_NOT_FOUND = 1157,
    [Description("The current process has used all of its system allowance of handles for Window Manager objects.")]
    ERROR_NO_MORE_USER_HANDLES = 1158,
    [Description("The message can be used only with synchronous operations.")]
    ERROR_MESSAGE_SYNC_ONLY = 1159,
    [Description("The indicated source element has no media.")]
    ERROR_SOURCE_ELEMENT_EMPTY = 1160,
    [Description("The indicated destination element already contains media.")]
    ERROR_DESTINATION_ELEMENT_FULL = 1161,
    [Description("The indicated element does not exist.")]
    ERROR_ILLEGAL_ELEMENT_ADDRESS = 1162,
    [Description("The indicated element is part of a magazine that is not present.")]
    ERROR_MAGAZINE_NOT_PRESENT = 1163,
    [Description("The indicated device requires reinitialization due to hardware errors.")]
    ERROR_DEVICE_REINITIALIZATION_NEEDED = 1164,
    [Description("The device has indicated that cleaning is required before further operations are attempted.")]
    ERROR_DEVICE_REQUIRES_CLEANING = 1165,
    [Description("The device has indicated that its door is open.")]
    ERROR_DEVICE_DOOR_OPEN = 1166,
    [Description("The device is not connected.")]
    ERROR_DEVICE_NOT_CONNECTED = 1167,
    [Description("Element not found.")]
    ERROR_NOT_FOUND = 1168,
    [Description("There was no match for the specified key in the index.")]
    ERROR_NO_MATCH = 1169,
    [Description("The property set specified does not exist on the object.")]
    ERROR_SET_NOT_FOUND = 1170,
    [Description("The point passed to GetMouseMovePoints is not in the buffer.")]
    ERROR_POINT_NOT_FOUND = 1171,
    [Description("The tracking (workstation) service is not running.")]
    ERROR_NO_TRACKING_SERVICE = 1172,
    [Description("The Volume ID could not be found.")]
    ERROR_NO_VOLUME_ID = 1173,
    [Description("Unable to remove the file to be replaced.")]
    ERROR_UNABLE_TO_REMOVE_REPLACED = 1175,
    [Description("Unable to move the replacement file to the file to be replaced. The file to be replaced has retained its original name.")]
    ERROR_UNABLE_TO_MOVE_REPLACEMENT = 1176,
    [Description("Unable to move the replacement file to the file to be replaced. The file to be replaced has been renamed using the backup name.")]
    ERROR_UNABLE_TO_MOVE_REPLACEMENT_2 = 1177,
    [Description("The volume change journal is being deleted.")]
    ERROR_JOURNAL_DELETE_IN_PROGRESS = 1178,
    [Description("The volume change journal is not active.")]
    ERROR_JOURNAL_NOT_ACTIVE = 1179,
    [Description("A file was found, but it may not be the correct file.")]
    ERROR_POTENTIAL_FILE_FOUND = 1180,
    [Description("The journal entry has been deleted from the journal.")]
    ERROR_JOURNAL_ENTRY_DELETED = 1181,
    [Description("A system shutdown has already been scheduled.")]
    ERROR_SHUTDOWN_IS_SCHEDULED = 1190,
    [Description("The system shutdown cannot be initiated because there are other users logged on to the computer.")]
    ERROR_SHUTDOWN_USERS_LOGGED_ON = 1191,
    [Description("The specified device name is invalid.")]
    ERROR_BAD_DEVICE = 1200,
    [Description("The device is not currently connected but it is a remembered connection.")]
    ERROR_CONNECTION_UNAVAIL = 1201,
    [Description("The local device name has a remembered connection to another network resource.")]
    ERROR_DEVICE_ALREADY_REMEMBERED = 1202,
    [Description("The network path was either typed incorrectly, does not exist, or the network provider is not currently available. Please try retyping the path or contact your network administrator.")]
    ERROR_NO_NET_OR_BAD_PATH = 1203,
    [Description("The specified network provider name is invalid.")]
    ERROR_BAD_PROVIDER = 1204,
    [Description("Unable to open the network connection profile.")]
    ERROR_CANNOT_OPEN_PROFILE = 1205,
    [Description("The network connection profile is corrupted.")]
    ERROR_BAD_PROFILE = 1206,
    [Description("Cannot enumerate a noncontainer.")]
    ERROR_NOT_CONTAINER = 1207,
    [Description("An extended error has occurred.")]
    ERROR_EXTENDED_ERROR = 1208,
    [Description("The format of the specified group name is invalid.")]
    ERROR_INVALID_GROUPNAME = 1209,
    [Description("The format of the specified computer name is invalid.")]
    ERROR_INVALID_COMPUTERNAME = 1210,
    [Description("The format of the specified event name is invalid.")]
    ERROR_INVALID_EVENTNAME = 1211,
    [Description("The format of the specified domain name is invalid.")]
    ERROR_INVALID_DOMAINNAME = 1212,
    [Description("The format of the specified service name is invalid.")]
    ERROR_INVALID_SERVICENAME = 1213,
    [Description("The format of the specified network name is invalid.")]
    ERROR_INVALID_NETNAME = 1214,
    [Description("The format of the specified share name is invalid.")]
    ERROR_INVALID_SHARENAME = 1215,
    [Description("The format of the specified password is invalid.")]
    ERROR_INVALID_PASSWORDNAME = 1216,
    [Description("The format of the specified message name is invalid.")]
    ERROR_INVALID_MESSAGENAME = 1217,
    [Description("The format of the specified message destination is invalid.")]
    ERROR_INVALID_MESSAGEDEST = 1218,
    [Description("Multiple connections to a server or shared resource by the same user, using more than one user name, are not allowed. Disconnect all previous connections to the server or shared resource and try again.")]
    ERROR_SESSION_CREDENTIAL_CONFLICT = 1219,
    [Description("An attempt was made to establish a session to a network server, but there are already too many sessions established to that server.")]
    ERROR_REMOTE_SESSION_LIMIT_EXCEEDED = 1220,
    [Description("The workgroup or domain name is already in use by another computer on the network.")]
    ERROR_DUP_DOMAINNAME = 1221,
    [Description("The network is not present or not started.")]
    ERROR_NO_NETWORK = 1222,
    [Description("The operation was canceled by the user.")]
    ERROR_CANCELLED = 1223,
    [Description("The requested operation cannot be performed on a file with a user-mapped section open.")]
    ERROR_USER_MAPPED_FILE = 1224,
    [Description("The remote computer refused the network connection.")]
    ERROR_CONNECTION_REFUSED = 1225,
    [Description("The network connection was gracefully closed.")]
    ERROR_GRACEFUL_DISCONNECT = 1226,
    [Description("The network transport endpoint already has an address associated with it.")]
    ERROR_ADDRESS_ALREADY_ASSOCIATED = 1227,
    [Description("An address has not yet been associated with the network endpoint.")]
    ERROR_ADDRESS_NOT_ASSOCIATED = 1228,
    [Description("An operation was attempted on a nonexistent network connection.")]
    ERROR_CONNECTION_INVALID = 1229,
    [Description("An invalid operation was attempted on an active network connection.")]
    ERROR_CONNECTION_ACTIVE = 1230,
    [Description("The network location cannot be reached. For information about network troubleshooting, see Windows Help.")]
    ERROR_NETWORK_UNREACHABLE = 1231,
    [Description("The network location cannot be reached. For information about network troubleshooting, see Windows Help.")]
    ERROR_HOST_UNREACHABLE = 1232,
    [Description("The network location cannot be reached. For information about network troubleshooting, see Windows Help.")]
    ERROR_PROTOCOL_UNREACHABLE = 1233,
    [Description("No service is operating at the destination network endpoint on the remote system.")]
    ERROR_PORT_UNREACHABLE = 1234,
    [Description("The request was aborted.")]
    ERROR_REQUEST_ABORTED = 1235,
    [Description("The network connection was aborted by the local system.")]
    ERROR_CONNECTION_ABORTED = 1236,
    [Description("The operation could not be completed. A retry should be performed.")]
    ERROR_RETRY = 1237,
    [Description("A connection to the server could not be made because the limit on the number of concurrent connections for this account has been reached.")]
    ERROR_CONNECTION_COUNT_LIMIT = 1238,
    [Description("Attempting to log in during an unauthorized time of day for this account.")]
    ERROR_LOGIN_TIME_RESTRICTION = 1239,
    [Description("The account is not authorized to log in from this station.")]
    ERROR_LOGIN_WKSTA_RESTRICTION = 1240,
    [Description("The network address could not be used for the operation requested.")]
    ERROR_INCORRECT_ADDRESS = 1241,
    [Description("The service is already registered.")]
    ERROR_ALREADY_REGISTERED = 1242,
    [Description("The specified service does not exist.")]
    ERROR_SERVICE_NOT_FOUND = 1243,
    [Description("The operation being requested was not performed because the user has not been authenticated.")]
    ERROR_NOT_AUTHENTICATED = 1244,
    [Description("The operation being requested was not performed because the user has not logged on to the network. The specified service does not exist.")]
    ERROR_NOT_LOGGED_ON = 1245,
    [Description("Continue with work in progress.")]
    ERROR_CONTINUE = 1246,
    [Description("An attempt was made to perform an initialization operation when initialization has already been completed.")]
    ERROR_ALREADY_INITIALIZED = 1247,
    [Description("No more local devices.")]
    ERROR_NO_MORE_DEVICES = 1248,
    [Description("The specified site does not exist.")]
    ERROR_NO_SUCH_SITE = 1249,
    [Description("A domain controller with the specified name already exists.")]
    ERROR_DOMAIN_CONTROLLER_EXISTS = 1250,
    [Description("This operation is supported only when you are connected to the server.")]
    ERROR_ONLY_IF_CONNECTED = 1251,
    [Description("The group policy framework should call the extension even if there are no changes.")]
    ERROR_OVERRIDE_NOCHANGES = 1252,
    [Description("The specified user does not have a valid profile.")]
    ERROR_BAD_USER_PROFILE = 1253,
    [Description("This operation is not supported on a computer running Windows Server 2003 for Small Business Server.")]
    ERROR_NOT_SUPPORTED_ON_SBS = 1254,
    [Description("The server machine is shutting down.")]
    ERROR_SERVER_SHUTDOWN_IN_PROGRESS = 1255,
    [Description("The remote system is not available. For information about network troubleshooting, see Windows Help.")]
    ERROR_HOST_DOWN = 1256,
    [Description("The security identifier provided is not from an account domain.")]
    ERROR_NON_ACCOUNT_SID = 1257,
    [Description("The security identifier provided does not have a domain component.")]
    ERROR_NON_DOMAIN_SID = 1258,
    [Description("AppHelp dialog canceled thus preventing the application from starting.")]
    ERROR_APPHELP_BLOCK = 1259,
    [Description("This program is blocked by group policy. For more information, contact your system administrator.")]
    ERROR_ACCESS_DISABLED_BY_POLICY = 1260,
    [Description("A program attempt to use an invalid register value. Normally caused by an uninitialized register. This error is Itanium specific.")]
    ERROR_REG_NAT_CONSUMPTION = 1261,
    [Description("The share is currently offline or does not exist.")]
    ERROR_CSCSHARE_OFFLINE = 1262,
    [Description("The Kerberos protocol encountered an error while validating the KDC certificate during smartcard logon. There is more information in the system event log.")]
    ERROR_PKINIT_FAILURE = 1263,
    [Description("The Kerberos protocol encountered an error while attempting to utilize the smartcard subsystem.")]
    ERROR_SMARTCARD_SUBSYSTEM_FAILURE = 1264,
    [Description("The system cannot contact a domain controller to service the authentication request. Please try again later.")]
    ERROR_DOWNGRADE_DETECTED = 1265,
    [Description("The machine is locked and cannot be shut down without the force option.")]
    ERROR_MACHINE_LOCKED = 1271,
    [Description("An application-defined callback gave invalid data when called.")]
    ERROR_CALLBACK_SUPPLIED_INVALID_DATA = 1273,
    [Description("The group policy framework should call the extension in the synchronous foreground policy refresh.")]
    ERROR_SYNC_FOREGROUND_REFRESH_REQUIRED = 1274,
    [Description("This driver has been blocked from loading.")]
    ERROR_DRIVER_BLOCKED = 1275,
    [Description("A dynamic link library (DLL) referenced a module that was neither a DLL nor the process's executable image.")]
    ERROR_INVALID_IMPORT_OF_NON_DLL = 1276,
    [Description("Windows cannot open this program since it has been disabled.")]
    ERROR_ACCESS_DISABLED_WEBBLADE = 1277,
    [Description("Windows cannot open this program because the license enforcement system has been tampered with or become corrupted.")]
    ERROR_ACCESS_DISABLED_WEBBLADE_TAMPER = 1278,
    [Description("A transaction recover failed.")]
    ERROR_RECOVERY_FAILURE = 1279,
    [Description("The current thread has already been converted to a fiber.")]
    ERROR_ALREADY_FIBER = 1280,
    [Description("The current thread has already been converted from a fiber.")]
    ERROR_ALREADY_THREAD = 1281,
    [Description("The system detected an overrun of a stack-based buffer in this application. This overrun could potentially allow a malicious user to gain control of this application.")]
    ERROR_STACK_BUFFER_OVERRUN = 1282,
    [Description("Data present in one of the parameters is more than the function can operate on.")]
    ERROR_PARAMETER_QUOTA_EXCEEDED = 1283,
    [Description("An attempt to do an operation on a debug object failed because the object is in the process of being deleted.")]
    ERROR_DEBUGGER_INACTIVE = 1284,
    [Description("An attempt to delay-load a .dll or get a function address in a delay-loaded .dll failed.")]
    ERROR_DELAY_LOAD_FAILED = 1285,
    [Description("%1 is a 16-bit application. You do not have permissions to execute 16-bit applications. Check your permissions with your system administrator.")]
    ERROR_VDM_DISALLOWED = 1286,
    [Description("Insufficient information exists to identify the cause of failure.")]
    ERROR_UNIDENTIFIED_ERROR = 1287,
    [Description("The parameter passed to a C runtime function is incorrect.")]
    ERROR_INVALID_CRUNTIME_PARAMETER = 1288,
    [Description("The operation occurred beyond the valid data length of the file.")]
    ERROR_BEYOND_VDL = 1289,
    [Description("The service start failed since one or more services in the same process have an incompatible service SID type  setting. A service with restricted service SID type can only coexist in the same process with other services  with a restricted SID type. If the service SID type for this service was just configured, the hosting process  must be restarted in order to start this service. On Windows Server 2003 and Windows XP, an unrestricted service cannot coexist in the  same process with other services. The service with the unrestricted service SID type must be moved to an owned  process in order to start this service.")]
    ERROR_INCOMPATIBLE_SERVICE_SID_TYPE = 1290,
    [Description("The process hosting the driver for this device has been terminated.")]
    ERROR_DRIVER_PROCESS_TERMINATED = 1291,
    [Description("An operation attempted to exceed an implementation-defined limit.")]
    ERROR_IMPLEMENTATION_LIMIT = 1292,
    [Description("Either the target process, or the target thread's containing process, is a protected process.")]
    ERROR_PROCESS_IS_PROTECTED = 1293,
    [Description("The service notification client is lagging too far behind the current state of services in the machine.")]
    ERROR_SERVICE_NOTIFY_CLIENT_LAGGING = 1294,
    [Description("The requested file operation failed because the storage quota was exceeded. To free up disk space, move files to a different location or delete unnecessary files. For more information, contact your system administrator.")]
    ERROR_DISK_QUOTA_EXCEEDED = 1295,
    [Description("The requested file operation failed because the storage policy blocks that type of file. For more information, contact your system administrator.")]
    ERROR_CONTENT_BLOCKED = 1296,
    [Description("A privilege that the service requires to function properly does not exist in the service account configuration. You may use the Services Microsoft Management Console (MMC) snap-in (services.msc) and the Local Security Settings MMC snap-in (secpol.msc) to view the service configuration and the account configuration.")]
    ERROR_INCOMPATIBLE_SERVICE_PRIVILEGE = 1297,
    [Description("A thread involved in this operation appears to be unresponsive.")]
    ERROR_APP_HANG = 1298,
    [Description("Indicates a particular Security ID may not be assigned as the label of an object.")]
    ERROR_INVALID_LABEL = 1299,
    [Description("Not all privileges or groups referenced are assigned to the caller.")]
    ERROR_NOT_ALL_ASSIGNED = 1300,
    [Description("Some mapping between account names and security IDs was not done.")]
    ERROR_SOME_NOT_MAPPED = 1301,
    [Description("No system quota limits are specifically set for this account.")]
    ERROR_NO_QUOTAS_FOR_ACCOUNT = 1302,
    [Description("No encryption key is available. A well-known encryption key was returned.")]
    ERROR_LOCAL_USER_SESSION_KEY = 1303,
    [Description("The password is too complex to be converted to a LAN Manager password. The LAN Manager password returned is a NULL string.")]
    ERROR_NULL_LM_PASSWORD = 1304,
    [Description("The revision level is unknown.")]
    ERROR_UNKNOWN_REVISION = 1305,
    [Description("Indicates two revision levels are incompatible.")]
    ERROR_REVISION_MISMATCH = 1306,
    [Description("This security ID may not be assigned as the owner of this object.")]
    ERROR_INVALID_OWNER = 1307,
    [Description("This security ID may not be assigned as the primary group of an object.")]
    ERROR_INVALID_PRIMARY_GROUP = 1308,
    [Description("An attempt has been made to operate on an impersonation token by a thread that is not currently impersonating a client.")]
    ERROR_NO_IMPERSONATION_TOKEN = 1309,
    [Description("The group may not be disabled.")]
    ERROR_CANT_DISABLE_MANDATORY = 1310,
    [Description("There are currently no logon servers available to service the logon request.")]
    ERROR_NO_LOGON_SERVERS = 1311,
    [Description("A specified logon session does not exist. It may already have been terminated.")]
    ERROR_NO_SUCH_LOGON_SESSION = 1312,
    [Description("A specified privilege does not exist.")]
    ERROR_NO_SUCH_PRIVILEGE = 1313,
    [Description("A required privilege is not held by the client.")]
    ERROR_PRIVILEGE_NOT_HELD = 1314,
    [Description("The name provided is not a properly formed account name.")]
    ERROR_INVALID_ACCOUNT_NAME = 1315,
    [Description("The specified account already exists.")]
    ERROR_USER_EXISTS = 1316,
    [Description("The specified account does not exist.")]
    ERROR_NO_SUCH_USER = 1317,
    [Description("The specified group already exists.")]
    ERROR_GROUP_EXISTS = 1318,
    [Description("The specified group does not exist.")]
    ERROR_NO_SUCH_GROUP = 1319,
    [Description("Either the specified user account is already a member of the specified group, or the specified group cannot be deleted because it contains a member.")]
    ERROR_MEMBER_IN_GROUP = 1320,
    [Description("The specified user account is not a member of the specified group account.")]
    ERROR_MEMBER_NOT_IN_GROUP = 1321,
    [Description("This operation is disallowed as it could result in an administration account being disabled, deleted or unable to log on.")]
    ERROR_LAST_ADMIN = 1322,
    [Description("Unable to update the password. The value provided as the current password is incorrect.")]
    ERROR_WRONG_PASSWORD = 1323,
    [Description("Unable to update the password. The value provided for the new password contains values that are not allowed in passwords.")]
    ERROR_ILL_FORMED_PASSWORD = 1324,
    [Description("Unable to update the password. The value provided for the new password does not meet the length, complexity, or history requirements of the domain.")]
    ERROR_PASSWORD_RESTRICTION = 1325,
    [Description("The user name or password is incorrect.")]
    ERROR_LOGON_FAILURE = 1326,
    [Description("Account restrictions are preventing this user from signing in. For example: blank passwords aren't allowed, sign-in times are limited, or a policy restriction has been enforced.")]
    ERROR_ACCOUNT_RESTRICTION = 1327,
    [Description("Your account has time restrictions that keep you from signing in right now.")]
    ERROR_INVALID_LOGON_HOURS = 1328,
    [Description("This user isn't allowed to sign in to this computer.")]
    ERROR_INVALID_WORKSTATION = 1329,
    [Description("The password for this account has expired.")]
    ERROR_PASSWORD_EXPIRED = 1330,
    [Description("This user can't sign in because this account is currently disabled.")]
    ERROR_ACCOUNT_DISABLED = 1331,
    [Description("No mapping between account names and security IDs was done.")]
    ERROR_NONE_MAPPED = 1332,
    [Description("Too many local user identifiers (LUIDs) were requested at one time.")]
    ERROR_TOO_MANY_LUIDS_REQUESTED = 1333,
    [Description("No more local user identifiers (LUIDs) are available.")]
    ERROR_LUIDS_EXHAUSTED = 1334,
    [Description("The subauthority part of a security ID is invalid for this particular use.")]
    ERROR_INVALID_SUB_AUTHORITY = 1335,
    [Description("The access control list (ACL) structure is invalid.")]
    ERROR_INVALID_ACL = 1336,
    [Description("The security ID structure is invalid.")]
    ERROR_INVALID_SID = 1337,
    [Description("The security descriptor structure is invalid.")]
    ERROR_INVALID_SECURITY_DESCR = 1338,
    [Description("The inherited access control list (ACL) or access control entry (ACE) could not be built.")]
    ERROR_BAD_INHERITANCE_ACL = 1340,
    [Description("The server is currently disabled.")]
    ERROR_SERVER_DISABLED = 1341,
    [Description("The server is currently enabled.")]
    ERROR_SERVER_NOT_DISABLED = 1342,
    [Description("The value provided was an invalid value for an identifier authority.")]
    ERROR_INVALID_ID_AUTHORITY = 1343,
    [Description("No more memory is available for security information updates.")]
    ERROR_ALLOTTED_SPACE_EXCEEDED = 1344,
    [Description("The specified attributes are invalid, or incompatible with the attributes for the group as a whole.")]
    ERROR_INVALID_GROUP_ATTRIBUTES = 1345,
    [Description("Either a required impersonation level was not provided, or the provided impersonation level is invalid.")]
    ERROR_BAD_IMPERSONATION_LEVEL = 1346,
    [Description("Cannot open an anonymous level security token.")]
    ERROR_CANT_OPEN_ANONYMOUS = 1347,
    [Description("The validation information class requested was invalid.")]
    ERROR_BAD_VALIDATION_CLASS = 1348,
    [Description("The type of the token is inappropriate for its attempted use.")]
    ERROR_BAD_TOKEN_TYPE = 1349,
    [Description("Unable to perform a security operation on an object that has no associated security.")]
    ERROR_NO_SECURITY_ON_OBJECT = 1350,
    [Description("Configuration information could not be read from the domain controller, either because the machine is unavailable, or access has been denied.")]
    ERROR_CANT_ACCESS_DOMAIN_INFO = 1351,
    [Description("The security account manager (SAM) or local security authority (LSA) server was in the wrong state to perform the security operation.")]
    ERROR_INVALID_SERVER_STATE = 1352,
    [Description("The domain was in the wrong state to perform the security operation.")]
    ERROR_INVALID_DOMAIN_STATE = 1353,
    [Description("This operation is only allowed for the Primary Domain Controller of the domain.")]
    ERROR_INVALID_DOMAIN_ROLE = 1354,
    [Description("The specified domain either does not exist or could not be contacted.")]
    ERROR_NO_SUCH_DOMAIN = 1355,
    [Description("The specified domain already exists.")]
    ERROR_DOMAIN_EXISTS = 1356,
    [Description("An attempt was made to exceed the limit on the number of domains per server.")]
    ERROR_DOMAIN_LIMIT_EXCEEDED = 1357,
    [Description("Unable to complete the requested operation because of either a catastrophic media failure or a data structure corruption on the disk.")]
    ERROR_INTERNAL_DB_CORRUPTION = 1358,
    [Description("An internal error occurred.")]
    ERROR_INTERNAL_ERROR = 1359,
    [Description("Generic access types were contained in an access mask which should already be mapped to nongeneric types.")]
    ERROR_GENERIC_NOT_MAPPED = 1360,
    [Description("A security descriptor is not in the right format (absolute or self-relative).")]
    ERROR_BAD_DESCRIPTOR_FORMAT = 1361,
    [Description("The requested action is restricted for use by logon processes only. The calling process has not registered as a logon process.")]
    ERROR_NOT_LOGON_PROCESS = 1362,
    [Description("Cannot start a new logon session with an ID that is already in use.")]
    ERROR_LOGON_SESSION_EXISTS = 1363,
    [Description("A specified authentication package is unknown.")]
    ERROR_NO_SUCH_PACKAGE = 1364,
    [Description("The logon session is not in a state that is consistent with the requested operation.")]
    ERROR_BAD_LOGON_SESSION_STATE = 1365,
    [Description("The logon session ID is already in use.")]
    ERROR_LOGON_SESSION_COLLISION = 1366,
    [Description("A logon request contained an invalid logon type value.")]
    ERROR_INVALID_LOGON_TYPE = 1367,
    [Description("Unable to impersonate using a named pipe until data has been read from that pipe.")]
    ERROR_CANNOT_IMPERSONATE = 1368,
    [Description("The transaction state of a registry subtree is incompatible with the requested operation.")]
    ERROR_RXACT_INVALID_STATE = 1369,
    [Description("An internal security database corruption has been encountered.")]
    ERROR_RXACT_COMMIT_FAILURE = 1370,
    [Description("Cannot perform this operation on built-in accounts.")]
    ERROR_SPECIAL_ACCOUNT = 1371,
    [Description("Cannot perform this operation on this built-in special group.")]
    ERROR_SPECIAL_GROUP = 1372,
    [Description("Cannot perform this operation on this built-in special user.")]
    ERROR_SPECIAL_USER = 1373,
    [Description("The user cannot be removed from a group because the group is currently the user's primary group.")]
    ERROR_MEMBERS_PRIMARY_GROUP = 1374,
    [Description("The token is already in use as a primary token.")]
    ERROR_TOKEN_ALREADY_IN_USE = 1375,
    [Description("The specified local group does not exist.")]
    ERROR_NO_SUCH_ALIAS = 1376,
    [Description("The specified account name is not a member of the group.")]
    ERROR_MEMBER_NOT_IN_ALIAS = 1377,
    [Description("The specified account name is already a member of the group.")]
    ERROR_MEMBER_IN_ALIAS = 1378,
    [Description("The specified local group already exists.")]
    ERROR_ALIAS_EXISTS = 1379,
    [Description("Logon failure: the user has not been granted the requested logon type at this computer.")]
    ERROR_LOGON_NOT_GRANTED = 1380,
    [Description("The maximum number of secrets that may be stored in a single system has been exceeded.")]
    ERROR_TOO_MANY_SECRETS = 1381,
    [Description("The length of a secret exceeds the maximum length allowed.")]
    ERROR_SECRET_TOO_LONG = 1382,
    [Description("The local security authority database contains an internal inconsistency.")]
    ERROR_INTERNAL_DB_ERROR = 1383,
    [Description("During a logon attempt, the user's security context accumulated too many security IDs.")]
    ERROR_TOO_MANY_CONTEXT_IDS = 1384,
    [Description("Logon failure: the user has not been granted the requested logon type at this computer.")]
    ERROR_LOGON_TYPE_NOT_GRANTED = 1385,
    [Description("A cross-encrypted password is necessary to change a user password.")]
    ERROR_NT_CROSS_ENCRYPTION_REQUIRED = 1386,
    [Description("A member could not be added to or removed from the local group because the member does not exist.")]
    ERROR_NO_SUCH_MEMBER = 1387,
    [Description("A new member could not be added to a local group because the member has the wrong account type.")]
    ERROR_INVALID_MEMBER = 1388,
    [Description("Too many security IDs have been specified.")]
    ERROR_TOO_MANY_SIDS = 1389,
    [Description("A cross-encrypted password is necessary to change this user password.")]
    ERROR_LM_CROSS_ENCRYPTION_REQUIRED = 1390,
    [Description("Indicates an ACL contains no inheritable components.")]
    ERROR_NO_INHERITANCE = 1391,
    [Description("The file or directory is corrupted and unreadable.")]
    ERROR_FILE_CORRUPT = 1392,
    [Description("The disk structure is corrupted and unreadable.")]
    ERROR_DISK_CORRUPT = 1393,
    [Description("There is no user session key for the specified logon session.")]
    ERROR_NO_USER_SESSION_KEY = 1394,
    [Description("The service being accessed is licensed for a particular number of connections. No more connections can be made to the service at this time because there are already as many connections as the service can accept.")]
    ERROR_LICENSE_QUOTA_EXCEEDED = 1395,
    [Description("The target account name is incorrect.")]
    ERROR_WRONG_TARGET_NAME = 1396,
    [Description("Mutual Authentication failed. The server's password is out of date at the domain controller.")]
    ERROR_MUTUAL_AUTH_FAILED = 1397,
    [Description("There is a time and/or date difference between the client and server.")]
    ERROR_TIME_SKEW = 1398,
    [Description("This operation cannot be performed on the current domain.")]
    ERROR_CURRENT_DOMAIN_NOT_ALLOWED = 1399,
    [Description("Invalid window handle.")]
    ERROR_INVALID_WINDOW_HANDLE = 1400,
    [Description("Invalid menu handle.")]
    ERROR_INVALID_MENU_HANDLE = 1401,
    [Description("Invalid cursor handle.")]
    ERROR_INVALID_CURSOR_HANDLE = 1402,
    [Description("Invalid accelerator table handle.")]
    ERROR_INVALID_ACCEL_HANDLE = 1403,
    [Description("Invalid hook handle.")]
    ERROR_INVALID_HOOK_HANDLE = 1404,
    [Description("Invalid handle to a multiple-window position structure.")]
    ERROR_INVALID_DWP_HANDLE = 1405,
    [Description("Cannot create a top-level child window.")]
    ERROR_TLW_WITH_WSCHILD = 1406,
    [Description("Cannot find window class.")]
    ERROR_CANNOT_FIND_WND_CLASS = 1407,
    [Description("Invalid window; it belongs to other thread.")]
    ERROR_WINDOW_OF_OTHER_THREAD = 1408,
    [Description("Hot key is already registered.")]
    ERROR_HOTKEY_ALREADY_REGISTERED = 1409,
    [Description("Class already exists.")]
    ERROR_CLASS_ALREADY_EXISTS = 1410,
    [Description("Class does not exist.")]
    ERROR_CLASS_DOES_NOT_EXIST = 1411,
    [Description("Class still has open windows.")]
    ERROR_CLASS_HAS_WINDOWS = 1412,
    [Description("Invalid index.")]
    ERROR_INVALID_INDEX = 1413,
    [Description("Invalid icon handle.")]
    ERROR_INVALID_ICON_HANDLE = 1414,
    [Description("Using private DIALOG window words.")]
    ERROR_PRIVATE_DIALOG_INDEX = 1415,
    [Description("The list box identifier was not found.")]
    ERROR_LISTBOX_ID_NOT_FOUND = 1416,
    [Description("No wildcards were found.")]
    ERROR_NO_WILDCARD_CHARACTERS = 1417,
    [Description("Thread does not have a clipboard open.")]
    ERROR_CLIPBOARD_NOT_OPEN = 1418,
    [Description("Hot key is not registered.")]
    ERROR_HOTKEY_NOT_REGISTERED = 1419,
    [Description("The window is not a valid dialog window.")]
    ERROR_WINDOW_NOT_DIALOG = 1420,
    [Description("Control ID not found.")]
    ERROR_CONTROL_ID_NOT_FOUND = 1421,
    [Description("Invalid message for a combo box because it does not have an edit control.")]
    ERROR_INVALID_COMBOBOX_MESSAGE = 1422,
    [Description("The window is not a combo box.")]
    ERROR_WINDOW_NOT_COMBOBOX = 1423,
    [Description("Height must be less than 256.")]
    ERROR_INVALID_EDIT_HEIGHT = 1424,
    [Description("Invalid device context (DC) handle.")]
    ERROR_DC_NOT_FOUND = 1425,
    [Description("Invalid hook procedure type.")]
    ERROR_INVALID_HOOK_FILTER = 1426,
    [Description("Invalid hook procedure.")]
    ERROR_INVALID_FILTER_PROC = 1427,
    [Description("Cannot set nonlocal hook without a module handle.")]
    ERROR_HOOK_NEEDS_HMOD = 1428,
    [Description("This hook procedure can only be set globally.")]
    ERROR_GLOBAL_ONLY_HOOK = 1429,
    [Description("The journal hook procedure is already installed.")]
    ERROR_JOURNAL_HOOK_SET = 1430,
    [Description("The hook procedure is not installed.")]
    ERROR_HOOK_NOT_INSTALLED = 1431,
    [Description("Invalid message for single-selection list box.")]
    ERROR_INVALID_LB_MESSAGE = 1432,
    [Description("LB_SETCOUNT sent to non-lazy list box.")]
    ERROR_SETCOUNT_ON_BAD_LB = 1433,
    [Description("This list box does not support tab stops.")]
    ERROR_LB_WITHOUT_TABSTOPS = 1434,
    [Description("Cannot destroy object created by another thread.")]
    ERROR_DESTROY_OBJECT_OF_OTHER_THREAD = 1435,
    [Description("Child windows cannot have menus.")]
    ERROR_CHILD_WINDOW_MENU = 1436,
    [Description("The window does not have a system menu.")]
    ERROR_NO_SYSTEM_MENU = 1437,
    [Description("Invalid message box style.")]
    ERROR_INVALID_MSGBOX_STYLE = 1438,
    [Description("Invalid system-wide (SPI_*) parameter.")]
    ERROR_INVALID_SPI_VALUE = 1439,
    [Description("Screen already locked.")]
    ERROR_SCREEN_ALREADY_LOCKED = 1440,
    [Description("All handles to windows in a multiple-window position structure must have the same parent.")]
    ERROR_HWNDS_HAVE_DIFF_PARENT = 1441,
    [Description("The window is not a child window.")]
    ERROR_NOT_CHILD_WINDOW = 1442,
    [Description("Invalid GW_* command.")]
    ERROR_INVALID_GW_COMMAND = 1443,
    [Description("Invalid thread identifier.")]
    ERROR_INVALID_THREAD_ID = 1444,
    [Description("Cannot process a message from a window that is not a multiple document interface (MDI) window.")]
    ERROR_NON_MDICHILD_WINDOW = 1445,
    [Description("Popup menu already active.")]
    ERROR_POPUP_ALREADY_ACTIVE = 1446,
    [Description("The window does not have scroll bars.")]
    ERROR_NO_SCROLLBARS = 1447,
    [Description("Scroll bar range cannot be greater than MAXLONG.")]
    ERROR_INVALID_SCROLLBAR_RANGE = 1448,
    [Description("Cannot show or remove the window in the way specified.")]
    ERROR_INVALID_SHOWWIN_COMMAND = 1449,
    [Description("Insufficient system resources exist to complete the requested service.")]
    ERROR_NO_SYSTEM_RESOURCES = 1450,
    [Description("Insufficient system resources exist to complete the requested service.")]
    ERROR_NONPAGED_SYSTEM_RESOURCES = 1451,
    [Description("Insufficient system resources exist to complete the requested service.")]
    ERROR_PAGED_SYSTEM_RESOURCES = 1452,
    [Description("Insufficient quota to complete the requested service.")]
    ERROR_WORKING_SET_QUOTA = 1453,
    [Description("Insufficient quota to complete the requested service.")]
    ERROR_PAGEFILE_QUOTA = 1454,
    [Description("The paging file is too small for this operation to complete.")]
    ERROR_COMMITMENT_LIMIT = 1455,
    [Description("A menu item was not found.")]
    ERROR_MENU_ITEM_NOT_FOUND = 1456,
    [Description("Invalid keyboard layout handle.")]
    ERROR_INVALID_KEYBOARD_HANDLE = 1457,
    [Description("Hook type not allowed.")]
    ERROR_HOOK_TYPE_NOT_ALLOWED = 1458,
    [Description("This operation requires an interactive window station.")]
    ERROR_REQUIRES_INTERACTIVE_WINDOWSTATION = 1459,
    [Description("This operation returned because the timeout period expired.")]
    ERROR_TIMEOUT = 1460,
    [Description("Invalid monitor handle.")]
    ERROR_INVALID_MONITOR_HANDLE = 1461,
    [Description("Incorrect size argument.")]
    ERROR_INCORRECT_SIZE = 1462,
    [Description("The symbolic link cannot be followed because its type is disabled.")]
    ERROR_SYMLINK_CLASS_DISABLED = 1463,
    [Description("This application does not support the current operation on symbolic links.")]
    ERROR_SYMLINK_NOT_SUPPORTED = 1464,
    [Description("Windows was unable to parse the requested XML data.")]
    ERROR_XML_PARSE_ERROR = 1465,
    [Description("An error was encountered while processing an XML digital signature.")]
    ERROR_XMLDSIG_ERROR = 1466,
    [Description("This application must be restarted.")]
    ERROR_RESTART_APPLICATION = 1467,
    [Description("The caller made the connection request in the wrong routing compartment.")]
    ERROR_WRONG_COMPARTMENT = 1468,
    [Description("There was an AuthIP failure when attempting to connect to the remote host.")]
    ERROR_AUTHIP_FAILURE = 1469,
    [Description("Insufficient NVRAM resources exist to complete the requested service. A reboot might be required.")]
    ERROR_NO_NVRAM_RESOURCES = 1470,
    [Description("Unable to finish the requested operation because the specified process is not a GUI process.")]
    ERROR_NOT_GUI_PROCESS = 1471,
    [Description("The event log file is corrupted.")]
    ERROR_EVENTLOG_FILE_CORRUPT = 1500,
    [Description("No event log file could be opened, so the event logging service did not start.")]
    ERROR_EVENTLOG_CANT_START = 1501,
    [Description("The event log file is full.")]
    ERROR_LOG_FILE_FULL = 1502,
    [Description("The event log file has changed between read operations.")]
    ERROR_EVENTLOG_FILE_CHANGED = 1503,
    [Description("The specified task name is invalid.")]
    ERROR_INVALID_TASK_NAME = 1550,
    [Description("The specified task index is invalid.")]
    ERROR_INVALID_TASK_INDEX = 1551,
    [Description("The specified thread is already joining a task.")]
    ERROR_THREAD_ALREADY_IN_TASK = 1552,
    [Description("The Windows Installer Service could not be accessed. This can occur if the Windows Installer is not correctly installed. Contact your support personnel for assistance.")]
    ERROR_INSTALL_SERVICE_FAILURE = 1601,
    [Description("User cancelled installation.")]
    ERROR_INSTALL_USEREXIT = 1602,
    [Description("Fatal error during installation.")]
    ERROR_INSTALL_FAILURE = 1603,
    [Description("Installation suspended, incomplete.")]
    ERROR_INSTALL_SUSPEND = 1604,
    [Description("This action is only valid for products that are currently installed.")]
    ERROR_UNKNOWN_PRODUCT = 1605,
    [Description("Feature ID not registered.")]
    ERROR_UNKNOWN_FEATURE = 1606,
    [Description("Component ID not registered.")]
    ERROR_UNKNOWN_COMPONENT = 1607,
    [Description("Unknown property.")]
    ERROR_UNKNOWN_PROPERTY = 1608,
    [Description("Handle is in an invalid state.")]
    ERROR_INVALID_HANDLE_STATE = 1609,
    [Description("The configuration data for this product is corrupt. Contact your support personnel.")]
    ERROR_BAD_CONFIGURATION = 1610,
    [Description("Component qualifier not present.")]
    ERROR_INDEX_ABSENT = 1611,
    [Description("The installation source for this product is not available. Verify that the source exists and that you can access it.")]
    ERROR_INSTALL_SOURCE_ABSENT = 1612,
    [Description("This installation package cannot be installed by the Windows Installer service. You must install a Windows service pack that contains a newer version of the Windows Installer service.")]
    ERROR_INSTALL_PACKAGE_VERSION = 1613,
    [Description("Product is uninstalled.")]
    ERROR_PRODUCT_UNINSTALLED = 1614,
    [Description("SQL query syntax invalid or unsupported.")]
    ERROR_BAD_QUERY_SYNTAX = 1615,
    [Description("Record field does not exist.")]
    ERROR_INVALID_FIELD = 1616,
    [Description("The device has been removed.")]
    ERROR_DEVICE_REMOVED = 1617,
    [Description("Another installation is already in progress. Complete that installation before proceeding with this install.")]
    ERROR_INSTALL_ALREADY_RUNNING = 1618,
    [Description("This installation package could not be opened. Verify that the package exists and that you can access it, or contact the application vendor to verify that this is a valid Windows Installer package.")]
    ERROR_INSTALL_PACKAGE_OPEN_FAILED = 1619,
    [Description("This installation package could not be opened. Contact the application vendor to verify that this is a valid Windows Installer package.")]
    ERROR_INSTALL_PACKAGE_INVALID = 1620,
    [Description("There was an error starting the Windows Installer service user interface. Contact your support personnel.")]
    ERROR_INSTALL_UI_FAILURE = 1621,
    [Description("Error opening installation log file. Verify that the specified log file location exists and that you can write to it.")]
    ERROR_INSTALL_LOG_FAILURE = 1622,
    [Description("The language of this installation package is not supported by your system.")]
    ERROR_INSTALL_LANGUAGE_UNSUPPORTED = 1623,
    [Description("Error applying transforms. Verify that the specified transform paths are valid.")]
    ERROR_INSTALL_TRANSFORM_FAILURE = 1624,
    [Description("This installation is forbidden by system policy. Contact your system administrator.")]
    ERROR_INSTALL_PACKAGE_REJECTED = 1625,
    [Description("Function could not be executed.")]
    ERROR_FUNCTION_NOT_CALLED = 1626,
    [Description("Function failed during execution.")]
    ERROR_FUNCTION_FAILED = 1627,
    [Description("Invalid or unknown table specified.")]
    ERROR_INVALID_TABLE = 1628,
    [Description("Data supplied is of wrong type.")]
    ERROR_DATATYPE_MISMATCH = 1629,
    [Description("Data of this type is not supported.")]
    ERROR_UNSUPPORTED_TYPE = 1630,
    [Description("The Windows Installer service failed to start. Contact your support personnel.")]
    ERROR_CREATE_FAILED = 1631,
    [Description("The Temp folder is on a drive that is full or is inaccessible. Free up space on the drive or verify that you have write permission on the Temp folder.")]
    ERROR_INSTALL_TEMP_UNWRITABLE = 1632,
    [Description("This installation package is not supported by this processor type. Contact your product vendor.")]
    ERROR_INSTALL_PLATFORM_UNSUPPORTED = 1633,
    [Description("Component not used on this computer.")]
    ERROR_INSTALL_NOTUSED = 1634,
    [Description("This update package could not be opened. Verify that the update package exists and that you can access it, or contact the application vendor to verify that this is a valid Windows Installer update package.")]
    ERROR_PATCH_PACKAGE_OPEN_FAILED = 1635,
    [Description("This update package could not be opened. Contact the application vendor to verify that this is a valid Windows Installer update package.")]
    ERROR_PATCH_PACKAGE_INVALID = 1636,
    [Description("This update package cannot be processed by the Windows Installer service. You must install a Windows service pack that contains a newer version of the Windows Installer service.")]
    ERROR_PATCH_PACKAGE_UNSUPPORTED = 1637,
    [Description("Another version of this product is already installed. Installation of this version cannot continue. To configure or remove the existing version of this product, use Add/Remove Programs on the Control Panel.")]
    ERROR_PRODUCT_VERSION = 1638,
    [Description("Invalid command line argument. Consult the Windows Installer SDK for detailed command line help.")]
    ERROR_INVALID_COMMAND_LINE = 1639,
    [Description("Only administrators have permission to add, remove, or configure server software during a Terminal services remote session. If you want to install or configure software on the server, contact your network administrator.")]
    ERROR_INSTALL_REMOTE_DISALLOWED = 1640,
    [Description("The requested operation completed successfully. The system will be restarted so the changes can take effect.")]
    ERROR_SUCCESS_REBOOT_INITIATED = 1641,
    [Description("The upgrade cannot be installed by the Windows Installer service because the program to be upgraded may be missing, or the upgrade may update a different version of the program. Verify that the program to be upgraded exists on your computer and that you have the correct upgrade.")]
    ERROR_PATCH_TARGET_NOT_FOUND = 1642,
    [Description("The update package is not permitted by software restriction policy.")]
    ERROR_PATCH_PACKAGE_REJECTED = 1643,
    [Description("One or more customizations are not permitted by software restriction policy.")]
    ERROR_INSTALL_TRANSFORM_REJECTED = 1644,
    [Description("The Windows Installer does not permit installation from a Remote Desktop Connection.")]
    ERROR_INSTALL_REMOTE_PROHIBITED = 1645,
    [Description("Uninstallation of the update package is not supported.")]
    ERROR_PATCH_REMOVAL_UNSUPPORTED = 1646,
    [Description("The update is not applied to this product.")]
    ERROR_UNKNOWN_PATCH = 1647,
    [Description("No valid sequence could be found for the set of updates.")]
    ERROR_PATCH_NO_SEQUENCE = 1648,
    [Description("Update removal was disallowed by policy.")]
    ERROR_PATCH_REMOVAL_DISALLOWED = 1649,
    [Description("The XML update data is invalid.")]
    ERROR_INVALID_PATCH_XML = 1650,
    [Description("Windows Installer does not permit updating of managed advertised products. At least one feature of the product must be installed before applying the update.")]
    ERROR_PATCH_MANAGED_ADVERTISED_PRODUCT = 1651,
    [Description("The Windows Installer service is not accessible in Safe Mode. Please try again when your computer is not in Safe Mode or you can use System Restore to return your machine to a previous good state.")]
    ERROR_INSTALL_SERVICE_SAFEBOOT = 1652,
    [Description("A fail fast exception occurred. Exception handlers will not be invoked and the process will be terminated immediately.")]
    ERROR_FAIL_FAST_EXCEPTION = 1653,
    [Description("The app that you are trying to run is not supported on this version of Windows.")]
    ERROR_INSTALL_REJECTED = 1654,
    [Description("The string binding is invalid.")]
    RPC_S_INVALID_STRING_BINDING = 1700,
    [Description("The binding handle is not the correct type.")]
    RPC_S_WRONG_KIND_OF_BINDING = 1701,
    [Description("The binding handle is invalid.")]
    RPC_S_INVALID_BINDING = 1702,
    [Description("The RPC protocol sequence is not supported.")]
    RPC_S_PROTSEQ_NOT_SUPPORTED = 1703,
    [Description("The RPC protocol sequence is invalid.")]
    RPC_S_INVALID_RPC_PROTSEQ = 1704,
    [Description("The string universal unique identifier (UUID) is invalid.")]
    RPC_S_INVALID_STRING_UUID = 1705,
    [Description("The endpoint format is invalid.")]
    RPC_S_INVALID_ENDPOINT_FORMAT = 1706,
    [Description("The network address is invalid.")]
    RPC_S_INVALID_NET_ADDR = 1707,
    [Description("No endpoint was found.")]
    RPC_S_NO_ENDPOINT_FOUND = 1708,
    [Description("The timeout value is invalid.")]
    RPC_S_INVALID_TIMEOUT = 1709,
    [Description("The object universal unique identifier (UUID) was not found.")]
    RPC_S_OBJECT_NOT_FOUND = 1710,
    [Description("The object universal unique identifier (UUID) has already been registered.")]
    RPC_S_ALREADY_REGISTERED = 1711,
    [Description("The type universal unique identifier (UUID) has already been registered.")]
    RPC_S_TYPE_ALREADY_REGISTERED = 1712,
    [Description("The RPC server is already listening.")]
    RPC_S_ALREADY_LISTENING = 1713,
    [Description("No protocol sequences have been registered.")]
    RPC_S_NO_PROTSEQS_REGISTERED = 1714,
    [Description("The RPC server is not listening.")]
    RPC_S_NOT_LISTENING = 1715,
    [Description("The manager type is unknown.")]
    RPC_S_UNKNOWN_MGR_TYPE = 1716,
    [Description("The interface is unknown.")]
    RPC_S_UNKNOWN_IF = 1717,
    [Description("There are no bindings.")]
    RPC_S_NO_BINDINGS = 1718,
    [Description("There are no protocol sequences.")]
    RPC_S_NO_PROTSEQS = 1719,
    [Description("The endpoint cannot be created.")]
    RPC_S_CANT_CREATE_ENDPOINT = 1720,
    [Description("Not enough resources are available to complete this operation.")]
    RPC_S_OUT_OF_RESOURCES = 1721,
    [Description("The RPC server is unavailable.")]
    RPC_S_SERVER_UNAVAILABLE = 1722,
    [Description("The RPC server is too busy to complete this operation.")]
    RPC_S_SERVER_TOO_BUSY = 1723,
    [Description("The network options are invalid.")]
    RPC_S_INVALID_NETWORK_OPTIONS = 1724,
    [Description("There are no remote procedure calls active on this thread.")]
    RPC_S_NO_CALL_ACTIVE = 1725,
    [Description("The remote procedure call failed.")]
    RPC_S_CALL_FAILED = 1726,
    [Description("The remote procedure call failed and did not execute.")]
    RPC_S_CALL_FAILED_DNE = 1727,
    [Description("A remote procedure call (RPC) protocol error occurred.")]
    RPC_S_PROTOCOL_ERROR = 1728,
    [Description("Access to the HTTP proxy is denied.")]
    RPC_S_PROXY_ACCESS_DENIED = 1729,
    [Description("The transfer syntax is not supported by the RPC server.")]
    RPC_S_UNSUPPORTED_TRANS_SYN = 1730,
    [Description("The universal unique identifier (UUID) type is not supported.")]
    RPC_S_UNSUPPORTED_TYPE = 1732,
    [Description("The tag is invalid.")]
    RPC_S_INVALID_TAG = 1733,
    [Description("The array bounds are invalid.")]
    RPC_S_INVALID_BOUND = 1734,
    [Description("The binding does not contain an entry name.")]
    RPC_S_NO_ENTRY_NAME = 1735,
    [Description("The name syntax is invalid.")]
    RPC_S_INVALID_NAME_SYNTAX = 1736,
    [Description("The name syntax is not supported.")]
    RPC_S_UNSUPPORTED_NAME_SYNTAX = 1737,
    [Description("No network address is available to use to construct a universal unique identifier (UUID).")]
    RPC_S_UUID_NO_ADDRESS = 1739,
    [Description("The endpoint is a duplicate.")]
    RPC_S_DUPLICATE_ENDPOINT = 1740,
    [Description("The authentication type is unknown.")]
    RPC_S_UNKNOWN_AUTHN_TYPE = 1741,
    [Description("The maximum number of calls is too small.")]
    RPC_S_MAX_CALLS_TOO_SMALL = 1742,
    [Description("The string is too long.")]
    RPC_S_STRING_TOO_LONG = 1743,
    [Description("The RPC protocol sequence was not found.")]
    RPC_S_PROTSEQ_NOT_FOUND = 1744,
    [Description("The procedure number is out of range.")]
    RPC_S_PROCNUM_OUT_OF_RANGE = 1745,
    [Description("The binding does not contain any authentication information.")]
    RPC_S_BINDING_HAS_NO_AUTH = 1746,
    [Description("The authentication service is unknown.")]
    RPC_S_UNKNOWN_AUTHN_SERVICE = 1747,
    [Description("The authentication level is unknown.")]
    RPC_S_UNKNOWN_AUTHN_LEVEL = 1748,
    [Description("The security context is invalid.")]
    RPC_S_INVALID_AUTH_IDENTITY = 1749,
    [Description("The authorization service is unknown.")]
    RPC_S_UNKNOWN_AUTHZ_SERVICE = 1750,
    [Description("The entry is invalid.")]
    EPT_S_INVALID_ENTRY = 1751,
    [Description("The server endpoint cannot perform the operation.")]
    EPT_S_CANT_PERFORM_OP = 1752,
    [Description("There are no more endpoints available from the endpoint mapper.")]
    EPT_S_NOT_REGISTERED = 1753,
    [Description("No interfaces have been exported.")]
    RPC_S_NOTHING_TO_EXPORT = 1754,
    [Description("The entry name is incomplete.")]
    RPC_S_INCOMPLETE_NAME = 1755,
    [Description("The version option is invalid.")]
    RPC_S_INVALID_VERS_OPTION = 1756,
    [Description("There are no more members.")]
    RPC_S_NO_MORE_MEMBERS = 1757,
    [Description("There is nothing to unexport.")]
    RPC_S_NOT_ALL_OBJS_UNEXPORTED = 1758,
    [Description("The interface was not found.")]
    RPC_S_INTERFACE_NOT_FOUND = 1759,
    [Description("The entry already exists.")]
    RPC_S_ENTRY_ALREADY_EXISTS = 1760,
    [Description("The entry is not found.")]
    RPC_S_ENTRY_NOT_FOUND = 1761,
    [Description("The name service is unavailable.")]
    RPC_S_NAME_SERVICE_UNAVAILABLE = 1762,
    [Description("The network address family is invalid.")]
    RPC_S_INVALID_NAF_ID = 1763,
    [Description("The requested operation is not supported.")]
    RPC_S_CANNOT_SUPPORT = 1764,
    [Description("No security context is available to allow impersonation.")]
    RPC_S_NO_CONTEXT_AVAILABLE = 1765,
    [Description("An internal error occurred in a remote procedure call (RPC).")]
    RPC_S_INTERNAL_ERROR = 1766,
    [Description("The RPC server attempted an integer division by zero.")]
    RPC_S_ZERO_DIVIDE = 1767,
    [Description("An addressing error occurred in the RPC server.")]
    RPC_S_ADDRESS_ERROR = 1768,
    [Description("A floating-point operation at the RPC server caused a division by zero.")]
    RPC_S_FP_DIV_ZERO = 1769,
    [Description("A floating-point underflow occurred at the RPC server.")]
    RPC_S_FP_UNDERFLOW = 1770,
    [Description("A floating-point overflow occurred at the RPC server.")]
    RPC_S_FP_OVERFLOW = 1771,
    [Description("The list of RPC servers available for the binding of auto handles has been exhausted.")]
    RPC_X_NO_MORE_ENTRIES = 1772,
    [Description("Unable to open the character translation table file.")]
    RPC_X_SS_CHAR_TRANS_OPEN_FAIL = 1773,
    [Description("The file containing the character translation table has fewer than 512 bytes.")]
    RPC_X_SS_CHAR_TRANS_SHORT_FILE = 1774,
    [Description("A null context handle was passed from the client to the host during a remote procedure call.")]
    RPC_X_SS_IN_NULL_CONTEXT = 1775,
    [Description("The context handle changed during a remote procedure call.")]
    RPC_X_SS_CONTEXT_DAMAGED = 1777,
    [Description("The binding handles passed to a remote procedure call do not match.")]
    RPC_X_SS_HANDLES_MISMATCH = 1778,
    [Description("The stub is unable to get the remote procedure call handle.")]
    RPC_X_SS_CANNOT_GET_CALL_HANDLE = 1779,
    [Description("A null reference pointer was passed to the stub.")]
    RPC_X_NULL_REF_POINTER = 1780,
    [Description("The enumeration value is out of range.")]
    RPC_X_ENUM_VALUE_OUT_OF_RANGE = 1781,
    [Description("The byte count is too small.")]
    RPC_X_BYTE_COUNT_TOO_SMALL = 1782,
    [Description("The stub received bad data.")]
    RPC_X_BAD_STUB_DATA = 1783,
    [Description("The supplied user buffer is not valid for the requested operation.")]
    ERROR_INVALID_USER_BUFFER = 1784,
    [Description("The disk media is not recognized. It may not be formatted.")]
    ERROR_UNRECOGNIZED_MEDIA = 1785,
    [Description("The workstation does not have a trust secret.")]
    ERROR_NO_TRUST_LSA_SECRET = 1786,
    [Description("The security database on the server does not have a computer account for this workstation trust relationship.")]
    ERROR_NO_TRUST_SAM_ACCOUNT = 1787,
    [Description("The trust relationship between the primary domain and the trusted domain failed.")]
    ERROR_TRUSTED_DOMAIN_FAILURE = 1788,
    [Description("The trust relationship between this workstation and the primary domain failed.")]
    ERROR_TRUSTED_RELATIONSHIP_FAILURE = 1789,
    [Description("The network logon failed.")]
    ERROR_TRUST_FAILURE = 1790,
    [Description("A remote procedure call is already in progress for this thread.")]
    RPC_S_CALL_IN_PROGRESS = 1791,
    [Description("An attempt was made to logon, but the network logon service was not started.")]
    ERROR_NETLOGON_NOT_STARTED = 1792,
    [Description("The user's account has expired.")]
    ERROR_ACCOUNT_EXPIRED = 1793,
    [Description("The redirector is in use and cannot be unloaded.")]
    ERROR_REDIRECTOR_HAS_OPEN_HANDLES = 1794,
    [Description("The specified printer driver is already installed.")]
    ERROR_PRINTER_DRIVER_ALREADY_INSTALLED = 1795,
    [Description("The specified port is unknown.")]
    ERROR_UNKNOWN_PORT = 1796,
    [Description("The printer driver is unknown.")]
    ERROR_UNKNOWN_PRINTER_DRIVER = 1797,
    [Description("The print processor is unknown.")]
    ERROR_UNKNOWN_PRINTPROCESSOR = 1798,
    [Description("The specified separator file is invalid.")]
    ERROR_INVALID_SEPARATOR_FILE = 1799,
    [Description("The specified priority is invalid.")]
    ERROR_INVALID_PRIORITY = 1800,
    [Description("The printer name is invalid.")]
    ERROR_INVALID_PRINTER_NAME = 1801,
    [Description("The printer already exists.")]
    ERROR_PRINTER_ALREADY_EXISTS = 1802,
    [Description("The printer command is invalid.")]
    ERROR_INVALID_PRINTER_COMMAND = 1803,
    [Description("The specified datatype is invalid.")]
    ERROR_INVALID_DATATYPE = 1804,
    [Description("The environment specified is invalid.")]
    ERROR_INVALID_ENVIRONMENT = 1805,
    [Description("There are no more bindings.")]
    RPC_S_NO_MORE_BINDINGS = 1806,
    [Description("The account used is an interdomain trust account. Use your global user account or local user account to access this server.")]
    ERROR_NOLOGON_INTERDOMAIN_TRUST_ACCOUNT = 1807,
    [Description("The account used is a computer account. Use your global user account or local user account to access this server.")]
    ERROR_NOLOGON_WORKSTATION_TRUST_ACCOUNT = 1808,
    [Description("The account used is a server trust account. Use your global user account or local user account to access this server.")]
    ERROR_NOLOGON_SERVER_TRUST_ACCOUNT = 1809,
    [Description("The name or security ID (SID) of the domain specified is inconsistent with the trust information for that domain.")]
    ERROR_DOMAIN_TRUST_INCONSISTENT = 1810,
    [Description("The server is in use and cannot be unloaded.")]
    ERROR_SERVER_HAS_OPEN_HANDLES = 1811,
    [Description("The specified image file did not contain a resource section.")]
    ERROR_RESOURCE_DATA_NOT_FOUND = 1812,
    [Description("The specified resource type cannot be found in the image file.")]
    ERROR_RESOURCE_TYPE_NOT_FOUND = 1813,
    [Description("The specified resource name cannot be found in the image file.")]
    ERROR_RESOURCE_NAME_NOT_FOUND = 1814,
    [Description("The specified resource language ID cannot be found in the image file.")]
    ERROR_RESOURCE_LANG_NOT_FOUND = 1815,
    [Description("Not enough quota is available to process this command.")]
    ERROR_NOT_ENOUGH_QUOTA = 1816,
    [Description("No interfaces have been registered.")]
    RPC_S_NO_INTERFACES = 1817,
    [Description("The remote procedure call was cancelled.")]
    RPC_S_CALL_CANCELLED = 1818,
    [Description("The binding handle does not contain all required information.")]
    RPC_S_BINDING_INCOMPLETE = 1819,
    [Description("A communications failure occurred during a remote procedure call.")]
    RPC_S_COMM_FAILURE = 1820,
    [Description("The requested authentication level is not supported.")]
    RPC_S_UNSUPPORTED_AUTHN_LEVEL = 1821,
    [Description("No principal name registered.")]
    RPC_S_NO_PRINC_NAME = 1822,
    [Description("The error specified is not a valid Windows RPC error code.")]
    RPC_S_NOT_RPC_ERROR = 1823,
    [Description("A UUID that is valid only on this computer has been allocated.")]
    RPC_S_UUID_LOCAL_ONLY = 1824,
    [Description("A security package specific error occurred.")]
    RPC_S_SEC_PKG_ERROR = 1825,
    [Description("Thread is not canceled.")]
    RPC_S_NOT_CANCELLED = 1826,
    [Description("Invalid operation on the encoding/decoding handle.")]
    RPC_X_INVALID_ES_ACTION = 1827,
    [Description("Incompatible version of the serializing package.")]
    RPC_X_WRONG_ES_VERSION = 1828,
    [Description("Incompatible version of the RPC stub.")]
    RPC_X_WRONG_STUB_VERSION = 1829,
    [Description("The RPC pipe object is invalid or corrupted.")]
    RPC_X_INVALID_PIPE_OBJECT = 1830,
    [Description("An invalid operation was attempted on an RPC pipe object.")]
    RPC_X_WRONG_PIPE_ORDER = 1831,
    [Description("Unsupported RPC pipe version.")]
    RPC_X_WRONG_PIPE_VERSION = 1832,
    [Description("HTTP proxy server rejected the connection because the cookie authentication failed.")]
    RPC_S_COOKIE_AUTH_FAILED = 1833,
    [Description("The group member was not found.")]
    RPC_S_GROUP_MEMBER_NOT_FOUND = 1898,
    [Description("The endpoint mapper database entry could not be created.")]
    EPT_S_CANT_CREATE = 1899,
    [Description("The object universal unique identifier (UUID) is the nil UUID.")]
    RPC_S_INVALID_OBJECT = 1900,
    [Description("The specified time is invalid.")]
    ERROR_INVALID_TIME = 1901,
    [Description("The specified form name is invalid.")]
    ERROR_INVALID_FORM_NAME = 1902,
    [Description("The specified form size is invalid.")]
    ERROR_INVALID_FORM_SIZE = 1903,
    [Description("The specified printer handle is already being waited on.")]
    ERROR_ALREADY_WAITING = 1904,
    [Description("The specified printer has been deleted.")]
    ERROR_PRINTER_DELETED = 1905,
    [Description("The state of the printer is invalid.")]
    ERROR_INVALID_PRINTER_STATE = 1906,
    [Description("The user's password must be changed before signing in.")]
    ERROR_PASSWORD_MUST_CHANGE = 1907,
    [Description("Could not find the domain controller for this domain.")]
    ERROR_DOMAIN_CONTROLLER_NOT_FOUND = 1908,
    [Description("The referenced account is currently locked out and may not be logged on to.")]
    ERROR_ACCOUNT_LOCKED_OUT = 1909,
    [Description("The object exporter specified was not found.")]
    OR_INVALID_OXID = 1910,
    [Description("The object specified was not found.")]
    OR_INVALID_OID = 1911,
    [Description("The object resolver set specified was not found.")]
    OR_INVALID_SET = 1912,
    [Description("Some data remains to be sent in the request buffer.")]
    RPC_S_SEND_INCOMPLETE = 1913,
    [Description("Invalid asynchronous remote procedure call handle.")]
    RPC_S_INVALID_ASYNC_HANDLE = 1914,
    [Description("Invalid asynchronous RPC call handle for this operation.")]
    RPC_S_INVALID_ASYNC_CALL = 1915,
    [Description("The RPC pipe object has already been closed.")]
    RPC_X_PIPE_CLOSED = 1916,
    [Description("The RPC call completed before all pipes were processed.")]
    RPC_X_PIPE_DISCIPLINE_ERROR = 1917,
    [Description("No more data is available from the RPC pipe.")]
    RPC_X_PIPE_EMPTY = 1918,
    [Description("No site name is available for this machine.")]
    ERROR_NO_SITENAME = 1919,
    [Description("The file cannot be accessed by the system.")]
    ERROR_CANT_ACCESS_FILE = 1920,
    [Description("The name of the file cannot be resolved by the system.")]
    ERROR_CANT_RESOLVE_FILENAME = 1921,
    [Description("The entry is not of the expected type.")]
    RPC_S_ENTRY_TYPE_MISMATCH = 1922,
    [Description("Not all object UUIDs could be exported to the specified entry.")]
    RPC_S_NOT_ALL_OBJS_EXPORTED = 1923,
    [Description("Interface could not be exported to the specified entry.")]
    RPC_S_INTERFACE_NOT_EXPORTED = 1924,
    [Description("The specified profile entry could not be added.")]
    RPC_S_PROFILE_NOT_ADDED = 1925,
    [Description("The specified profile element could not be added.")]
    RPC_S_PRF_ELT_NOT_ADDED = 1926,
    [Description("The specified profile element could not be removed.")]
    RPC_S_PRF_ELT_NOT_REMOVED = 1927,
    [Description("The group element could not be added.")]
    RPC_S_GRP_ELT_NOT_ADDED = 1928,
    [Description("The group element could not be removed.")]
    RPC_S_GRP_ELT_NOT_REMOVED = 1929,
    [Description("The printer driver is not compatible with a policy enabled on your computer that blocks NT 4.0 drivers.")]
    ERROR_KM_DRIVER_BLOCKED = 1930,
    [Description("The context has expired and can no longer be used.")]
    ERROR_CONTEXT_EXPIRED = 1931,
    [Description("The current user's delegated trust creation quota has been exceeded.")]
    ERROR_PER_USER_TRUST_QUOTA_EXCEEDED = 1932,
    [Description("The total delegated trust creation quota has been exceeded.")]
    ERROR_ALL_USER_TRUST_QUOTA_EXCEEDED = 1933,
    [Description("The current user's delegated trust deletion quota has been exceeded.")]
    ERROR_USER_DELETE_TRUST_QUOTA_EXCEEDED = 1934,
    [Description("The computer you are signing into is protected by an authentication firewall. The specified account is not allowed to authenticate to the computer.")]
    ERROR_AUTHENTICATION_FIREWALL_FAILED = 1935,
    [Description("Remote connections to the Print Spooler are blocked by a policy set on your machine.")]
    ERROR_REMOTE_PRINT_CONNECTIONS_BLOCKED = 1936,
    [Description("Authentication failed because NTLM authentication has been disabled.")]
    ERROR_NTLM_BLOCKED = 1937,
    [Description("Logon Failure: EAS policy requires that the user change their password before this operation can be performed.")]
    ERROR_PASSWORD_CHANGE_REQUIRED = 1938,
    [Description("The pixel format is invalid.")]
    ERROR_INVALID_PIXEL_FORMAT = 2000,
    [Description("The specified driver is invalid.")]
    ERROR_BAD_DRIVER = 2001,
    [Description("The window style or class attribute is invalid for this operation.")]
    ERROR_INVALID_WINDOW_STYLE = 2002,
    [Description("The requested metafile operation is not supported.")]
    ERROR_METAFILE_NOT_SUPPORTED = 2003,
    [Description("The requested transformation operation is not supported.")]
    ERROR_TRANSFORM_NOT_SUPPORTED = 2004,
    [Description("The requested clipping operation is not supported.")]
    ERROR_CLIPPING_NOT_SUPPORTED = 2005,
    [Description("The specified color management module is invalid.")]
    ERROR_INVALID_CMM = 2010,
    [Description("The specified color profile is invalid.")]
    ERROR_INVALID_PROFILE = 2011,
    [Description("The specified tag was not found.")]
    ERROR_TAG_NOT_FOUND = 2012,
    [Description("A required tag is not present.")]
    ERROR_TAG_NOT_PRESENT = 2013,
    [Description("The specified tag is already present.")]
    ERROR_DUPLICATE_TAG = 2014,
    [Description("The specified color profile is not associated with the specified device.")]
    ERROR_PROFILE_NOT_ASSOCIATED_WITH_DEVICE = 2015,
    [Description("The specified color profile was not found.")]
    ERROR_PROFILE_NOT_FOUND = 2016,
    [Description("The specified color space is invalid.")]
    ERROR_INVALID_COLORSPACE = 2017,
    [Description("Image Color Management is not enabled.")]
    ERROR_ICM_NOT_ENABLED = 2018,
    [Description("There was an error while deleting the color transform.")]
    ERROR_DELETING_ICM_XFORM = 2019,
    [Description("The specified color transform is invalid.")]
    ERROR_INVALID_TRANSFORM = 2020,
    [Description("The specified transform does not match the bitmap's color space.")]
    ERROR_COLORSPACE_MISMATCH = 2021,
    [Description("The specified named color index is not present in the profile.")]
    ERROR_INVALID_COLORINDEX = 2022,
    [Description("The specified profile is intended for a device of a different type than the specified device.")]
    ERROR_PROFILE_DOES_NOT_MATCH_DEVICE = 2023,
    [Description("The network connection was made successfully, but the user had to be prompted for a password other than the one originally specified.")]
    ERROR_CONNECTED_OTHER_PASSWORD = 2108,
    [Description("The network connection was made successfully using default credentials.")]
    ERROR_CONNECTED_OTHER_PASSWORD_DEFAULT = 2109,
    [Description("The specified username is invalid.")]
    ERROR_BAD_USERNAME = 2202,
    [Description("This network connection does not exist.")]
    ERROR_NOT_CONNECTED = 2250,
    [Description("This network connection has files open or requests pending.")]
    ERROR_OPEN_FILES = 2401,
    [Description("Active connections still exist.")]
    ERROR_ACTIVE_CONNECTIONS = 2402,
    [Description("The device is in use by an active process and cannot be disconnected.")]
    ERROR_DEVICE_IN_USE = 2404,
    [Description("The specified print monitor is unknown.")]
    ERROR_UNKNOWN_PRINT_MONITOR = 3000,
    [Description("The specified printer driver is currently in use.")]
    ERROR_PRINTER_DRIVER_IN_USE = 3001,
    [Description("The spool file was not found.")]
    ERROR_SPOOL_FILE_NOT_FOUND = 3002,
    [Description("A StartDocPrinter call was not issued.")]
    ERROR_SPL_NO_STARTDOC = 3003,
    [Description("An AddJob call was not issued.")]
    ERROR_SPL_NO_ADDJOB = 3004,
    [Description("The specified print processor has already been installed.")]
    ERROR_PRINT_PROCESSOR_ALREADY_INSTALLED = 3005,
    [Description("The specified print monitor has already been installed.")]
    ERROR_PRINT_MONITOR_ALREADY_INSTALLED = 3006,
    [Description("The specified print monitor does not have the required functions.")]
    ERROR_INVALID_PRINT_MONITOR = 3007,
    [Description("The specified print monitor is currently in use.")]
    ERROR_PRINT_MONITOR_IN_USE = 3008,
    [Description("The requested operation is not allowed when there are jobs queued to the printer.")]
    ERROR_PRINTER_HAS_JOBS_QUEUED = 3009,
    [Description("The requested operation is successful. Changes will not be effective until the system is rebooted.")]
    ERROR_SUCCESS_REBOOT_REQUIRED = 3010,
    [Description("The requested operation is successful. Changes will not be effective until the service is restarted.")]
    ERROR_SUCCESS_RESTART_REQUIRED = 3011,
    [Description("No printers were found.")]
    ERROR_PRINTER_NOT_FOUND = 3012,
    [Description("The printer driver is known to be unreliable.")]
    ERROR_PRINTER_DRIVER_WARNED = 3013,
    [Description("The printer driver is known to harm the system.")]
    ERROR_PRINTER_DRIVER_BLOCKED = 3014,
    [Description("The specified printer driver package is currently in use.")]
    ERROR_PRINTER_DRIVER_PACKAGE_IN_USE = 3015,
    [Description("Unable to find a core driver package that is required by the printer driver package.")]
    ERROR_CORE_DRIVER_PACKAGE_NOT_FOUND = 3016,
    [Description("The requested operation failed. A system reboot is required to roll back changes made.")]
    ERROR_FAIL_REBOOT_REQUIRED = 3017,
    [Description("The requested operation failed. A system reboot has been initiated to roll back changes made.")]
    ERROR_FAIL_REBOOT_INITIATED = 3018,
    [Description("The specified printer driver was not found on the system and needs to be downloaded.")]
    ERROR_PRINTER_DRIVER_DOWNLOAD_NEEDED = 3019,
    [Description("The requested print job has failed to print. A print system update requires the job to be resubmitted.")]
    ERROR_PRINT_JOB_RESTART_REQUIRED = 3020,
    [Description("The printer driver does not contain a valid manifest, or contains too many manifests.")]
    ERROR_INVALID_PRINTER_DRIVER_MANIFEST = 3021,
    [Description("The specified printer cannot be shared.")]
    ERROR_PRINTER_NOT_SHAREABLE = 3022,
    [Description("The operation was paused.")]
    ERROR_REQUEST_PAUSED = 3050,
    [Description("Reissue the given operation as a cached IO operation.")]
    ERROR_IO_REISSUE_AS_CACHED = 3950,
    [Description("WINS encountered an error while processing the command.")]
    ERROR_WINS_INTERNAL = 4000,
    [Description("The local WINS cannot be deleted.")]
    ERROR_CAN_NOT_DEL_LOCAL_WINS = 4001,
    [Description("The importation from the file failed.")]
    ERROR_STATIC_INIT = 4002,
    [Description("The backup failed. Was a full backup done before?")]
    ERROR_INC_BACKUP = 4003,
    [Description("The backup failed. Check the directory to which you are backing the database.")]
    ERROR_FULL_BACKUP = 4004,
    [Description("The name does not exist in the WINS database.")]
    ERROR_REC_NON_EXISTENT = 4005,
    [Description("Replication with a nonconfigured partner is not allowed.")]
    ERROR_RPL_NOT_ALLOWED = 4006,
    [Description("The version of the supplied content information is not supported.")]
    PEERDIST_ERROR_CONTENTINFO_VERSION_UNSUPPORTED = 4050,
    [Description("The supplied content information is malformed.")]
    PEERDIST_ERROR_CANNOT_PARSE_CONTENTINFO = 4051,
    [Description("The requested data cannot be found in local or peer caches.")]
    PEERDIST_ERROR_MISSING_DATA = 4052,
    [Description("No more data is available or required.")]
    PEERDIST_ERROR_NO_MORE = 4053,
    [Description("The supplied object has not been initialized.")]
    PEERDIST_ERROR_NOT_INITIALIZED = 4054,
    [Description("The supplied object has already been initialized.")]
    PEERDIST_ERROR_ALREADY_INITIALIZED = 4055,
    [Description("A shutdown operation is already in progress.")]
    PEERDIST_ERROR_SHUTDOWN_IN_PROGRESS = 4056,
    [Description("The supplied object has already been invalidated.")]
    PEERDIST_ERROR_INVALIDATED = 4057,
    [Description("An element already exists and was not replaced.")]
    PEERDIST_ERROR_ALREADY_EXISTS = 4058,
    [Description("Can not cancel the requested operation as it has already been completed.")]
    PEERDIST_ERROR_OPERATION_NOTFOUND = 4059,
    [Description("Can not perform the reqested operation because it has already been carried out.")]
    PEERDIST_ERROR_ALREADY_COMPLETED = 4060,
    [Description("An operation accessed data beyond the bounds of valid data.")]
    PEERDIST_ERROR_OUT_OF_BOUNDS = 4061,
    [Description("The requested version is not supported.")]
    PEERDIST_ERROR_VERSION_UNSUPPORTED = 4062,
    [Description("A configuration value is invalid.")]
    PEERDIST_ERROR_INVALID_CONFIGURATION = 4063,
    [Description("The SKU is not licensed.")]
    PEERDIST_ERROR_NOT_LICENSED = 4064,
    [Description("PeerDist Service is still initializing and will be available shortly.")]
    PEERDIST_ERROR_SERVICE_UNAVAILABLE = 4065,
    [Description("Communication with one or more computers will be temporarily blocked due to recent errors.")]
    PEERDIST_ERROR_TRUST_FAILURE = 4066,
    [Description("The DHCP client has obtained an IP address that is already in use on the network. The local interface will be disabled until the DHCP client can obtain a new address.")]
    ERROR_DHCP_ADDRESS_CONFLICT = 4100,
    [Description("The GUID passed was not recognized as valid by a WMI data provider.")]
    ERROR_WMI_GUID_NOT_FOUND = 4200,
    [Description("The instance name passed was not recognized as valid by a WMI data provider.")]
    ERROR_WMI_INSTANCE_NOT_FOUND = 4201,
    [Description("The data item ID passed was not recognized as valid by a WMI data provider.")]
    ERROR_WMI_ITEMID_NOT_FOUND = 4202,
    [Description("The WMI request could not be completed and should be retried.")]
    ERROR_WMI_TRY_AGAIN = 4203,
    [Description("The WMI data provider could not be located.")]
    ERROR_WMI_DP_NOT_FOUND = 4204,
    [Description("The WMI data provider references an instance set that has not been registered.")]
    ERROR_WMI_UNRESOLVED_INSTANCE_REF = 4205,
    [Description("The WMI data block or event notification has already been enabled.")]
    ERROR_WMI_ALREADY_ENABLED = 4206,
    [Description("The WMI data block is no longer available.")]
    ERROR_WMI_GUID_DISCONNECTED = 4207,
    [Description("The WMI data service is not available.")]
    ERROR_WMI_SERVER_UNAVAILABLE = 4208,
    [Description("The WMI data provider failed to carry out the request.")]
    ERROR_WMI_DP_FAILED = 4209,
    [Description("The WMI MOF information is not valid.")]
    ERROR_WMI_INVALID_MOF = 4210,
    [Description("The WMI registration information is not valid.")]
    ERROR_WMI_INVALID_REGINFO = 4211,
    [Description("The WMI data block or event notification has already been disabled.")]
    ERROR_WMI_ALREADY_DISABLED = 4212,
    [Description("The WMI data item or data block is read only.")]
    ERROR_WMI_READ_ONLY = 4213,
    [Description("The WMI data item or data block could not be changed.")]
    ERROR_WMI_SET_FAILURE = 4214,
    [Description("This operation is only valid in the context of an app container.")]
    ERROR_NOT_APPCONTAINER = 4250,
    [Description("This application can only run in the context of an app container.")]
    ERROR_APPCONTAINER_REQUIRED = 4251,
    [Description("This functionality is not supported in the context of an app container.")]
    ERROR_NOT_SUPPORTED_IN_APPCONTAINER = 4252,
    [Description("The length of the SID supplied is not a valid length for app container SIDs.")]
    ERROR_INVALID_PACKAGE_SID_LENGTH = 4253,
    [Description("The media identifier does not represent a valid medium.")]
    ERROR_INVALID_MEDIA = 4300,
    [Description("The library identifier does not represent a valid library.")]
    ERROR_INVALID_LIBRARY = 4301,
    [Description("The media pool identifier does not represent a valid media pool.")]
    ERROR_INVALID_MEDIA_POOL = 4302,
    [Description("The drive and medium are not compatible or exist in different libraries.")]
    ERROR_DRIVE_MEDIA_MISMATCH = 4303,
    [Description("The medium currently exists in an offline library and must be online to perform this operation.")]
    ERROR_MEDIA_OFFLINE = 4304,
    [Description("The operation cannot be performed on an offline library.")]
    ERROR_LIBRARY_OFFLINE = 4305,
    [Description("The library, drive, or media pool is empty.")]
    ERROR_EMPTY = 4306,
    [Description("The library, drive, or media pool must be empty to perform this operation.")]
    ERROR_NOT_EMPTY = 4307,
    [Description("No media is currently available in this media pool or library.")]
    ERROR_MEDIA_UNAVAILABLE = 4308,
    [Description("A resource required for this operation is disabled.")]
    ERROR_RESOURCE_DISABLED = 4309,
    [Description("The media identifier does not represent a valid cleaner.")]
    ERROR_INVALID_CLEANER = 4310,
    [Description("The drive cannot be cleaned or does not support cleaning.")]
    ERROR_UNABLE_TO_CLEAN = 4311,
    [Description("The object identifier does not represent a valid object.")]
    ERROR_OBJECT_NOT_FOUND = 4312,
    [Description("Unable to read from or write to the database.")]
    ERROR_DATABASE_FAILURE = 4313,
    [Description("The database is full.")]
    ERROR_DATABASE_FULL = 4314,
    [Description("The medium is not compatible with the device or media pool.")]
    ERROR_MEDIA_INCOMPATIBLE = 4315,
    [Description("The resource required for this operation does not exist.")]
    ERROR_RESOURCE_NOT_PRESENT = 4316,
    [Description("The operation identifier is not valid.")]
    ERROR_INVALID_OPERATION = 4317,
    [Description("The media is not mounted or ready for use.")]
    ERROR_MEDIA_NOT_AVAILABLE = 4318,
    [Description("The device is not ready for use.")]
    ERROR_DEVICE_NOT_AVAILABLE = 4319,
    [Description("The operator or administrator has refused the request.")]
    ERROR_REQUEST_REFUSED = 4320,
    [Description("The drive identifier does not represent a valid drive.")]
    ERROR_INVALID_DRIVE_OBJECT = 4321,
    [Description("Library is full. No slot is available for use.")]
    ERROR_LIBRARY_FULL = 4322,
    [Description("The transport cannot access the medium.")]
    ERROR_MEDIUM_NOT_ACCESSIBLE = 4323,
    [Description("Unable to load the medium into the drive.")]
    ERROR_UNABLE_TO_LOAD_MEDIUM = 4324,
    [Description("Unable to retrieve the drive status.")]
    ERROR_UNABLE_TO_INVENTORY_DRIVE = 4325,
    [Description("Unable to retrieve the slot status.")]
    ERROR_UNABLE_TO_INVENTORY_SLOT = 4326,
    [Description("Unable to retrieve status about the transport.")]
    ERROR_UNABLE_TO_INVENTORY_TRANSPORT = 4327,
    [Description("Cannot use the transport because it is already in use.")]
    ERROR_TRANSPORT_FULL = 4328,
    [Description("Unable to open or close the inject/eject port.")]
    ERROR_CONTROLLING_IEPORT = 4329,
    [Description("Unable to eject the medium because it is in a drive.")]
    ERROR_UNABLE_TO_EJECT_MOUNTED_MEDIA = 4330,
    [Description("A cleaner slot is already reserved.")]
    ERROR_CLEANER_SLOT_SET = 4331,
    [Description("A cleaner slot is not reserved.")]
    ERROR_CLEANER_SLOT_NOT_SET = 4332,
    [Description("The cleaner cartridge has performed the maximum number of drive cleanings.")]
    ERROR_CLEANER_CARTRIDGE_SPENT = 4333,
    [Description("Unexpected on-medium identifier.")]
    ERROR_UNEXPECTED_OMID = 4334,
    [Description("The last remaining item in this group or resource cannot be deleted.")]
    ERROR_CANT_DELETE_LAST_ITEM = 4335,
    [Description("The message provided exceeds the maximum size allowed for this parameter.")]
    ERROR_MESSAGE_EXCEEDS_MAX_SIZE = 4336,
    [Description("The volume contains system or paging files.")]
    ERROR_VOLUME_CONTAINS_SYS_FILES = 4337,
    [Description("The media type cannot be removed from this library since at least one drive in the library reports it can support this media type.")]
    ERROR_INDIGENOUS_TYPE = 4338,
    [Description("This offline media cannot be mounted on this system since no enabled drives are present which can be used.")]
    ERROR_NO_SUPPORTING_DRIVES = 4339,
    [Description("A cleaner cartridge is present in the tape library.")]
    ERROR_CLEANER_CARTRIDGE_INSTALLED = 4340,
    [Description("Cannot use the inject/eject port because it is not empty.")]
    ERROR_IEPORT_FULL = 4341,
    [Description("This file is currently not available for use on this computer.")]
    ERROR_FILE_OFFLINE = 4350,
    [Description("The remote storage service is not operational at this time.")]
    ERROR_REMOTE_STORAGE_NOT_ACTIVE = 4351,
    [Description("The remote storage service encountered a media error.")]
    ERROR_REMOTE_STORAGE_MEDIA_ERROR = 4352,
    [Description("The file or directory is not a reparse point.")]
    ERROR_NOT_A_REPARSE_POINT = 4390,
    [Description("The reparse point attribute cannot be set because it conflicts with an existing attribute.")]
    ERROR_REPARSE_ATTRIBUTE_CONFLICT = 4391,
    [Description("The data present in the reparse point buffer is invalid.")]
    ERROR_INVALID_REPARSE_DATA = 4392,
    [Description("The tag present in the reparse point buffer is invalid.")]
    ERROR_REPARSE_TAG_INVALID = 4393,
    [Description("There is a mismatch between the tag specified in the request and the tag present in the reparse point.")]
    ERROR_REPARSE_TAG_MISMATCH = 4394,
    [Description("Fast Cache data not found.")]
    ERROR_APP_DATA_NOT_FOUND = 4400,
    [Description("Fast Cache data expired.")]
    ERROR_APP_DATA_EXPIRED = 4401,
    [Description("Fast Cache data corrupt.")]
    ERROR_APP_DATA_CORRUPT = 4402,
    [Description("Fast Cache data has exceeded its max size and cannot be updated.")]
    ERROR_APP_DATA_LIMIT_EXCEEDED = 4403,
    [Description("Fast Cache has been ReArmed and requires a reboot until it can be updated.")]
    ERROR_APP_DATA_REBOOT_REQUIRED = 4404,
    [Description("Secure Boot detected that rollback of protected data has been attempted.")]
    ERROR_SECUREBOOT_ROLLBACK_DETECTED = 4420,
    [Description("The value is protected by Secure Boot policy and cannot be modified or deleted.")]
    ERROR_SECUREBOOT_POLICY_VIOLATION = 4421,
    [Description("The Secure Boot policy is invalid.")]
    ERROR_SECUREBOOT_INVALID_POLICY = 4422,
    [Description("A new Secure Boot policy did not contain the current publisher on its update list.")]
    ERROR_SECUREBOOT_POLICY_PUBLISHER_NOT_FOUND = 4423,
    [Description("The Secure Boot policy is either not signed or is signed by a non-trusted signer.")]
    ERROR_SECUREBOOT_POLICY_NOT_SIGNED = 4424,
    [Description("Secure Boot is not enabled on this machine.")]
    ERROR_SECUREBOOT_NOT_ENABLED = 4425,
    [Description("Secure Boot requires that certain files and drivers are not replaced by other files or drivers.")]
    ERROR_SECUREBOOT_FILE_REPLACED = 4426,
    [Description("The copy offload read operation is not supported by a filter.")]
    ERROR_OFFLOAD_READ_FLT_NOT_SUPPORTED = 4440,
    [Description("The copy offload write operation is not supported by a filter.")]
    ERROR_OFFLOAD_WRITE_FLT_NOT_SUPPORTED = 4441,
    [Description("The copy offload read operation is not supported for the file.")]
    ERROR_OFFLOAD_READ_FILE_NOT_SUPPORTED = 4442,
    [Description("The copy offload write operation is not supported for the file.")]
    ERROR_OFFLOAD_WRITE_FILE_NOT_SUPPORTED = 4443,
    [Description("Single Instance Storage is not available on this volume.")]
    ERROR_VOLUME_NOT_SIS_ENABLED = 4500,
    [Description("The operation cannot be completed because other resources are dependent on this resource.")]
    ERROR_DEPENDENT_RESOURCE_EXISTS = 5001,
    [Description("The cluster resource dependency cannot be found.")]
    ERROR_DEPENDENCY_NOT_FOUND = 5002,
    [Description("The cluster resource cannot be made dependent on the specified resource because it is already dependent.")]
    ERROR_DEPENDENCY_ALREADY_EXISTS = 5003,
    [Description("The cluster resource is not online.")]
    ERROR_RESOURCE_NOT_ONLINE = 5004,
    [Description("A cluster node is not available for this operation.")]
    ERROR_HOST_NODE_NOT_AVAILABLE = 5005,
    [Description("The cluster resource is not available.")]
    ERROR_RESOURCE_NOT_AVAILABLE = 5006,
    [Description("The cluster resource could not be found.")]
    ERROR_RESOURCE_NOT_FOUND = 5007,
    [Description("The cluster is being shut down.")]
    ERROR_SHUTDOWN_CLUSTER = 5008,
    [Description("A cluster node cannot be evicted from the cluster unless the node is down or it is the last node.")]
    ERROR_CANT_EVICT_ACTIVE_NODE = 5009,
    [Description("The object already exists.")]
    ERROR_OBJECT_ALREADY_EXISTS = 5010,
    [Description("The object is already in the list.")]
    ERROR_OBJECT_IN_LIST = 5011,
    [Description("The cluster group is not available for any new requests.")]
    ERROR_GROUP_NOT_AVAILABLE = 5012,
    [Description("The cluster group could not be found.")]
    ERROR_GROUP_NOT_FOUND = 5013,
    [Description("The operation could not be completed because the cluster group is not online.")]
    ERROR_GROUP_NOT_ONLINE = 5014,
    [Description("The operation failed because either the specified cluster node is not the owner of the resource, or the node is not a possible owner of the resource.")]
    ERROR_HOST_NODE_NOT_RESOURCE_OWNER = 5015,
    [Description("The operation failed because either the specified cluster node is not the owner of the group, or the node is not a possible owner of the group.")]
    ERROR_HOST_NODE_NOT_GROUP_OWNER = 5016,
    [Description("The cluster resource could not be created in the specified resource monitor.")]
    ERROR_RESMON_CREATE_FAILED = 5017,
    [Description("The cluster resource could not be brought online by the resource monitor.")]
    ERROR_RESMON_ONLINE_FAILED = 5018,
    [Description("The operation could not be completed because the cluster resource is online.")]
    ERROR_RESOURCE_ONLINE = 5019,
    [Description("The cluster resource could not be deleted or brought offline because it is the quorum resource.")]
    ERROR_QUORUM_RESOURCE = 5020,
    [Description("The cluster could not make the specified resource a quorum resource because it is not capable of being a quorum resource.")]
    ERROR_NOT_QUORUM_CAPABLE = 5021,
    [Description("The cluster software is shutting down.")]
    ERROR_CLUSTER_SHUTTING_DOWN = 5022,
    [Description("The group or resource is not in the correct state to perform the requested operation.")]
    ERROR_INVALID_STATE = 5023,
    [Description("The properties were stored but not all changes will take effect until the next time the resource is brought online.")]
    ERROR_RESOURCE_PROPERTIES_STORED = 5024,
    [Description("The cluster could not make the specified resource a quorum resource because it does not belong to a shared storage class.")]
    ERROR_NOT_QUORUM_CLASS = 5025,
    [Description("The cluster resource could not be deleted since it is a core resource.")]
    ERROR_CORE_RESOURCE = 5026,
    [Description("The quorum resource failed to come online.")]
    ERROR_QUORUM_RESOURCE_ONLINE_FAILED = 5027,
    [Description("The quorum log could not be created or mounted successfully.")]
    ERROR_QUORUMLOG_OPEN_FAILED = 5028,
    [Description("The cluster log is corrupt.")]
    ERROR_CLUSTERLOG_CORRUPT = 5029,
    [Description("The record could not be written to the cluster log since it exceeds the maximum size.")]
    ERROR_CLUSTERLOG_RECORD_EXCEEDS_MAXSIZE = 5030,
    [Description("The cluster log exceeds its maximum size.")]
    ERROR_CLUSTERLOG_EXCEEDS_MAXSIZE = 5031,
    [Description("No checkpoint record was found in the cluster log.")]
    ERROR_CLUSTERLOG_CHKPOINT_NOT_FOUND = 5032,
    [Description("The minimum required disk space needed for logging is not available.")]
    ERROR_CLUSTERLOG_NOT_ENOUGH_SPACE = 5033,
    [Description("The cluster node failed to take control of the quorum resource because the resource is owned by another active node.")]
    ERROR_QUORUM_OWNER_ALIVE = 5034,
    [Description("A cluster network is not available for this operation.")]
    ERROR_NETWORK_NOT_AVAILABLE = 5035,
    [Description("A cluster node is not available for this operation.")]
    ERROR_NODE_NOT_AVAILABLE = 5036,
    [Description("All cluster nodes must be running to perform this operation.")]
    ERROR_ALL_NODES_NOT_AVAILABLE = 5037,
    [Description("A cluster resource failed.")]
    ERROR_RESOURCE_FAILED = 5038,
    [Description("The cluster node is not valid.")]
    ERROR_CLUSTER_INVALID_NODE = 5039,
    [Description("The cluster node already exists.")]
    ERROR_CLUSTER_NODE_EXISTS = 5040,
    [Description("A node is in the process of joining the cluster.")]
    ERROR_CLUSTER_JOIN_IN_PROGRESS = 5041,
    [Description("The cluster node was not found.")]
    ERROR_CLUSTER_NODE_NOT_FOUND = 5042,
    [Description("The cluster local node information was not found.")]
    ERROR_CLUSTER_LOCAL_NODE_NOT_FOUND = 5043,
    [Description("The cluster network already exists.")]
    ERROR_CLUSTER_NETWORK_EXISTS = 5044,
    [Description("The cluster network was not found.")]
    ERROR_CLUSTER_NETWORK_NOT_FOUND = 5045,
    [Description("The cluster network interface already exists.")]
    ERROR_CLUSTER_NETINTERFACE_EXISTS = 5046,
    [Description("The cluster network interface was not found.")]
    ERROR_CLUSTER_NETINTERFACE_NOT_FOUND = 5047,
    [Description("The cluster request is not valid for this object.")]
    ERROR_CLUSTER_INVALID_REQUEST = 5048,
    [Description("The cluster network provider is not valid.")]
    ERROR_CLUSTER_INVALID_NETWORK_PROVIDER = 5049,
    [Description("The cluster node is down.")]
    ERROR_CLUSTER_NODE_DOWN = 5050,
    [Description("The cluster node is not reachable.")]
    ERROR_CLUSTER_NODE_UNREACHABLE = 5051,
    [Description("The cluster node is not a member of the cluster.")]
    ERROR_CLUSTER_NODE_NOT_MEMBER = 5052,
    [Description("A cluster join operation is not in progress.")]
    ERROR_CLUSTER_JOIN_NOT_IN_PROGRESS = 5053,
    [Description("The cluster network is not valid.")]
    ERROR_CLUSTER_INVALID_NETWORK = 5054,
    [Description("The cluster node is up.")]
    ERROR_CLUSTER_NODE_UP = 5056,
    [Description("The cluster IP address is already in use.")]
    ERROR_CLUSTER_IPADDR_IN_USE = 5057,
    [Description("The cluster node is not paused.")]
    ERROR_CLUSTER_NODE_NOT_PAUSED = 5058,
    [Description("No cluster security context is available.")]
    ERROR_CLUSTER_NO_SECURITY_CONTEXT = 5059,
    [Description("The cluster network is not configured for internal cluster communication.")]
    ERROR_CLUSTER_NETWORK_NOT_INTERNAL = 5060,
    [Description("The cluster node is already up.")]
    ERROR_CLUSTER_NODE_ALREADY_UP = 5061,
    [Description("The cluster node is already down.")]
    ERROR_CLUSTER_NODE_ALREADY_DOWN = 5062,
    [Description("The cluster network is already online.")]
    ERROR_CLUSTER_NETWORK_ALREADY_ONLINE = 5063,
    [Description("The cluster network is already offline.")]
    ERROR_CLUSTER_NETWORK_ALREADY_OFFLINE = 5064,
    [Description("The cluster node is already a member of the cluster.")]
    ERROR_CLUSTER_NODE_ALREADY_MEMBER = 5065,
    [Description("The cluster network is the only one configured for internal cluster communication between two or more active cluster nodes. The internal communication capability cannot be removed from the network.")]
    ERROR_CLUSTER_LAST_INTERNAL_NETWORK = 5066,
    [Description("One or more cluster resources depend on the network to provide service to clients. The client access capability cannot be removed from the network.")]
    ERROR_CLUSTER_NETWORK_HAS_DEPENDENTS = 5067,
    [Description("This operation cannot be performed on the cluster resource as it the quorum resource. You may not bring the quorum resource offline or modify its possible owners list.")]
    ERROR_INVALID_OPERATION_ON_QUORUM = 5068,
    [Description("The cluster quorum resource is not allowed to have any dependencies.")]
    ERROR_DEPENDENCY_NOT_ALLOWED = 5069,
    [Description("The cluster node is paused.")]
    ERROR_CLUSTER_NODE_PAUSED = 5070,
    [Description("The cluster resource cannot be brought online. The owner node cannot run this resource.")]
    ERROR_NODE_CANT_HOST_RESOURCE = 5071,
    [Description("The cluster node is not ready to perform the requested operation.")]
    ERROR_CLUSTER_NODE_NOT_READY = 5072,
    [Description("The cluster node is shutting down.")]
    ERROR_CLUSTER_NODE_SHUTTING_DOWN = 5073,
    [Description("The cluster join operation was aborted.")]
    ERROR_CLUSTER_JOIN_ABORTED = 5074,
    [Description("The cluster join operation failed due to incompatible software versions between the joining node and its sponsor.")]
    ERROR_CLUSTER_INCOMPATIBLE_VERSIONS = 5075,
    [Description("This resource cannot be created because the cluster has reached the limit on the number of resources it can monitor.")]
    ERROR_CLUSTER_MAXNUM_OF_RESOURCES_EXCEEDED = 5076,
    [Description("The system configuration changed during the cluster join or form operation. The join or form operation was aborted.")]
    ERROR_CLUSTER_SYSTEM_CONFIG_CHANGED = 5077,
    [Description("The specified resource type was not found.")]
    ERROR_CLUSTER_RESOURCE_TYPE_NOT_FOUND = 5078,
    [Description("The specified node does not support a resource of this type. This may be due to version inconsistencies or due to the absence of the resource DLL on this node.")]
    ERROR_CLUSTER_RESTYPE_NOT_SUPPORTED = 5079,
    [Description("The specified resource name is not supported by this resource DLL. This may be due to a bad (or changed) name supplied to the resource DLL.")]
    ERROR_CLUSTER_RESNAME_NOT_FOUND = 5080,
    [Description("No authentication package could be registered with the RPC server.")]
    ERROR_CLUSTER_NO_RPC_PACKAGES_REGISTERED = 5081,
    [Description("You cannot bring the group online because the owner of the group is not in the preferred list for the group. To change the owner node for the group, move the group.")]
    ERROR_CLUSTER_OWNER_NOT_IN_PREFLIST = 5082,
    [Description("The join operation failed because the cluster database sequence number has changed or is incompatible with the locker node. This may happen during a join operation if the cluster database was changing during the join.")]
    ERROR_CLUSTER_DATABASE_SEQMISMATCH = 5083,
    [Description("The resource monitor will not allow the fail operation to be performed while the resource is in its current state. This may happen if the resource is in a pending state.")]
    ERROR_RESMON_INVALID_STATE = 5084,
    [Description("A non locker code got a request to reserve the lock for making global updates.")]
    ERROR_CLUSTER_GUM_NOT_LOCKER = 5085,
    [Description("The quorum disk could not be located by the cluster service.")]
    ERROR_QUORUM_DISK_NOT_FOUND = 5086,
    [Description("The backed up cluster database is possibly corrupt.")]
    ERROR_DATABASE_BACKUP_CORRUPT = 5087,
    [Description("A DFS root already exists in this cluster node.")]
    ERROR_CLUSTER_NODE_ALREADY_HAS_DFS_ROOT = 5088,
    [Description("An attempt to modify a resource property failed because it conflicts with another existing property.")]
    ERROR_RESOURCE_PROPERTY_UNCHANGEABLE = 5089,
    [Description("An operation was attempted that is incompatible with the current membership state of the node.")]
    ERROR_CLUSTER_MEMBERSHIP_INVALID_STATE = 5890,
    [Description("The quorum resource does not contain the quorum log.")]
    ERROR_CLUSTER_QUORUMLOG_NOT_FOUND = 5891,
    [Description("The membership engine requested shutdown of the cluster service on this node.")]
    ERROR_CLUSTER_MEMBERSHIP_HALT = 5892,
    [Description("The join operation failed because the cluster instance ID of the joining node does not match the cluster instance ID of the sponsor node.")]
    ERROR_CLUSTER_INSTANCE_ID_MISMATCH = 5893,
    [Description("A matching cluster network for the specified IP address could not be found.")]
    ERROR_CLUSTER_NETWORK_NOT_FOUND_FOR_IP = 5894,
    [Description("The actual data type of the property did not match the expected data type of the property.")]
    ERROR_CLUSTER_PROPERTY_DATA_TYPE_MISMATCH = 5895,
    [Description("The cluster node was evicted from the cluster successfully, but the node was not cleaned up. To determine what cleanup steps failed and how to recover, see the Failover Clustering application event log using Event Viewer.")]
    ERROR_CLUSTER_EVICT_WITHOUT_CLEANUP = 5896,
    [Description("Two or more parameter values specified for a resource's properties are in conflict.")]
    ERROR_CLUSTER_PARAMETER_MISMATCH = 5897,
    [Description("This computer cannot be made a member of a cluster.")]
    ERROR_NODE_CANNOT_BE_CLUSTERED = 5898,
    [Description("This computer cannot be made a member of a cluster because it does not have the correct version of Windows installed.")]
    ERROR_CLUSTER_WRONG_OS_VERSION = 5899,
    [Description("A cluster cannot be created with the specified cluster name because that cluster name is already in use. Specify a different name for the cluster.")]
    ERROR_CLUSTER_CANT_CREATE_DUP_CLUSTER_NAME = 5900,
    [Description("The cluster configuration action has already been committed.")]
    ERROR_CLUSCFG_ALREADY_COMMITTED = 5901,
    [Description("The cluster configuration action could not be rolled back.")]
    ERROR_CLUSCFG_ROLLBACK_FAILED = 5902,
    [Description("The drive letter assigned to a system disk on one node conflicted with the drive letter assigned to a disk on another node.")]
    ERROR_CLUSCFG_SYSTEM_DISK_DRIVE_LETTER_CONFLICT = 5903,
    [Description("One or more nodes in the cluster are running a version of Windows that does not support this operation.")]
    ERROR_CLUSTER_OLD_VERSION = 5904,
    [Description("The name of the corresponding computer account doesn't match the Network Name for this resource.")]
    ERROR_CLUSTER_MISMATCHED_COMPUTER_ACCT_NAME = 5905,
    [Description("No network adapters are available.")]
    ERROR_CLUSTER_NO_NET_ADAPTERS = 5906,
    [Description("The cluster node has been poisoned.")]
    ERROR_CLUSTER_POISONED = 5907,
    [Description("The group is unable to accept the request since it is moving to another node.")]
    ERROR_CLUSTER_GROUP_MOVING = 5908,
    [Description("The resource type cannot accept the request since is too busy performing another operation.")]
    ERROR_CLUSTER_RESOURCE_TYPE_BUSY = 5909,
    [Description("The call to the cluster resource DLL timed out.")]
    ERROR_RESOURCE_CALL_TIMED_OUT = 5910,
    [Description("The address is not valid for an IPv6 Address resource. A global IPv6 address is required, and it must match a cluster network. Compatibility addresses are not permitted.")]
    ERROR_INVALID_CLUSTER_IPV6_ADDRESS = 5911,
    [Description("An internal cluster error occurred. A call to an invalid function was attempted.")]
    ERROR_CLUSTER_INTERNAL_INVALID_FUNCTION = 5912,
    [Description("A parameter value is out of acceptable range.")]
    ERROR_CLUSTER_PARAMETER_OUT_OF_BOUNDS = 5913,
    [Description("A network error occurred while sending data to another node in the cluster. The number of bytes transmitted was less than required.")]
    ERROR_CLUSTER_PARTIAL_SEND = 5914,
    [Description("An invalid cluster registry operation was attempted.")]
    ERROR_CLUSTER_REGISTRY_INVALID_FUNCTION = 5915,
    [Description("An input string of characters is not properly terminated.")]
    ERROR_CLUSTER_INVALID_STRING_TERMINATION = 5916,
    [Description("An input string of characters is not in a valid format for the data it represents.")]
    ERROR_CLUSTER_INVALID_STRING_FORMAT = 5917,
    [Description("An internal cluster error occurred. A cluster database transaction was attempted while a transaction was already in progress.")]
    ERROR_CLUSTER_DATABASE_TRANSACTION_IN_PROGRESS = 5918,
    [Description("An internal cluster error occurred. There was an attempt to commit a cluster database transaction while no transaction was in progress.")]
    ERROR_CLUSTER_DATABASE_TRANSACTION_NOT_IN_PROGRESS = 5919,
    [Description("An internal cluster error occurred. Data was not properly initialized.")]
    ERROR_CLUSTER_NULL_DATA = 5920,
    [Description("An error occurred while reading from a stream of data. An unexpected number of bytes was returned.")]
    ERROR_CLUSTER_PARTIAL_READ = 5921,
    [Description("An error occurred while writing to a stream of data. The required number of bytes could not be written.")]
    ERROR_CLUSTER_PARTIAL_WRITE = 5922,
    [Description("An error occurred while deserializing a stream of cluster data.")]
    ERROR_CLUSTER_CANT_DESERIALIZE_DATA = 5923,
    [Description("One or more property values for this resource are in conflict with one or more property values associated with its dependent resource(s).")]
    ERROR_DEPENDENT_RESOURCE_PROPERTY_CONFLICT = 5924,
    [Description("A quorum of cluster nodes was not present to form a cluster.")]
    ERROR_CLUSTER_NO_QUORUM = 5925,
    [Description("The cluster network is not valid for an IPv6 Address resource, or it does not match the configured address.")]
    ERROR_CLUSTER_INVALID_IPV6_NETWORK = 5926,
    [Description("The cluster network is not valid for an IPv6 Tunnel resource. Check the configuration of the IP Address resource on which the IPv6 Tunnel resource depends.")]
    ERROR_CLUSTER_INVALID_IPV6_TUNNEL_NETWORK = 5927,
    [Description("Quorum resource cannot reside in the Available Storage group.")]
    ERROR_QUORUM_NOT_ALLOWED_IN_THIS_GROUP = 5928,
    [Description("The dependencies for this resource are nested too deeply.")]
    ERROR_DEPENDENCY_TREE_TOO_COMPLEX = 5929,
    [Description("The call into the resource DLL raised an unhandled exception.")]
    ERROR_EXCEPTION_IN_RESOURCE_CALL = 5930,
    [Description("The RHS process failed to initialize.")]
    ERROR_CLUSTER_RHS_FAILED_INITIALIZATION = 5931,
    [Description("The Failover Clustering feature is not installed on this node.")]
    ERROR_CLUSTER_NOT_INSTALLED = 5932,
    [Description("The resources must be online on the same node for this operation.")]
    ERROR_CLUSTER_RESOURCES_MUST_BE_ONLINE_ON_THE_SAME_NODE = 5933,
    [Description("A new node can not be added since this cluster is already at its maximum number of nodes.")]
    ERROR_CLUSTER_MAX_NODES_IN_CLUSTER = 5934,
    [Description("This cluster can not be created since the specified number of nodes exceeds the maximum allowed limit.")]
    ERROR_CLUSTER_TOO_MANY_NODES = 5935,
    [Description("An attempt to use the specified cluster name failed because an enabled computer object with the given name already exists in the domain.")]
    ERROR_CLUSTER_OBJECT_ALREADY_USED = 5936,
    [Description("This cluster cannot be destroyed. It has non-core application groups which must be deleted before the cluster can be destroyed.")]
    ERROR_NONCORE_GROUPS_FOUND = 5937,
    [Description("File share associated with file share witness resource cannot be hosted by this cluster or any of its nodes.")]
    ERROR_FILE_SHARE_RESOURCE_CONFLICT = 5938,
    [Description("Eviction of this node is invalid at this time. Due to quorum requirements node eviction will result in cluster shutdown. If it is the last node in the cluster, destroy cluster command should be used.")]
    ERROR_CLUSTER_EVICT_INVALID_REQUEST = 5939,
    [Description("Only one instance of this resource type is allowed in the cluster.")]
    ERROR_CLUSTER_SINGLETON_RESOURCE = 5940,
    [Description("Only one instance of this resource type is allowed per resource group.")]
    ERROR_CLUSTER_GROUP_SINGLETON_RESOURCE = 5941,
    [Description("The resource failed to come online due to the failure of one or more provider resources.")]
    ERROR_CLUSTER_RESOURCE_PROVIDER_FAILED = 5942,
    [Description("The resource has indicated that it cannot come online on any node.")]
    ERROR_CLUSTER_RESOURCE_CONFIGURATION_ERROR = 5943,
    [Description("The current operation cannot be performed on this group at this time.")]
    ERROR_CLUSTER_GROUP_BUSY = 5944,
    [Description("The directory or file is not located on a cluster shared volume.")]
    ERROR_CLUSTER_NOT_SHARED_VOLUME = 5945,
    [Description("The Security Descriptor does not meet the requirements for a cluster.")]
    ERROR_CLUSTER_INVALID_SECURITY_DESCRIPTOR = 5946,
    [Description("There is one or more shared volumes resources configured in the cluster. Those resources must be moved to available storage in order for operation to succeed.")]
    ERROR_CLUSTER_SHARED_VOLUMES_IN_USE = 5947,
    [Description("This group or resource cannot be directly manipulated. Use shared volume APIs to perform desired operation.")]
    ERROR_CLUSTER_USE_SHARED_VOLUMES_API = 5948,
    [Description("Back up is in progress. Please wait for backup completion before trying this operation again.")]
    ERROR_CLUSTER_BACKUP_IN_PROGRESS = 5949,
    [Description("The path does not belong to a cluster shared volume.")]
    ERROR_NON_CSV_PATH = 5950,
    [Description("The cluster shared volume is not locally mounted on this node.")]
    ERROR_CSV_VOLUME_NOT_LOCAL = 5951,
    [Description("The cluster watchdog is terminating.")]
    ERROR_CLUSTER_WATCHDOG_TERMINATING = 5952,
    [Description("A resource vetoed a move between two nodes because they are incompatible.")]
    ERROR_CLUSTER_RESOURCE_VETOED_MOVE_INCOMPATIBLE_NODES = 5953,
    [Description("The request is invalid either because node weight cannot be changed while the cluster is in disk-only quorum mode, or because changing the node weight would violate the minimum cluster quorum requirements.")]
    ERROR_CLUSTER_INVALID_NODE_WEIGHT = 5954,
    [Description("The resource vetoed the call.")]
    ERROR_CLUSTER_RESOURCE_VETOED_CALL = 5955,
    [Description("Resource could not start or run because it could not reserve sufficient system resources.")]
    ERROR_RESMON_SYSTEM_RESOURCES_LACKING = 5956,
    [Description("A resource vetoed a move between two nodes because the destination currently does not have enough resources to complete the operation.")]
    ERROR_CLUSTER_RESOURCE_VETOED_MOVE_NOT_ENOUGH_RESOURCES_ON_DESTINATION = 5957,
    [Description("A resource vetoed a move between two nodes because the source currently does not have enough resources to complete the operation.")]
    ERROR_CLUSTER_RESOURCE_VETOED_MOVE_NOT_ENOUGH_RESOURCES_ON_SOURCE = 5958,
    [Description("The requested operation can not be completed because the group is queued for an operation.")]
    ERROR_CLUSTER_GROUP_QUEUED = 5959,
    [Description("The requested operation can not be completed because a resource has locked status.")]
    ERROR_CLUSTER_RESOURCE_LOCKED_STATUS = 5960,
    [Description("The resource cannot move to another node because a cluster shared volume vetoed the operation.")]
    ERROR_CLUSTER_SHARED_VOLUME_FAILOVER_NOT_ALLOWED = 5961,
    [Description("A node drain is already in progress. This value was also named ERROR_CLUSTER_NODE_EVACUATION_IN_PROGRESS")]
    ERROR_CLUSTER_NODE_DRAIN_IN_PROGRESS = 5962,
    [Description("Clustered storage is not connected to the node.")]
    ERROR_CLUSTER_DISK_NOT_CONNECTED = 5963,
    [Description("The disk is not configured in a way to be used with CSV. CSV disks must have at least one partition that is formatted with NTFS.")]
    ERROR_DISK_NOT_CSV_CAPABLE = 5964,
    [Description("The resource must be part of the Available Storage group to complete this action.")]
    ERROR_RESOURCE_NOT_IN_AVAILABLE_STORAGE = 5965,
    [Description("CSVFS failed operation as volume is in redirected mode.")]
    ERROR_CLUSTER_SHARED_VOLUME_REDIRECTED = 5966,
    [Description("CSVFS failed operation as volume is not in redirected mode.")]
    ERROR_CLUSTER_SHARED_VOLUME_NOT_REDIRECTED = 5967,
    [Description("Cluster properties cannot be returned at this time.")]
    ERROR_CLUSTER_CANNOT_RETURN_PROPERTIES = 5968,
    [Description("The clustered disk resource contains software snapshot diff area that are not supported for Cluster Shared Volumes.")]
    ERROR_CLUSTER_RESOURCE_CONTAINS_UNSUPPORTED_DIFF_AREA_FOR_SHARED_VOLUMES = 5969,
    [Description("The operation cannot be completed because the resource is in maintenance mode.")]
    ERROR_CLUSTER_RESOURCE_IS_IN_MAINTENANCE_MODE = 5970,
    [Description("The operation cannot be completed because of cluster affinity conflicts.")]
    ERROR_CLUSTER_AFFINITY_CONFLICT = 5971,
    [Description("The operation cannot be completed because the resource is a replica virtual machine.")]
    ERROR_CLUSTER_RESOURCE_IS_REPLICA_VIRTUAL_MACHINE = 5972,
    [Description("The specified file could not be encrypted.")]
    ERROR_ENCRYPTION_FAILED = 6000,
    [Description("The specified file could not be decrypted.")]
    ERROR_DECRYPTION_FAILED = 6001,
    [Description("The specified file is encrypted and the user does not have the ability to decrypt it.")]
    ERROR_FILE_ENCRYPTED = 6002,
    [Description("There is no valid encryption recovery policy configured for this system.")]
    ERROR_NO_RECOVERY_POLICY = 6003,
    [Description("The required encryption driver is not loaded for this system.")]
    ERROR_NO_EFS = 6004,
    [Description("The file was encrypted with a different encryption driver than is currently loaded.")]
    ERROR_WRONG_EFS = 6005,
    [Description("There are no EFS keys defined for the user.")]
    ERROR_NO_USER_KEYS = 6006,
    [Description("The specified file is not encrypted.")]
    ERROR_FILE_NOT_ENCRYPTED = 6007,
    [Description("The specified file is not in the defined EFS export format.")]
    ERROR_NOT_EXPORT_FORMAT = 6008,
    [Description("The specified file is read only.")]
    ERROR_FILE_READ_ONLY = 6009,
    [Description("The directory has been disabled for encryption.")]
    ERROR_DIR_EFS_DISALLOWED = 6010,
    [Description("The server is not trusted for remote encryption operation.")]
    ERROR_EFS_SERVER_NOT_TRUSTED = 6011,
    [Description("Recovery policy configured for this system contains invalid recovery certificate.")]
    ERROR_BAD_RECOVERY_POLICY = 6012,
    [Description("The encryption algorithm used on the source file needs a bigger key buffer than the one on the destination file.")]
    ERROR_EFS_ALG_BLOB_TOO_BIG = 6013,
    [Description("The disk partition does not support file encryption.")]
    ERROR_VOLUME_NOT_SUPPORT_EFS = 6014,
    [Description("This machine is disabled for file encryption.")]
    ERROR_EFS_DISABLED = 6015,
    [Description("A newer system is required to decrypt this encrypted file.")]
    ERROR_EFS_VERSION_NOT_SUPPORT = 6016,
    [Description("The remote server sent an invalid response for a file being opened with Client Side Encryption.")]
    ERROR_CS_ENCRYPTION_INVALID_SERVER_RESPONSE = 6017,
    [Description("Client Side Encryption is not supported by the remote server even though it claims to support it.")]
    ERROR_CS_ENCRYPTION_UNSUPPORTED_SERVER = 6018,
    [Description("File is encrypted and should be opened in Client Side Encryption mode.")]
    ERROR_CS_ENCRYPTION_EXISTING_ENCRYPTED_FILE = 6019,
    [Description("A new encrypted file is being created and a $EFS needs to be provided.")]
    ERROR_CS_ENCRYPTION_NEW_ENCRYPTED_FILE = 6020,
    [Description("The SMB client requested a CSE FSCTL on a non-CSE file.")]
    ERROR_CS_ENCRYPTION_FILE_NOT_CSE = 6021,
    [Description("The requested operation was blocked by policy. For more information, contact your system administrator.")]
    ERROR_ENCRYPTION_POLICY_DENIES_OPERATION = 6022,
    [Description("The list of servers for this workgroup is not currently available.")]
    ERROR_NO_BROWSER_SERVERS_FOUND = 6118,
    [Description("The Task Scheduler service must be configured to run in the System account to function properly. Individual tasks may be configured to run in other accounts.")]
    SCHED_E_SERVICE_NOT_LOCALSYSTEM = 6200,
    [Description("Log service encountered an invalid log sector.")]
    ERROR_LOG_SECTOR_INVALID = 6600,
    [Description("Log service encountered a log sector with invalid block parity.")]
    ERROR_LOG_SECTOR_PARITY_INVALID = 6601,
    [Description("Log service encountered a remapped log sector.")]
    ERROR_LOG_SECTOR_REMAPPED = 6602,
    [Description("Log service encountered a partial or incomplete log block.")]
    ERROR_LOG_BLOCK_INCOMPLETE = 6603,
    [Description("Log service encountered an attempt access data outside the active log range.")]
    ERROR_LOG_INVALID_RANGE = 6604,
    [Description("Log service user marshalling buffers are exhausted.")]
    ERROR_LOG_BLOCKS_EXHAUSTED = 6605,
    [Description("Log service encountered an attempt read from a marshalling area with an invalid read context.")]
    ERROR_LOG_READ_CONTEXT_INVALID = 6606,
    [Description("Log service encountered an invalid log restart area.")]
    ERROR_LOG_RESTART_INVALID = 6607,
    [Description("Log service encountered an invalid log block version.")]
    ERROR_LOG_BLOCK_VERSION = 6608,
    [Description("Log service encountered an invalid log block.")]
    ERROR_LOG_BLOCK_INVALID = 6609,
    [Description("Log service encountered an attempt to read the log with an invalid read mode.")]
    ERROR_LOG_READ_MODE_INVALID = 6610,
    [Description("Log service encountered a log stream with no restart area.")]
    ERROR_LOG_NO_RESTART = 6611,
    [Description("Log service encountered a corrupted metadata file.")]
    ERROR_LOG_METADATA_CORRUPT = 6612,
    [Description("Log service encountered a metadata file that could not be created by the log file system.")]
    ERROR_LOG_METADATA_INVALID = 6613,
    [Description("Log service encountered a metadata file with inconsistent data.")]
    ERROR_LOG_METADATA_INCONSISTENT = 6614,
    [Description("Log service encountered an attempt to erroneous allocate or dispose reservation space.")]
    ERROR_LOG_RESERVATION_INVALID = 6615,
    [Description("Log service cannot delete log file or file system container.")]
    ERROR_LOG_CANT_DELETE = 6616,
    [Description("Log service has reached the maximum allowable containers allocated to a log file.")]
    ERROR_LOG_CONTAINER_LIMIT_EXCEEDED = 6617,
    [Description("Log service has attempted to read or write backward past the start of the log.")]
    ERROR_LOG_START_OF_LOG = 6618,
    [Description("Log policy could not be installed because a policy of the same type is already present.")]
    ERROR_LOG_POLICY_ALREADY_INSTALLED = 6619,
    [Description("Log policy in question was not installed at the time of the request.")]
    ERROR_LOG_POLICY_NOT_INSTALLED = 6620,
    [Description("The installed set of policies on the log is invalid.")]
    ERROR_LOG_POLICY_INVALID = 6621,
    [Description("A policy on the log in question prevented the operation from completing.")]
    ERROR_LOG_POLICY_CONFLICT = 6622,
    [Description("Log space cannot be reclaimed because the log is pinned by the archive tail.")]
    ERROR_LOG_PINNED_ARCHIVE_TAIL = 6623,
    [Description("Log record is not a record in the log file.")]
    ERROR_LOG_RECORD_NONEXISTENT = 6624,
    [Description("Number of reserved log records or the adjustment of the number of reserved log records is invalid.")]
    ERROR_LOG_RECORDS_RESERVED_INVALID = 6625,
    [Description("Reserved log space or the adjustment of the log space is invalid.")]
    ERROR_LOG_SPACE_RESERVED_INVALID = 6626,
    [Description("An new or existing archive tail or base of the active log is invalid.")]
    ERROR_LOG_TAIL_INVALID = 6627,
    [Description("Log space is exhausted.")]
    ERROR_LOG_FULL = 6628,
    [Description("The log could not be set to the requested size.")]
    ERROR_COULD_NOT_RESIZE_LOG = 6629,
    [Description("Log is multiplexed, no direct writes to the physical log is allowed.")]
    ERROR_LOG_MULTIPLEXED = 6630,
    [Description("The operation failed because the log is a dedicated log.")]
    ERROR_LOG_DEDICATED = 6631,
    [Description("The operation requires an archive context.")]
    ERROR_LOG_ARCHIVE_NOT_IN_PROGRESS = 6632,
    [Description("Log archival is in progress.")]
    ERROR_LOG_ARCHIVE_IN_PROGRESS = 6633,
    [Description("The operation requires a non-ephemeral log, but the log is ephemeral.")]
    ERROR_LOG_EPHEMERAL = 6634,
    [Description("The log must have at least two containers before it can be read from or written to.")]
    ERROR_LOG_NOT_ENOUGH_CONTAINERS = 6635,
    [Description("A log client has already registered on the stream.")]
    ERROR_LOG_CLIENT_ALREADY_REGISTERED = 6636,
    [Description("A log client has not been registered on the stream.")]
    ERROR_LOG_CLIENT_NOT_REGISTERED = 6637,
    [Description("A request has already been made to handle the log full condition.")]
    ERROR_LOG_FULL_HANDLER_IN_PROGRESS = 6638,
    [Description("Log service encountered an error when attempting to read from a log container.")]
    ERROR_LOG_CONTAINER_READ_FAILED = 6639,
    [Description("Log service encountered an error when attempting to write to a log container.")]
    ERROR_LOG_CONTAINER_WRITE_FAILED = 6640,
    [Description("Log service encountered an error when attempting open a log container.")]
    ERROR_LOG_CONTAINER_OPEN_FAILED = 6641,
    [Description("Log service encountered an invalid container state when attempting a requested action.")]
    ERROR_LOG_CONTAINER_STATE_INVALID = 6642,
    [Description("Log service is not in the correct state to perform a requested action.")]
    ERROR_LOG_STATE_INVALID = 6643,
    [Description("Log space cannot be reclaimed because the log is pinned.")]
    ERROR_LOG_PINNED = 6644,
    [Description("Log metadata flush failed.")]
    ERROR_LOG_METADATA_FLUSH_FAILED = 6645,
    [Description("Security on the log and its containers is inconsistent.")]
    ERROR_LOG_INCONSISTENT_SECURITY = 6646,
    [Description("Records were appended to the log or reservation changes were made, but the log could not be flushed.")]
    ERROR_LOG_APPENDED_FLUSH_FAILED = 6647,
    [Description("The log is pinned due to reservation consuming most of the log space. Free some reserved records to make space available.")]
    ERROR_LOG_PINNED_RESERVATION = 6648,
    [Description("The transaction handle associated with this operation is not valid.")]
    ERROR_INVALID_TRANSACTION = 6700,
    [Description("The requested operation was made in the context of a transaction that is no longer active.")]
    ERROR_TRANSACTION_NOT_ACTIVE = 6701,
    [Description("The requested operation is not valid on the Transaction object in its current state.")]
    ERROR_TRANSACTION_REQUEST_NOT_VALID = 6702,
    [Description("The caller has called a response API, but the response is not expected because the TM did not issue the corresponding request to the caller.")]
    ERROR_TRANSACTION_NOT_REQUESTED = 6703,
    [Description("It is too late to perform the requested operation, since the Transaction has already been aborted.")]
    ERROR_TRANSACTION_ALREADY_ABORTED = 6704,
    [Description("It is too late to perform the requested operation, since the Transaction has already been committed.")]
    ERROR_TRANSACTION_ALREADY_COMMITTED = 6705,
    [Description("The Transaction Manager was unable to be successfully initialized. Transacted operations are not supported.")]
    ERROR_TM_INITIALIZATION_FAILED = 6706,
    [Description("The specified ResourceManager made no changes or updates to the resource under this transaction.")]
    ERROR_RESOURCEMANAGER_READ_ONLY = 6707,
    [Description("The resource manager has attempted to prepare a transaction that it has not successfully joined.")]
    ERROR_TRANSACTION_NOT_JOINED = 6708,
    [Description("The Transaction object already has a superior enlistment, and the caller attempted an operation that would have created a new superior. Only a single superior enlistment is allow.")]
    ERROR_TRANSACTION_SUPERIOR_EXISTS = 6709,
    [Description("The RM tried to register a protocol that already exists.")]
    ERROR_CRM_PROTOCOL_ALREADY_EXISTS = 6710,
    [Description("The attempt to propagate the Transaction failed.")]
    ERROR_TRANSACTION_PROPAGATION_FAILED = 6711,
    [Description("The requested propagation protocol was not registered as a CRM.")]
    ERROR_CRM_PROTOCOL_NOT_FOUND = 6712,
    [Description("The buffer passed in to PushTransaction or PullTransaction is not in a valid format.")]
    ERROR_TRANSACTION_INVALID_MARSHALL_BUFFER = 6713,
    [Description("The current transaction context associated with the thread is not a valid handle to a transaction object.")]
    ERROR_CURRENT_TRANSACTION_NOT_VALID = 6714,
    [Description("The specified Transaction object could not be opened, because it was not found.")]
    ERROR_TRANSACTION_NOT_FOUND = 6715,
    [Description("The specified ResourceManager object could not be opened, because it was not found.")]
    ERROR_RESOURCEMANAGER_NOT_FOUND = 6716,
    [Description("The specified Enlistment object could not be opened, because it was not found.")]
    ERROR_ENLISTMENT_NOT_FOUND = 6717,
    [Description("The specified TransactionManager object could not be opened, because it was not found.")]
    ERROR_TRANSACTIONMANAGER_NOT_FOUND = 6718,
    [Description("The object specified could not be created or opened, because its associated TransactionManager is not online. The TransactionManager must be brought fully Online by calling RecoverTransactionManager to recover to the end of its LogFile before objects in its Transaction or ResourceManager namespaces can be opened.  In addition, errors in writing records to its LogFile can cause a TransactionManager to go offline.")]
    ERROR_TRANSACTIONMANAGER_NOT_ONLINE = 6719,
    [Description("The specified TransactionManager was unable to create the objects contained in its logfile in the Ob namespace. Therefore, the TransactionManager was unable to recover.")]
    ERROR_TRANSACTIONMANAGER_RECOVERY_NAME_COLLISION = 6720,
    [Description("The call to create a superior Enlistment on this Transaction object could not be completed, because the Transaction object specified for the enlistment is a subordinate branch of the Transaction. Only the root of the Transaction can be enlisted on as a superior.")]
    ERROR_TRANSACTION_NOT_ROOT = 6721,
    [Description("Because the associated transaction manager or resource manager has been closed, the handle is no longer valid.")]
    ERROR_TRANSACTION_OBJECT_EXPIRED = 6722,
    [Description("The specified operation could not be performed on this Superior enlistment, because the enlistment was not created with the corresponding completion response in the NotificationMask.")]
    ERROR_TRANSACTION_RESPONSE_NOT_ENLISTED = 6723,
    [Description("The specified operation could not be performed, because the record that would be logged was too long. This can occur because of two conditions: either there are too many Enlistments on this Transaction, or the combined RecoveryInformation being logged on behalf of those Enlistments is too long.")]
    ERROR_TRANSACTION_RECORD_TOO_LONG = 6724,
    [Description("Implicit transaction are not supported.")]
    ERROR_IMPLICIT_TRANSACTION_NOT_SUPPORTED = 6725,
    [Description("The kernel transaction manager had to abort or forget the transaction because it blocked forward progress.")]
    ERROR_TRANSACTION_INTEGRITY_VIOLATED = 6726,
    [Description("The TransactionManager identity that was supplied did not match the one recorded in the TransactionManager's log file.")]
    ERROR_TRANSACTIONMANAGER_IDENTITY_MISMATCH = 6727,
    [Description("This snapshot operation cannot continue because a transactional resource manager cannot be frozen in its current state.  Please try again.")]
    ERROR_RM_CANNOT_BE_FROZEN_FOR_SNAPSHOT = 6728,
    [Description("The transaction cannot be enlisted on with the specified EnlistmentMask, because the transaction has already completed the PrePrepare phase.  In order to ensure correctness, the ResourceManager must switch to a write-      through mode and cease caching data within this transaction.  Enlisting for only subsequent transaction phases may still succeed.")]
    ERROR_TRANSACTION_MUST_WRITETHROUGH = 6729,
    [Description("The transaction does not have a superior enlistment.")]
    ERROR_TRANSACTION_NO_SUPERIOR = 6730,
    [Description("The attempt to commit the Transaction completed, but it is possible that some portion of the transaction tree did not commit successfully due to heuristics.  Therefore it is possible that some data modified in the transaction may not have committed, resulting in transactional inconsistency.  If possible, check the consistency of the associated data.")]
    ERROR_HEURISTIC_DAMAGE_POSSIBLE = 6731,
    [Description("The function attempted to use a name that is reserved for use by another transaction.")]
    ERROR_TRANSACTIONAL_CONFLICT = 6800,
    [Description("Transaction support within the specified resource manager is not started or was shut down due to an error.")]
    ERROR_RM_NOT_ACTIVE = 6801,
    [Description("The metadata of the RM has been corrupted. The RM will not function.")]
    ERROR_RM_METADATA_CORRUPT = 6802,
    [Description("The specified directory does not contain a resource manager.")]
    ERROR_DIRECTORY_NOT_RM = 6803,
    [Description("The remote server or share does not support transacted file operations.")]
    ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE = 6805,
    [Description("The requested log size is invalid.")]
    ERROR_LOG_RESIZE_INVALID_SIZE = 6806,
    [Description("The object (file, stream, link) corresponding to the handle has been deleted by a Transaction Savepoint Rollback.")]
    ERROR_OBJECT_NO_LONGER_EXISTS = 6807,
    [Description("The specified file miniversion was not found for this transacted file open.")]
    ERROR_STREAM_MINIVERSION_NOT_FOUND = 6808,
    [Description("The specified file miniversion was found but has been invalidated. Most likely cause is a transaction savepoint rollback.")]
    ERROR_STREAM_MINIVERSION_NOT_VALID = 6809,
    [Description("A miniversion may only be opened in the context of the transaction that created it.")]
    ERROR_MINIVERSION_INACCESSIBLE_FROM_SPECIFIED_TRANSACTION = 6810,
    [Description("It is not possible to open a miniversion with modify access.")]
    ERROR_CANT_OPEN_MINIVERSION_WITH_MODIFY_INTENT = 6811,
    [Description("It is not possible to create any more miniversions for this stream.")]
    ERROR_CANT_CREATE_MORE_STREAM_MINIVERSIONS = 6812,
    [Description("The remote server sent mismatching version number or Fid for a file opened with transactions.")]
    ERROR_REMOTE_FILE_VERSION_MISMATCH = 6814,
    [Description("The handle has been invalidated by a transaction. The most likely cause is the presence of memory mapping on a file or an open handle when the transaction ended or rolled back to savepoint.")]
    ERROR_HANDLE_NO_LONGER_VALID = 6815,
    [Description("There is no transaction metadata on the file.")]
    ERROR_NO_TXF_METADATA = 6816,
    [Description("The log data is corrupt.")]
    ERROR_LOG_CORRUPTION_DETECTED = 6817,
    [Description("The file can't be recovered because there is a handle still open on it.")]
    ERROR_CANT_RECOVER_WITH_HANDLE_OPEN = 6818,
    [Description("The transaction outcome is unavailable because the resource manager responsible for it has disconnected.")]
    ERROR_RM_DISCONNECTED = 6819,
    [Description("The request was rejected because the enlistment in question is not a superior enlistment.")]
    ERROR_ENLISTMENT_NOT_SUPERIOR = 6820,
    [Description("The transactional resource manager is already consistent. Recovery is not needed.")]
    ERROR_RECOVERY_NOT_NEEDED = 6821,
    [Description("The transactional resource manager has already been started.")]
    ERROR_RM_ALREADY_STARTED = 6822,
    [Description("The file cannot be opened transactionally, because its identity depends on the outcome of an unresolved transaction.")]
    ERROR_FILE_IDENTITY_NOT_PERSISTENT = 6823,
    [Description("The operation cannot be performed because another transaction is depending on the fact that this property will not change.")]
    ERROR_CANT_BREAK_TRANSACTIONAL_DEPENDENCY = 6824,
    [Description("The operation would involve a single file with two transactional resource managers and is therefore not allowed.")]
    ERROR_CANT_CROSS_RM_BOUNDARY = 6825,
    [Description("The $Txf directory must be empty for this operation to succeed.")]
    ERROR_TXF_DIR_NOT_EMPTY = 6826,
    [Description("The operation would leave a transactional resource manager in an inconsistent state and is therefore not allowed.")]
    ERROR_INDOUBT_TRANSACTIONS_EXIST = 6827,
    [Description("The operation could not be completed because the transaction manager does not have a log.")]
    ERROR_TM_VOLATILE = 6828,
    [Description("A rollback could not be scheduled because a previously scheduled rollback has already executed or been queued for execution.")]
    ERROR_ROLLBACK_TIMER_EXPIRED = 6829,
    [Description("The transactional metadata attribute on the file or directory is corrupt and unreadable.")]
    ERROR_TXF_ATTRIBUTE_CORRUPT = 6830,
    [Description("The encryption operation could not be completed because a transaction is active.")]
    ERROR_EFS_NOT_ALLOWED_IN_TRANSACTION = 6831,
    [Description("This object is not allowed to be opened in a transaction.")]
    ERROR_TRANSACTIONAL_OPEN_NOT_ALLOWED = 6832,
    [Description("An attempt to create space in the transactional resource manager's log failed. The failure status has been recorded in the event log.")]
    ERROR_LOG_GROWTH_FAILED = 6833,
    [Description("Memory mapping (creating a mapped section) a remote file under a transaction is not supported.")]
    ERROR_TRANSACTED_MAPPING_UNSUPPORTED_REMOTE = 6834,
    [Description("Transaction metadata is already present on this file and cannot be superseded.")]
    ERROR_TXF_METADATA_ALREADY_PRESENT = 6835,
    [Description("A transaction scope could not be entered because the scope handler has not been initialized.")]
    ERROR_TRANSACTION_SCOPE_CALLBACKS_NOT_SET = 6836,
    [Description("Promotion was required in order to allow the resource manager to enlist, but the transaction was set to disallow it.")]
    ERROR_TRANSACTION_REQUIRED_PROMOTION = 6837,
    [Description("This file is open for modification in an unresolved transaction and may be opened for execute only by a transacted reader.")]
    ERROR_CANNOT_EXECUTE_FILE_IN_TRANSACTION = 6838,
    [Description("The request to thaw frozen transactions was ignored because transactions had not previously been frozen.")]
    ERROR_TRANSACTIONS_NOT_FROZEN = 6839,
    [Description("Transactions cannot be frozen because a freeze is already in progress.")]
    ERROR_TRANSACTION_FREEZE_IN_PROGRESS = 6840,
    [Description("The target volume is not a snapshot volume. This operation is only valid on a volume mounted as a snapshot.")]
    ERROR_NOT_SNAPSHOT_VOLUME = 6841,
    [Description("The savepoint operation failed because files are open on the transaction. This is not permitted.")]
    ERROR_NO_SAVEPOINT_WITH_OPEN_FILES = 6842,
    [Description("Windows has discovered corruption in a file, and that file has since been repaired. Data loss may have occurred.")]
    ERROR_DATA_LOST_REPAIR = 6843,
    [Description("The sparse operation could not be completed because a transaction is active on the file.")]
    ERROR_SPARSE_NOT_ALLOWED_IN_TRANSACTION = 6844,
    [Description("The call to create a TransactionManager object failed because the Tm Identity stored in the logfile does not match the Tm Identity that was passed in as an argument.")]
    ERROR_TM_IDENTITY_MISMATCH = 6845,
    [Description("I/O was attempted on a section object that has been floated as a result of a transaction ending. There is no valid data.")]
    ERROR_FLOATED_SECTION = 6846,
    [Description("The transactional resource manager cannot currently accept transacted work due to a transient condition such as low resources.")]
    ERROR_CANNOT_ACCEPT_TRANSACTED_WORK = 6847,
    [Description("The transactional resource manager had too many tranactions outstanding that could not be aborted. The transactional resource manger has been shut down.")]
    ERROR_CANNOT_ABORT_TRANSACTIONS = 6848,
    [Description("The operation could not be completed due to bad clusters on disk.")]
    ERROR_BAD_CLUSTERS = 6849,
    [Description("The compression operation could not be completed because a transaction is active on the file.")]
    ERROR_COMPRESSION_NOT_ALLOWED_IN_TRANSACTION = 6850,
    [Description("The operation could not be completed because the volume is dirty. Please run chkdsk and try again.")]
    ERROR_VOLUME_DIRTY = 6851,
    [Description("The link tracking operation could not be completed because a transaction is active.")]
    ERROR_NO_LINK_TRACKING_IN_TRANSACTION = 6852,
    [Description("This operation cannot be performed in a transaction.")]
    ERROR_OPERATION_NOT_SUPPORTED_IN_TRANSACTION = 6853,
    [Description("The handle is no longer properly associated with its transaction.  It may have been opened in a transactional resource manager that was subsequently forced to restart.  Please close the handle and open a new one.")]
    ERROR_EXPIRED_HANDLE = 6854,
    [Description("The specified operation could not be performed because the resource manager is not enlisted in the transaction.")]
    ERROR_TRANSACTION_NOT_ENLISTED = 6855,
    [Description("The specified session name is invalid.")]
    ERROR_CTX_WINSTATION_NAME_INVALID = 7001,
    [Description("The specified protocol driver is invalid.")]
    ERROR_CTX_INVALID_PD = 7002,
    [Description("The specified protocol driver was not found in the system path.")]
    ERROR_CTX_PD_NOT_FOUND = 7003,
    [Description("The specified terminal connection driver was not found in the system path.")]
    ERROR_CTX_WD_NOT_FOUND = 7004,
    [Description("A registry key for event logging could not be created for this session.")]
    ERROR_CTX_CANNOT_MAKE_EVENTLOG_ENTRY = 7005,
    [Description("A service with the same name already exists on the system.")]
    ERROR_CTX_SERVICE_NAME_COLLISION = 7006,
    [Description("A close operation is pending on the session.")]
    ERROR_CTX_CLOSE_PENDING = 7007,
    [Description("There are no free output buffers available.")]
    ERROR_CTX_NO_OUTBUF = 7008,
    [Description("The MODEM.INF file was not found.")]
    ERROR_CTX_MODEM_INF_NOT_FOUND = 7009,
    [Description("The modem name was not found in MODEM.INF.")]
    ERROR_CTX_INVALID_MODEMNAME = 7010,
    [Description("The modem did not accept the command sent to it. Verify that the configured modem name matches the attached modem.")]
    ERROR_CTX_MODEM_RESPONSE_ERROR = 7011,
    [Description("The modem did not respond to the command sent to it. Verify that the modem is properly cabled and powered on.")]
    ERROR_CTX_MODEM_RESPONSE_TIMEOUT = 7012,
    [Description("Carrier detect has failed or carrier has been dropped due to disconnect.")]
    ERROR_CTX_MODEM_RESPONSE_NO_CARRIER = 7013,
    [Description("Dial tone not detected within the required time. Verify that the phone cable is properly attached and functional.")]
    ERROR_CTX_MODEM_RESPONSE_NO_DIALTONE = 7014,
    [Description("Busy signal detected at remote site on callback.")]
    ERROR_CTX_MODEM_RESPONSE_BUSY = 7015,
    [Description("Voice detected at remote site on callback.")]
    ERROR_CTX_MODEM_RESPONSE_VOICE = 7016,
    [Description("Transport driver error.")]
    ERROR_CTX_TD_ERROR = 7017,
    [Description("The specified session cannot be found.")]
    ERROR_CTX_WINSTATION_NOT_FOUND = 7022,
    [Description("The specified session name is already in use.")]
    ERROR_CTX_WINSTATION_ALREADY_EXISTS = 7023,
    [Description("The task you are trying to do can't be completed because Remote Desktop Services is currently busy. Please try again in a few minutes. Other users should still be able to log on.")]
    ERROR_CTX_WINSTATION_BUSY = 7024,
    [Description("An attempt has been made to connect to a session whose video mode is not supported by the current client.")]
    ERROR_CTX_BAD_VIDEO_MODE = 7025,
    [Description("The application attempted to enable DOS graphics mode. DOS graphics mode is not supported.")]
    ERROR_CTX_GRAPHICS_INVALID = 7035,
    [Description("Your interactive logon privilege has been disabled. Please contact your administrator.")]
    ERROR_CTX_LOGON_DISABLED = 7037,
    [Description("The requested operation can be performed only on the system console. This is most often the result of a driver or system DLL requiring direct console access.")]
    ERROR_CTX_NOT_CONSOLE = 7038,
    [Description("The client failed to respond to the server connect message.")]
    ERROR_CTX_CLIENT_QUERY_TIMEOUT = 7040,
    [Description("Disconnecting the console session is not supported.")]
    ERROR_CTX_CONSOLE_DISCONNECT = 7041,
    [Description("Reconnecting a disconnected session to the console is not supported.")]
    ERROR_CTX_CONSOLE_CONNECT = 7042,
    [Description("The request to control another session remotely was denied.")]
    ERROR_CTX_SHADOW_DENIED = 7044,
    [Description("The requested session access is denied.")]
    ERROR_CTX_WINSTATION_ACCESS_DENIED = 7045,
    [Description("The specified terminal connection driver is invalid.")]
    ERROR_CTX_INVALID_WD = 7049,
    [Description("The requested session cannot be controlled remotely. This may be because the session is disconnected or does not currently have a user logged on.")]
    ERROR_CTX_SHADOW_INVALID = 7050,
    [Description("The requested session is not configured to allow remote control.")]
    ERROR_CTX_SHADOW_DISABLED = 7051,
    [Description("Your request to connect to this Terminal Server has been rejected. Your Terminal Server client license number is currently being used by another user. Please call your system administrator to obtain a unique license number.")]
    ERROR_CTX_CLIENT_LICENSE_IN_USE = 7052,
    [Description("Your request to connect to this Terminal Server has been rejected. Your Terminal Server client license number has not been entered for this copy of the Terminal Server client. Please contact your system administrator.")]
    ERROR_CTX_CLIENT_LICENSE_NOT_SET = 7053,
    [Description("The number of connections to this computer is limited and all connections are in use right now. Try connecting later or contact your system administrator.")]
    ERROR_CTX_LICENSE_NOT_AVAILABLE = 7054,
    [Description("The client you are using is not licensed to use this system. Your logon request is denied.")]
    ERROR_CTX_LICENSE_CLIENT_INVALID = 7055,
    [Description("The system license has expired. Your logon request is denied.")]
    ERROR_CTX_LICENSE_EXPIRED = 7056,
    [Description("Remote control could not be terminated because the specified session is not currently being remotely controlled.")]
    ERROR_CTX_SHADOW_NOT_RUNNING = 7057,
    [Description("The remote control of the console was terminated because the display mode was changed. Changing the display mode in a remote control session is not supported.")]
    ERROR_CTX_SHADOW_ENDED_BY_MODE_CHANGE = 7058,
    [Description("Activation has already been reset the maximum number of times for this installation. Your activation timer will not be cleared.")]
    ERROR_ACTIVATION_COUNT_EXCEEDED = 7059,
    [Description("Remote logins are currently disabled.")]
    ERROR_CTX_WINSTATIONS_DISABLED = 7060,
    [Description("You do not have the proper encryption level to access this Session.")]
    ERROR_CTX_ENCRYPTION_LEVEL_REQUIRED = 7061,
    [Description("The user %s\\\\%s is currently logged on to this computer. Only the current user or an administrator can log on to this computer.")]
    ERROR_CTX_SESSION_IN_USE = 7062,
    [Description("The user %s\\\\%s is already logged on to the console of this computer. You do not have permission to log in at this time. To resolve this issue, contact %s\\\\%s and have them log off.")]
    ERROR_CTX_NO_FORCE_LOGOFF = 7063,
    [Description("Unable to log you on because of an account restriction.")]
    ERROR_CTX_ACCOUNT_RESTRICTION = 7064,
    [Description("The RDP protocol component %2 detected an error in the protocol stream and has disconnected the client.")]
    ERROR_RDP_PROTOCOL_ERROR = 7065,
    [Description("The Client Drive Mapping Service Has Connected on Terminal Connection.")]
    ERROR_CTX_CDM_CONNECT = 7066,
    [Description("The Client Drive Mapping Service Has Disconnected on Terminal Connection.")]
    ERROR_CTX_CDM_DISCONNECT = 7067,
    [Description("The Terminal Server security layer detected an error in the protocol stream and has disconnected the client.")]
    ERROR_CTX_SECURITY_LAYER_ERROR = 7068,
    [Description("The target session is incompatible with the current session.")]
    ERROR_TS_INCOMPATIBLE_SESSIONS = 7069,
    [Description("Windows can't connect to your session because a problem occurred in the Windows video subsystem. Try connecting again later, or contact the server administrator for assistance.")]
    ERROR_TS_VIDEO_SUBSYSTEM_ERROR = 7070,
    [Description("The file replication service API was called incorrectly.")]
    FRS_ERR_INVALID_API_SEQUENCE = 8001,
    [Description("The file replication service cannot be started.")]
    FRS_ERR_STARTING_SERVICE = 8002,
    [Description("The file replication service cannot be stopped.")]
    FRS_ERR_STOPPING_SERVICE = 8003,
    [Description("The file replication service API terminated the request. The event log may have more information.")]
    FRS_ERR_INTERNAL_API = 8004,
    [Description("The file replication service terminated the request. The event log may have more information.")]
    FRS_ERR_INTERNAL = 8005,
    [Description("The file replication service cannot be contacted. The event log may have more information.")]
    FRS_ERR_SERVICE_COMM = 8006,
    [Description("The file replication service cannot satisfy the request because the user has insufficient privileges. The event log may have more information.")]
    FRS_ERR_INSUFFICIENT_PRIV = 8007,
    [Description("The file replication service cannot satisfy the request because authenticated RPC is not available. The event log may have more information.")]
    FRS_ERR_AUTHENTICATION = 8008,
    [Description("The file replication service cannot satisfy the request because the user has insufficient privileges on the domain controller. The event log may have more information.")]
    FRS_ERR_PARENT_INSUFFICIENT_PRIV = 8009,
    [Description("The file replication service cannot satisfy the request because authenticated RPC is not available on the domain controller. The event log may have more information.")]
    FRS_ERR_PARENT_AUTHENTICATION = 8010,
    [Description("The file replication service cannot communicate with the file replication service on the domain controller. The event log may have more information.")]
    FRS_ERR_CHILD_TO_PARENT_COMM = 8011,
    [Description("The file replication service on the domain controller cannot communicate with the file replication service on this computer. The event log may have more information.")]
    FRS_ERR_PARENT_TO_CHILD_COMM = 8012,
    [Description("The file replication service cannot populate the system volume because of an internal error. The event log may have more information.")]
    FRS_ERR_SYSVOL_POPULATE = 8013,
    [Description("The file replication service cannot populate the system volume because of an internal timeout. The event log may have more information.")]
    FRS_ERR_SYSVOL_POPULATE_TIMEOUT = 8014,
    [Description("The file replication service cannot process the request. The system volume is busy with a previous request.")]
    FRS_ERR_SYSVOL_IS_BUSY = 8015,
    [Description("The file replication service cannot stop replicating the system volume because of an internal error. The event log may have more information.")]
    FRS_ERR_SYSVOL_DEMOTE = 8016,
    [Description("The file replication service detected an invalid parameter.")]
    FRS_ERR_INVALID_SERVICE_PARAMETER = 8017,
    [Description("An error occurred while installing the directory service. For more information, see the event log.")]
    ERROR_DS_NOT_INSTALLED = 8200,
    [Description("The directory service evaluated group memberships locally.")]
    ERROR_DS_MEMBERSHIP_EVALUATED_LOCALLY = 8201,
    [Description("The specified directory service attribute or value does not exist.")]
    ERROR_DS_NO_ATTRIBUTE_OR_VALUE = 8202,
    [Description("The attribute syntax specified to the directory service is invalid.")]
    ERROR_DS_INVALID_ATTRIBUTE_SYNTAX = 8203,
    [Description("The attribute type specified to the directory service is not defined.")]
    ERROR_DS_ATTRIBUTE_TYPE_UNDEFINED = 8204,
    [Description("The specified directory service attribute or value already exists.")]
    ERROR_DS_ATTRIBUTE_OR_VALUE_EXISTS = 8205,
    [Description("The directory service is busy.")]
    ERROR_DS_BUSY = 8206,
    [Description("The directory service is unavailable.")]
    ERROR_DS_UNAVAILABLE = 8207,
    [Description("The directory service was unable to allocate a relative identifier.")]
    ERROR_DS_NO_RIDS_ALLOCATED = 8208,
    [Description("The directory service has exhausted the pool of relative identifiers.")]
    ERROR_DS_NO_MORE_RIDS = 8209,
    [Description("The requested operation could not be performed because the directory service is not the master for that type of operation.")]
    ERROR_DS_INCORRECT_ROLE_OWNER = 8210,
    [Description("The directory service was unable to initialize the subsystem that allocates relative identifiers.")]
    ERROR_DS_RIDMGR_INIT_ERROR = 8211,
    [Description("The requested operation did not satisfy one or more constraints associated with the class of the object.")]
    ERROR_DS_OBJ_CLASS_VIOLATION = 8212,
    [Description("The directory service can perform the requested operation only on a leaf object.")]
    ERROR_DS_CANT_ON_NON_LEAF = 8213,
    [Description("The directory service cannot perform the requested operation on the RDN attribute of an object.")]
    ERROR_DS_CANT_ON_RDN = 8214,
    [Description("The directory service detected an attempt to modify the object class of an object.")]
    ERROR_DS_CANT_MOD_OBJ_CLASS = 8215,
    [Description("The requested cross-domain move operation could not be performed.")]
    ERROR_DS_CROSS_DOM_MOVE_ERROR = 8216,
    [Description("Unable to contact the global catalog server.")]
    ERROR_DS_GC_NOT_AVAILABLE = 8217,
    [Description("The policy object is shared and can only be modified at the root.")]
    ERROR_SHARED_POLICY = 8218,
    [Description("The policy object does not exist.")]
    ERROR_POLICY_OBJECT_NOT_FOUND = 8219,
    [Description("The requested policy information is only in the directory service.")]
    ERROR_POLICY_ONLY_IN_DS = 8220,
    [Description("A domain controller promotion is currently active.")]
    ERROR_PROMOTION_ACTIVE = 8221,
    [Description("A domain controller promotion is not currently active.")]
    ERROR_NO_PROMOTION_ACTIVE = 8222,
    [Description("An operations error occurred.")]
    ERROR_DS_OPERATIONS_ERROR = 8224,
    [Description("A protocol error occurred.")]
    ERROR_DS_PROTOCOL_ERROR = 8225,
    [Description("The time limit for this request was exceeded.")]
    ERROR_DS_TIMELIMIT_EXCEEDED = 8226,
    [Description("The size limit for this request was exceeded.")]
    ERROR_DS_SIZELIMIT_EXCEEDED = 8227,
    [Description("The administrative limit for this request was exceeded.")]
    ERROR_DS_ADMIN_LIMIT_EXCEEDED = 8228,
    [Description("The compare response was false.")]
    ERROR_DS_COMPARE_FALSE = 8229,
    [Description("The compare response was true.")]
    ERROR_DS_COMPARE_TRUE = 8230,
    [Description("The requested authentication method is not supported by the server.")]
    ERROR_DS_AUTH_METHOD_NOT_SUPPORTED = 8231,
    [Description("A more secure authentication method is required for this server.")]
    ERROR_DS_STRONG_AUTH_REQUIRED = 8232,
    [Description("Inappropriate authentication.")]
    ERROR_DS_INAPPROPRIATE_AUTH = 8233,
    [Description("The authentication mechanism is unknown.")]
    ERROR_DS_AUTH_UNKNOWN = 8234,
    [Description("A referral was returned from the server.")]
    ERROR_DS_REFERRAL = 8235,
    [Description("The server does not support the requested critical extension.")]
    ERROR_DS_UNAVAILABLE_CRIT_EXTENSION = 8236,
    [Description("This request requires a secure connection.")]
    ERROR_DS_CONFIDENTIALITY_REQUIRED = 8237,
    [Description("Inappropriate matching.")]
    ERROR_DS_INAPPROPRIATE_MATCHING = 8238,
    [Description("A constraint violation occurred.")]
    ERROR_DS_CONSTRAINT_VIOLATION = 8239,
    [Description("There is no such object on the server.")]
    ERROR_DS_NO_SUCH_OBJECT = 8240,
    [Description("There is an alias problem.")]
    ERROR_DS_ALIAS_PROBLEM = 8241,
    [Description("An invalid dn syntax has been specified.")]
    ERROR_DS_INVALID_DN_SYNTAX = 8242,
    [Description("The object is a leaf object.")]
    ERROR_DS_IS_LEAF = 8243,
    [Description("There is an alias dereferencing problem.")]
    ERROR_DS_ALIAS_DEREF_PROBLEM = 8244,
    [Description("The server is unwilling to process the request.")]
    ERROR_DS_UNWILLING_TO_PERFORM = 8245,
    [Description("A loop has been detected.")]
    ERROR_DS_LOOP_DETECT = 8246,
    [Description("There is a naming violation.")]
    ERROR_DS_NAMING_VIOLATION = 8247,
    [Description("The result set is too large.")]
    ERROR_DS_OBJECT_RESULTS_TOO_LARGE = 8248,
    [Description("The operation affects multiple DSAs.")]
    ERROR_DS_AFFECTS_MULTIPLE_DSAS = 8249,
    [Description("The server is not operational.")]
    ERROR_DS_SERVER_DOWN = 8250,
    [Description("A local error has occurred.")]
    ERROR_DS_LOCAL_ERROR = 8251,
    [Description("An encoding error has occurred.")]
    ERROR_DS_ENCODING_ERROR = 8252,
    [Description("A decoding error has occurred.")]
    ERROR_DS_DECODING_ERROR = 8253,
    [Description("The search filter cannot be recognized.")]
    ERROR_DS_FILTER_UNKNOWN = 8254,
    [Description("One or more parameters are illegal.")]
    ERROR_DS_PARAM_ERROR = 8255,
    [Description("The specified method is not supported.")]
    ERROR_DS_NOT_SUPPORTED = 8256,
    [Description("No results were returned.")]
    ERROR_DS_NO_RESULTS_RETURNED = 8257,
    [Description("The specified control is not supported by the server.")]
    ERROR_DS_CONTROL_NOT_FOUND = 8258,
    [Description("A referral loop was detected by the client.")]
    ERROR_DS_CLIENT_LOOP = 8259,
    [Description("The preset referral limit was exceeded.")]
    ERROR_DS_REFERRAL_LIMIT_EXCEEDED = 8260,
    [Description("The search requires a SORT control.")]
    ERROR_DS_SORT_CONTROL_MISSING = 8261,
    [Description("The search results exceed the offset range specified.")]
    ERROR_DS_OFFSET_RANGE_ERROR = 8262,
    [Description("The directory service detected the subsystem that allocates relative identifiers is disabled. This can occur as a protective mechanism when the system determines a significant portion of relative identifiers (RIDs) have been exhausted. Please see http://go.microsoft.com/fwlink/p/?linkid=228610 for recommended diagnostic steps and the procedure to re-enable account creation.")]
    ERROR_DS_RIDMGR_DISABLED = 8263,
    [Description("The root object must be the head of a naming context. The root object cannot have an instantiated parent.")]
    ERROR_DS_ROOT_MUST_BE_NC = 8301,
    [Description("The add replica operation cannot be performed. The naming context must be writeable in order to create the replica.")]
    ERROR_DS_ADD_REPLICA_INHIBITED = 8302,
    [Description("A reference to an attribute that is not defined in the schema occurred.")]
    ERROR_DS_ATT_NOT_DEF_IN_SCHEMA = 8303,
    [Description("The maximum size of an object has been exceeded.")]
    ERROR_DS_MAX_OBJ_SIZE_EXCEEDED = 8304,
    [Description("An attempt was made to add an object to the directory with a name that is already in use.")]
    ERROR_DS_OBJ_STRING_NAME_EXISTS = 8305,
    [Description("An attempt was made to add an object of a class that does not have an RDN defined in the schema.")]
    ERROR_DS_NO_RDN_DEFINED_IN_SCHEMA = 8306,
    [Description("An attempt was made to add an object using an RDN that is not the RDN defined in the schema.")]
    ERROR_DS_RDN_DOESNT_MATCH_SCHEMA = 8307,
    [Description("None of the requested attributes were found on the objects.")]
    ERROR_DS_NO_REQUESTED_ATTS_FOUND = 8308,
    [Description("The user buffer is too small.")]
    ERROR_DS_USER_BUFFER_TO_SMALL = 8309,
    [Description("The attribute specified in the operation is not present on the object.")]
    ERROR_DS_ATT_IS_NOT_ON_OBJ = 8310,
    [Description("Illegal modify operation. Some aspect of the modification is not permitted.")]
    ERROR_DS_ILLEGAL_MOD_OPERATION = 8311,
    [Description("The specified object is too large.")]
    ERROR_DS_OBJ_TOO_LARGE = 8312,
    [Description("The specified instance type is not valid.")]
    ERROR_DS_BAD_INSTANCE_TYPE = 8313,
    [Description("The operation must be performed at a master DSA.")]
    ERROR_DS_MASTERDSA_REQUIRED = 8314,
    [Description("The object class attribute must be specified.")]
    ERROR_DS_OBJECT_CLASS_REQUIRED = 8315,
    [Description("A required attribute is missing.")]
    ERROR_DS_MISSING_REQUIRED_ATT = 8316,
    [Description("An attempt was made to modify an object to include an attribute that is not legal for its class.")]
    ERROR_DS_ATT_NOT_DEF_FOR_CLASS = 8317,
    [Description("The specified attribute is already present on the object.")]
    ERROR_DS_ATT_ALREADY_EXISTS = 8318,
    [Description("The specified attribute is not present, or has no values.")]
    ERROR_DS_CANT_ADD_ATT_VALUES = 8320,
    [Description("Multiple values were specified for an attribute that can have only one value.")]
    ERROR_DS_SINGLE_VALUE_CONSTRAINT = 8321,
    [Description("A value for the attribute was not in the acceptable range of values.")]
    ERROR_DS_RANGE_CONSTRAINT = 8322,
    [Description("The specified value already exists.")]
    ERROR_DS_ATT_VAL_ALREADY_EXISTS = 8323,
    [Description("The attribute cannot be removed because it is not present on the object.")]
    ERROR_DS_CANT_REM_MISSING_ATT = 8324,
    [Description("The attribute value cannot be removed because it is not present on the object.")]
    ERROR_DS_CANT_REM_MISSING_ATT_VAL = 8325,
    [Description("The specified root object cannot be a subref.")]
    ERROR_DS_ROOT_CANT_BE_SUBREF = 8326,
    [Description("Chaining is not permitted.")]
    ERROR_DS_NO_CHAINING = 8327,
    [Description("Chained evaluation is not permitted.")]
    ERROR_DS_NO_CHAINED_EVAL = 8328,
    [Description("The operation could not be performed because the object's parent is either uninstantiated or deleted.")]
    ERROR_DS_NO_PARENT_OBJECT = 8329,
    [Description("Having a parent that is an alias is not permitted. Aliases are leaf objects.")]
    ERROR_DS_PARENT_IS_AN_ALIAS = 8330,
    [Description("The object and parent must be of the same type, either both masters or both replicas.")]
    ERROR_DS_CANT_MIX_MASTER_AND_REPS = 8331,
    [Description("The operation cannot be performed because child objects exist. This operation can only be performed on a leaf object.")]
    ERROR_DS_CHILDREN_EXIST = 8332,
    [Description("Directory object not found.")]
    ERROR_DS_OBJ_NOT_FOUND = 8333,
    [Description("The aliased object is missing.")]
    ERROR_DS_ALIASED_OBJ_MISSING = 8334,
    [Description("The object name has bad syntax.")]
    ERROR_DS_BAD_NAME_SYNTAX = 8335,
    [Description("It is not permitted for an alias to refer to another alias.")]
    ERROR_DS_ALIAS_POINTS_TO_ALIAS = 8336,
    [Description("The alias cannot be dereferenced.")]
    ERROR_DS_CANT_DEREF_ALIAS = 8337,
    [Description("The operation is out of scope.")]
    ERROR_DS_OUT_OF_SCOPE = 8338,
    [Description("The operation cannot continue because the object is in the process of being removed.")]
    ERROR_DS_OBJECT_BEING_REMOVED = 8339,
    [Description("The DSA object cannot be deleted.")]
    ERROR_DS_CANT_DELETE_DSA_OBJ = 8340,
    [Description("A directory service error has occurred.")]
    ERROR_DS_GENERIC_ERROR = 8341,
    [Description("The operation can only be performed on an internal master DSA object.")]
    ERROR_DS_DSA_MUST_BE_INT_MASTER = 8342,
    [Description("The object must be of class DSA.")]
    ERROR_DS_CLASS_NOT_DSA = 8343,
    [Description("Insufficient access rights to perform the operation.")]
    ERROR_DS_INSUFF_ACCESS_RIGHTS = 8344,
    [Description("The object cannot be added because the parent is not on the list of possible superiors.")]
    ERROR_DS_ILLEGAL_SUPERIOR = 8345,
    [Description("Access to the attribute is not permitted because the attribute is owned by the Security Accounts Manager (SAM).")]
    ERROR_DS_ATTRIBUTE_OWNED_BY_SAM = 8346,
    [Description("The name has too many parts.")]
    ERROR_DS_NAME_TOO_MANY_PARTS = 8347,
    [Description("The name is too long.")]
    ERROR_DS_NAME_TOO_LONG = 8348,
    [Description("The name value is too long.")]
    ERROR_DS_NAME_VALUE_TOO_LONG = 8349,
    [Description("The directory service encountered an error parsing a name.")]
    ERROR_DS_NAME_UNPARSEABLE = 8350,
    [Description("The directory service cannot get the attribute type for a name.")]
    ERROR_DS_NAME_TYPE_UNKNOWN = 8351,
    [Description("The name does not identify an object; the name identifies a phantom.")]
    ERROR_DS_NOT_AN_OBJECT = 8352,
    [Description("The security descriptor is too short.")]
    ERROR_DS_SEC_DESC_TOO_SHORT = 8353,
    [Description("The security descriptor is invalid.")]
    ERROR_DS_SEC_DESC_INVALID = 8354,
    [Description("Failed to create name for deleted object.")]
    ERROR_DS_NO_DELETED_NAME = 8355,
    [Description("The parent of a new subref must exist.")]
    ERROR_DS_SUBREF_MUST_HAVE_PARENT = 8356,
    [Description("The object must be a naming context.")]
    ERROR_DS_NCNAME_MUST_BE_NC = 8357,
    [Description("It is not permitted to add an attribute which is owned by the system.")]
    ERROR_DS_CANT_ADD_SYSTEM_ONLY = 8358,
    [Description("The class of the object must be structural; you cannot instantiate an abstract class.")]
    ERROR_DS_CLASS_MUST_BE_CONCRETE = 8359,
    [Description("The schema object could not be found.")]
    ERROR_DS_INVALID_DMD = 8360,
    [Description("A local object with this GUID (dead or alive) already exists.")]
    ERROR_DS_OBJ_GUID_EXISTS = 8361,
    [Description("The operation cannot be performed on a back link.")]
    ERROR_DS_NOT_ON_BACKLINK = 8362,
    [Description("The cross reference for the specified naming context could not be found.")]
    ERROR_DS_NO_CROSSREF_FOR_NC = 8363,
    [Description("The operation could not be performed because the directory service is shutting down.")]
    ERROR_DS_SHUTTING_DOWN = 8364,
    [Description("The directory service request is invalid.")]
    ERROR_DS_UNKNOWN_OPERATION = 8365,
    [Description("The role owner attribute could not be read.")]
    ERROR_DS_INVALID_ROLE_OWNER = 8366,
    [Description("The requested FSMO operation failed. The current FSMO holder could not be contacted.")]
    ERROR_DS_COULDNT_CONTACT_FSMO = 8367,
    [Description("Modification of a DN across a naming context is not permitted.")]
    ERROR_DS_CROSS_NC_DN_RENAME = 8368,
    [Description("The attribute cannot be modified because it is owned by the system.")]
    ERROR_DS_CANT_MOD_SYSTEM_ONLY = 8369,
    [Description("Only the replicator can perform this function.")]
    ERROR_DS_REPLICATOR_ONLY = 8370,
    [Description("The specified class is not defined.")]
    ERROR_DS_OBJ_CLASS_NOT_DEFINED = 8371,
    [Description("The specified class is not a subclass.")]
    ERROR_DS_OBJ_CLASS_NOT_SUBCLASS = 8372,
    [Description("The name reference is invalid.")]
    ERROR_DS_NAME_REFERENCE_INVALID = 8373,
    [Description("A cross reference already exists.")]
    ERROR_DS_CROSS_REF_EXISTS = 8374,
    [Description("It is not permitted to delete a master cross reference.")]
    ERROR_DS_CANT_DEL_MASTER_CROSSREF = 8375,
    [Description("Subtree notifications are only supported on NC heads.")]
    ERROR_DS_SUBTREE_NOTIFY_NOT_NC_HEAD = 8376,
    [Description("Notification filter is too complex.")]
    ERROR_DS_NOTIFY_FILTER_TOO_COMPLEX = 8377,
    [Description("Schema update failed: duplicate RDN.")]
    ERROR_DS_DUP_RDN = 8378,
    [Description("Schema update failed: duplicate OID.")]
    ERROR_DS_DUP_OID = 8379,
    [Description("Schema update failed: duplicate MAPI identifier.")]
    ERROR_DS_DUP_MAPI_ID = 8380,
    [Description("Schema update failed: duplicate schema-id GUID.")]
    ERROR_DS_DUP_SCHEMA_ID_GUID = 8381,
    [Description("Schema update failed: duplicate LDAP display name.")]
    ERROR_DS_DUP_LDAP_DISPLAY_NAME = 8382,
    [Description("Schema update failed: range-lower less than range upper.")]
    ERROR_DS_SEMANTIC_ATT_TEST = 8383,
    [Description("Schema update failed: syntax mismatch.")]
    ERROR_DS_SYNTAX_MISMATCH = 8384,
    [Description("Schema deletion failed: attribute is used in must-contain.")]
    ERROR_DS_EXISTS_IN_MUST_HAVE = 8385,
    [Description("Schema deletion failed: attribute is used in may-contain.")]
    ERROR_DS_EXISTS_IN_MAY_HAVE = 8386,
    [Description("Schema update failed: attribute in may-contain does not exist.")]
    ERROR_DS_NONEXISTENT_MAY_HAVE = 8387,
    [Description("Schema update failed: attribute in must-contain does not exist.")]
    ERROR_DS_NONEXISTENT_MUST_HAVE = 8388,
    [Description("Schema update failed: class in aux-class list does not exist or is not an auxiliary class.")]
    ERROR_DS_AUX_CLS_TEST_FAIL = 8389,
    [Description("Schema update failed: class in poss-superiors does not exist.")]
    ERROR_DS_NONEXISTENT_POSS_SUP = 8390,
    [Description("Schema update failed: class in subclassof list does not exist or does not satisfy hierarchy rules.")]
    ERROR_DS_SUB_CLS_TEST_FAIL = 8391,
    [Description("Schema update failed: Rdn-Att-Id has wrong syntax.")]
    ERROR_DS_BAD_RDN_ATT_ID_SYNTAX = 8392,
    [Description("Schema deletion failed: class is used as auxiliary class.")]
    ERROR_DS_EXISTS_IN_AUX_CLS = 8393,
    [Description("Schema deletion failed: class is used as sub class.")]
    ERROR_DS_EXISTS_IN_SUB_CLS = 8394,
    [Description("Schema deletion failed: class is used as poss superior.")]
    ERROR_DS_EXISTS_IN_POSS_SUP = 8395,
    [Description("Schema update failed in recalculating validation cache.")]
    ERROR_DS_RECALCSCHEMA_FAILED = 8396,
    [Description("The tree deletion is not finished. The request must be made again to continue deleting the tree.")]
    ERROR_DS_TREE_DELETE_NOT_FINISHED = 8397,
    [Description("The requested delete operation could not be performed.")]
    ERROR_DS_CANT_DELETE = 8398,
    [Description("Cannot read the governs class identifier for the schema record.")]
    ERROR_DS_ATT_SCHEMA_REQ_ID = 8399,
    [Description("The attribute schema has bad syntax.")]
    ERROR_DS_BAD_ATT_SCHEMA_SYNTAX = 8400,
    [Description("The attribute could not be cached.")]
    ERROR_DS_CANT_CACHE_ATT = 8401,
    [Description("The class could not be cached.")]
    ERROR_DS_CANT_CACHE_CLASS = 8402,
    [Description("The attribute could not be removed from the cache.")]
    ERROR_DS_CANT_REMOVE_ATT_CACHE = 8403,
    [Description("The class could not be removed from the cache.")]
    ERROR_DS_CANT_REMOVE_CLASS_CACHE = 8404,
    [Description("The distinguished name attribute could not be read.")]
    ERROR_DS_CANT_RETRIEVE_DN = 8405,
    [Description("No superior reference has been configured for the directory service. The directory service is therefore unable to issue referrals to objects outside this forest.")]
    ERROR_DS_MISSING_SUPREF = 8406,
    [Description("The instance type attribute could not be retrieved.")]
    ERROR_DS_CANT_RETRIEVE_INSTANCE = 8407,
    [Description("An internal error has occurred.")]
    ERROR_DS_CODE_INCONSISTENCY = 8408,
    [Description("A database error has occurred.")]
    ERROR_DS_DATABASE_ERROR = 8409,
    [Description("The attribute GOVERNSID is missing.")]
    ERROR_DS_GOVERNSID_MISSING = 8410,
    [Description("An expected attribute is missing.")]
    ERROR_DS_MISSING_EXPECTED_ATT = 8411,
    [Description("The specified naming context is missing a cross reference.")]
    ERROR_DS_NCNAME_MISSING_CR_REF = 8412,
    [Description("A security checking error has occurred.")]
    ERROR_DS_SECURITY_CHECKING_ERROR = 8413,
    [Description("The schema is not loaded.")]
    ERROR_DS_SCHEMA_NOT_LOADED = 8414,
    [Description("Schema allocation failed. Please check if the machine is running low on memory.")]
    ERROR_DS_SCHEMA_ALLOC_FAILED = 8415,
    [Description("Failed to obtain the required syntax for the attribute schema.")]
    ERROR_DS_ATT_SCHEMA_REQ_SYNTAX = 8416,
    [Description("The global catalog verification failed. The global catalog is not available or does not support the operation. Some part of the directory is currently not available.")]
    ERROR_DS_GCVERIFY_ERROR = 8417,
    [Description("The replication operation failed because of a schema mismatch between the servers involved.")]
    ERROR_DS_DRA_SCHEMA_MISMATCH = 8418,
    [Description("The DSA object could not be found.")]
    ERROR_DS_CANT_FIND_DSA_OBJ = 8419,
    [Description("The naming context could not be found.")]
    ERROR_DS_CANT_FIND_EXPECTED_NC = 8420,
    [Description("The naming context could not be found in the cache.")]
    ERROR_DS_CANT_FIND_NC_IN_CACHE = 8421,
    [Description("The child object could not be retrieved.")]
    ERROR_DS_CANT_RETRIEVE_CHILD = 8422,
    [Description("The modification was not permitted for security reasons.")]
    ERROR_DS_SECURITY_ILLEGAL_MODIFY = 8423,
    [Description("The operation cannot replace the hidden record.")]
    ERROR_DS_CANT_REPLACE_HIDDEN_REC = 8424,
    [Description("The hierarchy file is invalid.")]
    ERROR_DS_BAD_HIERARCHY_FILE = 8425,
    [Description("The attempt to build the hierarchy table failed.")]
    ERROR_DS_BUILD_HIERARCHY_TABLE_FAILED = 8426,
    [Description("The directory configuration parameter is missing from the registry.")]
    ERROR_DS_CONFIG_PARAM_MISSING = 8427,
    [Description("The attempt to count the address book indices failed.")]
    ERROR_DS_COUNTING_AB_INDICES_FAILED = 8428,
    [Description("The allocation of the hierarchy table failed.")]
    ERROR_DS_HIERARCHY_TABLE_MALLOC_FAILED = 8429,
    [Description("The directory service encountered an internal failure.")]
    ERROR_DS_INTERNAL_FAILURE = 8430,
    [Description("The directory service encountered an unknown failure.")]
    ERROR_DS_UNKNOWN_ERROR = 8431,
    [Description("A root object requires a class of 'top'.")]
    ERROR_DS_ROOT_REQUIRES_CLASS_TOP = 8432,
    [Description("This directory server is shutting down, and cannot take ownership of new floating single-master operation roles.")]
    ERROR_DS_REFUSING_FSMO_ROLES = 8433,
    [Description("The directory service is missing mandatory configuration information, and is unable to determine the ownership of floating single-master operation roles.")]
    ERROR_DS_MISSING_FSMO_SETTINGS = 8434,
    [Description("The directory service was unable to transfer ownership of one or more floating single-master operation roles to other servers.")]
    ERROR_DS_UNABLE_TO_SURRENDER_ROLES = 8435,
    [Description("The replication operation failed.")]
    ERROR_DS_DRA_GENERIC = 8436,
    [Description("An invalid parameter was specified for this replication operation.")]
    ERROR_DS_DRA_INVALID_PARAMETER = 8437,
    [Description("The directory service is too busy to complete the replication operation at this time.")]
    ERROR_DS_DRA_BUSY = 8438,
    [Description("The distinguished name specified for this replication operation is invalid.")]
    ERROR_DS_DRA_BAD_DN = 8439,
    [Description("The naming context specified for this replication operation is invalid.")]
    ERROR_DS_DRA_BAD_NC = 8440,
    [Description("The distinguished name specified for this replication operation already exists.")]
    ERROR_DS_DRA_DN_EXISTS = 8441,
    [Description("The replication system encountered an internal error.")]
    ERROR_DS_DRA_INTERNAL_ERROR = 8442,
    [Description("The replication operation encountered a database inconsistency.")]
    ERROR_DS_DRA_INCONSISTENT_DIT = 8443,
    [Description("The server specified for this replication operation could not be contacted.")]
    ERROR_DS_DRA_CONNECTION_FAILED = 8444,
    [Description("The replication operation encountered an object with an invalid instance type.")]
    ERROR_DS_DRA_BAD_INSTANCE_TYPE = 8445,
    [Description("The replication operation failed to allocate memory.")]
    ERROR_DS_DRA_OUT_OF_MEM = 8446,
    [Description("The replication operation encountered an error with the mail system.")]
    ERROR_DS_DRA_MAIL_PROBLEM = 8447,
    [Description("The replication reference information for the target server already exists.")]
    ERROR_DS_DRA_REF_ALREADY_EXISTS = 8448,
    [Description("The replication reference information for the target server does not exist.")]
    ERROR_DS_DRA_REF_NOT_FOUND = 8449,
    [Description("The naming context cannot be removed because it is replicated to another server.")]
    ERROR_DS_DRA_OBJ_IS_REP_SOURCE = 8450,
    [Description("The replication operation encountered a database error.")]
    ERROR_DS_DRA_DB_ERROR = 8451,
    [Description("The naming context is in the process of being removed or is not replicated from the specified server.")]
    ERROR_DS_DRA_NO_REPLICA = 8452,
    [Description("Replication access was denied.")]
    ERROR_DS_DRA_ACCESS_DENIED = 8453,
    [Description("The requested operation is not supported by this version of the directory service.")]
    ERROR_DS_DRA_NOT_SUPPORTED = 8454,
    [Description("The replication remote procedure call was cancelled.")]
    ERROR_DS_DRA_RPC_CANCELLED = 8455,
    [Description("The source server is currently rejecting replication requests.")]
    ERROR_DS_DRA_SOURCE_DISABLED = 8456,
    [Description("The destination server is currently rejecting replication requests.")]
    ERROR_DS_DRA_SINK_DISABLED = 8457,
    [Description("The replication operation failed due to a collision of object names.")]
    ERROR_DS_DRA_NAME_COLLISION = 8458,
    [Description("The replication source has been reinstalled.")]
    ERROR_DS_DRA_SOURCE_REINSTALLED = 8459,
    [Description("The replication operation failed because a required parent object is missing.")]
    ERROR_DS_DRA_MISSING_PARENT = 8460,
    [Description("The replication operation was preempted.")]
    ERROR_DS_DRA_PREEMPTED = 8461,
    [Description("The replication synchronization attempt was abandoned because of a lack of updates.")]
    ERROR_DS_DRA_ABANDON_SYNC = 8462,
    [Description("The replication operation was terminated because the system is shutting down.")]
    ERROR_DS_DRA_SHUTDOWN = 8463,
    [Description("Synchronization attempt failed because the destination DC is currently waiting to synchronize new partial attributes from source. This condition is normal if a recent schema change modified the partial attribute set. The destination partial attribute set is not a subset of source partial attribute set.")]
    ERROR_DS_DRA_INCOMPATIBLE_PARTIAL_SET = 8464,
    [Description("The replication synchronization attempt failed because a master replica attempted to sync from a partial replica.")]
    ERROR_DS_DRA_SOURCE_IS_PARTIAL_REPLICA = 8465,
    [Description("The server specified for this replication operation was contacted, but that server was unable to contact an additional server needed to complete the operation.")]
    ERROR_DS_DRA_EXTN_CONNECTION_FAILED = 8466,
    [Description("The version of the directory service schema of the source forest is not compatible with the version of directory service on this computer.")]
    ERROR_DS_INSTALL_SCHEMA_MISMATCH = 8467,
    [Description("Schema update failed: An attribute with the same link identifier already exists.")]
    ERROR_DS_DUP_LINK_ID = 8468,
    [Description("Name translation: Generic processing error.")]
    ERROR_DS_NAME_ERROR_RESOLVING = 8469,
    [Description("Name translation: Could not find the name or insufficient right to see name.")]
    ERROR_DS_NAME_ERROR_NOT_FOUND = 8470,
    [Description("Name translation: Input name mapped to more than one output name.")]
    ERROR_DS_NAME_ERROR_NOT_UNIQUE = 8471,
    [Description("Name translation: Input name found, but not the associated output format.")]
    ERROR_DS_NAME_ERROR_NO_MAPPING = 8472,
    [Description("Name translation: Unable to resolve completely, only the domain was found.")]
    ERROR_DS_NAME_ERROR_DOMAIN_ONLY = 8473,
    [Description("Name translation: Unable to perform purely syntactical mapping at the client without going out to the wire.")]
    ERROR_DS_NAME_ERROR_NO_SYNTACTICAL_MAPPING = 8474,
    [Description("Modification of a constructed attribute is not allowed.")]
    ERROR_DS_CONSTRUCTED_ATT_MOD = 8475,
    [Description("The OM-Object-Class specified is incorrect for an attribute with the specified syntax.")]
    ERROR_DS_WRONG_OM_OBJ_CLASS = 8476,
    [Description("The replication request has been posted; waiting for reply.")]
    ERROR_DS_DRA_REPL_PENDING = 8477,
    [Description("The requested operation requires a directory service, and none was available.")]
    ERROR_DS_DS_REQUIRED = 8478,
    [Description("The LDAP display name of the class or attribute contains non-ASCII characters.")]
    ERROR_DS_INVALID_LDAP_DISPLAY_NAME = 8479,
    [Description("The requested search operation is only supported for base searches.")]
    ERROR_DS_NON_BASE_SEARCH = 8480,
    [Description("The search failed to retrieve attributes from the database.")]
    ERROR_DS_CANT_RETRIEVE_ATTS = 8481,
    [Description("The schema update operation tried to add a backward link attribute that has no corresponding forward link.")]
    ERROR_DS_BACKLINK_WITHOUT_LINK = 8482,
    [Description("Source and destination of a cross-domain move do not agree on the object's epoch number. Either source or destination does not have the latest version of the object.")]
    ERROR_DS_EPOCH_MISMATCH = 8483,
    [Description("Source and destination of a cross-domain move do not agree on the object's current name. Either source or destination does not have the latest version of the object.")]
    ERROR_DS_SRC_NAME_MISMATCH = 8484,
    [Description("Source and destination for the cross-domain move operation are identical. Caller should use local move operation instead of cross-domain move operation.")]
    ERROR_DS_SRC_AND_DST_NC_IDENTICAL = 8485,
    [Description("Source and destination for a cross-domain move are not in agreement on the naming contexts in the forest. Either source or destination does not have the latest version of the Partitions container.")]
    ERROR_DS_DST_NC_MISMATCH = 8486,
    [Description("Destination of a cross-domain move is not authoritative for the destination naming context.")]
    ERROR_DS_NOT_AUTHORITIVE_FOR_DST_NC = 8487,
    [Description("Source and destination of a cross-domain move do not agree on the identity of the source object. Either source or destination does not have the latest version of the source object.")]
    ERROR_DS_SRC_GUID_MISMATCH = 8488,
    [Description("Object being moved across-domains is already known to be deleted by the destination server. The source server does not have the latest version of the source object.")]
    ERROR_DS_CANT_MOVE_DELETED_OBJECT = 8489,
    [Description("Another operation which requires exclusive access to the PDC FSMO is already in progress.")]
    ERROR_DS_PDC_OPERATION_IN_PROGRESS = 8490,
    [Description("A cross-domain move operation failed such that two versions of the moved object exist - one each in the source and destination domains. The destination object needs to be removed to restore the system to a consistent state.")]
    ERROR_DS_CROSS_DOMAIN_CLEANUP_REQD = 8491,
    [Description("This object may not be moved across domain boundaries either because cross-domain moves for this class are disallowed, or the object has some special characteristics, e.g.: trust account or restricted RID, which prevent its move.")]
    ERROR_DS_ILLEGAL_XDOM_MOVE_OPERATION = 8492,
    [Description("Can't move objects with memberships across domain boundaries as once moved, this would violate the membership conditions of the account group. Remove the object from any account group memberships and retry.")]
    ERROR_DS_CANT_WITH_ACCT_GROUP_MEMBERSHPS = 8493,
    [Description("A naming context head must be the immediate child of another naming context head, not of an interior node.")]
    ERROR_DS_NC_MUST_HAVE_NC_PARENT = 8494,
    [Description("The directory cannot validate the proposed naming context name because it does not hold a replica of the naming context above the proposed naming context. Please ensure that the domain naming master role is held by a server that is configured as a global catalog server, and that the server is up to date with its replication partners. (Applies only to Windows 2000 Domain Naming masters.)")]
    ERROR_DS_CR_IMPOSSIBLE_TO_VALIDATE = 8495,
    [Description("Destination domain must be in native mode.")]
    ERROR_DS_DST_DOMAIN_NOT_NATIVE = 8496,
    [Description("The operation cannot be performed because the server does not have an infrastructure container in the domain of interest.")]
    ERROR_DS_MISSING_INFRASTRUCTURE_CONTAINER = 8497,
    [Description("Cross-domain move of non-empty account groups is not allowed.")]
    ERROR_DS_CANT_MOVE_ACCOUNT_GROUP = 8498,
    [Description("Cross-domain move of non-empty resource groups is not allowed.")]
    ERROR_DS_CANT_MOVE_RESOURCE_GROUP = 8499,
    [Description("The search flags for the attribute are invalid. The ANR bit is valid only on attributes of Unicode or Teletex strings.")]
    ERROR_DS_INVALID_SEARCH_FLAG = 8500,
    [Description("Tree deletions starting at an object which has an NC head as a descendant are not allowed.")]
    ERROR_DS_NO_TREE_DELETE_ABOVE_NC = 8501,
    [Description("The directory service failed to lock a tree in preparation for a tree deletion because the tree was in use.")]
    ERROR_DS_COULDNT_LOCK_TREE_FOR_DELETE = 8502,
    [Description("The directory service failed to identify the list of objects to delete while attempting a tree deletion.")]
    ERROR_DS_COULDNT_IDENTIFY_OBJECTS_FOR_TREE_DELETE = 8503,
    [Description("Security Accounts Manager initialization failed because of the following error: %1. Error Status: 0x%2. Please shutdown this system and reboot into Directory Services Restore Mode, check the event log for more  detailed information.")]
    ERROR_DS_SAM_INIT_FAILURE = 8504,
    [Description("Only an administrator can modify the membership list of an administrative group.")]
    ERROR_DS_SENSITIVE_GROUP_VIOLATION = 8505,
    [Description("Cannot change the primary group ID of a domain controller account.")]
    ERROR_DS_CANT_MOD_PRIMARYGROUPID = 8506,
    [Description("An attempt is made to modify the base schema.")]
    ERROR_DS_ILLEGAL_BASE_SCHEMA_MOD = 8507,
    [Description("Adding a new mandatory attribute to an existing class, deleting a mandatory attribute from an existing class, or adding an optional attribute to the special class Top that is not a backlink attribute (directly or  through inheritance, for example, by adding or deleting an auxiliary class) is not allowed.")]
    ERROR_DS_NONSAFE_SCHEMA_CHANGE = 8508,
    [Description("Schema update is not allowed on this DC because the DC is not the schema FSMO Role Owner.")]
    ERROR_DS_SCHEMA_UPDATE_DISALLOWED = 8509,
    [Description("An object of this class cannot be created under the schema container. You can only create attribute-schema and class-schema objects under the schema container.")]
    ERROR_DS_CANT_CREATE_UNDER_SCHEMA = 8510,
    [Description("The replica/child install failed to get the objectVersion attribute on the schema container on the source DC. Either the attribute is missing on the schema container or the credentials supplied do not have permission to read it.")]
    ERROR_DS_INSTALL_NO_SRC_SCH_VERSION = 8511,
    [Description("The replica/child install failed to read the objectVersion attribute in the SCHEMA section of the file schema.ini in the system32 directory.")]
    ERROR_DS_INSTALL_NO_SCH_VERSION_IN_INIFILE = 8512,
    [Description("The specified group type is invalid.")]
    ERROR_DS_INVALID_GROUP_TYPE = 8513,
    [Description("You cannot nest global groups in a mixed domain if the group is security-enabled.")]
    ERROR_DS_NO_NEST_GLOBALGROUP_IN_MIXEDDOMAIN = 8514,
    [Description("You cannot nest local groups in a mixed domain if the group is security-enabled.")]
    ERROR_DS_NO_NEST_LOCALGROUP_IN_MIXEDDOMAIN = 8515,
    [Description("A global group cannot have a local group as a member.")]
    ERROR_DS_GLOBAL_CANT_HAVE_LOCAL_MEMBER = 8516,
    [Description("A global group cannot have a universal group as a member.")]
    ERROR_DS_GLOBAL_CANT_HAVE_UNIVERSAL_MEMBER = 8517,
    [Description("A universal group cannot have a local group as a member.")]
    ERROR_DS_UNIVERSAL_CANT_HAVE_LOCAL_MEMBER = 8518,
    [Description("A global group cannot have a cross-domain member.")]
    ERROR_DS_GLOBAL_CANT_HAVE_CROSSDOMAIN_MEMBER = 8519,
    [Description("A local group cannot have another cross domain local group as a member.")]
    ERROR_DS_LOCAL_CANT_HAVE_CROSSDOMAIN_LOCAL_MEMBER = 8520,
    [Description("A group with primary members cannot change to a security-disabled group.")]
    ERROR_DS_HAVE_PRIMARY_MEMBERS = 8521,
    [Description("The schema cache load failed to convert the string default SD on a class-schema object.")]
    ERROR_DS_STRING_SD_CONVERSION_FAILED = 8522,
    [Description("Only DSAs configured to be Global Catalog servers should be allowed to hold the Domain Naming Master FSMO role. (Applies only to Windows 2000 servers.)")]
    ERROR_DS_NAMING_MASTER_GC = 8523,
    [Description("The DSA operation is unable to proceed because of a DNS lookup failure.")]
    ERROR_DS_DNS_LOOKUP_FAILURE = 8524,
    [Description("While processing a change to the DNS Host Name for an object, the Service Principal Name values could not be kept in sync.")]
    ERROR_DS_COULDNT_UPDATE_SPNS = 8525,
    [Description("The Security Descriptor attribute could not be read.")]
    ERROR_DS_CANT_RETRIEVE_SD = 8526,
    [Description("The object requested was not found, but an object with that key was found.")]
    ERROR_DS_KEY_NOT_UNIQUE = 8527,
    [Description("The syntax of the linked attribute being added is incorrect. Forward links can only have syntax 2.5.5.1, 2.5.5.7, and 2.5.5.14, and backlinks can only have syntax 2.5.5.1.")]
    ERROR_DS_WRONG_LINKED_ATT_SYNTAX = 8528,
    [Description("Security Account Manager needs to get the boot password.")]
    ERROR_DS_SAM_NEED_BOOTKEY_PASSWORD = 8529,
    [Description("Security Account Manager needs to get the boot key from floppy disk.")]
    ERROR_DS_SAM_NEED_BOOTKEY_FLOPPY = 8530,
    [Description("Directory Service cannot start.")]
    ERROR_DS_CANT_START = 8531,
    [Description("Directory Services could not start.")]
    ERROR_DS_INIT_FAILURE = 8532,
    [Description("The connection between client and server requires packet privacy or better.")]
    ERROR_DS_NO_PKT_PRIVACY_ON_CONNECTION = 8533,
    [Description("The source domain may not be in the same forest as destination.")]
    ERROR_DS_SOURCE_DOMAIN_IN_FOREST = 8534,
    [Description("The destination domain must be in the forest.")]
    ERROR_DS_DESTINATION_DOMAIN_NOT_IN_FOREST = 8535,
    [Description("The operation requires that destination domain auditing be enabled.")]
    ERROR_DS_DESTINATION_AUDITING_NOT_ENABLED = 8536,
    [Description("The operation couldn't locate a DC for the source domain.")]
    ERROR_DS_CANT_FIND_DC_FOR_SRC_DOMAIN = 8537,
    [Description("The source object must be a group or user.")]
    ERROR_DS_SRC_OBJ_NOT_GROUP_OR_USER = 8538,
    [Description("The source object's SID already exists in destination forest.")]
    ERROR_DS_SRC_SID_EXISTS_IN_FOREST = 8539,
    [Description("The source and destination object must be of the same type.")]
    ERROR_DS_SRC_AND_DST_OBJECT_CLASS_MISMATCH = 8540,
    [Description("Security Accounts Manager initialization failed because of the following error: %1. Error Status: 0x%2. Click OK to shut down the system and reboot into Safe Mode. Check the event log for detailed information.")]
    ERROR_SAM_INIT_FAILURE = 8541,
    [Description("Schema information could not be included in the replication request.")]
    ERROR_DS_DRA_SCHEMA_INFO_SHIP = 8542,
    [Description("The replication operation could not be completed due to a schema incompatibility.")]
    ERROR_DS_DRA_SCHEMA_CONFLICT = 8543,
    [Description("The replication operation could not be completed due to a previous schema incompatibility.")]
    ERROR_DS_DRA_EARLIER_SCHEMA_CONFLICT = 8544,
    [Description("The replication update could not be applied because either the source or the destination has not yet received information regarding a recent cross-domain move operation.")]
    ERROR_DS_DRA_OBJ_NC_MISMATCH = 8545,
    [Description("The requested domain could not be deleted because there exist domain controllers that still host this domain.")]
    ERROR_DS_NC_STILL_HAS_DSAS = 8546,
    [Description("The requested operation can be performed only on a global catalog server.")]
    ERROR_DS_GC_REQUIRED = 8547,
    [Description("A local group can only be a member of other local groups in the same domain.")]
    ERROR_DS_LOCAL_MEMBER_OF_LOCAL_ONLY = 8548,
    [Description("Foreign security principals cannot be members of universal groups.")]
    ERROR_DS_NO_FPO_IN_UNIVERSAL_GROUPS = 8549,
    [Description("The attribute is not allowed to be replicated to the GC because of security reasons.")]
    ERROR_DS_CANT_ADD_TO_GC = 8550,
    [Description("The checkpoint with the PDC could not be taken because there too many modifications being processed currently.")]
    ERROR_DS_NO_CHECKPOINT_WITH_PDC = 8551,
    [Description("The operation requires that source domain auditing be enabled.")]
    ERROR_DS_SOURCE_AUDITING_NOT_ENABLED = 8552,
    [Description("Security principal objects can only be created inside domain naming contexts.")]
    ERROR_DS_CANT_CREATE_IN_NONDOMAIN_NC = 8553,
    [Description("A Service Principal Name (SPN) could not be constructed because the provided hostname is not in the necessary format.")]
    ERROR_DS_INVALID_NAME_FOR_SPN = 8554,
    [Description("A Filter was passed that uses constructed attributes.")]
    ERROR_DS_FILTER_USES_CONTRUCTED_ATTRS = 8555,
    [Description("The unicodePwd attribute value must be enclosed in double quotes.")]
    ERROR_DS_UNICODEPWD_NOT_IN_QUOTES = 8556,
    [Description("Your computer could not be joined to the domain. You have exceeded the maximum number of computer accounts you are allowed to create in this domain. Contact your system administrator to have this limit reset or increased.")]
    ERROR_DS_MACHINE_ACCOUNT_QUOTA_EXCEEDED = 8557,
    [Description("For security reasons, the operation must be run on the destination DC.")]
    ERROR_DS_MUST_BE_RUN_ON_DST_DC = 8558,
    [Description("For security reasons, the source DC must be NT4SP4 or greater.")]
    ERROR_DS_SRC_DC_MUST_BE_SP4_OR_GREATER = 8559,
    [Description("Critical Directory Service System objects cannot be deleted during tree delete operations. The tree delete may have been partially performed.")]
    ERROR_DS_CANT_TREE_DELETE_CRITICAL_OBJ = 8560,
    [Description("Directory Services could not start because of the following error: %1. Error Status: 0x%2. Please click OK to shutdown the system. You can use the recovery console to diagnose the system further.")]
    ERROR_DS_INIT_FAILURE_CONSOLE = 8561,
    [Description("Security Accounts Manager initialization failed because of the following error: %1. Error Status: 0x%2. Please click OK to shutdown the system. You can use the recovery console to diagnose the system further.")]
    ERROR_DS_SAM_INIT_FAILURE_CONSOLE = 8562,
    [Description("The version of the operating system is incompatible with the current AD DS forest functional level or AD LDS Configuration Set functional level. You must upgrade to a new version of the operating system before this server can become an AD DS Domain Controller or add an AD LDS Instance in this AD DS Forest or AD LDS Configuration Set.")]
    ERROR_DS_FOREST_VERSION_TOO_HIGH = 8563,
    [Description("The version of the operating system installed is incompatible with the current domain functional level. You must upgrade to a new version of the operating system before this server can become a domain controller in this domain.")]
    ERROR_DS_DOMAIN_VERSION_TOO_HIGH = 8564,
    [Description("The version of the operating system installed on this server no longer supports the current AD DS Forest functional level or AD LDS Configuration Set functional level. You must raise the AD DS Forest functional level or AD LDS Configuration Set functional level before this server can become an AD DS Domain Controller or an AD LDS Instance in this Forest or Configuration Set.")]
    ERROR_DS_FOREST_VERSION_TOO_LOW = 8565,
    [Description("The version of the operating system installed on this server no longer supports the current domain functional level. You must raise the domain functional level before this server can become a domain controller in this domain.")]
    ERROR_DS_DOMAIN_VERSION_TOO_LOW = 8566,
    [Description("The version of the operating system installed on this server is incompatible with the functional level of the domain or forest.")]
    ERROR_DS_INCOMPATIBLE_VERSION = 8567,
    [Description("The functional level of the domain (or forest) cannot be raised to the requested value, because there exist one or more domain controllers in the domain (or forest) that are at a lower incompatible functional level.")]
    ERROR_DS_LOW_DSA_VERSION = 8568,
    [Description("The forest functional level cannot be raised to the requested value since one or more domains are still in mixed domain mode. All domains in the forest must be in native mode, for you to raise the forest functional level.")]
    ERROR_DS_NO_BEHAVIOR_VERSION_IN_MIXEDDOMAIN = 8569,
    [Description("The sort order requested is not supported.")]
    ERROR_DS_NOT_SUPPORTED_SORT_ORDER = 8570,
    [Description("The requested name already exists as a unique identifier.")]
    ERROR_DS_NAME_NOT_UNIQUE = 8571,
    [Description("The machine account was created pre-NT4. The account needs to be recreated.")]
    ERROR_DS_MACHINE_ACCOUNT_CREATED_PRENT4 = 8572,
    [Description("The database is out of version store.")]
    ERROR_DS_OUT_OF_VERSION_STORE = 8573,
    [Description("Unable to continue operation because multiple conflicting controls were used.")]
    ERROR_DS_INCOMPATIBLE_CONTROLS_USED = 8574,
    [Description("Unable to find a valid security descriptor reference domain for this partition.")]
    ERROR_DS_NO_REF_DOMAIN = 8575,
    [Description("Schema update failed: The link identifier is reserved.")]
    ERROR_DS_RESERVED_LINK_ID = 8576,
    [Description("Schema update failed: There are no link identifiers available.")]
    ERROR_DS_LINK_ID_NOT_AVAILABLE = 8577,
    [Description("An account group cannot have a universal group as a member.")]
    ERROR_DS_AG_CANT_HAVE_UNIVERSAL_MEMBER = 8578,
    [Description("Rename or move operations on naming context heads or read-only objects are not allowed.")]
    ERROR_DS_MODIFYDN_DISALLOWED_BY_INSTANCE_TYPE = 8579,
    [Description("Move operations on objects in the schema naming context are not allowed.")]
    ERROR_DS_NO_OBJECT_MOVE_IN_SCHEMA_NC = 8580,
    [Description("A system flag has been set on the object and does not allow the object to be moved or renamed.")]
    ERROR_DS_MODIFYDN_DISALLOWED_BY_FLAG = 8581,
    [Description("This object is not allowed to change its grandparent container. Moves are not forbidden on this object, but are restricted to sibling containers.")]
    ERROR_DS_MODIFYDN_WRONG_GRANDPARENT = 8582,
    [Description("Unable to resolve completely, a referral to another forest is generated.")]
    ERROR_DS_NAME_ERROR_TRUST_REFERRAL = 8583,
    [Description("The requested action is not supported on standard server.")]
    ERROR_NOT_SUPPORTED_ON_STANDARD_SERVER = 8584,
    [Description("Could not access a partition of the directory service located on a remote server. Make sure at least one server is running for the partition in question.")]
    ERROR_DS_CANT_ACCESS_REMOTE_PART_OF_AD = 8585,
    [Description("The directory cannot validate the proposed naming context (or partition) name because it does not hold a replica nor can it contact a replica of the naming context above the proposed naming context. Please ensure that the parent naming context is properly registered in DNS, and at least one replica of this naming context is reachable by the Domain Naming master.")]
    ERROR_DS_CR_IMPOSSIBLE_TO_VALIDATE_V2 = 8586,
    [Description("The thread limit for this request was exceeded.")]
    ERROR_DS_THREAD_LIMIT_EXCEEDED = 8587,
    [Description("The Global catalog server is not in the closest site.")]
    ERROR_DS_NOT_CLOSEST = 8588,
    [Description("The DS cannot derive a service principal name (SPN) with which to mutually authenticate the target server because the corresponding server object in the local DS database has no serverReference attribute.")]
    ERROR_DS_CANT_DERIVE_SPN_WITHOUT_SERVER_REF = 8589,
    [Description("The Directory Service failed to enter single user mode.")]
    ERROR_DS_SINGLE_USER_MODE_FAILED = 8590,
    [Description("The Directory Service cannot parse the script because of a syntax error.")]
    ERROR_DS_NTDSCRIPT_SYNTAX_ERROR = 8591,
    [Description("The Directory Service cannot process the script because of an error.")]
    ERROR_DS_NTDSCRIPT_PROCESS_ERROR = 8592,
    [Description("The directory service cannot perform the requested operation because the servers involved are of different replication epochs (which is usually related to a domain rename that is in progress).")]
    ERROR_DS_DIFFERENT_REPL_EPOCHS = 8593,
    [Description("The directory service binding must be renegotiated due to a change in the server extensions information.")]
    ERROR_DS_DRS_EXTENSIONS_CHANGED = 8594,
    [Description("Operation not allowed on a disabled cross ref.")]
    ERROR_DS_REPLICA_SET_CHANGE_NOT_ALLOWED_ON_DISABLED_CR = 8595,
    [Description("Schema update failed: No values for msDS-IntId are available.")]
    ERROR_DS_NO_MSDS_INTID = 8596,
    [Description("Schema update failed: Duplicate msDS-INtId. Retry the operation.")]
    ERROR_DS_DUP_MSDS_INTID = 8597,
    [Description("Schema deletion failed: attribute is used in rDNAttID.")]
    ERROR_DS_EXISTS_IN_RDNATTID = 8598,
    [Description("The directory service failed to authorize the request.")]
    ERROR_DS_AUTHORIZATION_FAILED = 8599,
    [Description("The Directory Service cannot process the script because it is invalid.")]
    ERROR_DS_INVALID_SCRIPT = 8600,
    [Description("The remote create cross reference operation failed on the Domain Naming Master FSMO. The operation's error is in the extended data.")]
    ERROR_DS_REMOTE_CROSSREF_OP_FAILED = 8601,
    [Description("A cross reference is in use locally with the same name.")]
    ERROR_DS_CROSS_REF_BUSY = 8602,
    [Description("The DS cannot derive a service principal name (SPN) with which to mutually authenticate the target server because the server's domain has been deleted from the forest.")]
    ERROR_DS_CANT_DERIVE_SPN_FOR_DELETED_DOMAIN = 8603,
    [Description("Writeable NCs prevent this DC from demoting.")]
    ERROR_DS_CANT_DEMOTE_WITH_WRITEABLE_NC = 8604,
    [Description("The requested object has a non-unique identifier and cannot be retrieved.")]
    ERROR_DS_DUPLICATE_ID_FOUND = 8605,
    [Description("Insufficient attributes were given to create an object. This object may not exist because it may have been deleted and already garbage collected.")]
    ERROR_DS_INSUFFICIENT_ATTR_TO_CREATE_OBJECT = 8606,
    [Description("The group cannot be converted due to attribute restrictions on the requested group type.")]
    ERROR_DS_GROUP_CONVERSION_ERROR = 8607,
    [Description("Cross-domain move of non-empty basic application groups is not allowed.")]
    ERROR_DS_CANT_MOVE_APP_BASIC_GROUP = 8608,
    [Description("Cross-domain move of non-empty query based application groups is not allowed.")]
    ERROR_DS_CANT_MOVE_APP_QUERY_GROUP = 8609,
    [Description("The FSMO role ownership could not be verified because its directory partition has not replicated successfully with at least one replication partner.")]
    ERROR_DS_ROLE_NOT_VERIFIED = 8610,
    [Description("The target container for a redirection of a well known object container cannot already be a special container.")]
    ERROR_DS_WKO_CONTAINER_CANNOT_BE_SPECIAL = 8611,
    [Description("The Directory Service cannot perform the requested operation because a domain rename operation is in progress.")]
    ERROR_DS_DOMAIN_RENAME_IN_PROGRESS = 8612,
    [Description("The directory service detected a child partition below the requested partition name. The partition hierarchy must be created in a top down method.")]
    ERROR_DS_EXISTING_AD_CHILD_NC = 8613,
    [Description("The directory service cannot replicate with this server because the time since the last replication with this server has exceeded the tombstone lifetime.")]
    ERROR_DS_REPL_LIFETIME_EXCEEDED = 8614,
    [Description("The requested operation is not allowed on an object under the system container.")]
    ERROR_DS_DISALLOWED_IN_SYSTEM_CONTAINER = 8615,
    [Description("The LDAP servers network send queue has filled up because the client is not processing the results of its requests fast enough. No more requests will be processed until the client catches up. If the client does not catch up then it will be disconnected.")]
    ERROR_DS_LDAP_SEND_QUEUE_FULL = 8616,
    [Description("The scheduled replication did not take place because the system was too busy to execute the request within the schedule window. The replication queue is overloaded. Consider reducing the number of partners or decreasing the scheduled replication frequency.")]
    ERROR_DS_DRA_OUT_SCHEDULE_WINDOW = 8617,
    [Description("At this time, it cannot be determined if the branch replication policy is available on the hub domain controller. Please retry at a later time to account for replication latencies.")]
    ERROR_DS_POLICY_NOT_KNOWN = 8618,
    [Description("The site settings object for the specified site does not exist.")]
    ERROR_NO_SITE_SETTINGS_OBJECT = 8619,
    [Description("The local account store does not contain secret material for the specified account.")]
    ERROR_NO_SECRETS = 8620,
    [Description("Could not find a writable domain controller in the domain.")]
    ERROR_NO_WRITABLE_DC_FOUND = 8621,
    [Description("The server object for the domain controller does not exist.")]
    ERROR_DS_NO_SERVER_OBJECT = 8622,
    [Description("The NTDS Settings object for the domain controller does not exist.")]
    ERROR_DS_NO_NTDSA_OBJECT = 8623,
    [Description("The requested search operation is not supported for ASQ searches.")]
    ERROR_DS_NON_ASQ_SEARCH = 8624,
    [Description("A required audit event could not be generated for the operation.")]
    ERROR_DS_AUDIT_FAILURE = 8625,
    [Description("The search flags for the attribute are invalid. The subtree index bit is valid only on single valued attributes.")]
    ERROR_DS_INVALID_SEARCH_FLAG_SUBTREE = 8626,
    [Description("The search flags for the attribute are invalid. The tuple index bit is valid only on attributes of Unicode strings.")]
    ERROR_DS_INVALID_SEARCH_FLAG_TUPLE = 8627,
    [Description("The address books are nested too deeply. Failed to build the hierarchy table.")]
    ERROR_DS_HIERARCHY_TABLE_TOO_DEEP = 8628,
    [Description("The specified up-to-date-ness vector is corrupt.")]
    ERROR_DS_DRA_CORRUPT_UTD_VECTOR = 8629,
    [Description("The request to replicate secrets is denied.")]
    ERROR_DS_DRA_SECRETS_DENIED = 8630,
    [Description("Schema update failed: The MAPI identifier is reserved.")]
    ERROR_DS_RESERVED_MAPI_ID = 8631,
    [Description("Schema update failed: There are no MAPI identifiers available.")]
    ERROR_DS_MAPI_ID_NOT_AVAILABLE = 8632,
    [Description("The replication operation failed because the required attributes of the local krbtgt object are missing.")]
    ERROR_DS_DRA_MISSING_KRBTGT_SECRET = 8633,
    [Description("The domain name of the trusted domain already exists in the forest.")]
    ERROR_DS_DOMAIN_NAME_EXISTS_IN_FOREST = 8634,
    [Description("The flat name of the trusted domain already exists in the forest.")]
    ERROR_DS_FLAT_NAME_EXISTS_IN_FOREST = 8635,
    [Description("The User Principal Name (UPN) is invalid.")]
    ERROR_INVALID_USER_PRINCIPAL_NAME = 8636,
    [Description("OID mapped groups cannot have members.")]
    ERROR_DS_OID_MAPPED_GROUP_CANT_HAVE_MEMBERS = 8637,
    [Description("The specified OID cannot be found.")]
    ERROR_DS_OID_NOT_FOUND = 8638,
    [Description("The replication operation failed because the target object referred by a link value is recycled.")]
    ERROR_DS_DRA_RECYCLED_TARGET = 8639,
    [Description("The redirect operation failed because the target object is in a NC different from the domain NC of the current domain controller.")]
    ERROR_DS_DISALLOWED_NC_REDIRECT = 8640,
    [Description("The functional level of the AD LDS configuration set cannot be lowered to the requested value.")]
    ERROR_DS_HIGH_ADLDS_FFL = 8641,
    [Description("The functional level of the domain (or forest) cannot be lowered to the requested value.")]
    ERROR_DS_HIGH_DSA_VERSION = 8642,
    [Description("The functional level of the AD LDS configuration set cannot be raised to the requested value, because there exist one or more ADLDS instances that are at a lower incompatible functional level.")]
    ERROR_DS_LOW_ADLDS_FFL = 8643,
    [Description("The domain join cannot be completed because the SID of the domain you attempted to join was identical to the SID of this machine. This is a symptom of an improperly cloned operating system install.  You should run sysprep on this machine in order to generate a new machine SID. Please see http://go.microsoft.com/fwlink/p/?linkid=168895 for more information.")]
    ERROR_DOMAIN_SID_SAME_AS_LOCAL_WORKSTATION = 8644,
    [Description("The undelete operation failed because the Sam Account Name or Additional Sam Account Name of the object being undeleted conflicts with an existing live object.")]
    ERROR_DS_UNDELETE_SAM_VALIDATION_FAILED = 8645,
    [Description("The system is not authoritative for the specified account and therefore cannot complete the operation. Please retry the operation using the provider associated with this account. If this is an online provider please use the provider's online site.")]
    ERROR_INCORRECT_ACCOUNT_TYPE = 8646,
    [Description("DNS server unable to interpret format.")]
    DNS_ERROR_RCODE_FORMAT_ERROR = 9001,
    [Description("DNS server failure.")]
    DNS_ERROR_RCODE_SERVER_FAILURE = 9002,
    [Description("DNS name does not exist.")]
    DNS_ERROR_RCODE_NAME_ERROR = 9003,
    [Description("DNS request not supported by name server.")]
    DNS_ERROR_RCODE_NOT_IMPLEMENTED = 9004,
    [Description("DNS operation refused.")]
    DNS_ERROR_RCODE_REFUSED = 9005,
    [Description("DNS name that ought not exist, does exist.")]
    DNS_ERROR_RCODE_YXDOMAIN = 9006,
    [Description("DNS RR set that ought not exist, does exist.")]
    DNS_ERROR_RCODE_YXRRSET = 9007,
    [Description("DNS RR set that ought to exist, does not exist.")]
    DNS_ERROR_RCODE_NXRRSET = 9008,
    [Description("DNS server not authoritative for zone.")]
    DNS_ERROR_RCODE_NOTAUTH = 9009,
    [Description("DNS name in update or prereq is not in zone.")]
    DNS_ERROR_RCODE_NOTZONE = 9010,
    [Description("DNS signature failed to verify.")]
    DNS_ERROR_RCODE_BADSIG = 9016,
    [Description("DNS bad key.")]
    DNS_ERROR_RCODE_BADKEY = 9017,
    [Description("DNS signature validity expired.")]
    DNS_ERROR_RCODE_BADTIME = 9018,
    [Description("Only the DNS server acting as the key master for the zone may perform this operation.")]
    DNS_ERROR_KEYMASTER_REQUIRED = 9101,
    [Description("This operation is not allowed on a zone that is signed or has signing keys.")]
    DNS_ERROR_NOT_ALLOWED_ON_SIGNED_ZONE = 9102,
    [Description("NSEC3 is not compatible with the RSA-SHA-1 algorithm. Choose a different algorithm or use NSEC. This value was also named DNS_ERROR_INVALID_NSEC3_PARAMETERS")]
    DNS_ERROR_NSEC3_INCOMPATIBLE_WITH_RSA_SHA1 = 9103,
    [Description("The zone does not have enough signing keys. There must be at least one key signing key (KSK) and at least one zone signing key (ZSK).")]
    DNS_ERROR_NOT_ENOUGH_SIGNING_KEY_DESCRIPTORS = 9104,
    [Description("The specified algorithm is not supported.")]
    DNS_ERROR_UNSUPPORTED_ALGORITHM = 9105,
    [Description("The specified key size is not supported.")]
    DNS_ERROR_INVALID_KEY_SIZE = 9106,
    [Description("One or more of the signing keys for a zone are not accessible to the DNS server. Zone signing will not be operational until this error is resolved.")]
    DNS_ERROR_SIGNING_KEY_NOT_ACCESSIBLE = 9107,
    [Description("The specified key storage provider does not support DPAPI++ data protection. Zone signing will not be operational until this error is resolved.")]
    DNS_ERROR_KSP_DOES_NOT_SUPPORT_PROTECTION = 9108,
    [Description("An unexpected DPAPI++ error was encountered. Zone signing will not be operational until this error is resolved.")]
    DNS_ERROR_UNEXPECTED_DATA_PROTECTION_ERROR = 9109,
    [Description("An unexpected crypto error was encountered. Zone signing may not be operational until this error is resolved.")]
    DNS_ERROR_UNEXPECTED_CNG_ERROR = 9110,
    [Description("The DNS server encountered a signing key with an unknown version. Zone signing will not be operational until this error is resolved.")]
    DNS_ERROR_UNKNOWN_SIGNING_PARAMETER_VERSION = 9111,
    [Description("The specified key service provider cannot be opened by the DNS server.")]
    DNS_ERROR_KSP_NOT_ACCESSIBLE = 9112,
    [Description("The DNS server cannot accept any more signing keys with the specified algorithm and KSK flag value for this zone.")]
    DNS_ERROR_TOO_MANY_SKDS = 9113,
    [Description("The specified rollover period is invalid.")]
    DNS_ERROR_INVALID_ROLLOVER_PERIOD = 9114,
    [Description("The specified initial rollover offset is invalid.")]
    DNS_ERROR_INVALID_INITIAL_ROLLOVER_OFFSET = 9115,
    [Description("The specified signing key is already in process of rolling over keys.")]
    DNS_ERROR_ROLLOVER_IN_PROGRESS = 9116,
    [Description("The specified signing key does not have a standby key to revoke.")]
    DNS_ERROR_STANDBY_KEY_NOT_PRESENT = 9117,
    [Description("This operation is not allowed on a zone signing key (ZSK).")]
    DNS_ERROR_NOT_ALLOWED_ON_ZSK = 9118,
    [Description("This operation is not allowed on an active signing key.")]
    DNS_ERROR_NOT_ALLOWED_ON_ACTIVE_SKD = 9119,
    [Description("The specified signing key is already queued for rollover.")]
    DNS_ERROR_ROLLOVER_ALREADY_QUEUED = 9120,
    [Description("This operation is not allowed on an unsigned zone.")]
    DNS_ERROR_NOT_ALLOWED_ON_UNSIGNED_ZONE = 9121,
    [Description("This operation could not be completed because the DNS server listed as the current key master for this zone is down or misconfigured. Resolve the problem on the current key master for this zone or use another DNS server to seize the key master role.")]
    DNS_ERROR_BAD_KEYMASTER = 9122,
    [Description("The specified signature validity period is invalid.")]
    DNS_ERROR_INVALID_SIGNATURE_VALIDITY_PERIOD = 9123,
    [Description("The specified NSEC3 iteration count is higher than allowed by the minimum key length used in the zone.")]
    DNS_ERROR_INVALID_NSEC3_ITERATION_COUNT = 9124,
    [Description("This operation could not be completed because the DNS server has been configured with DNSSEC features disabled. Enable DNSSEC on the DNS server.")]
    DNS_ERROR_DNSSEC_IS_DISABLED = 9125,
    [Description("This operation could not be completed because the XML stream received is empty or syntactically invalid.")]
    DNS_ERROR_INVALID_XML = 9126,
    [Description("This operation completed, but no trust anchors were added because all of the trust anchors received were either invalid, unsupported, expired, or would not become valid in less than 30 days.")]
    DNS_ERROR_NO_VALID_TRUST_ANCHORS = 9127,
    [Description("The specified signing key is not waiting for parental DS update.")]
    DNS_ERROR_ROLLOVER_NOT_POKEABLE = 9128,
    [Description("Hash collision detected during NSEC3 signing. Specify a different user-provided salt, or use a randomly generated salt, and attempt to sign the zone again.")]
    DNS_ERROR_NSEC3_NAME_COLLISION = 9129,
    [Description("NSEC is not compatible with the NSEC3-RSA-SHA-1 algorithm. Choose a different algorithm or use NSEC3.")]
    DNS_ERROR_NSEC_INCOMPATIBLE_WITH_NSEC3_RSA_SHA1 = 9130,
    [Description("No records found for given DNS query.")]
    DNS_INFO_NO_RECORDS = 9501,
    [Description("Bad DNS packet.")]
    DNS_ERROR_BAD_PACKET = 9502,
    [Description("No DNS packet.")]
    DNS_ERROR_NO_PACKET = 9503,
    [Description("DNS error, check rcode.")]
    DNS_ERROR_RCODE = 9504,
    [Description("Unsecured DNS packet.")]
    DNS_ERROR_UNSECURE_PACKET = 9505,
    [Description("DNS query request is pending.")]
    DNS_REQUEST_PENDING = 9506,
    [Description("Invalid DNS type.")]
    DNS_ERROR_INVALID_TYPE = 9551,
    [Description("Invalid IP address.")]
    DNS_ERROR_INVALID_IP_ADDRESS = 9552,
    [Description("Invalid property.")]
    DNS_ERROR_INVALID_PROPERTY = 9553,
    [Description("Try DNS operation again later.")]
    DNS_ERROR_TRY_AGAIN_LATER = 9554,
    [Description("Record for given name and type is not unique.")]
    DNS_ERROR_NOT_UNIQUE = 9555,
    [Description("DNS name does not comply with RFC specifications.")]
    DNS_ERROR_NON_RFC_NAME = 9556,
    [Description("DNS name is a fully-qualified DNS name.")]
    DNS_STATUS_FQDN = 9557,
    [Description("DNS name is dotted (multi-label).")]
    DNS_STATUS_DOTTED_NAME = 9558,
    [Description("DNS name is a single-part name.")]
    DNS_STATUS_SINGLE_PART_NAME = 9559,
    [Description("DNS name contains an invalid character.")]
    DNS_ERROR_INVALID_NAME_CHAR = 9560,
    [Description("DNS name is entirely numeric.")]
    DNS_ERROR_NUMERIC_NAME = 9561,
    [Description("The operation requested is not permitted on a DNS root server.")]
    DNS_ERROR_NOT_ALLOWED_ON_ROOT_SERVER = 9562,
    [Description("The record could not be created because this part of the DNS namespace has been delegated to another server.")]
    DNS_ERROR_NOT_ALLOWED_UNDER_DELEGATION = 9563,
    [Description("The DNS server could not find a set of root hints.")]
    DNS_ERROR_CANNOT_FIND_ROOT_HINTS = 9564,
    [Description("The DNS server found root hints but they were not consistent across all adapters.")]
    DNS_ERROR_INCONSISTENT_ROOT_HINTS = 9565,
    [Description("The specified value is too small for this parameter.")]
    DNS_ERROR_DWORD_VALUE_TOO_SMALL = 9566,
    [Description("The specified value is too large for this parameter.")]
    DNS_ERROR_DWORD_VALUE_TOO_LARGE = 9567,
    [Description("This operation is not allowed while the DNS server is loading zones in the background. Please try again later.")]
    DNS_ERROR_BACKGROUND_LOADING = 9568,
    [Description("The operation requested is not permitted on against a DNS server running on a read-only DC.")]
    DNS_ERROR_NOT_ALLOWED_ON_RODC = 9569,
    [Description("No data is allowed to exist underneath a DNAME record.")]
    DNS_ERROR_NOT_ALLOWED_UNDER_DNAME = 9570,
    [Description("This operation requires credentials delegation.")]
    DNS_ERROR_DELEGATION_REQUIRED = 9571,
    [Description("Name resolution policy table has been corrupted. DNS resolution will fail until it is fixed. Contact your network administrator.")]
    DNS_ERROR_INVALID_POLICY_TABLE = 9572,
    [Description("DNS zone does not exist.")]
    DNS_ERROR_ZONE_DOES_NOT_EXIST = 9601,
    [Description("DNS zone information not available.")]
    DNS_ERROR_NO_ZONE_INFO = 9602,
    [Description("Invalid operation for DNS zone.")]
    DNS_ERROR_INVALID_ZONE_OPERATION = 9603,
    [Description("Invalid DNS zone configuration.")]
    DNS_ERROR_ZONE_CONFIGURATION_ERROR = 9604,
    [Description("DNS zone has no start of authority (SOA) record.")]
    DNS_ERROR_ZONE_HAS_NO_SOA_RECORD = 9605,
    [Description("DNS zone has no Name Server (NS) record.")]
    DNS_ERROR_ZONE_HAS_NO_NS_RECORDS = 9606,
    [Description("DNS zone is locked.")]
    DNS_ERROR_ZONE_LOCKED = 9607,
    [Description("DNS zone creation failed.")]
    DNS_ERROR_ZONE_CREATION_FAILED = 9608,
    [Description("DNS zone already exists.")]
    DNS_ERROR_ZONE_ALREADY_EXISTS = 9609,
    [Description("DNS automatic zone already exists.")]
    DNS_ERROR_AUTOZONE_ALREADY_EXISTS = 9610,
    [Description("Invalid DNS zone type.")]
    DNS_ERROR_INVALID_ZONE_TYPE = 9611,
    [Description("Secondary DNS zone requires master IP address.")]
    DNS_ERROR_SECONDARY_REQUIRES_MASTER_IP = 9612,
    [Description("DNS zone not secondary.")]
    DNS_ERROR_ZONE_NOT_SECONDARY = 9613,
    [Description("Need secondary IP address.")]
    DNS_ERROR_NEED_SECONDARY_ADDRESSES = 9614,
    [Description("WINS initialization failed.")]
    DNS_ERROR_WINS_INIT_FAILED = 9615,
    [Description("Need WINS servers.")]
    DNS_ERROR_NEED_WINS_SERVERS = 9616,
    [Description("NBTSTAT initialization call failed.")]
    DNS_ERROR_NBSTAT_INIT_FAILED = 9617,
    [Description("Invalid delete of start of authority (SOA).")]
    DNS_ERROR_SOA_DELETE_INVALID = 9618,
    [Description("A conditional forwarding zone already exists for that name.")]
    DNS_ERROR_FORWARDER_ALREADY_EXISTS = 9619,
    [Description("This zone must be configured with one or more master DNS server IP addresses.")]
    DNS_ERROR_ZONE_REQUIRES_MASTER_IP = 9620,
    [Description("The operation cannot be performed because this zone is shut down.")]
    DNS_ERROR_ZONE_IS_SHUTDOWN = 9621,
    [Description("This operation cannot be performed because the zone is currently being signed. Please try again later.")]
    DNS_ERROR_ZONE_LOCKED_FOR_SIGNING = 9622,
    [Description("Primary DNS zone requires datafile.")]
    DNS_ERROR_PRIMARY_REQUIRES_DATAFILE = 9651,
    [Description("Invalid datafile name for DNS zone.")]
    DNS_ERROR_INVALID_DATAFILE_NAME = 9652,
    [Description("Failed to open datafile for DNS zone.")]
    DNS_ERROR_DATAFILE_OPEN_FAILURE = 9653,
    [Description("Failed to write datafile for DNS zone.")]
    DNS_ERROR_FILE_WRITEBACK_FAILED = 9654,
    [Description("Failure while reading datafile for DNS zone.")]
    DNS_ERROR_DATAFILE_PARSING = 9655,
    [Description("DNS record does not exist.")]
    DNS_ERROR_RECORD_DOES_NOT_EXIST = 9701,
    [Description("DNS record format error.")]
    DNS_ERROR_RECORD_FORMAT = 9702,
    [Description("Node creation failure in DNS.")]
    DNS_ERROR_NODE_CREATION_FAILED = 9703,
    [Description("Unknown DNS record type.")]
    DNS_ERROR_UNKNOWN_RECORD_TYPE = 9704,
    [Description("DNS record timed out.")]
    DNS_ERROR_RECORD_TIMED_OUT = 9705,
    [Description("Name not in DNS zone.")]
    DNS_ERROR_NAME_NOT_IN_ZONE = 9706,
    [Description("CNAME loop detected.")]
    DNS_ERROR_CNAME_LOOP = 9707,
    [Description("Node is a CNAME DNS record.")]
    DNS_ERROR_NODE_IS_CNAME = 9708,
    [Description("A CNAME record already exists for given name.")]
    DNS_ERROR_CNAME_COLLISION = 9709,
    [Description("Record only at DNS zone root.")]
    DNS_ERROR_RECORD_ONLY_AT_ZONE_ROOT = 9710,
    [Description("DNS record already exists.")]
    DNS_ERROR_RECORD_ALREADY_EXISTS = 9711,
    [Description("Secondary DNS zone data error.")]
    DNS_ERROR_SECONDARY_DATA = 9712,
    [Description("Could not create DNS cache data.")]
    DNS_ERROR_NO_CREATE_CACHE_DATA = 9713,
    [Description("DNS name does not exist.")]
    DNS_ERROR_NAME_DOES_NOT_EXIST = 9714,
    [Description("Could not create pointer (PTR) record.")]
    DNS_WARNING_PTR_CREATE_FAILED = 9715,
    [Description("DNS domain was undeleted.")]
    DNS_WARNING_DOMAIN_UNDELETED = 9716,
    [Description("The directory service is unavailable.")]
    DNS_ERROR_DS_UNAVAILABLE = 9717,
    [Description("DNS zone already exists in the directory service.")]
    DNS_ERROR_DS_ZONE_ALREADY_EXISTS = 9718,
    [Description("DNS server not creating or reading the boot file for the directory service integrated DNS zone.")]
    DNS_ERROR_NO_BOOTFILE_IF_DS_ZONE = 9719,
    [Description("Node is a DNAME DNS record.")]
    DNS_ERROR_NODE_IS_DNAME = 9720,
    [Description("A DNAME record already exists for given name.")]
    DNS_ERROR_DNAME_COLLISION = 9721,
    [Description("An alias loop has been detected with either CNAME or DNAME records.")]
    DNS_ERROR_ALIAS_LOOP = 9722,
    [Description("DNS AXFR (zone transfer) complete.")]
    DNS_INFO_AXFR_COMPLETE = 9751,
    [Description("DNS zone transfer failed.")]
    DNS_ERROR_AXFR = 9752,
    [Description("Added local WINS server.")]
    DNS_INFO_ADDED_LOCAL_WINS = 9753,
    [Description("Secure update call needs to continue update request.")]
    DNS_STATUS_CONTINUE_NEEDED = 9801,
    [Description("TCP/IP network protocol not installed.")]
    DNS_ERROR_NO_TCPIP = 9851,
    [Description("No DNS servers configured for local system.")]
    DNS_ERROR_NO_DNS_SERVERS = 9852,
    [Description("The specified directory partition does not exist.")]
    DNS_ERROR_DP_DOES_NOT_EXIST = 9901,
    [Description("The specified directory partition already exists.")]
    DNS_ERROR_DP_ALREADY_EXISTS = 9902,
    [Description("This DNS server is not enlisted in the specified directory partition.")]
    DNS_ERROR_DP_NOT_ENLISTED = 9903,
    [Description("This DNS server is already enlisted in the specified directory partition.")]
    DNS_ERROR_DP_ALREADY_ENLISTED = 9904,
    [Description("The directory partition is not available at this time. Please wait a few minutes and try again.")]
    DNS_ERROR_DP_NOT_AVAILABLE = 9905,
    [Description("The operation failed because the domain naming master FSMO role could not be reached. The domain controller holding the domain naming master FSMO role is down or unable to service the request or is not running Windows Server 2003 or later.")]
    DNS_ERROR_DP_FSMO_ERROR = 9906,
    [Description("A blocking operation was interrupted by a call to WSACancelBlockingCall.")]
    WSAEINTR = 10004,
    [Description("The file handle supplied is not valid.")]
    WSAEBADF = 10009,
    [Description("An attempt was made to access a socket in a way forbidden by its access permissions.")]
    WSAEACCES = 10013,
    [Description("The system detected an invalid pointer address in attempting to use a pointer argument in a call.")]
    WSAEFAULT = 10014,
    [Description("An invalid argument was supplied.")]
    WSAEINVAL = 10022,
    [Description("Too many open sockets.")]
    WSAEMFILE = 10024,
    [Description("A non-blocking socket operation could not be completed immediately.")]
    WSAEWOULDBLOCK = 10035,
    [Description("A blocking operation is currently executing.")]
    WSAEINPROGRESS = 10036,
    [Description("An operation was attempted on a non-blocking socket that already had an operation in progress.")]
    WSAEALREADY = 10037,
    [Description("An operation was attempted on something that is not a socket.")]
    WSAENOTSOCK = 10038,
    [Description("A required address was omitted from an operation on a socket.")]
    WSAEDESTADDRREQ = 10039,
    [Description("A message sent on a datagram socket was larger than the internal message buffer or some other network limit, or the buffer used to receive a datagram into was smaller than the datagram itself.")]
    WSAEMSGSIZE = 10040,
    [Description("A protocol was specified in the socket function call that does not support the semantics of the socket type requested.")]
    WSAEPROTOTYPE = 10041,
    [Description("An unknown, invalid, or unsupported option or level was specified in a getsockopt or setsockopt call.")]
    WSAENOPROTOOPT = 10042,
    [Description("The requested protocol has not been configured into the system, or no implementation for it exists.")]
    WSAEPROTONOSUPPORT = 10043,
    [Description("The support for the specified socket type does not exist in this address family.")]
    WSAESOCKTNOSUPPORT = 10044,
    [Description("The attempted operation is not supported for the type of object referenced.")]
    WSAEOPNOTSUPP = 10045,
    [Description("The protocol family has not been configured into the system or no implementation for it exists.")]
    WSAEPFNOSUPPORT = 10046,
    [Description("An address incompatible with the requested protocol was used.")]
    WSAEAFNOSUPPORT = 10047,
    [Description("Only one usage of each socket address (protocol/network address/port) is normally permitted.")]
    WSAEADDRINUSE = 10048,
    [Description("The requested address is not valid in its context.")]
    WSAEADDRNOTAVAIL = 10049,
    [Description("A socket operation encountered a dead network.")]
    WSAENETDOWN = 10050,
    [Description("A socket operation was attempted to an unreachable network.")]
    WSAENETUNREACH = 10051,
    [Description("The connection has been broken due to keep-alive activity detecting a failure while the operation was in progress.")]
    WSAENETRESET = 10052,
    [Description("An established connection was aborted by the software in your host machine.")]
    WSAECONNABORTED = 10053,
    [Description("An existing connection was forcibly closed by the remote host.")]
    WSAECONNRESET = 10054,
    [Description("An operation on a socket could not be performed because the system lacked sufficient buffer space or because a queue was full.")]
    WSAENOBUFS = 10055,
    [Description("A connect request was made on an already connected socket.")]
    WSAEISCONN = 10056,
    [Description("A request to send or receive data was disallowed because the socket is not connected and (when sending on a datagram socket using a sendto call) no address was supplied.")]
    WSAENOTCONN = 10057,
    [Description("A request to send or receive data was disallowed because the socket had already been shut down in that direction with a previous shutdown call.")]
    WSAESHUTDOWN = 10058,
    [Description("Too many references to some kernel object.")]
    WSAETOOMANYREFS = 10059,
    [Description("A connection attempt failed because the connected party did not properly respond after a period of time, or established connection failed because connected host has failed to respond.")]
    WSAETIMEDOUT = 10060,
    [Description("No connection could be made because the target machine actively refused it.")]
    WSAECONNREFUSED = 10061,
    [Description("Cannot translate name.")]
    WSAELOOP = 10062,
    [Description("Name component or name was too long.")]
    WSAENAMETOOLONG = 10063,
    [Description("A socket operation failed because the destination host was down.")]
    WSAEHOSTDOWN = 10064,
    [Description("A socket operation was attempted to an unreachable host.")]
    WSAEHOSTUNREACH = 10065,
    [Description("Cannot remove a directory that is not empty.")]
    WSAENOTEMPTY = 10066,
    [Description("A Windows Sockets implementation may have a limit on the number of applications that may use it simultaneously.")]
    WSAEPROCLIM = 10067,
    [Description("Ran out of quota.")]
    WSAEUSERS = 10068,
    [Description("Ran out of disk quota.")]
    WSAEDQUOT = 10069,
    [Description("File handle reference is no longer available.")]
    WSAESTALE = 10070,
    [Description("Item is not available locally.")]
    WSAEREMOTE = 10071,
    [Description("WSAStartup cannot function at this time because the underlying system it uses to provide network services is currently unavailable.")]
    WSASYSNOTREADY = 10091,
    [Description("The Windows Sockets version requested is not supported.")]
    WSAVERNOTSUPPORTED = 10092,
    [Description("Either the application has not called WSAStartup, or WSAStartup failed.")]
    WSANOTINITIALISED = 10093,
    [Description("Returned by WSARecv or WSARecvFrom to indicate the remote party has initiated a graceful shutdown sequence.")]
    WSAEDISCON = 10101,
    [Description("No more results can be returned by WSALookupServiceNext.")]
    WSAENOMORE = 10102,
    [Description("A call to WSALookupServiceEnd was made while this call was still processing. The call has been canceled.")]
    WSAECANCELLED = 10103,
    [Description("The procedure call table is invalid.")]
    WSAEINVALIDPROCTABLE = 10104,
    [Description("The requested service provider is invalid.")]
    WSAEINVALIDPROVIDER = 10105,
    [Description("The requested service provider could not be loaded or initialized.")]
    WSAEPROVIDERFAILEDINIT = 10106,
    [Description("A system call has failed.")]
    WSASYSCALLFAILURE = 10107,
    [Description("No such service is known. The service cannot be found in the specified name space.")]
    WSASERVICE_NOT_FOUND = 10108,
    [Description("The specified class was not found.")]
    WSATYPE_NOT_FOUND = 10109,
    [Description("No more results can be returned by WSALookupServiceNext.")]
    WSA_E_NO_MORE = 10110,
    [Description("A call to WSALookupServiceEnd was made while this call was still processing. The call has been canceled.")]
    WSA_E_CANCELLED = 10111,
    [Description("A database query failed because it was actively refused.")]
    WSAEREFUSED = 10112,
    [Description("No such host is known.")]
    WSAHOST_NOT_FOUND = 11001,
    [Description("This is usually a temporary error during hostname resolution and means that the local server did not receive a response from an authoritative server.")]
    WSATRY_AGAIN = 11002,
    [Description("A non-recoverable error occurred during a database lookup.")]
    WSANO_RECOVERY = 11003,
    [Description("The requested name is valid, but no data of the requested type was found.")]
    WSANO_DATA = 11004,
    [Description("At least one reserve has arrived.")]
    WSA_QOS_RECEIVERS = 11005,
    [Description("At least one path has arrived.")]
    WSA_QOS_SENDERS = 11006,
    [Description("There are no senders.")]
    WSA_QOS_NO_SENDERS = 11007,
    [Description("There are no receivers.")]
    WSA_QOS_NO_RECEIVERS = 11008,
    [Description("Reserve has been confirmed.")]
    WSA_QOS_REQUEST_CONFIRMED = 11009,
    [Description("Error due to lack of resources.")]
    WSA_QOS_ADMISSION_FAILURE = 11010,
    [Description("Rejected for administrative reasons - bad credentials.")]
    WSA_QOS_POLICY_FAILURE = 11011,
    [Description("Unknown or conflicting style.")]
    WSA_QOS_BAD_STYLE = 11012,
    [Description("Problem with some part of the filterspec or providerspecific buffer in general.")]
    WSA_QOS_BAD_OBJECT = 11013,
    [Description("Problem with some part of the flowspec.")]
    WSA_QOS_TRAFFIC_CTRL_ERROR = 11014,
    [Description("General QOS error.")]
    WSA_QOS_GENERIC_ERROR = 11015,
    [Description("An invalid or unrecognized service type was found in the flowspec.")]
    WSA_QOS_ESERVICETYPE = 11016,
    [Description("An invalid or inconsistent flowspec was found in the QOS structure.")]
    WSA_QOS_EFLOWSPEC = 11017,
    [Description("Invalid QOS provider-specific buffer.")]
    WSA_QOS_EPROVSPECBUF = 11018,
    [Description("An invalid QOS filter style was used.")]
    WSA_QOS_EFILTERSTYLE = 11019,
    [Description("An invalid QOS filter type was used.")]
    WSA_QOS_EFILTERTYPE = 11020,
    [Description("An incorrect number of QOS FILTERSPECs were specified in the FLOWDESCRIPTOR.")]
    WSA_QOS_EFILTERCOUNT = 11021,
    [Description("An object with an invalid ObjectLength field was specified in the QOS provider-specific buffer.")]
    WSA_QOS_EOBJLENGTH = 11022,
    [Description("An incorrect number of flow descriptors was specified in the QOS structure.")]
    WSA_QOS_EFLOWCOUNT = 11023,
    [Description("An unrecognized object was found in the QOS provider-specific buffer.")]
    WSA_QOS_EUNKOWNPSOBJ = 11024,
    [Description("An invalid policy object was found in the QOS provider-specific buffer.")]
    WSA_QOS_EPOLICYOBJ = 11025,
    [Description("An invalid QOS flow descriptor was found in the flow descriptor list.")]
    WSA_QOS_EFLOWDESC = 11026,
    [Description("An invalid or inconsistent flowspec was found in the QOS provider specific buffer.")]
    WSA_QOS_EPSFLOWSPEC = 11027,
    [Description("An invalid FILTERSPEC was found in the QOS provider-specific buffer.")]
    WSA_QOS_EPSFILTERSPEC = 11028,
    [Description("An invalid shape discard mode object was found in the QOS provider specific buffer.")]
    WSA_QOS_ESDMODEOBJ = 11029,
    [Description("An invalid shaping rate object was found in the QOS provider-specific buffer.")]
    WSA_QOS_ESHAPERATEOBJ = 11030,
    [Description("A reserved policy element was found in the QOS provider-specific buffer.")]
    WSA_QOS_RESERVED_PETYPE = 11031,
    [Description("No such host is known securely.")]
    WSA_SECURE_HOST_NOT_FOUND = 11032,
    [Description("Name based IPSEC policy could not be added.")]
    WSA_IPSEC_NAME_POLICY_ERROR = 11033,
    [Description("The FTP operation was not completed because the session was aborted.")]
    ERROR_FTP_DROPPED = 12111,
    [Description("Passive mode is not available on the server.")]
    ERROR_FTP_NO_PASSIVE_MODE = 12112,
    [Description("The requested operation cannot be made on the FTP session handle because an operation is already in progress.")]
    ERROR_FTP_TRANSFER_IN_PROGRESS = 12110,
    [Description("The requested attribute could not be located.\nNote  Windows XP and Windows Server 2003 R2 and earlier only.")]
    ERROR_GOPHER_ATTRIBUTE_NOT_FOUND = 12137,
    [Description("An error was detected while receiving data from the Gopher server.\nNote  Windows XP and Windows Server 2003 R2 and earlier only.")]
    ERROR_GOPHER_DATA_ERROR = 12132,
    [Description("The end of the data has been reached.\nNote  Windows XP and Windows Server 2003 R2 and earlier only.")]
    ERROR_GOPHER_END_OF_DATA = 12133,
    [Description("The type of the locator is not correct for this operation.\nNote  Windows XP and Windows Server 2003 R2 and earlier only.")]
    ERROR_GOPHER_INCORRECT_LOCATOR_TYPE = 12135,
    [Description("The supplied locator is not valid.\nNote  Windows XP and Windows Server 2003 R2 and earlier only.")]
    ERROR_GOPHER_INVALID_LOCATOR = 12134,
    [Description("The request must be made for a file locator.\nNote  Windows XP and Windows Server 2003 R2 and earlier only.")]
    ERROR_GOPHER_NOT_FILE = 12131,
    [Description("The requested operation can be made only against a Gopher+ server, or with a locator that specifies a Gopher+ operation.\nNote  Windows XP and Windows Server 2003 R2 and earlier only.")]
    ERROR_GOPHER_NOT_GOPHER_PLUS = 12136,
    [Description("An error was detected while parsing data returned from the Gopher server.\nNote  Windows XP and Windows Server 2003 R2 and earlier only.")]
    ERROR_GOPHER_PROTOCOL_ERROR = 12130,
    [Description("The locator type is unknown.\nNote  Windows XP and Windows Server 2003 R2 and earlier only.")]
    ERROR_GOPHER_UNKNOWN_LOCATOR = 12138,
    [Description("The HTTP cookie was declined by the server.")]
    ERROR_HTTP_COOKIE_DECLINED = 12162,
    [Description("The HTTP cookie requires confirmation.\nNote  Windows Vista and Windows Server 2008 and earlier only.")]
    ERROR_HTTP_COOKIE_NEEDS_CONFIRMATION = 12161,
    [Description("The server did not return any headers.")]
    ERROR_HTTP_DOWNLEVEL_SERVER = 12151,
    [Description("The header could not be added because it already exists.")]
    ERROR_HTTP_HEADER_ALREADY_EXISTS = 12155,
    [Description("The requested header could not be located.")]
    ERROR_HTTP_HEADER_NOT_FOUND = 12150,
    [Description("The supplied header is invalid.")]
    ERROR_HTTP_INVALID_HEADER = 12153,
    [Description("The request made to \nHttpQueryInfo is invalid.")]
    ERROR_HTTP_INVALID_QUERY_REQUEST = 12154,
    [Description("The server response could not be parsed.")]
    ERROR_HTTP_INVALID_SERVER_RESPONSE = 12152,
    [Description("The HTTP request was not redirected.")]
    ERROR_HTTP_NOT_REDIRECTED = 12160,
    [Description("The redirection failed because either the scheme changed (for example, HTTP to FTP) or all attempts made to redirect failed (default is five attempts).")]
    ERROR_HTTP_REDIRECT_FAILED = 12156,
    [Description("The redirection requires user confirmation.")]
    ERROR_HTTP_REDIRECT_NEEDS_CONFIRMATION = 12168,
    [Description("The application could not start an asynchronous thread.")]
    ERROR_INTERNET_ASYNC_THREAD_FAILED = 12047,
    [Description("There was an error in the automatic proxy configuration script.")]
    ERROR_INTERNET_BAD_AUTO_PROXY_SCRIPT = 12166,
    [Description("The length of an option supplied to \nInternetQueryOption or \nInternetSetOption is incorrect for the type of option specified.")]
    ERROR_INTERNET_BAD_OPTION_LENGTH = 12010,
    [Description("A required registry value was located but is an incorrect type or has an invalid value.")]
    ERROR_INTERNET_BAD_REGISTRY_PARAMETER = 12022,
    [Description("The attempt to connect to the server failed.")]
    ERROR_INTERNET_CANNOT_CONNECT = 12029,
    [Description("The application is posting and attempting to change multiple lines of text on a server that is not secure.")]
    ERROR_INTERNET_CHG_POST_IS_NON_SECURE = 12042,
    [Description("The server is requesting client authentication.")]
    ERROR_INTERNET_CLIENT_AUTH_CERT_NEEDED = 12044,
    [Description("Client authorization is not set up on this computer.")]
    ERROR_INTERNET_CLIENT_AUTH_NOT_SETUP = 12046,
    [Description("The connection with the server has been terminated.")]
    ERROR_INTERNET_CONNECTION_ABORTED = 12030,
    [Description("The connection with the server has been reset.")]
    ERROR_INTERNET_CONNECTION_RESET = 12031,
    [Description("WinINet failed to perform content decoding on the response. For more information, see the Content Encoding topic.")]
    ERROR_INTERNET_DECODING_FAILED = 12175,
    [Description("Another thread has a password dialog box in progress.")]
    ERROR_INTERNET_DIALOG_PENDING = 12049,
    [Description("The Internet connection has been lost.")]
    ERROR_INTERNET_DISCONNECTED = 12163,
    [Description("An extended error was returned from the server. This is typically a string or buffer containing a verbose error message. Call \nInternetGetLastResponseInfo to retrieve the error text.")]
    ERROR_INTERNET_EXTENDED_ERROR = 12003,
    [Description("The function failed due to a security check.")]
    ERROR_INTERNET_FAILED_DUETOSECURITYCHECK = 12171,
    [Description("The function needs to redo the request.")]
    ERROR_INTERNET_FORCE_RETRY = 12032,
    [Description("The requested resource requires Fortezza authentication.")]
    ERROR_INTERNET_FORTEZZA_LOGIN_NEEDED = 12054,
    [Description("The request failed because the handle already exists.")]
    ERROR_INTERNET_HANDLE_EXISTS = 12036,
    [Description("The application is moving from a non-SSL to an SSL connection because of a redirect.")]
    ERROR_INTERNET_HTTP_TO_HTTPS_ON_REDIR = 12039,
    [Description("The data being submitted to an SSL connection is being redirected to a non-SSL connection.")]
    ERROR_INTERNET_HTTPS_HTTP_SUBMIT_REDIR = 12052,
    [Description("The application is moving from an SSL to an non-SSL connection because of a redirect.")]
    ERROR_INTERNET_HTTPS_TO_HTTP_ON_REDIR = 12040,
    [Description("The format of the request is invalid.")]
    ERROR_INTERNET_INCORRECT_FORMAT = 12027,
    [Description("The requested operation cannot be carried out because the handle supplied is not in the correct state.")]
    ERROR_INTERNET_INCORRECT_HANDLE_STATE = 12019,
    [Description("The type of handle supplied is incorrect for this operation.")]
    ERROR_INTERNET_INCORRECT_HANDLE_TYPE = 12018,
    [Description("The request to connect and log on to an FTP server could not be completed because the supplied password is incorrect.")]
    ERROR_INTERNET_INCORRECT_PASSWORD = 12014,
    [Description("The request to connect and log on to an FTP server could not be completed because the supplied user name is incorrect.")]
    ERROR_INTERNET_INCORRECT_USER_NAME = 12013,
    [Description("The request requires a CD-ROM to be inserted in the CD-ROM drive to locate the resource requested.Note  Windows Vista and Windows Server 2008 and earlier only.")]
    ERROR_INTERNET_INSERT_CDROM = 12053,
    [Description("An internal error has occurred.")]
    ERROR_INTERNET_INTERNAL_ERROR = 12004,
    [Description("The function is unfamiliar with the Certificate Authority that generated the server's certificate.")]
    ERROR_INTERNET_INVALID_CA = 12045,
    [Description("The requested operation is invalid.")]
    ERROR_INTERNET_INVALID_OPERATION = 12016,
    [Description("A request to \nInternetQueryOption or \nInternetSetOption specified an invalid option value.")]
    ERROR_INTERNET_INVALID_OPTION = 12009,
    [Description("The request to the proxy was invalid.")]
    ERROR_INTERNET_INVALID_PROXY_REQUEST = 12033,
    [Description("The URL is invalid.")]
    ERROR_INTERNET_INVALID_URL = 12005,
    [Description("The requested item could not be located.")]
    ERROR_INTERNET_ITEM_NOT_FOUND = 12028,
    [Description("The request to connect and log on to an FTP server failed.")]
    ERROR_INTERNET_LOGIN_FAILURE = 12015,
    [Description("The MS-Logoff digest header has been returned from the website. This header specifically instructs the digest package to purge credentials for the associated realm. This error will only be returned if \nINTERNET_ERROR_MASK_LOGIN_FAILURE_DISPLAY_ENTITY_BODY option has been set; otherwise, ERROR_INTERNET_LOGIN_FAILURE is returned.")]
    ERROR_INTERNET_LOGIN_FAILURE_DISPLAY_ENTITY_BODY = 12174,
    [Description("The content is not entirely secure. Some of the content being viewed may have come from unsecured servers.")]
    ERROR_INTERNET_MIXED_SECURITY = 12041,
    [Description("The server name could not be resolved.")]
    ERROR_INTERNET_NAME_NOT_RESOLVED = 12007,
    [Description("Not currently implemented.")]
    ERROR_INTERNET_NEED_MSN_SSPI_PKG = 12173,
    [Description("A user interface or other blocking operation has been requested.Note  Windows Vista and Windows Server 2008 and earlier only.")]
    ERROR_INTERNET_NEED_UI = 12034,
    [Description("An asynchronous request could not be made because a callback function has not been set.")]
    ERROR_INTERNET_NO_CALLBACK = 12025,
    [Description("An asynchronous request could not be made because a zero context value was supplied.")]
    ERROR_INTERNET_NO_CONTEXT = 12024,
    [Description("Direct network access cannot be made at this time.")]
    ERROR_INTERNET_NO_DIRECT_ACCESS = 12023,
    [Description("Initialization of the WinINet API has not occurred. Indicates that a higher-level function, such as \nInternetOpen, has not been called yet.")]
    ERROR_INTERNET_NOT_INITIALIZED = 12172,
    [Description("The request cannot be made via a proxy.")]
    ERROR_INTERNET_NOT_PROXY_REQUEST = 12020,
    [Description("The operation was canceled, usually because the handle on which the request was operating was closed before the operation completed.")]
    ERROR_INTERNET_OPERATION_CANCELLED = 12017,
    [Description("The requested option cannot be set, only queried.")]
    ERROR_INTERNET_OPTION_NOT_SETTABLE = 12011,
    [Description("No more handles could be generated at this time.")]
    ERROR_INTERNET_OUT_OF_HANDLES = 12001,
    [Description("The application is posting data to a server that is not secure.")]
    ERROR_INTERNET_POST_IS_NON_SECURE = 12043,
    [Description("The requested protocol could not be located.")]
    ERROR_INTERNET_PROTOCOL_NOT_FOUND = 12008,
    [Description("The designated proxy server cannot be reached.")]
    ERROR_INTERNET_PROXY_SERVER_UNREACHABLE = 12165,
    [Description("The function could not handle the redirection, because the scheme changed (for example, HTTP to FTP).")]
    ERROR_INTERNET_REDIRECT_SCHEME_CHANGE = 12048,
    [Description("A required registry value could not be located.")]
    ERROR_INTERNET_REGISTRY_VALUE_NOT_FOUND = 12021,
    [Description("The required operation could not be completed because one or more requests are pending.")]
    ERROR_INTERNET_REQUEST_PENDING = 12026,
    [Description("The dialog box should be retried.")]
    ERROR_INTERNET_RETRY_DIALOG = 12050,
    [Description("SSL certificate common name (host name field) is incorrect—for example, if you entered www.server.com and the common name on the certificate says www.different.com.")]
    ERROR_INTERNET_SEC_CERT_CN_INVALID = 12038,
    [Description("SSL certificate date that was received from the server is bad. The certificate is expired.")]
    ERROR_INTERNET_SEC_CERT_DATE_INVALID = 12037,
    [Description("The SSL certificate contains errors.")]
    ERROR_INTERNET_SEC_CERT_ERRORS = 12055,
    [Description("The SSL certificate was not revoked.")]
    ERROR_INTERNET_SEC_CERT_NO_REV = 12056,
    [Description("Revocation of the SSL certificate failed.")]
    ERROR_INTERNET_SEC_CERT_REV_FAILED = 12057,
    [Description("The SSL certificate was revoked.")]
    ERROR_INTERNET_SEC_CERT_REVOKED = 12170,
    [Description("The SSL certificate is invalid.")]
    ERROR_INTERNET_SEC_INVALID_CERT = 12169,
    [Description("The application experienced an internal error loading the SSL libraries.")]
    ERROR_INTERNET_SECURITY_CHANNEL_ERROR = 12157,
    [Description("The website or server indicated is unreachable.")]
    ERROR_INTERNET_SERVER_UNREACHABLE = 12164,
    [Description("WinINet support is being shut down or unloaded.")]
    ERROR_INTERNET_SHUTDOWN = 12012,
    [Description("The required protocol stack is not loaded and the application cannot start WinSock.")]
    ERROR_INTERNET_TCPIP_NOT_INSTALLED = 12159,
    [Description("The request has timed out.")]
    ERROR_INTERNET_TIMEOUT = 12002,
    [Description("The function was unable to cache the file.")]
    ERROR_INTERNET_UNABLE_TO_CACHE_FILE = 12158,
    [Description("The automatic proxy configuration script could not be downloaded. The INTERNET_FLAG_MUST_CACHE_REQUEST flag was set.")]
    ERROR_INTERNET_UNABLE_TO_DOWNLOAD_SCRIPT = 12167,
    [Description("The URL scheme could not be recognized, or is not supported.")]
    ERROR_INTERNET_UNRECOGNIZED_SCHEME = 12006,
    [Description("The specified quick mode policy already exists.")]
    ERROR_IPSEC_QM_POLICY_EXISTS = 13000,
    [Description("The specified quick mode policy was not found.")]
    ERROR_IPSEC_QM_POLICY_NOT_FOUND = 13001,
    [Description("The specified quick mode policy is being used.")]
    ERROR_IPSEC_QM_POLICY_IN_USE = 13002,
    [Description("The specified main mode policy already exists.")]
    ERROR_IPSEC_MM_POLICY_EXISTS = 13003,
    [Description("The specified main mode policy was not found.")]
    ERROR_IPSEC_MM_POLICY_NOT_FOUND = 13004,
    [Description("The specified main mode policy is being used.")]
    ERROR_IPSEC_MM_POLICY_IN_USE = 13005,
    [Description("The specified main mode filter already exists.")]
    ERROR_IPSEC_MM_FILTER_EXISTS = 13006,
    [Description("The specified main mode filter was not found.")]
    ERROR_IPSEC_MM_FILTER_NOT_FOUND = 13007,
    [Description("The specified transport mode filter already exists.")]
    ERROR_IPSEC_TRANSPORT_FILTER_EXISTS = 13008,
    [Description("The specified transport mode filter does not exist.")]
    ERROR_IPSEC_TRANSPORT_FILTER_NOT_FOUND = 13009,
    [Description("The specified main mode authentication list exists.")]
    ERROR_IPSEC_MM_AUTH_EXISTS = 13010,
    [Description("The specified main mode authentication list was not found.")]
    ERROR_IPSEC_MM_AUTH_NOT_FOUND = 13011,
    [Description("The specified main mode authentication list is being used.")]
    ERROR_IPSEC_MM_AUTH_IN_USE = 13012,
    [Description("The specified default main mode policy was not found.")]
    ERROR_IPSEC_DEFAULT_MM_POLICY_NOT_FOUND = 13013,
    [Description("The specified default main mode authentication list was not found.")]
    ERROR_IPSEC_DEFAULT_MM_AUTH_NOT_FOUND = 13014,
    [Description("The specified default quick mode policy was not found.")]
    ERROR_IPSEC_DEFAULT_QM_POLICY_NOT_FOUND = 13015,
    [Description("The specified tunnel mode filter exists.")]
    ERROR_IPSEC_TUNNEL_FILTER_EXISTS = 13016,
    [Description("The specified tunnel mode filter was not found.")]
    ERROR_IPSEC_TUNNEL_FILTER_NOT_FOUND = 13017,
    [Description("The Main Mode filter is pending deletion.")]
    ERROR_IPSEC_MM_FILTER_PENDING_DELETION = 13018,
    [Description("The transport filter is pending deletion.")]
    ERROR_IPSEC_TRANSPORT_FILTER_PENDING_DELETION = 13019,
    [Description("The tunnel filter is pending deletion.")]
    ERROR_IPSEC_TUNNEL_FILTER_PENDING_DELETION = 13020,
    [Description("The Main Mode policy is pending deletion.")]
    ERROR_IPSEC_MM_POLICY_PENDING_DELETION = 13021,
    [Description("The Main Mode authentication bundle is pending deletion.")]
    ERROR_IPSEC_MM_AUTH_PENDING_DELETION = 13022,
    [Description("The Quick Mode policy is pending deletion.")]
    ERROR_IPSEC_QM_POLICY_PENDING_DELETION = 13023,
    [Description("The Main Mode policy was successfully added, but some of the requested offers are not supported.")]
    WARNING_IPSEC_MM_POLICY_PRUNED = 13024,
    [Description("The Quick Mode policy was successfully added, but some of the requested offers are not supported.")]
    WARNING_IPSEC_QM_POLICY_PRUNED = 13025,
    [Description("ERROR_IPSEC_IKE_NEG_STATUS_BEGIN")]
    ERROR_IPSEC_IKE_NEG_STATUS_BEGIN = 13800,
    [Description("IKE authentication credentials are unacceptable.")]
    ERROR_IPSEC_IKE_AUTH_FAIL = 13801,
    [Description("IKE security attributes are unacceptable.")]
    ERROR_IPSEC_IKE_ATTRIB_FAIL = 13802,
    [Description("IKE Negotiation in progress.")]
    ERROR_IPSEC_IKE_NEGOTIATION_PENDING = 13803,
    [Description("General processing error.")]
    ERROR_IPSEC_IKE_GENERAL_PROCESSING_ERROR = 13804,
    [Description("Negotiation timed out.")]
    ERROR_IPSEC_IKE_TIMED_OUT = 13805,
    [Description("IKE failed to find valid machine certificate. Contact your Network Security Administrator about installing a valid certificate in the appropriate Certificate Store.")]
    ERROR_IPSEC_IKE_NO_CERT = 13806,
    [Description("IKE SA deleted by peer before establishment completed.")]
    ERROR_IPSEC_IKE_SA_DELETED = 13807,
    [Description("IKE SA deleted before establishment completed.")]
    ERROR_IPSEC_IKE_SA_REAPED = 13808,
    [Description("Negotiation request sat in Queue too long.")]
    ERROR_IPSEC_IKE_MM_ACQUIRE_DROP = 13809,
    [Description("Negotiation request sat in Queue too long.")]
    ERROR_IPSEC_IKE_QM_ACQUIRE_DROP = 13810,
    [Description("Negotiation request sat in Queue too long.")]
    ERROR_IPSEC_IKE_QUEUE_DROP_MM = 13811,
    [Description("Negotiation request sat in Queue too long.")]
    ERROR_IPSEC_IKE_QUEUE_DROP_NO_MM = 13812,
    [Description("No response from peer.")]
    ERROR_IPSEC_IKE_DROP_NO_RESPONSE = 13813,
    [Description("Negotiation took too long.")]
    ERROR_IPSEC_IKE_MM_DELAY_DROP = 13814,
    [Description("Negotiation took too long.")]
    ERROR_IPSEC_IKE_QM_DELAY_DROP = 13815,
    [Description("Unknown error occurred.")]
    ERROR_IPSEC_IKE_ERROR = 13816,
    [Description("Certificate Revocation Check failed.")]
    ERROR_IPSEC_IKE_CRL_FAILED = 13817,
    [Description("Invalid certificate key usage.")]
    ERROR_IPSEC_IKE_INVALID_KEY_USAGE = 13818,
    [Description("Invalid certificate type.")]
    ERROR_IPSEC_IKE_INVALID_CERT_TYPE = 13819,
    [Description("IKE negotiation failed because the machine certificate used does not have a private key. IPsec certificates require a private key. Contact your Network Security administrator about replacing with a certificate that has a private key.")]
    ERROR_IPSEC_IKE_NO_PRIVATE_KEY = 13820,
    [Description("Simultaneous rekeys were detected.")]
    ERROR_IPSEC_IKE_SIMULTANEOUS_REKEY = 13821,
    [Description("Failure in Diffie-Hellman computation.")]
    ERROR_IPSEC_IKE_DH_FAIL = 13822,
    [Description("Don't know how to process critical payload.")]
    ERROR_IPSEC_IKE_CRITICAL_PAYLOAD_NOT_RECOGNIZED = 13823,
    [Description("Invalid header.")]
    ERROR_IPSEC_IKE_INVALID_HEADER = 13824,
    [Description("No policy configured.")]
    ERROR_IPSEC_IKE_NO_POLICY = 13825,
    [Description("Failed to verify signature.")]
    ERROR_IPSEC_IKE_INVALID_SIGNATURE = 13826,
    [Description("Failed to authenticate using Kerberos.")]
    ERROR_IPSEC_IKE_KERBEROS_ERROR = 13827,
    [Description("Peer's certificate did not have a public key.")]
    ERROR_IPSEC_IKE_NO_PUBLIC_KEY = 13828,
    [Description("Error processing error payload.")]
    ERROR_IPSEC_IKE_PROCESS_ERR = 13829,
    [Description("Error processing SA payload.")]
    ERROR_IPSEC_IKE_PROCESS_ERR_SA = 13830,
    [Description("Error processing Proposal payload.")]
    ERROR_IPSEC_IKE_PROCESS_ERR_PROP = 13831,
    [Description("Error processing Transform payload.")]
    ERROR_IPSEC_IKE_PROCESS_ERR_TRANS = 13832,
    [Description("Error processing KE payload.")]
    ERROR_IPSEC_IKE_PROCESS_ERR_KE = 13833,
    [Description("Error processing ID payload.")]
    ERROR_IPSEC_IKE_PROCESS_ERR_ID = 13834,
    [Description("Error processing Cert payload.")]
    ERROR_IPSEC_IKE_PROCESS_ERR_CERT = 13835,
    [Description("Error processing Certificate Request payload.")]
    ERROR_IPSEC_IKE_PROCESS_ERR_CERT_REQ = 13836,
    [Description("Error processing Hash payload.")]
    ERROR_IPSEC_IKE_PROCESS_ERR_HASH = 13837,
    [Description("Error processing Signature payload.")]
    ERROR_IPSEC_IKE_PROCESS_ERR_SIG = 13838,
    [Description("Error processing Nonce payload.")]
    ERROR_IPSEC_IKE_PROCESS_ERR_NONCE = 13839,
    [Description("Error processing Notify payload.")]
    ERROR_IPSEC_IKE_PROCESS_ERR_NOTIFY = 13840,
    [Description("Error processing Delete Payload.")]
    ERROR_IPSEC_IKE_PROCESS_ERR_DELETE = 13841,
    [Description("Error processing VendorId payload.")]
    ERROR_IPSEC_IKE_PROCESS_ERR_VENDOR = 13842,
    [Description("Invalid payload received.")]
    ERROR_IPSEC_IKE_INVALID_PAYLOAD = 13843,
    [Description("Soft SA loaded.")]
    ERROR_IPSEC_IKE_LOAD_SOFT_SA = 13844,
    [Description("Soft SA torn down.")]
    ERROR_IPSEC_IKE_SOFT_SA_TORN_DOWN = 13845,
    [Description("Invalid cookie received.")]
    ERROR_IPSEC_IKE_INVALID_COOKIE = 13846,
    [Description("Peer failed to send valid machine certificate.")]
    ERROR_IPSEC_IKE_NO_PEER_CERT = 13847,
    [Description("Certification Revocation check of peer's certificate failed.")]
    ERROR_IPSEC_IKE_PEER_CRL_FAILED = 13848,
    [Description("New policy invalidated SAs formed with old policy.")]
    ERROR_IPSEC_IKE_POLICY_CHANGE = 13849,
    [Description("There is no available Main Mode IKE policy.")]
    ERROR_IPSEC_IKE_NO_MM_POLICY = 13850,
    [Description("Failed to enabled TCB privilege.")]
    ERROR_IPSEC_IKE_NOTCBPRIV = 13851,
    [Description("Failed to load SECURITY.DLL.")]
    ERROR_IPSEC_IKE_SECLOADFAIL = 13852,
    [Description("Failed to obtain security function table dispatch address from SSPI.")]
    ERROR_IPSEC_IKE_FAILSSPINIT = 13853,
    [Description("Failed to query Kerberos package to obtain max token size.")]
    ERROR_IPSEC_IKE_FAILQUERYSSP = 13854,
    [Description("Failed to obtain Kerberos server credentials for ISAKMP/ERROR_IPSEC_IKE service. Kerberos authentication will not function. The most likely reason for this is lack of domain membership. This is normal if your computer is a member of a workgroup.")]
    ERROR_IPSEC_IKE_SRVACQFAIL = 13855,
    [Description("Failed to determine SSPI principal name for ISAKMP/ERROR_IPSEC_IKE service (QueryCredentialsAttributes).")]
    ERROR_IPSEC_IKE_SRVQUERYCRED = 13856,
    [Description("Failed to obtain new SPI for the inbound SA from IPsec driver. The most common cause for this is that the driver does not have the correct filter. Check your policy to verify the filters.")]
    ERROR_IPSEC_IKE_GETSPIFAIL = 13857,
    [Description("Given filter is invalid.")]
    ERROR_IPSEC_IKE_INVALID_FILTER = 13858,
    [Description("Memory allocation failed.")]
    ERROR_IPSEC_IKE_OUT_OF_MEMORY = 13859,
    [Description("Failed to add Security Association to IPsec Driver. The most common cause for this is if the IKE negotiation took too long to complete. If the problem persists, reduce the load on the faulting machine.")]
    ERROR_IPSEC_IKE_ADD_UPDATE_KEY_FAILED = 13860,
    [Description("Invalid policy.")]
    ERROR_IPSEC_IKE_INVALID_POLICY = 13861,
    [Description("Invalid DOI.")]
    ERROR_IPSEC_IKE_UNKNOWN_DOI = 13862,
    [Description("Invalid situation.")]
    ERROR_IPSEC_IKE_INVALID_SITUATION = 13863,
    [Description("Diffie-Hellman failure.")]
    ERROR_IPSEC_IKE_DH_FAILURE = 13864,
    [Description("Invalid Diffie-Hellman group.")]
    ERROR_IPSEC_IKE_INVALID_GROUP = 13865,
    [Description("Error encrypting payload.")]
    ERROR_IPSEC_IKE_ENCRYPT = 13866,
    [Description("Error decrypting payload.")]
    ERROR_IPSEC_IKE_DECRYPT = 13867,
    [Description("Policy match error.")]
    ERROR_IPSEC_IKE_POLICY_MATCH = 13868,
    [Description("Unsupported ID.")]
    ERROR_IPSEC_IKE_UNSUPPORTED_ID = 13869,
    [Description("Hash verification failed.")]
    ERROR_IPSEC_IKE_INVALID_HASH = 13870,
    [Description("Invalid hash algorithm.")]
    ERROR_IPSEC_IKE_INVALID_HASH_ALG = 13871,
    [Description("Invalid hash size.")]
    ERROR_IPSEC_IKE_INVALID_HASH_SIZE = 13872,
    [Description("Invalid encryption algorithm.")]
    ERROR_IPSEC_IKE_INVALID_ENCRYPT_ALG = 13873,
    [Description("Invalid authentication algorithm.")]
    ERROR_IPSEC_IKE_INVALID_AUTH_ALG = 13874,
    [Description("Invalid certificate signature.")]
    ERROR_IPSEC_IKE_INVALID_SIG = 13875,
    [Description("Load failed.")]
    ERROR_IPSEC_IKE_LOAD_FAILED = 13876,
    [Description("Deleted via RPC call.")]
    ERROR_IPSEC_IKE_RPC_DELETE = 13877,
    [Description("Temporary state created to perform reinitialization. This is not a real failure.")]
    ERROR_IPSEC_IKE_BENIGN_REINIT = 13878,
    [Description("The lifetime value received in the Responder Lifetime Notify is below the Windows 2000 configured minimum value. Please fix the policy on the peer machine.")]
    ERROR_IPSEC_IKE_INVALID_RESPONDER_LIFETIME_NOTIFY = 13879,
    [Description("The recipient cannot handle version of IKE specified in the header.")]
    ERROR_IPSEC_IKE_INVALID_MAJOR_VERSION = 13880,
    [Description("Key length in certificate is too small for configured security requirements.")]
    ERROR_IPSEC_IKE_INVALID_CERT_KEYLEN = 13881,
    [Description("Max number of established MM SAs to peer exceeded.")]
    ERROR_IPSEC_IKE_MM_LIMIT = 13882,
    [Description("IKE received a policy that disables negotiation.")]
    ERROR_IPSEC_IKE_NEGOTIATION_DISABLED = 13883,
    [Description("Reached maximum quick mode limit for the main mode. New main mode will be started.")]
    ERROR_IPSEC_IKE_QM_LIMIT = 13884,
    [Description("Main mode SA lifetime expired or peer sent a main mode delete.")]
    ERROR_IPSEC_IKE_MM_EXPIRED = 13885,
    [Description("Main mode SA assumed to be invalid because peer stopped responding.")]
    ERROR_IPSEC_IKE_PEER_MM_ASSUMED_INVALID = 13886,
    [Description("Certificate doesn't chain to a trusted root in IPsec policy.")]
    ERROR_IPSEC_IKE_CERT_CHAIN_POLICY_MISMATCH = 13887,
    [Description("Received unexpected message ID.")]
    ERROR_IPSEC_IKE_UNEXPECTED_MESSAGE_ID = 13888,
    [Description("Received invalid authentication offers.")]
    ERROR_IPSEC_IKE_INVALID_AUTH_PAYLOAD = 13889,
    [Description("Sent DoS cookie notify to initiator.")]
    ERROR_IPSEC_IKE_DOS_COOKIE_SENT = 13890,
    [Description("IKE service is shutting down.")]
    ERROR_IPSEC_IKE_SHUTTING_DOWN = 13891,
    [Description("Could not verify binding between CGA address and certificate.")]
    ERROR_IPSEC_IKE_CGA_AUTH_FAILED = 13892,
    [Description("Error processing NatOA payload.")]
    ERROR_IPSEC_IKE_PROCESS_ERR_NATOA = 13893,
    [Description("Parameters of the main mode are invalid for this quick mode.")]
    ERROR_IPSEC_IKE_INVALID_MM_FOR_QM = 13894,
    [Description("Quick mode SA was expired by IPsec driver.")]
    ERROR_IPSEC_IKE_QM_EXPIRED = 13895,
    [Description("Too many dynamically added IKEEXT filters were detected.")]
    ERROR_IPSEC_IKE_TOO_MANY_FILTERS = 13896,
    [Description("ERROR_IPSEC_IKE_NEG_STATUS_END")]
    ERROR_IPSEC_IKE_NEG_STATUS_END = 13897,
    [Description("NAP reauth succeeded and must delete the dummy NAP IKEv2 tunnel.")]
    ERROR_IPSEC_IKE_KILL_DUMMY_NAP_TUNNEL = 13898,
    [Description("Error in assigning inner IP address to initiator in tunnel mode.")]
    ERROR_IPSEC_IKE_INNER_IP_ASSIGNMENT_FAILURE = 13899,
    [Description("Require configuration payload missing.")]
    ERROR_IPSEC_IKE_REQUIRE_CP_PAYLOAD_MISSING = 13900,
    [Description("A negotiation running as the security principle who issued the connection is in progress.")]
    ERROR_IPSEC_KEY_MODULE_IMPERSONATION_NEGOTIATION_PENDING = 13901,
    [Description("SA was deleted due to IKEv1/AuthIP co-existence suppress check.")]
    ERROR_IPSEC_IKE_COEXISTENCE_SUPPRESS = 13902,
    [Description("Incoming SA request was dropped due to peer IP address rate limiting.")]
    ERROR_IPSEC_IKE_RATELIMIT_DROP = 13903,
    [Description("Peer does not support MOBIKE.")]
    ERROR_IPSEC_IKE_PEER_DOESNT_SUPPORT_MOBIKE = 13904,
    [Description("SA establishment is not authorized.")]
    ERROR_IPSEC_IKE_AUTHORIZATION_FAILURE = 13905,
    [Description("SA establishment is not authorized because there is not a sufficiently strong PKINIT-based credential.")]
    ERROR_IPSEC_IKE_STRONG_CRED_AUTHORIZATION_FAILURE = 13906,
    [Description("SA establishment is not authorized.  You may need to enter updated or different credentials such as a smartcard.")]
    ERROR_IPSEC_IKE_AUTHORIZATION_FAILURE_WITH_OPTIONAL_RETRY = 13907,
    [Description("SA establishment is not authorized because there is not a sufficiently strong PKINIT-based credential. This might be related to certificate-to-account mapping failure for the SA.")]
    ERROR_IPSEC_IKE_STRONG_CRED_AUTHORIZATION_AND_CERTMAP_FAILURE = 13908,
    [Description("ERROR_IPSEC_IKE_NEG_STATUS_EXTENDED_END")]
    ERROR_IPSEC_IKE_NEG_STATUS_EXTENDED_END = 13909,
    [Description("The SPI in the packet does not match a valid IPsec SA.")]
    ERROR_IPSEC_BAD_SPI = 13910,
    [Description("Packet was received on an IPsec SA whose lifetime has expired.")]
    ERROR_IPSEC_SA_LIFETIME_EXPIRED = 13911,
    [Description("Packet was received on an IPsec SA that does not match the packet characteristics.")]
    ERROR_IPSEC_WRONG_SA = 13912,
    [Description("Packet sequence number replay check failed.")]
    ERROR_IPSEC_REPLAY_CHECK_FAILED = 13913,
    [Description("IPsec header and/or trailer in the packet is invalid.")]
    ERROR_IPSEC_INVALID_PACKET = 13914,
    [Description("IPsec integrity check failed.")]
    ERROR_IPSEC_INTEGRITY_CHECK_FAILED = 13915,
    [Description("IPsec dropped a clear text packet.")]
    ERROR_IPSEC_CLEAR_TEXT_DROP = 13916,
    [Description("IPsec dropped an incoming ESP packet in authenticated firewall mode. This drop is benign.")]
    ERROR_IPSEC_AUTH_FIREWALL_DROP = 13917,
    [Description("IPsec dropped a packet due to DoS throttling.")]
    ERROR_IPSEC_THROTTLE_DROP = 13918,
    [Description("IPsec DoS Protection matched an explicit block rule.")]
    ERROR_IPSEC_DOSP_BLOCK = 13925,
    [Description("IPsec DoS Protection received an IPsec specific multicast packet which is not allowed.")]
    ERROR_IPSEC_DOSP_RECEIVED_MULTICAST = 13926,
    [Description("IPsec DoS Protection received an incorrectly formatted packet.")]
    ERROR_IPSEC_DOSP_INVALID_PACKET = 13927,
    [Description("IPsec DoS Protection failed to look up state.")]
    ERROR_IPSEC_DOSP_STATE_LOOKUP_FAILED = 13928,
    [Description("IPsec DoS Protection failed to create state because the maximum number of entries allowed by policy has been reached.")]
    ERROR_IPSEC_DOSP_MAX_ENTRIES = 13929,
    [Description("IPsec DoS Protection received an IPsec negotiation packet for a keying module which is not allowed by policy.")]
    ERROR_IPSEC_DOSP_KEYMOD_NOT_ALLOWED = 13930,
    [Description("IPsec DoS Protection has not been enabled.")]
    ERROR_IPSEC_DOSP_NOT_INSTALLED = 13931,
    [Description("IPsec DoS Protection failed to create a per internal IP rate limit queue because the maximum number of queues allowed by policy has been reached.")]
    ERROR_IPSEC_DOSP_MAX_PER_IP_RATELIMIT_QUEUES = 13932,
    [Description("The requested section was not present in the activation context.")]
    ERROR_SXS_SECTION_NOT_FOUND = 14000,
    [Description("The application has failed to start because its side-by-side configuration is incorrect. Please see the application event log or use the command-line sxstrace.exe tool for more detail.")]
    ERROR_SXS_CANT_GEN_ACTCTX = 14001,
    [Description("The application binding data format is invalid.")]
    ERROR_SXS_INVALID_ACTCTXDATA_FORMAT = 14002,
    [Description("The referenced assembly is not installed on your system.")]
    ERROR_SXS_ASSEMBLY_NOT_FOUND = 14003,
    [Description("The manifest file does not begin with the required tag and format information.")]
    ERROR_SXS_MANIFEST_FORMAT_ERROR = 14004,
    [Description("The manifest file contains one or more syntax errors.")]
    ERROR_SXS_MANIFEST_PARSE_ERROR = 14005,
    [Description("The application attempted to activate a disabled activation context.")]
    ERROR_SXS_ACTIVATION_CONTEXT_DISABLED = 14006,
    [Description("The requested lookup key was not found in any active activation context.")]
    ERROR_SXS_KEY_NOT_FOUND = 14007,
    [Description("A component version required by the application conflicts with another component version already active.")]
    ERROR_SXS_VERSION_CONFLICT = 14008,
    [Description("The type requested activation context section does not match the query API used.")]
    ERROR_SXS_WRONG_SECTION_TYPE = 14009,
    [Description("Lack of system resources has required isolated activation to be disabled for the current thread of execution.")]
    ERROR_SXS_THREAD_QUERIES_DISABLED = 14010,
    [Description("An attempt to set the process default activation context failed because the process default activation context was already set.")]
    ERROR_SXS_PROCESS_DEFAULT_ALREADY_SET = 14011,
    [Description("The encoding group identifier specified is not recognized.")]
    ERROR_SXS_UNKNOWN_ENCODING_GROUP = 14012,
    [Description("The encoding requested is not recognized.")]
    ERROR_SXS_UNKNOWN_ENCODING = 14013,
    [Description("The manifest contains a reference to an invalid URI.")]
    ERROR_SXS_INVALID_XML_NAMESPACE_URI = 14014,
    [Description("The application manifest contains a reference to a dependent assembly which is not installed.")]
    ERROR_SXS_ROOT_MANIFEST_DEPENDENCY_NOT_INSTALLED = 14015,
    [Description("The manifest for an assembly used by the application has a reference to a dependent assembly which is not installed.")]
    ERROR_SXS_LEAF_MANIFEST_DEPENDENCY_NOT_INSTALLED = 14016,
    [Description("The manifest contains an attribute for the assembly identity which is not valid.")]
    ERROR_SXS_INVALID_ASSEMBLY_IDENTITY_ATTRIBUTE = 14017,
    [Description("The manifest is missing the required default namespace specification on the assembly element.")]
    ERROR_SXS_MANIFEST_MISSING_REQUIRED_DEFAULT_NAMESPACE = 14018,
    [Description("The manifest has a default namespace specified on the assembly element but its value is not \"urn:schemas-microsoft-com:asm.v1\".")]
    ERROR_SXS_MANIFEST_INVALID_REQUIRED_DEFAULT_NAMESPACE = 14019,
    [Description("The private manifest probed has crossed a path with an unsupported reparse point.")]
    ERROR_SXS_PRIVATE_MANIFEST_CROSS_PATH_WITH_REPARSE_POINT = 14020,
    [Description("Two or more components referenced directly or indirectly by the application manifest have files by the same name.")]
    ERROR_SXS_DUPLICATE_DLL_NAME = 14021,
    [Description("Two or more components referenced directly or indirectly by the application manifest have window classes with the same name.")]
    ERROR_SXS_DUPLICATE_WINDOWCLASS_NAME = 14022,
    [Description("Two or more components referenced directly or indirectly by the application manifest have the same COM server CLSIDs.")]
    ERROR_SXS_DUPLICATE_CLSID = 14023,
    [Description("Two or more components referenced directly or indirectly by the application manifest have proxies for the same COM interface IIDs.")]
    ERROR_SXS_DUPLICATE_IID = 14024,
    [Description("Two or more components referenced directly or indirectly by the application manifest have the same COM type library TLBIDs.")]
    ERROR_SXS_DUPLICATE_TLBID = 14025,
    [Description("Two or more components referenced directly or indirectly by the application manifest have the same COM ProgIDs.")]
    ERROR_SXS_DUPLICATE_PROGID = 14026,
    [Description("Two or more components referenced directly or indirectly by the application manifest are different versions of the same component which is not permitted.")]
    ERROR_SXS_DUPLICATE_ASSEMBLY_NAME = 14027,
    [Description("A component's file does not match the verification information present in the component manifest.")]
    ERROR_SXS_FILE_HASH_MISMATCH = 14028,
    [Description("The policy manifest contains one or more syntax errors.")]
    ERROR_SXS_POLICY_PARSE_ERROR = 14029,
    [Description("Manifest Parse Error : A string literal was expected, but no opening quote character was found.")]
    ERROR_SXS_XML_E_MISSINGQUOTE = 14030,
    [Description("Manifest Parse Error : Incorrect syntax was used in a comment.")]
    ERROR_SXS_XML_E_COMMENTSYNTAX = 14031,
    [Description("Manifest Parse Error : A name was started with an invalid character.")]
    ERROR_SXS_XML_E_BADSTARTNAMECHAR = 14032,
    [Description("Manifest Parse Error : A name contained an invalid character.")]
    ERROR_SXS_XML_E_BADNAMECHAR = 14033,
    [Description("Manifest Parse Error : A string literal contained an invalid character.")]
    ERROR_SXS_XML_E_BADCHARINSTRING = 14034,
    [Description("Manifest Parse Error : Invalid syntax for an xml declaration.")]
    ERROR_SXS_XML_E_XMLDECLSYNTAX = 14035,
    [Description("Manifest Parse Error : An Invalid character was found in text content.")]
    ERROR_SXS_XML_E_BADCHARDATA = 14036,
    [Description("Manifest Parse Error : Required white space was missing.")]
    ERROR_SXS_XML_E_MISSINGWHITESPACE = 14037,
    [Description("Manifest Parse Error : The character '>' was expected.")]
    ERROR_SXS_XML_E_EXPECTINGTAGEND = 14038,
    [Description("Manifest Parse Error : A semi colon character was expected.")]
    ERROR_SXS_XML_E_MISSINGSEMICOLON = 14039,
    [Description("Manifest Parse Error : Unbalanced parentheses.")]
    ERROR_SXS_XML_E_UNBALANCEDPAREN = 14040,
    [Description("Manifest Parse Error : Internal error.")]
    ERROR_SXS_XML_E_INTERNALERROR = 14041,
    [Description("Manifest Parse Error : Whitespace is not allowed at this location.")]
    ERROR_SXS_XML_E_UNEXPECTED_WHITESPACE = 14042,
    [Description("Manifest Parse Error : End of file reached in invalid state for current encoding.")]
    ERROR_SXS_XML_E_INCOMPLETE_ENCODING = 14043,
    [Description("Manifest Parse Error : Missing parenthesis.")]
    ERROR_SXS_XML_E_MISSING_PAREN = 14044,
    [Description("Manifest Parse Error : A single or double closing quote character (\\' or \\\") is missing.")]
    ERROR_SXS_XML_E_EXPECTINGCLOSEQUOTE = 14045,
    [Description("Manifest Parse Error : Multiple colons are not allowed in a name.")]
    ERROR_SXS_XML_E_MULTIPLE_COLONS = 14046,
    [Description("Manifest Parse Error : Invalid character for decimal digit.")]
    ERROR_SXS_XML_E_INVALID_DECIMAL = 14047,
    [Description("Manifest Parse Error : Invalid character for hexadecimal digit.")]
    ERROR_SXS_XML_E_INVALID_HEXIDECIMAL = 14048,
    [Description("Manifest Parse Error : Invalid unicode character value for this platform.")]
    ERROR_SXS_XML_E_INVALID_UNICODE = 14049,
    [Description("Manifest Parse Error : Expecting whitespace or '?'.")]
    ERROR_SXS_XML_E_WHITESPACEORQUESTIONMARK = 14050,
    [Description("Manifest Parse Error : End tag was not expected at this location.")]
    ERROR_SXS_XML_E_UNEXPECTEDENDTAG = 14051,
    [Description("Manifest Parse Error : The following tags were not closed: %1.")]
    ERROR_SXS_XML_E_UNCLOSEDTAG = 14052,
    [Description("Manifest Parse Error : Duplicate attribute.")]
    ERROR_SXS_XML_E_DUPLICATEATTRIBUTE = 14053,
    [Description("Manifest Parse Error : Only one top level element is allowed in an XML document.")]
    ERROR_SXS_XML_E_MULTIPLEROOTS = 14054,
    [Description("Manifest Parse Error : Invalid at the top level of the document.")]
    ERROR_SXS_XML_E_INVALIDATROOTLEVEL = 14055,
    [Description("Manifest Parse Error : Invalid xml declaration.")]
    ERROR_SXS_XML_E_BADXMLDECL = 14056,
    [Description("Manifest Parse Error : XML document must have a top level element.")]
    ERROR_SXS_XML_E_MISSINGROOT = 14057,
    [Description("Manifest Parse Error : Unexpected end of file.")]
    ERROR_SXS_XML_E_UNEXPECTEDEOF = 14058,
    [Description("Manifest Parse Error : Parameter entities cannot be used inside markup declarations in an internal subset.")]
    ERROR_SXS_XML_E_BADPEREFINSUBSET = 14059,
    [Description("Manifest Parse Error : Element was not closed.")]
    ERROR_SXS_XML_E_UNCLOSEDSTARTTAG = 14060,
    [Description("Manifest Parse Error : End element was missing the character '>'.")]
    ERROR_SXS_XML_E_UNCLOSEDENDTAG = 14061,
    [Description("Manifest Parse Error : A string literal was not closed.")]
    ERROR_SXS_XML_E_UNCLOSEDSTRING = 14062,
    [Description("Manifest Parse Error : A comment was not closed.")]
    ERROR_SXS_XML_E_UNCLOSEDCOMMENT = 14063,
    [Description("Manifest Parse Error : A declaration was not closed.")]
    ERROR_SXS_XML_E_UNCLOSEDDECL = 14064,
    [Description("Manifest Parse Error : A CDATA section was not closed.")]
    ERROR_SXS_XML_E_UNCLOSEDCDATA = 14065,
    [Description("Manifest Parse Error : The namespace prefix is not allowed to start with the reserved string \"xml\".")]
    ERROR_SXS_XML_E_RESERVEDNAMESPACE = 14066,
    [Description("Manifest Parse Error : System does not support the specified encoding.")]
    ERROR_SXS_XML_E_INVALIDENCODING = 14067,
    [Description("Manifest Parse Error : Switch from current encoding to specified encoding not supported.")]
    ERROR_SXS_XML_E_INVALIDSWITCH = 14068,
    [Description("Manifest Parse Error : The name 'xml' is reserved and must be lower case.")]
    ERROR_SXS_XML_E_BADXMLCASE = 14069,
    [Description("Manifest Parse Error : The standalone attribute must have the value 'yes' or 'no'.")]
    ERROR_SXS_XML_E_INVALID_STANDALONE = 14070,
    [Description("Manifest Parse Error : The standalone attribute cannot be used in external entities.")]
    ERROR_SXS_XML_E_UNEXPECTED_STANDALONE = 14071,
    [Description("Manifest Parse Error : Invalid version number.")]
    ERROR_SXS_XML_E_INVALID_VERSION = 14072,
    [Description("Manifest Parse Error : Missing equals sign between attribute and attribute value.")]
    ERROR_SXS_XML_E_MISSINGEQUALS = 14073,
    [Description("Assembly Protection Error : Unable to recover the specified assembly.")]
    ERROR_SXS_PROTECTION_RECOVERY_FAILED = 14074,
    [Description("Assembly Protection Error : The public key for an assembly was too short to be allowed.")]
    ERROR_SXS_PROTECTION_PUBLIC_KEY_TOO_SHORT = 14075,
    [Description("Assembly Protection Error : The catalog for an assembly is not valid, or does not match the assembly's manifest.")]
    ERROR_SXS_PROTECTION_CATALOG_NOT_VALID = 14076,
    [Description("An HRESULT could not be translated to a corresponding Win32 error code.")]
    ERROR_SXS_UNTRANSLATABLE_HRESULT = 14077,
    [Description("Assembly Protection Error : The catalog for an assembly is missing.")]
    ERROR_SXS_PROTECTION_CATALOG_FILE_MISSING = 14078,
    [Description("The supplied assembly identity is missing one or more attributes which must be present in this context.")]
    ERROR_SXS_MISSING_ASSEMBLY_IDENTITY_ATTRIBUTE = 14079,
    [Description("The supplied assembly identity has one or more attribute names that contain characters not permitted in XML names.")]
    ERROR_SXS_INVALID_ASSEMBLY_IDENTITY_ATTRIBUTE_NAME = 14080,
    [Description("The referenced assembly could not be found.")]
    ERROR_SXS_ASSEMBLY_MISSING = 14081,
    [Description("The activation context activation stack for the running thread of execution is corrupt.")]
    ERROR_SXS_CORRUPT_ACTIVATION_STACK = 14082,
    [Description("The application isolation metadata for this process or thread has become corrupt.")]
    ERROR_SXS_CORRUPTION = 14083,
    [Description("The activation context being deactivated is not the most recently activated one.")]
    ERROR_SXS_EARLY_DEACTIVATION = 14084,
    [Description("The activation context being deactivated is not active for the current thread of execution.")]
    ERROR_SXS_INVALID_DEACTIVATION = 14085,
    [Description("The activation context being deactivated has already been deactivated.")]
    ERROR_SXS_MULTIPLE_DEACTIVATION = 14086,
    [Description("A component used by the isolation facility has requested to terminate the process.")]
    ERROR_SXS_PROCESS_TERMINATION_REQUESTED = 14087,
    [Description("A kernel mode component is releasing a reference on an activation context.")]
    ERROR_SXS_RELEASE_ACTIVATION_CONTEXT = 14088,
    [Description("The activation context of system default assembly could not be generated.")]
    ERROR_SXS_SYSTEM_DEFAULT_ACTIVATION_CONTEXT_EMPTY = 14089,
    [Description("The value of an attribute in an identity is not within the legal range.")]
    ERROR_SXS_INVALID_IDENTITY_ATTRIBUTE_VALUE = 14090,
    [Description("The name of an attribute in an identity is not within the legal range.")]
    ERROR_SXS_INVALID_IDENTITY_ATTRIBUTE_NAME = 14091,
    [Description("An identity contains two definitions for the same attribute.")]
    ERROR_SXS_IDENTITY_DUPLICATE_ATTRIBUTE = 14092,
    [Description("The identity string is malformed. This may be due to a trailing comma, more than two unnamed attributes, missing attribute name or missing attribute value.")]
    ERROR_SXS_IDENTITY_PARSE_ERROR = 14093,
    [Description("A string containing localized substitutable content was malformed. Either a dollar sign ($) was followed by something other than a left parenthesis or another dollar sign or an substitution's right parenthesis was not found.")]
    ERROR_MALFORMED_SUBSTITUTION_STRING = 14094,
    [Description("The public key token does not correspond to the public key specified.")]
    ERROR_SXS_INCORRECT_PUBLIC_KEY_TOKEN = 14095,
    [Description("A substitution string had no mapping.")]
    ERROR_UNMAPPED_SUBSTITUTION_STRING = 14096,
    [Description("The component must be locked before making the request.")]
    ERROR_SXS_ASSEMBLY_NOT_LOCKED = 14097,
    [Description("The component store has been corrupted.")]
    ERROR_SXS_COMPONENT_STORE_CORRUPT = 14098,
    [Description("An advanced installer failed during setup or servicing.")]
    ERROR_ADVANCED_INSTALLER_FAILED = 14099,
    [Description("The character encoding in the XML declaration did not match the encoding used in the document.")]
    ERROR_XML_ENCODING_MISMATCH = 14100,
    [Description("The identities of the manifests are identical but their contents are different.")]
    ERROR_SXS_MANIFEST_IDENTITY_SAME_BUT_CONTENTS_DIFFERENT = 14101,
    [Description("The component identities are different.")]
    ERROR_SXS_IDENTITIES_DIFFERENT = 14102,
    [Description("The assembly is not a deployment.")]
    ERROR_SXS_ASSEMBLY_IS_NOT_A_DEPLOYMENT = 14103,
    [Description("The file is not a part of the assembly.")]
    ERROR_SXS_FILE_NOT_PART_OF_ASSEMBLY = 14104,
    [Description("The size of the manifest exceeds the maximum allowed.")]
    ERROR_SXS_MANIFEST_TOO_BIG = 14105,
    [Description("The setting is not registered.")]
    ERROR_SXS_SETTING_NOT_REGISTERED = 14106,
    [Description("One or more required members of the transaction are not present.")]
    ERROR_SXS_TRANSACTION_CLOSURE_INCOMPLETE = 14107,
    [Description("The SMI primitive installer failed during setup or servicing.")]
    ERROR_SMI_PRIMITIVE_INSTALLER_FAILED = 14108,
    [Description("A generic command executable returned a result that indicates failure.")]
    ERROR_GENERIC_COMMAND_FAILED = 14109,
    [Description("A component is missing file verification information in its manifest.")]
    ERROR_SXS_FILE_HASH_MISSING = 14110,
    [Description("The specified channel path is invalid.")]
    ERROR_EVT_INVALID_CHANNEL_PATH = 15000,
    [Description("The specified query is invalid.")]
    ERROR_EVT_INVALID_QUERY = 15001,
    [Description("The publisher metadata cannot be found in the resource.")]
    ERROR_EVT_PUBLISHER_METADATA_NOT_FOUND = 15002,
    [Description("The template for an event definition cannot be found in the resource (error = %1).")]
    ERROR_EVT_EVENT_TEMPLATE_NOT_FOUND = 15003,
    [Description("The specified publisher name is invalid.")]
    ERROR_EVT_INVALID_PUBLISHER_NAME = 15004,
    [Description("The event data raised by the publisher is not compatible with the event template definition in the publisher's manifest.")]
    ERROR_EVT_INVALID_EVENT_DATA = 15005,
    [Description("The specified channel could not be found. Check channel configuration.")]
    ERROR_EVT_CHANNEL_NOT_FOUND = 15007,
    [Description("The specified xml text was not well-formed. See Extended Error for more details.")]
    ERROR_EVT_MALFORMED_XML_TEXT = 15008,
    [Description("The caller is trying to subscribe to a direct channel which is not allowed. The events for a direct channel go directly to a logfile and cannot be subscribed to.")]
    ERROR_EVT_SUBSCRIPTION_TO_DIRECT_CHANNEL = 15009,
    [Description("Configuration error.")]
    ERROR_EVT_CONFIGURATION_ERROR = 15010,
    [Description("The query result is stale / invalid. This may be due to the log being cleared or rolling over after the query result was created. Users should handle this code by releasing the query result object and reissuing the query.")]
    ERROR_EVT_QUERY_RESULT_STALE = 15011,
    [Description("Query result is currently at an invalid position.")]
    ERROR_EVT_QUERY_RESULT_INVALID_POSITION = 15012,
    [Description("Registered MSXML doesn't support validation.")]
    ERROR_EVT_NON_VALIDATING_MSXML = 15013,
    [Description("An expression can only be followed by a change of scope operation if it itself evaluates to a node set and is not already part of some other change of scope operation.")]
    ERROR_EVT_FILTER_ALREADYSCOPED = 15014,
    [Description("Can't perform a step operation from a term that does not represent an element set.")]
    ERROR_EVT_FILTER_NOTELTSET = 15015,
    [Description("Left hand side arguments to binary operators must be either attributes, nodes or variables and right hand side arguments must be constants.")]
    ERROR_EVT_FILTER_INVARG = 15016,
    [Description("A step operation must involve either a node test or, in the case of a predicate, an algebraic expression against which to test each node in the node set identified by the preceeding node set can be evaluated.")]
    ERROR_EVT_FILTER_INVTEST = 15017,
    [Description("This data type is currently unsupported.")]
    ERROR_EVT_FILTER_INVTYPE = 15018,
    [Description("A syntax error occurred at position %1!d!.")]
    ERROR_EVT_FILTER_PARSEERR = 15019,
    [Description("This operator is unsupported by this implementation of the filter.")]
    ERROR_EVT_FILTER_UNSUPPORTEDOP = 15020,
    [Description("The token encountered was unexpected.")]
    ERROR_EVT_FILTER_UNEXPECTEDTOKEN = 15021,
    [Description("The requested operation cannot be performed over an enabled direct channel. The channel must first be disabled before performing the requested operation.")]
    ERROR_EVT_INVALID_OPERATION_OVER_ENABLED_DIRECT_CHANNEL = 15022,
    [Description("Channel property %1!s! contains invalid value. The value has invalid type, is outside of valid range, can't be updated or is not supported by this type of channel.")]
    ERROR_EVT_INVALID_CHANNEL_PROPERTY_VALUE = 15023,
    [Description("Publisher property %1!s! contains invalid value. The value has invalid type, is outside of valid range, can't be updated or is not supported by this type of publisher.")]
    ERROR_EVT_INVALID_PUBLISHER_PROPERTY_VALUE = 15024,
    [Description("The channel fails to activate.")]
    ERROR_EVT_CHANNEL_CANNOT_ACTIVATE = 15025,
    [Description("The xpath expression exceeded supported complexity. Please symplify it or split it into two or more simple expressions.")]
    ERROR_EVT_FILTER_TOO_COMPLEX = 15026,
    [Description("the message resource is present but the message is not found in the string/message table.")]
    ERROR_EVT_MESSAGE_NOT_FOUND = 15027,
    [Description("The message id for the desired message could not be found.")]
    ERROR_EVT_MESSAGE_ID_NOT_FOUND = 15028,
    [Description("The substitution string for insert index (%1) could not be found.")]
    ERROR_EVT_UNRESOLVED_VALUE_INSERT = 15029,
    [Description("The description string for parameter reference (%1) could not be found.")]
    ERROR_EVT_UNRESOLVED_PARAMETER_INSERT = 15030,
    [Description("The maximum number of replacements has been reached.")]
    ERROR_EVT_MAX_INSERTS_REACHED = 15031,
    [Description("The event definition could not be found for event id (%1).")]
    ERROR_EVT_EVENT_DEFINITION_NOT_FOUND = 15032,
    [Description("The locale specific resource for the desired message is not present.")]
    ERROR_EVT_MESSAGE_LOCALE_NOT_FOUND = 15033,
    [Description("The resource is too old to be compatible.")]
    ERROR_EVT_VERSION_TOO_OLD = 15034,
    [Description("The resource is too new to be compatible.")]
    ERROR_EVT_VERSION_TOO_NEW = 15035,
    [Description("The channel at index %1!d! of the query can't be opened.")]
    ERROR_EVT_CANNOT_OPEN_CHANNEL_OF_QUERY = 15036,
    [Description("The publisher has been disabled and its resource is not available. This usually occurs when the publisher is in the process of being uninstalled or upgraded.")]
    ERROR_EVT_PUBLISHER_DISABLED = 15037,
    [Description("Attempted to create a numeric type that is outside of its valid range.")]
    ERROR_EVT_FILTER_OUT_OF_RANGE = 15038,
    [Description("The subscription fails to activate.")]
    ERROR_EC_SUBSCRIPTION_CANNOT_ACTIVATE = 15080,
    [Description("The log of the subscription is in disabled state, and can not be used to forward events to. The log must first be enabled before the subscription can be activated.")]
    ERROR_EC_LOG_DISABLED = 15081,
    [Description("When forwarding events from local machine to itself, the query of the subscription can't contain target log of the subscription.")]
    ERROR_EC_CIRCULAR_FORWARDING = 15082,
    [Description("The credential store that is used to save credentials is full.")]
    ERROR_EC_CREDSTORE_FULL = 15083,
    [Description("The credential used by this subscription can't be found in credential store.")]
    ERROR_EC_CRED_NOT_FOUND = 15084,
    [Description("No active channel is found for the query.")]
    ERROR_EC_NO_ACTIVE_CHANNEL = 15085,
    [Description("The resource loader failed to find MUI file.")]
    ERROR_MUI_FILE_NOT_FOUND = 15100,
    [Description("The resource loader failed to load MUI file because the file fail to pass validation.")]
    ERROR_MUI_INVALID_FILE = 15101,
    [Description("The RC Manifest is corrupted with garbage data or unsupported version or missing required item.")]
    ERROR_MUI_INVALID_RC_CONFIG = 15102,
    [Description("The RC Manifest has invalid culture name.")]
    ERROR_MUI_INVALID_LOCALE_NAME = 15103,
    [Description("The RC Manifest has invalid ultimatefallback name.")]
    ERROR_MUI_INVALID_ULTIMATEFALLBACK_NAME = 15104,
    [Description("The resource loader cache doesn't have loaded MUI entry.")]
    ERROR_MUI_FILE_NOT_LOADED = 15105,
    [Description("User stopped resource enumeration.")]
    ERROR_RESOURCE_ENUM_USER_STOP = 15106,
    [Description("UI language installation failed.")]
    ERROR_MUI_INTLSETTINGS_UILANG_NOT_INSTALLED = 15107,
    [Description("Locale installation failed.")]
    ERROR_MUI_INTLSETTINGS_INVALID_LOCALE_NAME = 15108,
    [Description("A resource does not have default or neutral value.")]
    ERROR_MRM_RUNTIME_NO_DEFAULT_OR_NEUTRAL_RESOURCE = 15110,
    [Description("Invalid PRI config file.")]
    ERROR_MRM_INVALID_PRICONFIG = 15111,
    [Description("Invalid file type.")]
    ERROR_MRM_INVALID_FILE_TYPE = 15112,
    [Description("Unknown qualifier.")]
    ERROR_MRM_UNKNOWN_QUALIFIER = 15113,
    [Description("Invalid qualifier value.")]
    ERROR_MRM_INVALID_QUALIFIER_VALUE = 15114,
    [Description("No Candidate found.")]
    ERROR_MRM_NO_CANDIDATE = 15115,
    [Description("The ResourceMap or NamedResource has an item that does not have default or neutral resource..")]
    ERROR_MRM_NO_MATCH_OR_DEFAULT_CANDIDATE = 15116,
    [Description("Invalid ResourceCandidate type.")]
    ERROR_MRM_RESOURCE_TYPE_MISMATCH = 15117,
    [Description("Duplicate Resource Map.")]
    ERROR_MRM_DUPLICATE_MAP_NAME = 15118,
    [Description("Duplicate Entry.")]
    ERROR_MRM_DUPLICATE_ENTRY = 15119,
    [Description("Invalid Resource Identifier.")]
    ERROR_MRM_INVALID_RESOURCE_IDENTIFIER = 15120,
    [Description("Filepath too long.")]
    ERROR_MRM_FILEPATH_TOO_LONG = 15121,
    [Description("Unsupported directory type.")]
    ERROR_MRM_UNSUPPORTED_DIRECTORY_TYPE = 15122,
    [Description("Invalid PRI File.")]
    ERROR_MRM_INVALID_PRI_FILE = 15126,
    [Description("NamedResource Not Found.")]
    ERROR_MRM_NAMED_RESOURCE_NOT_FOUND = 15127,
    [Description("ResourceMap Not Found.")]
    ERROR_MRM_MAP_NOT_FOUND = 15135,
    [Description("Unsupported MRT profile type.")]
    ERROR_MRM_UNSUPPORTED_PROFILE_TYPE = 15136,
    [Description("Invalid qualifier operator.")]
    ERROR_MRM_INVALID_QUALIFIER_OPERATOR = 15137,
    [Description("Unable to determine qualifier value or qualifier value has not been set.")]
    ERROR_MRM_INDETERMINATE_QUALIFIER_VALUE = 15138,
    [Description("Automerge is enabled in the PRI file.")]
    ERROR_MRM_AUTOMERGE_ENABLED = 15139,
    [Description("Too many resources defined for package.")]
    ERROR_MRM_TOO_MANY_RESOURCES = 15140,
    [Description("The monitor returned a DDC/CI capabilities string that did not comply with the ACCESS.bus 3.0, DDC/CI 1.1 or MCCS 2 Revision 1 specification.")]
    ERROR_MCA_INVALID_CAPABILITIES_STRING = 15200,
    [Description("The monitor's VCP Version (0xDF) VCP code returned an invalid version value.")]
    ERROR_MCA_INVALID_VCP_VERSION = 15201,
    [Description("The monitor does not comply with the MCCS specification it claims to support.")]
    ERROR_MCA_MONITOR_VIOLATES_MCCS_SPECIFICATION = 15202,
    [Description("The MCCS version in a monitor's mccs_ver capability does not match the MCCS version the monitor reports when the VCP Version (0xDF) VCP code is used.")]
    ERROR_MCA_MCCS_VERSION_MISMATCH = 15203,
    [Description("The Monitor Configuration API only works with monitors that support the MCCS 1.0 specification, MCCS 2.0 specification or the MCCS 2.0 Revision 1 specification.")]
    ERROR_MCA_UNSUPPORTED_MCCS_VERSION = 15204,
    [Description("An internal Monitor Configuration API error occurred.")]
    ERROR_MCA_INTERNAL_ERROR = 15205,
    [Description("The monitor returned an invalid monitor technology type. CRT, Plasma and LCD (TFT) are examples of monitor technology types. This error implies that the monitor violated the MCCS 2.0 or MCCS 2.0 Revision 1 specification.")]
    ERROR_MCA_INVALID_TECHNOLOGY_TYPE_RETURNED = 15206,
    [Description("The caller of SetMonitorColorTemperature specified a color temperature that the current monitor did not support. This error implies that the monitor violated the MCCS 2.0 or MCCS 2.0 Revision 1 specification.")]
    ERROR_MCA_UNSUPPORTED_COLOR_TEMPERATURE = 15207,
    [Description("The requested system device cannot be identified due to multiple indistinguishable devices potentially matching the identification criteria.")]
    ERROR_AMBIGUOUS_SYSTEM_DEVICE = 15250,
    [Description("The requested system device cannot be found.")]
    ERROR_SYSTEM_DEVICE_NOT_FOUND = 15299,
    [Description("Hash generation for the specified hash version and hash type is not enabled on the server.")]
    ERROR_HASH_NOT_SUPPORTED = 15300,
    [Description("The hash requested from the server is not available or no longer valid.")]
    ERROR_HASH_NOT_PRESENT = 15301,
    [Description("The secondary interrupt controller instance that manages the specified interrupt is not registered.")]
    ERROR_SECONDARY_IC_PROVIDER_NOT_REGISTERED = 15321,
    [Description("The information supplied by the GPIO client driver is invalid.")]
    ERROR_GPIO_CLIENT_INFORMATION_INVALID = 15322,
    [Description("The version specified by the GPIO client driver is not supported.")]
    ERROR_GPIO_VERSION_NOT_SUPPORTED = 15323,
    [Description("The registration packet supplied by the GPIO client driver is not valid.")]
    ERROR_GPIO_INVALID_REGISTRATION_PACKET = 15324,
    [Description("The requested operation is not suppported for the specified handle.")]
    ERROR_GPIO_OPERATION_DENIED = 15325,
    [Description("The requested connect mode conflicts with an existing mode on one or more of the specified pins.")]
    ERROR_GPIO_INCOMPATIBLE_CONNECT_MODE = 15326,
    [Description("The interrupt requested to be unmasked is not masked.")]
    ERROR_GPIO_INTERRUPT_ALREADY_UNMASKED = 15327,
    [Description("The requested run level switch cannot be completed successfully.")]
    ERROR_CANNOT_SWITCH_RUNLEVEL = 15400,
    [Description("The service has an invalid run level setting. The run level for a service must not be higher than the run level of its dependent services.")]
    ERROR_INVALID_RUNLEVEL_SETTING = 15401,
    [Description("The requested run level switch cannot be completed successfully since one or more services will not stop or restart within the specified timeout.")]
    ERROR_RUNLEVEL_SWITCH_TIMEOUT = 15402,
    [Description("A run level switch agent did not respond within the specified timeout.")]
    ERROR_RUNLEVEL_SWITCH_AGENT_TIMEOUT = 15403,
    [Description("A run level switch is currently in progress.")]
    ERROR_RUNLEVEL_SWITCH_IN_PROGRESS = 15404,
    [Description("One or more services failed to start during the service startup phase of a run level switch.")]
    ERROR_SERVICES_FAILED_AUTOSTART = 15405,
    [Description("The task stop request cannot be completed immediately since task needs more time to shutdown.")]
    ERROR_COM_TASK_STOP_PENDING = 15501,
    [Description("Package could not be opened.")]
    ERROR_INSTALL_OPEN_PACKAGE_FAILED = 15600,
    [Description("Package was not found.")]
    ERROR_INSTALL_PACKAGE_NOT_FOUND = 15601,
    [Description("Package data is invalid.")]
    ERROR_INSTALL_INVALID_PACKAGE = 15602,
    [Description("Package failed updates, dependency or conflict validation.")]
    ERROR_INSTALL_RESOLVE_DEPENDENCY_FAILED = 15603,
    [Description("There is not enough disk space on your computer. Please free up some space and try again.")]
    ERROR_INSTALL_OUT_OF_DISK_SPACE = 15604,
    [Description("There was a problem downloading your product.")]
    ERROR_INSTALL_NETWORK_FAILURE = 15605,
    [Description("Package could not be registered.")]
    ERROR_INSTALL_REGISTRATION_FAILURE = 15606,
    [Description("Package could not be unregistered.")]
    ERROR_INSTALL_DEREGISTRATION_FAILURE = 15607,
    [Description("User cancelled the install request.")]
    ERROR_INSTALL_CANCEL = 15608,
    [Description("Install failed. Please contact your software vendor.")]
    ERROR_INSTALL_FAILED = 15609,
    [Description("Removal failed. Please contact your software vendor.")]
    ERROR_REMOVE_FAILED = 15610,
    [Description("The provided package is already installed, and reinstallation of the package was blocked. Check the AppXDeployment-Server event log for details.")]
    ERROR_PACKAGE_ALREADY_EXISTS = 15611,
    [Description("The application cannot be started. Try reinstalling the application to fix the problem.")]
    ERROR_NEEDS_REMEDIATION = 15612,
    [Description("A Prerequisite for an install could not be satisfied.")]
    ERROR_INSTALL_PREREQUISITE_FAILED = 15613,
    [Description("The package repository is corrupted.")]
    ERROR_PACKAGE_REPOSITORY_CORRUPTED = 15614,
    [Description("To install this application you need either a Windows developer license or a sideloading-enabled system.")]
    ERROR_INSTALL_POLICY_FAILURE = 15615,
    [Description("The application cannot be started because it is currently updating.")]
    ERROR_PACKAGE_UPDATING = 15616,
    [Description("The package deployment operation is blocked by policy. Please contact your system administrator.")]
    ERROR_DEPLOYMENT_BLOCKED_BY_POLICY = 15617,
    [Description("The package could not be installed because resources it modifies are currently in use.")]
    ERROR_PACKAGES_IN_USE = 15618,
    [Description("The package could not be recovered because necessary data for recovery have been corrupted.")]
    ERROR_RECOVERY_FILE_CORRUPT = 15619,
    [Description("The signature is invalid. To register in developer mode, AppxSignature.p7x and AppxBlockMap.xml must be valid or should not be present.")]
    ERROR_INVALID_STAGED_SIGNATURE = 15620,
    [Description("An error occurred while deleting the package's previously existing application data.")]
    ERROR_DELETING_EXISTING_APPLICATIONDATA_STORE_FAILED = 15621,
    [Description("The package could not be installed because a higher version of this package is already installed.")]
    ERROR_INSTALL_PACKAGE_DOWNGRADE = 15622,
    [Description("An error in a system binary was detected. Try refreshing the PC to fix the problem.")]
    ERROR_SYSTEM_NEEDS_REMEDIATION = 15623,
    [Description("A corrupted CLR NGEN binary was detected on the system.")]
    ERROR_APPX_INTEGRITY_FAILURE_CLR_NGEN = 15624,
    [Description("The operation could not be resumed because necessary data for recovery have been corrupted.")]
    ERROR_RESILIENCY_FILE_CORRUPT = 15625,
    [Description("The package could not be installed because the Windows Firewall service is not running. Enable the Windows Firewall service and try again.")]
    ERROR_INSTALL_FIREWALL_SERVICE_NOT_RUNNING = 15626,
    [Description("The process has no package identity.")]
    APPMODEL_ERROR_NO_PACKAGE = 15700,
    [Description("The package runtime information is corrupted.")]
    APPMODEL_ERROR_PACKAGE_RUNTIME_CORRUPT = 15701,
    [Description("The package identity is corrupted.")]
    APPMODEL_ERROR_PACKAGE_IDENTITY_CORRUPT = 15702,
    [Description("The process has no application identity.")]
    APPMODEL_ERROR_NO_APPLICATION = 15703,
    [Description("Loading the state store failed.")]
    ERROR_STATE_LOAD_STORE_FAILED = 15800,
    [Description("Retrieving the state version for the application failed.")]
    ERROR_STATE_GET_VERSION_FAILED = 15801,
    [Description("Setting the state version for the application failed.")]
    ERROR_STATE_SET_VERSION_FAILED = 15802,
    [Description("Resetting the structured state of the application failed.")]
    ERROR_STATE_STRUCTURED_RESET_FAILED = 15803,
    [Description("State Manager failed to open the container.")]
    ERROR_STATE_OPEN_CONTAINER_FAILED = 15804,
    [Description("State Manager failed to create the container.")]
    ERROR_STATE_CREATE_CONTAINER_FAILED = 15805,
    [Description("State Manager failed to delete the container.")]
    ERROR_STATE_DELETE_CONTAINER_FAILED = 15806,
    [Description("State Manager failed to read the setting.")]
    ERROR_STATE_READ_SETTING_FAILED = 15807,
    [Description("State Manager failed to write the setting.")]
    ERROR_STATE_WRITE_SETTING_FAILED = 15808,
    [Description("State Manager failed to delete the setting.")]
    ERROR_STATE_DELETE_SETTING_FAILED = 15809,
    [Description("State Manager failed to query the setting.")]
    ERROR_STATE_QUERY_SETTING_FAILED = 15810,
    [Description("State Manager failed to read the composite setting.")]
    ERROR_STATE_READ_COMPOSITE_SETTING_FAILED = 15811,
    [Description("State Manager failed to write the composite setting.")]
    ERROR_STATE_WRITE_COMPOSITE_SETTING_FAILED = 15812,
    [Description("State Manager failed to enumerate the containers.")]
    ERROR_STATE_ENUMERATE_CONTAINER_FAILED = 15813,
    [Description("State Manager failed to enumerate the settings.")]
    ERROR_STATE_ENUMERATE_SETTINGS_FAILED = 15814,
    [Description("The size of the state manager composite setting value has exceeded the limit.")]
    ERROR_STATE_COMPOSITE_SETTING_VALUE_SIZE_LIMIT_EXCEEDED = 15815,
    [Description("The size of the state manager setting value has exceeded the limit.")]
    ERROR_STATE_SETTING_VALUE_SIZE_LIMIT_EXCEEDED = 15816,
    [Description("The length of the state manager setting name has exceeded the limit.")]
    ERROR_STATE_SETTING_NAME_SIZE_LIMIT_EXCEEDED = 15817,
    [Description("The length of the state manager container name has exceeded the limit.")]
    ERROR_STATE_CONTAINER_NAME_SIZE_LIMIT_EXCEEDED = 15818,
    [Description("This API cannot be used in the context of the caller's application type.")]
    ERROR_API_UNAVAILABLE = 15841
}
