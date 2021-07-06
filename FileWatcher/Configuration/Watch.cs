﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TE.FileWatcher.Configuration
{
    /// <summary>
    /// The watch element in the XML file.
    /// </summary>
    public class Watch
    {
        /// <summary>
        /// Gets or sets the path of the watch.
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the exclusions
        /// </summary>
        [XmlElement("exclusions")]
        public Exclusions.Exclusions Exclusions { get; set; } = new Exclusions.Exclusions();

        /// <summary>
        /// Gets or sets the notifications for the watch.
        /// </summary>
        [XmlElement("notifications")]
        public Notifications.Notifications Notifications { get; set; } = new Notifications.Notifications();

        /// <summary>
        /// Gets or sets the actions for the watch.
        /// </summary>
        [XmlElement("actions")]
        public Actions.Actions Actions { get; set; } = new Actions.Actions();
    }
}
