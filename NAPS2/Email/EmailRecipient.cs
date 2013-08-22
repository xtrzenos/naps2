﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace NAPS2.Email
{
    public class EmailRecipient
    {
        public EmailRecipient()
        {
            Name = "";
        }

        /// <summary>
        /// Gets or sets the recipient's name. Can be empty but must not be null.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the recipient's email address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the type of recipient ("to", "cc", "bcc").
        /// </summary>
        public EmailRecipientType Type { get; set; }
    }
}