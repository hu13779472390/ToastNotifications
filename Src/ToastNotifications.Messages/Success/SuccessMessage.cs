﻿using System.Windows;
using ToastNotifications.Messages.Core;

namespace ToastNotifications.Messages.Success
{
    public class SuccessMessage : MessageBase<SuccessDisplayPart>
    {
        public SuccessMessage(string message) : this(message, new MessageOptions())
        {
        }

        public SuccessMessage(string message, MessageOptions options) : base(message, options)
        {
        }

        protected override SuccessDisplayPart CreateDisplayPart()
        {
            return new SuccessDisplayPart(this);
        }

        protected override void UpdateDisplayOptions(SuccessDisplayPart displayPart, MessageOptions options)
        {
            if (options.FontSize != null)
                displayPart.Text.FontSize = options.FontSize.Value;

            if (options.ShowCloseButton != null)
                displayPart.CloseButton.Visibility = options.ShowCloseButton.Value ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}