﻿//
// Copyright (c) 2018 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

namespace nanoFramework.Devices.Can
{
    /// <summary>
    /// CAN message frame type.
    /// </summary>
    public enum CanMessageFrameType
    {
        /// <summary>
        /// Data frame.
        /// </summary>
        Data = 0,

        /// <summary>
        /// Remote request frame.
        /// </summary>
        RemoteRequest
    }
}
