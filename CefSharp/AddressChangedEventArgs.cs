﻿// Copyright © 2010-2014 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using System;

namespace CefSharp
{
    /// <summary>
    /// Event arguments to the AddressChanged event handler.
    /// </summary>
    public class AddressChangedEventArgs : EventArgs
    {
        public string Address { get; private set; }

        public AddressChangedEventArgs(string address)
        {
            Address = address;
        }
    };

    /// <summary>
    /// A delegate type used to listen to AddressChanged events.
    /// </summary>
    /// <param name="sender">The object that raised the event.</param>
    /// <param name="e">The event arguments.</param>
    public delegate void AddressChangedEventHandler(object sender, AddressChangedEventArgs args);
}
