﻿using System;
using System.Collections.Generic;
using MediaPortal.GUI.Library;
using MediaPortal.Configuration;
using System.Collections;
using System.Linq;

namespace WifiRemote
{
    /// <summary>
    /// Message containing all plugins installed on the htpc
    /// </summary>
    class MessagePlugins : IMessage
    {
        public string Type
        {
            get { return "plugins"; }
        }

        ArrayList plugins;
        /// <summary>
        /// A list of installed and active window plugins.
        /// </summary>
        public ArrayList Plugins
        {
            get { return plugins; }
        }

        /// <summary>
        /// Contructor.
        /// </summary>
        public MessagePlugins(bool sendIcons)
        {
            plugins = WifiRemote.GetActiveWindowPluginsAndIDs(sendIcons);
        }
    }
}
