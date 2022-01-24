using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Global
{
    public class Enums
    {
        public enum eLoginStatus
        {
            LOGIN_FAILURE = 0,
            LOGIN_SUCCESS = 1
        }

        public enum eUWUserType
        {
            TYPE_ADMIN = 1,
            TYPE_APPROVER = 2,
            TYPE_UWUSER = 3,
            TYPE_IA = 4,
            TYPE_CMDMAN = 5
        }

        public enum eDecision
        {
            RETURN = 0,
            APPROVE = 1,
            NONE = 2
        }

        public enum eStatus
        {
            DRAFT = 1,
            SUBMITTED = 2,
            COMPLETE = 3,
            ARCHIVED = 4
        }

        public enum ePriority{
            NORMAL = 0,
            HOT = 1
        }

    }
}
