using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using SlackModel.Core.Model;

namespace SlackModel.Core.Extensions
{
    public static class ModelExtensions
    {
        public static SlackMessage AddAttachment(this SlackMessage message, SlackAttachment attachment)
        {
            if (message.Attachments == null) message.Attachments = new List<SlackAttachment>();
            message.Attachments.Add(attachment);
            return message;
        }

        public static SlackMessage AddField(this SlackMessage message, SlackField attachment)
        {
            return message;
        }

        public static object ToJObject(this SlackMessage message)
        {
            return JObject.FromObject(message);
        }

        public static void SetFooterTimestamp(this SlackAttachment attachment, DateTime datetime)
        {
            TimeSpan t = datetime - new DateTime(1970, 1, 1);
            int secondsSinceEpoch = (int)t.TotalSeconds;
            attachment.FooterTimestamp = secondsSinceEpoch;
        }
    }
}
