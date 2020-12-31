﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XstReader.XstData.Properties
{
    internal enum EpropertyTag : UInt16
    {
        PidTagDisplayName = 0x3001,

        // Root folder
        PidTagRecordKey = 0x0FF9,
        PidTagIpmSubTreeEntryId = 0x35E0,

        // Folder
        PidTagContentCount = 0x3602,
        PidTagSubfolders = 0x360A,

        // Message List
        PidTagSubjectW = 0x0037,
        PidTagDisplayCcW = 0x0E03,
        PidTagDisplayToW = 0x0E04,
        PidTagMessageFlags = 0x0E07,
        PidTagMessageDeliveryTime = 0x0E06,
        PidTagReceivedByName = 0x0040,
        PidTagSentRepresentingNameW = 0x0042,
        PidTagSentRepresentingEmailAddress = 0x0065,
        PidTagSenderName = 0x0C1A,
        PidTagClientSubmitTime = 0x0039,
        PidTagLastModificationTime = 0x3008,

        // Message body
        PidTagNativeBody = 0x1016,
        PidTagBody = 0x1000,
        PidTagInternetCodepage = 0x3FDE,
        PidTagHtml = 0x1013,
        PidTagRtfCompressed = 0x1009,

        // Recipient
        PidTagRecipientType = 0x0c15,
        PidTagEmailAddress = 0x3003,

        // Attachment
        PidTagAttachFilenameW = 0x3704,
        PidTagAttachLongFilename = 0x3707,
        PidTagAttachmentSize = 0x0E20,
        PidTagAttachMethod = 0x3705,
        PidTagAttachMimeTag = 0x370e,
        PidTagAttachContentId = 0x3712,
        PidTagAttachFlags = 0x3714,
        PidTagAttachPayloadClass = 0x371a,
        PidTagAttachDataBinary = 0x3701,
        PidTagAttachmentHidden = 0x7ffe,
        //PidTagAttachDataObject = 0x3701,

        // Named properties
        PidTagNameidStreamGuid = 0x0002,
        PidTagNameidStreamEntry = 0x0003,
        PidTagNameidStreamString = 0x0004,
    }

}
