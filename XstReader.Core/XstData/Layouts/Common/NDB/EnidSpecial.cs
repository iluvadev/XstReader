using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XstReader.XstData.Layouts.Common.NDB
{
    internal enum EnidSpecial : uint
    {
        NID_MESSAGE_STORE = 0x21,
        NID_NAME_TO_ID_MAP = 0x61,
        NID_NORMAL_FOLDER_TEMPLATE = 0xa1,
        NID_SEARCH_FOLDER_TEMPLATE = 0xc1,
        NID_ROOT_FOLDER = 0x122,
        NID_SEARCH_MANAGEMENT_QUEUE = 0x1e1,
        NID_SEARCH_ACTIVITY_LIST = 0x201,
        NID_SEARCH_DOMAIN_OBJECT = 0x261,
        NID_SEARCH_GATHERER_QUEUE = 0x281,
        NID_SEARCH_GATHERER_DESCRIPTOR = 0x2a1,
        NID_SEARCH_GATHERER_FOLDER_QUEUE = 0x321,
        NID_ATTACHMENT_TABLE = 0x671,
        NID_RECIPIENT_TABLE = 0x692,
    }

}
