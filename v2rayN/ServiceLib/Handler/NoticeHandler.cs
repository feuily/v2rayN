﻿using ReactiveUI;

namespace ServiceLib.Handler
{
    public class NoticeHandler
    {
        public void Enqueue(string? content)
        {
            if (content.IsNullOrEmpty())
            {
                return;
            }
            MessageBus.Current.SendMessage(content, Global.CommandSendSnackMsg);
        }

        public void SendMessage(string? content)
        {
            if (content.IsNullOrEmpty())
            {
                return;
            }
            MessageBus.Current.SendMessage(content, Global.CommandSendMsgView);
        }

        public void SendMessageEx(string? content)
        {
            if (content.IsNullOrEmpty())
            {
                return;
            }
            content = $"{DateTime.Now:yyyy/MM/dd HH:mm:ss} {content}";
            SendMessage(content);
        }

        public void SendMessageAndEnqueue(string? msg)
        {
            Enqueue(msg);
            SendMessage(msg);
        }
    }
}