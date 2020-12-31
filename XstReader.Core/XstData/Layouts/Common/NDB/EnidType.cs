using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XstReader.XstData.Layouts.Common.NDB
{
    internal enum EnidType : byte
    {
        HID = 0x00,   // Heap node
        INTERNAL = 0x01,   // Internal node
        NORMAL_FOLDER = 0x02,  // Normal Folder object
        SEARCH_FOLDER = 0x03,  // Search Folder object
        NORMAL_MESSAGE = 0x04,
        ATTACHMENT = 0x05,
        SEARCH_UPDATE_QUEUE = 0x06,
        SEARCH_CRITERIA_OBJECT = 0x07,
        ASSOC_MESSAGE = 0x08,   // Folder associated information (FAI) Message object
        CONTENTS_TABLE_INDEX = 0x0a, // Internal, persisted view-related
        RECEIVE_FOLDER_TABLE = 0x0b, // Receive Folder object (Inbox)
        OUTGOING_QUEUE_TABLE = 0x0c, // Outbound queue (Outbox)
        HIERARCHY_TABLE = 0x0d,
        CONTENTS_TABLE = 0x0e,
        ASSOC_CONTENTS_TABLE = 0x0f,   // FAI contents table
        SEARCH_CONTENTS_TABLE = 0x10,   // Contents table (TC) of a search Folder object
        ATTACHMENT_TABLE = 0x11,
        RECIPIENT_TABLE = 0x12,
        SEARCH_TABLE_INDEX = 0x13,  // Internal, persisted view-related
        LTP = 0x1f,
    }

}
